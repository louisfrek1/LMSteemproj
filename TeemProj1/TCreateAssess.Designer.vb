<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TCreateAssess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TCreateAssess))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.minutes = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cnametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ccodetxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.examtype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Add = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.noitemscmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.teemgcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.assessno = New Guna.UI2.WinForms.Guna2TextBox()
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
        'minutes
        '
        Me.minutes.AutoRoundedCorners = True
        Me.minutes.BackColor = System.Drawing.Color.Transparent
        Me.minutes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.minutes.BorderRadius = 17
        Me.minutes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.minutes.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minutes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minutes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.minutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.minutes.ItemHeight = 30
        Me.minutes.Location = New System.Drawing.Point(181, 224)
        Me.minutes.Name = "minutes"
        Me.minutes.Size = New System.Drawing.Size(144, 36)
        Me.minutes.TabIndex = 13
        '
        'cnametxt
        '
        Me.cnametxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cnametxt.DefaultText = ""
        Me.cnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cnametxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cnametxt.ForeColor = System.Drawing.Color.Black
        Me.cnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cnametxt.Location = New System.Drawing.Point(23, 69)
        Me.cnametxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cnametxt.Name = "cnametxt"
        Me.cnametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cnametxt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.cnametxt.PlaceholderText = "Course Name"
        Me.cnametxt.ReadOnly = True
        Me.cnametxt.SelectedText = ""
        Me.cnametxt.Size = New System.Drawing.Size(300, 34)
        Me.cnametxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cnametxt.TabIndex = 16
        '
        'ccodetxt
        '
        Me.ccodetxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ccodetxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ccodetxt.DefaultText = ""
        Me.ccodetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ccodetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ccodetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ccodetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ccodetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ccodetxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ccodetxt.ForeColor = System.Drawing.Color.Black
        Me.ccodetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ccodetxt.Location = New System.Drawing.Point(372, 69)
        Me.ccodetxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ccodetxt.Name = "ccodetxt"
        Me.ccodetxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ccodetxt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.ccodetxt.PlaceholderText = "Course Code"
        Me.ccodetxt.ReadOnly = True
        Me.ccodetxt.SelectedText = ""
        Me.ccodetxt.Size = New System.Drawing.Size(189, 34)
        Me.ccodetxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.ccodetxt.TabIndex = 17
        '
        'examtype
        '
        Me.examtype.AutoRoundedCorners = True
        Me.examtype.BackColor = System.Drawing.Color.Transparent
        Me.examtype.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.examtype.BorderRadius = 17
        Me.examtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.examtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.examtype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.examtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.examtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.examtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.examtype.ItemHeight = 30
        Me.examtype.Items.AddRange(New Object() {"Examination", "Quiz", "Assisgnment"})
        Me.examtype.Location = New System.Drawing.Point(181, 170)
        Me.examtype.Name = "examtype"
        Me.examtype.Size = New System.Drawing.Size(144, 36)
        Me.examtype.TabIndex = 18
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
        Me.Guna2Button2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Type of Assessment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Minutes to take"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Exipiration"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(465, 235)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 22)
        Me.DateTimePicker1.TabIndex = 25
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 332)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(646, 317)
        Me.FlowLayoutPanel1.TabIndex = 26
        '
        'Add
        '
        Me.Add.AutoRoundedCorners = True
        Me.Add.BorderRadius = 21
        Me.Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Add.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Add.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Add.ForeColor = System.Drawing.Color.White
        Me.Add.Location = New System.Drawing.Point(516, 277)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(104, 45)
        Me.Add.TabIndex = 27
        Me.Add.Text = "ADD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "No. of items"
        '
        'noitemscmb
        '
        Me.noitemscmb.AutoRoundedCorners = True
        Me.noitemscmb.BackColor = System.Drawing.Color.Transparent
        Me.noitemscmb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.noitemscmb.BorderRadius = 17
        Me.noitemscmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.noitemscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.noitemscmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.noitemscmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.noitemscmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.noitemscmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.noitemscmb.ItemHeight = 30
        Me.noitemscmb.Items.AddRange(New Object() {"10 items"})
        Me.noitemscmb.Location = New System.Drawing.Point(465, 173)
        Me.noitemscmb.Name = "noitemscmb"
        Me.noitemscmb.Size = New System.Drawing.Size(144, 36)
        Me.noitemscmb.TabIndex = 28
        '
        'teemgcode
        '
        Me.teemgcode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.teemgcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.teemgcode.DefaultText = ""
        Me.teemgcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.teemgcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.teemgcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.teemgcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.teemgcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.teemgcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.teemgcode.ForeColor = System.Drawing.Color.Black
        Me.teemgcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.teemgcode.Location = New System.Drawing.Point(23, 112)
        Me.teemgcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.teemgcode.Name = "teemgcode"
        Me.teemgcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.teemgcode.PlaceholderForeColor = System.Drawing.Color.Black
        Me.teemgcode.PlaceholderText = "Teem Code"
        Me.teemgcode.ReadOnly = True
        Me.teemgcode.SelectedText = ""
        Me.teemgcode.Size = New System.Drawing.Size(192, 34)
        Me.teemgcode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.teemgcode.TabIndex = 34
        '
        'assessno
        '
        Me.assessno.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.assessno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.assessno.DefaultText = ""
        Me.assessno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.assessno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.assessno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.assessno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.assessno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.assessno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.assessno.ForeColor = System.Drawing.Color.Black
        Me.assessno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.assessno.Location = New System.Drawing.Point(372, 112)
        Me.assessno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.assessno.Name = "assessno"
        Me.assessno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.assessno.PlaceholderForeColor = System.Drawing.Color.Black
        Me.assessno.PlaceholderText = "Assessment No."
        Me.assessno.SelectedText = ""
        Me.assessno.Size = New System.Drawing.Size(189, 34)
        Me.assessno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.assessno.TabIndex = 35
        '
        'TCreateAssess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(648, 649)
        Me.Controls.Add(Me.assessno)
        Me.Controls.Add(Me.teemgcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.noitemscmb)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.examtype)
        Me.Controls.Add(Me.ccodetxt)
        Me.Controls.Add(Me.cnametxt)
        Me.Controls.Add(Me.minutes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TCreateAssess"
        Me.Text = "TCreateAssess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents examtype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ccodetxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cnametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents minutes As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents noitemscmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents teemgcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents assessno As Guna.UI2.WinForms.Guna2TextBox
End Class
