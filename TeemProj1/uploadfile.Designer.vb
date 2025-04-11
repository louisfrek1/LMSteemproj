<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uploadfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uploadfile))
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cnametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ccodetxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cgcodetxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.lnametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fnametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.idnumtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(522, 73)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(100, 45)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Browse"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.BorderColor = System.Drawing.Color.Black
        Me.TextBox1.BorderRadius = 20
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.DefaultText = ""
        Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(65, 73)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.PlaceholderText = "File Name"
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(447, 45)
        Me.TextBox1.TabIndex = 1
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2ProgressBar1
        '
        Me.Guna2ProgressBar1.BorderRadius = 10
        Me.Guna2ProgressBar1.Location = New System.Drawing.Point(66, 136)
        Me.Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2ProgressBar1.Size = New System.Drawing.Size(447, 26)
        Me.Guna2ProgressBar1.TabIndex = 2
        Me.Guna2ProgressBar1.Text = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2Button2
        '
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 22
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(522, 126)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(101, 46)
        Me.Guna2Button2.TabIndex = 3
        Me.Guna2Button2.Text = "UPLOAD"
        '
        'Timer1
        '
        '
        'cnametxt
        '
        Me.cnametxt.BorderColor = System.Drawing.Color.Black
        Me.cnametxt.BorderRadius = 20
        Me.cnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cnametxt.DefaultText = ""
        Me.cnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cnametxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cnametxt.Location = New System.Drawing.Point(74, 265)
        Me.cnametxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cnametxt.Name = "cnametxt"
        Me.cnametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cnametxt.PlaceholderText = "Course Name"
        Me.cnametxt.SelectedText = ""
        Me.cnametxt.Size = New System.Drawing.Size(295, 45)
        Me.cnametxt.TabIndex = 4
        '
        'ccodetxt
        '
        Me.ccodetxt.BorderColor = System.Drawing.Color.Black
        Me.ccodetxt.BorderRadius = 20
        Me.ccodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ccodetxt.DefaultText = ""
        Me.ccodetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ccodetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ccodetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ccodetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ccodetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ccodetxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ccodetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ccodetxt.Location = New System.Drawing.Point(73, 318)
        Me.ccodetxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ccodetxt.Name = "ccodetxt"
        Me.ccodetxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ccodetxt.PlaceholderText = "Course Code"
        Me.ccodetxt.SelectedText = ""
        Me.ccodetxt.Size = New System.Drawing.Size(296, 45)
        Me.ccodetxt.TabIndex = 5
        '
        'cgcodetxt
        '
        Me.cgcodetxt.BorderColor = System.Drawing.Color.Black
        Me.cgcodetxt.BorderRadius = 20
        Me.cgcodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cgcodetxt.DefaultText = ""
        Me.cgcodetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cgcodetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cgcodetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cgcodetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cgcodetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cgcodetxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cgcodetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cgcodetxt.Location = New System.Drawing.Point(73, 371)
        Me.cgcodetxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cgcodetxt.Name = "cgcodetxt"
        Me.cgcodetxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cgcodetxt.PlaceholderText = "Teem Code"
        Me.cgcodetxt.SelectedText = ""
        Me.cgcodetxt.Size = New System.Drawing.Size(295, 45)
        Me.cgcodetxt.TabIndex = 6
        '
        'Guna2Button3
        '
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button3.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(41, 36)
        Me.Guna2Button3.TabIndex = 10
        '
        'lnametxt
        '
        Me.lnametxt.BorderColor = System.Drawing.Color.Black
        Me.lnametxt.BorderRadius = 20
        Me.lnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lnametxt.DefaultText = ""
        Me.lnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnametxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnametxt.Location = New System.Drawing.Point(74, 530)
        Me.lnametxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lnametxt.Name = "lnametxt"
        Me.lnametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lnametxt.PlaceholderText = "Last Name"
        Me.lnametxt.SelectedText = ""
        Me.lnametxt.Size = New System.Drawing.Size(295, 45)
        Me.lnametxt.TabIndex = 13
        '
        'fnametxt
        '
        Me.fnametxt.BorderColor = System.Drawing.Color.Black
        Me.fnametxt.BorderRadius = 20
        Me.fnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fnametxt.DefaultText = ""
        Me.fnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fnametxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fnametxt.Location = New System.Drawing.Point(74, 477)
        Me.fnametxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fnametxt.Name = "fnametxt"
        Me.fnametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fnametxt.PlaceholderText = "First Name"
        Me.fnametxt.SelectedText = ""
        Me.fnametxt.Size = New System.Drawing.Size(296, 45)
        Me.fnametxt.TabIndex = 12
        '
        'idnumtxt
        '
        Me.idnumtxt.BorderColor = System.Drawing.Color.Black
        Me.idnumtxt.BorderRadius = 20
        Me.idnumtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idnumtxt.DefaultText = ""
        Me.idnumtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.idnumtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.idnumtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idnumtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idnumtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idnumtxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.idnumtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idnumtxt.Location = New System.Drawing.Point(75, 424)
        Me.idnumtxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.idnumtxt.Name = "idnumtxt"
        Me.idnumtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idnumtxt.PlaceholderText = "ID"
        Me.idnumtxt.SelectedText = ""
        Me.idnumtxt.Size = New System.Drawing.Size(295, 45)
        Me.idnumtxt.TabIndex = 11
        '
        'uploadfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 649)
        Me.Controls.Add(Me.lnametxt)
        Me.Controls.Add(Me.fnametxt)
        Me.Controls.Add(Me.idnumtxt)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.cgcodetxt)
        Me.Controls.Add(Me.ccodetxt)
        Me.Controls.Add(Me.cnametxt)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2ProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "uploadfile"
        Me.Text = "uploadfile"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cgcodetxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ccodetxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cnametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lnametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fnametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents idnumtxt As Guna.UI2.WinForms.Guna2TextBox
End Class
