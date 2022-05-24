Public Class Form2
    Private Sub listview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        ListView1.Columns.Add("STT", 40, HorizontalAlignment.Center)
        ListView1.Columns.Add("Họ tên", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Mã sinh viên", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Quê quán", 100, HorizontalAlignment.Center)
        ListView1.View = View.Details
        Dim ptu As ListViewItem
        Dim i As Integer
        For i = 1 To 1
            ptu = New ListViewItem(i)
            ptu.SubItems.Add("Nguyễn văn A")
            ptu.SubItems.Add("2050531200999")
            ptu.SubItems.Add("Quảng Nam")
            ListView1.Items.Add(ptu)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class