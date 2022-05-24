<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadioButton
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
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadioButton))
        Me.kqHinh = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tronCb = New System.Windows.Forms.CheckBox()
        Me.tgCb = New System.Windows.Forms.CheckBox()
        Me.vuongCb = New System.Windows.Forms.CheckBox()
        Me.cnCb = New System.Windows.Forms.CheckBox()
        Me.canh3 = New System.Windows.Forms.TextBox()
        Me.canh2 = New System.Windows.Forms.TextBox()
        Me.canh4 = New System.Windows.Forms.TextBox()
        Me.canh1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.b1Lb = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.ketquaLB = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chiaRB = New System.Windows.Forms.RadioButton()
        Me.luythuaRB = New System.Windows.Forms.RadioButton()
        Me.chialayduRB = New System.Windows.Forms.RadioButton()
        Me.chialaynguyenRB = New System.Windows.Forms.RadioButton()
        Me.nhanRB = New System.Windows.Forms.RadioButton()
        Me.truRB = New System.Windows.Forms.RadioButton()
        Me.congRB = New System.Windows.Forms.RadioButton()
        Me.tinhBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sothu2 = New System.Windows.Forms.TextBox()
        Me.sothu1 = New System.Windows.Forms.TextBox()
        Me.btnChuyenTab = New System.Windows.Forms.Button()
        Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.ForeColor = System.Drawing.Color.DarkRed
        Label9.Location = New System.Drawing.Point(583, 366)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(201, 45)
        Label9.TabIndex = 60
        Label9.Text = "Lưu ý: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " + Tam giác nhập cạnh 1,2,3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " + Hình tròn nhập bán kính ở cạnh 1"
        '
        'kqHinh
        '
        Me.kqHinh.AutoSize = True
        Me.kqHinh.BackColor = System.Drawing.Color.Transparent
        Me.kqHinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kqHinh.ForeColor = System.Drawing.Color.Navy
        Me.kqHinh.Location = New System.Drawing.Point(634, 335)
        Me.kqHinh.Name = "kqHinh"
        Me.kqHinh.Size = New System.Drawing.Size(139, 18)
        Me.kqHinh.TabIndex = 59
        Me.kqHinh.Text = "Kết quả bài diện tích"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(510, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 25)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "KẾT QUẢ:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.Location = New System.Drawing.Point(632, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 41)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "TÍNH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tronCb)
        Me.Panel1.Controls.Add(Me.tgCb)
        Me.Panel1.Controls.Add(Me.vuongCb)
        Me.Panel1.Controls.Add(Me.cnCb)
        Me.Panel1.Location = New System.Drawing.Point(534, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 121)
        Me.Panel1.TabIndex = 56
        '
        'tronCb
        '
        Me.tronCb.AutoSize = True
        Me.tronCb.Location = New System.Drawing.Point(172, 66)
        Me.tronCb.Name = "tronCb"
        Me.tronCb.Size = New System.Drawing.Size(93, 19)
        Me.tronCb.TabIndex = 4
        Me.tronCb.Text = "HÌNH TRÒN"
        Me.tronCb.UseVisualStyleBackColor = True
        '
        'tgCb
        '
        Me.tgCb.AutoSize = True
        Me.tgCb.Location = New System.Drawing.Point(20, 66)
        Me.tgCb.Name = "tgCb"
        Me.tgCb.Size = New System.Drawing.Size(114, 19)
        Me.tgCb.TabIndex = 2
        Me.tgCb.Text = "HÌNH TAM GIÁC"
        Me.tgCb.UseVisualStyleBackColor = True
        '
        'vuongCb
        '
        Me.vuongCb.AutoSize = True
        Me.vuongCb.Location = New System.Drawing.Point(172, 21)
        Me.vuongCb.Name = "vuongCb"
        Me.vuongCb.Size = New System.Drawing.Size(102, 19)
        Me.vuongCb.TabIndex = 1
        Me.vuongCb.Text = "HÌNH VUÔNG"
        Me.vuongCb.UseVisualStyleBackColor = True
        '
        'cnCb
        '
        Me.cnCb.AutoSize = True
        Me.cnCb.Location = New System.Drawing.Point(20, 21)
        Me.cnCb.Name = "cnCb"
        Me.cnCb.Size = New System.Drawing.Size(120, 19)
        Me.cnCb.TabIndex = 0
        Me.cnCb.Text = "HÌNH CHỮ NHẬT"
        Me.cnCb.UseVisualStyleBackColor = True
        '
        'canh3
        '
        Me.canh3.Location = New System.Drawing.Point(586, 117)
        Me.canh3.Name = "canh3"
        Me.canh3.Size = New System.Drawing.Size(81, 20)
        Me.canh3.TabIndex = 55
        '
        'canh2
        '
        Me.canh2.Location = New System.Drawing.Point(750, 65)
        Me.canh2.Name = "canh2"
        Me.canh2.Size = New System.Drawing.Size(81, 20)
        Me.canh2.TabIndex = 54
        '
        'canh4
        '
        Me.canh4.Location = New System.Drawing.Point(750, 113)
        Me.canh4.Name = "canh4"
        Me.canh4.Size = New System.Drawing.Size(81, 20)
        Me.canh4.TabIndex = 53
        '
        'canh1
        '
        Me.canh1.Location = New System.Drawing.Point(586, 65)
        Me.canh1.Name = "canh1"
        Me.canh1.Size = New System.Drawing.Size(81, 20)
        Me.canh1.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(531, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Cạnh 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(691, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Cạnh 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(691, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Cạnh 2"
        '
        'b1Lb
        '
        Me.b1Lb.AutoSize = True
        Me.b1Lb.BackColor = System.Drawing.Color.Transparent
        Me.b1Lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1Lb.ForeColor = System.Drawing.Color.Navy
        Me.b1Lb.Location = New System.Drawing.Point(185, 329)
        Me.b1Lb.Name = "b1Lb"
        Me.b1Lb.Size = New System.Drawing.Size(141, 18)
        Me.b1Lb.TabIndex = 48
        Me.b1Lb.Text = "Kết quả bài toán tính"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(530, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 25)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "TÍNH DIỆN TÍCH HÌNH HỌC"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Location = New System.Drawing.Point(531, 65)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(46, 15)
        Me.label10.TabIndex = 46
        Me.label10.Text = "Cạnh 1"
        '
        'ketquaLB
        '
        Me.ketquaLB.AutoSize = True
        Me.ketquaLB.Location = New System.Drawing.Point(511, 91)
        Me.ketquaLB.Name = "ketquaLB"
        Me.ketquaLB.Size = New System.Drawing.Size(0, 15)
        Me.ketquaLB.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(61, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 25)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "KẾT QUẢ:"
        '
        'chiaRB
        '
        Me.chiaRB.AutoSize = True
        Me.chiaRB.BackColor = System.Drawing.Color.Transparent
        Me.chiaRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chiaRB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chiaRB.Location = New System.Drawing.Point(65, 279)
        Me.chiaRB.Name = "chiaRB"
        Me.chiaRB.Size = New System.Drawing.Size(60, 22)
        Me.chiaRB.TabIndex = 43
        Me.chiaRB.TabStop = True
        Me.chiaRB.Text = "Chia"
        Me.chiaRB.UseVisualStyleBackColor = False
        '
        'luythuaRB
        '
        Me.luythuaRB.AutoSize = True
        Me.luythuaRB.BackColor = System.Drawing.Color.Transparent
        Me.luythuaRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luythuaRB.ForeColor = System.Drawing.Color.Gold
        Me.luythuaRB.Location = New System.Drawing.Point(179, 201)
        Me.luythuaRB.Name = "luythuaRB"
        Me.luythuaRB.Size = New System.Drawing.Size(167, 22)
        Me.luythuaRB.TabIndex = 42
        Me.luythuaRB.TabStop = True
        Me.luythuaRB.Text = "Phép lũy thừa ( ^ ) "
        Me.luythuaRB.UseVisualStyleBackColor = False
        '
        'chialayduRB
        '
        Me.chialayduRB.AutoSize = True
        Me.chialayduRB.BackColor = System.Drawing.Color.Transparent
        Me.chialayduRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chialayduRB.ForeColor = System.Drawing.Color.Gold
        Me.chialayduRB.Location = New System.Drawing.Point(179, 159)
        Me.chialayduRB.Name = "chialayduRB"
        Me.chialayduRB.Size = New System.Drawing.Size(159, 22)
        Me.chialayduRB.TabIndex = 41
        Me.chialayduRB.TabStop = True
        Me.chialayduRB.Text = "Chia lấy dư (mod)"
        Me.chialayduRB.UseVisualStyleBackColor = False
        '
        'chialaynguyenRB
        '
        Me.chialaynguyenRB.AutoSize = True
        Me.chialaynguyenRB.BackColor = System.Drawing.Color.Transparent
        Me.chialaynguyenRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chialaynguyenRB.ForeColor = System.Drawing.Color.Gold
        Me.chialaynguyenRB.Location = New System.Drawing.Point(179, 241)
        Me.chialaynguyenRB.Name = "chialaynguyenRB"
        Me.chialaynguyenRB.Size = New System.Drawing.Size(225, 22)
        Me.chialaynguyenRB.TabIndex = 40
        Me.chialaynguyenRB.TabStop = True
        Me.chialaynguyenRB.Text = "Phép chia lấy nguyên ( % )"
        Me.chialaynguyenRB.UseVisualStyleBackColor = False
        '
        'nhanRB
        '
        Me.nhanRB.AutoSize = True
        Me.nhanRB.BackColor = System.Drawing.Color.Transparent
        Me.nhanRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nhanRB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nhanRB.Location = New System.Drawing.Point(65, 241)
        Me.nhanRB.Name = "nhanRB"
        Me.nhanRB.Size = New System.Drawing.Size(65, 22)
        Me.nhanRB.TabIndex = 39
        Me.nhanRB.TabStop = True
        Me.nhanRB.Text = "Nhân"
        Me.nhanRB.UseVisualStyleBackColor = False
        '
        'truRB
        '
        Me.truRB.AutoSize = True
        Me.truRB.BackColor = System.Drawing.Color.Transparent
        Me.truRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.truRB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.truRB.Location = New System.Drawing.Point(65, 201)
        Me.truRB.Name = "truRB"
        Me.truRB.Size = New System.Drawing.Size(51, 22)
        Me.truRB.TabIndex = 38
        Me.truRB.TabStop = True
        Me.truRB.Text = "Trừ"
        Me.truRB.UseVisualStyleBackColor = False
        '
        'congRB
        '
        Me.congRB.AutoSize = True
        Me.congRB.BackColor = System.Drawing.Color.Transparent
        Me.congRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.congRB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.congRB.Location = New System.Drawing.Point(65, 159)
        Me.congRB.Name = "congRB"
        Me.congRB.Size = New System.Drawing.Size(66, 22)
        Me.congRB.TabIndex = 37
        Me.congRB.TabStop = True
        Me.congRB.Text = "Cộng"
        Me.congRB.UseVisualStyleBackColor = False
        '
        'tinhBtn
        '
        Me.tinhBtn.BackColor = System.Drawing.SystemColors.WindowText
        Me.tinhBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tinhBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tinhBtn.ForeColor = System.Drawing.SystemColors.Highlight
        Me.tinhBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.tinhBtn.Location = New System.Drawing.Point(146, 427)
        Me.tinhBtn.Name = "tinhBtn"
        Me.tinhBtn.Size = New System.Drawing.Size(100, 41)
        Me.tinhBtn.TabIndex = 36
        Me.tinhBtn.Text = "TÍNH"
        Me.tinhBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(155, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 25)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "TÍNH ĐƠN GIẢN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Số thứ 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Số thứ nhất"
        '
        'sothu2
        '
        Me.sothu2.Location = New System.Drawing.Point(179, 110)
        Me.sothu2.Name = "sothu2"
        Me.sothu2.Size = New System.Drawing.Size(140, 20)
        Me.sothu2.TabIndex = 32
        '
        'sothu1
        '
        Me.sothu1.Location = New System.Drawing.Point(179, 65)
        Me.sothu1.Name = "sothu1"
        Me.sothu1.Size = New System.Drawing.Size(140, 20)
        Me.sothu1.TabIndex = 31
        '
        'btnChuyenTab
        '
        Me.btnChuyenTab.BackColor = System.Drawing.SystemColors.WindowText
        Me.btnChuyenTab.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnChuyenTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChuyenTab.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnChuyenTab.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnChuyenTab.Location = New System.Drawing.Point(898, 19)
        Me.btnChuyenTab.Name = "btnChuyenTab"
        Me.btnChuyenTab.Size = New System.Drawing.Size(100, 41)
        Me.btnChuyenTab.TabIndex = 36
        Me.btnChuyenTab.Text = "Chuyển tab"
        Me.btnChuyenTab.UseVisualStyleBackColor = False
        '
        'RadioButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1009, 486)
        Me.ControlBox = False
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.kqHinh)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.canh3)
        Me.Controls.Add(Me.canh2)
        Me.Controls.Add(Me.canh4)
        Me.Controls.Add(Me.canh1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.b1Lb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.ketquaLB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chiaRB)
        Me.Controls.Add(Me.luythuaRB)
        Me.Controls.Add(Me.chialayduRB)
        Me.Controls.Add(Me.chialaynguyenRB)
        Me.Controls.Add(Me.nhanRB)
        Me.Controls.Add(Me.truRB)
        Me.Controls.Add(Me.congRB)
        Me.Controls.Add(Me.btnChuyenTab)
        Me.Controls.Add(Me.tinhBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sothu2)
        Me.Controls.Add(Me.sothu1)
        Me.Name = "RadioButton"
        Me.Text = "3.3 RadioButton"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kqHinh As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tronCb As System.Windows.Forms.CheckBox
    Friend WithEvents tgCb As System.Windows.Forms.CheckBox
    Friend WithEvents vuongCb As System.Windows.Forms.CheckBox
    Friend WithEvents cnCb As System.Windows.Forms.CheckBox
    Friend WithEvents canh3 As System.Windows.Forms.TextBox
    Friend WithEvents canh2 As System.Windows.Forms.TextBox
    Friend WithEvents canh4 As System.Windows.Forms.TextBox
    Friend WithEvents canh1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents b1Lb As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents ketquaLB As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chiaRB As System.Windows.Forms.RadioButton
    Friend WithEvents luythuaRB As System.Windows.Forms.RadioButton
    Friend WithEvents chialayduRB As System.Windows.Forms.RadioButton
    Friend WithEvents chialaynguyenRB As System.Windows.Forms.RadioButton
    Friend WithEvents nhanRB As System.Windows.Forms.RadioButton
    Friend WithEvents truRB As System.Windows.Forms.RadioButton
    Friend WithEvents congRB As System.Windows.Forms.RadioButton
    Friend WithEvents tinhBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sothu2 As System.Windows.Forms.TextBox
    Friend WithEvents sothu1 As System.Windows.Forms.TextBox
    Friend WithEvents btnChuyenTab As System.Windows.Forms.Button

End Class
