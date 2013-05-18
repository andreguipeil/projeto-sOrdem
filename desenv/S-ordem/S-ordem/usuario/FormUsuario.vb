Public Class FormUsuario
    Dim maskaras As New Maskaras


    '
    ' INIT
    '============================================================================================
    Public Sub FormUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(txtUsuarioId.Text) Then
            txtUsuarioId.Text = "-1"
        End If

        If txtUsuarioId.Text = "-1" Then
            btnDeletarUsuario.Enabled = False
        End If

    End Sub

    ' RG
    '-----------------------
    Private Sub txtUsuarioRg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuarioRg.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    ' TELEFONE
    '-----------------------
    Private Sub mskUsuarioTelefone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskUsuarioTelefone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back And Not Convert.ToInt32(e.KeyChar) = Keys.Delete Then
            e.Handled = True
        End If
    End Sub

    Private Sub mskUsuarioTelefone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskUsuarioTelefone.GotFocus
        Me.mskUsuarioTelefone.UseSystemPasswordChar = False
        Me.mskUsuarioTelefone.Mask = "####-####"
        Me.mskUsuarioTelefone.Focus()
    End Sub

    ' DDD
    '-----------------------
    Private Sub mskUsuarioDdd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskUsuarioDdd.GotFocus
        Me.mskUsuarioDdd.UseSystemPasswordChar = False
        Me.mskUsuarioDdd.Mask = "(##)"
        Me.mskUsuarioDdd.Focus()

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


    '  SALVAR
    '==========================================================
    Private Sub btnSalvarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarUsuario.Click

        Try
            If mskUsuarioSenha.Text = mskUsuarioSenha2.Text Then
                Dim usuarioDdd As String = maskaras.retiraMaskara(mskUsuarioDdd.Text)
                Dim usuarioTelefone As String = maskaras.retiraMaskara(mskUsuarioTelefone.Text)
                Dim usuario As New Usuario
                Dim callBack As Boolean
                Dim acessoModelUsuario As New usuarioModel
                Dim data As DateTime = DateTime.Now
                Dim dt_cadastro As String

                dt_cadastro = FormatDateTime(data, DateFormat.ShortDate)        ' tratamento da data    
                dt_cadastro = maskaras.retiraMaskaraData(dt_cadastro)


                usuario.id = txtUsuarioId.Text
                usuario.nome = txtUsuarioNome.Text
                usuario.rg = txtUsuarioRg.Text
                usuario.email = txtUsuarioEmail.Text
                usuario.ddd = usuarioDdd
                usuario.telefone = usuarioTelefone
                usuario.username = txtUsuarioUsername.Text
                usuario.senha = mskUsuarioSenha.Text
                usuario.dt_cadastro = dt_cadastro
                usuario.pessoa_id = acessoModelUsuario.getUsuarioById(txtUsuarioId.Text).pessoa_id
                If chkAdministrador.Checked = 0 Then
                    usuario.flag_adm = 0
                Else
                    usuario.flag_adm = 1
                End If

                If usuario.id = -1 Then
                    If validaCamposUsuario(usuario.id, txtUsuarioNome.Text, txtUsuarioRg.Text, txtUsuarioUsername.Text, mskUsuarioSenha.Text) = False Then
                        callBack = acessoModelUsuario.inserirUsuario(usuario)
                        If callBack = True Then
                            successUsuario(callBack)
                        End If
                        fecharForm(True)
                    End If
                Else
                    If validaCamposUsuario(usuario.id, txtUsuarioNome.Text, txtUsuarioRg.Text, txtUsuarioUsername.Text, mskUsuarioSenha.Text) = False Then
                        callBack = acessoModelUsuario.alterarUsuario(usuario)
                        If callBack = True Then
                            successUsuario(callBack)
                        End If
                        fecharForm(True)
                    End If
                End If
            Else
                MsgBox("Erro: As senhas não correspondem.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' DELETAR
    '==========================================================
    Private Sub btnDeletarUsuario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeletarUsuario.Click
        Dim acessoUsuarioModel As New usuarioModel()
        Dim id As Integer
        Dim resposta As Integer = 0
        Dim flag As Boolean

        resposta = confirmaUsuarioExclusao(txtUsuarioUsername.Text)

        If resposta = 6 Then
            id = CInt(Me.txtUsuarioId.Text)                                 ' transforma o id em int
            flag = acessoUsuarioModel.excluirUsuario(id)                    ' executa o delete retorna uma flag 
            fecharForm(deleteUsuarioSuccess(flag))                          ' flag apresenta uma msg box e depois fecha o formulario
        End If
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



    ' esta funcao carrega os dados do cliente no formulario 
    '=================================================================
    Public Sub carregaDados(ByVal usuario As Usuario)

        Me.txtUsuarioId.Text = usuario.id
        Me.txtUsuarioNome.Text = usuario.nome
        Me.txtUsuarioRg.Text = usuario.rg
        Me.mskUsuarioTelefone.Text = usuario.telefone
        Me.mskUsuarioDdd.Text = usuario.ddd
        Me.txtUsuarioEmail.Text = usuario.email
        Me.txtUsuarioUsername.Text = usuario.username
        Me.mskUsuarioSenha.Text = usuario.senha
        Me.mskUsuarioSenha2.Text = usuario.senha
        If usuario.flag_adm = 1 Then
            Me.chkAdministrador.Checked = 1
        Else
            Me.chkAdministrador.Checked = 0
        End If

    End Sub


    ' fecha formulario
    '=================================================================
    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub

End Class