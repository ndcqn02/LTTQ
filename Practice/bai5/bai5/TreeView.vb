Public Class TreeView



    Private Sub TreeView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TV.Nodes.Clear()


     
        ''TV.ImageList = Me.anh

        TV.ImageIndex = 1
        TV.SelectedImageIndex = 0
        TV.Nodes.Add("Khoa Điện")
        TV.Nodes(0).Nodes.Add("Bộ Môn Công Nghệ Thông Tin")
        TV.Nodes(0).Nodes.Add("Bô Môn Điện Kỹ thuật")
        TV.Nodes(0).Nodes.Add("Bô Môn Điện tử viễn thông")
        TV.Nodes(0).Nodes(0).Nodes.Add("Lớp 07T1")
        TV.Nodes(0).Nodes(0).Nodes.Add("Lớp 07T2")
        TV.Nodes.Add("Khoa Cơ")
        TV.Nodes.Add("Khoa Xây dựng")
        TV.Nodes.Add("Khoa Hóa")
        lv1.Visible = False
    End Sub

    Private Sub TV_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV.AfterSelect
        If e.Node.Text = "Lớp 07T1" Then
            lv1.Items.Clear()
            lv1.Columns.Add("Họ và tên", 300, HorizontalAlignment.Center)
            lv1.View = View.Details
            Dim ptu As ListViewItem
            ptu = New ListViewItem("Hoàng Ngọc Khánh Quỳnh")
            lv1.Items.Add(ptu)
            ptu = New ListViewItem("Hoàng Ngọc Thịnh")
            lv1.Items.Add(ptu)
            lv1.Visible = True
        Else
            If e.Node.Text = "Lớp 07T2" Then
                lv1.Items.Clear()
                lv1.Columns.Add("Họ và tên", 300, HorizontalAlignment.Center)
                lv1.View = View.Details
                Dim ptu As ListViewItem
                ptu = New ListViewItem("Nguyễn Đức Cường")
                lv1.Items.Add(ptu)
                ptu = New ListViewItem("Trần Ngọc Thịnh")
                lv1.Items.Add(ptu)
                lv1.Visible = True
            Else
            End If
        End If


    End Sub


    Private Sub btnChuyen_Click(sender As System.Object, e As System.EventArgs) Handles btnChuyen.Click
        TreeViewAdd.Show()

    End Sub
End Class