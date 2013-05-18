Module validaMarca

    Public Function validaCampoMarca(ByVal nome)

        If String.IsNullOrEmpty(nome) = True Then
            MsgBox("Marca não informada.", MsgBoxStyle.Information)
            Return True
        End If

        Return False
    End Function

    Public Function successMarca(ByVal flag)
        If flag = True Then
            MsgBox("Registro gravado com sucesso!", MsgBoxStyle.OkOnly)
        End If

        Return flag
    End Function

    Public Function deleteMarcaSuccess(ByVal flag)
        If flag = True Then
            MsgBox("Registro deletado com Sucesso!", MsgBoxStyle.OkOnly)
        End If

        Return flag
    End Function

    Public Sub gridMarcaVazia()
        MsgBox("Não há registros na tabela.", MsgBoxStyle.Exclamation)
    End Sub

    Public Sub linhaMarcaInvalida()
        MsgBox("Linha Inválida.", MsgBoxStyle.Exclamation)
    End Sub

    Public Function confirmaMarcaExclusao(ByVal nome As String) As Integer
        Dim resposta As Integer = 0
        resposta = (MsgBox("Deseja realmente excluir a Marca: " & nome & "? ", MsgBoxStyle.YesNo))

        Return resposta
    End Function

End Module
