Imports System.Data.SqlClient
Imports System.Configuration


Public Class login


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtusername.Text.Length <= 0 Then
            MessageBox.Show("Please enter Username!")
        ElseIf txtpassword.Text.Length <= 0 Then
            MessageBox.Show("Please enter Password!")
        End If
        Dim Con = New SqlConnection("Server=LAPTOP-RLOU7QH7\SQLEXPRESS;User Id=sa;Password=123;Initial Catalog=QuanLyTuyenSinh")
        Dim cmd As SqlCommand = New SqlCommand("select * from users where CCCD ='" + txtusername.Text + "' and password='" + txtpassword.Text + "'  ", Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            ' MessageBox.Show("Đăng nhập thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
            Me.Hide()

        Else
            MessageBox.Show("Thấ bại rồi man ơi!")
        End If

    End Sub

End Class