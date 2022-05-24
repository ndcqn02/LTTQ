Public Class Bai_30

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        n_71.Text = ""
        dayso_14.Text = "Dãy số: "
        ket_qua_71.Text = ""
    End Sub
    Public Sub nhapmang(ByVal x%, ByRef arr%())
        dayso_14.Text = "Dãy số: "
        For i As Integer = 1 To x Step 1
            arr(i) = CInt(Math.Floor((x + x + 1) * Rnd())) - x
            If i <> 1 Then
                dayso_14.Text = dayso_14.Text + ", " + arr(i).ToString
            Else
                dayso_14.Text = dayso_14.Text + arr(i).ToString
            End If
        Next
    End Sub
    Public Function chanle%(ByVal n_14%, ByVal arr%())
        If n_14 = 0 Then
            Return 0
        End If
        If arr(n_14) Mod 2 <> 0 Then
            Return 1
        End If
        Return chanle(n_14 - 1, arr)
    End Function
    Public Sub min(ByVal n_14%, ByVal arr%(), ByRef soMin%)
        For i As Integer = 1 To n_14 Step 1
            If arr(i) Mod 2 <> 0 Then
                soMin = arr(i)
                For j As Integer = i To n_14 Step 1
                    If arr(j) < soMin And arr(j) Mod 2 <> 0 Then
                        soMin = arr(j)
                    End If
                Next
                Exit For
            End If
        Next
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If n_71.Text <> "" Then
            Dim x% = CInt(n_71.Text)
            If x > 0 Then
                Dim arr%(x + 1)
                Dim soMin%
                Call nhapmang(x, arr)
                If chanle(x, arr) = 1 Then
                    Call min(x, arr, soMin)
                    ket_qua_71.Text = soMin
                    MsgBox("Thành công")
                Else
                    ket_qua_71.Text = ""
                    MsgBox("Dãy không có số lẻ")
                End If
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