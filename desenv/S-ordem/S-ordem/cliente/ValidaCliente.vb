Module ValidaCliente

    Public Function ValidaAdd_Cliente(ByVal nome, ByVal rg) As Boolean
        Dim flag As Boolean

        If String.IsNullOrEmpty(nome) = True Then
            MsgBox("Nome não informado.", MsgBoxStyle.Information)
            flag = True
        End If

        If String.IsNullOrEmpty(rg) = True Then
            MsgBox("RG não informado.", MsgBoxStyle.Information)
            flag = True
        End If

        ValidaAdd_Cliente = flag
    End Function

    Public Function SuccessAddCliente(ByVal flag)
        If flag = True Then
            MsgBox("Registro gravado com sucesso!", MsgBoxStyle.OkOnly)
        End If

        SuccessAddCliente = flag
    End Function

End Module
