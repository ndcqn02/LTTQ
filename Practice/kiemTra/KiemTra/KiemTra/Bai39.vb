Public Class Bai39



    Public Function UCLN%(ByVal a%, ByVal b%)
        Dim r% = 0
        While b <> 0
            r% = a Mod b
            a = b
            b = r
        End While
        Return a
    End Function

    Private Sub btnThucHien_Click(sender As System.Object, e As System.EventArgs) Handles btnThucHien.Click
        If txt1.Text <> "" And txt2.Text <> "" And txt3.Text <> "" Then
            Dim x% = CInt(txt1.Text)
            Dim y% = CInt(txt2.Text)
            Dim z% = CInt(txt3.Text)
            If x > 0 And y > 0 And z > 0 Then
                Dim tg = UCLN(x, y)
                KetQua.Text = "Ước chung lớn nhất của " + txt1.Text + ", " + txt2.Text + ", " + txt3.Text + " là " + UCLN(tg, z).ToString
            Else
                MsgBox("n phải lớn hơn 0")
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub
    Private Sub a_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt1.Text = ""
    End Sub
    Private Sub b_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt2.Text = ""
    End Sub
    Private Sub c_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt3.Text = ""
    End Sub

    Private Sub btnLamMoi_Click(sender As System.Object, e As System.EventArgs) Handles btnLamMoi.Click
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        ketqua.Text = "Ước chung lớn nhất của 3 số"
    End Sub


End Class