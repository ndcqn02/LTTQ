Public Class Bai_40

    Private Sub lam_moi_14_Click(sender As Object, e As EventArgs) Handles lam_moi_71.Click
        t1_71.Text = ""
        m1_71.Text = ""
        t2_71.Text = ""
        m2_71.Text = ""
        ket_qua_71.Text = ""
    End Sub
    Public Function UCLN%(ByVal a_14%, ByVal b_14%)
        Dim r_14% = 0
        While b_14 <> 0
            r_14% = a_14 Mod b_14
            a_14 = b_14
            b_14 = r_14
        End While
        Return a_14
    End Function
    Public Sub tru2ps(ByVal t1%, ByVal t2%, ByVal m1%, ByVal m2%, ByRef t_14%, ByRef m_14%)
        t_14 = t1 * m2 - t2 * m1
        m_14 = m1 * m2
        If t_14 <> 0 And m_14 <> 0 Then
            Dim ucln_14 = UCLN(t_14, m_14)
            t_14 /= ucln_14
            m_14 /= ucln_14
        End If
    End Sub

    Private Sub thuc_hien_14_Click(sender As Object, e As EventArgs) Handles thuc_hien_71.Click
        If t1_71.Text <> "" And t2_71.Text <> "" And m1_71.Text <> "" And m2_71.Text <> "" Then
            Dim t1 = CInt(t1_71.Text)
            Dim t2 = CInt(t2_71.Text)
            Dim m1 = CInt(m1_71.Text)
            Dim m2 = CInt(m2_71.Text)
            Dim t_14% = 0, m_14% = 0
            Call tru2ps(t1, t2, m1, m2, t_14, m_14)
            If m_14 = 1 Then
                ket_qua_71.Text = t_14
            Else
                If (t_14 = 0 And m_14 = 0) Or (t_14 = 0 And m_14 <> 0) Then
                    ket_qua_71.Text = 0
                Else
                    ket_qua_71.Text = t_14.ToString + "/" + m_14.ToString
                End If
            End If
        Else
            MsgBox("Không được để trống")
        End If
    End Sub

    Private Sub t1_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        t1_71.Text = ""
    End Sub
    Private Sub m1_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        m1_71.Text = ""
    End Sub
    Private Sub t2_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        t2_71.Text = ""
    End Sub
    Private Sub m2_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        m2_71.Text = ""
    End Sub
    Private Sub ket_qua_14_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ket_qua_71.Text = ""
    End Sub
End Class