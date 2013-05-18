Imports System.Data.OleDb

Public Class EstadoModel
    Inherits programaModel

    'FUNCAO getEstados
    '@return tabela com as estados
    '=======================================================================================================================
    Public Function getEstados()
        Try
            Dim sql As String = "SELECT * FROM ordens_estados"
            Dim DataReader As OleDb.OleDbDataReader
            Dim myDataTable As New DataTable

            Conectar()
            DataReader = retornaQuery(sql)
            myDataTable.Load(DataReader)
            Desconectar()
            Return myDataTable
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try

    End Function

    'FUNCAO getEstado
    '@param id
    '@return estado
    '=======================================================================================================================
    Public Function getEstadoById(ByVal id)
        Try
            Dim dr As OleDb.OleDbDataReader
            Dim estado As New Estado()
            Dim query As String = "SELECT * FROM ordens_estados WHERE id = " & id.ToString

            Conectar()
            dr = retornaQuery(query)

            If dr.HasRows Then                                      ' se tem linhas no objeto (retorno da query)
                While dr.Read                                       'enquanto nao chega ao final do bjeto (dados da query)
                    estado.id = dr.Item("id")
                    estado.nome = dr.Item("nome")
                    Exit While
                End While
            End If

            Desconectar()
            Return estado
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function


    'FUNCAO alterarEstado
    '@param estado
    '@return true or false
    '=======================================================================================================================
    Public Function inserirEstado(ByVal estado As Estado) As Boolean
        Try
            Dim cmd As New OleDbCommand("INSERT INTO ordens_estados (nome) VALUES ( ? )", conexao)

            cmd.Parameters.Add(New OleDbParameter("nome", estado.nome))

            Conectar()
            Dim cont As Integer = cmd.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCAO alterarEstado
    '@param estado
    '@return true or false
    '=======================================================================================================================
    Public Function alterarEstado(ByVal estado As Estado) As Boolean
        Try
            Dim sql As String = "UPDATE ordens_estados SET [nome] = @nome WHERE id = " & estado.id.ToString
            Dim cmd As New OleDbCommand(sql, conexao)

            cmd.Parameters.Add(New OleDbParameter("nome", estado.nome))

            Conectar()
            cmd.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCAO excluirEstado
    '@param id
    '@return true or false
    '================================================================================================================
    Public Function excluirEstado(ByVal id As Integer) As Boolean
        Try
            Dim sql As String = "DELETE FROM ordens_estados WHERE id = " & id.ToString
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

End Class
