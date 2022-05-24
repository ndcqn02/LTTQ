<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bai_25
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.thuc_hien_71 = New System.Windows.Forms.Button()
        Me.lam_moi_71 = New System.Windows.Forms.Button()
        Me.n_71 = New System.Windows.Forms.TextBox()
        Me.ket_qua_14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dayso_14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(36, 202)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nhập n:"
        '
        'thuc_hien_71
        '
        Me.thuc_hien_71.Location = New System.Drawing.Point(339, 230)
        Me.thuc_hien_71.Margin = New System.Windows.Forms.Padding(4)
        Me.thuc_hien_71.Name = "thuc_hien_71"
        Me.thuc_hien_71.Size = New System.Drawing.Size(116, 53)
        Me.thuc_hien_71.TabIndex = 63
        Me.thuc_hien_71.Text = "Thực hiện"
        Me.thuc_hien_71.UseVisualStyleBackColor = True
        '
        'lam_moi_71
        '
        Me.lam_moi_71.Location = New System.Drawing.Point(339, 149)
        Me.lam_moi_71.Margin = New System.Windows.Forms.Padding(4)
        Me.lam_moi_71.Name = "lam_moi_71"
        Me.lam_moi_71.Size = New System.Drawing.Size(116, 53)
        Me.lam_moi_71.TabIndex = 64
        Me.lam_moi_71.Text = "Làm mới"
        Me.lam_moi_71.UseVisualStyleBackColor = True
        '
        'n_71
        '
        Me.n_71.Location = New System.Drawing.Point(121, 198)
        Me.n_71.Margin = New System.Windows.Forms.Padding(4)
        Me.n_71.Name = "n_71"
        Me.n_71.Size = New System.Drawing.Size(132, 22)
        Me.n_71.TabIndex = 62
        '
        'ket_qua_14
        '
        Me.ket_qua_14.AutoSize = True
        Me.ket_qua_14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ket_qua_14.Location = New System.Drawing.Point(116, 80)
        Me.ket_qua_14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ket_qua_14.Name = "ket_qua_14"
        Me.ket_qua_14.Size = New System.Drawing.Size(142, 29)
        Me.ket_qua_14.TabIndex = 59
        Me.ket_qua_14.Text = "ket_qua_71"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(31, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 27)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "=> S="
        '
        'dayso_14
        '
        Me.dayso_14.AutoSize = True
        Me.dayso_14.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.dayso_14.Location = New System.Drawing.Point(31, 38)
        Me.dayso_14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dayso_14.Name = "dayso_14"
        Me.dayso_14.Size = New System.Drawing.Size(70, 27)
        Me.dayso_14.TabIndex = 61
        Me.dayso_14.Text = "S= ..."
        '
        'Bai_25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 321)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.thuc_hien_71)
        Me.Controls.Add(Me.lam_moi_71)
        Me.Controls.Add(Me.n_71)
        Me.Controls.Add(Me.ket_qua_14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dayso_14)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Bai_25"
        Me.Text = "Hân-71_Bai_25"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents thuc_hien_71 As System.Windows.Forms.Button
    Friend WithEvents lam_moi_71 As System.Windows.Forms.Button
    Friend WithEvents n_71 As System.Windows.Forms.TextBox
    Friend WithEvents ket_qua_14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dayso_14 As System.Windows.Forms.Label
End Class
