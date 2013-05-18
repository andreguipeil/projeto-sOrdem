Public Class FormConsultaUsuario
    Private _IDUsuario As Integer
    Dim acessoUsuarioModel As New usuarioModel


    ReadOnly Property IDUsuario() As String
        Get
            Return _IDUsuario
        End Get
    End Property


    ' INIT
    '==========================================================
    Private Sub FormProcurarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        acessoUsuarioModel.atualizarUsuario()
        gridUsuarios.ReadOnly = True
    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '


    ' FORMULARIO
    '==========================================================

    ' USUARIO_NOME
    '-----------------------
    Private Sub txtUsuarioNome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuarioNome.TextChanged

        gridUsuarios.DataSource = acessoUsuarioModel.buscarUsuario(txtUsuarioNome.Text)

    End Sub


    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    '   BOTOES
    '==========================================================



    ' SELECIONAR
    '==========================================================
    Private Sub btnSelecionar_Click() Handles btnSelecionar.Click
        If gridUsuarios.RowCount = 1 Then
            gridUsuarioVazia()
            Me.DialogResult = Windows.Forms.DialogResult.None
        Else
            If String.IsNullOrEmpty(gridUsuarios.CurrentRow.Cells("id").Value.ToString) Then
                linhaUsuarioInvalida()
                Me.DialogResult = Windows.Forms.DialogResult.None
            Else
                _IDUsuario = gridUsuarios.CurrentRow.Cells("id").Value.ToString()
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Me.fecharForm(True)
                Dim editarUsuario As New FormUsuario
                Dim usuario As New Usuario

                usuario = acessoUsuarioModel.getUsuarioById(_IDUsuario)
                editarUsuario.carregaDados(usuario)
                editarUsuario.ShowDialog()

            End If
        End If
    End Sub

    ' GRID DOUBLE CLICK
    '==========================================================
    Private Sub gridUsuarios_MouseDoubleClick() Handles gridUsuarios.MouseDoubleClick

        If gridUsuarios.RowCount = 1 Then
            gridClienteVazia()
        Else
            If String.IsNullOrEmpty(gridUsuarios.CurrentRow.Cells("id").Value.ToString) Then
                linhaClienteInvalida()
            Else
                _IDUsuario = gridUsuarios.CurrentRow.Cells("id").Value.ToString()
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Me.fecharForm(True)
                Dim editarUsuario As New FormUsuario
                Dim usuario As New Usuario

                usuario = acessoUsuarioModel.getUsuarioById(_IDUsuario)
                editarUsuario.carregaDados(usuario)
                editarUsuario.ShowDialog()
            End If
        End If

    End Sub


    ' CANCELAR
    '==========================================================
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        fecharForm(True)
    End Sub

    '
    '
    '
    '###############################################################################################################
    '
    '
    '

    ' FUNCOES AUXILIARES
    '==========================================================

    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub




End Class