Public Class Bai_46

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        thapphan_71.Text = ""
        ket_qua_71.Text = "=> Thập lục phân:"
    End Sub
    Public Sub thapluc(ByVal s_14%)
        Dim i% = 0
        Dim tg$ = ""
        ket_qua_71.Text = "=> Thập lục phân: "
        While s_14 > 0
            Select Case s_14 Mod 16
                Case 10
                    tg += "A "
                Case 11
                    tg += "B "
                Case 12
                    tg += "C "
                Case 13
                    tg += "D "
                Case 14
                    tg += "E "
                Case 15
                    tg += "F "
                Case Else
                    tg += (s_14 Mod 16).ToString + " "
            End Select
            s_14 = (s_14 - (s_14 Mod 16)) / 16
        End While
        For j As Integer = Len(tg) - 1 To 0 Step -1
            ket_qua_71.Text += tg(j)
        Next
        ket_qua_71.ForeColor = Color.Green
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If thapphan_71.Text <> "" Then
            Dim so% = CInt(thapphan_71.Text)
            If so > 0 Then
                Call thapluc(so)
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Private Sub thapphan_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        thapphan_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "=> Thập lục phân:"
    End Sub
End Class