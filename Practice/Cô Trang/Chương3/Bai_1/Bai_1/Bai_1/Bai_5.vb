Public Class Bai_5

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        cc_71.Text = ""
        cd_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Function dt_hinhtamgiac#(ByVal cc_14#, ByVal cd_14#)
        If cc_14 > 0 And cd_14 > 0 Then
            Return 0.5 * cc_14 * cd_14
        Else
            Return -1
        End If
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If cc_71.Text <> "" And cd_71.Text <> "" Then
            Dim x# = CDbl(cc_71.Text)
            Dim y# = CDbl(cd_71.Text)
            If dt_hinhtamgiac(x, y) <> -1 Then
                ket_qua_71.Text = dt_hinhtamgiac(x, y)
                MsgBox("Thành công")
            Else
                MsgBox("Độ dài các cạnh không được nhỏ hơn 1")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Friend Shared Sub Show()
        Throw New System.NotImplementedException()
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