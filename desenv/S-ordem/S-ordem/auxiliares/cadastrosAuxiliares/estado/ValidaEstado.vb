Module ValidaEstado

    Public Function validaCampoEstado(ByVal nome)

        If String.IsNullOrEmpty(nome) = True Then
            MsgBox("Estado não informado.", MsgBoxStyle.Information)
            Return True
        End If

        Return False
    End Function

    Public Function successEstado(ByVal flag)
        If flag = True Then
            MsgBox("Registro gravado com sucesso!", MsgBoxStyle.OkOnly)
        End If

        Return flag
    End Function

    Public Function deleteEstadoSuccess(ByVal flag)
        If flag = True Then
            MsgBox("Registro deletado com Sucesso!", MsgBoxStyle.OkOnly)
        End If

        Return flag
    End Function

    Public Sub gridestadoVazia()
        MsgBox("Não há registros na tabela.", MsgBoxStyle.Exclamation)
    End Sub

    Public Sub linhaEstadoInvalida()
        MsgBox("Linha Inválida.", MsgBoxStyle.Exclamation)
    End Sub

    Public Function confirmaEstadoExclusao(ByVal nome As String) As Integer
        Dim resposta As Integer = 0
        resposta = (MsgBox("Deseja realmente excluir o estado: " & nome & "? ", MsgBoxStyle.YesNo))

        Return resposta
    End Function

End Module
