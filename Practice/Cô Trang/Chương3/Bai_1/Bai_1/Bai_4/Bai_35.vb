Public Class Bai_35

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        n_71.Text = ""
        ket_qua_71.Text = "Tổng các chữ số của n"
    End Sub
    Public Function tgn%(ByVal n_14%)
        Dim s_14% = 0
        While n_14 <> 0
            s_14 += (n_14 Mod 10)
            n_14 = (n_14 - (n_14 Mod 10)) / 10
        End While
        Return s_14
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If n_71.Text <> "" Then
            Dim x% = CInt(n_71.Text)
            If x > 0 Then
                ket_qua_71.Text = "Tổng các chữ số của " + n_71.Text + " là " + tgn(x).ToString
            Else
                MsgBox("n phải lớn hơn 0")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub n_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        n_71.Text = ""
    End Sub

End Class