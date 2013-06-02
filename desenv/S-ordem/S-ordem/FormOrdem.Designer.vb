<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrdem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOrdem))
        Me.groupBoxOrdem = New System.Windows.Forms.GroupBox()
        Me.btnRelatorioOrdem = New System.Windows.Forms.Button()
        Me.PanelCliente = New System.Windows.Forms.Panel()
        Me.btnPesquisarCliente = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtClienteRg = New System.Windows.Forms.TextBox()
        Me.txtClienteNome = New System.Windows.Forms.TextBox()
        Me.txtClienteEmail = New System.Windows.Forms.TextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnDeletarOrdem = New System.Windows.Forms.Button()
        Me.btnCancelarOrdem = New System.Windows.Forms.Button()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.btnSalvarOrdem = New System.Windows.Forms.Button()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.cmbEstadoOrdem = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtUsuarioId = New System.Windows.Forms.TextBox()
        Me.txtClienteId = New System.Windows.Forms.TextBox()
        Me.txtOrdemId = New System.Windows.Forms.TextBox()
        Me.mskDtSaida = New System.Windows.Forms.MaskedTextBox()
        Me.mskDtEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtLaudo = New System.Windows.Forms.TextBox()
        Me.txtPrecoConcerto = New System.Windows.Forms.TextBox()
        Me.txtDefeito = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.lblDtSaida = New System.Windows.Forms.Label()
        Me.lblDtEntrada = New System.Windows.Forms.Label()
        Me.lblTaxa = New System.Windows.Forms.Label()
        Me.lblLaudo = New System.Windows.Forms.Label()
        Me.lblDefeito = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.groupBoxOrdem.SuspendLayout()
        Me.PanelCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxOrdem
        '
        Me.groupBoxOrdem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxOrdem.Controls.Add(Me.btnRelatorioOrdem)
        Me.groupBoxOrdem.Controls.Add(Me.PanelCliente)
        Me.groupBoxOrdem.Controls.Add(Me.btnDeletarOrdem)
        Me.groupBoxOrdem.Controls.Add(Me.btnCancelarOrdem)
        Me.groupBoxOrdem.Controls.Add(Me.txtObservacao)
        Me.groupBoxOrdem.Controls.Add(Me.btnSalvarOrdem)
        Me.groupBoxOrdem.Controls.Add(Me.lblObs)
        Me.groupBoxOrdem.Controls.Add(Me.cmbEstadoOrdem)
        Me.groupBoxOrdem.Controls.Add(Me.lblEstado)
        Me.groupBoxOrdem.Controls.Add(Me.txtUsuarioId)
        Me.groupBoxOrdem.Controls.Add(Me.txtClienteId)
        Me.groupBoxOrdem.Controls.Add(Me.txtOrdemId)
        Me.groupBoxOrdem.Controls.Add(Me.mskDtSaida)
        Me.groupBoxOrdem.Controls.Add(Me.mskDtEntrada)
        Me.groupBoxOrdem.Controls.Add(Me.txtLaudo)
        Me.groupBoxOrdem.Controls.Add(Me.txtPrecoConcerto)
        Me.groupBoxOrdem.Controls.Add(Me.txtDefeito)
        Me.groupBoxOrdem.Controls.Add(Me.txtModelo)
        Me.groupBoxOrdem.Controls.Add(Me.cmbMarca)
        Me.groupBoxOrdem.Controls.Add(Me.lblDtSaida)
        Me.groupBoxOrdem.Controls.Add(Me.lblDtEntrada)
        Me.groupBoxOrdem.Controls.Add(Me.lblTaxa)
        Me.groupBoxOrdem.Controls.Add(Me.lblLaudo)
        Me.groupBoxOrdem.Controls.Add(Me.lblDefeito)
        Me.groupBoxOrdem.Controls.Add(Me.lblModelo)
        Me.groupBoxOrdem.Controls.Add(Me.lblMarca)
        Me.groupBoxOrdem.Location = New System.Drawing.Point(30, 12)
        Me.groupBoxOrdem.Name = "groupBoxOrdem"
        Me.groupBoxOrdem.Size = New System.Drawing.Size(578, 551)
        Me.groupBoxOrdem.TabIndex = 21
        Me.groupBoxOrdem.TabStop = False
        Me.groupBoxOrdem.Text = "Ordem de Serviço"
        '
        'btnRelatorioOrdem
        '
        Me.btnRelatorioOrdem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorioOrdem.Location = New System.Drawing.Point(254, 516)
        Me.btnRelatorioOrdem.Name = "btnRelatorioOrdem"
        Me.btnRelatorioOrdem.Size = New System.Drawing.Size(75, 23)
        Me.btnRelatorioOrdem.TabIndex = 16
        Me.btnRelatorioOrdem.Text = "Relatório"
        Me.btnRelatorioOrdem.UseVisualStyleBackColor = True
        '
        'PanelCliente
        '
        Me.PanelCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelCliente.Controls.Add(Me.btnPesquisarCliente)
        Me.PanelCliente.Controls.Add(Me.lblCliente)
        Me.PanelCliente.Controls.Add(Me.txtClienteRg)
        Me.PanelCliente.Controls.Add(Me.txtClienteNome)
        Me.PanelCliente.Controls.Add(Me.txtClienteEmail)
        Me.PanelCliente.Controls.Add(Me.lblCpf)
        Me.PanelCliente.Controls.Add(Me.lblEmail)
        Me.PanelCliente.Location = New System.Drawing.Point(6, 12)
        Me.PanelCliente.Name = "PanelCliente"
        Me.PanelCliente.Size = New System.Drawing.Size(566, 111)
        Me.PanelCliente.TabIndex = 28
        '
        'btnPesquisarCliente
        '
        Me.btnPesquisarCliente.Image = Global.sordem.My.Resources.Resources.Search_30x30
        Me.btnPesquisarCliente.Location = New System.Drawing.Point(506, 11)
        Me.btnPesquisarCliente.Name = "btnPesquisarCliente"
        Me.btnPesquisarCliente.Size = New System.Drawing.Size(32, 32)
        Me.btnPesquisarCliente.TabIndex = 0
        Me.btnPesquisarCliente.UseVisualStyleBackColor = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(22, 19)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 31
        Me.lblCliente.Text = "Cliente"
        '
        'txtClienteRg
        '
        Me.txtClienteRg.Location = New System.Drawing.Point(131, 42)
        Me.txtClienteRg.Name = "txtClienteRg"
        Me.txtClienteRg.ReadOnly = True
        Me.txtClienteRg.Size = New System.Drawing.Size(151, 20)
        Me.txtClienteRg.TabIndex = 2
        '
        'txtClienteNome
        '
        Me.txtClienteNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtClienteNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtClienteNome.Location = New System.Drawing.Point(131, 16)
        Me.txtClienteNome.Name = "txtClienteNome"
        Me.txtClienteNome.ReadOnly = True
        Me.txtClienteNome.Size = New System.Drawing.Size(350, 20)
        Me.txtClienteNome.TabIndex = 1
        '
        'txtClienteEmail
        '
        Me.txtClienteEmail.Location = New System.Drawing.Point(131, 68)
        Me.txtClienteEmail.Name = "txtClienteEmail"
        Me.txtClienteEmail.ReadOnly = True
        Me.txtClienteEmail.Size = New System.Drawing.Size(287, 20)
        Me.txtClienteEmail.TabIndex = 3
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(22, 45)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(23, 13)
        Me.lblCpf.TabIndex = 32
        Me.lblCpf.Text = "RG"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(22, 71)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 33
        Me.lblEmail.Text = "Email"
        '
        'btnDeletarOrdem
        '
        Me.btnDeletarOrdem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeletarOrdem.Location = New System.Drawing.Point(335, 516)
        Me.btnDeletarOrdem.Name = "btnDeletarOrdem"
        Me.btnDeletarOrdem.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletarOrdem.TabIndex = 15
        Me.btnDeletarOrdem.Text = "Deletar"
        Me.btnDeletarOrdem.UseVisualStyleBackColor = True
        '
        'btnCancelarOrdem
        '
        Me.btnCancelarOrdem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarOrdem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelarOrdem.Location = New System.Drawing.Point(416, 516)
        Me.btnCancelarOrdem.Name = "btnCancelarOrdem"
        Me.btnCancelarOrdem.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarOrdem.TabIndex = 14
        Me.btnCancelarOrdem.Text = "Cancelar"
        Me.btnCancelarOrdem.UseVisualStyleBackColor = True
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(147, 459)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(350, 48)
        Me.txtObservacao.TabIndex = 12
        '
        'btnSalvarOrdem
        '
        Me.btnSalvarOrdem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarOrdem.Location = New System.Drawing.Point(497, 516)
        Me.btnSalvarOrdem.Name = "btnSalvarOrdem"
        Me.btnSalvarOrdem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalvarOrdem.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarOrdem.TabIndex = 13
        Me.btnSalvarOrdem.Text = "Salvar"
        Me.btnSalvarOrdem.UseVisualStyleBackColor = True
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(35, 470)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(65, 13)
        Me.lblObs.TabIndex = 42
        Me.lblObs.Text = "Observação"
        '
        'cmbEstadoOrdem
        '
        Me.cmbEstadoOrdem.FormattingEnabled = True
        Me.cmbEstadoOrdem.Location = New System.Drawing.Point(147, 215)
        Me.cmbEstadoOrdem.Name = "cmbEstadoOrdem"
        Me.cmbEstadoOrdem.Size = New System.Drawing.Size(236, 21)
        Me.cmbEstadoOrdem.TabIndex = 6
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(35, 215)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(89, 13)
        Me.lblEstado.TabIndex = 36
        Me.lblEstado.Text = "Estado da Ordem"
        '
        'txtUsuarioId
        '
        Me.txtUsuarioId.Location = New System.Drawing.Point(16, 516)
        Me.txtUsuarioId.Name = "txtUsuarioId"
        Me.txtUsuarioId.ReadOnly = True
        Me.txtUsuarioId.Size = New System.Drawing.Size(39, 20)
        Me.txtUsuarioId.TabIndex = 23
        Me.txtUsuarioId.Visible = False
        '
        'txtClienteId
        '
        Me.txtClienteId.Location = New System.Drawing.Point(61, 516)
        Me.txtClienteId.Name = "txtClienteId"
        Me.txtClienteId.ReadOnly = True
        Me.txtClienteId.Size = New System.Drawing.Size(39, 20)
        Me.txtClienteId.TabIndex = 24
        Me.txtClienteId.Visible = False
        '
        'txtOrdemId
        '
        Me.txtOrdemId.Location = New System.Drawing.Point(106, 516)
        Me.txtOrdemId.Name = "txtOrdemId"
        Me.txtOrdemId.ReadOnly = True
        Me.txtOrdemId.Size = New System.Drawing.Size(39, 20)
        Me.txtOrdemId.TabIndex = 25
        Me.txtOrdemId.Visible = False
        '
        'mskDtSaida
        '
        Me.mskDtSaida.Location = New System.Drawing.Point(370, 426)
        Me.mskDtSaida.Mask = "00/00/0000"
        Me.mskDtSaida.Name = "mskDtSaida"
        Me.mskDtSaida.Size = New System.Drawing.Size(100, 20)
        Me.mskDtSaida.TabIndex = 11
        Me.mskDtSaida.ValidatingType = GetType(Date)
        '
        'mskDtEntrada
        '
        Me.mskDtEntrada.Location = New System.Drawing.Point(147, 426)
        Me.mskDtEntrada.Mask = "00/00/0000"
        Me.mskDtEntrada.Name = "mskDtEntrada"
        Me.mskDtEntrada.Size = New System.Drawing.Size(100, 20)
        Me.mskDtEntrada.TabIndex = 10
        Me.mskDtEntrada.ValidatingType = GetType(Date)
        '
        'txtLaudo
        '
        Me.txtLaudo.Location = New System.Drawing.Point(147, 320)
        Me.txtLaudo.Multiline = True
        Me.txtLaudo.Name = "txtLaudo"
        Me.txtLaudo.Size = New System.Drawing.Size(350, 48)
        Me.txtLaudo.TabIndex = 8
        '
        'txtPrecoConcerto
        '
        Me.txtPrecoConcerto.Location = New System.Drawing.Point(147, 384)
        Me.txtPrecoConcerto.Name = "txtPrecoConcerto"
        Me.txtPrecoConcerto.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoConcerto.TabIndex = 9
        '
        'txtDefeito
        '
        Me.txtDefeito.Location = New System.Drawing.Point(147, 256)
        Me.txtDefeito.Multiline = True
        Me.txtDefeito.Name = "txtDefeito"
        Me.txtDefeito.Size = New System.Drawing.Size(350, 48)
        Me.txtDefeito.TabIndex = 7
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(147, 177)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(151, 20)
        Me.txtModelo.TabIndex = 5
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.ItemHeight = 13
        Me.cmbMarca.Location = New System.Drawing.Point(147, 140)
        Me.cmbMarca.MaxDropDownItems = 30
        Me.cmbMarca.MaxLength = 50
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(236, 21)
        Me.cmbMarca.TabIndex = 4
        '
        'lblDtSaida
        '
        Me.lblDtSaida.AutoSize = True
        Me.lblDtSaida.Location = New System.Drawing.Point(278, 426)
        Me.lblDtSaida.Name = "lblDtSaida"
        Me.lblDtSaida.Size = New System.Drawing.Size(75, 13)
        Me.lblDtSaida.TabIndex = 41
        Me.lblDtSaida.Text = "Data de Saida"
        '
        'lblDtEntrada
        '
        Me.lblDtEntrada.AutoSize = True
        Me.lblDtEntrada.Location = New System.Drawing.Point(35, 426)
        Me.lblDtEntrada.Name = "lblDtEntrada"
        Me.lblDtEntrada.Size = New System.Drawing.Size(85, 13)
        Me.lblDtEntrada.TabIndex = 40
        Me.lblDtEntrada.Text = "Data de Entrada"
        '
        'lblTaxa
        '
        Me.lblTaxa.AutoSize = True
        Me.lblTaxa.Location = New System.Drawing.Point(35, 384)
        Me.lblTaxa.Name = "lblTaxa"
        Me.lblTaxa.Size = New System.Drawing.Size(31, 13)
        Me.lblTaxa.TabIndex = 39
        Me.lblTaxa.Text = "Taxa"
        '
        'lblLaudo
        '
        Me.lblLaudo.AutoSize = True
        Me.lblLaudo.Location = New System.Drawing.Point(35, 320)
        Me.lblLaudo.Name = "lblLaudo"
        Me.lblLaudo.Size = New System.Drawing.Size(37, 13)
        Me.lblLaudo.TabIndex = 38
        Me.lblLaudo.Text = "Laudo"
        '
        'lblDefeito
        '
        Me.lblDefeito.AutoSize = True
        Me.lblDefeito.Location = New System.Drawing.Point(35, 256)
        Me.lblDefeito.Name = "lblDefeito"
        Me.lblDefeito.Size = New System.Drawing.Size(41, 13)
        Me.lblDefeito.TabIndex = 37
        Me.lblDefeito.Text = "Defeito"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(35, 177)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(42, 13)
        Me.lblModelo.TabIndex = 35
        Me.lblModelo.Text = "Modelo"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(35, 140)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 34
        Me.lblMarca.Text = "Marca"
        '
        'FormOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelarOrdem
        Me.ClientSize = New System.Drawing.Size(640, 586)
        Me.Controls.Add(Me.groupBoxOrdem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOrdem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordem de Serviço"
        Me.groupBoxOrdem.ResumeLayout(False)
        Me.groupBoxOrdem.PerformLayout()
        Me.PanelCliente.ResumeLayout(False)
        Me.PanelCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupBoxOrdem As System.Windows.Forms.GroupBox
    Friend WithEvents lblDtSaida As System.Windows.Forms.Label
    Friend WithEvents lblDtEntrada As System.Windows.Forms.Label
    Friend WithEvents lblTaxa As System.Windows.Forms.Label
    Friend WithEvents lblLaudo As System.Windows.Forms.Label
    Friend WithEvents lblDefeito As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents mskDtSaida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskDtEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPrecoConcerto As System.Windows.Forms.TextBox
    Friend WithEvents txtLaudo As System.Windows.Forms.TextBox
    Friend WithEvents txtDefeito As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalvarOrdem As System.Windows.Forms.Button
    Friend WithEvents btnCancelarOrdem As System.Windows.Forms.Button
    Friend WithEvents txtOrdemId As System.Windows.Forms.TextBox
    Friend WithEvents btnDeletarOrdem As System.Windows.Forms.Button
    Friend WithEvents txtClienteId As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioId As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents cmbEstadoOrdem As System.Windows.Forms.ComboBox
    Friend WithEvents lblObs As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As System.Windows.Forms.TextBox
    Friend WithEvents PanelCliente As System.Windows.Forms.Panel
    Friend WithEvents btnPesquisarCliente As System.Windows.Forms.Button
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtClienteRg As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteNome As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnRelatorioOrdem As System.Windows.Forms.Button
End Class
