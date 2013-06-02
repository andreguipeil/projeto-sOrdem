<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaCliente))
        Me.gridClientes = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpfCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone1Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone2Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone3Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_cadastro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_alteracao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consultaCliente = New System.Windows.Forms.GroupBox()
        Me.btnRelatorioClientes = New System.Windows.Forms.Button()
        Me.mskClienteCpf = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancelarConsulta = New System.Windows.Forms.Button()
        Me.btnPesquisarCliente = New System.Windows.Forms.Button()
        Me.txtClienteEmail = New System.Windows.Forms.TextBox()
        Me.txtClienteRg = New System.Windows.Forms.TextBox()
        Me.txtClienteNome = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.consultaCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridClientes
        '
        Me.gridClientes.AllowUserToOrderColumns = True
        Me.gridClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridClientes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nomeCliente, Me.Rg, Me.cpfCliente, Me.emailCliente, Me.telefone1Cliente, Me.telefone2Cliente, Me.telefone3Cliente, Me.endereco, Me.cep, Me.dt_cadastro, Me.dt_alteracao, Me.usuario})
        Me.gridClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.gridClientes.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gridClientes.Location = New System.Drawing.Point(12, 213)
        Me.gridClientes.MultiSelect = False
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.ReadOnly = True
        Me.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridClientes.Size = New System.Drawing.Size(873, 337)
        Me.gridClientes.TabIndex = 8
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nomeCliente
        '
        Me.nomeCliente.DataPropertyName = "nome"
        Me.nomeCliente.HeaderText = "Nome"
        Me.nomeCliente.MinimumWidth = 20
        Me.nomeCliente.Name = "nomeCliente"
        Me.nomeCliente.ReadOnly = True
        '
        'Rg
        '
        Me.Rg.DataPropertyName = "rg"
        Me.Rg.HeaderText = "RG"
        Me.Rg.Name = "Rg"
        Me.Rg.ReadOnly = True
        '
        'cpfCliente
        '
        Me.cpfCliente.DataPropertyName = "cpf"
        Me.cpfCliente.HeaderText = "CPF"
        Me.cpfCliente.Name = "cpfCliente"
        Me.cpfCliente.ReadOnly = True
        '
        'emailCliente
        '
        Me.emailCliente.DataPropertyName = "email"
        Me.emailCliente.HeaderText = "Email"
        Me.emailCliente.Name = "emailCliente"
        Me.emailCliente.ReadOnly = True
        '
        'telefone1Cliente
        '
        Me.telefone1Cliente.DataPropertyName = "telefone_1"
        Me.telefone1Cliente.HeaderText = "Telefone 1"
        Me.telefone1Cliente.Name = "telefone1Cliente"
        Me.telefone1Cliente.ReadOnly = True
        '
        'telefone2Cliente
        '
        Me.telefone2Cliente.DataPropertyName = "telefone_2"
        Me.telefone2Cliente.HeaderText = "Telefone 2"
        Me.telefone2Cliente.Name = "telefone2Cliente"
        Me.telefone2Cliente.ReadOnly = True
        '
        'telefone3Cliente
        '
        Me.telefone3Cliente.DataPropertyName = "telefone_3"
        Me.telefone3Cliente.HeaderText = "Telefone 3"
        Me.telefone3Cliente.Name = "telefone3Cliente"
        Me.telefone3Cliente.ReadOnly = True
        '
        'endereco
        '
        Me.endereco.DataPropertyName = "endereco"
        Me.endereco.HeaderText = "Endereço"
        Me.endereco.Name = "endereco"
        Me.endereco.ReadOnly = True
        '
        'cep
        '
        Me.cep.DataPropertyName = "cep"
        Me.cep.HeaderText = "CEP"
        Me.cep.Name = "cep"
        Me.cep.ReadOnly = True
        '
        'dt_cadastro
        '
        Me.dt_cadastro.DataPropertyName = "dt_cadastro"
        Me.dt_cadastro.HeaderText = "Dt. Cadastro"
        Me.dt_cadastro.Name = "dt_cadastro"
        Me.dt_cadastro.ReadOnly = True
        '
        'dt_alteracao
        '
        Me.dt_alteracao.DataPropertyName = "dt_alteracao"
        Me.dt_alteracao.HeaderText = "Dt. Alteração"
        Me.dt_alteracao.Name = "dt_alteracao"
        Me.dt_alteracao.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "usuario"
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'consultaCliente
        '
        Me.consultaCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.consultaCliente.Controls.Add(Me.btnRelatorioClientes)
        Me.consultaCliente.Controls.Add(Me.mskClienteCpf)
        Me.consultaCliente.Controls.Add(Me.btnCancelarConsulta)
        Me.consultaCliente.Controls.Add(Me.btnPesquisarCliente)
        Me.consultaCliente.Controls.Add(Me.txtClienteEmail)
        Me.consultaCliente.Controls.Add(Me.txtClienteRg)
        Me.consultaCliente.Controls.Add(Me.txtClienteNome)
        Me.consultaCliente.Controls.Add(Me.lblEmail)
        Me.consultaCliente.Controls.Add(Me.lblCpf)
        Me.consultaCliente.Controls.Add(Me.lblRg)
        Me.consultaCliente.Controls.Add(Me.lblNome)
        Me.consultaCliente.Location = New System.Drawing.Point(12, 12)
        Me.consultaCliente.Name = "consultaCliente"
        Me.consultaCliente.Size = New System.Drawing.Size(873, 181)
        Me.consultaCliente.TabIndex = 0
        Me.consultaCliente.TabStop = False
        Me.consultaCliente.Text = "Filtro"
        '
        'btnRelatorioClientes
        '
        Me.btnRelatorioClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorioClientes.Location = New System.Drawing.Point(630, 139)
        Me.btnRelatorioClientes.Name = "btnRelatorioClientes"
        Me.btnRelatorioClientes.Size = New System.Drawing.Size(75, 23)
        Me.btnRelatorioClientes.TabIndex = 7
        Me.btnRelatorioClientes.Text = "Relatório"
        Me.btnRelatorioClientes.UseVisualStyleBackColor = True
        '
        'mskClienteCpf
        '
        Me.mskClienteCpf.Location = New System.Drawing.Point(64, 82)
        Me.mskClienteCpf.Name = "mskClienteCpf"
        Me.mskClienteCpf.Size = New System.Drawing.Size(162, 20)
        Me.mskClienteCpf.TabIndex = 3
        '
        'btnCancelarConsulta
        '
        Me.btnCancelarConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarConsulta.AutoSize = True
        Me.btnCancelarConsulta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelarConsulta.Location = New System.Drawing.Point(711, 139)
        Me.btnCancelarConsulta.Name = "btnCancelarConsulta"
        Me.btnCancelarConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarConsulta.TabIndex = 6
        Me.btnCancelarConsulta.Text = "Cancelar"
        Me.btnCancelarConsulta.UseVisualStyleBackColor = True
        '
        'btnPesquisarCliente
        '
        Me.btnPesquisarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesquisarCliente.AutoSize = True
        Me.btnPesquisarCliente.Location = New System.Drawing.Point(792, 139)
        Me.btnPesquisarCliente.Name = "btnPesquisarCliente"
        Me.btnPesquisarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisarCliente.TabIndex = 5
        Me.btnPesquisarCliente.Text = "Pesquisar"
        Me.btnPesquisarCliente.UseVisualStyleBackColor = True
        '
        'txtClienteEmail
        '
        Me.txtClienteEmail.Location = New System.Drawing.Point(64, 113)
        Me.txtClienteEmail.Name = "txtClienteEmail"
        Me.txtClienteEmail.Size = New System.Drawing.Size(273, 20)
        Me.txtClienteEmail.TabIndex = 4
        '
        'txtClienteRg
        '
        Me.txtClienteRg.Location = New System.Drawing.Point(64, 54)
        Me.txtClienteRg.Name = "txtClienteRg"
        Me.txtClienteRg.Size = New System.Drawing.Size(162, 20)
        Me.txtClienteRg.TabIndex = 2
        '
        'txtClienteNome
        '
        Me.txtClienteNome.Location = New System.Drawing.Point(64, 27)
        Me.txtClienteNome.Name = "txtClienteNome"
        Me.txtClienteNome.Size = New System.Drawing.Size(354, 20)
        Me.txtClienteNome.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 113)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(6, 82)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 10
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(7, 54)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 9
        Me.lblRg.Text = "RG"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(7, 27)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 8
        Me.lblNome.Text = "Nome"
        '
        'FormConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelarConsulta
        Me.ClientSize = New System.Drawing.Size(897, 562)
        Me.Controls.Add(Me.consultaCliente)
        Me.Controls.Add(Me.gridClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormConsultaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Cliente"
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.consultaCliente.ResumeLayout(False)
        Me.consultaCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridClientes As System.Windows.Forms.DataGridView
    Friend WithEvents consultaCliente As System.Windows.Forms.GroupBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnPesquisarCliente As System.Windows.Forms.Button
    Friend WithEvents txtClienteEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteNome As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelarConsulta As System.Windows.Forms.Button
    Friend WithEvents mskClienteCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtClienteRg As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomeCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpfCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emailCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefone1Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefone2Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefone3Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents endereco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_cadastro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_alteracao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRelatorioClientes As System.Windows.Forms.Button
End Class
