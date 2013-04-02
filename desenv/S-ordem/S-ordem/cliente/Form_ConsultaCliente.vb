Public Class Form_ConsultaCliente

    Dim gridSql As String = "SELECT id, nome, rg, cpf, email FROM pessoas"

    ' INIT
    '-----------------------------
    Private Sub FormConsultaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conexao As New AcessaDB()
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
        Dim conexao As New AcessaDB()
        Dim DataReader As OleDb.OleDbDataReader
        Dim myDataTable As New DataTable
        Dim gridFiltroSql As String

        gridFiltroSql = "SELECT id, nome, rg, cpf, email FROM pessoas"
        Dim flag As Integer = 0

        '============================================
        If String.IsNullOrEmpty(txtClienteNome.Text) = False Then
            If flag = 0 Then
                MsgBox("aqui")
                gridFiltroSql = "SELECT id, nome, rg, cpf, email FROM pessoas WHERE nome LIKE '" & txtClienteNome.Text & "'"
                flag = 1
            Else
                MsgBox("aqui")
                gridFiltroSql = "SELECT id, nome, rg, cpf, email FROM pessoas WHERE nome LIKE '" & txtClienteNome.Text & "'"
            End If
        End If

        '=============================================
        If String.IsNullOrEmpty(txtClienteRg.Text) = False Then
            If flag = 0 Then
                gridFiltroSql = " SELECT id, nome, rg, cpf, email FROM pessoas WHERE rg LIKE '" & txtClienteRg.Text & "'"
                flag = 1
            Else
                gridFiltroSql = gridFiltroSql & " UNION SELECT id, nome, rg, cpf, email FROM pessoas WHERE rg LIKE '" & txtClienteRg.Text & "'"
            End If
        End If

        '=============================================
        If String.IsNullOrEmpty(mskClienteCpf.Text) = False Then
            Dim clienteCpf As String = Replace(Replace((mskClienteCpf.Text), "-", ""), ",", "")

            If flag = 0 Then
                gridFiltroSql = " SELECT id, nome, rg, cpf, email FROM pessoas WHERE cpf LIKE '" & clienteCpf & "'"
                flag = 1
            Else
                gridFiltroSql = gridFiltroSql & " UNION SELECT id, nome, rg, cpf, email FROM pessoas WHERE cpf LIKE '" & clienteCpf & "'"
            End If
        End If

        '==============================================
        If String.IsNullOrEmpty(txtClienteEmail.Text) = False Then
            If flag = 0 Then
                gridFiltroSql = " SELECT id, nome, rg, cpf, email FROM pessoas WHERE email LIKE '*" & txtClienteEmail.Text & "*'"
                flag = 1
            Else
                gridFiltroSql = gridFiltroSql & " UNION SELECT id, nome, rg, cpf, email FROM pessoas WHERE email LIKE '*" & txtClienteEmail.Text & "*'"
            End If
        End If

        MessageBox.Show(gridFiltroSql)

        conexao.Conectar()
        DataReader = conexao.retornaQuery(gridFiltroSql)
        myDataTable.Load(DataReader)
        gridClientes.DataSource = myDataTable
        gridClientes.ReadOnly = True

    End Sub


End Class
