'Developed by André Peil
Imports System
Imports System.Data
Imports System.Data.OleDb

' 
' Faz a conexao entre o programa e o banco de dados
'==============================================================
Public Class programaModel
    Public enderecoDB As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\projeto-sOrdem\database\sordem-db.accdb"  ' Access 2007
    ' Dim enderecoDB As String = "Provider = Microsoft.jet.OleDB.4.0;Data Source = D:\dados.mdb" ' só para access 2003
    Public conexao As New OleDb.OleDbConnection(enderecoDB)

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

    Public Sub Insere(ByVal query As String)

        Dim cn As New OleDbConnection(enderecoDB)
        Dim cmd As New OleDbCommand("INSERT INTO pessoas (nome , rg , cpf, telefone_1, telefone_2, telefone_3, email, endereco, cep, dt_cadastro ) VALUES ( ? , ? , ?, ?, ?, ?, ?, ?, ?, ?)", cn)
        Dim Data_hoje As DateTime = DateTime.Now
        Dim data As String

        Data_hoje = FormatDateTime(Data_hoje, DateFormat.ShortDate)
        data = Replace(Data_hoje, "/", "-")
        MsgBox(data)

        cmd.Parameters.Add(New OleDbParameter("nome", "Caio"))
        cmd.Parameters.Add(New OleDbParameter("rg", "999999999"))
        cmd.Parameters.Add(New OleDbParameter("cpf", "99999999999"))
        cmd.Parameters.Add(New OleDbParameter("telefone_1", ""))
        cmd.Parameters.Add(New OleDbParameter("telefone_2", "99999999999"))
        cmd.Parameters.Add(New OleDbParameter("telefone_3", "99999999999"))
        cmd.Parameters.Add(New OleDbParameter("email", "asdsadas"))
        cmd.Parameters.Add(New OleDbParameter("endereco", "asadas"))
        cmd.Parameters.Add(New OleDbParameter("cep", "96080000"))
        cmd.Parameters.Add(New OleDbParameter("dt_cadastro", data))
        cn.Open()

        Dim cont As Integer = cmd.ExecuteNonQuery()

        MsgBox(cont)

        cn.Close()

    End Sub

End Class