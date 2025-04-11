<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelChoose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelChoose))
        Me.btnTeacher = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudent = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTeacher
        '
        Me.btnTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnTeacher.BorderRadius = 40
        Me.btnTeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTeacher.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTeacher.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTeacher.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnTeacher.Font = New System.Drawing.Font("Consolas", 22.2!, System.Drawing.FontStyle.Bold)
        Me.btnTeacher.ForeColor = System.Drawing.Color.White
        Me.btnTeacher.Location = New System.Drawing.Point(195, 332)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(364, 97)
        Me.btnTeacher.TabIndex = 6
        Me.btnTeacher.Text = "TEACHER"
        Me.btnTeacher.UseTransparentBackground = True
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnStudent.BorderRadius = 40
        Me.btnStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudent.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudent.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnStudent.Font = New System.Drawing.Font("Consolas", 22.2!, System.Drawing.FontStyle.Bold)
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.Location = New System.Drawing.Point(195, 211)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(364, 97)
        Me.btnStudent.TabIndex = 5
        Me.btnStudent.Text = "STUDENT"
        Me.btnStudent.UseTransparentBackground = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(272, 19)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(211, 186)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 4
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 70
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'PanelChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 496)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelChoose"
        Me.Text = "PanelChoose"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTeacher As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudent As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
