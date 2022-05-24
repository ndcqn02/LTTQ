Public Class Bai_2

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        dl_71.Text = ""
        db_71.Text = ""
        cc_71.Text = ""
        ket_qua_14.Text = ""
    End Sub
    Public Sub dt_hinhthang(ByVal dl_14#, ByVal db_14#, ByVal cc_14#, ByRef kq_14$)
        If dl_14 > 0 And db_14 > 0 And cc_14 > 0 Then
            kq_14 = (((dl_14 + db_14) * cc_14) / 2.0).ToString
        Else
            kq_14 = "Error"
            MsgBox("Độ dài các cạnh không được nhỏ hơn 1")
        End If
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If dl_71.Text <> "" And db_71.Text <> "" And cc_71.Text <> "" Then
            Dim a_14# = CDbl(dl_71.Text)
            Dim b_14# = CDbl(db_71.Text)
            Dim c_14# = CDbl(cc_71.Text)
            Dim kq_14$ = ket_qua_14.Text
            Call dt_hinhthang(a_14, b_14, c_14, kq_14)
            ket_qua_14.Text = kq_14
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Private Sub dl_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dl_71.Text = ""
    End Sub
    Private Sub db_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        db_71.Text = ""
    End Sub
    Private Sub cc_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cc_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_14.Text = "N/A"
    End Sub
End Class