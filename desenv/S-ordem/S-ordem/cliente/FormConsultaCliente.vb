Public Class FormConsultaCliente

    Private gridSql As String = "SELECT id, nome, rg, cpf, email FROM pessoas"
    Private dsPessoas As DataSet

    ' INIT
    '-----------------------------
    Private Sub FormConsultaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conexao As New programaModel()
        Dim DataReader As OleDb.OleDbDataReader
        Dim myDataTable As New DataTable

        conexao.Conectar()
        DataReader = conexao.retornaQuery(gridSql)
        myDataTable.Load(DataReader)
        gridClientes.DataSource = myDataTable
        gridClientes.ReadOnly = True

    End Sub
    '####################




    ' botao cancelar
    '-----------------------------
    Private Sub cancelarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarConsulta.Click
        Limpar(Me)
        Close()
    End Sub

    '####################

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


    Private Sub btnPesquisarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCliente.Click
        Dim cliente As New Cliente
        Dim acessoModel As New clienteModel()

        cliente.nome = txtClienteNome.Text
        cliente.rg = txtClienteRg.Text
        cliente.cpf = mskClienteCpf.Text
        cliente.email = txtClienteEmail.Text

        gridClientes.DataSource = acessoModel.getClientes(cliente)
        'gridClientes.ReadOnly = True
    End Sub


    Private Sub gridClientes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridClientes.MouseDoubleClick
        Dim acessoModel As New clienteModel()
        Dim id As Integer
        Dim cliente As DataSet

        id = gridClientes.CurrentRow.Cells("id").Value.ToString()
        cliente = acessoModel.getCliente(id)



        Dim editarCliente As New FormCliente
        editarCliente.carregaDados(cliente)
        editarCliente.ShowDialog()


    End Sub
End Class
