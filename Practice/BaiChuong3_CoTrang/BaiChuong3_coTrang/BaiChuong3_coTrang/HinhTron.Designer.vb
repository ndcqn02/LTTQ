<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HinhTron
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.ketQua = New System.Windows.Forms.Label()
        Me.Calculator = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập bán kính:"
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(291, 105)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(153, 22)
        Me.txtR.TabIndex = 1
        '
        'ketQua
        '
        Me.ketQua.AutoSize = True
        Me.ketQua.Location = New System.Drawing.Point(288, 202)
        Me.ketQua.Name = "ketQua"
        Me.ketQua.Size = New System.Drawing.Size(104, 17)
        Me.ketQua.TabIndex = 0
        Me.ketQua.Text = "Nhập bán kính:"
        '
        'Calculator
        '
        Me.Calculator.Location = New System.Drawing.Point(145, 173)
        Me.Calculator.Name = "Calculator"
        Me.Calculator.Size = New System.Drawing.Size(117, 56)
        Me.Calculator.TabIndex = 2
        Me.Calculator.Text = "Tính"
        Me.Calculator.UseVisualStyleBackColor = True
        '
        'HinhTron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 436)
        Me.Controls.Add(Me.Calculator)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.ketQua)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HinhTron"
        Me.Text = "HinhTron"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents ketQua As System.Windows.Forms.Label
    Friend WithEvents Calculator As System.Windows.Forms.Button
End Class
