<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bai4_Combobox_ListView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bai4_Combobox_ListView))
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnChon = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.ListBoxDSDagky = New System.Windows.Forms.ListBox()
        Me.ComboBoxDSMonHoc = New System.Windows.Forms.ComboBox()
        Me.txtMonhoc = New System.Windows.Forms.TextBox()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.Crimson
        Me.btnXoa.Location = New System.Drawing.Point(146, 434)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 55)
        Me.btnXoa.TabIndex = 19
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnChon
        '
        Me.btnChon.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnChon.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnChon.Location = New System.Drawing.Point(468, 254)
        Me.btnChon.Name = "btnChon"
        Me.btnChon.Size = New System.Drawing.Size(75, 55)
        Me.btnChon.TabIndex = 18
        Me.btnChon.Text = "Chọn"
        Me.btnChon.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHuy.ForeColor = System.Drawing.Color.Crimson
        Me.btnHuy.Location = New System.Drawing.Point(468, 348)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 55)
        Me.btnHuy.TabIndex = 21
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThem.Location = New System.Drawing.Point(27, 434)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 55)
        Me.btnThem.TabIndex = 20
        Me.btnThem.Text = "Thêm "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'ListBoxDSDagky
        '
        Me.ListBoxDSDagky.FormattingEnabled = True
        Me.ListBoxDSDagky.Location = New System.Drawing.Point(573, 240)
        Me.ListBoxDSDagky.Name = "ListBoxDSDagky"
        Me.ListBoxDSDagky.Size = New System.Drawing.Size(210, 160)
        Me.ListBoxDSDagky.TabIndex = 17
        '
        'ComboBoxDSMonHoc
        '
        Me.ComboBoxDSMonHoc.FormattingEnabled = True
        Me.ComboBoxDSMonHoc.Items.AddRange(New Object() {"Mạng máy tính", "Khoa học máy tính", "Cơ sở dữ liệu", "Thực hành lập trình trực quan", "Thiết kế web"})
        Me.ComboBoxDSMonHoc.Location = New System.Drawing.Point(181, 281)
        Me.ComboBoxDSMonHoc.Name = "ComboBoxDSMonHoc"
        Me.ComboBoxDSMonHoc.Size = New System.Drawing.Size(190, 21)
        Me.ComboBoxDSMonHoc.TabIndex = 16
        '
        'txtMonhoc
        '
        Me.txtMonhoc.Location = New System.Drawing.Point(181, 206)
        Me.txtMonhoc.Name = "txtMonhoc"
        Me.txtMonhoc.Size = New System.Drawing.Size(190, 20)
        Me.txtMonhoc.TabIndex = 15
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.BackColor = System.Drawing.Color.Transparent
        Me.LabelResult.Location = New System.Drawing.Point(637, 463)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(101, 15)
        Me.LabelResult.TabIndex = 12
        Me.LabelResult.Text = "Số lượng đăng ký"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(465, 463)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Số lượng đăng ký:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(570, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Danh sách đăng ký: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(33, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Danh sách môn học: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(33, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nhập môn học:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ĐĂNG KÝ MÔN HỌC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(21, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(700, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ĐẠI HỌC SƯ PHẠM KĨ THUẬT - ĐẠI HỌC ĐÀ NẴNG"
        '
        'Bai4_Combobox_ListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(804, 543)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnChon)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.ListBoxDSDagky)
        Me.Controls.Add(Me.ComboBoxDSMonHoc)
        Me.Controls.Add(Me.txtMonhoc)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Bai4_Combobox_ListView"
        Me.Text = "Bai4_Combobox_ListView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnChon As System.Windows.Forms.Button
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents ListBoxDSDagky As System.Windows.Forms.ListBox
    Friend WithEvents ComboBoxDSMonHoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonhoc As System.Windows.Forms.TextBox
    Friend WithEvents LabelResult As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
