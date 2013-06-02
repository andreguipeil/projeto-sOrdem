'Developed by André Peil
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
' 
' Faz a conexao entre o programa e o banco de dados
'==============================================================
Public Class programaModel
    Public local As String = init()
    Public enderecoDB As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & local & ";" ' & " Database Password=sordem;" & " Persist Security Info=False;" 'Persist Security Info=True;




    ' & Application.StartupPath & "\" & 
    'Public enderecoDB As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\sordem-db.accdb"  ' Access 2007
    ' Dim enderecoDB As String = "Provider = Microsoft.jet.OleDB.4.0;Data Source = D:\dados.mdb" ' só para access 2003
    Public conexao As New OleDb.OleDbConnection(enderecoDB)



    Public Function init() As String
        Try
            Dim fluxoTexto As IO.StreamReader                             'Classe de leitura de arquivos (txt)
            Dim linhaTexto As String
            Dim strBase As String = ""
            Dim endereco As String

            fluxoTexto = New IO.StreamReader(System.Windows.Forms.Application.StartupPath & "\config.ini")
            linhaTexto = fluxoTexto.ReadLine
            While linhaTexto <> Nothing
                If Mid(linhaTexto, 1, 4) = "base" Then
                    strBase = Trim(Mid(linhaTexto, 6, 80))
                    '        ElseIf Mid(linhaTexto, 1, 5) = "senha" Then
                    '           strSenha = Trim(Mid(linhaTexto, 7, 80))
                    '          strSenha = _criptografia.CriptaTexto(strSenha, False)
                End If
                linhaTexto = fluxoTexto.ReadLine
            End While
            fluxoTexto.Close()

            If String.IsNullOrEmpty(strBase) Then
                endereco = System.Windows.Forms.Application.StartupPath & "\sordem-db.accdb"
            Else
                endereco = strBase
            End If

            Return endereco
        Catch exception As Exception
            MsgBox("Erro:" & exception.ToString())
        End Try
        Return Nothing
    End Function





    ' executaQuery  "INSERT INTO pessoas(nome, rg, cpf, telefone_1, telefone_2, telefone_3, email, endereco, cep, dt_cadastro) VALUES(asdsadasdas, 12312312312, 13212312312, 1111111111, 1222222222, 3333333333, asadadsad, aaaaaaaaaaaaaa, 12312312, Now())"
    ' --> envia para o banco a conexao e a query solicitada
    ' @param String query -> contem o sql a ser executado
    '====================================================================== 
    Public Sub executaQuery(ByVal query As String)
        Dim cm As New OleDb.OleDbCommand
        cm.Connection = conexao
        cm.CommandText = query
        cm.ExecuteNonQuery()

    End Sub

    ' retornaQuery
    ' --> trás todos os dados do banco referentes a busca solicitada 
    ' @param String query -> contem o sql a ser executado
    '======================================================================
    Public Function retornaQuery(ByVal query As String) As OleDb.OleDbDataReader

        Dim cm As New OleDb.OleDbCommand(query, conexao)

        Dim dr As OleDb.OleDbDataReader
        dr = cm.ExecuteReader
        retornaQuery = dr
    End Function

    'Conectar
    ' --> conecta o banco de dados
    '=======================================================================
    Public Sub Conectar()
        Try
            conexao.Open()
        Catch exception As Exception
            MsgBox("Erro:" & exception.ToString())
        End Try
    End Sub

    'Desconectar
    ' --> desconecta do banco de dados
    '=======================================================================
    Public Sub Desconectar()
        Try
            conexao.Close()
        Catch exception As Exception
            MsgBox("Erro:" & exception.ToString())
        End Try
    End Sub


    Public Function getMarca(ByVal id) As String
        Try
            Dim sql As String = "SELECT nome FROM marcas WHERE id = " & id
            Dim marca As String = ""
            Dim dr As OleDb.OleDbDataReader

            Conectar()
            dr = retornaQuery(sql)
            If dr.HasRows Then                                      ' se tem linhas no objeto (retorno da query)
                While dr.Read                                       'enquanto nao chega ao final do bjeto (dados da query)
                    marca = dr.Item("nome")
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

    Public Function getOrdemEstado(ByVal id) As String
        Try
            Dim sql As String = "SELECT nome FROM ordens_estados WHERE id = " & id
            Dim estado As String = ""
            Dim dr As OleDb.OleDbDataReader

            Conectar()
            dr = retornaQuery(sql)
            If dr.HasRows Then                                      ' se tem linhas no objeto (retorno da query)
                While dr.Read                                       'enquanto nao chega ao final do bjeto (dados da query)
                    estado = dr.Item("nome")
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

End Class
