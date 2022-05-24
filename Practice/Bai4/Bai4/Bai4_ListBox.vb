Public Class ListBox

    Private Sub btnMoveOver_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveOver.Click
        Dim monhoc = (From i In ListBox1.SelectedItems).ToArray()
        For Each ptu In monhoc
            ListBox2.Items.Add(ptu)
            ListBox1.Items.Remove(ptu)
        Next
    End Sub



    Private Sub btnDoubleSwitching_Click(sender As System.Object, e As System.EventArgs) Handles btnDoubleSwitching.Click
        Dim monhoc = (From i In ListBox2.SelectedItems).ToArray()
        For Each ptu In monhoc
            ListBox1.Items.Add(ptu)
            ListBox2.Items.Remove(ptu)
        Next
    End Sub


    Private Sub btnMoveOverAll_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveOverAll.Click
        For i = 0 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items(i))
        Next
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnDoubleSwitchingALL_Click(sender As System.Object, e As System.EventArgs) Handles btnDoubleSwitchingALL.Click
        For i = 0 To ListBox2.Items.Count - 1
            ListBox1.Items.Add(ListBox2.Items(i))
        Next
        ListBox2.Items.Clear()
    End Sub


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        ListBox1.Items.Add(TextBox1.Text().ToString())
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim monhoc = (From i In ListBox1.SelectedItems).ToArray()
        For Each ptu In monhoc
            ListBox1.Items.Remove(ptu)
        Next

        Dim danhsach = (From i In ListBox2.SelectedItems).ToArray()
        For Each ptu In danhsach
            ListBox2.Items.Remove(ptu)
        Next
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        TextBox1.Text() = ""
    End Sub


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Bai4_Combobox_ListView.Show()

    End Sub
End Class
