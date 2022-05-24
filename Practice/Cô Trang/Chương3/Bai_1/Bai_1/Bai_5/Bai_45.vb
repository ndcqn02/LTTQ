Public Class Bai_45

    Private Sub lam_moi_71_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        nhiphan_71.Text = ""
        ket_qua_71.Text = "=> Thập phân:"
    End Sub
    Public Sub thapphan(ByVal s_14%)
        Dim i% = 0, p% = 0, kq% = 0
        ket_qua_71.Text = "=> Thập phân: "
        While s_14 > 0
            kq += (s_14 Mod 10) * 8 ^ p
            p += 1
            s_14 = (s_14 - (s_14 Mod 10)) / 10
        End While
        ket_qua_71.Text += kq.ToString
        ket_qua_71.ForeColor = Color.Green
    End Sub

    Private Sub thuc_hien_71_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If nhiphan_71.Text <> "" Then
            Dim so% = CInt(nhiphan_71.Text)
            If so > 0 Then
                Call thapphan(so)
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Private Sub nhiphan_71_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nhiphan_71.Text = ""
    End Sub
    Private Sub ket_qua_71_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "=> Thập phân:"
    End Sub
End Class