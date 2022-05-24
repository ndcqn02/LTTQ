Public Class Bai_41

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        chuoi_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Function dx%(ByVal s_14$)
        For i As Integer = 0 To Len(s_14) / 2 Step 1
            If s_14(i) <> s_14(Len(s_14) - i - 1) Then
                Return 0
            End If
        Next

        Return 1
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If chuoi_71.Text <> "" Then
            If dx(chuoi_71.Text) = 1 Then
                ket_qua_71.Text = "=> " + chuoi_71.Text + " là chuỗi đối xứng"
                ket_qua_71.ForeColor = Color.Green
            Else
                ket_qua_71.Text = "=> " + chuoi_71.Text + " không phải chuỗi đối xứng"
                ket_qua_71.ForeColor = Color.Red
            End If
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