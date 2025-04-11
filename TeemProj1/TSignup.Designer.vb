<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TSignup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TSignup))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.titlecmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSUp = New Guna.UI2.WinForms.Guna2Button()
        Me.txtphonenum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.showpass = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 70
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
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
        Me.Guna2Button2.Location = New System.Drawing.Point(24, 24)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(41, 36)
        Me.Guna2Button2.TabIndex = 15
        '
        'titlecmb
        '
        Me.titlecmb.BackColor = System.Drawing.Color.Transparent
        Me.titlecmb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.titlecmb.BorderRadius = 15
        Me.titlecmb.BorderThickness = 2
        Me.titlecmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.titlecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.titlecmb.DropDownWidth = 50
        Me.titlecmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.titlecmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.titlecmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.titlecmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.titlecmb.ItemHeight = 30
        Me.titlecmb.Items.AddRange(New Object() {"Miss", "Mr", "Mrs", "Ms"})
        Me.titlecmb.Location = New System.Drawing.Point(122, 148)
        Me.titlecmb.MaximumSize = New System.Drawing.Size(124, 0)
        Me.titlecmb.MaxLength = 50
        Me.titlecmb.Name = "titlecmb"
        Me.titlecmb.Size = New System.Drawing.Size(124, 36)
        Me.titlecmb.Sorted = True
        Me.titlecmb.TabIndex = 20
        '
        'txtfname
        '
        Me.txtfname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtfname.BorderRadius = 15
        Me.txtfname.BorderThickness = 2
        Me.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfname.DefaultText = ""
        Me.txtfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfname.Location = New System.Drawing.Point(252, 136)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfname.PlaceholderText = "First Name"
        Me.txtfname.SelectedText = ""
        Me.txtfname.Size = New System.Drawing.Size(191, 60)
        Me.txtfname.TabIndex = 21
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
        Me.txtlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlname.Location = New System.Drawing.Point(449, 136)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlname.PlaceholderText = "Last Name"
        Me.txtlname.SelectedText = ""
        Me.txtlname.Size = New System.Drawing.Size(191, 60)
        Me.txtlname.TabIndex = 22
        '
        'txtemail
        '
        Me.txtemail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtemail.BorderRadius = 15
        Me.txtemail.BorderThickness = 2
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.DefaultText = ""
        Me.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Location = New System.Drawing.Point(122, 204)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.PlaceholderText = "Enter e-mail"
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(518, 60)
        Me.txtemail.TabIndex = 23
        '
        'txtpass
        '
        Me.txtpass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtpass.BorderRadius = 15
        Me.txtpass.BorderThickness = 2
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpass.DefaultText = ""
        Me.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpass.Location = New System.Drawing.Point(122, 272)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpass.PlaceholderText = "Enter password"
        Me.txtpass.SelectedText = ""
        Me.txtpass.Size = New System.Drawing.Size(518, 60)
        Me.txtpass.TabIndex = 24
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
        Me.btnSUp.TabIndex = 19
        Me.btnSUp.UseTransparentBackground = True
        '
        'txtphonenum
        '
        Me.txtphonenum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtphonenum.BorderRadius = 15
        Me.txtphonenum.BorderThickness = 2
        Me.txtphonenum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtphonenum.DefaultText = ""
        Me.txtphonenum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtphonenum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtphonenum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtphonenum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtphonenum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtphonenum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtphonenum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtphonenum.Location = New System.Drawing.Point(122, 340)
        Me.txtphonenum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtphonenum.Name = "txtphonenum"
        Me.txtphonenum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphonenum.PlaceholderText = "Phone number"
        Me.txtphonenum.SelectedText = ""
        Me.txtphonenum.Size = New System.Drawing.Size(518, 60)
        Me.txtphonenum.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 33)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Create account as a Teacher"
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
        Me.showpass.TabIndex = 27
        Me.showpass.UseTransparentBackground = True
        '
        'TSignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 496)
        Me.Controls.Add(Me.showpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtphonenum)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.titlecmb)
        Me.Controls.Add(Me.btnSUp)
        Me.Controls.Add(Me.Guna2Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TSignup"
        Me.Text = "TSignup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents titlecmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtphonenum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents showpass As Guna.UI2.WinForms.Guna2Button
End Class
