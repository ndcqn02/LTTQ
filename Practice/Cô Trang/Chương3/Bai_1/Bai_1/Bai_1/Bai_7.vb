Public Class Bai_7

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        a_71.Text = ""
        b_71.Text = ""
        c_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Function dt_hinhtamgiac#(ByVal a_14#, ByVal b_14#, ByVal c_14#)
        If a_14 > 0 And b_14 > 0 And c_14 > 0 Then
            Dim p$ = (a_14 + b_14 + c_14) / 2
            Return Math.Sqrt(p * (p - a_14) * (p - b_14) * (p - c_14))
        Else
            Return -1
        End If
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If a_71.Text <> "" And b_71.Text <> "" And c_71.Text <> "" Then
            Dim x# = CDbl(a_71.Text)
            Dim y# = CDbl(b_71.Text)
            Dim z# = CDbl(c_71.Text)
            If dt_hinhtamgiac(x, y, z) <> -1 Then
                ket_qua_71.Text = dt_hinhtamgiac(x, y, z)
                MsgBox("Thành công")
            Else
                MsgBox("Độ dài các cạnh không được nhỏ hơn hoặc bằng 0")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub a_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        a_71.Text = ""
    End Sub
    Private Sub b_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        b_71.Text = ""
    End Sub
    Private Sub c_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        c_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "N/A"
    End Sub

End Class