Public Class Principal

    '
    'Ações do Botão Adicionar Cliente
    '====================================


    ' abre um formulario para adicionar cliente
    '------------------------------------------------------------------------
    Private Sub AddCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCliente.Click
        
        FormCliente.ShowDialog()

    End Sub

    '####

    '
    'Ações do Botão Consulta Cliente
    '====================================

    ' abre uma grid com filtro com os clientes da empresa
    '-------------------------------------------------------------------------
    Private Sub ConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaClientes.Click

        FormConsultaCliente.ShowDialog()

    End Sub

    '####

    '
    'Ações do Botão Adicionar Ordem de Serviço
    '====================================

    ' adiciona ordem de servico
    '-------------------------------------------------------------------------
    Private Sub AddOrdemDeServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOrdemDeServico.Click

    End Sub

    '####

    '
    'Ações do Botão Consulta Ordens de Serviço
    '====================================

    ' abre uma grid com filtro com as ordens da empresa
    '-------------------------------------------------------------------------
    Private Sub ConsultaOrdensDeServicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaOrdensDeServicos.Click

    End Sub

    '####

    '
    'Ações do Botão Sair
    '====================================
    ' sai do programa
    '-------------------------------------------------------------------------
    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        Close()
    End Sub

    '####

End Class
