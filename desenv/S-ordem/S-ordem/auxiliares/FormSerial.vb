Public Class FormSerial

    Public keygen As String

    Private Sub btnInserirSerial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirSerial.Click
        Dim acessoLicenca As New ValidaLicencaModel
        Dim flag As Boolean
        If txtSerial.Text = keygen Then
            flag = acessoLicenca.setSerial(txtSerial.Text)
            If flag = True Then
                DialogResult = 1
            Else
                DialogResult = 2
            End If
        Else
            MsgBox("Serial Inválido, Contate-nos: andreguipeil@gmail.com")
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class