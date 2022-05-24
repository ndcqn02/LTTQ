<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HinhThang
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
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.txtDL = New System.Windows.Forms.TextBox()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.ketQua = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculator
        '
        Me.btnCalculator.Location = New System.Drawing.Point(143, 239)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(108, 45)
        Me.btnCalculator.TabIndex = 0
        Me.btnCalculator.Text = "Tính"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nhập đáy lớn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập đáy bé:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nhập chiều cao:"
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(333, 138)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(124, 22)
        Me.txtDB.TabIndex = 2
        '
        'txtDL
        '
        Me.txtDL.Location = New System.Drawing.Point(333, 111)
        Me.txtDL.Name = "txtDL"
        Me.txtDL.Size = New System.Drawing.Size(124, 22)
        Me.txtDL.TabIndex = 2
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(333, 168)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(124, 22)
        Me.txtCC.TabIndex = 2
        '
        'ketQua
        '
        Me.ketQua.AutoSize = True
        Me.ketQua.Location = New System.Drawing.Point(346, 253)
        Me.ketQua.Name = "ketQua"
        Me.ketQua.Size = New System.Drawing.Size(0, 17)
        Me.ketQua.TabIndex = 1
        '
        'HinhThang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 421)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.txtDL)
        Me.Controls.Add(Me.txtDB)
        Me.Controls.Add(Me.ketQua)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculator)
        Me.Name = "HinhThang"
        Me.Text = "HinhThang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculator As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDB As System.Windows.Forms.TextBox
    Friend WithEvents txtDL As System.Windows.Forms.TextBox
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents ketQua As System.Windows.Forms.Label
End Class
