﻿Public Class Bai_37

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        a_71.Text = ""
        b_71.Text = ""
        ket_qua_71.Text = "Bội chung nhỏ nhất của 2 số"
    End Sub
    Public Function UCLN%(ByVal a_14%, ByVal b_14%)
        Dim r_14% = 0
        While b_14 <> 0
            r_14% = a_14 Mod b_14
            a_14 = b_14
            b_14 = r_14
        End While
        Return a_14
    End Function
    Public Function BCNN#(ByVal a_14%, ByVal b_14%)
        Return CDbl((a_14 / UCLN(a_14, b_14))) * b_14
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If a_71.Text <> "" And b_71.Text <> "" Then
            Dim x% = CInt(a_71.Text)
            Dim y% = CInt(b_71.Text)
            If x > 0 And y > 0 Then
                ket_qua_71.Text = "Bội chung nhỏ nhất của " + a_71.Text + " và " + b_71.Text + " là " + BCNN(x, y).ToString
            Else
                MsgBox("n phải lớn hơn 0")
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
End Class