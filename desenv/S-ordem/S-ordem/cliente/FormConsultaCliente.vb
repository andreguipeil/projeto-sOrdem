Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class FormConsultaCliente

    'Public usuarioSessaoId As Integer
    Private dsPessoas As DataSet


    ' ATUALIZA
    '=================================================================
    Private Sub FormConsultaCliente_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.FormConsultaCliente_Load(sender, e)
    End Sub

    ' INIT
    '=================================================================
    Private Sub FormConsultaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim acessoClienteModel As New clienteModel
        Dim cliente As New Cliente

        Limpar(Me)
        gridClientes.DataSource = acessoClienteModel.getClientes(cliente)

    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    ' BOTOES
    '=================================================================


    ' PESQUISAR
    '=================================================================
    Private Sub btnPesquisarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCliente.Click
        Dim cliente As New Cliente
        Dim acessoModel As New clienteModel()

        cliente.nome = txtClienteNome.Text
        cliente.rg = txtClienteRg.Text
        cliente.cpf = mskClienteCpf.Text
        cliente.email = txtClienteEmail.Text
        gridClientes.DataSource = acessoModel.getClientes(cliente)
    End Sub

    ' CANCELAR
    '=================================================================
    Private Sub cancelarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarConsulta.Click
        Limpar(Me)
        Close()
    End Sub

    ' GRID DOUBLE CLICK
    '=================================================================
    Private Sub gridClientes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridClientes.MouseDoubleClick
        Dim acessoClienteModel As New clienteModel()
        Dim id As Integer
        Dim cliente As Cliente

        If gridClientes.RowCount = 1 Then
            gridClienteVazia()
        Else
            If String.IsNullOrEmpty(gridClientes.CurrentRow.Cells("id").Value.ToString) Then
                linhaClienteInvalida()
            Else
                id = gridClientes.CurrentRow.Cells("id").Value.ToString()
                cliente = acessoClienteModel.getClienteById(id)
                '--
                Dim editarCliente As New FormCliente
                editarCliente.carregaDados(cliente)
                'editarCliente.usuarioSessaoId = Me.usuarioSessaoId
                editarCliente.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnRelatorioClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorioClientes.Click
        Dim cliente As New Cliente
        Dim rptClientes As New RptClientes
        cliente.nome = txtClienteNome.Text
        cliente.rg = txtClienteRg.Text
        cliente.cpf = mskClienteCpf.Text
        cliente.email = txtClienteEmail.Text
        rptClientes.relatorioClientes(cliente)
    End Sub


    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    ' FORMULARIO
    '=================================================================

    ' campo RG
    '-----------------------------
    Private Sub clienteRg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClienteRg.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    ' campo CPF 
    '-----------------------------
    Private Sub mskClienteCpf_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskClienteCpf.GotFocus
        Me.mskClienteCpf.UseSystemPasswordChar = False
        Me.mskClienteCpf.Mask = "###.###.###-##"
        Me.mskClienteCpf.Focus()
    End Sub

    Private Sub mskClienteCpf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskClienteCpf.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

End Class
