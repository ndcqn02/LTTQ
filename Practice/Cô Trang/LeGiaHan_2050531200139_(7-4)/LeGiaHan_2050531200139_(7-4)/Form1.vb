Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://daotao.ute.udn.vn/")
    End Sub

    Private Sub RichTextBox1_linkClicked(sender As Object, e As EventArgs) Handles RichTextBox1.LinkClicked
        System.Diagnostics.Process.Start("http://daotao.ute.udn.vn/")
    End Sub
End Class
