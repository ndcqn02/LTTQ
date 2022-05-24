Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DsUsers1.Clear()
        OleDbDataAdapter2.Fill(DsUsers1)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        BindingContext(DsUsers1, "Users").Position = BindingContext(DsUsers1, "Users").Position - 1
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        BindingContext(DsUsers1, "Users").Position = BindingContext(DsUsers1, "Users").Position + 1
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        BindingContext(DsUsers1, "Users").Position = BindingContext(DsUsers1, "Users").Count - 1
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        BindingContext(DsUsers1, "Users").Position = 0
    End Sub
End Class
