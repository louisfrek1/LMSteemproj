<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudSignUp))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.txtUn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSUp = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.showpass = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtUn.Location = New System.Drawing.Point(122, 204)
        Me.txtUn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUn.Name = "txtUn"
        Me.txtUn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUn.PlaceholderText = "username"
        Me.txtUn.SelectedText = ""
        Me.txtUn.Size = New System.Drawing.Size(518, 60)
        Me.txtUn.TabIndex = 2
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
        Me.txtPass.Location = New System.Drawing.Point(122, 272)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass.PlaceholderText = "password"
        Me.txtPass.SelectedText = ""
        Me.txtPass.Size = New System.Drawing.Size(518, 60)
        Me.txtPass.TabIndex = 3
        '
        'txtlname
        '
        Me.txtlname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtlname.BorderRadius = 15
        Me.txtlname.BorderThickness = 2
        Me.txtlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlname.DefaultText = ""
        Me.txtlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtlname.ForeColor = System.Drawing.Color.Black
        Me.txtlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlname.Location = New System.Drawing.Point(379, 136)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlname.PlaceholderText = "last name"
        Me.txtlname.SelectedText = ""
        Me.txtlname.Size = New System.Drawing.Size(261, 60)
        Me.txtlname.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtEmail.BorderRadius = 15
        Me.txtEmail.BorderThickness = 2
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(122, 340)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "e-mail"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(518, 60)
        Me.txtEmail.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(132, 417)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "*preferably school's e-mail"
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
        Me.Guna2Button2.TabIndex = 7
        '
        'btnSUp
        '
        Me.btnSUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSUp.FillColor = System.Drawing.Color.Transparent
        Me.btnSUp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSUp.ForeColor = System.Drawing.Color.White
        Me.btnSUp.Image = CType(resources.GetObject("btnSUp.Image"), System.Drawing.Image)
        Me.btnSUp.ImageSize = New System.Drawing.Size(120, 120)
        Me.btnSUp.Location = New System.Drawing.Point(571, 417)
        Me.btnSUp.Name = "btnSUp"
        Me.btnSUp.Size = New System.Drawing.Size(69, 55)
        Me.btnSUp.TabIndex = 8
        Me.btnSUp.UseTransparentBackground = True
        '
        'txtFname
        '
        Me.txtFname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtFname.BorderRadius = 15
        Me.txtFname.BorderThickness = 2
        Me.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFname.DefaultText = ""
        Me.txtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.Location = New System.Drawing.Point(122, 136)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.PlaceholderText = "first name"
        Me.txtFname.SelectedText = ""
        Me.txtFname.Size = New System.Drawing.Size(251, 60)
        Me.txtFname.TabIndex = 9
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.showpass.Location = New System.Drawing.Point(646, 286)
        Me.showpass.Name = "showpass"
        Me.showpass.Size = New System.Drawing.Size(45, 33)
        Me.showpass.TabIndex = 12
        Me.showpass.UseTransparentBackground = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 33)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Create account as a Student"
        '
        'StudSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 496)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.showpass)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.btnSUp)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudSignUp"
        Me.Text = "StudSignUp"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents txtUn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents showpass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
End Class
