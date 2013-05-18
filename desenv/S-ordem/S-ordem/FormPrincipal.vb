Imports System.Management
Imports System.Security.Cryptography
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class FormPrincipal
    ' Public usuarioSessaoId As Integer
    Public usuarioSession As UsuarioSessao
    Dim _criptografia As New Criptografia()                       'Classe de criptografia de dados
    Public caminhoBanco As String
    ' ATALHOS
    '=================================================================
    Private Sub FormPrincipal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.L Then
            Dim lixao As New FormLixao
            lixao.ShowDialog()
        End If

        Select Case (e.KeyCode)

            Case Keys.F1
                AddCliente_Click(sender, e)
            Case Keys.F2
                ConsultaClientes_Click(sender, e)
            Case Keys.F3
                AddOrdemDeServico_Click(sender, e)
            Case Keys.F4
                ConsultaOrdensDeServicos_Click(sender, e)
            Case Keys.F5
                Sair_Click(sender, e)
        End Select

    End Sub

    ' INIT
    '=================================================================
    Private Sub FormPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim login As New FormLogin()
        Dim licenca As New ValidaLicencaModel()
        Dim cont As Integer
        Dim serialMB As String = ""
        Dim keygen As String = ""
        Dim formSerial As New FormSerial
        Dim controle As Boolean

        ' THIS
        ' ----------------------
        Dim oMotherB As Object = Nothing
        Dim oWMG As Object = GetObject("WinMgmts:")
        oMotherB = oWMG.InstancesOf("Win32_BaseBoard")
        For Each obj As Object In oMotherB
            serialMB += obj.SerialNumber
        Next
        '------------------------

        keygen = _criptografia.CriptaTexto(serialMB, True)
        cont = licenca.contadorSerial()

        If cont = 0 Then
            formSerial.keygen = keygen
            formSerial.ShowDialog()
            If formSerial.DialogResult = 2 Then
                Me.fecharForm(True)
            End If
            If formSerial.DialogResult = 1 Then
                controle = True
            End If
            'End If
        Else
            'If cont = 1 Then

            If licenca.getSerial(keygen) = True Then
                controle = True
            Else
                formSerial.keygen = keygen
                formSerial.ShowDialog()
                If formSerial.DialogResult = 2 Then
                    Me.fecharForm(True)
                End If
                If formSerial.DialogResult = 1 Then
                    controle = True
                End If
            End If
        End If

        If controle = True Then
            login.ShowDialog()
            If login.DialogResult = 1 Then
                Me.Show()
                Me.usuarioSession = login.sessao
                If (Me.usuarioSession.getUsuarioFlagAdm() <> 1) Then
                    btnAddUsuario.Enabled = False
                    btnConsultaUsuario.Enabled = False
                End If
                If login.DialogResult = 2 Then
                    fecharForm(True)
                End If
            Else
                If login.DialogResult = 2 Then
                    fecharForm(True)
                Else
                    MsgBox("Seu Serial é inválido.")

                    licenca.deleteSerial()
                    Dim serial As New FormSerial
                    serial.keygen = keygen
                    serial.ShowDialog()
                End If
            End If
        End If

    End Sub

    '
    'Ações do Botão Adicionar Cliente
    '====================================


    ' abre um formulario para adicionar cliente
    '------------------------------------------------------------------------
    Private Sub AddCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCliente.Click
        Dim addCliente As New FormCliente
        addCliente.ShowDialog()

    End Sub

    '####

    '
    'Ações do Botão Consulta Cliente
    '====================================

    ' abre uma grid com filtro com os clientes da empresa
    '-------------------------------------------------------------------------
    Private Sub ConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaClientes.Click
        Dim consultaCliente As New FormConsultaCliente
        consultaCliente.ShowDialog()

    End Sub

    '####

    '
    'Ações do Botão Adicionar Ordem de Serviço
    '====================================

    ' adiciona ordem de servico
    '-------------------------------------------------------------------------
    Private Sub AddOrdemDeServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOrdemDeServico.Click
        Dim ordem As New FormOrdem
        ordem.ShowDialog()

    End Sub

    '####

    '
    'Ações do Botão Consulta Ordens de Serviço
    '====================================

    ' abre uma grid com filtro com as ordens da empresa
    '-------------------------------------------------------------------------
    Private Sub ConsultaOrdensDeServicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaOrdensDeServicos.Click
        Dim consultaOrdem As New FormConsultaOrdem
        consultaOrdem.ShowDialog()

    End Sub

    '####


    '
    'Ações do Botão Adicionar Usuário
    '====================================

    ' abre o formulário para cadastrar usuario
    '-------------------------------------------------------------------------
    Private Sub btnAddUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUsuario.Click
        Dim cadastroUsuario As New FormUsuario
        cadastroUsuario.ShowDialog()

    End Sub

    '
    'Ações do Botão Consultar Usuario
    '====================================

    ' abre uma grid com os usuarios do sistema
    '-------------------------------------------------------------------------
    Private Sub btnConsultaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaUsuario.Click
        Dim consultaUsuario As New FormConsultaUsuario
        consultaUsuario.ShowDialog()

    End Sub


    '
    'Ações do Botão Sair
    '====================================
    ' sai do programa
    '-------------------------------------------------------------------------
    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        Dim resposta As Integer

        resposta = MsgBox("Deseja realmente sair do S-Ordem?", MsgBoxStyle.YesNo)
        If resposta = 6 Then
            fecharForm(True)
        End If

    End Sub

    '
    ' relatorio de clientes
    '====================================
    ' imprime o relatório de clientes
    '-------------------------------------------------------------------------
    Private Sub btnRelatorioClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorioClientes.Click
        Dim cliente As New Cliente
        Dim rptClientes As New RptClientes
        rptClientes.relatorioClientes(cliente)
    End Sub



    Private Sub btnRelatorioOrdens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorioOrdens.Click
        Dim ordem As New Ordem
        Dim rptOrdens As New RptOrdens

        rptOrdens.relatorioOrdens(ordem, "")

    End Sub

    ' #
    ' #
    ' #
    ' #

    ' CADASTROS AUXILIARES
    '=======================================================================

    Private Sub btnAddMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMarcas.Click
        Dim marca As New FormMarca
        marca.ShowDialog()

    End Sub

    Private Sub btnConsultaMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaMarcas.Click
        Dim consultaMarcas As New FormConsultaMarcas
        consultaMarcas.ShowDialog()

    End Sub

    Private Sub btnAddEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEstado.Click
        Dim estado As New FormEstado
        estado.ShowDialog()

    End Sub

    Private Sub btnConsultaEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaEstado.Click
        Dim consultaEstado As New FormConsultaEstado
        consultaEstado.ShowDialog()

    End Sub



    ' FUNCOES AUXILIARES
    '=======================================================================

    Private Sub fecharForm(ByVal flag)
        If flag = True Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub

End Class















