Public Class HinhThang

    Private Sub btnCalculator_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculator.Click
        ketQua.Text() = DtHinhThang(txtDL.Text(), txtDB.Text(), txtCC.Text())

    End Sub

    Function DtHinhThang(dl As Double, db As Double, h As Double) As Double
        If db > dl Then
            MsgBox("Nhap du lieu sai")

        End If
        Return (0.5 * h * (dl + db))
    End Function

End Class