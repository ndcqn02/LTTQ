Public Class Bai_32

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        n_71.Text = ""
        ket_qua_71.Text = "Kiểm tra n có phải số nguyên tố hay không?"
    End Sub
    Public Function snt$(ByVal n_14%)
        If n_14 = 1 Then
            Return "Số 1 không phải là số nguyên tố"
        End If
        For i As Integer = 2 To Math.Sqrt(n_14) Step 1
            If (n_14 Mod i = 0) Then
                Return "Số " + n_14.ToString + " không phải là số nguyên tố"
            End If
        Next
        Return "Số " + n_14.ToString + " là số nguyên tố"
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If n_71.Text <> "" Then
            Dim x% = CInt(n_71.Text)
            If x > 0 Then
                ket_qua_71.Text = snt(x)
                MsgBox("Thành công")
            Else
                MsgBox("n phải lớn hơn 0")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub n_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        n_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "Kiểm tra n có phải số nguyên tố hay không?"
    End Sub
End Class