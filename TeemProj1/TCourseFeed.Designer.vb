<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCourseFeed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TCourseFeed))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.coursenametlbl = New System.Windows.Forms.Label()
        Me.coursecode = New System.Windows.Forms.Label()
        Me.coursegcode = New System.Windows.Forms.Label()
        Me.postTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.streambtn = New Guna.UI2.WinForms.Guna2Button()
        Me.assessbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.cfeedpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.flayoutpanefeed = New System.Windows.Forms.FlowLayoutPanel()
        Me.postbtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button2.Location = New System.Drawing.Point(12, 17)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(41, 36)
        Me.Guna2Button2.TabIndex = 9
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(59, 44)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(137, 123)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 10
        Me.Guna2PictureBox1.TabStop = False
        '
        'coursenametlbl
        '
        Me.coursenametlbl.AutoSize = True
        Me.coursenametlbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursenametlbl.Location = New System.Drawing.Point(202, 44)
        Me.coursenametlbl.Name = "coursenametlbl"
        Me.coursenametlbl.Size = New System.Drawing.Size(76, 23)
        Me.coursenametlbl.TabIndex = 11
        Me.coursenametlbl.Text = "Label1"
        '
        'coursecode
        '
        Me.coursecode.AutoSize = True
        Me.coursecode.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecode.Location = New System.Drawing.Point(202, 104)
        Me.coursecode.Name = "coursecode"
        Me.coursecode.Size = New System.Drawing.Size(56, 18)
        Me.coursecode.TabIndex = 12
        Me.coursecode.Text = "Label2"
        '
        'coursegcode
        '
        Me.coursegcode.AutoSize = True
        Me.coursegcode.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursegcode.Location = New System.Drawing.Point(202, 133)
        Me.coursegcode.Name = "coursegcode"
        Me.coursegcode.Size = New System.Drawing.Size(56, 18)
        Me.coursegcode.TabIndex = 13
        Me.coursegcode.Text = "Label3"
        '
        'postTxt
        '
        Me.postTxt.AcceptsReturn = True
        Me.postTxt.AcceptsTab = True
        Me.postTxt.AutoScroll = True
        Me.postTxt.AutoSize = True
        Me.postTxt.BorderRadius = 15
        Me.postTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.postTxt.DefaultText = ""
        Me.postTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.postTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.postTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.postTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.postTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.postTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.postTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.postTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.postTxt.IconRight = CType(resources.GetObject("postTxt.IconRight"), System.Drawing.Image)
        Me.postTxt.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.postTxt.IconRightSize = New System.Drawing.Size(30, 30)
        Me.postTxt.Location = New System.Drawing.Point(59, 240)
        Me.postTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.postTxt.Multiline = True
        Me.postTxt.Name = "postTxt"
        Me.postTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.postTxt.PlaceholderText = "Write something..."
        Me.postTxt.SelectedText = ""
        Me.postTxt.Size = New System.Drawing.Size(464, 48)
        Me.postTxt.TabIndex = 17
        '
        'streambtn
        '
        Me.streambtn.BackColor = System.Drawing.Color.Transparent
        Me.streambtn.BorderColor = System.Drawing.Color.Transparent
        Me.streambtn.BorderRadius = 15
        Me.streambtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.streambtn.Checked = True
        Me.streambtn.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.streambtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.streambtn.CheckedState.FillColor = System.Drawing.Color.White
        Me.streambtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.streambtn.CheckedState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.streambtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.streambtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.streambtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.streambtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.streambtn.FillColor = System.Drawing.Color.Transparent
        Me.streambtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.streambtn.ForeColor = System.Drawing.Color.Black
        Me.streambtn.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.streambtn.Location = New System.Drawing.Point(30, 173)
        Me.streambtn.Name = "streambtn"
        Me.streambtn.Size = New System.Drawing.Size(126, 45)
        Me.streambtn.TabIndex = 18
        Me.streambtn.Text = "Stream"
        '
        'assessbtn
        '
        Me.assessbtn.BackColor = System.Drawing.Color.Transparent
        Me.assessbtn.BorderColor = System.Drawing.Color.Transparent
        Me.assessbtn.BorderRadius = 15
        Me.assessbtn.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.assessbtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.assessbtn.CheckedState.FillColor = System.Drawing.Color.White
        Me.assessbtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.assessbtn.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.assessbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.assessbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.assessbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.assessbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.assessbtn.FillColor = System.Drawing.Color.Transparent
        Me.assessbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.assessbtn.ForeColor = System.Drawing.Color.Black
        Me.assessbtn.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.assessbtn.Location = New System.Drawing.Point(171, 173)
        Me.assessbtn.Name = "assessbtn"
        Me.assessbtn.Size = New System.Drawing.Size(166, 45)
        Me.assessbtn.TabIndex = 19
        Me.assessbtn.Text = "Assessment"
        '
        'cfeedpanel
        '
        Me.cfeedpanel.Location = New System.Drawing.Point(30, 224)
        Me.cfeedpanel.Name = "cfeedpanel"
        Me.cfeedpanel.Size = New System.Drawing.Size(580, 429)
        Me.cfeedpanel.TabIndex = 20
        '
        'flayoutpanefeed
        '
        Me.flayoutpanefeed.AutoScroll = True
        Me.flayoutpanefeed.Location = New System.Drawing.Point(30, 317)
        Me.flayoutpanefeed.Name = "flayoutpanefeed"
        Me.flayoutpanefeed.Size = New System.Drawing.Size(580, 336)
        Me.flayoutpanefeed.TabIndex = 0
        '
        'postbtn
        '
        Me.postbtn.BorderRadius = 15
        Me.postbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.postbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.postbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.postbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.postbtn.FillColor = System.Drawing.Color.Transparent
        Me.postbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postbtn.ForeColor = System.Drawing.Color.Black
        Me.postbtn.Location = New System.Drawing.Point(532, 242)
        Me.postbtn.Name = "postbtn"
        Me.postbtn.Size = New System.Drawing.Size(78, 45)
        Me.postbtn.TabIndex = 22
        Me.postbtn.Text = "POST"
        '
        'TCourseFeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 652)
        Me.Controls.Add(Me.flayoutpanefeed)
        Me.Controls.Add(Me.cfeedpanel)
        Me.Controls.Add(Me.postTxt)
        Me.Controls.Add(Me.assessbtn)
        Me.Controls.Add(Me.streambtn)
        Me.Controls.Add(Me.coursegcode)
        Me.Controls.Add(Me.coursecode)
        Me.Controls.Add(Me.coursenametlbl)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.postbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TCourseFeed"
        Me.Text = "TCourseFeed"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents coursegcode As Label
    Friend WithEvents coursecode As Label
    Friend WithEvents coursenametlbl As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents postTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents streambtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents assessbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cfeedpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flayoutpanefeed As FlowLayoutPanel
    Friend WithEvents postbtn As Guna.UI2.WinForms.Guna2Button
End Class
