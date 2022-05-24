Public Class Bai_6

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        cc_71.Text = ""
        cd_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Sub dt_hinhtamgiac(ByVal cc_14#, ByVal cd_14#, ByRef kq_14$)
        If cc_14 > 0 And cd_14 > 0 Then
            kq_14 = (0.5 * cc_14 * cd_14).ToString
            MsgBox("Thành công")
        Else
            kq_14 = "Error"
            MsgBox("Độ dài các cạnh không được nhỏ hơn 1")
        End If
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If cc_71.Text <> "" And cd_71.Text <> "" Then
            Dim x# = CDbl(cc_71.Text)
            Dim y# = CDbl(cd_71.Text)
            Dim kq_14$ = ""
            Call dt_hinhtamgiac(x, y, kq_14)
            ket_qua_71.Text = kq_14
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub cc_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cc_71.Text = ""
    End Sub
    Private Sub cd_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cd_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "N/A"
    End Sub
End Class