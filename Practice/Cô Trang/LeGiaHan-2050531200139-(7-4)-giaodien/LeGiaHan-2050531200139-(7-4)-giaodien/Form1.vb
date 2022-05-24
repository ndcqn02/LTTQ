Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox4.Text = CInt(TextBox1.Text) + CInt(TextBox2.Text) + CInt(TextBox3.Text)
        End If
        If RadioButton2.Checked = True Then
            TextBox4.Text = CInt(TextBox1.Text) - CInt(TextBox2.Text) - CInt(TextBox3.Text)
        End If
        If RadioButton3.Checked = True Then
            TextBox4.Text = CInt(TextBox1.Text) * CInt(TextBox2.Text) * CInt(TextBox3.Text)
        End If
        If RadioButton4.Checked = True Then
            TextBox4.Text = CInt(TextBox1.Text) / CInt(TextBox2.Text) / CInt(TextBox3.Text)
        End If
        If RadioButton5.Checked = True Then
            TextBox4.Text = CInt(TextBox1.Text) Mod CInt(TextBox2.Text)
        End If
        If RadioButton6.Checked = True Then
            TextBox4.Text = Math.Pow(CInt(TextBox1.Text), CInt(TextBox2.Text))
        End If
        If RadioButton7.Checked = True Then
            TextBox4.Text = CInt(TextBox1.Text) \ CInt(TextBox2.Text)
        End If



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton8.Checked = True Then
            TextBox4.Text = CInt(TextBox1.Text) * CInt(TextBox2.Text)
        End If
        If RadioButton9.Checked = True Then
            TextBox4.Text = CInt(TextBox1.Text) * CInt(TextBox2.Text)
        End If
        If RadioButton10.Checked = True Then
            TextBox4.Text = 2 * 3.14 * CInt(TextBox1.Text)

        End If
        If RadioButton11.Checked = True Then
            Dim p As Double
            p = (CInt(TextBox1.Text) + CInt(TextBox2.Text) + CInt(TextBox3.Text)) / 2
            TextBox4.Text = Math.Sqrt(p * (p - CInt(TextBox1.Text)) * (p - CInt(TextBox2.Text)) * (p - CInt(TextBox3.Text)))
        End If

    End Sub
End Class
