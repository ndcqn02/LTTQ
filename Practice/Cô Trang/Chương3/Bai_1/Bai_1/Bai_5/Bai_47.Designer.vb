<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bai_47
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
        Me.nhiphan_71 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lam_moi_71
        '
        Me.lam_moi_71.Location = New System.Drawing.Point(179, 268)
        Me.lam_moi_71.Margin = New System.Windows.Forms.Padding(4)
        Me.lam_moi_71.Name = "lam_moi_71"
        Me.lam_moi_71.Size = New System.Drawing.Size(116, 50)
        Me.lam_moi_71.TabIndex = 26
        Me.lam_moi_71.Text = "Làm mới"
        Me.lam_moi_71.UseVisualStyleBackColor = True
        '
        'thuc_hien_71
        '
        Me.thuc_hien_71.Location = New System.Drawing.Point(357, 268)
        Me.thuc_hien_71.Margin = New System.Windows.Forms.Padding(4)
        Me.thuc_hien_71.Name = "thuc_hien_71"
        Me.thuc_hien_71.Size = New System.Drawing.Size(116, 50)
        Me.thuc_hien_71.TabIndex = 27
        Me.thuc_hien_71.Text = "Thực hiện"
        Me.thuc_hien_71.UseVisualStyleBackColor = True
        '
        'ket_qua_71
        '
        Me.ket_qua_71.AutoSize = True
        Me.ket_qua_71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ket_qua_71.Location = New System.Drawing.Point(44, 199)
        Me.ket_qua_71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ket_qua_71.Name = "ket_qua_71"
        Me.ket_qua_71.Size = New System.Drawing.Size(130, 20)
        Me.ket_qua_71.TabIndex = 24
        Me.ket_qua_71.Text = "=> Thập phân:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Số thập lục phân:"
        '
        'nhiphan_71
        '
        Me.nhiphan_71.Location = New System.Drawing.Point(221, 143)
        Me.nhiphan_71.Margin = New System.Windows.Forms.Padding(4)
        Me.nhiphan_71.Name = "nhiphan_71"
        Me.nhiphan_71.Size = New System.Drawing.Size(240, 22)
        Me.nhiphan_71.TabIndex = 23
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.label2.Location = New System.Drawing.Point(60, 26)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(375, 24)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Đổi 1 số thập lục phân sang thập phân"
        '
        'Bai_47
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 345)
        Me.Controls.Add(Me.lam_moi_71)
        Me.Controls.Add(Me.thuc_hien_71)
        Me.Controls.Add(Me.ket_qua_71)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nhiphan_71)
        Me.Controls.Add(Me.label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Bai_47"
        Me.Text = "Hân-71_Bai_47"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lam_moi_71 As System.Windows.Forms.Button
    Friend WithEvents thuc_hien_71 As System.Windows.Forms.Button
    Friend WithEvents ket_qua_71 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nhiphan_71 As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
End Class
