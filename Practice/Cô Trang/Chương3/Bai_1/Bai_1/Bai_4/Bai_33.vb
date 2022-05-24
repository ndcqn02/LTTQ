Public Class Bai_33

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        n_71.Text = ""
        ket_qua_71.Text = "Kiểm tra n có phải số Fibonaci hay không?"
    End Sub
    Public Function snt$(ByVal n_14%)
        Dim f1% = 1, f2% = 1, t% = f1, s% = f2, tt% = 0
        While s < n_14
            tt = t + s
            t = s
            s = tt
        End While
        If s = n_14 Then
            Return "Số " + n_14.ToString + " là số Fibonaci"
        Else
            Return "Số " + n_14.ToString + " không phải là số Fibonaci"
        End If
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If n_71.Text <> "" Then
            Dim x% = CInt(n_71.Text)
            If x > 0 Then
                ket_qua_71.Text = snt(x)
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
        ket_qua_71.Text = "Kiểm tra n có phải số Fibonaci hay không?"
    End Sub
End Class