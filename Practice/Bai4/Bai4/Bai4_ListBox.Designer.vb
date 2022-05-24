<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListBox))
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMoveOverAll = New System.Windows.Forms.Button()
        Me.btnMoveOver = New System.Windows.Forms.Button()
        Me.btnDoubleSwitching = New System.Windows.Forms.Button()
        Me.btnDoubleSwitchingALL = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.Location = New System.Drawing.Point(441, 37)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(46, 32)
        Me.btnReset.TabIndex = 6
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 45)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox1.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(353, 35)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 28)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnMoveOverAll)
        Me.Panel1.Controls.Add(Me.btnMoveOver)
        Me.Panel1.Controls.Add(Me.btnDoubleSwitching)
        Me.Panel1.Controls.Add(Me.btnDoubleSwitchingALL)
        Me.Panel1.Location = New System.Drawing.Point(47, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 383)
        Me.Panel1.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Nguyễn Đức Cường", "Nguyễn Văn Danh", "Nguyễn Minh Huy", "Trần Văn B", "Nguyễn Văn A"})
        Me.ListBox1.Location = New System.Drawing.Point(16, 93)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(148, 212)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(380, 93)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox2.Size = New System.Drawing.Size(148, 212)
        Me.ListBox2.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(262, 37)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 28)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMoveOverAll
        '
        Me.btnMoveOverAll.BackColor = System.Drawing.Color.PaleGreen
        Me.btnMoveOverAll.Location = New System.Drawing.Point(238, 187)
        Me.btnMoveOverAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMoveOverAll.Name = "btnMoveOverAll"
        Me.btnMoveOverAll.Size = New System.Drawing.Size(56, 31)
        Me.btnMoveOverAll.TabIndex = 2
        Me.btnMoveOverAll.Text = ">>"
        Me.btnMoveOverAll.UseVisualStyleBackColor = False
        '
        'btnMoveOver
        '
        Me.btnMoveOver.BackColor = System.Drawing.Color.Green
        Me.btnMoveOver.Location = New System.Drawing.Point(238, 93)
        Me.btnMoveOver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMoveOver.Name = "btnMoveOver"
        Me.btnMoveOver.Size = New System.Drawing.Size(56, 29)
        Me.btnMoveOver.TabIndex = 1
        Me.btnMoveOver.Text = ">"
        Me.btnMoveOver.UseVisualStyleBackColor = False
        '
        'btnDoubleSwitching
        '
        Me.btnDoubleSwitching.BackColor = System.Drawing.Color.Green
        Me.btnDoubleSwitching.Location = New System.Drawing.Point(238, 141)
        Me.btnDoubleSwitching.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDoubleSwitching.Name = "btnDoubleSwitching"
        Me.btnDoubleSwitching.Size = New System.Drawing.Size(56, 31)
        Me.btnDoubleSwitching.TabIndex = 2
        Me.btnDoubleSwitching.Text = "<"
        Me.btnDoubleSwitching.UseVisualStyleBackColor = False
        '
        'btnDoubleSwitchingALL
        '
        Me.btnDoubleSwitchingALL.BackColor = System.Drawing.Color.PaleGreen
        Me.btnDoubleSwitchingALL.Location = New System.Drawing.Point(238, 241)
        Me.btnDoubleSwitchingALL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDoubleSwitchingALL.Name = "btnDoubleSwitchingALL"
        Me.btnDoubleSwitchingALL.Size = New System.Drawing.Size(56, 28)
        Me.btnDoubleSwitchingALL.TabIndex = 2
        Me.btnDoubleSwitchingALL.Text = "<<"
        Me.btnDoubleSwitchingALL.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(646, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Chuyển tab"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(733, 483)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ListBox"
        Me.Text = "Bai4_ListBox"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnMoveOverAll As System.Windows.Forms.Button
    Friend WithEvents btnMoveOver As System.Windows.Forms.Button
    Friend WithEvents btnDoubleSwitching As System.Windows.Forms.Button
    Friend WithEvents btnDoubleSwitchingALL As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
