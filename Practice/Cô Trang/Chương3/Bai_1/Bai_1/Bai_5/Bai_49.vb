Public Class Bai_49

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        chuoi_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Sub dx(ByRef s_14$, ByRef kq_14$())
        For i As Integer = 0 To Len(s_14) - 1 Step 1
            kq_14(i) = s_14(i)
        Next
        If kq_14(0) <> " " Then
            kq_14(0) = UCase(kq_14(0))
        End If
        For i As Integer = 0 To Len(s_14) - 2
            If kq_14(i) = " " And kq_14(i + 1) <> " " Then
                kq_14(i + 1) = UCase(kq_14(i + 1))
            End If
        Next
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If chuoi_71.Text <> "" Then
            Dim s_14$ = chuoi_71.Text
            Dim kq_14$(Len(chuoi_71.Text))
            Call dx(s_14, kq_14)
            ket_qua_71.Text = ""
            For i As Integer = 0 To Len(chuoi_71.Text)
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