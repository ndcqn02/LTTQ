<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGiaTri1 = New System.Windows.Forms.TextBox()
        Me.txtGiaTri2 = New System.Windows.Forms.TextBox()
        Me.btnThucHien = New System.Windows.Forms.Button()
        Me.LbResult = New System.Windows.Forms.Label()
        Me.RbtAdd = New System.Windows.Forms.RadioButton()
        Me.RbtSub = New System.Windows.Forms.RadioButton()
        Me.RbtMulti = New System.Windows.Forms.RadioButton()
        Me.RbtDevice = New System.Windows.Forms.RadioButton()
        Me.RbtMod = New System.Windows.Forms.RadioButton()
        Me.RbtPower = New System.Windows.Forms.RadioButton()
        Me.RbtDiv = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbtSquare = New System.Windows.Forms.RadioButton()
        Me.RbtTrigle = New System.Windows.Forms.RadioButton()
        Me.RbtRect = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbGiatri3 = New System.Windows.Forms.Label()
        Me.txtGiaTri3 = New System.Windows.Forms.TextBox()
        Me.LbArea = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleName = "lb1"
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(38, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Giá trị 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(38, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Giá trị 2"
        '
        'txtGiaTri1
        '
        Me.txtGiaTri1.AccessibleName = "txtgiatri1"
        Me.txtGiaTri1.BackColor = System.Drawing.SystemColors.Window
        Me.txtGiaTri1.Location = New System.Drawing.Point(38, 61)
        Me.txtGiaTri1.Name = "txtGiaTri1"
        Me.txtGiaTri1.Size = New System.Drawing.Size(125, 27)
        Me.txtGiaTri1.TabIndex = 3
        '
        'txtGiaTri2
        '
        Me.txtGiaTri2.AccessibleName = ""
        Me.txtGiaTri2.Location = New System.Drawing.Point(38, 143)
        Me.txtGiaTri2.Name = "txtGiaTri2"
        Me.txtGiaTri2.Size = New System.Drawing.Size(125, 27)
        Me.txtGiaTri2.TabIndex = 3
        '
        'btnThucHien
        '
        Me.btnThucHien.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnThucHien.ForeColor = System.Drawing.Color.Black
        Me.btnThucHien.Location = New System.Drawing.Point(151, 357)
        Me.btnThucHien.Name = "btnThucHien"
        Me.btnThucHien.Size = New System.Drawing.Size(122, 35)
        Me.btnThucHien.TabIndex = 4
        Me.btnThucHien.Text = "Thực Hiện"
        Me.btnThucHien.UseVisualStyleBackColor = False
        '
        'LbResult
        '
        Me.LbResult.AutoSize = True
        Me.LbResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbResult.Location = New System.Drawing.Point(303, 364)
        Me.LbResult.Name = "LbResult"
        Me.LbResult.Size = New System.Drawing.Size(69, 20)
        Me.LbResult.TabIndex = 5
        Me.LbResult.Text = "Kết Quả :"
        '
        'RbtAdd
        '
        Me.RbtAdd.AutoSize = True
        Me.RbtAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RbtAdd.Location = New System.Drawing.Point(29, 37)
        Me.RbtAdd.Name = "RbtAdd"
        Me.RbtAdd.Size = New System.Drawing.Size(89, 24)
        Me.RbtAdd.TabIndex = 6
        Me.RbtAdd.TabStop = True
        Me.RbtAdd.Text = "Cộng (+)"
        Me.RbtAdd.UseVisualStyleBackColor = True
        '
        'RbtSub
        '
        Me.RbtSub.AutoSize = True
        Me.RbtSub.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RbtSub.Location = New System.Drawing.Point(29, 82)
        Me.RbtSub.Name = "RbtSub"
        Me.RbtSub.Size = New System.Drawing.Size(71, 24)
        Me.RbtSub.TabIndex = 6
        Me.RbtSub.TabStop = True
        Me.RbtSub.Text = "Trừ (-)"
        Me.RbtSub.UseVisualStyleBackColor = True
        '
        'RbtMulti
        '
        Me.RbtMulti.AutoSize = True
        Me.RbtMulti.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RbtMulti.Location = New System.Drawing.Point(29, 121)
        Me.RbtMulti.Name = "RbtMulti"
        Me.RbtMulti.Size = New System.Drawing.Size(86, 24)
        Me.RbtMulti.TabIndex = 6
        Me.RbtMulti.TabStop = True
        Me.RbtMulti.Text = "Nhân (x)"
        Me.RbtMulti.UseVisualStyleBackColor = True
        '
        'RbtDevice
        '
        Me.RbtDevice.AutoSize = True
        Me.RbtDevice.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RbtDevice.Location = New System.Drawing.Point(29, 160)
        Me.RbtDevice.Name = "RbtDevice"
        Me.RbtDevice.Size = New System.Drawing.Size(79, 24)
        Me.RbtDevice.TabIndex = 6
        Me.RbtDevice.TabStop = True
        Me.RbtDevice.Text = "Chia (/)"
        Me.RbtDevice.UseVisualStyleBackColor = True
        '
        'RbtMod
        '
        Me.RbtMod.AutoSize = True
        Me.RbtMod.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RbtMod.Location = New System.Drawing.Point(174, 39)
        Me.RbtMod.Name = "RbtMod"
        Me.RbtMod.Size = New System.Drawing.Size(149, 24)
        Me.RbtMod.TabIndex = 7
        Me.RbtMod.TabStop = True
        Me.RbtMod.Text = "Chia lấy dư (Mod)"
        Me.RbtMod.UseVisualStyleBackColor = True
        '
        'RbtPower
        '
        Me.RbtPower.AutoSize = True
        Me.RbtPower.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RbtPower.Location = New System.Drawing.Point(174, 123)
        Me.RbtPower.Name = "RbtPower"
        Me.RbtPower.Size = New System.Drawing.Size(93, 24)
        Me.RbtPower.TabIndex = 7
        Me.RbtPower.TabStop = True
        Me.RbtPower.Text = "Lũy Thừa "
        Me.RbtPower.UseVisualStyleBackColor = True
        '
        'RbtDiv
        '
        Me.RbtDiv.AutoSize = True
        Me.RbtDiv.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RbtDiv.Location = New System.Drawing.Point(174, 84)
        Me.RbtDiv.Name = "RbtDiv"
        Me.RbtDiv.Size = New System.Drawing.Size(168, 24)
        Me.RbtDiv.TabIndex = 7
        Me.RbtDiv.TabStop = True
        Me.RbtDiv.Text = "Chia lấy nguyên (div)"
        Me.RbtDiv.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtAdd)
        Me.GroupBox1.Controls.Add(Me.RbtDiv)
        Me.GroupBox1.Controls.Add(Me.RbtPower)
        Me.GroupBox1.Controls.Add(Me.RbtSub)
        Me.GroupBox1.Controls.Add(Me.RbtMod)
        Me.GroupBox1.Controls.Add(Me.RbtMulti)
        Me.GroupBox1.Controls.Add(Me.RbtDevice)
        Me.GroupBox1.Location = New System.Drawing.Point(313, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 289)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Toán Tử"
        '
        'RbtSquare
        '
        Me.RbtSquare.AutoSize = True
        Me.RbtSquare.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RbtSquare.Location = New System.Drawing.Point(31, 82)
        Me.RbtSquare.Name = "RbtSquare"
        Me.RbtSquare.Size = New System.Drawing.Size(143, 24)
        Me.RbtSquare.TabIndex = 9
        Me.RbtSquare.TabStop = True
        Me.RbtSquare.Text = "Area square (HV)"
        Me.RbtSquare.UseVisualStyleBackColor = True
        '
        'RbtTrigle
        '
        Me.RbtTrigle.AutoSize = True
        Me.RbtTrigle.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RbtTrigle.Location = New System.Drawing.Point(31, 123)
        Me.RbtTrigle.Name = "RbtTrigle"
        Me.RbtTrigle.Size = New System.Drawing.Size(150, 24)
        Me.RbtTrigle.TabIndex = 9
        Me.RbtTrigle.TabStop = True
        Me.RbtTrigle.Text = "Area triagle (HTG)"
        Me.RbtTrigle.UseVisualStyleBackColor = True
        '
        'RbtRect
        '
        Me.RbtRect.AutoSize = True
        Me.RbtRect.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RbtRect.Location = New System.Drawing.Point(31, 39)
        Me.RbtRect.Name = "RbtRect"
        Me.RbtRect.Size = New System.Drawing.Size(172, 24)
        Me.RbtRect.TabIndex = 9
        Me.RbtRect.TabStop = True
        Me.RbtRect.Text = "Area rectangle (HCN)"
        Me.RbtRect.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbtRect)
        Me.GroupBox2.Controls.Add(Me.RbtTrigle)
        Me.GroupBox2.Controls.Add(Me.RbtSquare)
        Me.GroupBox2.Location = New System.Drawing.Point(762, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 289)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Area"
        '
        'lbGiatri3
        '
        Me.lbGiatri3.AutoSize = True
        Me.lbGiatri3.BackColor = System.Drawing.Color.Transparent
        Me.lbGiatri3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbGiatri3.Location = New System.Drawing.Point(38, 201)
        Me.lbGiatri3.Name = "lbGiatri3"
        Me.lbGiatri3.Size = New System.Drawing.Size(61, 20)
        Me.lbGiatri3.TabIndex = 1
        Me.lbGiatri3.Text = "Giá trị 3"
        '
        'txtGiaTri3
        '
        Me.txtGiaTri3.AccessibleName = ""
        Me.txtGiaTri3.Location = New System.Drawing.Point(38, 224)
        Me.txtGiaTri3.Name = "txtGiaTri3"
        Me.txtGiaTri3.Size = New System.Drawing.Size(125, 27)
        Me.txtGiaTri3.TabIndex = 3
        '
        'LbArea
        '
        Me.LbArea.AutoSize = True
        Me.LbArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbArea.Location = New System.Drawing.Point(762, 364)
        Me.LbArea.Name = "LbArea"
        Me.LbArea.Size = New System.Drawing.Size(47, 20)
        Me.LbArea.TabIndex = 5
        Me.LbArea.Text = "Area :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 547)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbArea)
        Me.Controls.Add(Me.LbResult)
        Me.Controls.Add(Me.btnThucHien)
        Me.Controls.Add(Me.txtGiaTri3)
        Me.Controls.Add(Me.txtGiaTri2)
        Me.Controls.Add(Me.lbGiatri3)
        Me.Controls.Add(Me.txtGiaTri1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nguyễn Đức Cường"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGiaTri1 As TextBox
    Friend WithEvents txtGiaTri2 As TextBox
    Friend WithEvents btnThucHien As Button
    Friend WithEvents LbResult As Label
    Friend WithEvents RbtAdd As RadioButton
    Friend WithEvents RbtSub As RadioButton
    Friend WithEvents RbtMulti As RadioButton
    Friend WithEvents RbtDevice As RadioButton
    Friend WithEvents RbtMod As RadioButton
    Friend WithEvents RbtPower As RadioButton
    Friend WithEvents RbtDiv As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbtSquare As RadioButton
    Friend WithEvents RbtTrigle As RadioButton
    Friend WithEvents RbtRect As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbGiatri3 As Label
    Friend WithEvents txtGiaTri3 As TextBox
    Friend WithEvents LbArea As Label
End Class
