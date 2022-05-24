Public Class Bai5_ListView


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnThem.Click
        Dim ptu As ListViewItem
        ptu = New ListViewItem(txtSTT.Text)
        ptu.SubItems.Add(txtName.Text)
        ptu.SubItems.Add(txtMSV.Text)
        ptu.SubItems.Add(txtQueQuan.Text)
        lv.Items.Add(ptu)
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lv.Items.Clear()
        lv.Columns.Add("Stt", 40, HorizontalAlignment.Center)
        lv.Columns.Add("Họ tên", 100, HorizontalAlignment.Center)
        lv.Columns.Add("MSV", 100, HorizontalAlignment.Center)
        lv.Columns.Add("Quê quán", 100, HorizontalAlignment.Center)
        lv.View = View.Details
        Dim ptu As ListViewItem
        Dim i, lop As Integer
        lop = 9
        For i = 1 To 10
            ptu = New ListViewItem(i)

            ptu.SubItems.Add("Nguyễn Văn " & i)
            ptu.SubItems.Add("2442" & i)
            ptu.SubItems.Add("Quảng Nam")

            lv.Items.Add(ptu)
        Next
    End Sub

    Private Sub btnXoa_Click(sender As System.Object, e As System.EventArgs) Handles btnXoa.Click
        For Each i As ListViewItem In lv.SelectedItems
            lv.Items.Remove(i)
        Next
    End Sub




    Private Sub btnChuyen_Click(sender As System.Object, e As System.EventArgs) Handles btnChuyen.Click
        TreeView.Show()

    End Sub
End Class

