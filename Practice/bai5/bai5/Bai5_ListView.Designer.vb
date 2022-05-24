<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bai5_ListView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bai5_ListView))
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtQueQuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMSV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSTT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.btnChuyen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(666, 245)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(70, 37)
        Me.btnCapNhat.TabIndex = 14
        Me.btnCapNhat.Text = "Cập nhât"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.Crimson
        Me.btnXoa.Location = New System.Drawing.Point(579, 245)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(70, 37)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnThem.Location = New System.Drawing.Point(488, 245)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(70, 37)
        Me.btnThem.TabIndex = 16
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtQueQuan
        '
        Me.txtQueQuan.Location = New System.Drawing.Point(562, 181)
        Me.txtQueQuan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQueQuan.Name = "txtQueQuan"
        Me.txtQueQuan.Size = New System.Drawing.Size(176, 20)
        Me.txtQueQuan.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(486, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quê quán:"
        '
        'txtMSV
        '
        Me.txtMSV.Location = New System.Drawing.Point(562, 136)
        Me.txtMSV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMSV.Name = "txtMSV"
        Me.txtMSV.Size = New System.Drawing.Size(176, 20)
        Me.txtMSV.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(486, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mã sinh viên:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(562, 95)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(176, 20)
        Me.txtName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(486, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Họ và tên:"
        '
        'txtSTT
        '
        Me.txtSTT.Location = New System.Drawing.Point(562, 51)
        Me.txtSTT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSTT.Name = "txtSTT"
        Me.txtSTT.Size = New System.Drawing.Size(176, 20)
        Me.txtSTT.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(486, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Số thứ tự:"
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(48, 42)
        Me.lv.Margin = New System.Windows.Forms.Padding(2)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(392, 269)
        Me.lv.TabIndex = 5
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'btnChuyen
        '
        Me.btnChuyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnChuyen.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnChuyen.Location = New System.Drawing.Point(495, 339)
        Me.btnChuyen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChuyen.Name = "btnChuyen"
        Me.btnChuyen.Size = New System.Drawing.Size(70, 37)
        Me.btnChuyen.TabIndex = 16
        Me.btnChuyen.Text = "Chuyển tab"
        Me.btnChuyen.UseVisualStyleBackColor = True
        '
        'Bai5_ListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(786, 483)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnChuyen)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtQueQuan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMSV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSTT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lv)
        Me.Name = "Bai5_ListView"
        Me.Text = "Bai5_ListView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtQueQuan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMSV As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSTT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents btnChuyen As System.Windows.Forms.Button

End Class
