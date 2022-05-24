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
        Me.cuong_11_ListBoxLeft = New System.Windows.Forms.ListBox()
        Me.cuong_11_ListBoxRight = New System.Windows.Forms.ListBox()
        Me.cuong_11_btnSwitchOver = New System.Windows.Forms.Button()
        Me.cuong_11_btnOverAll = New System.Windows.Forms.Button()
        Me.cuong_11_btnSwitchBack = New System.Windows.Forms.Button()
        Me.cuong_11btnBackAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cuong_11_ListBoxLeft
        '
        Me.cuong_11_ListBoxLeft.AccessibleName = ""
        Me.cuong_11_ListBoxLeft.FormattingEnabled = True
        Me.cuong_11_ListBoxLeft.ItemHeight = 20
        Me.cuong_11_ListBoxLeft.Items.AddRange(New Object() {"Nguyễn Đức Cường", "Nguyễn Văn A", "Nguyễn Văn B", "Trần Văn A", "Trần Văn B", "Nguyễn Văn C"})
        Me.cuong_11_ListBoxLeft.Location = New System.Drawing.Point(109, 99)
        Me.cuong_11_ListBoxLeft.Name = "cuong_11_ListBoxLeft"
        Me.cuong_11_ListBoxLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.cuong_11_ListBoxLeft.Size = New System.Drawing.Size(150, 184)
        Me.cuong_11_ListBoxLeft.TabIndex = 0
        '
        'cuong_11_ListBoxRight
        '
        Me.cuong_11_ListBoxRight.FormattingEnabled = True
        Me.cuong_11_ListBoxRight.ItemHeight = 20
        Me.cuong_11_ListBoxRight.Location = New System.Drawing.Point(448, 99)
        Me.cuong_11_ListBoxRight.Name = "cuong_11_ListBoxRight"
        Me.cuong_11_ListBoxRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.cuong_11_ListBoxRight.Size = New System.Drawing.Size(150, 184)
        Me.cuong_11_ListBoxRight.TabIndex = 1
        '
        'cuong_11_btnSwitchOver
        '
        Me.cuong_11_btnSwitchOver.Location = New System.Drawing.Point(302, 99)
        Me.cuong_11_btnSwitchOver.Name = "cuong_11_btnSwitchOver"
        Me.cuong_11_btnSwitchOver.Size = New System.Drawing.Size(94, 29)
        Me.cuong_11_btnSwitchOver.TabIndex = 2
        Me.cuong_11_btnSwitchOver.Text = ">"
        Me.cuong_11_btnSwitchOver.UseVisualStyleBackColor = True
        '
        'cuong_11_btnOverAll
        '
        Me.cuong_11_btnOverAll.Location = New System.Drawing.Point(302, 143)
        Me.cuong_11_btnOverAll.Name = "cuong_11_btnOverAll"
        Me.cuong_11_btnOverAll.Size = New System.Drawing.Size(94, 29)
        Me.cuong_11_btnOverAll.TabIndex = 3
        Me.cuong_11_btnOverAll.Text = ">>"
        Me.cuong_11_btnOverAll.UseVisualStyleBackColor = True
        '
        'cuong_11_btnSwitchBack
        '
        Me.cuong_11_btnSwitchBack.Location = New System.Drawing.Point(302, 188)
        Me.cuong_11_btnSwitchBack.Name = "cuong_11_btnSwitchBack"
        Me.cuong_11_btnSwitchBack.Size = New System.Drawing.Size(94, 29)
        Me.cuong_11_btnSwitchBack.TabIndex = 4
        Me.cuong_11_btnSwitchBack.Text = "<"
        Me.cuong_11_btnSwitchBack.UseVisualStyleBackColor = True
        '
        'cuong_11btnBackAll
        '
        Me.cuong_11btnBackAll.Location = New System.Drawing.Point(302, 235)
        Me.cuong_11btnBackAll.Name = "cuong_11btnBackAll"
        Me.cuong_11btnBackAll.Size = New System.Drawing.Size(94, 29)
        Me.cuong_11btnBackAll.TabIndex = 5
        Me.cuong_11btnBackAll.Text = "<<"
        Me.cuong_11btnBackAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cuong_11btnBackAll)
        Me.Controls.Add(Me.cuong_11_btnSwitchBack)
        Me.Controls.Add(Me.cuong_11_btnOverAll)
        Me.Controls.Add(Me.cuong_11_btnSwitchOver)
        Me.Controls.Add(Me.cuong_11_ListBoxRight)
        Me.Controls.Add(Me.cuong_11_ListBoxLeft)
        Me.Name = "Form1"
        Me.Text = "Nguyễn Đức Cường_MSV 2050531200110"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cuong_11_ListBoxLeft As ListBox
    Friend WithEvents cuong_11_ListBoxRight As ListBox
    Friend WithEvents cuong_11_btnSwitchOver As Button
    Friend WithEvents cuong_11_btnOverAll As Button
    Friend WithEvents cuong_11_btnSwitchBack As Button
    Friend WithEvents cuong_11btnBackAll As Button
End Class
