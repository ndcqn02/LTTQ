Public Class Bai_12

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        n_71.Text = ""
        gt_14.Text = "n! ="
        ket_qua_71.Text = ""
    End Sub
    Public Function giaithua%(ByVal n_14%)
        If n_14 = 1 Then
            Return 1
        End If
        Return n_14 * giaithua(n_14 - 1)
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If n_71.Text <> "" Then
            Dim x% = CInt(n_71.Text)
            If x > 0 Then
                ket_qua_71.Text = giaithua(x)
                gt_14.Text = n_71.Text + "! ="
                MsgBox("Thành công")
            Else
                MsgBox("n không được nhỏ hơn 1")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub n_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        n_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "N/A"
    End Sub

End Class