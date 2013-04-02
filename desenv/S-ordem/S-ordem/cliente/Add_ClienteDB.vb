Imports System.Data.OleDb

Public Class Add_ClienteDb

    Inherits AcessaDB

    Public Sub insereCliente(ByVal Cliente As Cliente)

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

        MsgBox(cont)

        Desconectar()
    End Sub

    Public Sub getClientes(ByVal Cliente As Cliente)
        Dim cmd As New OleDbCommand("SELECT id, nome, rg, cpf, email FROM pessoas", conexao)

        If Cliente.nome <> "" Then

        End If


    End Sub

End Class
