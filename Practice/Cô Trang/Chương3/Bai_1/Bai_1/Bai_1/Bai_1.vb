Public Class Bai_1

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        dl_71.Text = ""
        db_71.Text = ""
        cc_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Function dt_hinhthang#(ByVal dl_14#, ByVal db_14#, ByVal cc_14#)
        If dl_14 > 0 And db_14 > 0 And cc_14 > 0 Then
            Return ((dl_14 + db_14) * cc_14) / 2.0
        Else
            Return -1
        End If
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If dl_71.Text <> "" And db_71.Text <> "" And cc_71.Text <> "" Then
            Dim a# = CDbl(dl_71.Text)
            Dim b# = CDbl(db_71.Text)
            Dim c# = CDbl(cc_71.Text)
            If dt_hinhthang(a, b, c) <> -1 Then
                ket_qua_71.Text = dt_hinhthang(a, b, c)
                MsgBox("Thành công")
            Else
                MsgBox("Độ dài các cạnh không được nhỏ hơn 1")
            End If
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
        ket_qua_71.Text = "N/A"
    End Sub
End Class