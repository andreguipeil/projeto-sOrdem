Imports System.Data.OleDb

Public Class UsuarioSessao

    Private usuario_id As Integer
    Private usuario_nome As String
    Private usuario_senha As String
    Private usuario_flag_adm As String

    Public Function getUsuarioFlagAdm() As Integer
        Return usuario_flag_adm
    End Function

    Public Function getUsuarioUsername() As String
        Return usuario_nome
    End Function

    Public Function getUsuarioId() As Integer
        Return usuario_id
    End Function

    Public Sub setUsuario(ByVal id)
        usuario_id = id
    End Sub

    Public Function autenticacao(ByVal username, ByVal senha) As Boolean
        Try
            Dim acessoModel As New programaModel
            Dim dr As OleDb.OleDbDataReader
            Dim sql As String = "SELECT * FROM usuarios WHERE username = '" & username & "' AND senha = '" & senha & "'"
            acessoModel.Conectar()
            dr = acessoModel.retornaQuery(sql)
            If dr.HasRows Then
                While dr.Read
                    usuario_id = dr.Item("id")
                    usuario_nome = dr.Item("username")
                    usuario_senha = dr.Item("senha")
                    usuario_flag_adm = dr.Item("flag_adm")
                    Exit While
                End While
            Else
                MsgBox("Usuario ou Senha inválidos, tente novamente.", MsgBoxStyle.Exclamation)
                Return False
            End If
            acessoModel.Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

End Class
