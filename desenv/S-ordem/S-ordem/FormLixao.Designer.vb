<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLixao
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
        Me.gridLixao = New System.Windows.Forms.DataGridView()
        Me.groupBoxLixao = New System.Windows.Forms.GroupBox()
        Me.btnCancelarLixao = New System.Windows.Forms.Button()
        CType(Me.gridLixao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxLixao.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridLixao
        '
        Me.gridLixao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridLixao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLixao.Location = New System.Drawing.Point(6, 33)
        Me.gridLixao.Name = "gridLixao"
        Me.gridLixao.ReadOnly = True
        Me.gridLixao.Size = New System.Drawing.Size(739, 284)
        Me.gridLixao.TabIndex = 0
        '
        'groupBoxLixao
        '
        Me.groupBoxLixao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxLixao.Controls.Add(Me.gridLixao)
        Me.groupBoxLixao.Location = New System.Drawing.Point(12, 13)
        Me.groupBoxLixao.Name = "groupBoxLixao"
        Me.groupBoxLixao.Size = New System.Drawing.Size(755, 335)
        Me.groupBoxLixao.TabIndex = 1
        Me.groupBoxLixao.TabStop = False
        Me.groupBoxLixao.Text = "Lixão"
        '
        'btnCancelarLixao
        '
        Me.btnCancelarLixao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarLixao.Location = New System.Drawing.Point(683, 354)
        Me.btnCancelarLixao.Name = "btnCancelarLixao"
        Me.btnCancelarLixao.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarLixao.TabIndex = 2
        Me.btnCancelarLixao.Text = "Cancelar"
        Me.btnCancelarLixao.UseVisualStyleBackColor = True
        '
        'FormLixao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 386)
        Me.Controls.Add(Me.btnCancelarLixao)
        Me.Controls.Add(Me.groupBoxLixao)
        Me.KeyPreview = True
        Me.Name = "FormLixao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lixao"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridLixao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxLixao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridLixao As System.Windows.Forms.DataGridView
    Friend WithEvents groupBoxLixao As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelarLixao As System.Windows.Forms.Button
End Class
