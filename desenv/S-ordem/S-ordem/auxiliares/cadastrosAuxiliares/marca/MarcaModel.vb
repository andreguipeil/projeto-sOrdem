Imports System.Data.OleDb

Public Class MarcaModel
    Inherits programaModel

    'FUNCAO getMarcas
    '@return tabela com as marcas
    '=======================================================================================================================
    Public Function getMarcas()
        Try
            Dim sql As String = "SELECT * FROM marcas"
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


    'FUNCAO getMarca
    '@param id
    '@return marca
    '=======================================================================================================================
    Public Function getMarcaById(ByVal id)
        Try
            Dim dr As OleDb.OleDbDataReader
            Dim marca As New Marca()
            Dim query As String = "SELECT * FROM marcas WHERE id = " & id.ToString

            Conectar()
            dr = retornaQuery(query)
            If dr.HasRows Then                                      ' se tem linhas no objeto (retorno da query)
                While dr.Read                                       ' enquanto nao chega ao final do bjeto (dados da query)
                    marca.id = dr.Item("id")
                    marca.nome = dr.Item("nome")
                    Exit While
                End While
            End If
            Desconectar()

            Return marca
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function


    'FUNCAO alterarMarca
    '@param Marcas
    '@return true or false
    '=======================================================================================================================
    Public Function inserirMarca(ByVal marca As Marca) As Boolean
        Try
            Dim cmd As New OleDbCommand("INSERT INTO marcas (nome) VALUES ( ? )", conexao)
            cmd.Parameters.Add(New OleDbParameter("nome", marca.nome))

            Conectar()
            Dim cont As Integer = cmd.ExecuteNonQuery()
            Desconectar()

            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCAO alterarMarca
    '@param Marcas
    '@return true or false
    '=======================================================================================================================
    Public Function alterarMarca(ByVal marca As Marca) As Boolean
        Try
            Dim sql As String = "UPDATE marcas SET [nome] = @nome WHERE id = " & marca.id.ToString
            Dim cmd As New OleDbCommand(sql, conexao)
            cmd.Parameters.Add(New OleDbParameter("nome", marca.nome))

            Conectar()
            cmd.ExecuteNonQuery()
            Desconectar()

            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCAO excluirMarca
    '@param id
    '@return true or false
    '================================================================================================================
    Public Function excluirMarca(ByVal id As Integer) As Boolean
        Try
            Dim sql As String = "DELETE FROM marcas WHERE id = " & id.ToString
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
