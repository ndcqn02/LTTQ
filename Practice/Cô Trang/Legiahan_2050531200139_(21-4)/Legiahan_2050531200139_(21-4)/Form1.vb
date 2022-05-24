Public Class Form1

    Private Sub CheckedListBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckedListBox1.SelectedItem <> " " Then
            Dim st As String = ""
            For Each ptu As Object In CheckedListBox1.CheckedItems
                st = st + ptu.ToString() + vbNewLine
            Next
            Label2.Text = st
        End If
    End Sub


End Class

