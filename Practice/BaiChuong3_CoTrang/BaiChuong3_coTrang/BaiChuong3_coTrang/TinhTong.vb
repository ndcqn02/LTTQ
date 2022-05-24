Public Class TinhTong

    Private Sub calculator_Click(sender As System.Object, e As System.EventArgs) Handles calculator.Click
        If txtn.Text = "" Then
            MsgBox("Nhập lại dữ liệu")
            With txtn
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        Else
            ketqua.Text = TongDS(txtn.Text)
        End If

    End Sub

    Function TongDS(n As Integer) As Integer
        Dim s As Integer
        s = 0
        If n < 0 Then
            MsgBox("Nhap du lieu sai")

        End If
        For i = 1 To n
            s += i
        Next
        Return s
    End Function


End Class