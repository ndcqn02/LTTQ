Public Class Bai_10

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        bk_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Sub cv_hinhtron(ByVal bk_14#, ByRef kq_14$)
        If bk_14 > 0 Then
            kq_14 = (2 * 3.14 * bk_14).ToString
            MsgBox("Thành công")
        Else
            kq_14 = "Lỗi"
            MsgBox("Bán kính không được nhỏ hơn 1")
        End If
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If bk_71.Text <> "" Then
            Dim x# = CDbl(bk_71.Text)
            Dim kq_14$ = ""
            Call cv_hinhtron(x, kq_14)
            ket_qua_71.Text = kq_14
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub bk_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        bk_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "N/A"
    End Sub
End Class