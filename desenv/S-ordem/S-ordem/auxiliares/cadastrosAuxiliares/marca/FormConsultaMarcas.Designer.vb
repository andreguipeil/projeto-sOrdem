<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaMarcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaMarcas))
        Me.GroupBoxConsultaMarcas = New System.Windows.Forms.GroupBox()
        Me.gridMarcas = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBoxConsultaMarcas.SuspendLayout()
        CType(Me.gridMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxConsultaMarcas
        '
        Me.GroupBoxConsultaMarcas.Controls.Add(Me.gridMarcas)
        Me.GroupBoxConsultaMarcas.Location = New System.Drawing.Point(13, 13)
        Me.GroupBoxConsultaMarcas.Name = "GroupBoxConsultaMarcas"
        Me.GroupBoxConsultaMarcas.Size = New System.Drawing.Size(312, 340)
        Me.GroupBoxConsultaMarcas.TabIndex = 0
        Me.GroupBoxConsultaMarcas.TabStop = False
        Me.GroupBoxConsultaMarcas.Text = "Consulta"
        '
        'gridMarcas
        '
        Me.gridMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridMarcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nome})
        Me.gridMarcas.Location = New System.Drawing.Point(21, 28)
        Me.gridMarcas.Name = "gridMarcas"
        Me.gridMarcas.ReadOnly = True
        Me.gridMarcas.Size = New System.Drawing.Size(273, 293)
        Me.gridMarcas.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 30
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 30
        '
        'nome
        '
        Me.nome.DataPropertyName = "nome"
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 200
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 200
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(249, 360)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSelecionar.TabIndex = 1
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(168, 360)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormConsultaMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 394)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.GroupBoxConsultaMarcas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConsultaMarcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Marcas"
        Me.GroupBoxConsultaMarcas.ResumeLayout(False)
        CType(Me.gridMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxConsultaMarcas As System.Windows.Forms.GroupBox
    Friend WithEvents gridMarcas As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
