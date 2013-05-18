<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMarca))
        Me.GroupBoxCadAux = New System.Windows.Forms.GroupBox()
        Me.txtMarcaId = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnSalvarMarca = New System.Windows.Forms.Button()
        Me.btnCancelarMarca = New System.Windows.Forms.Button()
        Me.btnDeletarMarca = New System.Windows.Forms.Button()
        Me.GroupBoxCadAux.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCadAux
        '
        Me.GroupBoxCadAux.Controls.Add(Me.txtMarcaId)
        Me.GroupBoxCadAux.Controls.Add(Me.lblMarca)
        Me.GroupBoxCadAux.Controls.Add(Me.txtMarca)
        Me.GroupBoxCadAux.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxCadAux.Name = "GroupBoxCadAux"
        Me.GroupBoxCadAux.Size = New System.Drawing.Size(324, 84)
        Me.GroupBoxCadAux.TabIndex = 0
        Me.GroupBoxCadAux.TabStop = False
        Me.GroupBoxCadAux.Text = "Cadastro"
        '
        'txtMarcaId
        '
        Me.txtMarcaId.Location = New System.Drawing.Point(289, 58)
        Me.txtMarcaId.Name = "txtMarcaId"
        Me.txtMarcaId.ReadOnly = True
        Me.txtMarcaId.Size = New System.Drawing.Size(29, 20)
        Me.txtMarcaId.TabIndex = 5
        Me.txtMarcaId.Visible = False
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(28, 38)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 1
        Me.lblMarca.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(81, 35)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(187, 20)
        Me.txtMarca.TabIndex = 0
        '
        'btnSalvarMarca
        '
        Me.btnSalvarMarca.Location = New System.Drawing.Point(261, 102)
        Me.btnSalvarMarca.Name = "btnSalvarMarca"
        Me.btnSalvarMarca.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarMarca.TabIndex = 1
        Me.btnSalvarMarca.Text = "Salvar"
        Me.btnSalvarMarca.UseVisualStyleBackColor = True
        '
        'btnCancelarMarca
        '
        Me.btnCancelarMarca.Location = New System.Drawing.Point(180, 102)
        Me.btnCancelarMarca.Name = "btnCancelarMarca"
        Me.btnCancelarMarca.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarMarca.TabIndex = 2
        Me.btnCancelarMarca.Text = "Cancelar"
        Me.btnCancelarMarca.UseVisualStyleBackColor = True
        '
        'btnDeletarMarca
        '
        Me.btnDeletarMarca.Location = New System.Drawing.Point(99, 102)
        Me.btnDeletarMarca.Name = "btnDeletarMarca"
        Me.btnDeletarMarca.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletarMarca.TabIndex = 3
        Me.btnDeletarMarca.Text = "Deletar"
        Me.btnDeletarMarca.UseVisualStyleBackColor = True
        '
        'FormMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 136)
        Me.Controls.Add(Me.btnDeletarMarca)
        Me.Controls.Add(Me.GroupBoxCadAux)
        Me.Controls.Add(Me.btnCancelarMarca)
        Me.Controls.Add(Me.btnSalvarMarca)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marca"
        Me.GroupBoxCadAux.ResumeLayout(False)
        Me.GroupBoxCadAux.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxCadAux As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeletarMarca As System.Windows.Forms.Button
    Friend WithEvents btnCancelarMarca As System.Windows.Forms.Button
    Friend WithEvents btnSalvarMarca As System.Windows.Forms.Button
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaId As System.Windows.Forms.TextBox
End Class
