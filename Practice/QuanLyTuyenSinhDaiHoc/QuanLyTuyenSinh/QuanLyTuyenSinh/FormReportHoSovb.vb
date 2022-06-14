Imports System.Data.SqlClient
Public Class FormReportHoSovb
    Dim Con = New SqlConnection("Server=LAPTOP-RLOU7QH7\SQLEXPRESS;User Id=sa;Password=123;Initial Catalog=QuanLyTuyenSinh")
    Private Sub FormReportHoSovb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        loadReportTheoDS(DanhSachHoSo(), "H:\2_Sophomore\semester_221\LTTQ\Practice\QuanLyTuyenSinhDaiHoc\QuanLyTuyenSinh\QuanLyTuyenSinh\ReportHoSo.rdlc")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub loadReportTheoDS(ds As DataTable, link As String)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = link
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetHoSo", ds))
        End With
    End Sub
    Private Function DanhSachHoSo() As DataTable
        Con.Open()
        Dim query = "select * from HoSoSinhVien"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adapter.Fill(dt)
        Con.Close()
        Return dt
    End Function

    Private Function DanhSachDau() As DataTable
        Con.Open()
        Dim query = "select * from HoSoSinhVien, Nganh where Diem1 + Diem1 + Diem3 >= DiemChuan "
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adapter.Fill(dt)
        Con.Close()
        Return dt
    End Function


    Private Sub btnBackForm1_Click(sender As System.Object, e As System.EventArgs) Handles btnBackForm1.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class