Public Class ComBox_ListView




    Private Sub btnXoa_Click(sender As System.Object, e As System.EventArgs) Handles btnXoa.Click
        Dim index As Integer = ComboBoxDSMonHoc.SelectedIndex
        ComboBoxDSMonHoc.Items.RemoveAt(index)
    End Sub

    Private Sub btnThem_Click(sender As System.Object, e As System.EventArgs) Handles btnThem.Click
        ComboBoxDSMonHoc.Items.Add(txtMonhoc.Text)


    End Sub

    Private Sub btnChon_Click(sender As System.Object, e As System.EventArgs) Handles btnChon.Click
        ListBoxDSDagky.Items.Add(ComboBoxDSMonHoc.SelectedItem)
        LabelResult.Text = ListBoxDSDagky.Items.Count.ToString()


    End Sub

    Private Sub btnHuy_Click(sender As System.Object, e As System.EventArgs) Handles btnHuy.Click
        ListBoxDSDagky.Items.Clear()
    End Sub

    Private Sub ComboBoxDSMonHoc_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxDSMonHoc.SelectedIndexChanged
        ComboBoxDSMonHoc.DisplayMember = ComboBoxDSMonHoc.SelectedItem
    End Sub

    Private Sub ComBox_ListView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
