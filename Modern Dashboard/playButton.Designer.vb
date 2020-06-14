<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class playButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(playButton))
        Me.BunifuImageBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.BunifuImageBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuImageBtn
        '
        Me.BunifuImageBtn.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageBtn.Image = CType(resources.GetObject("BunifuImageBtn.Image"), System.Drawing.Image)
        Me.BunifuImageBtn.ImageActive = Nothing
        Me.BunifuImageBtn.Location = New System.Drawing.Point(21, 12)
        Me.BunifuImageBtn.Name = "BunifuImageBtn"
        Me.BunifuImageBtn.Size = New System.Drawing.Size(31, 29)
        Me.BunifuImageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageBtn.TabIndex = 0
        Me.BunifuImageBtn.TabStop = False
        Me.BunifuImageBtn.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(64, 18)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(91, 17)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "1. Song Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(237, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 53)
        Me.Panel1.TabIndex = 3
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(143, 19)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(32, 17)
        Me.BunifuCustomLabel3.TabIndex = 4
        Me.BunifuCustomLabel3.Text = "4:59"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(15, 19)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(86, 17)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Weird Genius"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Controls.Add(Me.BunifuImageBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(73, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(164, 53)
        Me.Panel2.TabIndex = 4
        '
        'playButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "playButton"
        Me.Size = New System.Drawing.Size(435, 53)
        CType(Me.BunifuImageBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuImageBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel

End Class
