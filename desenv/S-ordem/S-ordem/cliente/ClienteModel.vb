Imports System.Data.OleDb

Public Class clienteModel

    Inherits programaModel

    Public Function inserirCliente(ByVal Cliente As Cliente) As Boolean

        'Dim acesso As New AcessaDB
        Dim cmd As New OleDbCommand("INSERT INTO pessoas (nome , rg , cpf, telefone_1, telefone_2, telefone_3, email, endereco, cep, dt_cadastro ) VALUES ( ? , ? , ?, ?, ?, ?, ?, ?, ?, ?)", conexao)

        'Dim cn As New OleDbConnection(enderecoDB)
        'Dim cmd As New OleDbCommand("INSERT INTO pessoas (nome , rg , cpf, telefone_1, telefone_2, telefone_3, email, endereco, cep, dt_cadastro ) VALUES ( ? , ? , ?, ?, ?, ?, ?, ?, ?, ?)", cn)

        cmd.Parameters.Add(New OleDbParameter("nome", Cliente.nome))
        cmd.Parameters.Add(New OleDbParameter("rg", Cliente.rg))
        cmd.Parameters.Add(New OleDbParameter("cpf", Cliente.cpf))
        cmd.Parameters.Add(New OleDbParameter("telefone_1", Cliente.telefone_1))
        cmd.Parameters.Add(New OleDbParameter("telefone_2", Cliente.telefone_2))
        cmd.Parameters.Add(New OleDbParameter("telefone_3", Cliente.telefone_3))
        cmd.Parameters.Add(New OleDbParameter("email", Cliente.email))
        cmd.Parameters.Add(New OleDbParameter("endereco", Cliente.endereco))
        cmd.Parameters.Add(New OleDbParameter("cep", Cliente.cep))
        cmd.Parameters.Add(New OleDbParameter("dt_cadastro", Cliente.data))

        Conectar()
        Dim cont As Integer = cmd.ExecuteNonQuery()
        Desconectar()

        Return True
    End Function

    Public Function getCliente(ByVal id As Integer) As DataSet

        Try
            Dim sql As String = "SELECT * FROM pessoas WHERE id =" & id.ToString
            Dim sa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conexao)
            Dim ds As New DataSet

            Try
                sa.Fill(ds, "pessoas")
            Finally
                sa.Dispose()
            End Try

            Return ds
        Finally
            Desconectar()
            conexao.Dispose()
        End Try
    End Function

    Public Function getClientes(ByVal parametros As Cliente) As DataTable
        Dim DataReader As OleDb.OleDbDataReader
        Dim myDataTable As New DataTable
        Dim gridFiltroSql As String

        gridFiltroSql = "SELECT id, nome, rg, cpf, email FROM pessoas"
        Dim flag As Integer = 0

        '============================================
        If String.IsNullOrEmpty(parametros.nome) = False Then
            If flag = 0 Then
                gridFiltroSql = "SELECT id, nome, rg, cpf, email FROM pessoas WHERE nome LIKE '%" & parametros.nome & "%'"
                flag = 1
            Else
                gridFiltroSql = "SELECT id, nome, rg, cpf, email FROM pessoas WHERE nome LIKE '%" & parametros.nome & "%'"
            End If
        End If

        '=============================================
        If String.IsNullOrEmpty(parametros.rg) = False Then
            If flag = 0 Then
                gridFiltroSql = " SELECT id, nome, rg, cpf, email FROM pessoas WHERE rg LIKE '%" & parametros.rg & "%'"
                flag = 1
            Else
                gridFiltroSql = gridFiltroSql & " UNION SELECT id, nome, rg, cpf, email FROM pessoas WHERE rg LIKE '%" & parametros.rg & "%'"
            End If
        End If

        '=============================================
        If String.IsNullOrEmpty(parametros.cpf) = False Then
            Dim clienteCpf As String = Replace(Replace((parametros.cpf), "-", ""), ",", "")

            If flag = 0 Then
                gridFiltroSql = " SELECT id, nome, rg, cpf, email FROM pessoas WHERE cpf LIKE '" & clienteCpf & "'"
                flag = 1
            Else
                gridFiltroSql = gridFiltroSql & " UNION SELECT id, nome, rg, cpf, email FROM pessoas WHERE cpf LIKE '" & clienteCpf & "'"
            End If
        End If

        '==============================================
        If String.IsNullOrEmpty(parametros.email) = False Then
            If flag = 0 Then
                gridFiltroSql = " SELECT id, nome, rg, cpf, email FROM pessoas WHERE email LIKE '%" & parametros.email & "%'"
                flag = 1
            Else
                gridFiltroSql = gridFiltroSql & " UNION SELECT id, nome, rg, cpf, email FROM pessoas WHERE email LIKE '%" & parametros.email & "%'"
            End If
        End If

        Conectar()
        DataReader = retornaQuery(gridFiltroSql)
        myDataTable.Load(DataReader)
        Desconectar()

        Return myDataTable
    End Function

    Public Function alterarCliente(ByVal cliente As Cliente) As Boolean

        Dim sql As String = "UPDATE pessoas SET [nome] = @nome, [rg] = @rg , [cpf] = @cpf, [telefone_1] = @telefone_1, [telefone_2] = @telefone_2, [telefone_3] = @telefone_3, [email] = @email, [endereco] = @endereco, [cep] = @cep, [dt_cadastro] = @dt_cadastro WHERE id = " & cliente.id.ToString

        Dim cmd As New OleDbCommand(sql, conexao)

        'cmd.Parameters.Add("@nome", OleDbType.VarChar).Value = cliente.nome
        'cmd.Parameters.Add("@rg", OleDbType.VarChar).Value = cliente.rg
        'cmd.Parameters.Add("@cpf", OleDbType.VarChar).Value = cliente.cpf
        'cmd.Parameters.Add("@telefone_1", OleDbType.VarChar).Value = cliente.telefone_1
        'cmd.Parameters.Add("@telefone_2", OleDbType.VarChar).Value = cliente.telefone_2
        'cmd.Parameters.Add("@telefone_3", OleDbType.VarChar).Value = cliente.telefone_3
        'cmd.Parameters.Add("@endereco", OleDbType.VarChar).Value = cliente.endereco
        'cmd.Parameters.Add("@email", OleDbType.VarChar).Value = cliente.email
        'cmd.Parameters.Add("@cep", OleDbType.VarChar).Value = cliente.cep
        'cmd.Parameters.Add("@dt_cadastro", OleDbType.VarChar).Value = cliente.data

        cmd.Parameters.Add(New OleDbParameter("nome", cliente.nome))
        cmd.Parameters.Add(New OleDbParameter("rg", cliente.rg))
        cmd.Parameters.Add(New OleDbParameter("cpf", cliente.cpf))
        cmd.Parameters.Add(New OleDbParameter("telefone_1", cliente.telefone_1))
        cmd.Parameters.Add(New OleDbParameter("telefone_2", cliente.telefone_2))
        cmd.Parameters.Add(New OleDbParameter("telefone_3", cliente.telefone_3))
        cmd.Parameters.Add(New OleDbParameter("email", cliente.email))
        cmd.Parameters.Add(New OleDbParameter("endereco", cliente.endereco))
        cmd.Parameters.Add(New OleDbParameter("cep", cliente.cep))
        cmd.Parameters.Add(New OleDbParameter("dt_cadastro", cliente.data))

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

        Return True
    End Function

End Class