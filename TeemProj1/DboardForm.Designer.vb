<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DboardForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DboardForm))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.studname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBcourses = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.UpdatePanel = New System.Windows.Forms.Panel()
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.dropdownpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.courpan = New System.Windows.Forms.Panel()
        Me.profilebtn = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.profilebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hello,  "
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(671, 133)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 7
        '
        'studname
        '
        Me.studname.AutoSize = True
        Me.studname.Font = New System.Drawing.Font("Britannic Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studname.Location = New System.Drawing.Point(175, 148)
        Me.studname.Name = "studname"
        Me.studname.Size = New System.Drawing.Size(0, 48)
        Me.studname.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "You have"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "()"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "lectures for today."
        '
        'btnBcourses
        '
        Me.btnBcourses.BackColor = System.Drawing.Color.Transparent
        Me.btnBcourses.BorderRadius = 15
        Me.btnBcourses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBcourses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBcourses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBcourses.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBcourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBcourses.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBcourses.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnBcourses.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBcourses.ForeColor = System.Drawing.Color.White
        Me.btnBcourses.Location = New System.Drawing.Point(43, 238)
        Me.btnBcourses.Name = "btnBcourses"
        Me.btnBcourses.Size = New System.Drawing.Size(163, 46)
        Me.btnBcourses.TabIndex = 12
        Me.btnBcourses.Text = "Browse Courses"
        Me.btnBcourses.UseTransparentBackground = True
        '
        'UpdatePanel
        '
        Me.UpdatePanel.Location = New System.Drawing.Point(633, 494)
        Me.UpdatePanel.Name = "UpdatePanel"
        Me.UpdatePanel.Size = New System.Drawing.Size(300, 227)
        Me.UpdatePanel.TabIndex = 29
        '
        'Guna2CircleButton2
        '
        Me.Guna2CircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.BackgroundImage = CType(resources.GetObject("Guna2CircleButton2.BackgroundImage"), System.Drawing.Image)
        Me.Guna2CircleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton2.Location = New System.Drawing.Point(746, 25)
        Me.Guna2CircleButton2.Name = "Guna2CircleButton2"
        Me.Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton2.Size = New System.Drawing.Size(50, 50)
        Me.Guna2CircleButton2.TabIndex = 31
        Me.Guna2CircleButton2.UseTransparentBackground = True
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.BackgroundImage = CType(resources.GetObject("Guna2CircleButton1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(805, 24)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(50, 50)
        Me.Guna2CircleButton1.TabIndex = 30
        Me.Guna2CircleButton1.UseTransparentBackground = True
        '
        'dropdownpanel
        '
        Me.dropdownpanel.BackColor = System.Drawing.Color.Transparent
        Me.dropdownpanel.Location = New System.Drawing.Point(674, 88)
        Me.dropdownpanel.Name = "dropdownpanel"
        Me.dropdownpanel.ShadowDecoration.BorderRadius = 0
        Me.dropdownpanel.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.dropdownpanel.ShadowDecoration.Depth = 20
        Me.dropdownpanel.ShadowDecoration.Enabled = True
        Me.dropdownpanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.dropdownpanel.Size = New System.Drawing.Size(303, 361)
        Me.dropdownpanel.TabIndex = 34
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Guna2TextBox2.BorderRadius = 13
        Me.Guna2TextBox2.BorderThickness = 2
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.IconRight = CType(resources.GetObject("Guna2TextBox2.IconRight"), System.Drawing.Image)
        Me.Guna2TextBox2.IconRightOffset = New System.Drawing.Point(-10, 0)
        Me.Guna2TextBox2.IconRightSize = New System.Drawing.Size(42, 42)
        Me.Guna2TextBox2.Location = New System.Drawing.Point(43, 30)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(507, 37)
        Me.Guna2TextBox2.TabIndex = 37
        '
        'courpan
        '
        Me.courpan.Location = New System.Drawing.Point(12, 304)
        Me.courpan.Name = "courpan"
        Me.courpan.Size = New System.Drawing.Size(599, 417)
        Me.courpan.TabIndex = 38
        '
        'profilebtn
        '
        Me.profilebtn.BackColor = System.Drawing.Color.Transparent
        Me.profilebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profilebtn.Image = CType(resources.GetObject("profilebtn.Image"), System.Drawing.Image)
        Me.profilebtn.ImageRotate = 0!
        Me.profilebtn.Location = New System.Drawing.Point(896, 7)
        Me.profilebtn.Name = "profilebtn"
        Me.profilebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.profilebtn.Size = New System.Drawing.Size(75, 75)
        Me.profilebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilebtn.TabIndex = 40
        Me.profilebtn.TabStop = False
        Me.profilebtn.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(514, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(514, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(514, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Label8"
        '
        'DboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(989, 768)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.profilebtn)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.dropdownpanel)
        Me.Controls.Add(Me.Guna2CircleButton2)
        Me.Controls.Add(Me.Guna2CircleButton1)
        Me.Controls.Add(Me.UpdatePanel)
        Me.Controls.Add(Me.btnBcourses)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.studname)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.courpan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DboardForm"
        Me.Text = "DboardForm"
        CType(Me.profilebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label2 As Label
    Friend WithEvents studname As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBcourses As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents UpdatePanel As Panel
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents dropdownpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents courpan As Panel
    Friend WithEvents profilebtn As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
