Public Class FormConsultaOrdem
    Public usuarioSessaoId As Integer
    Dim acessoProgramaModel As New programaModel()
    Private gridSql As String = "SELECT oe.nome AS estado, os.id AS nr_ordem, p.nome AS cliente, m.nome AS marca, os.dt_entrada, os.dt_saida, os.modelo, os.preco_concerto, os.defeito, os.laudo, os.dt_alteracao, os.observacao, u.username AS usuario " &
                                "FROM usuarios AS u  " &
                                "INNER JOIN (pessoas AS p " &
                                "INNER JOIN (clientes AS c " &
                                "INNER JOIN (marcas as m " &
                                "INNER JOIN (ordens_estados AS oe " &
                                "INNER JOIN ordens_servico AS os ON oe.id = os.ordem_estado_id) " &
                                "ON m.id = os.marca_id) " &
                                "ON c.id = os.cliente_id) " &
                                "ON p.id = c.pessoa_id) " &
                                "ON u.id = os.usuario_id;"

    Private Sub FormConsultaOrdem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.FormConsultaOrdem_Load()
    End Sub

    Private Sub FormConsultaOrdem_Load() Handles Me.Load

        Dim DataReader As OleDb.OleDbDataReader
        Dim myDataTable As New DataTable
        Limpar(Me)

        Me.carregaComboMarcasConsulta()
        Me.carregaComboOrdensEstadosConsulta()
        acessoProgramaModel.Conectar()
        DataReader = acessoProgramaModel.retornaQuery(gridSql)
        myDataTable.Load(DataReader)
        gridOrdens.DataSource = myDataTable
        gridOrdens.ReadOnly = True
        acessoProgramaModel.Desconectar()
    End Sub


    Public Function carregaComboMarcasConsulta()
        Dim sql As String = "SELECT id, nome FROM marcas"
        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, acessoProgramaModel.conexao)
        Dim ds As New DataSet

        Try
            acessoProgramaModel.Conectar()
            adapter.Fill(ds, "marcas")
            Me.cmbMarca.DataSource = ds.Tables(0)
            Me.cmbMarca.DisplayMember = "nome"
            Me.cmbMarca.ValueMember = "id"
            Me.cmbMarca.SelectedIndex = -1
            acessoProgramaModel.Desconectar()
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try

        Return True
    End Function


    Public Function carregaComboOrdensEstadosConsulta()
        Dim sql As String = "SELECT id, nome FROM ordens_estados"
        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, acessoProgramaModel.conexao)
        Dim ds As New DataSet

        Try
            acessoProgramaModel.Conectar()
            adapter.Fill(ds, "ordens_estados")
            Me.cmbEstadoOrdem.DataSource = ds.Tables(0)
            Me.cmbEstadoOrdem.DisplayMember = "nome"
            Me.cmbEstadoOrdem.ValueMember = "id"
            Me.cmbEstadoOrdem.SelectedIndex = -1
            acessoProgramaModel.Desconectar()
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try

        Return True
    End Function

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    Private Sub btnPesquisarOrdem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarOrdem.Click
        Dim ordem As New Ordem()
        Dim cliente As String
        Dim acessoOrdemModel As New OrdemModel()
        Dim maskara As New Maskaras()

        cliente = txtConsultaCliente.Text

        If String.IsNullOrEmpty(txtConsultaNrOrdem.Text) Then
            ordem.id = -1
        Else
            ordem.id = txtConsultaNrOrdem.Text
        End If

        If String.IsNullOrEmpty(cmbMarca.SelectedValue) Then
            ordem.marca_id = -1
        Else
            ordem.marca_id = cmbMarca.SelectedValue
        End If

        If String.IsNullOrEmpty(cmbEstadoOrdem.SelectedValue) Then
            ordem.ordem_estado_id = -1
        Else
            ordem.ordem_estado_id = cmbEstadoOrdem.SelectedValue
        End If
        ordem.modelo = txtConsultaModelo.Text
        gridOrdens.DataSource = acessoOrdemModel.getOrdens(ordem, cliente)
    End Sub

    ' botao cancelar
    '-----------------------------
    Private Sub btnCancelarOrdem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarOrdem.Click
        Limpar(Me)
        Close()
    End Sub


    Private Sub gridOrdens_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridOrdens.MouseDoubleClick
        Dim acessoOrdemModel As New OrdemModel()
        Dim id As Integer
        Dim ordem As Ordem

        If gridOrdens.RowCount = 1 Then
            gridOrdemVazia()
        Else
            If String.IsNullOrEmpty(gridOrdens.CurrentRow.Cells("nrOrdem").Value.ToString) Then
                linhaOrdemInvalida()
            Else
                id = gridOrdens.CurrentRow.Cells("nrOrdem").Value.ToString()
                ordem = acessoOrdemModel.getOrdemById(id)
                '--

                Dim editarOrdem As New FormOrdem
                editarOrdem.carregaOrdem(ordem)
                editarOrdem.ShowDialog()
            End If
        End If
    End Sub


    Private Sub btnRelatorioOrdens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorioOrdens.Click
        Dim ordem As New Ordem
        Dim rptOrdens As New RptOrdens
        Dim cliente As String
        Dim acessoOrdemModel As New OrdemModel()
        Dim maskara As New Maskaras()

        cliente = txtConsultaCliente.Text

        If String.IsNullOrEmpty(txtConsultaNrOrdem.Text) Then
            ordem.id = -1
        Else
            ordem.id = txtConsultaNrOrdem.Text
        End If

        If String.IsNullOrEmpty(cmbMarca.SelectedValue) Then
            ordem.marca_id = -1
        Else
            ordem.marca_id = cmbMarca.SelectedValue
        End If

        If String.IsNullOrEmpty(cmbEstadoOrdem.SelectedValue) Then
            ordem.ordem_estado_id = -1
        Else
            ordem.ordem_estado_id = cmbEstadoOrdem.SelectedValue
        End If

        ordem.modelo = txtConsultaModelo.Text
        rptOrdens.relatorioOrdens(ordem, cliente)

    End Sub
End Class
