Imports System.Data.OleDb

Public Class usuarioModel
    Inherits programaModel

    ' FUNCAO validaUsername
    ' @param username
    ' @return true or false
    '==================================================================================================
    Public Function validaUsername(ByVal username) As Boolean
        Dim sql As String = "SELECT (count(username)) as num FROM USUARIOS WHERE username LIKE '" & username & "'"
        Dim cmd As New OleDb.OleDbCommand(sql, conexao)
        Dim flag As Boolean = True
        Dim cont As Integer

        Conectar()
        cont = cmd.ExecuteScalar()
        Desconectar()

        If (cont = 0) Then
            flag = False
        End If

        Return flag
    End Function


    ' FUNCAO getUsuarioByRg
    ' @param rg
    ' @return usuario
    '==================================================================================================
    Public Function getUsuarioByNome(ByVal nome As String) As Usuario
        Try
            Dim dr As OleDb.OleDbDataReader
            Dim usuario As New Usuario()
            Dim query As String = "SELECT * FROM  pessoas WHERE nome LIKE '" & nome & "'"

            Conectar()
            dr = retornaQuery(query)

            If dr.HasRows Then                                  ' se tem linhas no objeto (retorno da query)
                While dr.Read                                   'enquanto nao chega ao final do bjeto (dados da query)
                    usuario.pessoa_id = dr.Item("id")
                    usuario.nome = dr.Item("nome")
                    usuario.rg = dr.Item("rg")
                    usuario.email = dr.Item("email")
                    usuario.telefone = dr.Item("telefone_1")
                    usuario.ddd = dr.Item("ddd_1")
                    Exit While
                End While
            End If
            Desconectar()
            Return usuario
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function



    ' FUNCAO insereUsuario
    ' @param usuario 
    ' @return true or false 
    '====================================================================================
    Public Function inserirUsuario(ByVal usuario As Usuario) As Boolean
        Try
            Dim cmd As New OleDbCommand("INSERT INTO pessoas (nome , rg , ddd_1, telefone_1, email, dt_cadastro ) VALUES ( ? , ? , ?, ?, ?, ?)", conexao)

            cmd.Parameters.Add(New OleDbParameter("nome", usuario.nome))
            cmd.Parameters.Add(New OleDbParameter("rg", usuario.rg))
            cmd.Parameters.Add(New OleDbParameter("ddd_1", usuario.ddd))
            cmd.Parameters.Add(New OleDbParameter("telefone_1", usuario.telefone))
            cmd.Parameters.Add(New OleDbParameter("email", usuario.email))
            cmd.Parameters.Add(New OleDbParameter("dt_cadastro", usuario.dt_cadastro))

            Conectar()
            Dim cont As Integer = cmd.ExecuteNonQuery()
            Desconectar()

            cont = 0
            Dim temp As New Usuario()

            temp = getUsuarioByNome(usuario.nome)

            Dim cmd2 As New OleDbCommand("INSERT INTO usuarios (username, senha, pessoa_id, flag_adm) VALUES (?, ?, ?, ?)", conexao)

            cmd2.Parameters.Add(New OleDbParameter("username", usuario.username))
            cmd2.Parameters.Add(New OleDbParameter("senha", usuario.senha))
            cmd2.Parameters.Add(New OleDbParameter("pessoa_id", temp.pessoa_id))
            cmd2.Parameters.Add(New OleDbParameter("flag_adm", usuario.flag_adm))

            Conectar()
            cont = cmd2.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function


    'FUNCAO alterarUsuario
    '@param usuario
    '@return true or false
    '=======================================================================================================================
    Public Function alterarUsuario(ByVal usuario As Usuario) As Boolean
        Try
            Dim sql As String = "UPDATE pessoas SET [nome] = @nome, [rg] = @rg, [ddd_1] = @ddd, [telefone_1] = @telefone, [email] = @email WHERE id = " & usuario.pessoa_id.ToString
            Dim cmd As New OleDbCommand(sql, conexao)

            cmd.Parameters.Add(New OleDbParameter("nome", usuario.nome))
            cmd.Parameters.Add(New OleDbParameter("rg", usuario.rg))
            cmd.Parameters.Add(New OleDbParameter("ddd_1", usuario.ddd))
            cmd.Parameters.Add(New OleDbParameter("telefone_1", usuario.telefone))
            cmd.Parameters.Add(New OleDbParameter("email", usuario.email))


            Conectar()
            cmd.ExecuteNonQuery()
            Desconectar()

            Dim sql2 As String = "UPDATE usuarios SET [username] = @username, [senha] = @senha, [flag_adm] = @flag_adm WHERE id = " & usuario.id.ToString
            Dim cmd2 As New OleDbCommand(sql2, conexao)

            cmd2.Parameters.Add(New OleDbParameter("username", usuario.username))
            cmd2.Parameters.Add(New OleDbParameter("senha", usuario.senha))
            cmd2.Parameters.Add(New OleDbParameter("flag_adm", usuario.flag_adm))

            Conectar()
            cmd2.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCAO excluirUsuario
    '@param id
    '@return true or false
    '================================================================================================================
    Public Function excluirUsuario(ByVal id As Integer) As Boolean
        Try
            Dim pessoaId As Integer = getUsuarioById(id).pessoa_id
            Dim sqlUsuario As String = "DELETE FROM usuarios WHERE id = " & id.ToString
            Dim sqlPessoa As String = "DELETE FROM pessoas WHERE id = " & pessoaId.ToString
            Dim cmdUsuario As New OleDbCommand(sqlUsuario, conexao)
            Dim cmdPessoa As New OleDbCommand(sqlPessoa, conexao)

            Conectar()
            cmdUsuario.ExecuteNonQuery()
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

    ' FUNCAO getUsuarioById
    ' @param id
    ' @return usuario
    '==================================================================================================
    Public Function getUsuarioById(ByVal id As Integer) As Usuario
        Try
            Dim dr As OleDb.OleDbDataReader
            Dim usuario As New Usuario
            Dim query As String = "SELECT * FROM usuarios as u INNER JOIN pessoas as p on u.pessoa_id = p.id WHERE u.id = " & id.ToString

            Conectar()
            dr = retornaQuery(query)

            If dr.HasRows Then                                      ' se tem linhas no objeto (retorno da query)
                While dr.Read                                       'enquanto nao chega ao final do bjeto (dados da query)
                    usuario.id = dr.Item("u.id")
                    usuario.nome = dr.Item("nome")
                    usuario.rg = dr.Item("rg")
                    usuario.pessoa_id = dr.Item("pessoa_id")
                    usuario.email = dr.Item("email")
                    usuario.ddd = dr.Item("ddd_1")
                    usuario.telefone = dr.Item("telefone_1")
                    usuario.username = dr.Item("username")
                    usuario.senha = dr.Item("senha")
                    usuario.flag_adm = dr.Item("flag_adm")
                    Exit While
                End While
            End If
            Desconectar()
            Return usuario
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function


    ' FUNCAO atualizarUsuario ==> funcao atualiza o usuario conforme o digitar da pessoa
    ' @param 
    ' @return true or false 
    '===========================================================================================
    Function atualizarUsuario()
        Dim sql As String = "SELECT id, nome FROM pessoas"
        Dim dt As New DataTable
        Dim adpt As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conexao)

        Try
            adpt.Fill(dt)
            FormConsultaUsuario.gridUsuarios.DataSource = dt
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Desconectar()
        Return True

    End Function


    ' FUNCAO buscarUsuario
    ' @param nome
    ' @return busca ==> retorna os resultados referentes ao filtro(nome)
    '===========================================================================================
    Function buscarUsuario(ByVal nome As String) As DataTable
        Dim busca As New DataTable
        Dim temp As String = nome
        Dim sql As String = "SELECT u.id, p.nome, u.username FROM usuarios as u INNER JOIN pessoas as p ON p.id = u.pessoa_id WHERE p.nome LIKE '%" & temp & "%'"
        Dim adpt As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conexao)

        Try
            adpt.Fill(busca)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Desconectar()
        Return busca
    End Function

End Class
