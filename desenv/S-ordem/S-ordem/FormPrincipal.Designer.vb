<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuPrincipal = New System.Windows.Forms.GroupBox()
        Me.btnConsultaUsuario = New System.Windows.Forms.Button()
        Me.Sair = New System.Windows.Forms.Button()
        Me.btnAddUsuario = New System.Windows.Forms.Button()
        Me.AddCliente = New System.Windows.Forms.Button()
        Me.ConsultaOrdensDeServicos = New System.Windows.Forms.Button()
        Me.ConsultaClientes = New System.Windows.Forms.Button()
        Me.AddOrdemDeServico = New System.Windows.Forms.Button()
        Me.btnRelatorioOrdens = New System.Windows.Forms.Button()
        Me.btnRelatorioClientes = New System.Windows.Forms.Button()
        Me.alt = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAddMarcas = New System.Windows.Forms.Button()
        Me.btnAddEstado = New System.Windows.Forms.Button()
        Me.btnConsultaMarcas = New System.Windows.Forms.Button()
        Me.btnConsultaEstado = New System.Windows.Forms.Button()
        Me.groupBoxRelatorios = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCadAux = New System.Windows.Forms.GroupBox()
        Me.usuarioLogado = New System.Windows.Forms.Label()
        Me.MenuPrincipal.SuspendLayout()
        Me.groupBoxRelatorios.SuspendLayout()
        Me.GroupBoxCadAux.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuPrincipal.Controls.Add(Me.btnConsultaUsuario)
        Me.MenuPrincipal.Controls.Add(Me.Sair)
        Me.MenuPrincipal.Controls.Add(Me.btnAddUsuario)
        Me.MenuPrincipal.Controls.Add(Me.AddCliente)
        Me.MenuPrincipal.Controls.Add(Me.ConsultaOrdensDeServicos)
        Me.MenuPrincipal.Controls.Add(Me.ConsultaClientes)
        Me.MenuPrincipal.Controls.Add(Me.AddOrdemDeServico)
        Me.MenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPrincipal.Location = New System.Drawing.Point(12, 27)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(794, 167)
        Me.MenuPrincipal.TabIndex = 1
        Me.MenuPrincipal.TabStop = False
        Me.MenuPrincipal.Text = "Menu Principal"
        '
        'btnConsultaUsuario
        '
        Me.btnConsultaUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConsultaUsuario.Image = Global.sordem.My.Resources.Resources.Person_white_search
        Me.btnConsultaUsuario.Location = New System.Drawing.Point(563, 35)
        Me.btnConsultaUsuario.Name = "btnConsultaUsuario"
        Me.btnConsultaUsuario.Size = New System.Drawing.Size(100, 100)
        Me.btnConsultaUsuario.TabIndex = 6
        Me.btnConsultaUsuario.Text = "Consultar Usuário"
        Me.btnConsultaUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.btnConsultaUsuario, "Consultar Usuário")
        Me.btnConsultaUsuario.UseVisualStyleBackColor = True
        '
        'Sair
        '
        Me.Sair.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Sair.Image = Global.sordem.My.Resources.Resources.X
        Me.Sair.Location = New System.Drawing.Point(669, 35)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(100, 100)
        Me.Sair.TabIndex = 7
        Me.Sair.Text = "Sair"
        Me.Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.Sair, "Sair")
        Me.Sair.UseVisualStyleBackColor = True
        '
        'btnAddUsuario
        '
        Me.btnAddUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddUsuario.Image = Global.sordem.My.Resources.Resources.Person_white_add
        Me.btnAddUsuario.Location = New System.Drawing.Point(457, 35)
        Me.btnAddUsuario.Name = "btnAddUsuario"
        Me.btnAddUsuario.Size = New System.Drawing.Size(100, 100)
        Me.btnAddUsuario.TabIndex = 5
        Me.btnAddUsuario.Text = "Adicionar Usuário"
        Me.btnAddUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.btnAddUsuario, "Adicionar Usuário")
        Me.btnAddUsuario.UseVisualStyleBackColor = True
        '
        'AddCliente
        '
        Me.AddCliente.AccessibleDescription = ""
        Me.AddCliente.AccessibleName = ""
        Me.AddCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddCliente.Image = Global.sordem.My.Resources.Resources.Person_add
        Me.AddCliente.Location = New System.Drawing.Point(33, 35)
        Me.AddCliente.Name = "AddCliente"
        Me.AddCliente.Size = New System.Drawing.Size(100, 100)
        Me.AddCliente.TabIndex = 0
        Me.AddCliente.Tag = ""
        Me.AddCliente.Text = "Adicionar Cliente"
        Me.AddCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.AddCliente, "Adicionar Cliente")
        Me.AddCliente.UseVisualStyleBackColor = True
        '
        'ConsultaOrdensDeServicos
        '
        Me.ConsultaOrdensDeServicos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ConsultaOrdensDeServicos.Image = Global.sordem.My.Resources.Resources.Paper_search
        Me.ConsultaOrdensDeServicos.Location = New System.Drawing.Point(351, 35)
        Me.ConsultaOrdensDeServicos.Name = "ConsultaOrdensDeServicos"
        Me.ConsultaOrdensDeServicos.Size = New System.Drawing.Size(100, 100)
        Me.ConsultaOrdensDeServicos.TabIndex = 3
        Me.ConsultaOrdensDeServicos.Text = "Consultar Ordem"
        Me.ConsultaOrdensDeServicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.ConsultaOrdensDeServicos, "Consultar Ordens de Serviço")
        Me.ConsultaOrdensDeServicos.UseVisualStyleBackColor = True
        '
        'ConsultaClientes
        '
        Me.ConsultaClientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ConsultaClientes.Image = Global.sordem.My.Resources.Resources.Person_serach
        Me.ConsultaClientes.Location = New System.Drawing.Point(139, 35)
        Me.ConsultaClientes.Name = "ConsultaClientes"
        Me.ConsultaClientes.Size = New System.Drawing.Size(100, 100)
        Me.ConsultaClientes.TabIndex = 1
        Me.ConsultaClientes.Text = "Consultar Cliente"
        Me.ConsultaClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.ConsultaClientes, "Consultar Clientes")
        Me.ConsultaClientes.UseVisualStyleBackColor = True
        '
        'AddOrdemDeServico
        '
        Me.AddOrdemDeServico.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddOrdemDeServico.Image = Global.sordem.My.Resources.Resources.Paper_add
        Me.AddOrdemDeServico.Location = New System.Drawing.Point(245, 35)
        Me.AddOrdemDeServico.Name = "AddOrdemDeServico"
        Me.AddOrdemDeServico.Size = New System.Drawing.Size(100, 100)
        Me.AddOrdemDeServico.TabIndex = 2
        Me.AddOrdemDeServico.Text = "Adicionar Ordem"
        Me.AddOrdemDeServico.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.AddOrdemDeServico, "Adicionar Ordem de Serviço")
        Me.AddOrdemDeServico.UseVisualStyleBackColor = True
        '
        'btnRelatorioOrdens
        '
        Me.btnRelatorioOrdens.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRelatorioOrdens.Image = Global.sordem.My.Resources.Resources.Paper
        Me.btnRelatorioOrdens.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRelatorioOrdens.Location = New System.Drawing.Point(397, 35)
        Me.btnRelatorioOrdens.Name = "btnRelatorioOrdens"
        Me.btnRelatorioOrdens.Size = New System.Drawing.Size(100, 100)
        Me.btnRelatorioOrdens.TabIndex = 9
        Me.btnRelatorioOrdens.Text = "Relatório de Ordens"
        Me.btnRelatorioOrdens.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.btnRelatorioOrdens, "Relatório de Ordens de Serviço")
        Me.btnRelatorioOrdens.UseVisualStyleBackColor = True
        '
        'btnRelatorioClientes
        '
        Me.btnRelatorioClientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRelatorioClientes.Image = Global.sordem.My.Resources.Resources.Paper
        Me.btnRelatorioClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRelatorioClientes.Location = New System.Drawing.Point(291, 35)
        Me.btnRelatorioClientes.Name = "btnRelatorioClientes"
        Me.btnRelatorioClientes.Size = New System.Drawing.Size(100, 100)
        Me.btnRelatorioClientes.TabIndex = 8
        Me.btnRelatorioClientes.Text = "Relatório de Clientes"
        Me.btnRelatorioClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.btnRelatorioClientes, "Relatório de Clientes")
        Me.btnRelatorioClientes.UseVisualStyleBackColor = True
        '
        'btnAddMarcas
        '
        Me.btnAddMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddMarcas.Image = Global.sordem.My.Resources.Resources.Database_add
        Me.btnAddMarcas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddMarcas.Location = New System.Drawing.Point(188, 39)
        Me.btnAddMarcas.Name = "btnAddMarcas"
        Me.btnAddMarcas.Size = New System.Drawing.Size(100, 100)
        Me.btnAddMarcas.TabIndex = 10
        Me.btnAddMarcas.Text = "Adicionar Marcas"
        Me.btnAddMarcas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.btnAddMarcas, "Relatório de Clientes")
        Me.btnAddMarcas.UseVisualStyleBackColor = True
        '
        'btnAddEstado
        '
        Me.btnAddEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddEstado.Image = Global.sordem.My.Resources.Resources.Database_add
        Me.btnAddEstado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddEstado.Location = New System.Drawing.Point(400, 39)
        Me.btnAddEstado.Name = "btnAddEstado"
        Me.btnAddEstado.Size = New System.Drawing.Size(100, 100)
        Me.btnAddEstado.TabIndex = 12
        Me.btnAddEstado.Text = "Adicionar Estados"
        Me.btnAddEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.btnAddEstado, "Relatório de Clientes")
        Me.btnAddEstado.UseVisualStyleBackColor = True
        '
        'btnConsultaMarcas
        '
        Me.btnConsultaMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConsultaMarcas.Image = Global.sordem.My.Resources.Resources.Database
        Me.btnConsultaMarcas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultaMarcas.Location = New System.Drawing.Point(294, 39)
        Me.btnConsultaMarcas.Name = "btnConsultaMarcas"
        Me.btnConsultaMarcas.Size = New System.Drawing.Size(100, 100)
        Me.btnConsultaMarcas.TabIndex = 11
        Me.btnConsultaMarcas.Text = "Consultar Marcas"
        Me.btnConsultaMarcas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.btnConsultaMarcas, "Relatório de Clientes")
        Me.btnConsultaMarcas.UseVisualStyleBackColor = True
        '
        'btnConsultaEstado
        '
        Me.btnConsultaEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConsultaEstado.Image = Global.sordem.My.Resources.Resources.Database
        Me.btnConsultaEstado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultaEstado.Location = New System.Drawing.Point(506, 39)
        Me.btnConsultaEstado.Name = "btnConsultaEstado"
        Me.btnConsultaEstado.Size = New System.Drawing.Size(100, 100)
        Me.btnConsultaEstado.TabIndex = 13
        Me.btnConsultaEstado.Text = "Consultar Estados"
        Me.btnConsultaEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alt.SetToolTip(Me.btnConsultaEstado, "Relatório de Clientes")
        Me.btnConsultaEstado.UseVisualStyleBackColor = True
        '
        'groupBoxRelatorios
        '
        Me.groupBoxRelatorios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxRelatorios.Controls.Add(Me.btnRelatorioOrdens)
        Me.groupBoxRelatorios.Controls.Add(Me.btnRelatorioClientes)
        Me.groupBoxRelatorios.Location = New System.Drawing.Point(12, 218)
        Me.groupBoxRelatorios.Name = "groupBoxRelatorios"
        Me.groupBoxRelatorios.Size = New System.Drawing.Size(794, 167)
        Me.groupBoxRelatorios.TabIndex = 8
        Me.groupBoxRelatorios.TabStop = False
        Me.groupBoxRelatorios.Text = "Relatórios"
        '
        'GroupBoxCadAux
        '
        Me.GroupBoxCadAux.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxCadAux.Controls.Add(Me.btnConsultaEstado)
        Me.GroupBoxCadAux.Controls.Add(Me.btnConsultaMarcas)
        Me.GroupBoxCadAux.Controls.Add(Me.btnAddEstado)
        Me.GroupBoxCadAux.Controls.Add(Me.btnAddMarcas)
        Me.GroupBoxCadAux.Location = New System.Drawing.Point(12, 391)
        Me.GroupBoxCadAux.Name = "GroupBoxCadAux"
        Me.GroupBoxCadAux.Size = New System.Drawing.Size(794, 170)
        Me.GroupBoxCadAux.TabIndex = 9
        Me.GroupBoxCadAux.TabStop = False
        Me.GroupBoxCadAux.Text = "Cadastros Auxiliares"
        '
        'usuarioLogado
        '
        Me.usuarioLogado.AutoSize = True
        Me.usuarioLogado.Location = New System.Drawing.Point(636, 564)
        Me.usuarioLogado.Name = "usuarioLogado"
        Me.usuarioLogado.Size = New System.Drawing.Size(0, 13)
        Me.usuarioLogado.TabIndex = 10
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 585)
        Me.Controls.Add(Me.usuarioLogado)
        Me.Controls.Add(Me.GroupBoxCadAux)
        Me.Controls.Add(Me.groupBoxRelatorios)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S-Ordem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuPrincipal.ResumeLayout(False)
        Me.groupBoxRelatorios.ResumeLayout(False)
        Me.GroupBoxCadAux.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents Sair As System.Windows.Forms.Button
    Friend WithEvents AddCliente As System.Windows.Forms.Button
    Friend WithEvents ConsultaOrdensDeServicos As System.Windows.Forms.Button
    Friend WithEvents ConsultaClientes As System.Windows.Forms.Button
    Friend WithEvents AddOrdemDeServico As System.Windows.Forms.Button
    Friend WithEvents alt As System.Windows.Forms.ToolTip
    Friend WithEvents btnAddUsuario As System.Windows.Forms.Button
    Friend WithEvents btnConsultaUsuario As System.Windows.Forms.Button
    Friend WithEvents btnRelatorioOrdens As System.Windows.Forms.Button
    Friend WithEvents btnRelatorioClientes As System.Windows.Forms.Button
    Friend WithEvents groupBoxRelatorios As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxCadAux As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddMarcas As System.Windows.Forms.Button
    Friend WithEvents btnConsultaEstado As System.Windows.Forms.Button
    Friend WithEvents btnConsultaMarcas As System.Windows.Forms.Button
    Friend WithEvents btnAddEstado As System.Windows.Forms.Button
    Friend WithEvents usuarioLogado As System.Windows.Forms.Label

End Class
