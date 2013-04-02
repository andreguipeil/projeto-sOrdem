Imports System.Windows.Forms

Module LimpaCampos

    Public  Sub Limpar(ByVal C As Control)

        For Each Controle As Control In C.Controls

            If Controle.HasChildren Then

                Limpar(Controle)

            End If

            If TypeOf Controle Is TextBox Then

                Dim tb As TextBox = CType(Controle, TextBox)

                tb.Clear()

            End If

            If TypeOf Controle Is ComboBox Then

                Dim cb = CType(Controle, ComboBox)

                cb.SelectedIndex = -1

            End If

            If TypeOf Controle Is MaskedTextBox Then

                Dim mtb = CType(Controle, MaskedTextBox)

                mtb.Clear()

            End If

            If TypeOf Controle Is DateTimePicker Then

                Dim dtp = CType(Controle, DateTimePicker)

                dtp.Value = Today

            End If

            If TypeOf Controle Is RadioButton Then

                Dim rb = CType(Controle, RadioButton)

                rb.Checked = False

            End If

            If TypeOf Controle Is CheckBox Then

                Dim ckb = CType(Controle, CheckBox)

                ckb.Checked = False

            End If

            ' If TypeOf Controle Is DataGridView Then

            '       Dim dgv = CType(Controle, DataGridView)

            '     dgv.Rows.Clear()

            '  End If

        Next

    End Sub
End Module
