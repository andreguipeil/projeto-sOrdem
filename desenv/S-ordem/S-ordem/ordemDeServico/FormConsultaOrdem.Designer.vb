<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaOrdem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaOrdem))
        Me.GroupFiltro = New System.Windows.Forms.GroupBox()
        Me.btnRelatorioOrdens = New System.Windows.Forms.Button()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.txtConsultaModelo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelarOrdem = New System.Windows.Forms.Button()
        Me.btnPesquisarOrdem = New System.Windows.Forms.Button()
        Me.cmbEstadoOrdem = New System.Windows.Forms.ComboBox()
        Me.txtConsultaCliente = New System.Windows.Forms.TextBox()
        Me.txtConsultaNrOrdem = New System.Windows.Forms.TextBox()
        Me.lblEstadoOrdem = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNrOrdem = New System.Windows.Forms.Label()
        Me.gridOrdens = New System.Windows.Forms.DataGridView()
        Me.nrOrdem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoOrdem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_saida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco_concerto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defeito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.laudo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_alteracao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alt = New System.Windows.Forms.ToolTip(Me.components)
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.GroupFiltro.SuspendLayout()
        CType(Me.gridOrdens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupFiltro
        '
        Me.GroupFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupFiltro.Controls.Add(Me.btnRelatorioOrdens)
        Me.GroupFiltro.Controls.Add(Me.cmbMarca)
        Me.GroupFiltro.Controls.Add(Me.txtConsultaModelo)
        Me.GroupFiltro.Controls.Add(Me.Label2)
        Me.GroupFiltro.Controls.Add(Me.Label1)
        Me.GroupFiltro.Controls.Add(Me.btnCancelarOrdem)
        Me.GroupFiltro.Controls.Add(Me.btnPesquisarOrdem)
        Me.GroupFiltro.Controls.Add(Me.cmbEstadoOrdem)
        Me.GroupFiltro.Controls.Add(Me.txtConsultaCliente)
        Me.GroupFiltro.Controls.Add(Me.txtConsultaNrOrdem)
        Me.GroupFiltro.Controls.Add(Me.lblEstadoOrdem)
        Me.GroupFiltro.Controls.Add(Me.lblCliente)
        Me.GroupFiltro.Controls.Add(Me.lblNrOrdem)
        Me.GroupFiltro.Location = New System.Drawing.Point(30, 21)
        Me.GroupFiltro.Name = "GroupFiltro"
        Me.GroupFiltro.Size = New System.Drawing.Size(949, 225)
        Me.GroupFiltro.TabIndex = 0
        Me.GroupFiltro.TabStop = False
        Me.GroupFiltro.Text = "Filtro"
        '
        'btnRelatorioOrdens
        '
        Me.btnRelatorioOrdens.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorioOrdens.Location = New System.Drawing.Point(706, 196)
        Me.btnRelatorioOrdens.Name = "btnRelatorioOrdens"
        Me.btnRelatorioOrdens.Size = New System.Drawing.Size(75, 23)
        Me.btnRelatorioOrdens.TabIndex = 12
        Me.btnRelatorioOrdens.Text = "Relatório"
        Me.btnRelatorioOrdens.UseVisualStyleBackColor = True
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(135, 130)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(220, 21)
        Me.cmbMarca.TabIndex = 8
        '
        'txtConsultaModelo
        '
        Me.txtConsultaModelo.Location = New System.Drawing.Point(135, 168)
        Me.txtConsultaModelo.Name = "txtConsultaModelo"
        Me.txtConsultaModelo.Size = New System.Drawing.Size(284, 20)
        Me.txtConsultaModelo.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Modelo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Marca"
        '
        'btnCancelarOrdem
        '
        Me.btnCancelarOrdem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarOrdem.Location = New System.Drawing.Point(787, 196)
        Me.btnCancelarOrdem.Name = "btnCancelarOrdem"
        Me.btnCancelarOrdem.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarOrdem.TabIndex = 11
        Me.btnCancelarOrdem.Text = "Cancelar"
        Me.btnCancelarOrdem.UseVisualStyleBackColor = True
        '
        'btnPesquisarOrdem
        '
        Me.btnPesquisarOrdem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesquisarOrdem.Location = New System.Drawing.Point(868, 196)
        Me.btnPesquisarOrdem.Name = "btnPesquisarOrdem"
        Me.btnPesquisarOrdem.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisarOrdem.TabIndex = 10
        Me.btnPesquisarOrdem.Text = "Pesquisar"
        Me.btnPesquisarOrdem.UseVisualStyleBackColor = True
        '
        'cmbEstadoOrdem
        '
        Me.cmbEstadoOrdem.FormattingEnabled = True
        Me.cmbEstadoOrdem.Location = New System.Drawing.Point(135, 91)
        Me.cmbEstadoOrdem.Name = "cmbEstadoOrdem"
        Me.cmbEstadoOrdem.Size = New System.Drawing.Size(220, 21)
        Me.cmbEstadoOrdem.TabIndex = 7
        '
        'txtConsultaCliente
        '
        Me.txtConsultaCliente.Location = New System.Drawing.Point(135, 60)
        Me.txtConsultaCliente.Name = "txtConsultaCliente"
        Me.txtConsultaCliente.Size = New System.Drawing.Size(284, 20)
        Me.txtConsultaCliente.TabIndex = 6
        '
        'txtConsultaNrOrdem
        '
        Me.txtConsultaNrOrdem.Location = New System.Drawing.Point(135, 27)
        Me.txtConsultaNrOrdem.Name = "txtConsultaNrOrdem"
        Me.txtConsultaNrOrdem.Size = New System.Drawing.Size(64, 20)
        Me.txtConsultaNrOrdem.TabIndex = 5
        '
        'lblEstadoOrdem
        '
        Me.lblEstadoOrdem.AutoSize = True
        Me.lblEstadoOrdem.Location = New System.Drawing.Point(13, 94)
        Me.lblEstadoOrdem.Name = "lblEstadoOrdem"
        Me.lblEstadoOrdem.Size = New System.Drawing.Size(89, 13)
        Me.lblEstadoOrdem.TabIndex = 2
        Me.lblEstadoOrdem.Text = "Estado da Ordem"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(13, 63)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'lblNrOrdem
        '
        Me.lblNrOrdem.AutoSize = True
        Me.lblNrOrdem.Location = New System.Drawing.Point(13, 30)
        Me.lblNrOrdem.Name = "lblNrOrdem"
        Me.lblNrOrdem.Size = New System.Drawing.Size(55, 13)
        Me.lblNrOrdem.TabIndex = 0
        Me.lblNrOrdem.Text = "Nr. Ordem"
        '
        'gridOrdens
        '
        Me.gridOrdens.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOrdens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridOrdens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOrdens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nrOrdem, Me.cliente, Me.estadoOrdem, Me.dt_entrada, Me.dt_saida, Me.marca, Me.modelo, Me.preco_concerto, Me.defeito, Me.laudo, Me.observacao, Me.dt_alteracao, Me.usuario})
        Me.gridOrdens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.gridOrdens.Location = New System.Drawing.Point(30, 268)
        Me.gridOrdens.Name = "gridOrdens"
        Me.gridOrdens.ReadOnly = True
        Me.gridOrdens.Size = New System.Drawing.Size(949, 259)
        Me.gridOrdens.TabIndex = 1
        '
        'nrOrdem
        '
        Me.nrOrdem.DataPropertyName = "nr_ordem"
        Me.nrOrdem.HeaderText = "Nr. Ordem"
        Me.nrOrdem.MinimumWidth = 30
        Me.nrOrdem.Name = "nrOrdem"
        Me.nrOrdem.ReadOnly = True
        '
        'cliente
        '
        Me.cliente.DataPropertyName = "cliente"
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.MinimumWidth = 140
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'estadoOrdem
        '
        Me.estadoOrdem.DataPropertyName = "estado"
        Me.estadoOrdem.HeaderText = "Estado"
        Me.estadoOrdem.MinimumWidth = 80
        Me.estadoOrdem.Name = "estadoOrdem"
        Me.estadoOrdem.ReadOnly = True
        '
        'dt_entrada
        '
        Me.dt_entrada.DataPropertyName = "dt_entrada"
        Me.dt_entrada.HeaderText = "Dt. Entrada"
        Me.dt_entrada.MinimumWidth = 90
        Me.dt_entrada.Name = "dt_entrada"
        Me.dt_entrada.ReadOnly = True
        '
        'dt_saida
        '
        Me.dt_saida.DataPropertyName = "dt_saida"
        Me.dt_saida.HeaderText = "Dt. Saida"
        Me.dt_saida.MinimumWidth = 90
        Me.dt_saida.Name = "dt_saida"
        Me.dt_saida.ReadOnly = True
        '
        'marca
        '
        Me.marca.DataPropertyName = "marca"
        Me.marca.HeaderText = "Marca"
        Me.marca.MinimumWidth = 60
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "modelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.MinimumWidth = 70
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'preco_concerto
        '
        Me.preco_concerto.DataPropertyName = "preco_concerto"
        Me.preco_concerto.HeaderText = "Taxa"
        Me.preco_concerto.MinimumWidth = 40
        Me.preco_concerto.Name = "preco_concerto"
        Me.preco_concerto.ReadOnly = True
        '
        'defeito
        '
        Me.defeito.DataPropertyName = "defeito"
        Me.defeito.HeaderText = "Defeito"
        Me.defeito.MinimumWidth = 50
        Me.defeito.Name = "defeito"
        Me.defeito.ReadOnly = True
        '
        'laudo
        '
        Me.laudo.DataPropertyName = "laudo"
        Me.laudo.HeaderText = "Laudo"
        Me.laudo.MinimumWidth = 50
        Me.laudo.Name = "laudo"
        Me.laudo.ReadOnly = True
        '
        'observacao
        '
        Me.observacao.DataPropertyName = "observacao"
        Me.observacao.HeaderText = "Observação"
        Me.observacao.MinimumWidth = 40
        Me.observacao.Name = "observacao"
        Me.observacao.ReadOnly = True
        '
        'dt_alteracao
        '
        Me.dt_alteracao.DataPropertyName = "dt_alteracao"
        Me.dt_alteracao.HeaderText = "Dt.  Alteração"
        Me.dt_alteracao.MinimumWidth = 90
        Me.dt_alteracao.Name = "dt_alteracao"
        Me.dt_alteracao.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "usuario"
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.MinimumWidth = 30
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'grid
        '
        Me.grid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.grid.Location = New System.Drawing.Point(30, 263)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(895, 259)
        Me.grid.TabIndex = 1
        '
        'FormConsultaOrdem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 550)
        Me.Controls.Add(Me.gridOrdens)
        Me.Controls.Add(Me.GroupFiltro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormConsultaOrdem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado da Ordem"
        Me.GroupFiltro.ResumeLayout(False)
        Me.GroupFiltro.PerformLayout()
        CType(Me.gridOrdens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelarOrdem As System.Windows.Forms.Button
    Friend WithEvents btnPesquisarOrdem As System.Windows.Forms.Button
    Friend WithEvents cmbEstadoOrdem As System.Windows.Forms.ComboBox
    Friend WithEvents txtConsultaCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultaNrOrdem As System.Windows.Forms.TextBox
    Friend WithEvents lblEstadoOrdem As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblNrOrdem As System.Windows.Forms.Label
    Friend WithEvents gridOrdens As System.Windows.Forms.DataGridView
    Friend WithEvents alt As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents txtConsultaModelo As System.Windows.Forms.TextBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents nrOrdem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estadoOrdem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_saida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preco_concerto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defeito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents laudo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt_alteracao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRelatorioOrdens As System.Windows.Forms.Button
End Class
