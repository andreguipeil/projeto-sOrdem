Public Class Maskaras

    ' recebe uma string e retorna a string sem maskara
    '=============================================================
    Public Function retiraMaskara(ByVal valor As String) As String

        Dim aux As String = valor

        If aux.Contains("-") Then
            aux = Replace(aux, "-", "")
        End If

        If aux.Contains(",") Then
            aux = Replace(aux, ",", "")
        End If

        If aux.Contains(".") Then
            valor = Replace(valor, ".", "")
        End If

        If aux.Contains("(") Then
            aux = Replace(aux, "(", "")
        End If

        If aux.Contains(")") Then
            aux = Replace(aux, ")", "")
        End If

        If aux.Contains("/") Then
            aux = Replace(aux, "/", "")
        End If

        If aux.Contains(" ") Then
            aux = Replace(aux, " ", "")
        End If

        retiraMaskara = aux
    End Function

    Public Function retiraMaskaraData(ByVal data As String)
        Dim aux As String = data

        aux = Replace(aux, "/", "-")

        retiraMaskaraData = aux
    End Function


End Class
