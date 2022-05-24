<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnHinhThang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHinhTron = New System.Windows.Forms.Button()
        Me.btnTong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHinhThang
        '
        Me.btnHinhThang.Location = New System.Drawing.Point(48, 220)
        Me.btnHinhThang.Name = "btnHinhThang"
        Me.btnHinhThang.Size = New System.Drawing.Size(199, 81)
        Me.btnHinhThang.TabIndex = 0
        Me.btnHinhThang.Text = "Diện tích hình thang"
        Me.btnHinhThang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(314, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'btnHinhTron
        '
        Me.btnHinhTron.Location = New System.Drawing.Point(306, 220)
        Me.btnHinhTron.Name = "btnHinhTron"
        Me.btnHinhTron.Size = New System.Drawing.Size(199, 81)
        Me.btnHinhTron.TabIndex = 0
        Me.btnHinhTron.Text = "Diện tích hình tròn"
        Me.btnHinhTron.UseVisualStyleBackColor = True
        '
        'btnTong
        '
        Me.btnTong.Location = New System.Drawing.Point(557, 220)
        Me.btnTong.Name = "btnTong"
        Me.btnTong.Size = New System.Drawing.Size(199, 81)
        Me.btnTong.TabIndex = 0
        Me.btnTong.Text = "Tính tổng"
        Me.btnTong.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 441)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTong)
        Me.Controls.Add(Me.btnHinhTron)
        Me.Controls.Add(Me.btnHinhThang)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHinhThang As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHinhTron As System.Windows.Forms.Button
    Friend WithEvents btnTong As System.Windows.Forms.Button

End Class
