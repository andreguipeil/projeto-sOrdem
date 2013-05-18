Module ValidaOrdem

    Public Function validaCamposOrdem(ByVal clienteNome, ByVal modelo, ByVal marcaId, ByVal ordemEstadoId, ByVal defeito, ByVal dt_entrada)

        If String.IsNullOrEmpty(clienteNome) = True Then
            MsgBox("Nome não informado.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If marcaId = -1 Then
            MsgBox("Marca não informada.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If String.IsNullOrEmpty(modelo) = True Then
            MsgBox("Modelo não informado.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If ordemEstadoId = -1 Then
            MsgBox("Estado da ordem não informado.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If String.IsNullOrEmpty(defeito) = True Then
            MsgBox("Defeito não informado.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If String.IsNullOrEmpty(dt_entrada) = True Then
            MsgBox("Data de entrada não informada.", MsgBoxStyle.Exclamation)
            Return True
        End If

        If IsDate(dt_entrada) = False Then
            MsgBox("Erro... Insira uma data válida.", MsgBoxStyle.Exclamation)
            Return True
        End If

        Return False
    End Function

    Public Function successOrdem(ByVal flag)
        If flag = True Then
            MsgBox("Registro gravado com sucesso!", MsgBoxStyle.Information)
            Return flag
        Else
            Return False
        End If
    End Function

    Public Function validaData(ByVal data)
        Dim isValidDate As Boolean = IsDate(data)
        If isValidDate = False Then
            MsgBox("Erro... Insira uma data válida.", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Public Function deleteOrdemSuccess(ByVal flag)
        If flag = True Then
            MsgBox("Registro deletado com Sucesso!", MsgBoxStyle.Information)
        End If

        Return flag
    End Function

    Public Sub gridOrdemVazia()
        MsgBox("Não há registros na tabela.", MsgBoxStyle.Exclamation)
    End Sub

    Public Sub linhaOrdemInvalida()
        MsgBox("Linha Inválida.", MsgBoxStyle.Exclamation)
    End Sub

    Public Function confirmaOrdemExclusao(ByVal nrOrdem As Integer) As Integer
        Dim resposta = 0
        resposta = (MsgBox("Deseja realmente excluir a Ordem de Nr." & nrOrdem & "? ", MsgBoxStyle.YesNo))

        Return resposta
    End Function

    Public Function validaDataXP(ByVal data As String) As String
        Dim dataFeia As String = data
        Dim dataBonitinha As String = data

        If (dataFeia.Length() <> 10) Then
            Dim dia As String
            Dim mes As String
            Dim ano As String
            ' Separa string baseado em /
            Dim dt As String() = dataFeia.Split(New Char() {"/"c})
            dia = dt(0)
            mes = dt(1)
            ano = dt(2)
            If (dia.Length = 1) Then
                dia = "0" & dia
            End If
            If (mes.Length = 1) Then
                mes = "0" & mes
            End If
            dataBonitinha = dia & "/" & mes & "/" & ano
        End If
        Return dataBonitinha
    End Function

End Module
