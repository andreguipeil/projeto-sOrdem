Imports System.Data.OleDb

'
'Esta Classe contém os metodos necessarios para manipular os clientes.
' aqui estao os metodos de acesso ao banco de dados do sistema
' herda a classe programa model
'======================================================================================
Public Class clienteModel

    Inherits programaModel

    ' FUNCAO getClienteByRg
    ' @param rg
    ' @return cliente
    '==================================================================================================
    Public Function getClienteByNome(ByVal nome As String) As Cliente
        Try
            Dim dr As OleDb.OleDbDataReader
            Dim cliente As New Cliente()
            Dim query As String = "SELECT * FROM  pessoas WHERE nome LIKE '" & nome & "'"

            Conectar()
            dr = retornaQuery(query)

            If dr.HasRows Then                                  ' se tem linhas no objeto (retorno da query)
                While dr.Read                                   'enquanto nao chega ao final do bjeto (dados da query)
                    cliente.id = dr.Item("id")
                    cliente.nome = dr.Item("nome")
                    cliente.rg = dr.Item("rg")
                    cliente.cpf = dr.Item("cpf")
                    cliente.endereco = dr.Item("endereco")
                    cliente.cep = dr.Item("cep")
                    cliente.email = dr.Item("email")
                    cliente.telefone_1 = dr.Item("telefone_1")
                    cliente.ddd_1 = dr.Item("ddd_1")
                    cliente.telefone_2 = dr.Item("telefone_2")
                    cliente.ddd_2 = dr.Item("ddd_2")
                    cliente.telefone_3 = dr.Item("telefone_3")
                    cliente.ddd_3 = dr.Item("ddd_3")
                    Exit While
                End While
            End If
            Desconectar()
            Return cliente
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' FUNCAO getClienteById
    ' @param id
    ' @return cliente
    '==================================================================================================
    Public Function getClienteById(ByVal id As Integer) As Cliente
        Try
            Dim dr As OleDb.OleDbDataReader
            Dim cliente As New Cliente()
            Dim query As String = "SELECT * FROM clientes as c INNER JOIN pessoas as p on c.pessoa_id = p.id WHERE c.id = " & id.ToString

            Conectar()
            dr = retornaQuery(query)

            If dr.HasRows Then                                      ' se tem linhas no objeto (retorno da query)
                While dr.Read                                       'enquanto nao chega ao final do bjeto (dados da query)
                    cliente.id = dr.Item("c.id")
                    cliente.nome = dr.Item("nome")
                    cliente.rg = dr.Item("rg")
                    cliente.pessoa_id = dr.Item("pessoa_id")
                    cliente.cpf = dr.Item("cpf")
                    cliente.endereco = dr.Item("endereco")
                    cliente.cep = dr.Item("cep")
                    cliente.email = dr.Item("email")
                    cliente.ddd_1 = dr.Item("ddd_1")
                    cliente.telefone_1 = dr.Item("telefone_1")
                    cliente.ddd_2 = dr.Item("ddd_2")
                    cliente.telefone_2 = dr.Item("telefone_2")
                    cliente.ddd_3 = dr.Item("ddd_3")
                    cliente.telefone_3 = dr.Item("telefone_3")
                    cliente.usuario_id = dr.Item("usuario_id")
                    cliente.dt_cadastro = dr.Item("dt_cadastro")
                    cliente.dt_alteracao = dr.Item("dt_alteracao")
                    Exit While
                End While
            End If
            Desconectar()
            Return cliente
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function


    ' FUNCAO getCliente
    ' @param id
    ' @return ds type dataSet
    '======================================================================================
    Public Function getCliente(ByVal id As Integer) As DataSet
        Try
            Dim sql As String = "SELECT * FROM clientes as c INNER JOIN pessoas as p on c.pessoa_id = p.id WHERE c.id =" & id.ToString
            Dim sa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conexao)
            Dim ds As New DataSet

            Try
                sa.Fill(ds, "clientes")
            Finally
                sa.Dispose()
            End Try

            Return ds
        Finally
            Desconectar()
        End Try
    End Function

    'FUNCAO getClientes
    '@param cliente => recebe alguns atributos de cliente para filtrar a pesquisa
    '@return dataReader => dataReader contém todos os valores da pesquisa
    '============================================================================================
    Public Function getClientesRpt(ByVal parametros As Cliente) As OleDbDataReader
        Try
            Dim clientes As OleDb.OleDbDataReader
            Dim gridFiltroSql As String

            gridFiltroSql = "SELECT c.id, p.nome, p.rg, p.cpf, p.email, ('('&p.ddd_1&')'&p.telefone_1) as telefone_1, ('('&p.ddd_2&')'&p.telefone_2) as telefone_2, ('('&p.ddd_3&')'&p.telefone_3) as telefone_3, p.endereco, p.cep, p.dt_cadastro, c.dt_alteracao, u.username AS usuario " &
                            " FROM pessoas as p " &
                            " INNER JOIN (clientes as c" &
                            " INNER JOIN usuarios as u" &
                            " ON u.id = c.usuario_id)" &
                            " ON p.id = c.pessoa_id"

            Dim flag As Integer = 0

            '============================================
            If String.IsNullOrEmpty(parametros.nome) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.nome LIKE '%" & parametros.nome & "%'"
                    flag = 1
                Else
                    gridFiltroSql = gridFiltroSql & " WHERE p.nome LIKE '%" & parametros.nome & "%'"
                End If
            End If

            '=============================================
            If String.IsNullOrEmpty(parametros.rg) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.rg LIKE '%" & parametros.rg & "%'"
                    flag = 1
                Else
                    gridFiltroSql = gridFiltroSql & " AND p.rg LIKE '%" & parametros.rg & "%'"
                End If
            End If

            '=============================================
            If String.IsNullOrEmpty(parametros.cpf) = False Then
                Dim clienteCpf As String = Replace(Replace(Replace((parametros.cpf), "-", ""), ",", ""), " ", "")

                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.cpf LIKE '%" & clienteCpf & "%'"
                    flag = 1
                Else
                    gridFiltroSql = gridFiltroSql & " AND p.cpf LIKE '%" & clienteCpf & "%'"
                End If
            End If

            '==============================================
            If String.IsNullOrEmpty(parametros.email) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.email LIKE '%" & parametros.email & "%'"
                    flag = 1
                Else
                    gridFiltroSql = gridFiltroSql & " AND p.email LIKE '%" & parametros.email & "%'"
                End If
            End If

            Conectar()
            clientes = retornaQuery(gridFiltroSql)
            'Desconectar()
            Return clientes
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function


    'FUNCAO getClientes
    '@param cliente => recebe alguns atributos de cliente para filtrar a pesquisa
    '@return myDataTable => myDataTable contém todos os valores da pesquisa
    '============================================================================================
    Public Function getClientes(ByVal parametros As Cliente) As DataTable
        Try
            Dim DataReader As OleDb.OleDbDataReader
            Dim myDataTable As New DataTable
            Dim gridFiltroSql As String

            gridFiltroSql = "SELECT c.id, p.nome, p.rg, p.cpf, p.email, ('('&p.ddd_1&')'&p.telefone_1) as telefone_1, ('('&p.ddd_2&')'&p.telefone_2) as telefone_2, ('('&p.ddd_3&')'&p.telefone_3) as telefone_3, p.endereco, p.cep, p.dt_cadastro, c.dt_alteracao, u.username AS usuario " &
                            " FROM pessoas as p " &
                            " INNER JOIN (clientes as c" &
                            " INNER JOIN usuarios as u" &
                            " ON u.id = c.usuario_id)" &
                            " ON p.id = c.pessoa_id"

            Dim flag As Integer = 0

            '============================================
            If String.IsNullOrEmpty(parametros.nome) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.nome LIKE '%" & parametros.nome & "%'"
                    flag = 1
                Else
                    gridFiltroSql = gridFiltroSql & " WHERE p.nome LIKE '%" & parametros.nome & "%'"
                End If
            End If

            '=============================================
            If String.IsNullOrEmpty(parametros.rg) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.rg LIKE '%" & parametros.rg & "%'"
                    flag = 1
                Else
                    gridFiltroSql = gridFiltroSql & " AND p.rg LIKE '%" & parametros.rg & "%'"
                End If
            End If

            '=============================================
            If String.IsNullOrEmpty(parametros.cpf) = False Then
                Dim clienteCpf As String = Replace(Replace(Replace((parametros.cpf), "-", ""), ",", ""), " ", "")

                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.cpf LIKE '%" & clienteCpf & "%'"
                    flag = 1
                Else
                    gridFiltroSql = gridFiltroSql & " AND p.cpf LIKE '%" & clienteCpf & "%'"
                End If
            End If

            '==============================================
            If String.IsNullOrEmpty(parametros.email) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.email LIKE '%" & parametros.email & "%'"
                    flag = 1
                Else
                    gridFiltroSql = gridFiltroSql & " AND p.email LIKE '%" & parametros.email & "%'"
                End If
            End If

            Conectar()
            DataReader = retornaQuery(gridFiltroSql)
            myDataTable.Load(DataReader)
            Desconectar()
            Return myDataTable
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' FUNCAO insereCliente
    ' @param cliente 
    ' @return true or false 
    '====================================================================================
    Public Function inserirCliente(ByVal cliente As Cliente) As Boolean
        Try
            Dim cmd As New OleDbCommand("INSERT INTO pessoas (nome , rg , cpf, ddd_1, telefone_1, ddd_2, telefone_2, ddd_3,telefone_3, email, endereco, cep, dt_cadastro ) VALUES ( ? , ? , ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexao)

            cmd.Parameters.Add(New OleDbParameter("nome", cliente.nome))
            cmd.Parameters.Add(New OleDbParameter("rg", cliente.rg))
            cmd.Parameters.Add(New OleDbParameter("cpf", cliente.cpf))
            cmd.Parameters.Add(New OleDbParameter("ddd_1", cliente.ddd_1))
            cmd.Parameters.Add(New OleDbParameter("telefone_1", cliente.telefone_1))
            cmd.Parameters.Add(New OleDbParameter("ddd_2", cliente.ddd_2))
            cmd.Parameters.Add(New OleDbParameter("telefone_2", cliente.telefone_2))
            cmd.Parameters.Add(New OleDbParameter("ddd_3", cliente.ddd_3))
            cmd.Parameters.Add(New OleDbParameter("telefone_3", cliente.telefone_3))
            cmd.Parameters.Add(New OleDbParameter("email", cliente.email))
            cmd.Parameters.Add(New OleDbParameter("endereco", cliente.endereco))
            cmd.Parameters.Add(New OleDbParameter("cep", cliente.cep))
            cmd.Parameters.Add(New OleDbParameter("dt_cadastro", cliente.dt_cadastro))

            Conectar()
            Dim cont As Integer = cmd.ExecuteNonQuery()
            Desconectar()

            cont = 0
            Dim temp As New Cliente()

            temp = getClienteByNome(cliente.nome)

            Dim cmd2 As New OleDbCommand("INSERT INTO clientes (pessoa_id, dt_alteracao, usuario_id) VALUES (?, ?, ?)", conexao)

            cmd2.Parameters.Add(New OleDbParameter("pessoa_id", temp.id))
            cmd2.Parameters.Add(New OleDbParameter("dt_alteracao", cliente.dt_cadastro))
            cmd2.Parameters.Add(New OleDbParameter("usuario_id", cliente.usuario_id))

            Conectar()
            cont = cmd2.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCAO alterarCliente
    '@param cliente
    '@return true or false
    '=======================================================================================================================
    Public Function alterarCliente(ByVal cliente As Cliente) As Boolean
        Try
            Dim sql As String = "UPDATE pessoas SET [nome] = @nome, [rg] = @rg , [cpf] = @cpf, [ddd_1] = @ddd_1, [telefone_1] = @telefone_1, [ddd_2] = @ddd_2, [telefone_2] = @telefone_2, [ddd_3] = @ddd_3, [telefone_3] = @telefone_3, [email] = @email, [endereco] = @endereco, [cep] = @cep WHERE id = " & cliente.pessoa_id.ToString
            Dim cmd As New OleDbCommand(sql, conexao)

            cmd.Parameters.Add(New OleDbParameter("nome", cliente.nome))
            cmd.Parameters.Add(New OleDbParameter("rg", cliente.rg))
            cmd.Parameters.Add(New OleDbParameter("cpf", cliente.cpf))
            cmd.Parameters.Add(New OleDbParameter("ddd_1", cliente.ddd_1))
            cmd.Parameters.Add(New OleDbParameter("telefone_1", cliente.telefone_1))
            cmd.Parameters.Add(New OleDbParameter("ddd_2", cliente.ddd_2))
            cmd.Parameters.Add(New OleDbParameter("telefone_2", cliente.telefone_2))
            cmd.Parameters.Add(New OleDbParameter("ddd_3", cliente.ddd_3))
            cmd.Parameters.Add(New OleDbParameter("telefone_3", cliente.telefone_3))
            cmd.Parameters.Add(New OleDbParameter("email", cliente.email))
            cmd.Parameters.Add(New OleDbParameter("endereco", cliente.endereco))
            cmd.Parameters.Add(New OleDbParameter("cep", cliente.cep))

            Conectar()
            cmd.ExecuteNonQuery()
            Desconectar()

            Dim sql2 As String = "UPDATE clientes SET [dt_alteracao] = @dt_alteracao, [usuario_id] = @usuario_id WHERE id = " & cliente.id.ToString
            Dim cmd2 As New OleDbCommand(sql2, conexao)
            cmd2.Parameters.Add(New OleDbParameter("dt_alteracao", cliente.dt_alteracao))
            cmd2.Parameters.Add(New OleDbParameter("usuario_id", cliente.usuario_id))
            Conectar()
            cmd2.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCAO excluirCliente
    '@param id
    '@return true or false
    '================================================================================================================
    Public Function excluirCliente(ByVal id As Integer) As Boolean
        Try
            Dim pessoaId As Integer = getClienteById(id).pessoa_id
            Dim sqlCliente As String = "DELETE FROM clientes WHERE id = " & id.ToString
            Dim sqlPessoa As String = "DELETE FROM pessoas WHERE id = " & pessoaId.ToString
            Dim cmdCliente As New OleDbCommand(sqlCliente, conexao)
            Dim cmdPessoa As New OleDbCommand(sqlPessoa, conexao)

            Conectar()
            cmdCliente.ExecuteNonQuery()
            Desconectar()

            Conectar()
            cmdPessoa.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

    ' FUNCAO atualizarCliente ==> funcao utilizada na busca de cliente no formulario FormProcurarCliente
    '@param 
    '@return true or false 
    '===========================================================================================
    Function atualizarCliente()
        Dim sql As String = "SELECT id, nome FROM pessoas"
        Dim dt As New DataTable
        Dim adpt As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conexao)

        Try
            adpt.Fill(dt)
            FormProcurarCliente.gridClientes.DataSource = dt
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Desconectar()
        Return True

    End Function

    ' FUNCAO buscarCliente
    '@param nome
    '@return busca ==> retorna os resultados referentes ao filtro(nome)
    '===========================================================================================
    Function buscarCliente(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim temp As String = nome
        Dim sql As String = "SELECT c.id, p.nome FROM clientes as c INNER JOIN pessoas as p ON p.id = c.pessoa_id WHERE p.nome LIKE '%" & temp & "%'"
        Dim adpt As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conexao)

        Try
            adpt.Fill(busca)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Desconectar()
        Return busca
    End Function

    ' FUNCAO completaTextoCliente ==>  funcao auxiliar para autocompletar nome do cliente buscado (FAIL)
    '@param
    '@return true or false 
    '===========================================================================================
    'Function completaTextoCliente()
    'Dim r As DataRow
    '    Try
    'Dim sql As String = "SELECT * FROM pessoas"
    'Dim adpt As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(Sql, conexao)
    'Dim dt As New DataTable
    'Dim ds As New DataSet
    '        Conectar()
    '       ds.Tables.Add(dt)
    '
    '       adpt.Fill(dt)
    '
    '       For Each r In dt.Rows
    '          FormOrdem.txtClienteNome.AutoCompleteCustomSource.Add(r.Item(1).ToString)
    '     Next
    '    Desconectar()
    '    Catch ex As Exception
    '      MessageBox.Show(ex.ToString)
    '       Return False
    '  End Try
    '
    '   Return True
    'End Function

End Class