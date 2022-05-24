<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckListBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckListBox))
        Me.btnchoice = New System.Windows.Forms.Button()
        Me.LabelShow = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'btnchoice
        '
        Me.btnchoice.Location = New System.Drawing.Point(225, 291)
        Me.btnchoice.Margin = New System.Windows.Forms.Padding(2)
        Me.btnchoice.Name = "btnchoice"
        Me.btnchoice.Size = New System.Drawing.Size(152, 28)
        Me.btnchoice.TabIndex = 7
        Me.btnchoice.Text = "Chọn danh sách "
        Me.btnchoice.UseVisualStyleBackColor = True
        '
        'LabelShow
        '
        Me.LabelShow.AutoSize = True
        Me.LabelShow.Location = New System.Drawing.Point(389, 85)
        Me.LabelShow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelShow.Name = "LabelShow"
        Me.LabelShow.Size = New System.Drawing.Size(0, 15)
        Me.LabelShow.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Danh sách được chọn:"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(79, 57)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(181, 199)
        Me.CheckedListBox1.TabIndex = 4
        '
        'CheckListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(712, 360)
        Me.Controls.Add(Me.btnchoice)
        Me.Controls.Add(Me.LabelShow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Name = "CheckListBox"
        Me.Text = "3.2 CheckListBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnchoice As System.Windows.Forms.Button
    Friend WithEvents LabelShow As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
End Class
