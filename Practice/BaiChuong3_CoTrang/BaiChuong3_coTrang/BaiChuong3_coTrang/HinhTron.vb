Public Class HinhTron

  4

    Private Sub Calculator_Click(sender As System.Object, e As System.EventArgs) Handles Calculator.Click
        If txtR.Text = "" Then
            MessageBox.Show("Please enter a Salesperson's name", "No entry",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            With txtR
                .Focus()
                .SelectAll()
            End With
            Exit Sub                    ' tell it to skip the rest
        End If
        ketQua.Text = DtHinhTRon(txtR.Text)
    End Sub


    Function DtHinhTRon(r As Double) As Double
        If r <= 0 Then
            MsgBox("Nhap du lieu sai")

        End If
        Return (Math.PI * r * r)
    End Function

End Class