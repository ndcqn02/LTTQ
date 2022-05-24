<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bai_48
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
        Me.lam_moi_71 = New System.Windows.Forms.Button()
        Me.thuc_hien_71 = New System.Windows.Forms.Button()
        Me.ket_qua_71 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chuoi_71 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lam_moi_71
        '
        Me.lam_moi_71.Location = New System.Drawing.Point(148, 273)
        Me.lam_moi_71.Margin = New System.Windows.Forms.Padding(4)
        Me.lam_moi_71.Name = "lam_moi_71"
        Me.lam_moi_71.Size = New System.Drawing.Size(116, 50)
        Me.lam_moi_71.TabIndex = 8
        Me.lam_moi_71.Text = "Làm mới"
        Me.lam_moi_71.UseVisualStyleBackColor = True
        '
        'thuc_hien_71
        '
        Me.thuc_hien_71.Location = New System.Drawing.Point(327, 273)
        Me.thuc_hien_71.Margin = New System.Windows.Forms.Padding(4)
        Me.thuc_hien_71.Name = "thuc_hien_71"
        Me.thuc_hien_71.Size = New System.Drawing.Size(116, 50)
        Me.thuc_hien_71.TabIndex = 9
        Me.thuc_hien_71.Text = "Thực hiện"
        Me.thuc_hien_71.UseVisualStyleBackColor = True
        '
        'ket_qua_71
        '
        Me.ket_qua_71.AutoSize = True
        Me.ket_qua_71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ket_qua_71.Location = New System.Drawing.Point(44, 208)
        Me.ket_qua_71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ket_qua_71.Name = "ket_qua_71"
        Me.ket_qua_71.Size = New System.Drawing.Size(31, 20)
        Me.ket_qua_71.TabIndex = 6
        Me.ket_qua_71.Text = "=>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nhập chuỗi:"
        '
        'chuoi_71
        '
        Me.chuoi_71.Location = New System.Drawing.Point(159, 151)
        Me.chuoi_71.Margin = New System.Windows.Forms.Padding(4)
        Me.chuoi_71.Name = "chuoi_71"
        Me.chuoi_71.Size = New System.Drawing.Size(317, 22)
        Me.chuoi_71.TabIndex = 5
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.label2.Location = New System.Drawing.Point(29, 31)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(174, 24)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Đảo ngược chuỗi"
        '
        'Bai_48
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 368)
        Me.Controls.Add(Me.lam_moi_71)
        Me.Controls.Add(Me.thuc_hien_71)
        Me.Controls.Add(Me.ket_qua_71)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chuoi_71)
        Me.Controls.Add(Me.label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Bai_48"
        Me.Text = "Hân-71_Bai_48"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lam_moi_71 As System.Windows.Forms.Button
    Friend WithEvents thuc_hien_71 As System.Windows.Forms.Button
    Friend WithEvents ket_qua_71 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chuoi_71 As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
End Class
