Public Class FormCliente

    Dim maskaras As New Maskaras()

    Public Sub FormCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If String.IsNullOrEmpty(txtClienteId.Text) Then
            txtClienteId.Text = "-1"
        End If
    End Sub

    '   formulario
    '==========================================================

    ' RG
    '-----------------------
    Private Sub txtClienteRg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClienteRg.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    ' CPF
    '-----------------------
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

    ' CEP
    '-----------------------
    Private Sub mskClienteCep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskClienteCep.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    Private Sub mskClienteCep_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskClienteCep.GotFocus
        Me.mskClienteCep.UseSystemPasswordChar = False
        Me.mskClienteCep.Mask = "#####-###"
        Me.mskClienteCep.Focus()
    End Sub

    ' TELEFONE 1
    '-----------------------
    Private Sub mskClienteTelefone1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskClienteTelefone1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    Private Sub mskClienteTelefone1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskClienteTelefone1.GotFocus
        Me.mskClienteTelefone1.UseSystemPasswordChar = False
        Me.mskClienteTelefone1.Mask = "(##)####-####"
        Me.mskClienteTelefone1.Focus()
    End Sub

    ' TELEFONE 2
    '-----------------------
    Private Sub mskClienteTelefone2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskClienteTelefone2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    Private Sub mskClienteTelefone2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskClienteTelefone2.GotFocus
        Me.mskClienteTelefone2.UseSystemPasswordChar = False
        Me.mskClienteTelefone2.Mask = "(##)####-####"
        Me.mskClienteTelefone2.Focus()
    End Sub

    ' TELEFONE 3
    '-----------------------
    Private Sub mskClienteTelefone3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskClienteTelefone3.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    Private Sub mskClienteTelefone3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskClienteTelefone3.GotFocus
        Me.mskClienteTelefone3.UseSystemPasswordChar = False
        Me.mskClienteTelefone3.Mask = "(##)####-####"
        Me.mskClienteTelefone3.Focus()
    End Sub

    '####################

    ' botao adicionar
    '==========================================================

    Private Sub btn_SalvarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SalvarCliente.Click

        ' para tirar as mascaras é necessario jogar dentro de uma variavel, pq nao sei
        '======================================================================================
        Dim clienteCpf As String = maskaras.retiraMaskara(mskClienteCpf.Text)
        Dim clienteCep As String = maskaras.retiraMaskara(mskClienteCep.Text)
        Dim clienteTelefone1 As String = maskaras.retiraMaskara(mskClienteTelefone1.Text)
        Dim clienteTelefone2 As String = maskaras.retiraMaskara(mskClienteTelefone2.Text)
        Dim clienteTelefone3 As String = maskaras.retiraMaskara(mskClienteTelefone3.Text)
        Dim acessoModel As New clienteModel()
        Dim cliente As New Cliente()
        Dim data As DateTime = DateTime.Now
        Dim dt_cadastro As String
        Dim callBack As Boolean

        dt_cadastro = FormatDateTime(data, DateFormat.ShortDate)        ' tratamento da data    
        dt_cadastro = maskaras.retiraMaskaraData(dt_cadastro)           ' dt_cadastro no formato padrao do banco 

        ' objeto cliente recebe os valores
        '=======================================
        cliente.id = CInt(txtClienteId.Text)
        cliente.nome = txtClienteNome.Text
        cliente.rg = txtClienteRg.Text
        cliente.cpf = clienteCpf
        cliente.endereco = txtClienteEndereco.Text
        cliente.cep = clienteCep
        cliente.email = txtClienteEmail.Text
        cliente.telefone_1 = clienteTelefone1
        cliente.telefone_2 = clienteTelefone2
        cliente.telefone_3 = clienteTelefone3
        cliente.data = dt_cadastro


        MsgBox(cliente.id.ToString)

        If cliente.id = 0 Then
            'verifica se os campos nome e rg foram preenchidos
            If validaCamposCliente(txtClienteNome.Text, txtClienteRg.Text) = False Then
                callBack = acessoModel.inserirCliente(cliente)                          ' insere
                If callBack = True Then                                                 ' verifica se inseriu no banco
                    successCliente(callBack)
                End If
            End If
        Else
            If validaCamposCliente(txtClienteNome.Text, txtClienteRg.Text) = False Then
                callBack = True
                acessoModel.alterarCliente(cliente)                                     ' altera clientes
                If callBack = True Then                                                 ' verifica se inseriu no banco
                    successCliente(callBack)
                End If
            End If
        End If
        Me.Close()
        Me.Dispose()

    End Sub

    ' botao cancelar
    '==========================================================
    Private Sub btn_CancelarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarCliente.Click
        Limpar(Me)
        fecharForm(True)
    End Sub

    Public Sub carregaDados(ByVal cliente As DataSet)
        Dim dsCliente As DataSet

        dsCliente = cliente
        Me.txtClienteId.DataBindings.Add(New Binding("text", dsCliente, "pessoas.id"))
        Me.txtClienteNome.DataBindings.Add(New Binding("text", dsCliente, "pessoas.nome"))
        Me.txtClienteRg.DataBindings.Add(New Binding("text", dsCliente, "pessoas.rg"))
        Me.mskClienteCpf.DataBindings.Add(New Binding("text", dsCliente, "pessoas.cpf"))
        Me.txtClienteEndereco.DataBindings.Add(New Binding("text", dsCliente, "pessoas.endereco"))
        Me.mskClienteCep.DataBindings.Add(New Binding("text", dsCliente, "pessoas.cep"))
        Me.txtClienteEmail.DataBindings.Add(New Binding("text", dsCliente, "pessoas.email"))
        Me.mskClienteTelefone1.DataBindings.Add(New Binding("text", dsCliente, "pessoas.telefone_1"))
        Me.mskClienteTelefone2.DataBindings.Add(New Binding("text", dsCliente, "pessoas.telefone_2"))
        Me.mskClienteTelefone3.DataBindings.Add(New Binding("text", dsCliente, "pessoas.telefone_3"))


    End Sub

    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    '####################
    '  Private Sub Form_AddCliente_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '      Limpar(Me)
    '      Close()
    ' End Sub

End Class