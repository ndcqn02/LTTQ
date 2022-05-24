Public Class Bai_50

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        chuoi_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Function dem%(ByVal s_14$)
        Dim d% = 0
        If s_14(0) <> " " Then
            d += 1
        End If
        For i As Integer = 0 To Len(s_14) - 2
            If s_14(i) = " " And s_14(i + 1) <> " " Then
                d += 1
            End If
        Next
        Return d
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If chuoi_71.Text <> "" Then
            Dim s_14$ = chuoi_71.Text
            ket_qua_71.Text = "Có " + dem(s_14).ToString + " từ"
            ket_qua_71.ForeColor = Color.Green
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Private Sub chuoi_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        chuoi_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = ""
    End Sub
End Class