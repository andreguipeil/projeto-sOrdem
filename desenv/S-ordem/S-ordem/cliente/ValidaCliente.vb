Module ValidaCliente

    Public Function validaCamposCliente(ByVal nome, ByVal rg)
        Dim flag As Boolean

        If String.IsNullOrEmpty(nome) = True Then
            MsgBox("Nome não informado.", MsgBoxStyle.Information)
            flag = True
        End If

        If String.IsNullOrEmpty(rg) = True Then
            MsgBox("RG não informado.", MsgBoxStyle.Information)
            flag = True
        End If

        Return flag
    End Function

    Public Function successCliente(ByVal flag)
        If flag = True Then
            MsgBox("Registro gravado com sucesso!", MsgBoxStyle.OkOnly)
        End If

        Return flag
    End Function

End Module
