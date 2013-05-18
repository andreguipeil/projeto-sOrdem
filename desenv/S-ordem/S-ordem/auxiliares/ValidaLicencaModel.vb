Imports System.Data.OleDb

Public Class ValidaLicencaModel

    Inherits programaModel

    Public Function setSerial(ByVal serial)
        Try
            Dim sql As String = "INSERT INTO configuracoes (serial) VALUES (?)"
            Dim cmd As New OleDbCommand(sql, conexao)

            cmd.Parameters.Add(New OleDbParameter("serial", serial))

            Conectar()
            cmd.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
        Return False
    End Function

    Public Function getSerial()
        Dim temp As String = ""
        Dim sql As String = "SELECT * FROM configuracoes"
        Dim dr As OleDb.OleDbDataReader

        Conectar()
        dr = retornaQuery(sql)
        If dr.HasRows Then
            While dr.Read
                temp = dr.Item("serial")
                Exit While
            End While
        End If
        Desconectar()
        Return temp
    End Function

    Public Function getSerial(ByVal key As String) As Boolean
        Dim temp As String = ""
        Dim sql As String = "SELECT * FROM configuracoes WHERE serial LIKE '" & key & "'"
        Dim dr As OleDb.OleDbDataReader

        Conectar()
        dr = retornaQuery(sql)
        If dr.HasRows Then
            While dr.Read
                temp = dr.Item("serial")
                Exit While
            End While
        End If
        Desconectar()

        If String.IsNullOrEmpty(temp) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function deleteSerial()
        Try
            Dim sql As String = "DELETE FROM configuracoes"
            Dim cmd As New OleDbCommand(sql, conexao)

            Conectar()
            cmd.ExecuteNonQuery()
            Desconectar()

            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function contadorSerial()

        Dim temp As Integer
        Dim sql As String = "SELECT count(*) as contador FROM configuracoes"
        Dim dr As OleDb.OleDbDataReader

        Conectar()
        dr = retornaQuery(sql)
        If dr.HasRows Then
            While dr.Read
                temp = dr.Item("contador")
                Exit While
            End While
        End If
        Desconectar()
        Return temp
    End Function

End Class
