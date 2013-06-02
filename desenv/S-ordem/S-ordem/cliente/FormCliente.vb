Public Class FormCliente
    Dim maskaras As New Maskaras()
    ' Public usuarioSessaoId As Integer
    '
    'INIT
    '============================================================================================
    Public Sub FormCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(txtClienteId.Text) Then
            txtClienteId.Text = "-1"
            txtClientePessoaId.Text = "-1"
        End If

        If txtClienteId.Text = "-1" Then
            btnDeletarCliente.Enabled = False
            btnRelatorioCliente.Enabled = False

        End If
        If FormPrincipal.usuarioSession.getUsuarioFlagAdm = 0 Then
            btnDeletarCliente.Enabled = False
        End If

    End Sub


    '
    '
    '
    '###############################################################################################################
    '
    '
    '


    '   FORMULARIO
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
        Me.mskClienteTelefone1.Mask = "####-####"
        Me.mskClienteTelefone1.Focus()
    End Sub

    Private Sub mskClienteDdd_1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskClienteDdd_1.GotFocus
        Me.mskClienteDdd_1.UseSystemPasswordChar = False
        Me.mskClienteDdd_1.Mask = "(##)"
        Me.mskClienteDdd_1.Focus()

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
        Me.mskClienteTelefone2.Mask = "####-####"
        Me.mskClienteTelefone2.Focus()
    End Sub

    Private Sub mskClienteDdd_2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskClienteDdd_2.GotFocus
        Me.mskClienteDdd_2.UseSystemPasswordChar = False
        Me.mskClienteDdd_2.Mask = "(##)"
        Me.mskClienteDdd_2.Focus()

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
        Me.mskClienteTelefone3.Mask = "####-####"
        Me.mskClienteTelefone3.Focus()
    End Sub

    Private Sub mskClienteDdd_3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskClienteDdd_3.GotFocus
        Me.mskClienteDdd_3.UseSystemPasswordChar = False
        Me.mskClienteDdd_3.Mask = "(##)"
        Me.mskClienteDdd_3.Focus()

    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    '   BOTOES
    '==========================================================


    ' SALVAR
    '==========================================================
    Private Sub btn_SalvarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SalvarCliente.Click

        ' para tirar as mascaras é necessario jogar dentro de uma variavel, pq nao sei
        '======================================================================================
        Dim clienteCpf As String = maskaras.retiraMaskara(mskClienteCpf.Text)
        Dim clienteCep As String = maskaras.retiraMaskara(mskClienteCep.Text)
        Dim clienteTelefone1 As String = maskaras.retiraMaskara(mskClienteTelefone1.Text)
        Dim clienteTelefone2 As String = maskaras.retiraMaskara(mskClienteTelefone2.Text)
        Dim clienteTelefone3 As String = maskaras.retiraMaskara(mskClienteTelefone3.Text)
        Dim clienteDdd1 As String = maskaras.retiraMaskara(mskClienteDdd_1.Text)
        Dim clienteDdd2 As String = maskaras.retiraMaskara(mskClienteDdd_2.Text)
        Dim clienteDdd3 As String = maskaras.retiraMaskara(mskClienteDdd_3.Text)
        Dim acessoModel As New clienteModel()
        Dim cliente As New Cliente()
        Dim data As DateTime = DateTime.Now
        Dim dt_cadastro As String
        Dim dt_alteracao As String
        Dim callBack As Boolean

        dt_alteracao = (FormatDateTime(data, DateFormat.ShortDate))
        dt_alteracao = maskaras.retiraMaskaraData(dt_alteracao)

        dt_cadastro = FormatDateTime(data, DateFormat.ShortDate)        ' tratamento da data    
        dt_cadastro = maskaras.retiraMaskaraData(dt_cadastro)           ' dt_cadastro no formato padrao do banco 

        ' objeto cliente recebe os valores
        '=======================================
        cliente.id = CInt(txtClienteId.Text)
        cliente.pessoa_id = CInt(txtClientePessoaId.Text)
        cliente.nome = txtClienteNome.Text
        cliente.rg = txtClienteRg.Text
        cliente.cpf = clienteCpf
        cliente.endereco = txtClienteEndereco.Text
        cliente.cep = clienteCep
        cliente.email = txtClienteEmail.Text
        cliente.telefone_1 = clienteTelefone1
        cliente.ddd_1 = clienteDdd1
        cliente.telefone_2 = clienteTelefone2
        cliente.ddd_2 = clienteDdd2
        cliente.telefone_3 = clienteTelefone3
        cliente.ddd_3 = clienteDdd3
        cliente.dt_cadastro = dt_cadastro
        cliente.dt_alteracao = dt_alteracao
        cliente.usuario_id = FormPrincipal.usuarioSession.getUsuarioId

        If cliente.id = -1 Then
            'verifica se os campos nome e rg foram preenchidos
            If validaCamposCliente(txtClienteNome.Text, txtClienteRg.Text) = False Then
                callBack = acessoModel.inserirCliente(cliente)                          ' insere
                If callBack = True Then                                                 ' verifica se inseriu no banco
                    successCliente(callBack)
                End If
                fecharForm(True)
            End If
        Else
            If validaCamposCliente(txtClienteNome.Text, txtClienteRg.Text) = False Then
                callBack = acessoModel.alterarCliente(cliente)                          ' altera clientes
                If callBack = True Then                                                 ' verifica se inseriu no banco
                    successCliente(callBack)
                End If
                fecharForm(True)
            End If
        End If
    End Sub

    ' CANCELAR
    '==========================================================
    Private Sub btn_CancelarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarCliente.Click
        Limpar(Me)
        fecharForm(True)
    End Sub

    ' DELETAR
    '==========================================================
    Private Sub btnDeletarCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeletarCliente.Click
        Dim acessoModel As New clienteModel()
        Dim id As Integer
        Dim resposta As Integer = 0
        Dim flag As Boolean

        resposta = confirmaClienteExclusao(txtClienteNome.Text)

        If resposta = 6 Then
            id = CInt(Me.txtClienteId.Text)                         ' transforma o id em int
            flag = acessoModel.excluirCliente(id)                   ' executa o delete retorna uma flag 
            fecharForm(deleteClienteSuccess(flag))                         ' flag apresenta uma msg box e depois fecha o formulario
        End If
    End Sub


    ' RELATORIO
    '==========================================================
    Private Sub btnRelatorioCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorioCliente.Click

        Dim rptCliente As New RptClientes

        rptCliente.relatorioCliente(CInt(txtClienteId.Text))

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

    ' esta funcao carrega os dados do cliente no formulario 
    '=================================================================
    Public Sub carregaDados(ByVal cliente As Cliente)

        Me.txtClienteId.Text = cliente.id.ToString()
        Me.txtClientePessoaId.Text = cliente.pessoa_id.ToString()
        Me.txtClienteNome.Text = cliente.nome
        Me.txtClienteRg.Text = cliente.rg
        Me.mskClienteCpf.Text = cliente.cpf
        Me.mskClienteTelefone1.Text = cliente.telefone_1
        Me.mskClienteDdd_1.Text = cliente.ddd_1
        Me.mskClienteTelefone2.Text = cliente.telefone_2
        Me.mskClienteDdd_2.Text = cliente.ddd_2
        Me.mskClienteTelefone3.Text = cliente.telefone_3
        Me.mskClienteDdd_3.Text = cliente.ddd_3
        Me.txtClienteEmail.Text = cliente.email
        Me.txtClienteEndereco.Text = cliente.endereco
        Me.mskClienteCep.Text = cliente.cep

    End Sub

    'fecha o formulario do cliente
    '=====================================================================
    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub

End Class