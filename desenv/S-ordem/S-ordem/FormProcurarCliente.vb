Public Class FormProcurarCliente
    Private _IDCliente As Integer
    Dim acessoClienteModel As New clienteModel



    ' pega o id do cliente
    '================================================
    ReadOnly Property IDCliente() As String
        Get
            Return _IDCliente
        End Get
    End Property


    ' INIT
    '=================================================================
    Private Sub FormProcurarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        acessoClienteModel.atualizarCliente()
        gridClientes.ReadOnly = True
    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    ' FILTRO
    '=================================================================
    Private Sub txtClienteNome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClienteNome.TextChanged

        gridClientes.DataSource = acessoClienteModel.buscarCliente(txtClienteNome.Text)

    End Sub


    '
    '
    '
    '###############################################################################################################
    '
    '
    '


    ' SELECIONAR
    '=================================================================
    Private Sub btnSelecionar_Click() Handles btnSelecionar.Click
        If gridClientes.RowCount = 1 Then
            gridOrdemVazia()
            Me.DialogResult = Windows.Forms.DialogResult.None
        Else
            If String.IsNullOrEmpty(gridClientes.CurrentRow.Cells("id").Value.ToString) Then
                linhaOrdemInvalida()
                Me.DialogResult = Windows.Forms.DialogResult.None
            Else
                _IDCliente = gridClientes.CurrentRow.Cells("id").Value.ToString()
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Me.fecharForm(True)
            End If
        End If
    End Sub

    ' DOUBLE CLICK
    '=================================================================
    Private Sub gridClientes_MouseDoubleClick() Handles gridClientes.MouseDoubleClick

        If gridClientes.RowCount = 1 Then
            gridClienteVazia()
        Else
            If String.IsNullOrEmpty(gridClientes.CurrentRow.Cells("id").Value.ToString) Then
                linhaClienteInvalida()
            Else
                _IDCliente = gridClientes.CurrentRow.Cells("id").Value.ToString()
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Me.fecharForm(True)
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

    ' FUNCOES AUXILIARES
    '=================================================================

    ' fechar form
    '=================================================================
    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub


End Class