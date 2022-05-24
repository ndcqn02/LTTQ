Public Class QuanLyLichBay



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lv.Items.Clear()
        lv.Columns.Add("ID Chuyến bay", 40, HorizontalAlignment.Center)
        lv.Columns.Add("Chuyến bay", 100, HorizontalAlignment.Center)

        lv.Columns.Add("Nơi đến", 100, HorizontalAlignment.Center)
        lv.Columns.Add("Nơi đi", 100, HorizontalAlignment.Center)
        lv.Columns.Add("Thời gian bay", 100, HorizontalAlignment.Center)
        lv.Columns.Add("Thời gian đến", 100, HorizontalAlignment.Center)
        '  lv.Columns.Add("Số ghế", 100, HorizontalAlignment.Center)

        lv.View = View.Details
        Dim ptu As ListViewItem
        Dim i, cbay As Integer
        cbay = 9
        For i = 1 To 10
            ptu = New ListViewItem(i)
            If i Mod 2 <> 0 Then
                ptu.SubItems.Add(Microsoft.VisualBasic.Right("0" & cbay, 2) & "CB")
            Else
                ptu.SubItems.Add(Microsoft.VisualBasic.Right("0" & cbay, 2) & "CB")
                cbay = cbay + 1
            End If
            ptu.SubItems.Add(300 + i)
            ptu.SubItems.Add(2 + i)
            ptu.SubItems.Add("Đà Nẵng")
            ptu.SubItems.Add("Hà Nội")
            ptu.SubItems.Add("1/2/22")
            ptu.SubItems.Add("2/2/22")

            lv.Items.Add(ptu)
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class