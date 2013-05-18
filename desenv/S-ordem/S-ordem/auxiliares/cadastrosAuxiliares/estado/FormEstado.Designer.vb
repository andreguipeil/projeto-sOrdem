<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstado))
        Me.btnDeletarEstado = New System.Windows.Forms.Button()
        Me.GroupBoxCadAux = New System.Windows.Forms.GroupBox()
        Me.txtEstadoId = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnCancelarEstado = New System.Windows.Forms.Button()
        Me.btnSalvarEstado = New System.Windows.Forms.Button()
        Me.GroupBoxCadAux.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDeletarEstado
        '
        Me.btnDeletarEstado.Location = New System.Drawing.Point(99, 102)
        Me.btnDeletarEstado.Name = "btnDeletarEstado"
        Me.btnDeletarEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletarEstado.TabIndex = 3
        Me.btnDeletarEstado.Text = "Deletar"
        Me.btnDeletarEstado.UseVisualStyleBackColor = True
        '
        'GroupBoxCadAux
        '
        Me.GroupBoxCadAux.Controls.Add(Me.txtEstadoId)
        Me.GroupBoxCadAux.Controls.Add(Me.lblMarca)
        Me.GroupBoxCadAux.Controls.Add(Me.txtEstado)
        Me.GroupBoxCadAux.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxCadAux.Name = "GroupBoxCadAux"
        Me.GroupBoxCadAux.Size = New System.Drawing.Size(324, 84)
        Me.GroupBoxCadAux.TabIndex = 5
        Me.GroupBoxCadAux.TabStop = False
        Me.GroupBoxCadAux.Text = "Cadastro"
        '
        'txtEstadoId
        '
        Me.txtEstadoId.Location = New System.Drawing.Point(289, 58)
        Me.txtEstadoId.Name = "txtEstadoId"
        Me.txtEstadoId.ReadOnly = True
        Me.txtEstadoId.Size = New System.Drawing.Size(29, 20)
        Me.txtEstadoId.TabIndex = 5
        Me.txtEstadoId.Visible = False
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(28, 38)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(89, 13)
        Me.lblMarca.TabIndex = 1
        Me.lblMarca.Text = "Estado da Ordem"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(131, 35)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(187, 20)
        Me.txtEstado.TabIndex = 0
        '
        'btnCancelarEstado
        '
        Me.btnCancelarEstado.Location = New System.Drawing.Point(180, 102)
        Me.btnCancelarEstado.Name = "btnCancelarEstado"
        Me.btnCancelarEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarEstado.TabIndex = 2
        Me.btnCancelarEstado.Text = "Cancelar"
        Me.btnCancelarEstado.UseVisualStyleBackColor = True
        '
        'btnSalvarEstado
        '
        Me.btnSalvarEstado.Location = New System.Drawing.Point(261, 102)
        Me.btnSalvarEstado.Name = "btnSalvarEstado"
        Me.btnSalvarEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarEstado.TabIndex = 1
        Me.btnSalvarEstado.Text = "Salvar"
        Me.btnSalvarEstado.UseVisualStyleBackColor = True
        '
        'FormEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 135)
        Me.Controls.Add(Me.btnDeletarEstado)
        Me.Controls.Add(Me.GroupBoxCadAux)
        Me.Controls.Add(Me.btnCancelarEstado)
        Me.Controls.Add(Me.btnSalvarEstado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado"
        Me.GroupBoxCadAux.ResumeLayout(False)
        Me.GroupBoxCadAux.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDeletarEstado As System.Windows.Forms.Button
    Friend WithEvents GroupBoxCadAux As System.Windows.Forms.GroupBox
    Friend WithEvents txtEstadoId As System.Windows.Forms.TextBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelarEstado As System.Windows.Forms.Button
    Friend WithEvents btnSalvarEstado As System.Windows.Forms.Button
End Class
