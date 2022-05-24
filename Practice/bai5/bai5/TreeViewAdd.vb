Public Class TreeViewAdd


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
        TV.Nodes(0).Nodes(0).Nodes.Add("Lớp 08T1")
        TV.Nodes(0).Nodes(0).Nodes.Add("Lớp 08T2")
        TV.Nodes.Add("Khoa Cơ")
        TV.Nodes(1).Nodes.Add("Bộ Môn Cơ khí chế tạo")
        TV.Nodes(1).Nodes.Add("Bô Môn Nhiệt Lạnh")
        TV.Nodes.Add("Khoa Xây dựng")
        TV.Nodes.Add("Khoa Hóa")

    End Sub

    Private Sub TV_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TV.AfterSelect

    End Sub

    Private Sub btnThem_Click(sender As System.Object, e As System.EventArgs) Handles btnThem.Click
        Dim nodeObj As New TreeNode
        nodeObj.Text = txt1.Text()
        nodeObj.ForeColor = Color.BlueViolet
        TV.SelectedNode.Nodes.Add(nodeObj)
    End Sub

 
    Private Sub btnXoa_Click(sender As System.Object, e As System.EventArgs) Handles btnXoa.Click
        Dim nodeObj As New TreeNode
        TV.SelectedNode.Remove()
    End Sub

    Private Sub btnCapNhat_Click(sender As System.Object, e As System.EventArgs)
        Dim nodeObj As New TreeNode


        nodeObj.Text = txt1.Text()
        ' TV.SelectedNode.Nodes.Add(nodeObj)
        '  TV.SelectedNode.Remove()

        Dim MyNode() As TreeNode
        MyNode = TV.Nodes.Find(TV.SelectedNode.Text(), True)
        ' MyNode(0).Nodes.Add(txt1.Text())
        TV.SelectedNode.Nodes.Add(nodeObj)

    End Sub
End Class