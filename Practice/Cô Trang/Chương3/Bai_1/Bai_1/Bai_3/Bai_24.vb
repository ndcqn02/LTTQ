Public Class Bai_24

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        n_71.Text = ""
        dayso_14.Text = "S= ..."
        ket_qua_71.Text = ""
    End Sub
    Public Sub nhapmang(ByVal x%, ByRef arr%())
        dayso_14.Text = "S="
        For i As Integer = 1 To x Step 1
            arr(i) = CInt(Math.Floor((x + x + 1) * Rnd())) - x
            If arr(i) >= 0 And i <> 1 Then
                dayso_14.Text = dayso_14.Text + "+" + arr(i).ToString
            Else
                dayso_14.Text = dayso_14.Text + arr(i).ToString
            End If
        Next
    End Sub
    Public Function tong%(ByVal n_14%, ByVal arr%())
        If n_14 = 1 Then
            If arr(n_14) < 0 Then
                Return arr(1)
            Else
                Return 0
            End If
        End If

        If arr(n_14) < 0 Then
            Return arr(n_14) + tong(n_14 - 1, arr)
        End If

        Return tong(n_14 - 1, arr)
    End Function

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If n_71.Text <> "" Then
            Dim x% = CInt(n_71.Text)
            If x > 0 Then
                Dim arr%(x + 1)
                Call nhapmang(x, arr)
                ket_qua_71.Text = tong(x, arr)
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