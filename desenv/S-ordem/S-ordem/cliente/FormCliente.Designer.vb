<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCliente))
        Me.Cliente = New System.Windows.Forms.GroupBox()
        Me.mskClienteDdd_3 = New System.Windows.Forms.MaskedTextBox()
        Me.mskClienteDdd_2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskClienteDdd_1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtClientePessoaId = New System.Windows.Forms.TextBox()
        Me.txtClienteId = New System.Windows.Forms.TextBox()
        Me.mskClienteTelefone3 = New System.Windows.Forms.MaskedTextBox()
        Me.mskClienteTelefone2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskClienteTelefone1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskClienteCep = New System.Windows.Forms.MaskedTextBox()
        Me.mskClienteCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone3Cliente = New System.Windows.Forms.Label()
        Me.Telefone2Cliente = New System.Windows.Forms.Label()
        Me.Telefone1Cliente = New System.Windows.Forms.Label()
        Me.EmailCliente = New System.Windows.Forms.Label()
        Me.CepCliente = New System.Windows.Forms.Label()
        Me.EnderecoCliente = New System.Windows.Forms.Label()
        Me.CpfCliente = New System.Windows.Forms.Label()
        Me.RgCliente = New System.Windows.Forms.Label()
        Me.nomeCliente = New System.Windows.Forms.Label()
        Me.txtClienteRg = New System.Windows.Forms.TextBox()
        Me.txtClienteEndereco = New System.Windows.Forms.TextBox()
        Me.txtClienteEmail = New System.Windows.Forms.TextBox()
        Me.txtClienteNome = New System.Windows.Forms.TextBox()
        Me.btn_SalvarCliente = New System.Windows.Forms.Button()
        Me.btn_CancelarCliente = New System.Windows.Forms.Button()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.btnDeletarCliente = New System.Windows.Forms.Button()
        Me.btnRelatorioCliente = New System.Windows.Forms.Button()
        Me.Cliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cliente
        '
        Me.Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cliente.AutoSize = True
        Me.Cliente.Controls.Add(Me.mskClienteDdd_3)
        Me.Cliente.Controls.Add(Me.mskClienteDdd_2)
        Me.Cliente.Controls.Add(Me.mskClienteDdd_1)
        Me.Cliente.Controls.Add(Me.txtClientePessoaId)
        Me.Cliente.Controls.Add(Me.txtClienteId)
        Me.Cliente.Controls.Add(Me.mskClienteTelefone3)
        Me.Cliente.Controls.Add(Me.mskClienteTelefone2)
        Me.Cliente.Controls.Add(Me.mskClienteTelefone1)
        Me.Cliente.Controls.Add(Me.mskClienteCep)
        Me.Cliente.Controls.Add(Me.mskClienteCpf)
        Me.Cliente.Controls.Add(Me.Telefone3Cliente)
        Me.Cliente.Controls.Add(Me.Telefone2Cliente)
        Me.Cliente.Controls.Add(Me.Telefone1Cliente)
        Me.Cliente.Controls.Add(Me.EmailCliente)
        Me.Cliente.Controls.Add(Me.CepCliente)
        Me.Cliente.Controls.Add(Me.EnderecoCliente)
        Me.Cliente.Controls.Add(Me.CpfCliente)
        Me.Cliente.Controls.Add(Me.RgCliente)
        Me.Cliente.Controls.Add(Me.nomeCliente)
        Me.Cliente.Controls.Add(Me.txtClienteRg)
        Me.Cliente.Controls.Add(Me.txtClienteEndereco)
        Me.Cliente.Controls.Add(Me.txtClienteEmail)
        Me.Cliente.Controls.Add(Me.txtClienteNome)
        Me.Cliente.Location = New System.Drawing.Point(13, 13)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(493, 294)
        Me.Cliente.TabIndex = 24
        Me.Cliente.TabStop = False
        Me.Cliente.Text = "Cliente"
        '
        'mskClienteDdd_3
        '
        Me.mskClienteDdd_3.Location = New System.Drawing.Point(124, 248)
        Me.mskClienteDdd_3.Name = "mskClienteDdd_3"
        Me.mskClienteDdd_3.Size = New System.Drawing.Size(36, 20)
        Me.mskClienteDdd_3.TabIndex = 10
        '
        'mskClienteDdd_2
        '
        Me.mskClienteDdd_2.Location = New System.Drawing.Point(124, 222)
        Me.mskClienteDdd_2.Name = "mskClienteDdd_2"
        Me.mskClienteDdd_2.Size = New System.Drawing.Size(36, 20)
        Me.mskClienteDdd_2.TabIndex = 8
        '
        'mskClienteDdd_1
        '
        Me.mskClienteDdd_1.Location = New System.Drawing.Point(124, 196)
        Me.mskClienteDdd_1.Name = "mskClienteDdd_1"
        Me.mskClienteDdd_1.Size = New System.Drawing.Size(36, 20)
        Me.mskClienteDdd_1.TabIndex = 6
        '
        'txtClientePessoaId
        '
        Me.txtClientePessoaId.Location = New System.Drawing.Point(433, 255)
        Me.txtClientePessoaId.Name = "txtClientePessoaId"
        Me.txtClientePessoaId.ReadOnly = True
        Me.txtClientePessoaId.Size = New System.Drawing.Size(24, 20)
        Me.txtClientePessoaId.TabIndex = 25
        Me.txtClientePessoaId.Visible = False
        '
        'txtClienteId
        '
        Me.txtClienteId.Location = New System.Drawing.Point(463, 255)
        Me.txtClienteId.Name = "txtClienteId"
        Me.txtClienteId.ReadOnly = True
        Me.txtClienteId.Size = New System.Drawing.Size(24, 20)
        Me.txtClienteId.TabIndex = 26
        Me.txtClienteId.Visible = False
        '
        'mskClienteTelefone3
        '
        Me.mskClienteTelefone3.Location = New System.Drawing.Point(166, 248)
        Me.mskClienteTelefone3.Name = "mskClienteTelefone3"
        Me.mskClienteTelefone3.Size = New System.Drawing.Size(150, 20)
        Me.mskClienteTelefone3.TabIndex = 11
        '
        'mskClienteTelefone2
        '
        Me.mskClienteTelefone2.Location = New System.Drawing.Point(166, 222)
        Me.mskClienteTelefone2.Name = "mskClienteTelefone2"
        Me.mskClienteTelefone2.Size = New System.Drawing.Size(150, 20)
        Me.mskClienteTelefone2.TabIndex = 9
        '
        'mskClienteTelefone1
        '
        Me.mskClienteTelefone1.Location = New System.Drawing.Point(166, 196)
        Me.mskClienteTelefone1.Name = "mskClienteTelefone1"
        Me.mskClienteTelefone1.Size = New System.Drawing.Size(150, 20)
        Me.mskClienteTelefone1.TabIndex = 7
        '
        'mskClienteCep
        '
        Me.mskClienteCep.Location = New System.Drawing.Point(124, 143)
        Me.mskClienteCep.Name = "mskClienteCep"
        Me.mskClienteCep.Size = New System.Drawing.Size(150, 20)
        Me.mskClienteCep.TabIndex = 4
        '
        'mskClienteCpf
        '
        Me.mskClienteCpf.Location = New System.Drawing.Point(124, 93)
        Me.mskClienteCpf.Name = "mskClienteCpf"
        Me.mskClienteCpf.Size = New System.Drawing.Size(176, 20)
        Me.mskClienteCpf.TabIndex = 2
        '
        'Telefone3Cliente
        '
        Me.Telefone3Cliente.AutoSize = True
        Me.Telefone3Cliente.Location = New System.Drawing.Point(18, 255)
        Me.Telefone3Cliente.Name = "Telefone3Cliente"
        Me.Telefone3Cliente.Size = New System.Drawing.Size(58, 13)
        Me.Telefone3Cliente.TabIndex = 23
        Me.Telefone3Cliente.Text = "Telefone 3"
        '
        'Telefone2Cliente
        '
        Me.Telefone2Cliente.AutoSize = True
        Me.Telefone2Cliente.Location = New System.Drawing.Point(18, 229)
        Me.Telefone2Cliente.Name = "Telefone2Cliente"
        Me.Telefone2Cliente.Size = New System.Drawing.Size(58, 13)
        Me.Telefone2Cliente.TabIndex = 22
        Me.Telefone2Cliente.Text = "Telefone 2"
        '
        'Telefone1Cliente
        '
        Me.Telefone1Cliente.AutoSize = True
        Me.Telefone1Cliente.Location = New System.Drawing.Point(18, 203)
        Me.Telefone1Cliente.Name = "Telefone1Cliente"
        Me.Telefone1Cliente.Size = New System.Drawing.Size(58, 13)
        Me.Telefone1Cliente.TabIndex = 21
        Me.Telefone1Cliente.Text = "Telefone 1"
        '
        'EmailCliente
        '
        Me.EmailCliente.AutoSize = True
        Me.EmailCliente.Location = New System.Drawing.Point(18, 177)
        Me.EmailCliente.Name = "EmailCliente"
        Me.EmailCliente.Size = New System.Drawing.Size(32, 13)
        Me.EmailCliente.TabIndex = 20
        Me.EmailCliente.Text = "Email"
        '
        'CepCliente
        '
        Me.CepCliente.AutoSize = True
        Me.CepCliente.Location = New System.Drawing.Point(18, 151)
        Me.CepCliente.Name = "CepCliente"
        Me.CepCliente.Size = New System.Drawing.Size(28, 13)
        Me.CepCliente.TabIndex = 19
        Me.CepCliente.Text = "CEP"
        '
        'EnderecoCliente
        '
        Me.EnderecoCliente.AutoSize = True
        Me.EnderecoCliente.Location = New System.Drawing.Point(18, 125)
        Me.EnderecoCliente.Name = "EnderecoCliente"
        Me.EnderecoCliente.Size = New System.Drawing.Size(53, 13)
        Me.EnderecoCliente.TabIndex = 18
        Me.EnderecoCliente.Text = "Endereço"
        '
        'CpfCliente
        '
        Me.CpfCliente.AutoSize = True
        Me.CpfCliente.Location = New System.Drawing.Point(18, 99)
        Me.CpfCliente.Name = "CpfCliente"
        Me.CpfCliente.Size = New System.Drawing.Size(27, 13)
        Me.CpfCliente.TabIndex = 17
        Me.CpfCliente.Text = "CPF"
        '
        'RgCliente
        '
        Me.RgCliente.AutoSize = True
        Me.RgCliente.Location = New System.Drawing.Point(18, 73)
        Me.RgCliente.Name = "RgCliente"
        Me.RgCliente.Size = New System.Drawing.Size(23, 13)
        Me.RgCliente.TabIndex = 16
        Me.RgCliente.Text = "RG"
        '
        'nomeCliente
        '
        Me.nomeCliente.AutoSize = True
        Me.nomeCliente.Location = New System.Drawing.Point(18, 46)
        Me.nomeCliente.Name = "nomeCliente"
        Me.nomeCliente.Size = New System.Drawing.Size(89, 13)
        Me.nomeCliente.TabIndex = 15
        Me.nomeCliente.Text = "Nome Completo *"
        '
        'txtClienteRg
        '
        Me.txtClienteRg.Location = New System.Drawing.Point(124, 66)
        Me.txtClienteRg.Name = "txtClienteRg"
        Me.txtClienteRg.Size = New System.Drawing.Size(176, 20)
        Me.txtClienteRg.TabIndex = 1
        '
        'txtClienteEndereco
        '
        Me.txtClienteEndereco.Location = New System.Drawing.Point(124, 118)
        Me.txtClienteEndereco.Name = "txtClienteEndereco"
        Me.txtClienteEndereco.Size = New System.Drawing.Size(338, 20)
        Me.txtClienteEndereco.TabIndex = 3
        '
        'txtClienteEmail
        '
        Me.txtClienteEmail.Location = New System.Drawing.Point(124, 170)
        Me.txtClienteEmail.Name = "txtClienteEmail"
        Me.txtClienteEmail.Size = New System.Drawing.Size(289, 20)
        Me.txtClienteEmail.TabIndex = 5
        '
        'txtClienteNome
        '
        Me.txtClienteNome.Location = New System.Drawing.Point(124, 40)
        Me.txtClienteNome.Name = "txtClienteNome"
        Me.txtClienteNome.Size = New System.Drawing.Size(338, 20)
        Me.txtClienteNome.TabIndex = 0
        '
        'btn_SalvarCliente
        '
        Me.btn_SalvarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SalvarCliente.Location = New System.Drawing.Point(431, 313)
        Me.btn_SalvarCliente.Name = "btn_SalvarCliente"
        Me.btn_SalvarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btn_SalvarCliente.TabIndex = 12
        Me.btn_SalvarCliente.Text = "Salvar"
        Me.btn_SalvarCliente.UseVisualStyleBackColor = True
        '
        'btn_CancelarCliente
        '
        Me.btn_CancelarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CancelarCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_CancelarCliente.Location = New System.Drawing.Point(350, 313)
        Me.btn_CancelarCliente.Name = "btn_CancelarCliente"
        Me.btn_CancelarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btn_CancelarCliente.TabIndex = 13
        Me.btn_CancelarCliente.Text = "Cancelar"
        Me.btn_CancelarCliente.UseVisualStyleBackColor = True
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(124, 40)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(338, 20)
        Me.txtNomeCliente.TabIndex = 0
        '
        'btnDeletarCliente
        '
        Me.btnDeletarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeletarCliente.Location = New System.Drawing.Point(269, 313)
        Me.btnDeletarCliente.Name = "btnDeletarCliente"
        Me.btnDeletarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletarCliente.TabIndex = 14
        Me.btnDeletarCliente.Text = "Deletar"
        Me.btnDeletarCliente.UseVisualStyleBackColor = True
        '
        'btnRelatorioCliente
        '
        Me.btnRelatorioCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorioCliente.Location = New System.Drawing.Point(188, 313)
        Me.btnRelatorioCliente.Name = "btnRelatorioCliente"
        Me.btnRelatorioCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnRelatorioCliente.TabIndex = 15
        Me.btnRelatorioCliente.Text = "Relatório"
        Me.btnRelatorioCliente.UseVisualStyleBackColor = True
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_CancelarCliente
        Me.ClientSize = New System.Drawing.Size(523, 347)
        Me.Controls.Add(Me.btnRelatorioCliente)
        Me.Controls.Add(Me.btn_SalvarCliente)
        Me.Controls.Add(Me.btnDeletarCliente)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.btn_CancelarCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cliente"
        Me.Cliente.ResumeLayout(False)
        Me.Cliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtClienteRg As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteNome As System.Windows.Forms.TextBox
    Friend WithEvents Telefone3Cliente As System.Windows.Forms.Label
    Friend WithEvents Telefone2Cliente As System.Windows.Forms.Label
    Friend WithEvents Telefone1Cliente As System.Windows.Forms.Label
    Friend WithEvents EmailCliente As System.Windows.Forms.Label
    Friend WithEvents CepCliente As System.Windows.Forms.Label
    Friend WithEvents EnderecoCliente As System.Windows.Forms.Label
    Friend WithEvents CpfCliente As System.Windows.Forms.Label
    Friend WithEvents RgCliente As System.Windows.Forms.Label
    Friend WithEvents nomeCliente As System.Windows.Forms.Label
    Friend WithEvents btn_SalvarCliente As System.Windows.Forms.Button
    Friend WithEvents btn_CancelarCliente As System.Windows.Forms.Button
    Friend WithEvents txtNomeCliente As System.Windows.Forms.TextBox
    Friend WithEvents mskClienteCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskClienteTelefone3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskClienteTelefone2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskClienteTelefone1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskClienteCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtClienteId As System.Windows.Forms.TextBox
    Friend WithEvents btnDeletarCliente As System.Windows.Forms.Button
    Friend WithEvents txtClientePessoaId As System.Windows.Forms.TextBox
    Friend WithEvents mskClienteDdd_3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskClienteDdd_2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskClienteDdd_1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnRelatorioCliente As System.Windows.Forms.Button
End Class
