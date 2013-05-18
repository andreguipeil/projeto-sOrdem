<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ConsultaCliente
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
        Me.gridClientes = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpfCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefoneCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consultaCliente = New System.Windows.Forms.GroupBox()
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
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nomeCliente, Me.Rg, Me.cpfCliente, Me.emailCliente, Me.telefoneCliente})
        Me.gridClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.gridClientes.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.gridClientes.Location = New System.Drawing.Point(12, 230)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.Size = New System.Drawing.Size(757, 437)
        Me.gridClientes.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'nomeCliente
        '
        Me.nomeCliente.DataPropertyName = "nome"
        Me.nomeCliente.HeaderText = "Nome"
        Me.nomeCliente.MinimumWidth = 60
        Me.nomeCliente.Name = "nomeCliente"
        Me.nomeCliente.Width = 230
        '
        'Rg
        '
        Me.Rg.DataPropertyName = "rg"
        Me.Rg.HeaderText = "RG"
        Me.Rg.Name = "Rg"
        '
        'cpfCliente
        '
        Me.cpfCliente.DataPropertyName = "cpf"
        Me.cpfCliente.HeaderText = "CPF"
        Me.cpfCliente.Name = "cpfCliente"
        '
        'emailCliente
        '
        Me.emailCliente.DataPropertyName = "email"
        Me.emailCliente.HeaderText = "Email"
        Me.emailCliente.Name = "emailCliente"
        Me.emailCliente.Width = 150
        '
        'telefoneCliente
        '
        Me.telefoneCliente.HeaderText = "Telefone"
        Me.telefoneCliente.Name = "telefoneCliente"
        Me.telefoneCliente.Width = 110
        '
        'consultaCliente
        '
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
        Me.consultaCliente.Location = New System.Drawing.Point(12, 40)
        Me.consultaCliente.Name = "consultaCliente"
        Me.consultaCliente.Size = New System.Drawing.Size(757, 170)
        Me.consultaCliente.TabIndex = 1
        Me.consultaCliente.TabStop = False
        Me.consultaCliente.Text = "Filtro"
        '
        'mskClienteCpf
        '
        Me.mskClienteCpf.Location = New System.Drawing.Point(64, 82)
        Me.mskClienteCpf.Name = "mskClienteCpf"
        Me.mskClienteCpf.Size = New System.Drawing.Size(162, 20)
        Me.mskClienteCpf.TabIndex = 10
        '
        'btnCancelarConsulta
        '
        Me.btnCancelarConsulta.Location = New System.Drawing.Point(595, 141)
        Me.btnCancelarConsulta.Name = "btnCancelarConsulta"
        Me.btnCancelarConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarConsulta.TabIndex = 9
        Me.btnCancelarConsulta.Text = "Cancelar"
        Me.btnCancelarConsulta.UseVisualStyleBackColor = True
        '
        'btnPesquisarCliente
        '
        Me.btnPesquisarCliente.Location = New System.Drawing.Point(676, 141)
        Me.btnPesquisarCliente.Name = "btnPesquisarCliente"
        Me.btnPesquisarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisarCliente.TabIndex = 8
        Me.btnPesquisarCliente.Text = "Pesquisar"
        Me.btnPesquisarCliente.UseVisualStyleBackColor = True
        '
        'txtClienteEmail
        '
        Me.txtClienteEmail.Location = New System.Drawing.Point(64, 113)
        Me.txtClienteEmail.Name = "txtClienteEmail"
        Me.txtClienteEmail.Size = New System.Drawing.Size(273, 20)
        Me.txtClienteEmail.TabIndex = 7
        '
        'txtClienteRg
        '
        Me.txtClienteRg.Location = New System.Drawing.Point(64, 54)
        Me.txtClienteRg.Name = "txtClienteRg"
        Me.txtClienteRg.Size = New System.Drawing.Size(162, 20)
        Me.txtClienteRg.TabIndex = 5
        '
        'txtClienteNome
        '
        Me.txtClienteNome.Location = New System.Drawing.Point(64, 27)
        Me.txtClienteNome.Name = "txtClienteNome"
        Me.txtClienteNome.Size = New System.Drawing.Size(354, 20)
        Me.txtClienteNome.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 113)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(6, 82)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 2
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(7, 54)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 1
        Me.lblRg.Text = "RG"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(7, 27)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome"
        '
        'Form_ConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 679)
        Me.Controls.Add(Me.consultaCliente)
        Me.Controls.Add(Me.gridClientes)
        Me.Name = "Form_ConsultaCliente"
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
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomeCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpfCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emailCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefoneCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancelarConsulta As System.Windows.Forms.Button
    Friend WithEvents mskClienteCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtClienteRg As System.Windows.Forms.TextBox
End Class
