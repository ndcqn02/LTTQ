Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Them.Click
        ComboBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Chon.Click
        ListBox1.Items.Add(ComboBox1.SelectedItem)
        Label6.Text = ListBox1.Items.Count
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Huy.Click
        ListBox1.Items.Clear()
    End Sub


End Class
