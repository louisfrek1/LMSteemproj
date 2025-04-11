<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudSign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudSign))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtUn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.LinkSignUp = New System.Windows.Forms.LinkLabel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.showpass = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 70
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 91)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(327, 322)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'txtUn
        '
        Me.txtUn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtUn.BorderRadius = 15
        Me.txtUn.BorderThickness = 2
        Me.txtUn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUn.DefaultText = ""
        Me.txtUn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUn.ForeColor = System.Drawing.Color.Black
        Me.txtUn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUn.Location = New System.Drawing.Point(320, 160)
        Me.txtUn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUn.Name = "txtUn"
        Me.txtUn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUn.PlaceholderText = "username"
        Me.txtUn.SelectedText = ""
        Me.txtUn.Size = New System.Drawing.Size(376, 60)
        Me.txtUn.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtPass.BorderRadius = 15
        Me.txtPass.BorderThickness = 2
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.DefaultText = ""
        Me.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(320, 239)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass.PlaceholderText = "password"
        Me.txtPass.SelectedText = ""
        Me.txtPass.Size = New System.Drawing.Size(376, 60)
        Me.txtPass.TabIndex = 2
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.Transparent
        Me.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignIn.FillColor = System.Drawing.Color.Transparent
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.Image = CType(resources.GetObject("btnSignIn.Image"), System.Drawing.Image)
        Me.btnSignIn.ImageSize = New System.Drawing.Size(100, 100)
        Me.btnSignIn.Location = New System.Drawing.Point(656, 306)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(65, 45)
        Me.btnSignIn.TabIndex = 3
        Me.btnSignIn.UseTransparentBackground = True
        '
        'LinkSignUp
        '
        Me.LinkSignUp.AutoSize = True
        Me.LinkSignUp.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkSignUp.LinkColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LinkSignUp.Location = New System.Drawing.Point(576, 362)
        Me.LinkSignUp.Name = "LinkSignUp"
        Me.LinkSignUp.Size = New System.Drawing.Size(72, 20)
        Me.LinkSignUp.TabIndex = 5
        Me.LinkSignUp.TabStop = True
        Me.LinkSignUp.Text = "sign up"
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
        Me.Guna2Button2.Location = New System.Drawing.Point(24, 24)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(41, 36)
        Me.Guna2Button2.TabIndex = 6
        '
        'showpass
        '
        Me.showpass.BackColor = System.Drawing.Color.Transparent
        Me.showpass.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.showpass.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.showpass.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.showpass.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.showpass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.showpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.showpass.FillColor = System.Drawing.Color.White
        Me.showpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.showpass.ForeColor = System.Drawing.Color.White
        Me.showpass.Image = CType(resources.GetObject("showpass.Image"), System.Drawing.Image)
        Me.showpass.ImageSize = New System.Drawing.Size(40, 40)
        Me.showpass.Location = New System.Drawing.Point(702, 253)
        Me.showpass.Name = "showpass"
        Me.showpass.Size = New System.Drawing.Size(45, 33)
        Me.showpass.TabIndex = 11
        Me.showpass.UseTransparentBackground = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 33)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sign In as Student"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Don't have an account?"
        '
        'StudSign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(773, 496)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.showpass)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.LinkSignUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudSign"
        Me.Text = "s"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LinkSignUp As LinkLabel
    Friend WithEvents btnSignIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showpass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
