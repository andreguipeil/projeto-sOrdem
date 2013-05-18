Module ValidaUsuario

    Public Function validaCamposUsuario(ByVal id, ByVal nome, ByVal rg, ByVal username, ByVal senha)
        Dim programaUsuarioModel As New usuarioModel

        If String.IsNullOrEmpty(nome) = True Then
            MsgBox("Nome não informado.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If String.IsNullOrEmpty(rg) = True Then
            MsgBox("RG não informado.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If String.IsNullOrEmpty(username) = True Then
            MsgBox("Username não informado.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If (programaUsuarioModel.validaUsername(username) = True) And (id = -1) Then
            MsgBox("Este nome de usuário já existe.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If String.IsNullOrEmpty(senha) = True Then
            MsgBox("Senha não informada.", MsgBoxStyle.Exclamation)
            Return True
        End If

        Return False
    End Function


    Public Function successUsuario(ByVal flag)
        If flag = True Then
            MsgBox("Registro gravado com sucesso!", MsgBoxStyle.Information)
        End If

        Return flag
    End Function

    Public Function deleteUsuarioSuccess(ByVal flag)
        If flag = True Then
            MsgBox("Registro deletado com Sucesso!", MsgBoxStyle.Information)
        End If

        Return flag
    End Function

    Public Sub gridUsuarioVazia()
        MsgBox("Não há registros na tabela.", MsgBoxStyle.Exclamation)
    End Sub

    Public Sub linhaUsuarioInvalida()
        MsgBox("Linha Inválida.", MsgBoxStyle.Exclamation)
    End Sub

    Public Function confirmaUsuarioExclusao(ByVal username As String) As Integer
        Dim resposta As Integer = 0
        resposta = (MsgBox("Deseja realmente excluir usuario: " & username & "? ", MsgBoxStyle.YesNo))

        Return resposta
    End Function

End Module
