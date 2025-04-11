<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnDBoard = New Guna.UI2.WinForms.Guna2Button()
        Me.imageslider = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnMCourse = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCalen = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageslider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.BorderRadius = 30
        Me.Guna2PictureBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(-3, 138)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(231, 630)
        Me.Guna2PictureBox3.TabIndex = 2
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.White
        Me.mainpanel.Location = New System.Drawing.Point(228, 1)
        Me.mainpanel.MaximumSize = New System.Drawing.Size(989, 768)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(989, 767)
        Me.mainpanel.TabIndex = 7
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(51, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(129, 118)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnDBoard
        '
        Me.btnDBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnDBoard.BorderColor = System.Drawing.Color.Transparent
        Me.btnDBoard.BorderRadius = 26
        Me.btnDBoard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnDBoard.Checked = True
        Me.btnDBoard.CheckedState.BorderColor = System.Drawing.Color.White
        Me.btnDBoard.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnDBoard.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnDBoard.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnDBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDBoard.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDBoard.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDBoard.ForeColor = System.Drawing.Color.White
        Me.btnDBoard.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnDBoard.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnDBoard.HoverState.FillColor = System.Drawing.Color.White
        Me.btnDBoard.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDBoard.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnDBoard.Image = CType(resources.GetObject("btnDBoard.Image"), System.Drawing.Image)
        Me.btnDBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDBoard.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnDBoard.Location = New System.Drawing.Point(12, 223)
        Me.btnDBoard.Name = "btnDBoard"
        Me.btnDBoard.ShadowDecoration.Color = System.Drawing.Color.White
        Me.btnDBoard.Size = New System.Drawing.Size(180, 65)
        Me.btnDBoard.TabIndex = 15
        Me.btnDBoard.Text = "DASHBOARD"
        Me.btnDBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDBoard.UseTransparentBackground = True
        '
        'imageslider
        '
        Me.imageslider.BackColor = System.Drawing.Color.Transparent
        Me.imageslider.Image = CType(resources.GetObject("imageslider.Image"), System.Drawing.Image)
        Me.imageslider.ImageRotate = 0!
        Me.imageslider.Location = New System.Drawing.Point(153, 177)
        Me.imageslider.Name = "imageslider"
        Me.imageslider.Size = New System.Drawing.Size(75, 157)
        Me.imageslider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageslider.TabIndex = 0
        Me.imageslider.TabStop = False
        '
        'btnMCourse
        '
        Me.btnMCourse.BackColor = System.Drawing.Color.Transparent
        Me.btnMCourse.BorderColor = System.Drawing.Color.Transparent
        Me.btnMCourse.BorderRadius = 26
        Me.btnMCourse.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnMCourse.CheckedState.BorderColor = System.Drawing.Color.White
        Me.btnMCourse.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnMCourse.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnMCourse.CheckedState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.btnMCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnMCourse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMCourse.ForeColor = System.Drawing.Color.White
        Me.btnMCourse.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnMCourse.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnMCourse.HoverState.FillColor = System.Drawing.Color.White
        Me.btnMCourse.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnMCourse.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.btnMCourse.Image = CType(resources.GetObject("btnMCourse.Image"), System.Drawing.Image)
        Me.btnMCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMCourse.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnMCourse.Location = New System.Drawing.Point(12, 301)
        Me.btnMCourse.Name = "btnMCourse"
        Me.btnMCourse.ShadowDecoration.Color = System.Drawing.Color.White
        Me.btnMCourse.Size = New System.Drawing.Size(180, 65)
        Me.btnMCourse.TabIndex = 15
        Me.btnMCourse.Text = "MY COURSE"
        Me.btnMCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMCourse.UseTransparentBackground = True
        '
        'btnRes
        '
        Me.btnRes.BackColor = System.Drawing.Color.Transparent
        Me.btnRes.BorderColor = System.Drawing.Color.Transparent
        Me.btnRes.BorderRadius = 26
        Me.btnRes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnRes.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnRes.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnRes.CheckedState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.btnRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRes.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnRes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRes.ForeColor = System.Drawing.Color.White
        Me.btnRes.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnRes.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnRes.HoverState.FillColor = System.Drawing.Color.White
        Me.btnRes.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnRes.HoverState.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.btnRes.Image = CType(resources.GetObject("btnRes.Image"), System.Drawing.Image)
        Me.btnRes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRes.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnRes.Location = New System.Drawing.Point(12, 380)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.ShadowDecoration.Color = System.Drawing.Color.White
        Me.btnRes.Size = New System.Drawing.Size(180, 65)
        Me.btnRes.TabIndex = 16
        Me.btnRes.Text = "RESOURCES"
        Me.btnRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRes.UseTransparentBackground = True
        '
        'btnCalen
        '
        Me.btnCalen.BackColor = System.Drawing.Color.Transparent
        Me.btnCalen.BorderColor = System.Drawing.Color.Transparent
        Me.btnCalen.BorderRadius = 26
        Me.btnCalen.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnCalen.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnCalen.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnCalen.CheckedState.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.btnCalen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCalen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCalen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCalen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCalen.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnCalen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalen.ForeColor = System.Drawing.Color.White
        Me.btnCalen.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnCalen.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnCalen.HoverState.FillColor = System.Drawing.Color.White
        Me.btnCalen.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnCalen.HoverState.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        Me.btnCalen.Image = CType(resources.GetObject("btnCalen.Image"), System.Drawing.Image)
        Me.btnCalen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCalen.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnCalen.Location = New System.Drawing.Point(12, 459)
        Me.btnCalen.Name = "btnCalen"
        Me.btnCalen.ShadowDecoration.Color = System.Drawing.Color.White
        Me.btnCalen.Size = New System.Drawing.Size(180, 65)
        Me.btnCalen.TabIndex = 17
        Me.btnCalen.Text = "CALENDAR"
        Me.btnCalen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCalen.UseTransparentBackground = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1218, 770)
        Me.Controls.Add(Me.btnCalen)
        Me.Controls.Add(Me.btnRes)
        Me.Controls.Add(Me.btnMCourse)
        Me.Controls.Add(Me.btnDBoard)
        Me.Controls.Add(Me.imageslider)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.mainpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TEEM"
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageslider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents mainpanel As Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnDBoard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents imageslider As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnMCourse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCalen As Guna.UI2.WinForms.Guna2Button
End Class
