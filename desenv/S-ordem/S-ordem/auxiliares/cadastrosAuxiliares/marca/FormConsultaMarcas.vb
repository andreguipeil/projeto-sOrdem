Public Class FormConsultaMarcas

    ' INIT
    '=================================================================
    Private Sub FormConsultaMarcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim acessoModel As New MarcaModel()
        Dim myDataTable As New DataTable

        Limpar(Me)
        gridMarcas.DataSource = acessoModel.getMarcas
    End Sub

    ' ATUALIZA
    '=================================================================
    Private Sub FormConsultaMarca_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.FormConsultaMarcas_Load(sender, e)
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
    Private Sub gridMarcas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridMarcas.MouseDoubleClick
        Dim acessoMarcaModel As New MarcaModel()
        Dim id As Integer
        Dim marca As Marca

        If gridMarcas.RowCount = 1 Then
            gridClienteVazia()
        Else
            If String.IsNullOrEmpty(gridMarcas.CurrentRow.Cells("id").Value.ToString) Then
                linhaClienteInvalida()
            Else
                id = gridMarcas.CurrentRow.Cells("id").Value.ToString()
                marca = acessoMarcaModel.getMarcaById(id)
                '--
                Dim editarMarca As New FormMarca
                editarMarca.carregaDados(marca)
                editarMarca.ShowDialog()
            End If
        End If
    End Sub

    ' SELECIONAR
    '=================================================================
    Private Sub btnSelecionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionar.Click
        Dim acessoMarcaModel As New MarcaModel()
        Dim id As Integer
        Dim marca As Marca

        If gridMarcas.RowCount = 1 Then
            gridMarcaVazia()
        Else
            If String.IsNullOrEmpty(gridMarcas.CurrentRow.Cells("id").Value.ToString) Then
                linhaMarcaInvalida()
            Else
                id = gridMarcas.CurrentRow.Cells("id").Value.ToString()
                marca = acessoMarcaModel.getMarcaById(id)
                '--
                Dim editarMarca As New FormMarca
                editarMarca.carregaDados(marca)
                editarMarca.ShowDialog()
            End If
        End If
    End Sub

    ' CANCELAR
    '=================================================================
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        fecharForm(True)
    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    'fecha o formulario do cliente
    '=====================================================================
    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub


End Class