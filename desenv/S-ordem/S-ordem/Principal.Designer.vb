<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.MenuPrincipal = New System.Windows.Forms.GroupBox()
        Me.Sair = New System.Windows.Forms.Button()
        Me.AddCliente = New System.Windows.Forms.Button()
        Me.ConsultaOrdensDeServicos = New System.Windows.Forms.Button()
        Me.ConsultaClientes = New System.Windows.Forms.Button()
        Me.AddOrdemDeServico = New System.Windows.Forms.Button()
        Me.alt = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Controls.Add(Me.Sair)
        Me.MenuPrincipal.Controls.Add(Me.AddCliente)
        Me.MenuPrincipal.Controls.Add(Me.ConsultaOrdensDeServicos)
        Me.MenuPrincipal.Controls.Add(Me.ConsultaClientes)
        Me.MenuPrincipal.Controls.Add(Me.AddOrdemDeServico)
        Me.MenuPrincipal.Location = New System.Drawing.Point(12, 23)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(800, 208)
        Me.MenuPrincipal.TabIndex = 1
        Me.MenuPrincipal.TabStop = False
        Me.MenuPrincipal.Text = "Menu Principal"
        '
        'Sair
        '
        Me.Sair.Image = Global.WindowsApplication1.My.Resources.Resources.exit128
        Me.Sair.Location = New System.Drawing.Point(657, 41)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(128, 128)
        Me.Sair.TabIndex = 4
        Me.alt.SetToolTip(Me.Sair, "Sair")
        Me.Sair.UseVisualStyleBackColor = True
        '
        'AddCliente
        '
        Me.AddCliente.AccessibleDescription = ""
        Me.AddCliente.AccessibleName = ""
        Me.AddCliente.Image = Global.WindowsApplication1.My.Resources.Resources.add_cliente128
        Me.AddCliente.Location = New System.Drawing.Point(17, 41)
        Me.AddCliente.Name = "AddCliente"
        Me.AddCliente.Size = New System.Drawing.Size(128, 128)
        Me.AddCliente.TabIndex = 0
        Me.AddCliente.Tag = ""
        Me.alt.SetToolTip(Me.AddCliente, "Adicionar Cliente")
        Me.AddCliente.UseVisualStyleBackColor = True
        '
        'ConsultaOrdensDeServicos
        '
        Me.ConsultaOrdensDeServicos.Image = Global.WindowsApplication1.My.Resources.Resources.consulta_ordem128
        Me.ConsultaOrdensDeServicos.Location = New System.Drawing.Point(493, 41)
        Me.ConsultaOrdensDeServicos.Name = "ConsultaOrdensDeServicos"
        Me.ConsultaOrdensDeServicos.Size = New System.Drawing.Size(128, 128)
        Me.ConsultaOrdensDeServicos.TabIndex = 3
        Me.alt.SetToolTip(Me.ConsultaOrdensDeServicos, "Consultar Ordens de Serviço")
        Me.ConsultaOrdensDeServicos.UseVisualStyleBackColor = True
        '
        'ConsultaClientes
        '
        Me.ConsultaClientes.Image = Global.WindowsApplication1.My.Resources.Resources.consulta_cliente128
        Me.ConsultaClientes.Location = New System.Drawing.Point(176, 41)
        Me.ConsultaClientes.Name = "ConsultaClientes"
        Me.ConsultaClientes.Size = New System.Drawing.Size(128, 128)
        Me.ConsultaClientes.TabIndex = 1
        Me.alt.SetToolTip(Me.ConsultaClientes, "Consultar Clientes")
        Me.ConsultaClientes.UseVisualStyleBackColor = True
        '
        'AddOrdemDeServico
        '
        Me.AddOrdemDeServico.Image = Global.WindowsApplication1.My.Resources.Resources.add_ordem128
        Me.AddOrdemDeServico.Location = New System.Drawing.Point(338, 41)
        Me.AddOrdemDeServico.Name = "AddOrdemDeServico"
        Me.AddOrdemDeServico.Size = New System.Drawing.Size(128, 128)
        Me.AddOrdemDeServico.TabIndex = 2
        Me.alt.SetToolTip(Me.AddOrdemDeServico, "Adicionar Ordem de Serviço")
        Me.AddOrdemDeServico.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 666)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Name = "Principal"
        Me.Text = "S-Ordem"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents Sair As System.Windows.Forms.Button
    Friend WithEvents AddCliente As System.Windows.Forms.Button
    Friend WithEvents ConsultaOrdensDeServicos As System.Windows.Forms.Button
    Friend WithEvents ConsultaClientes As System.Windows.Forms.Button
    Friend WithEvents AddOrdemDeServico As System.Windows.Forms.Button
    Friend WithEvents alt As System.Windows.Forms.ToolTip

End Class
