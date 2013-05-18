Public Class FormEstado
    Dim usuarioSession As New UsuarioSessao

    ' INIT
    '=================================================================
    Private Sub FormMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(txtEstadoId.Text) Then
            txtEstadoId.Text = "-1"
        End If

        If txtEstadoId.Text = "-1" Or FormPrincipal.usuarioSession.getUsuarioFlagAdm() = 0 Then
            btnDeletarEstado.Enabled = False
        End If
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

    ' SALVAR
    '==========================================================
    Private Sub btnSalvarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarEstado.Click
        Dim estado As New Estado
        Dim acessoEstadoModel As New EstadoModel
        Dim callBack As Boolean

        estado.id = CInt(txtEstadoId.Text)
        estado.nome = txtEstado.Text

        If estado.id = -1 Then
            If validaCampoEstado(txtEstado.Text) = False Then
                callBack = acessoEstadoModel.inserirEstado(estado)                          ' insere
                If callBack = True Then                                                 ' verifica se inseriu no banco
                    successEstado(callBack)
                End If
                fecharForm(True)
            End If
        Else
            If validaCampoEstado(txtEstado.Text) = False Then
                callBack = acessoEstadoModel.alterarEstado(estado)                          ' altera clientes
                If callBack = True Then                                                 ' verifica se inseriu no banco
                    successEstado(callBack)
                End If
                fecharForm(True)
            End If
        End If
    End Sub

    ' CANCELAR
    '==========================================================
    Private Sub btnCancelarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEstado.Click
        Limpar(Me)
        fecharForm(True)
    End Sub

    ' DELETAR
    '==========================================================
    Private Sub btnDeletarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletarEstado.Click
        Dim acessoModel As New EstadoModel()
        Dim id As Integer
        Dim resposta As Integer = 0
        Dim flag As Boolean

        resposta = confirmaMarcaExclusao(txtEstado.Text)

        If resposta = 6 Then
            id = CInt(Me.txtEstadoId.Text)                         ' transforma o id em int
            flag = acessoModel.excluirEstado(id)                   ' executa o delete retorna uma flag 
            fecharForm(deleteMarcaSuccess(flag))                   ' flag apresenta uma msg box e depois fecha o formulario
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
    '=================================================================

    ' esta funcao carrega os dados do cliente no formulario 
    '=================================================================
    Public Sub carregaDados(ByVal estado As Estado)

        Me.txtEstadoId.Text = estado.id.ToString()
        Me.txtEstado.Text = estado.nome.ToString()

    End Sub

    'fecha o formulario do cliente
    '=====================================================================
    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub

End Class