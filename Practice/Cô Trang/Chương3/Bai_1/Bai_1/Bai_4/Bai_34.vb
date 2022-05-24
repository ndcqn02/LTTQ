Public Class Bai_34

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        n_71.Text = ""
        ket_qua_71.Text = "Kiểm tra n có phải số Hoàn Hảo hay không?"
    End Sub
    Public Function shh$(ByVal n_14%)
        Dim s% = 0
        For i As Integer = 1 To n_14 - 1 Step 1
            If n_14 Mod i = 0 Then
                s += i
            End If
        Next
        If s = n_14 Then
            Return "Số " + n_14.ToString + " là số hoàn hảo"
        Else
            Return "Số " + n_14.ToString + " không phải là số hoàn hảo"
        End If
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If n_71.Text <> "" Then
            Dim x% = CInt(n_71.Text)
            If x > 0 Then
                ket_qua_71.Text = shh(x)
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
        ket_qua_71.Text = "Kiểm tra n có phải số Hoàn Hoản hay không?"
    End Sub
End Class