Public Class FormConsultaEstado

    ' INIT
    '=================================================================
    Private Sub FormConsultaEstados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim acessoEstadoModel As New EstadoModel()
        Dim myDataTable As New DataTable

        Limpar(Me)
        gridEstados.DataSource = acessoEstadoModel.getEstados
    End Sub

    ' ATUALIZA
    '=================================================================
    Private Sub FormConsultaEstado_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.FormConsultaEstados_Load(sender, e)
    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    ' GRID DOUBLE CLICK
    '=================================================================
    Private Sub gridEstados_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridEstados.MouseDoubleClick
        Dim acessoEstadoModel As New EstadoModel()
        Dim id As Integer
        Dim estado As Estado

        If gridEstados.RowCount = 1 Then
            gridestadoVazia()
        Else
            If String.IsNullOrEmpty(gridEstados.CurrentRow.Cells("id").Value.ToString) Then
                linhaEstadoInvalida()
            Else
                id = gridEstados.CurrentRow.Cells("id").Value.ToString()
                estado = acessoEstadoModel.getEstadoById(id)
                '--
                Dim editarEstado As New FormEstado
                editarEstado.carregaDados(estado)
                editarEstado.ShowDialog()
            End If
        End If
    End Sub

    ' SELECIONAR
    '=================================================================
    Private Sub btnSelecionarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionarEstado.Click
        Dim acessoEstadoModel As New EstadoModel()
        Dim id As Integer
        Dim estado As Estado

        If gridEstados.RowCount = 1 Then
            gridestadoVazia()
        Else
            If String.IsNullOrEmpty(gridEstados.CurrentRow.Cells("id").Value.ToString) Then
                linhaEstadoInvalida()
            Else
                id = gridEstados.CurrentRow.Cells("id").Value.ToString()
                estado = acessoEstadoModel.getEstadoById(id)
                '--
                Dim editarEstado As New FormEstado
                editarEstado.carregaDados(estado)
                editarEstado.ShowDialog()
            End If
        End If
    End Sub

    ' CANCELAR
    '=================================================================
    Private Sub btnCancelarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEstado.Click
        fecharForm(True)
    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    ' fecha o formulario do cliente
    '=====================================================================
    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub

End Class