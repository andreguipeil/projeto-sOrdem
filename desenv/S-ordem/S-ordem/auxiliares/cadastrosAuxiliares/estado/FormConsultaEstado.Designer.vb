<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaEstado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaEstado))
        Me.btnCancelarEstado = New System.Windows.Forms.Button()
        Me.btnSelecionarEstado = New System.Windows.Forms.Button()
        Me.GroupBoxConsultaEstado = New System.Windows.Forms.GroupBox()
        Me.gridEstados = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxConsultaEstado.SuspendLayout()
        CType(Me.gridEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarEstado
        '
        Me.btnCancelarEstado.Location = New System.Drawing.Point(167, 359)
        Me.btnCancelarEstado.Name = "btnCancelarEstado"
        Me.btnCancelarEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarEstado.TabIndex = 2
        Me.btnCancelarEstado.Text = "Cancelar"
        Me.btnCancelarEstado.UseVisualStyleBackColor = True
        '
        'btnSelecionarEstado
        '
        Me.btnSelecionarEstado.Location = New System.Drawing.Point(248, 359)
        Me.btnSelecionarEstado.Name = "btnSelecionarEstado"
        Me.btnSelecionarEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnSelecionarEstado.TabIndex = 1
        Me.btnSelecionarEstado.Text = "Selecionar"
        Me.btnSelecionarEstado.UseVisualStyleBackColor = True
        '
        'GroupBoxConsultaEstado
        '
        Me.GroupBoxConsultaEstado.Controls.Add(Me.gridEstados)
        Me.GroupBoxConsultaEstado.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxConsultaEstado.Name = "GroupBoxConsultaEstado"
        Me.GroupBoxConsultaEstado.Size = New System.Drawing.Size(312, 340)
        Me.GroupBoxConsultaEstado.TabIndex = 3
        Me.GroupBoxConsultaEstado.TabStop = False
        Me.GroupBoxConsultaEstado.Text = "Consulta"
        '
        'gridEstados
        '
        Me.gridEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEstados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nome})
        Me.gridEstados.Location = New System.Drawing.Point(21, 28)
        Me.gridEstados.Name = "gridEstados"
        Me.gridEstados.ReadOnly = True
        Me.gridEstados.Size = New System.Drawing.Size(273, 293)
        Me.gridEstados.TabIndex = 0
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
        'FormConsultaEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 396)
        Me.Controls.Add(Me.btnCancelarEstado)
        Me.Controls.Add(Me.btnSelecionarEstado)
        Me.Controls.Add(Me.GroupBoxConsultaEstado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConsultaEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Estado"
        Me.GroupBoxConsultaEstado.ResumeLayout(False)
        CType(Me.gridEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelarEstado As System.Windows.Forms.Button
    Friend WithEvents btnSelecionarEstado As System.Windows.Forms.Button
    Friend WithEvents GroupBoxConsultaEstado As System.Windows.Forms.GroupBox
    Friend WithEvents gridEstados As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
