Public Class FormLixao

    Dim acessoProgramaModel As New programaModel()
    Private gridSql As String = "SELECT * FROM ordens_servico"


    Private Sub FormConsultaOrdem_Activated(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.FormConsultaOrdem_Load()
    End Sub

    Private Sub FormConsultaOrdem_Load() Handles Me.Load

        Dim DataReader As OleDb.OleDbDataReader
        Dim myDataTable As New DataTable
        Limpar(Me)

         acessoProgramaModel.Conectar()
        DataReader = acessoProgramaModel.retornaQuery(gridSql)
        myDataTable.Load(DataReader)
        gridLixao.DataSource = myDataTable
        gridLixao.ReadOnly = True
        acessoProgramaModel.Desconectar()
    End Sub


    ' botao cancelar
    '-----------------------------
    Private Sub btnCancelarLixao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarLixao.Click
        Limpar(Me)
        Close()
    End Sub

End Class