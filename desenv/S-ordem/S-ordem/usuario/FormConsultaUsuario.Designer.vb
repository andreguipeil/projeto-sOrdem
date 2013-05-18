<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaUsuario))
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.gridUsuarios = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuarioNome = New System.Windows.Forms.TextBox()
        Me.groupBoxConsultarUsuario = New System.Windows.Forms.GroupBox()
        CType(Me.gridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionar.Location = New System.Drawing.Point(376, 451)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSelecionar.TabIndex = 10
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'gridUsuarios
        '
        Me.gridUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nome, Me.username})
        Me.gridUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.gridUsuarios.Location = New System.Drawing.Point(27, 80)
        Me.gridUsuarios.MultiSelect = False
        Me.gridUsuarios.Name = "gridUsuarios"
        Me.gridUsuarios.ReadOnly = True
        Me.gridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridUsuarios.Size = New System.Drawing.Size(409, 321)
        Me.gridUsuarios.TabIndex = 9
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 20.30457!
        Me.id.HeaderText = "Id"
        Me.id.MinimumWidth = 25
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'nome
        '
        Me.nome.DataPropertyName = "nome"
        Me.nome.FillWeight = 179.6954!
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 200
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(295, 451)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nome"
        '
        'txtUsuarioNome
        '
        Me.txtUsuarioNome.Location = New System.Drawing.Point(73, 42)
        Me.txtUsuarioNome.Name = "txtUsuarioNome"
        Me.txtUsuarioNome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUsuarioNome.Size = New System.Drawing.Size(275, 20)
        Me.txtUsuarioNome.TabIndex = 6
        '
        'groupBoxConsultarUsuario
        '
        Me.groupBoxConsultarUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxConsultarUsuario.Location = New System.Drawing.Point(13, 13)
        Me.groupBoxConsultarUsuario.Name = "groupBoxConsultarUsuario"
        Me.groupBoxConsultarUsuario.Size = New System.Drawing.Size(438, 415)
        Me.groupBoxConsultarUsuario.TabIndex = 11
        Me.groupBoxConsultarUsuario.TabStop = False
        Me.groupBoxConsultarUsuario.Text = "Consultar Usuário"
        '
        'FormConsultaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 486)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.gridUsuarios)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuarioNome)
        Me.Controls.Add(Me.groupBoxConsultarUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConsultaUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Usuario"
        CType(Me.gridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents gridUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioNome As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents groupBoxConsultarUsuario As System.Windows.Forms.GroupBox
End Class
