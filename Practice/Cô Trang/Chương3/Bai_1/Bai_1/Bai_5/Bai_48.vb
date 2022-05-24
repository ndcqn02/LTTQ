Public Class Bai_48

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        chuoi_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Sub daoso(ByVal s_14$, ByRef kq_14$())
        For i As Integer = 0 To (Len(s_14) / 2) Step 1
            Dim temp$ = s_14(i)
            kq_14(i) = s_14(Len(s_14) - i - 1)
            kq_14(Len(s_14) - i - 1) = temp
        Next
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If chuoi_71.Text <> "" Then
            Dim kq_14$(Len(chuoi_71.Text))
            Call daoso(chuoi_71.Text, kq_14)
            ket_qua_71.Text = ""
            For i As Integer = 0 To Len(chuoi_71.Text) - 1 Step 1
                ket_qua_71.Text += kq_14(i)
            Next
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