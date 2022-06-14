Imports System.Data.SqlClient
Public Class FormThongke



    Dim Con = New SqlConnection("Server=LAPTOP-RLOU7QH7\SQLEXPRESS;User Id=sa;Password=123;Initial Catalog=QuanLyTuyenSinh")
    Dim queryHoSo = "select * from HoSoSinhVien"
    Dim queryNganh = "select * from Nganh"
    Private Function Display(query As String, ByVal csvDataSet As DataSet) As DataSet
        Con.open()
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        Con.close()
        Return ds
    End Function

    'CHUYỂN HƯỚNG PANEL'
    Private Sub PanelVeLaiWelCom_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelVeLaiWelCom.MouseClick
        PaneHoSo.Visible = False
        PanelNganh.Visible = False
        PanelTraCuuKQ.Visible = False
        PanelThongKe.Visible = False
        PanelWelCome.Visible = True
    End Sub

    Private Sub btnHoSoTuyenSinh_Click(sender As System.Object, e As System.EventArgs) Handles btnHoSoTuyenSinh.Click
        Dim ds As New DataSet
        DataGridViewHoSo.DataSource = Display(queryHoSo, ds).Tables(0)

        DataGridViewHoSo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        PaneHoSo.Visible = True
        PanelNganh.Visible = False
        PanelTraCuuKQ.Visible = False
        PanelThongKe.Visible = False
        PanelWelCome.Visible = False
    End Sub

    Private Sub btnDSNganh_Click(sender As System.Object, e As System.EventArgs) Handles btnDSNganh.Click
        Dim ds As New DataSet
        DataGridViewNganh.DataSource = Display(queryNganh, ds).Tables(0)
        PaneHoSo.Visible = False
        PanelNganh.Visible = True
        PanelTraCuuKQ.Visible = False
        PanelThongKe.Visible = False
        PanelWelCome.Visible = False
    End Sub

    Private Sub btnThongKe_Click(sender As System.Object, e As System.EventArgs) Handles btnThongKe.Click
        lbTilted.Text = "DANH SÁCH NHỮNG THÍ SINH  ĐẬU ĐẠI HỌC"
        Dim ds As New DataSet
        DataGridViewThongKe.DataSource = Display("select distinct * from HoSoSinhVien LEFT JOIN Nganh ON HoSoSinhVien.MaNganh  = Nganh.MaNganh where Diem1 + Diem1 + Diem3 >= DiemChuan", ds).Tables(0)
        PaneHoSo.Visible = False
        PanelNganh.Visible = False
        PanelTraCuuKQ.Visible = False
        PanelThongKe.Visible = True
        PanelWelCome.Visible = False
    End Sub

    Private Sub btnTraCuuKQ_Click(sender As System.Object, e As System.EventArgs) Handles btnTraCuuKQ.Click
        PaneHoSo.Visible = False
        PanelNganh.Visible = False
        PanelTraCuuKQ.Visible = True
        PanelThongKe.Visible = False
        PanelWelCome.Visible = False
    End Sub


    Private Sub load_cbx_MaNganh()
        Con.open()
        Dim cmd As New SqlCommand("select * from Nganh", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBox_MaNganh.DataSource = table
        ComboBox_MaNganh.DisplayMember = "MaNganh"
        ComboBox_MaNganh.ValueMember = "MaNganh"
        Con.Close()
    End Sub


    'CHỨC NĂNG PANEL WELCOM'

    Function CountTK(query As String, tenCot As String) As Integer
        Dim sl As Integer
        Con.open()
        Dim cmd As SqlCommand = New SqlCommand(query, Con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        Con.close()
        sl = dt.Rows(0).Item(tenCot)
        Return sl
    End Function

    Private Sub FormThongKe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_cbx_MaNganh()
        lbSLHoSoDK.Text = CountTK("select count (CCCD) as SoHSo from HoSoSinhVien ", "SoHSo")
        lbSlDauDH.Text = CountTK("select count(DISTINCT(CCCD )) as slDau from HoSoSinhVien LEFT JOIN Nganh ON HoSoSinhVien.MaNganh  = Nganh.MaNganh where Diem1 + Diem1 + Diem3 >= DiemChuan", "slDau")
        lbSlNganh.Text = CountTK("select count(MaNganh) as slNganh from Nganh", "slNganh")
        lbTilted.Text = "DANH SÁCH NHỮNG THÍ SINH  ĐẬU ĐẠI HỌC"
        Dim ds As New DataSet
        DataGridViewThongKe.DataSource = Display("select distinct * from HoSoSinhVien LEFT JOIN Nganh ON HoSoSinhVien.MaNganh  = Nganh.MaNganh where Diem1 + Diem1 + Diem3 >= DiemChuan", ds).Tables(0)

        PaneHoSo.Visible = False
        PanelNganh.Visible = False
        PanelTraCuuKQ.Visible = False
        PanelThongKe.Visible = True
        PanelWelCome.Visible = False
    End Sub

    Private Sub Them(query As String)
        Try
            Con.open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Thêm thành công!")
            Con.Close()
        Catch ex As Exception
            Con.Close()
            MsgBox("Thêm thất bại!")
        End Try

    End Sub

    Private Sub Sua(query As String)
        If key = 0 And keyNganh = "" Then
            MsgBox("Chọn dòng để sửa thông tin!")
        Else
            Con.open()
            Dim ds As New DataSet
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Sửa thành công!")
            Con.Close()
        End If
    End Sub

    Private Sub Xoa(query As String)
        If key = 0 And keyNganh = "" Then
            MsgBox("Chọn dòng muốn xoá!")
        Else
            If MsgBox("Bạn có muốn xóa không? ", vbYesNo, "Xóa") = MsgBoxResult.Yes Then
                Con.open()
                Dim ds As New DataSet
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Đã xoá thành công!")
                Con.Close()
            End If
        End If
    End Sub

    Private Function Tim(query As String, ByVal csvDataSet As DataSet) As DataSet
        Con.open()
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        Con.close()
        Return ds
    End Function

    'CHỨC NĂNG CỦA HO SO SINH VIEN'
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If txtCCCD.Text = "" Or txtDiaChi.Text = "" Or txtHoVaTen.Text = "" Or txtNgaySinh.Text = "" Or ComboBox_MaNganh.Text = "" Or ComboBox_NguyenV.Text = "" Or ComboBox_GioiTinh.Text = "" Then
            MsgBox("Bạn cần nhập đủ những thông tin cần thiết!!")
        Else
            Dim query = "insert into HoSoSinhVien values ('" & txtCCCD.Text & "',N'" & txtHoVaTen.Text & "', '" & txtNgaySinh.Text & "', N'" & ComboBox_GioiTinh.Text & "', '" & ComboBox_MaNganh.Text & "', '" & ComboBox_NguyenV.Text & "', N'" & txtDiaChi.Text & "','" & txtDiem1.Text & "' ,'" & txtDiem2.Text & "','" & txtDiem3.Text & "' )"
            Them(query)
            Dim ds As New DataSet
            DataGridViewHoSo.DataSource = Display(queryHoSo, ds).Tables(0)
        End If
    End Sub

    Private Sub btnModified_Click(sender As System.Object, e As System.EventArgs) Handles btnModified.Click
        Dim query = "UPDATE HoSoSinhVien SET  CCCD='" & txtCCCD.Text & "', HoTen = N'" & txtHoVaTen.Text & "',NgaySinh= '" & txtNgaySinh.Text & "',GioiTinh= N'" & ComboBox_GioiTinh.Text & "',MaNganh= '" & ComboBox_MaNganh.Text & "',NguyenVong= '" & ComboBox_NguyenV.Text & "',DiaChi= N'" & txtDiaChi.Text & "',Diem1='" & txtDiem1.Text & "' ,Diem2='" & txtDiem2.Text & "',Diem3='" & txtDiem3.Text & "'   where CCCD=" & key & ""
        Sua(query)
        Dim ds As New DataSet
        DataGridViewHoSo.DataSource = Display(queryHoSo, ds).Tables(0)
        reset()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim query = "delete from HoSoSinhVien where CCCD=" & key & ""
        Xoa(query)
        Dim ds As New DataSet
        DataGridViewHoSo.DataSource = Display(queryHoSo, ds).Tables(0)
        reset()
    End Sub


    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Dim ds As New DataSet
        reset()
        DataGridViewHoSo.DataSource = Display(queryHoSo, ds).Tables(0)
    End Sub

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        Dim ds As New DataSet
        Dim query = "select * from HoSoSinhVien where  CCCD='" & txtCCCD.Text & "'"
        DataGridViewHoSo.DataSource = Tim(query, ds).Tables(0)
        If DataGridViewHoSo.Rows.Count = 1 Then
            MsgBox("Không tìm thấy hồ sơ của CCCD này!")
        End If
    End Sub

    'CHỨC NĂNG CỦA NGÀNH'
    Private Sub btnAddNganh_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNganh.Click
        If txtMaNganh.Text = "" Or txtTenNganh.Text = "" Or txtChitieu.Text = "" Or txtDiemChuan.Text = "" Then
            MsgBox("Bạn cần nhập đủ những thông tin cần thiết!!")
        Else
            Dim query = "insert into Nganh values ('" & txtMaNganh.Text & "',N'" & txtTenNganh.Text & "', '" & txtChitieu.Text & "', '" & txtDiemChuan.Text & "')"
            Them(query)
            Dim ds As New DataSet
            DataGridViewNganh.DataSource = Display(queryNganh, ds).Tables(0)
            resetNganh()
        End If
    End Sub

    Private Sub btnModifiedNganh_Click(sender As System.Object, e As System.EventArgs) Handles btnModifiedNganh.Click
        Dim query = "UPDATE Nganh SET  MaNganh='" & txtMaNganh.Text & "', TenNganh = N'" & txtTenNganh.Text & "',ChiTieu= '" & txtChitieu.Text & "',DiemChuan= N'" & txtDiemChuan.Text & "'  where MaNganh='" & keyNganh & "'"
        Sua(query)
        Dim ds As New DataSet
        DataGridViewNganh.DataSource = Display(queryNganh, ds).Tables(0)
        resetNganh()
    End Sub

    Private Sub btnDeleteNganh_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteNganh.Click
        Dim query = "delete from Nganh where MaNganh='" & keyNganh & "'"
        Xoa(query)
        Dim ds As New DataSet
        DataGridViewNganh.DataSource = Display(queryNganh, ds).Tables(0)
        resetNganh()
    End Sub

    Private Sub btnRefreshNganh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshNganh.Click
        Dim ds As New DataSet
        resetNganh()
        DataGridViewNganh.DataSource = Display(queryNganh, ds).Tables(0)
    End Sub


    Private Sub btnFindNganh_Click(sender As System.Object, e As System.EventArgs) Handles btnFindNganh.Click
        Dim ds As New DataSet
        Dim query = "select * from Nganh where  MaNganh='" & txtMaNganh.Text & "'"
        DataGridViewNganh.DataSource = Tim(query, ds).Tables(0)
        If DataGridViewNganh.Rows.Count = 1 Then
            MsgBox("Không tìm thấy hồ sơ của CCCD này!")
        End If
    End Sub


    Private Sub reset()
        txtCCCD.Text = ""
        txtHoVaTen.Text = ""
        txtNgaySinh.Text = ""
        ComboBox_GioiTinh.Text = ""
        ComboBox_MaNganh.Text = ""
        ComboBox_NguyenV.Text = ""
        txtDiaChi.Text = ""
        txtDiem1.Text = ""
        txtDiem2.Text = ""
        txtDiem3.Text = ""
    End Sub

    Private Sub resetNganh()
        txtMaNganh.Text = ""
        txtTenNganh.Text = ""
        txtChitieu.Text = ""
        txtDiemChuan.Text = ""
    End Sub

    Dim key = 0
    Private Sub DataGridViewHoSo_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewHoSo.CellMouseClick
        Dim row As DataGridViewRow = DataGridViewHoSo.Rows(e.RowIndex)
        txtCCCD.Text = row.Cells(0).Value.ToString
        txtHoVaTen.Text = row.Cells(1).Value.ToString
        txtNgaySinh.Text = row.Cells(2).Value.ToString
        ComboBox_GioiTinh.Text = row.Cells(3).Value.ToString
        ComboBox_MaNganh.Text = row.Cells(4).Value.ToString
        ComboBox_NguyenV.Text = row.Cells(5).Value.ToString
        txtDiaChi.Text = row.Cells(6).Value.ToString
        txtDiem1.Text = row.Cells(7).Value.ToString
        txtDiem2.Text = row.Cells(8).Value.ToString
        txtDiem3.Text = row.Cells(9).Value.ToString
        If txtCCCD.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Dim keyNganh = ""
    Private Sub DataGridViewNganh_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewNganh.CellMouseClick
        Dim row As DataGridViewRow = DataGridViewNganh.Rows(e.RowIndex)
        txtMaNganh.Text = row.Cells(0).Value.ToString
        txtTenNganh.Text = row.Cells(1).Value.ToString
        txtChitieu.Text = row.Cells(2).Value.ToString
        txtDiemChuan.Text = row.Cells(3).Value.ToString
        If txtMaNganh.Text = "" Then
            keyNganh = ""
        Else
            keyNganh = row.Cells(0).Value.ToString

        End If
    End Sub







    'CHỨC NĂNG TRA CỨU'

    Private Sub btnTraCuu_Click(sender As System.Object, e As System.EventArgs) Handles btnTraCuu.Click
        If txtkqCCCD.Text.Length <= 0 Then
            MessageBox.Show("Bạn quên nhập số CCCD rồi kìa !!")
        Else
            Dim cmd As SqlCommand = New SqlCommand("select * from HoSoSinhVien where  CCCD='" + txtkqCCCD.Text + "'  ", Con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then
                PanelChildTraCukq.Visible = True
                lbHoten.Text = dt.Rows(0).Item("HoTen").ToString()
                lbCCCD.Text = dt.Rows(0).Item("CCCD").ToString()
                Dim strDate As String = Date.Now.ToString("dd'/'MM'/'yyyy")   'Định dạng kiểu ngày
                strDate = dt.Rows(0).Item("NgaySinh")
                lbNgaySinh.Text = strDate
                lbDiem1.Text = dt.Rows(0).Item("Diem1")
                lbDiem2.Text = dt.Rows(0).Item("Diem2")
                lbDiem3.Text = dt.Rows(0).Item("Diem3")
                Dim tongDiem As Double = dt.Rows(0).Item("Diem1") + dt.Rows(0).Item("Diem2") + dt.Rows(0).Item("Diem3")
                lbTongDiem.Text = tongDiem

                Dim cmdDiemChuan As SqlCommand = New SqlCommand("select * from Nganh where  MaNganh='" + dt.Rows(0).Item("MaNganh") + "'  ", Con)
                Dim sdaDC As SqlDataAdapter = New SqlDataAdapter(cmdDiemChuan)
                Dim dtDC As DataTable = New DataTable()
                sdaDC.Fill(dtDC)

                Dim diemChuan As Double = dtDC.Rows(0).Item("DiemChuan").ToString()
                lbDiemChuan.Text = diemChuan
                lbTenNganh.Text = dtDC.Rows(0).Item("TenNganh").ToString()
                If tongDiem >= diemChuan Then
                    lbKetQua.Text = "Đậu"
                Else
                    lbKetQua.Text = "Rớt"
                End If
            Else
                MessageBox.Show("Không tìm thấy kết quả phù hợp!! Bạn kiểm tra lại số CCCD")
            End If
        End If
    End Sub



    Private Sub btnReport_Click(sender As System.Object, e As System.EventArgs) Handles btnReport.Click
        FormReportHoSovb.Show()
        Me.Hide()
    End Sub




    'CHUC NANG PANEL THONG KE'
    Private Sub LbTiltedChid_Click(sender As System.Object, e As System.EventArgs) Handles LbTiltedChid.Click
        lbTilted.Text = "DANH SÁCH CÁC NGÀNH ĐÃ TUYỂN ĐỦ CHỈ TIÊU"
        Dim ds As New DataSet
        Dim queryDuChiTieu = "select Nganh .TenNganh ,Chitieu from Nganh,(select TenNganh, count (Nganh.MaNganh ) as SLDaDau from HoSoSinhVien,Nganh where Diem1 + Diem1 + Diem3 >= DiemChuan group by TenNganh ) truyvancon where  Nganh .TenNganh = truyvancon.TenNganh and truyvancon.SLDaDau >= Chitieu  "
        DataGridViewThongKe.DataSource = Display(queryDuChiTieu, ds).Tables(0)
    End Sub



    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub HồSơSinhViênToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HồSơSinhViênToolStripMenuItem.Click
        FromHoSo.Show()
        Me.Hide()
    End Sub

    Private Sub NgànhHọcToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NgànhHọcToolStripMenuItem.Click
        FormNganhHoc.Show()
        Me.Hide()
    End Sub


    Private Sub ReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        FormReportHoSovb.Show()
        Me.Hide()
    End Sub

    Private Sub TraCứKếtQuảToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TraCứKếtQuảToolStripMenuItem.Click
        FormTraCuuKetQua.Show()
        Me.Hide()
    End Sub
End Class
