Public Class FormOrdem
    Dim maskaras As New Maskaras
    Dim acessoOrdemModel As New OrdemModel
    Dim acessoClienteModel As New clienteModel

    ' INIT
    '=================================================================
    Private Sub FormOrdem_Load() Handles Me.Load

        If String.IsNullOrEmpty(txtOrdemId.Text) Then
            txtOrdemId.Text = "-1"
        End If

        If txtOrdemId.Text = "-1" Then
            btnDeletarOrdem.Enabled = False
            btnRelatorioOrdem.Enabled = False
        End If

        If FormPrincipal.usuarioSession.getUsuarioFlagAdm = 0 Then
            btnDeletarOrdem.Enabled = False
        End If

        Me.carregaComboMarcas(txtOrdemId.Text)
        Me.carregaComboOrdensEstados(txtOrdemId.Text)

        If String.IsNullOrEmpty(txtClienteId.Text) Then
            txtClienteId.Text = "-1"
        End If

    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    'BOTOES
    '=========================================



    ' PESQUISAR CLIENTE
    '=================================================================
    Private Sub btnPesquisarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCliente.Click
        Dim frm As New FormProcurarCliente()
        Dim resultado As DialogResult
        Dim id As String

        resultado = frm.ShowDialog()

        If (resultado = Windows.Forms.DialogResult.Yes) Then
            id = frm.IDCliente
            txtClienteId.Text = id
            carregaCliente(acessoClienteModel.getClienteById(id))

        End If

    End Sub

    ' CANCELAR
    '=================================================================
    Private Sub btnCancelarOrdem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarOrdem.Click
        Limpar(Me)
        fecharForm(True)
    End Sub

    ' DELETAR
    '==========================================================
    Private Sub btnDeletarOrdem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeletarOrdem.Click
        Dim acessoOrdemModel As New OrdemModel()
        Dim id As Integer
        Dim resposta As Integer = 0
        Dim flag As Boolean

        resposta = confirmaOrdemExclusao(txtOrdemId.Text)

        If resposta = 6 Then
            id = CInt(Me.txtOrdemId.Text)                           ' transforma o id em int
            flag = acessoOrdemModel.excluirOrdem(id)                 ' executa o delete retorna uma flag 
            fecharForm(deleteOrdemSuccess(flag))                         ' flag apresenta uma msg box e depois fecha o formulario
        End If

    End Sub


    ' RELATORIO
    '==========================================================
    Private Sub btnRelatorioOrdem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorioOrdem.Click
        Dim rptOrdem As New RptOrdens
        rptOrdem.relatorioOrdem(CInt(txtOrdemId.Text))

    End Sub

    ' SALVAR
    '==========================================================
    Private Sub btn_SalvarOrdem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarOrdem.Click

        ' para tirar as mascaras é necessario jogar dentro de uma variavel, pq nao sei
        '======================================================================================
        If String.IsNullOrEmpty(txtPrecoConcerto.Text) Then
            Me.txtPrecoConcerto_LostFocus()
        End If

        Dim preco_concerto As String = txtPrecoConcerto.Text
        Dim acessoOrdemModel As New OrdemModel()
        Dim ordem As New Ordem()
        Dim data As DateTime = DateTime.Now
        Dim dt_cadastro As String
        Dim dt_entrada As String = mskDtEntrada.Text
        Dim dt_saida As String = mskDtSaida.Text
        Dim dt_alteracao As String
        Dim callBack As Boolean
        Dim valida As Boolean = True

        dt_cadastro = FormatDateTime(data, DateFormat.ShortDate)        ' tratamento da data    
        dt_cadastro = maskaras.retiraMaskaraData(dt_cadastro)           ' dt_cadastro no formato padrao do banco 
        dt_entrada = maskaras.retiraMaskaraData(dt_entrada)
        dt_saida = maskaras.retiraMaskaraData(dt_saida)
        dt_alteracao = (FormatDateTime(data, DateFormat.ShortDate))
        dt_alteracao = maskaras.retiraMaskaraData(dt_alteracao)

        ' objeto cliente recebe os valores
        '=======================================
        ordem.id = CInt(txtOrdemId.Text)
        ordem.cliente_id = CInt(txtClienteId.Text)
        ordem.usuario_id = FormPrincipal.usuarioSession.getUsuarioId
        ordem.modelo = txtModelo.Text
        ordem.marca_id = cmbMarca.SelectedValue
        ordem.defeito = txtDefeito.Text
        ordem.laudo = txtLaudo.Text
        ordem.preco_concerto = preco_concerto
        ordem.ordem_estado_id = cmbEstadoOrdem.SelectedValue
        ordem.dt_entrada = dt_entrada
        If IsDate(dt_saida) = False Then
            ordem.dt_saida = dt_entrada
        Else
            ordem.dt_saida = dt_saida
        End If
        ordem.dt_cadastro = dt_cadastro
        ordem.dt_alteracao = dt_alteracao
        ordem.observacao = txtObservacao.Text

        If validaCamposOrdem(txtClienteNome.Text, txtModelo.Text, cmbMarca.SelectedIndex, cmbEstadoOrdem.SelectedIndex, txtDefeito.Text, mskDtEntrada.Text) = True Then
            valida = False
        End If
        Dim aux As String = mskDtSaida.Text

        aux = maskaras.retiraMaskara(aux)
        If String.IsNullOrEmpty(aux) = True Then
            aux = mskDtEntrada.Text
        Else
            aux = mskDtSaida.Text
        End If
        If validaData(aux) = False Then
            valida = False
        End If

        callBack = False
        If ordem.id = -1 Then
            If valida = True Then
                callBack = acessoOrdemModel.inserirOrdem(ordem)
            End If
        Else
            If valida = True Then
                callBack = acessoOrdemModel.alterarOrdem(ordem)
            End If
        End If
        If callBack = True Then
            Me.fecharForm(successOrdem(callBack))
        End If
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

    ' PRECO CONCERTO
    '-----------------------
    Private Sub txtPrecoConcerto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecoConcerto.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete And Not Convert.ToString(e.KeyChar).Equals(",")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecoConcerto_LostFocus() Handles txtPrecoConcerto.LostFocus
        If String.IsNullOrEmpty(txtPrecoConcerto.Text) Then
            txtPrecoConcerto.Text = 0
        End If
        txtPrecoConcerto.Text = FormatCurrency(CDbl(txtPrecoConcerto.Text), 2, TriState.True, TriState.False, TriState.True)
    End Sub

    ' DATA ENTRADA
    '-----------------------
    Private Sub mskDtEntrada_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDtEntrada.GotFocus
        Me.mskDtEntrada.UseSystemPasswordChar = False
        Me.mskDtEntrada.Mask = "##/##/####"
        Me.mskDtEntrada.Focus()
    End Sub

    Private Sub mskDtEntrada_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDtEntrada.LostFocus
        Dim temp As String = mskDtEntrada.Text
        temp = maskaras.retiraMaskara(temp)
        Dim teste As String
        If String.IsNullOrEmpty(temp) Then
            teste = Format(Date.Now, "dd/MM/yyyy")
            Me.mskDtEntrada.Text = teste
        End If

    End Sub

    Private Sub mskDtEntrada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskDtEntrada.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    ' DATA SAIDA
    '-----------------------
    Private Sub mskDtSaida_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDtSaida.GotFocus
        Me.mskDtSaida.UseSystemPasswordChar = False
        Me.mskDtSaida.Mask = "##/##/####"
        Me.mskDtSaida.Focus()
    End Sub

    Private Sub mskDtSaida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskDtSaida.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
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


    ' esta funcao carrega os dados da ordem SOMENTE UTILIZADA NO ALTERAR ORDEM
    '===================================================================================
    Public Sub carregaOrdem(ByVal ordem As Ordem)

        Me.txtOrdemId.Text = ordem.id
        Me.txtClienteId.Text = ordem.cliente_id
        Me.txtUsuarioId.Text = ordem.usuario_id
        Me.cmbEstadoOrdem.SelectedItem = ordem.ordem_estado_id
        Me.cmbMarca.SelectedItem = ordem.marca_id
        Me.txtDefeito.Text = ordem.defeito
        Me.txtLaudo.Text = ordem.laudo
        Me.txtPrecoConcerto.Text = ordem.preco_concerto
        Me.txtModelo.Text = ordem.modelo
        Me.mskDtEntrada.Text = validaDataXP(ordem.dt_entrada)
        Me.mskDtSaida.Text = validaDataXP(ordem.dt_saida)
        Me.txtObservacao.Text = ordem.observacao
        Me.txtClienteNome.Text = acessoClienteModel.getClienteById(ordem.cliente_id).nome
        Me.txtClienteRg.Text = acessoClienteModel.getClienteById(ordem.cliente_id).rg
        Me.txtClienteEmail.Text = acessoClienteModel.getClienteById(ordem.cliente_id).email

    End Sub

    ' esta funcao carrega os dados do cliente SOMENTE UTIZADA NO INCLUIR ORDEM
    '=================================================================================
    Public Sub carregaCliente(ByVal cliente As Cliente)
        Me.txtClienteId.Text = cliente.id.ToString()
        Me.txtClienteNome.Text = cliente.nome
        Me.txtClienteEmail.Text = cliente.email
        Me.txtClienteRg.Text = cliente.rg
    End Sub

    ' carrega a combo com os estados das ordens
    '=================================================================================
    Public Function carregaComboOrdensEstados(ByVal id As Integer)
        Dim sql As String = "SELECT id, nome FROM ordens_estados"
        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, acessoOrdemModel.conexao)
        Dim ds As New DataSet
        Dim ordem_estado_id As Integer

        If id <> -1 Then
            ordem_estado_id = acessoOrdemModel.getOrdemById(id).ordem_estado_id         ' combobox comeca em 0 preciso diminuir 1
        Else
            ordem_estado_id = 0
        End If
        Try
            acessoOrdemModel.Conectar()
            adapter.Fill(ds, "ordens_estados")
            Me.cmbEstadoOrdem.DataSource = ds.Tables(0)
            Me.cmbEstadoOrdem.DisplayMember = "nome"
            Me.cmbEstadoOrdem.ValueMember = "id"
            Me.cmbEstadoOrdem.SelectedValue = ordem_estado_id
            acessoOrdemModel.Desconectar()
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try

        Return True
    End Function

    ' carrega a combo com as marcas 
    '=================================================================================
    Public Function carregaComboMarcas(ByVal id As Integer)
        Dim sql As String = "SELECT id, nome FROM marcas"
        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, acessoOrdemModel.conexao)
        Dim ds As New DataSet
        Dim marca_id As Integer

        If id <> -1 Then
            marca_id = (acessoOrdemModel.getOrdemById(id).marca_id)             ' combobox comeca em 0 preciso diminuir 1
        Else
            marca_id = 0
        End If

        Try
            acessoOrdemModel.Conectar()
            adapter.Fill(ds, "marcas")
            Me.cmbMarca.DataSource = ds.Tables(0)
            Me.cmbMarca.DisplayMember = "nome"
            Me.cmbMarca.ValueMember = "id"
            Me.cmbMarca.SelectedValue = marca_id
            acessoOrdemModel.Desconectar()
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
        Return True
    End Function

    ' fecha o formulario da ordem
    '=====================================================================
    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub


End Class