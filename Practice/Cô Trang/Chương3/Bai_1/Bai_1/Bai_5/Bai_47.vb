Public Class Bai_47

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        nhiphan_71.Text = ""
        ket_qua_71.Text = "=> Thập phân:"
    End Sub
    Public Sub thapphan(ByVal s_14$)
        Dim i% = 0, p% = 0, kq% = 0
        Dim arr$(Len(s_14))
        ket_qua_71.Text = "=> Thập phân: "
        For j As Integer = 0 To Len(s_14) - 1
            arr(j) = s_14(j)
        Next
        For j As Integer = 0 To Len(s_14) - 1
            Select Case arr(j)
                Case "A"
                    arr(j) = "10"
                Case "B"
                    arr(j) = "11"
                Case "C"
                    arr(j) = "12"
                Case "D"
                    arr(j) = "13"
                Case "E"
                    arr(j) = "14"
                Case "F"
                    arr(j) = "15"
            End Select
        Next
        For j As Integer = Len(s_14) - 1 To 0 Step -1
            kq += CInt(arr(j)) * 16 ^ p
            p += 1
        Next
        
        ket_qua_71.Text += kq.ToString
        ket_qua_71.ForeColor = Color.Green
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If nhiphan_71.Text <> "" Then
            Call thapphan(nhiphan_71.Text)
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Private Sub nhiphan_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nhiphan_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = "=> Thập phân:"
    End Sub
End Class