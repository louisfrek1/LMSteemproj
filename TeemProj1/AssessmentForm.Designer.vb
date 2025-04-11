<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssessmentForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssessmentForm))
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.mcqcmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.radioa = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radiob = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radioc = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.radiod = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.deletebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.checka = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.checkb = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.checkc = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.checkd = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txtshortanswer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(11, 15)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.Multiline = True
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Question"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(386, 46)
        Me.Guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox1.TabIndex = 0
        '
        'mcqcmb
        '
        Me.mcqcmb.BackColor = System.Drawing.Color.Transparent
        Me.mcqcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.mcqcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mcqcmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mcqcmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mcqcmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mcqcmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.mcqcmb.ItemHeight = 30
        Me.mcqcmb.Items.AddRange(New Object() {"Multiple Choice", "Checkboxes", "Short Answer"})
        Me.mcqcmb.Location = New System.Drawing.Point(424, 25)
        Me.mcqcmb.Name = "mcqcmb"
        Me.mcqcmb.Size = New System.Drawing.Size(169, 36)
        Me.mcqcmb.TabIndex = 1
        '
        'radioa
        '
        Me.radioa.AutoSize = True
        Me.radioa.Checked = True
        Me.radioa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radioa.CheckedState.BorderThickness = 0
        Me.radioa.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.radioa.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radioa.CheckedState.InnerOffset = -4
        Me.radioa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.radioa.Location = New System.Drawing.Point(26, 92)
        Me.radioa.Name = "radioa"
        Me.radioa.Size = New System.Drawing.Size(85, 22)
        Me.radioa.TabIndex = 2
        Me.radioa.TabStop = True
        Me.radioa.Text = "Option 1"
        Me.radioa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radioa.UncheckedState.BorderThickness = 2
        Me.radioa.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radioa.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'radiob
        '
        Me.radiob.AutoSize = True
        Me.radiob.Checked = True
        Me.radiob.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radiob.CheckedState.BorderThickness = 0
        Me.radiob.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.radiob.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radiob.CheckedState.InnerOffset = -4
        Me.radiob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.radiob.Location = New System.Drawing.Point(26, 133)
        Me.radiob.Name = "radiob"
        Me.radiob.Size = New System.Drawing.Size(85, 22)
        Me.radiob.TabIndex = 3
        Me.radiob.TabStop = True
        Me.radiob.Text = "Option 2"
        Me.radiob.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radiob.UncheckedState.BorderThickness = 2
        Me.radiob.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radiob.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'radioc
        '
        Me.radioc.AutoSize = True
        Me.radioc.Checked = True
        Me.radioc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radioc.CheckedState.BorderThickness = 0
        Me.radioc.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.radioc.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radioc.CheckedState.InnerOffset = -4
        Me.radioc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.radioc.Location = New System.Drawing.Point(234, 92)
        Me.radioc.Name = "radioc"
        Me.radioc.Size = New System.Drawing.Size(85, 22)
        Me.radioc.TabIndex = 4
        Me.radioc.TabStop = True
        Me.radioc.Text = "Option 3"
        Me.radioc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radioc.UncheckedState.BorderThickness = 2
        Me.radioc.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radioc.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'radiod
        '
        Me.radiod.AutoSize = True
        Me.radiod.Checked = True
        Me.radiod.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radiod.CheckedState.BorderThickness = 0
        Me.radiod.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.radiod.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radiod.CheckedState.InnerOffset = -4
        Me.radiod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.radiod.Location = New System.Drawing.Point(234, 133)
        Me.radiod.Name = "radiod"
        Me.radiod.Size = New System.Drawing.Size(85, 22)
        Me.radiod.TabIndex = 5
        Me.radiod.TabStop = True
        Me.radiod.Text = "Option 4"
        Me.radiod.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radiod.UncheckedState.BorderThickness = 2
        Me.radiod.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radiod.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.Transparent
        Me.deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deletebtn.FillColor = System.Drawing.Color.Transparent
        Me.deletebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.deletebtn.ForeColor = System.Drawing.Color.White
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.ImageSize = New System.Drawing.Size(30, 30)
        Me.deletebtn.Location = New System.Drawing.Point(558, 176)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(35, 40)
        Me.deletebtn.TabIndex = 6
        Me.deletebtn.UseTransparentBackground = True
        '
        'checka
        '
        Me.checka.AutoSize = True
        Me.checka.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checka.CheckedState.BorderRadius = 0
        Me.checka.CheckedState.BorderThickness = 0
        Me.checka.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checka.Location = New System.Drawing.Point(26, 92)
        Me.checka.Name = "checka"
        Me.checka.Size = New System.Drawing.Size(136, 20)
        Me.checka.TabIndex = 7
        Me.checka.Text = "Guna2CheckBox1"
        Me.checka.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checka.UncheckedState.BorderRadius = 0
        Me.checka.UncheckedState.BorderThickness = 0
        Me.checka.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'checkb
        '
        Me.checkb.AutoSize = True
        Me.checkb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkb.CheckedState.BorderRadius = 0
        Me.checkb.CheckedState.BorderThickness = 0
        Me.checkb.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkb.Location = New System.Drawing.Point(26, 133)
        Me.checkb.Name = "checkb"
        Me.checkb.Size = New System.Drawing.Size(136, 20)
        Me.checkb.TabIndex = 8
        Me.checkb.Text = "Guna2CheckBox2"
        Me.checkb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkb.UncheckedState.BorderRadius = 0
        Me.checkb.UncheckedState.BorderThickness = 0
        Me.checkb.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'checkc
        '
        Me.checkc.AutoSize = True
        Me.checkc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkc.CheckedState.BorderRadius = 0
        Me.checkc.CheckedState.BorderThickness = 0
        Me.checkc.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkc.Location = New System.Drawing.Point(234, 92)
        Me.checkc.Name = "checkc"
        Me.checkc.Size = New System.Drawing.Size(136, 20)
        Me.checkc.TabIndex = 9
        Me.checkc.Text = "Guna2CheckBox3"
        Me.checkc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkc.UncheckedState.BorderRadius = 0
        Me.checkc.UncheckedState.BorderThickness = 0
        Me.checkc.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'checkd
        '
        Me.checkd.AutoSize = True
        Me.checkd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkd.CheckedState.BorderRadius = 0
        Me.checkd.CheckedState.BorderThickness = 0
        Me.checkd.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkd.Location = New System.Drawing.Point(234, 133)
        Me.checkd.Name = "checkd"
        Me.checkd.Size = New System.Drawing.Size(136, 20)
        Me.checkd.TabIndex = 10
        Me.checkd.Text = "Guna2CheckBox4"
        Me.checkd.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkd.UncheckedState.BorderRadius = 0
        Me.checkd.UncheckedState.BorderThickness = 0
        Me.checkd.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'txtshortanswer
        '
        Me.txtshortanswer.BorderColor = System.Drawing.Color.Black
        Me.txtshortanswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtshortanswer.DefaultText = ""
        Me.txtshortanswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtshortanswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtshortanswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtshortanswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtshortanswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtshortanswer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtshortanswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtshortanswer.Location = New System.Drawing.Point(11, 98)
        Me.txtshortanswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtshortanswer.Name = "txtshortanswer"
        Me.txtshortanswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtshortanswer.PlaceholderText = "Answer"
        Me.txtshortanswer.SelectedText = ""
        Me.txtshortanswer.Size = New System.Drawing.Size(386, 48)
        Me.txtshortanswer.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtshortanswer.TabIndex = 11
        '
        'AssessmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.radiod)
        Me.Controls.Add(Me.radioc)
        Me.Controls.Add(Me.radiob)
        Me.Controls.Add(Me.radioa)
        Me.Controls.Add(Me.mcqcmb)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.txtshortanswer)
        Me.Controls.Add(Me.checka)
        Me.Controls.Add(Me.checkb)
        Me.Controls.Add(Me.checkc)
        Me.Controls.Add(Me.checkd)
        Me.Name = "AssessmentForm"
        Me.Size = New System.Drawing.Size(608, 219)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mcqcmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents radioa As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radiob As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radioc As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents radiod As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents deletebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents checka As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents checkb As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents checkc As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents checkd As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txtshortanswer As Guna.UI2.WinForms.Guna2TextBox
End Class
