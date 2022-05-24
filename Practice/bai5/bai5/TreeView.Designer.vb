<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeView
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreeView))
        Me.TV = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.btnChuyen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TV
        '
        Me.TV.ImageIndex = 0
        Me.TV.ImageList = Me.ImageList1
        Me.TV.Location = New System.Drawing.Point(26, 69)
        Me.TV.Name = "TV"
        Me.TV.SelectedImageIndex = 0
        Me.TV.Size = New System.Drawing.Size(253, 354)
        Me.TV.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "anh.png")
        Me.ImageList1.Images.SetKeyName(1, "anh.png")
        '
        'lv1
        '
        Me.lv1.Location = New System.Drawing.Point(441, 68)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(269, 355)
        Me.lv1.TabIndex = 1
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'btnChuyen
        '
        Me.btnChuyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnChuyen.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnChuyen.Location = New System.Drawing.Point(732, 11)
        Me.btnChuyen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChuyen.Name = "btnChuyen"
        Me.btnChuyen.Size = New System.Drawing.Size(70, 37)
        Me.btnChuyen.TabIndex = 17
        Me.btnChuyen.Text = "Chuyển tab"
        Me.btnChuyen.UseVisualStyleBackColor = True
        '
        'TreeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(827, 469)
        Me.Controls.Add(Me.btnChuyen)
        Me.Controls.Add(Me.lv1)
        Me.Controls.Add(Me.TV)
        Me.Name = "TreeView"
        Me.Text = "TreeView"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TV As System.Windows.Forms.TreeView
    Friend WithEvents lv1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnChuyen As System.Windows.Forms.Button
End Class
