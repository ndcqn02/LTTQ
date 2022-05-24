Public Class Form1
    Private Sub txtGiaTri1_TextChanged(sender As Object, e As EventArgs) Handles txtGiaTri1.TextChanged

    End Sub

    Private Sub btnThucHien_Click(sender As Object, e As EventArgs) Handles btnThucHien.Click
        'Dim n As Integer = CInt(Me.txtGiaTri1.Text.Trim)
        'Dim m As Integer = CInt(Me.txtGiaTri2.Text.Trim)

        If Me.txtGiaTri1.Text = "" Or Me.txtGiaTri2.Text = "" Or Me.txtGiaTri3.Text = "" Then
            MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!! ")
            Exit Sub
        End If

        Dim n As Double = Double.Parse(txtGiaTri1.Text)
        Dim m As Double = Double.Parse(txtGiaTri2.Text)
        Dim q As Double = Double.Parse(txtGiaTri3.Text)

        If RbtAdd.Checked = True Then
            LbResult.Text = "Kết Quả : " & n + m
        End If
        If RbtSub.Checked = True Then
            LbResult.Text = "Kết Quả : " & n - m
        End If
        If RbtMulti.Checked = True Then
            LbResult.Text = "Kết Quả : " & n * m
        End If
        If RbtDevice.Checked = True Then
            LbResult.Text = "Kết Quả : " & n / m
        End If

        If RbtDiv.Checked = True Then
            LbResult.Text = "Kết Quả : " & n \ m
        End If
        If RbtMod.Checked = True Then
            LbResult.Text = "Kết Quả : " & n Mod m
        End If
        If RbtPower.Checked = True Then
            LbResult.Text = "Kết Quả : " & n ^ m
        End If


        If RbtRect.Checked = True Then
            LbArea.Text = "Area : " & n * m
        End If
        If RbtSquare.Checked = True Then
            LbArea.Text = "Area : " & n * n
        End If

        Dim p As Double = (n + m + q) / 2
        If RbtTrigle.Checked = True Then
            LbArea.Text = "Area : " & Math.Sqrt((p * (p - n) * (p - m) * (p - q)))
        End If
    End Sub


End Class
