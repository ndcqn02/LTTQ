﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bai_36
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
        Me.ket_qua_71 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(43, 196)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Nhập n:"
        '
        'thuc_hien_71
        '
        Me.thuc_hien_71.Location = New System.Drawing.Point(345, 224)
        Me.thuc_hien_71.Margin = New System.Windows.Forms.Padding(4)
        Me.thuc_hien_71.Name = "thuc_hien_71"
        Me.thuc_hien_71.Size = New System.Drawing.Size(116, 53)
        Me.thuc_hien_71.TabIndex = 62
        Me.thuc_hien_71.Text = "Thực hiện"
        Me.thuc_hien_71.UseVisualStyleBackColor = True
        '
        'lam_moi_71
        '
        Me.lam_moi_71.Location = New System.Drawing.Point(345, 143)
        Me.lam_moi_71.Margin = New System.Windows.Forms.Padding(4)
        Me.lam_moi_71.Name = "lam_moi_71"
        Me.lam_moi_71.Size = New System.Drawing.Size(116, 53)
        Me.lam_moi_71.TabIndex = 63
        Me.lam_moi_71.Text = "Làm mới"
        Me.lam_moi_71.UseVisualStyleBackColor = True
        '
        'n_71
        '
        Me.n_71.Location = New System.Drawing.Point(128, 192)
        Me.n_71.Margin = New System.Windows.Forms.Padding(4)
        Me.n_71.Name = "n_71"
        Me.n_71.Size = New System.Drawing.Size(132, 22)
        Me.n_71.TabIndex = 61
        '
        'ket_qua_71
        '
        Me.ket_qua_71.AutoSize = True
        Me.ket_qua_71.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ket_qua_71.Location = New System.Drawing.Point(16, 42)
        Me.ket_qua_71.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ket_qua_71.Name = "ket_qua_71"
        Me.ket_qua_71.Size = New System.Drawing.Size(376, 29)
        Me.ket_qua_71.TabIndex = 60
        Me.ket_qua_71.Text = "Cho biết n có bao nhiêu chữ số"
        '
        'Bai_36
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 321)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.thuc_hien_71)
        Me.Controls.Add(Me.lam_moi_71)
        Me.Controls.Add(Me.n_71)
        Me.Controls.Add(Me.ket_qua_71)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Bai_36"
        Me.Text = "Hân-71_Bai_36"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents thuc_hien_71 As System.Windows.Forms.Button
    Friend WithEvents lam_moi_71 As System.Windows.Forms.Button
    Friend WithEvents n_71 As System.Windows.Forms.TextBox
    Friend WithEvents ket_qua_71 As System.Windows.Forms.Label
End Class
