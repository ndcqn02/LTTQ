

Public Class CheckListBox

    Private Sub CheckedListBox1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i, lop As Integer
        lop = 17
        For i = 1 To 4
            CheckedListBox1.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T1")
            CheckedListBox1.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T2")
            CheckedListBox1.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T3")
            CheckedListBox1.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T4")
            CheckedListBox1.Items.Add(Microsoft.VisualBasic.Right("0" & lop, 2) & "T5")
            lop = lop + 1
        Next
    End Sub

    Private Sub btnchoice_Click(sender As System.Object, e As System.EventArgs) Handles btnchoice.Click
        If CheckedListBox1.SelectedItem <> " " Then
            Dim st As String = ""
            For Each ptu As Object In CheckedListBox1.CheckedItems
                st = st + ptu.ToString() + vbNewLine
            Next
            LabelShow.Text = st
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LabelShow_Click(sender As System.Object, e As System.EventArgs) Handles LabelShow.Click

    End Sub
End Class
