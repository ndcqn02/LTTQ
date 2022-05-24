Public Class Bai_28

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        n_71.Text = ""
        dayso_14.Text = "Dãy số: "
        ket_qua_71.Text = ""
    End Sub
    Public Sub nhapmang(ByVal x%, ByRef arr%())
        dayso_14.Text = "Dãy số: "
        For i As Integer = 1 To x Step 1
            arr(i) = CInt(Math.Floor((x + x + 1) * Rnd())) - x
            If i <> 1 Then
                dayso_14.Text = dayso_14.Text + ", " + arr(i).ToString
            Else
                dayso_14.Text = dayso_14.Text + arr(i).ToString
            End If
        Next
    End Sub
    Public Function min%(ByVal n_14%, ByVal arr%())
        If n_14 = 1 Then
            Return arr(1)
        End If
        If arr(n_14) < min(n_14 - 1, arr) Then
            Return arr(n_14)
        End If
        Return min(n_14 - 1, arr)
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If n_71.Text <> "" Then
            Dim x% = CInt(n_71.Text)
            If x > 0 Then
                Dim arr%(x + 1)
                Call nhapmang(x, arr)
                ket_qua_71.Text = min(x, arr)
                MsgBox("Thành công")
            Else
                MsgBox("n không được nhỏ hơn 1")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub n_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        n_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "N/A"
    End Sub

End Class