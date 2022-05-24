Public Class Bai_3

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        bk_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Function dt_hinhtron#(ByVal bk_14#)
        If bk_14 > 0 Then
            Return 3.14 * bk_14 * bk_14
        Else
            Return -1
        End If
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If bk_71.Text <> "" Then
            Dim x# = CDbl(bk_71.Text)
            If dt_hinhtron(x) <> -1 Then
                ket_qua_71.Text = dt_hinhtron(x)
                MsgBox("Thành công")
            Else
                MsgBox("Bán kính không được nhỏ hơn 1")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub cc_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        bk_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "N/A"
    End Sub

End Class