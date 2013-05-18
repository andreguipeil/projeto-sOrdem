Public Class FormMarca


    ' INIT
    '=================================================================
    Private Sub FormMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(txtMarcaId.Text) Then
            txtMarcaId.Text = "-1"
        End If

        If FormPrincipal.usuarioSession.getUsuarioFlagAdm() <> 1 Then
            btnDeletarMarca.Enabled = False
        End If

        If txtMarcaId.Text = "-1" Then
            btnDeletarMarca.Enabled = False
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
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarMarca.Click
        Dim marca As New Marca
        Dim acessoModel As New MarcaModel
        Dim callBack As Boolean

        marca.id = CInt(txtMarcaId.Text)
        marca.nome = txtMarca.Text

        If marca.id = -1 Then
            If validaCampoMarca(txtMarca.Text) = False Then
                callBack = acessoModel.inserirMarca(marca)                          ' insere
                If callBack = True Then                                                 ' verifica se inseriu no banco
                    successMarca(callBack)
                End If
                fecharForm(True)
            End If
        Else
            If validaCampoMarca(txtMarca.Text) = False Then
                callBack = acessoModel.alterarMarca(marca)                          ' altera clientes
                If callBack = True Then                                                 ' verifica se inseriu no banco
                    successMarca(callBack)
                End If
                fecharForm(True)
            End If
        End If

    End Sub

    ' CANCELAR
    '==========================================================
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarMarca.Click
        Limpar(Me)
        fecharForm(True)
    End Sub

    ' DELETAR
    '==========================================================
    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletarMarca.Click
        Dim acessoModel As New MarcaModel()
        Dim id As Integer
        Dim resposta As Integer = 0
        Dim flag As Boolean

        resposta = confirmaMarcaExclusao(txtMarca.Text)

        If resposta = 6 Then
            id = CInt(Me.txtMarcaId.Text)                         ' transforma o id em int
            flag = acessoModel.excluirMarca(id)                   ' executa o delete retorna uma flag 
            fecharForm(deleteMarcaSuccess(flag))                  ' flag apresenta uma msg box e depois fecha o formulario
        End If
    End Sub


    '
    '
    '
    '###############################################################################################################
    '
    '
    '
    '

    ' FUNCOES AUXILIARES
    '=================================================================


    ' esta funcao carrega os dados do cliente no formulario 
    '=================================================================
    Public Sub carregaDados(ByVal marca As Marca)

        Me.txtMarcaId.Text = marca.id.ToString()
        Me.txtMarca.Text = marca.nome.ToString()

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