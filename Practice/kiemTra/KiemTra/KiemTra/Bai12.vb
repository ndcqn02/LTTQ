Public Class Bai12
    Public Function tong%(ByVal n%)
        If n = 1 Then
            Return 1
        End If
        If n Mod 2 = 0 Then
            Return tong(n - 1) - n
        End If
        Return n + tong(n - 1)
    End Function

    Private Sub btnThucHien_Click(sender As System.Object, e As System.EventArgs) Handles btnThucHien.Click
        If txt1.Text <> "" Then
            Dim x% = CInt(txt1.Text)
            If x > 0 Then
                ketqua.Text = tong(x)
                MsgBox("Thành công")
            Else
                MsgBox("n không được nhỏ hơn 1")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Private Sub n_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt1.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ketqua.Text = "N/A"
    End Sub



    Private Sub btnLamMoi_Click(sender As System.Object, e As System.EventArgs) Handles btnLamMoi.Click
        txt1.Text = ""
        ketqua.Text = ""
    End Sub
End Class