Imports System.Data.OleDb

Public Class OrdemModel

    Inherits programaModel

    ' FUNCAO getOrdemById
    ' @param id
    ' @return ordem
    '==================================================================================================
    Public Function getOrdem(ByVal id As Integer) As DataSet

        Try
            Dim sql As String = "SELECT * FROM ordens_servico WHERE id =" & id.ToString
            Dim sa As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conexao)
            Dim ds As New DataSet

            Try
                sa.Fill(ds, "ordens_servico")
            Finally
                sa.Dispose()
            End Try

            Return ds
        Finally
            Desconectar()
            conexao.Dispose()
        End Try
    End Function


    ' FUNCAO getOrdemById
    ' @param id
    ' @return ordem
    '==================================================================================================
    Public Function getOrdemById(ByVal id As Integer) As Ordem
        Try
            Dim dr As OleDb.OleDbDataReader
            Dim ordem As New Ordem()
            Dim query As String = "SELECT * FROM ordens_servico WHERE id =" & id.ToString

            Conectar()
            dr = retornaQuery(query)

            If dr.HasRows Then                          ' se tem linhas no objeto (retorno da query)
                While dr.Read                           'enquanto nao chega ao final do bjeto (dados da query)
                    ordem.id = dr.Item("id")
                    ordem.cliente_id = dr.Item("cliente_id")
                    ordem.marca_id = dr.Item("marca_id")
                    ordem.ordem_estado_id = dr.Item("ordem_estado_id")
                    ordem.laudo = dr.Item("laudo")
                    ordem.defeito = dr.Item("defeito")
                    ordem.preco_concerto = dr.Item("preco_concerto")
                    ordem.usuario_id = dr.Item("usuario_id")
                    ordem.modelo = dr.Item("modelo")
                    ordem.dt_entrada = dr.Item("dt_entrada")
                    ordem.dt_saida = dr.Item("dt_saida")
                    ordem.dt_cadastro = dr.Item("dt_cadastro")
                    ordem.dt_alteracao = dr.Item("dt_alteracao")
                    ordem.observacao = dr.Item("observacao")
                    Exit While
                End While
            End If
            Desconectar()
            Return ordem
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try
    End Function


    ' FUNCAO getOrdens
    ' @param ordem, cliente
    ' @return datagrid com as ordens filtradas
    '==================================================================================================
    Public Function getOrdens(ByVal parametros As Ordem, ByVal cliente As String) As DataTable
        Try
            Dim DataReader As OleDb.OleDbDataReader
            Dim myDataTable As New DataTable
            Dim flag As Integer = 0
            Dim gridFiltroSql As String
            gridFiltroSql = "SELECT oe.nome AS estado, os.id AS nr_ordem, p.nome AS cliente, m.nome AS marca, os.dt_entrada, os.dt_saida, os.modelo, os.preco_concerto, os.defeito, os.laudo, os.dt_alteracao, os.observacao, u.username AS usuario " &
                                            "FROM usuarios AS u  " &
                                            "INNER JOIN (pessoas AS p " &
                                            "INNER JOIN (clientes AS c " &
                                            "INNER JOIN (marcas as m " &
                                            "INNER JOIN (ordens_estados AS oe " &
                                            "INNER JOIN ordens_servico AS os ON oe.id = os.ordem_estado_id) " &
                                            "ON m.id = os.marca_id) " &
                                            "ON c.id = os.cliente_id) " &
                                            "ON p.id = c.pessoa_id) " &
                                            "ON u.id = os.usuario_id"

            If String.IsNullOrEmpty(cliente) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.nome LIKE '%" & cliente & "%'"
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " WHERE p.nome LIKE '%" & cliente & "%'"
                End If
            End If

            If parametros.id <> -1 Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE os.id =" & parametros.id
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " AND os.id =" & parametros.id
                End If
            End If

            If parametros.ordem_estado_id <> -1 Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE os.ordem_estado_id =" & parametros.ordem_estado_id
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " AND os.ordem_estado_id =" & parametros.ordem_estado_id
                End If
            End If

            If parametros.marca_id <> -1 Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE os.marca_id =" & parametros.marca_id
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " AND os.marca_id =" & parametros.marca_id
                End If
            End If

            If String.IsNullOrEmpty(parametros.modelo) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE os.modelo LIKE '%" & parametros.modelo & "%'"
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " AND os.modelo LIKE '%" & parametros.modelo & "%'"
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

    Public Function getOrdensRpt(ByVal parametros As Ordem, ByVal cliente As String) As OleDbDataReader
        Try

            If parametros.id = 0 Then
                parametros.id = -1
            End If
            If parametros.ordem_estado_id = 0 Then
                parametros.ordem_estado_id = -1
            End If
            If parametros.marca_id = 0 Then
                parametros.marca_id = -1
            End If


            Dim ordens As OleDb.OleDbDataReader
            Dim flag As Integer = 0
            Dim gridFiltroSql As String
            gridFiltroSql = "SELECT oe.nome AS estado, os.id AS nr_ordem, p.nome AS cliente, m.nome AS marca, os.dt_entrada, os.dt_saida, os.modelo, os.preco_concerto, os.defeito, os.laudo, os.dt_alteracao, os.observacao, u.username AS usuario " &
                                            "FROM usuarios AS u  " &
                                            "INNER JOIN (pessoas AS p " &
                                            "INNER JOIN (clientes AS c " &
                                            "INNER JOIN (marcas as m " &
                                            "INNER JOIN (ordens_estados AS oe " &
                                            "INNER JOIN ordens_servico AS os ON oe.id = os.ordem_estado_id) " &
                                            "ON m.id = os.marca_id) " &
                                            "ON c.id = os.cliente_id) " &
                                            "ON p.id = c.pessoa_id) " &
                                            "ON u.id = os.usuario_id"

            If String.IsNullOrEmpty(cliente) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE p.nome LIKE '%" & cliente & "%'"
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " WHERE p.nome LIKE '%" & cliente & "%'"
                End If
            End If

            If parametros.id <> -1 Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE os.id =" & parametros.id
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " AND os.id =" & parametros.id
                End If
            End If

            If parametros.ordem_estado_id <> -1 Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE os.ordem_estado_id =" & parametros.ordem_estado_id
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " AND os.ordem_estado_id =" & parametros.ordem_estado_id
                End If
            End If

            If parametros.marca_id <> -1 Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE os.marca_id =" & parametros.marca_id
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " AND os.marca_id =" & parametros.marca_id
                End If
            End If

            If String.IsNullOrEmpty(parametros.modelo) = False Then
                If flag = 0 Then
                    gridFiltroSql = gridFiltroSql & " WHERE os.modelo LIKE '%" & parametros.modelo & "%'"
                    flag = 1

                Else
                    gridFiltroSql = gridFiltroSql & " AND os.modelo LIKE '%" & parametros.modelo & "%'"
                End If
            End If

            Conectar()
            ordens = retornaQuery(gridFiltroSql)
            ' Desconectar()

            Return ordens
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return Nothing
        End Try


    End Function


    ' FUNCAO insereOrdem
    ' @param ordem 
    ' @return true or false 
    '====================================================================================
    Public Function inserirOrdem(ByVal ordem As Ordem) As Boolean
        Try
            Dim sql As String = "INSERT INTO ordens_servico (marca_id, ordem_estado_id , modelo , defeito, laudo, preco_concerto," &
                                " cliente_id, usuario_id, dt_entrada, dt_saida, dt_cadastro, observacao, dt_alteracao)" &
                                " VALUES ( ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

            Dim cmd As New OleDbCommand(sql, conexao)

            cmd.Parameters.Add(New OleDbParameter("marca_id", ordem.marca_id))
            cmd.Parameters.Add(New OleDbParameter("ordem_estado_id", ordem.ordem_estado_id))
            cmd.Parameters.Add(New OleDbParameter("modelo", ordem.modelo))
            cmd.Parameters.Add(New OleDbParameter("defeito", ordem.defeito))
            cmd.Parameters.Add(New OleDbParameter("laudo", ordem.laudo))
            cmd.Parameters.Add(New OleDbParameter("preco_concerto", ordem.preco_concerto))
            cmd.Parameters.Add(New OleDbParameter("cliente_id", ordem.cliente_id))
            cmd.Parameters.Add(New OleDbParameter("usuario_id", ordem.usuario_id))
            cmd.Parameters.Add(New OleDbParameter("dt_entrada", ordem.dt_entrada))
            cmd.Parameters.Add(New OleDbParameter("dt_saida", ordem.dt_saida))
            cmd.Parameters.Add(New OleDbParameter("dt_cadastro", ordem.dt_cadastro))
            cmd.Parameters.Add(New OleDbParameter("observacao", ordem.observacao))
            cmd.Parameters.Add(New OleDbParameter("dt_alteracao", ordem.dt_alteracao))

            Conectar()
            Dim cont As Integer = cmd.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function


    'FUNCAO alterarOrdem
    '@param ordem
    '@return true or false
    '=======================================================================================================================
    Public Function alterarOrdem(ByVal ordem As Ordem) As Boolean
        Try
            Dim sql As String = "UPDATE ordens_servico SET [usuario_id] = @usuario_id, [cliente_id] = @cliente_id, " &
                                " [marca_id] = @marca_id, [modelo] = @modelo , [ordem_estado_id] = @ordem_estado_id, [defeito] = @defeito, [laudo] = @laudo," &
                                " [preco_concerto] = @preco_concerto, [dt_entrada] = @dt_entrada," &
                                " [dt_saida] = @dt_saida, [dt_alteracao] = @dt_alteracao, [observacao] = @observacao WHERE id = " & ordem.id.ToString
            Dim cmd As New OleDbCommand(sql, conexao)

            cmd.Parameters.Add(New OleDbParameter("usuario_id", ordem.usuario_id))
            cmd.Parameters.Add(New OleDbParameter("cliente_id", ordem.cliente_id))
            cmd.Parameters.Add(New OleDbParameter("marca_id", ordem.marca_id))
            cmd.Parameters.Add(New OleDbParameter("modelo", ordem.modelo))
            cmd.Parameters.Add(New OleDbParameter("ordem_estado_id", ordem.ordem_estado_id))
            cmd.Parameters.Add(New OleDbParameter("defeito", ordem.defeito))
            cmd.Parameters.Add(New OleDbParameter("laudo", ordem.laudo))
            cmd.Parameters.Add(New OleDbParameter("preco_concerto", ordem.preco_concerto))
            cmd.Parameters.Add(New OleDbParameter("dt_entrada", ordem.dt_entrada))
            cmd.Parameters.Add(New OleDbParameter("dt_saida", ordem.dt_saida))
            cmd.Parameters.Add(New OleDbParameter("dt_alteracao", ordem.dt_alteracao))
            cmd.Parameters.Add(New OleDbParameter("observacao", ordem.observacao))

            Conectar()
            cmd.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function


    'FUNCAO excluirOrdem
    '@param ordem
    '@return true or false
    '=======================================================================================================================
    Public Function excluirOrdem(ByVal id As Integer) As Boolean
        Try
            Dim sqlOrdem As String = "DELETE FROM ordens_servico WHERE id = " & id.ToString
            Dim cmdOrdem As New OleDbCommand(sqlOrdem, conexao)

            Conectar()
            cmdOrdem.ExecuteNonQuery()
            Desconectar()

            Return True
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Return False
        End Try
    End Function

End Class
