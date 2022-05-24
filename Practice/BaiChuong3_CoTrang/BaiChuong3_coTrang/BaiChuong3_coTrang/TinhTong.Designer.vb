<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TinhTong
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.ketqua = New System.Windows.Forms.Label()
        Me.calculator = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tính tổng: 1+ 2+ 3 + 4 +5 + ...+  n"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập n:"
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(191, 122)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(100, 22)
        Me.txtn.TabIndex = 2
        '
        'ketqua
        '
        Me.ketqua.AutoSize = True
        Me.ketqua.Location = New System.Drawing.Point(233, 204)
        Me.ketqua.Name = "ketqua"
        Me.ketqua.Size = New System.Drawing.Size(58, 17)
        Me.ketqua.TabIndex = 1
        Me.ketqua.Text = "Nhập n:"
        '
        'calculator
        '
        Me.calculator.Location = New System.Drawing.Point(97, 186)
        Me.calculator.Name = "calculator"
        Me.calculator.Size = New System.Drawing.Size(117, 53)
        Me.calculator.TabIndex = 3
        Me.calculator.Text = "Tính"
        Me.calculator.UseVisualStyleBackColor = True
        '
        'TinhTong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 337)
        Me.Controls.Add(Me.calculator)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.ketqua)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TinhTong"
        Me.Text = "TinhTong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents ketqua As System.Windows.Forms.Label
    Friend WithEvents calculator As System.Windows.Forms.Button
End Class
