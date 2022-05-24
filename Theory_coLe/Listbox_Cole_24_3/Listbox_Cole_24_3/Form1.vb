Public Class Form1


    Private Sub cuong_11_btnSwitchOver_Click(sender As Object, e As EventArgs) Handles cuong_11_btnSwitchOver.Click
        Dim mang = (From i In cuong_11_ListBoxLeft.SelectedItems).ToArray()
        For Each ptu In mang
            cuong_11_ListBoxRight.Items.Add(ptu)
            cuong_11_ListBoxLeft.Items.Remove(ptu)
        Next
    End Sub

    Private Sub cuong_11_btnOverAll_Click(sender As Object, e As EventArgs) Handles cuong_11_btnOverAll.Click
        For i% = 0 To cuong_11_ListBoxLeft.Items.Count - 1
            cuong_11_ListBoxRight.Items.Add(cuong_11_ListBoxLeft.Items(i))
        Next
        cuong_11_ListBoxLeft.Items.Clear()
    End Sub

    Private Sub cuong_11_btnSwitchBack_Click(sender As Object, e As EventArgs) Handles cuong_11_btnSwitchBack.Click
        Dim mang = (From i In cuong_11_ListBoxRight.SelectedItems).ToArray()
        For Each ptu In mang
            cuong_11_ListBoxLeft.Items.Add(ptu)
            cuong_11_ListBoxRight.Items.Remove(ptu)
        Next
    End Sub

    Private Sub cuong_11btnBackAll_Click(sender As Object, e As EventArgs) Handles cuong_11btnBackAll.Click
        For i% = 0 To cuong_11_ListBoxRight.Items.Count - 1
            cuong_11_ListBoxLeft.Items.Add(cuong_11_ListBoxRight.Items(i))
        Next
        cuong_11_ListBoxRight.Items.Clear()
    End Sub

End Class
