<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuario))
        Me.GroupBoxUsuario = New System.Windows.Forms.GroupBox()
        Me.txtUsuarioEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsuarioNome = New System.Windows.Forms.TextBox()
        Me.txtUsuarioRg = New System.Windows.Forms.TextBox()
        Me.txtUsuarioUsername = New System.Windows.Forms.TextBox()
        Me.mskUsuarioTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mskUsuarioDdd = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskUsuarioSenha2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskUsuarioSenha = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalvarUsuario = New System.Windows.Forms.Button()
        Me.btnCancelarUsuario = New System.Windows.Forms.Button()
        Me.txtUsuarioId = New System.Windows.Forms.TextBox()
        Me.btnDeletarUsuario = New System.Windows.Forms.Button()
        Me.chkAdministrador = New System.Windows.Forms.CheckBox()
        Me.GroupBoxUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxUsuario
        '
        Me.GroupBoxUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxUsuario.Controls.Add(Me.chkAdministrador)
        Me.GroupBoxUsuario.Controls.Add(Me.txtUsuarioEmail)
        Me.GroupBoxUsuario.Controls.Add(Me.txtUsuarioId)
        Me.GroupBoxUsuario.Controls.Add(Me.Label7)
        Me.GroupBoxUsuario.Controls.Add(Me.txtUsuarioNome)
        Me.GroupBoxUsuario.Controls.Add(Me.txtUsuarioRg)
        Me.GroupBoxUsuario.Controls.Add(Me.txtUsuarioUsername)
        Me.GroupBoxUsuario.Controls.Add(Me.mskUsuarioTelefone)
        Me.GroupBoxUsuario.Controls.Add(Me.mskUsuarioDdd)
        Me.GroupBoxUsuario.Controls.Add(Me.Label6)
        Me.GroupBoxUsuario.Controls.Add(Me.mskUsuarioSenha2)
        Me.GroupBoxUsuario.Controls.Add(Me.mskUsuarioSenha)
        Me.GroupBoxUsuario.Controls.Add(Me.Label5)
        Me.GroupBoxUsuario.Controls.Add(Me.Label4)
        Me.GroupBoxUsuario.Controls.Add(Me.Label3)
        Me.GroupBoxUsuario.Controls.Add(Me.Label2)
        Me.GroupBoxUsuario.Controls.Add(Me.Label1)
        Me.GroupBoxUsuario.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxUsuario.Name = "GroupBoxUsuario"
        Me.GroupBoxUsuario.Size = New System.Drawing.Size(309, 325)
        Me.GroupBoxUsuario.TabIndex = 0
        Me.GroupBoxUsuario.TabStop = False
        Me.GroupBoxUsuario.Text = "Cadastro de Usuário"
        '
        'txtUsuarioEmail
        '
        Me.txtUsuarioEmail.Location = New System.Drawing.Point(121, 134)
        Me.txtUsuarioEmail.Name = "txtUsuarioEmail"
        Me.txtUsuarioEmail.Size = New System.Drawing.Size(182, 20)
        Me.txtUsuarioEmail.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Email"
        '
        'txtUsuarioNome
        '
        Me.txtUsuarioNome.Location = New System.Drawing.Point(121, 32)
        Me.txtUsuarioNome.Name = "txtUsuarioNome"
        Me.txtUsuarioNome.Size = New System.Drawing.Size(182, 20)
        Me.txtUsuarioNome.TabIndex = 1
        '
        'txtUsuarioRg
        '
        Me.txtUsuarioRg.Location = New System.Drawing.Point(121, 65)
        Me.txtUsuarioRg.Name = "txtUsuarioRg"
        Me.txtUsuarioRg.Size = New System.Drawing.Size(124, 20)
        Me.txtUsuarioRg.TabIndex = 2
        '
        'txtUsuarioUsername
        '
        Me.txtUsuarioUsername.Location = New System.Drawing.Point(121, 172)
        Me.txtUsuarioUsername.Name = "txtUsuarioUsername"
        Me.txtUsuarioUsername.Size = New System.Drawing.Size(145, 20)
        Me.txtUsuarioUsername.TabIndex = 6
        '
        'mskUsuarioTelefone
        '
        Me.mskUsuarioTelefone.Location = New System.Drawing.Point(159, 100)
        Me.mskUsuarioTelefone.Name = "mskUsuarioTelefone"
        Me.mskUsuarioTelefone.Size = New System.Drawing.Size(107, 20)
        Me.mskUsuarioTelefone.TabIndex = 4
        '
        'mskUsuarioDdd
        '
        Me.mskUsuarioDdd.Location = New System.Drawing.Point(121, 100)
        Me.mskUsuarioDdd.Name = "mskUsuarioDdd"
        Me.mskUsuarioDdd.Size = New System.Drawing.Size(32, 20)
        Me.mskUsuarioDdd.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telefone"
        '
        'mskUsuarioSenha2
        '
        Me.mskUsuarioSenha2.Location = New System.Drawing.Point(121, 255)
        Me.mskUsuarioSenha2.Name = "mskUsuarioSenha2"
        Me.mskUsuarioSenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mskUsuarioSenha2.Size = New System.Drawing.Size(145, 20)
        Me.mskUsuarioSenha2.TabIndex = 8
        '
        'mskUsuarioSenha
        '
        Me.mskUsuarioSenha.Location = New System.Drawing.Point(121, 212)
        Me.mskUsuarioSenha.Name = "mskUsuarioSenha"
        Me.mskUsuarioSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mskUsuarioSenha.Size = New System.Drawing.Size(145, 20)
        Me.mskUsuarioSenha.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Confirma Senha *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Senha *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Usuario *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "RG *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nome *"
        '
        'btnSalvarUsuario
        '
        Me.btnSalvarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarUsuario.Location = New System.Drawing.Point(247, 343)
        Me.btnSalvarUsuario.Name = "btnSalvarUsuario"
        Me.btnSalvarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarUsuario.TabIndex = 9
        Me.btnSalvarUsuario.Text = "Salvar"
        Me.btnSalvarUsuario.UseVisualStyleBackColor = True
        '
        'btnCancelarUsuario
        '
        Me.btnCancelarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelarUsuario.Location = New System.Drawing.Point(160, 343)
        Me.btnCancelarUsuario.Name = "btnCancelarUsuario"
        Me.btnCancelarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarUsuario.TabIndex = 10
        Me.btnCancelarUsuario.Text = "Cancelar"
        Me.btnCancelarUsuario.UseVisualStyleBackColor = True
        '
        'txtUsuarioId
        '
        Me.txtUsuarioId.Location = New System.Drawing.Point(23, 288)
        Me.txtUsuarioId.Name = "txtUsuarioId"
        Me.txtUsuarioId.ReadOnly = True
        Me.txtUsuarioId.Size = New System.Drawing.Size(25, 20)
        Me.txtUsuarioId.TabIndex = 18
        Me.txtUsuarioId.Visible = False
        '
        'btnDeletarUsuario
        '
        Me.btnDeletarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeletarUsuario.Location = New System.Drawing.Point(70, 343)
        Me.btnDeletarUsuario.Name = "btnDeletarUsuario"
        Me.btnDeletarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletarUsuario.TabIndex = 19
        Me.btnDeletarUsuario.Text = "Deletar"
        Me.btnDeletarUsuario.UseVisualStyleBackColor = True
        '
        'chkAdministrador
        '
        Me.chkAdministrador.AutoSize = True
        Me.chkAdministrador.Location = New System.Drawing.Point(121, 290)
        Me.chkAdministrador.Name = "chkAdministrador"
        Me.chkAdministrador.Size = New System.Drawing.Size(89, 17)
        Me.chkAdministrador.TabIndex = 20
        Me.chkAdministrador.Text = "Administrador"
        Me.chkAdministrador.UseVisualStyleBackColor = True
        '
        'FormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 378)
        Me.Controls.Add(Me.btnDeletarUsuario)
        Me.Controls.Add(Me.btnCancelarUsuario)
        Me.Controls.Add(Me.btnSalvarUsuario)
        Me.Controls.Add(Me.GroupBoxUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.GroupBoxUsuario.ResumeLayout(False)
        Me.GroupBoxUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioNome As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioRg As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioUsername As System.Windows.Forms.TextBox
    Friend WithEvents mskUsuarioTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskUsuarioDdd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskUsuarioSenha2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskUsuarioSenha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSalvarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnCancelarUsuario As System.Windows.Forms.Button
    Friend WithEvents txtUsuarioId As System.Windows.Forms.TextBox
    Friend WithEvents btnDeletarUsuario As System.Windows.Forms.Button
    Friend WithEvents chkAdministrador As System.Windows.Forms.CheckBox
End Class
