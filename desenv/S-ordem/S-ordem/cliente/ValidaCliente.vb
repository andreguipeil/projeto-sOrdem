Module ValidaCliente

    Public Function validaCamposCliente(ByVal nome, ByVal rg)

        If String.IsNullOrEmpty(nome) = True Then
            MsgBox("Nome não informado.", MsgBoxStyle.Exclamation)
            Return True
        End If

        'If String.IsNullOrEmpty(rg) = True Then
        'MsgBox("RG não informado.", MsgBoxStyle.Exclamation)
        'Return True
        'End If

        Return False
    End Function

    Public Function successCliente(ByVal flag)
        If flag = True Then
            MsgBox("Registro gravado com sucesso!", MsgBoxStyle.Information)
        End If

        Return flag
    End Function

    Public Function deleteClienteSuccess(ByVal flag)
        If flag = True Then
            MsgBox("Registro deletado com Sucesso!", MsgBoxStyle.Information)
        End If

        Return flag
    End Function

    Public Sub gridClienteVazia()
        MsgBox("Não há registros na tabela.", MsgBoxStyle.Exclamation)
    End Sub

    Public Sub linhaClienteInvalida()
        MsgBox("Linha Inválida.", MsgBoxStyle.Exclamation)
    End Sub

    Public Function confirmaClienteExclusao(ByVal nome As String) As Integer
        Dim resposta As Integer = 0
        resposta = (MsgBox("Deseja realmente excluir Sr(a). " & nome & "? ", MsgBoxStyle.YesNo))

        Return resposta
    End Function

End Module
