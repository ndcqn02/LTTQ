Public Class Bai_44

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        thapphan_71.Text = ""
        ket_qua_71.Text = "=> Bát phân:"
    End Sub
    Public Sub nhiphan(ByVal s_14%)
        Dim i% = 0
        Dim tg$ = ""
        ket_qua_71.Text = "=> Bát phân: "
        While s_14 > 0
            tg += (s_14 Mod 8).ToString + " "
            s_14 = (s_14 - (s_14 Mod 8)) / 8
        End While
        For j As Integer = Len(tg) - 1 To 0 Step -1
            ket_qua_71.Text += tg(j)
        Next
        ket_qua_71.ForeColor = Color.Green
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If thapphan_71.Text <> "" Then
            Dim so% = CInt(thapphan_71.Text)
            If so > 0 Then
                Call nhiphan(so)
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Private Sub thapphan_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        thapphan_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "=> Bát phân:"
    End Sub
End Class