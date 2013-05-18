Imports System.Security.Cryptography
Imports System.Text

Public Class Criptografia
    Dim myKey As String
    Dim des As New TripleDESCryptoServiceProvider()
    Dim hashmd5 As New MD5CryptoServiceProvider()

    Public Sub New()
        myKey = "PeilSoft2013" 'Chave
    End Sub

    Public Function CriptaTexto(ByVal texto As String, ByVal Operacao As Boolean) As String
        If Operacao Then
            CriptaTexto = Cifra(texto)
        Else
            CriptaTexto = DeCifra(texto)
        End If
    End Function

    Private Function DeCifra(ByVal texto As String) As String
        des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(myKey))
        des.Mode = CipherMode.ECB
        Dim desdencrypt As ICryptoTransform = des.CreateDecryptor()
        Dim buff() As Byte = Convert.FromBase64String(texto)
        DeCifra = ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))
    End Function

    Private Function Cifra(ByVal texto As String) As String
        des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(myKey))
        des.Mode = CipherMode.ECB
        Dim desdencrypt As ICryptoTransform = des.CreateEncryptor()
        Dim MyASCIIEncoding = New ASCIIEncoding()
        Dim buff() As Byte = ASCIIEncoding.ASCII.GetBytes(texto)
        Cifra = Convert.ToBase64String(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))
    End Function

End Class
