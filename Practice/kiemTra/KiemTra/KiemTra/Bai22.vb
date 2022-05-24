Public Class Bai22


    Public Sub nhapmang(ByVal x%, ByRef arr%())
        dayso.Text = "S="
        For i As Integer = 1 To x Step 1
            arr(i) = CInt(Math.Floor((x - 1 + 1) * Rnd())) + 1
            If i <> 1 Then
                dayso.Text = dayso.Text + "+" + arr(i).ToString
            Else
                dayso.Text = dayso.Text + arr(i).ToString
            End If
        Next
    End Sub
    Public Function tong%(ByVal n%, ByVal arr%())
        If n = 1 Then
            If arr(n) Mod 2 = 0 Then
                Return arr(1)
            Else
                Return 0
            End If
        End If

        If arr(n) Mod 2 = 0 Then
            Return arr(n) + tong(n - 1, arr)
        End If

        Return tong(n - 1, arr)
    End Function

    Private Sub btnThucHien_Click(sender As System.Object, e As System.EventArgs) Handles btnThucHien.Click
        If txt1.Text <> "" Then
            Dim x% = CInt(txt1.Text)
            If x > 0 Then
                Dim arr%(x + 1)
                Call nhapmang(x, arr)
                ketqua.Text = tong(x, arr)
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
        dayso.Text = "S= ..."
        ketqua.Text = ""
    End Sub
End Class