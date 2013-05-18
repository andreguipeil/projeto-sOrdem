Imports System.Management
Imports System.Security.Cryptography
Imports System.Data.OleDb

Public Class FormLogin
    Public sessao As New UsuarioSessao

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim autenticacao As Boolean
        autenticacao = sessao.autenticacao(txtUsuario.Text, mskSenha.Text)
        If autenticacao = True Then
            Me.DialogResult = 1
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Dim resposta As Integer
        resposta = MsgBox("Deseja realmente sair do S-Ordem?", MsgBoxStyle.YesNo)

        If resposta = 6 Then
            Me.fecharForm(True)
        End If
    End Sub

    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim _criptografia As New Criptografia()
            Dim hashcrip As String
            Dim hash As String = ""
            Dim acessoLicencaModel As New ValidaLicencaModel()
            Dim licencaPC As String

            ' THIS
            ' ----------------------
            Dim oMotherB As Object = Nothing
            Dim oWMG As Object = GetObject("WinMgmts:")
            oMotherB = oWMG.InstancesOf("Win32_BaseBoard")
            For Each obj As Object In oMotherB
                hash += obj.SerialNumber
            Next
            '------------------------
            hashcrip = _criptografia.CriptaTexto(hash, True)

            licencaPC = acessoLicencaModel.getSerial(hashcrip)

            If licencaPC = False Then
                MsgBox("Há um problema com a Licença do programa." + vbCrLf + "Entre em Contato" + vbCrLf + "Email: andreguipeil@gmail.com" + vbCrLf + "Ligue: (53) 9167-3037", MsgBoxStyle.Information)
                Me.DialogResult = 2
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

End Class