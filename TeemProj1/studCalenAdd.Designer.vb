<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studCalenAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studCalenAdd))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.txttitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.datepcker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbccode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbcname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbevent = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'txttitle
        '
        Me.txttitle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txttitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttitle.DefaultText = ""
        Me.txttitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttitle.Location = New System.Drawing.Point(335, 68)
        Me.txttitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttitle.PlaceholderText = ""
        Me.txttitle.SelectedText = ""
        Me.txttitle.Size = New System.Drawing.Size(301, 36)
        Me.txttitle.TabIndex = 24
        '
        'datepcker
        '
        Me.datepcker.BorderRadius = 9
        Me.datepcker.Checked = True
        Me.datepcker.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.datepcker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.datepcker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datepcker.Location = New System.Drawing.Point(156, 13)
        Me.datepcker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datepcker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datepcker.Name = "datepcker"
        Me.datepcker.Size = New System.Drawing.Size(327, 36)
        Me.datepcker.TabIndex = 23
        Me.datepcker.Value = New Date(2023, 9, 25, 6, 31, 52, 943)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(538, 156)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(98, 46)
        Me.Guna2Button1.TabIndex = 22
        Me.Guna2Button1.Text = "SAVE"
        '
        'cmbccode
        '
        Me.cmbccode.BackColor = System.Drawing.Color.Transparent
        Me.cmbccode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmbccode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbccode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbccode.DropDownWidth = 200
        Me.cmbccode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbccode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbccode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbccode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbccode.ItemHeight = 30
        Me.cmbccode.Items.AddRange(New Object() {"Event", "Exam", "Expiration", "Quiz", "Holiday", "Activity"})
        Me.cmbccode.Location = New System.Drawing.Point(156, 124)
        Me.cmbccode.Name = "cmbccode"
        Me.cmbccode.Size = New System.Drawing.Size(140, 36)
        Me.cmbccode.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Course Code"
        '
        'cmbcname
        '
        Me.cmbcname.BackColor = System.Drawing.Color.Transparent
        Me.cmbcname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmbcname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcname.DropDownWidth = 200
        Me.cmbcname.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbcname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbcname.ItemHeight = 30
        Me.cmbcname.Items.AddRange(New Object() {"Event", "Exam", "Expiration", "Quiz", "Holiday", "Activity"})
        Me.cmbcname.Location = New System.Drawing.Point(156, 68)
        Me.cmbcname.Name = "cmbcname"
        Me.cmbcname.Size = New System.Drawing.Size(140, 36)
        Me.cmbcname.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Course Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Date"
        '
        'cmbevent
        '
        Me.cmbevent.BackColor = System.Drawing.Color.Transparent
        Me.cmbevent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmbevent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbevent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbevent.DropDownWidth = 200
        Me.cmbevent.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbevent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbevent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbevent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbevent.ItemHeight = 30
        Me.cmbevent.Items.AddRange(New Object() {"Event", "Exam", "Expiration", "Quiz", "Holiday", "Activity"})
        Me.cmbevent.Location = New System.Drawing.Point(156, 178)
        Me.cmbevent.Name = "cmbevent"
        Me.cmbevent.Size = New System.Drawing.Size(140, 36)
        Me.cmbevent.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Event"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.Location = New System.Drawing.Point(619, 6)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(32, 34)
        Me.Guna2Button2.TabIndex = 25
        Me.Guna2Button2.UseTransparentBackground = True
        '
        'studCalenAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(678, 240)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.datepcker)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.cmbccode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbcname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbevent)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "studCalenAdd"
        Me.Text = "studCalenAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents txttitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents datepcker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbccode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbcname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbevent As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
