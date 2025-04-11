<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudCourse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudCourse))
        Me.studctimelbl = New System.Windows.Forms.Label()
        Me.studccodelbl = New System.Windows.Forms.Label()
        Me.studcnametxtlink = New System.Windows.Forms.LinkLabel()
        Me.pb_image = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'studctimelbl
        '
        Me.studctimelbl.AutoSize = True
        Me.studctimelbl.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studctimelbl.Location = New System.Drawing.Point(143, 103)
        Me.studctimelbl.Name = "studctimelbl"
        Me.studctimelbl.Size = New System.Drawing.Size(57, 21)
        Me.studctimelbl.TabIndex = 7
        Me.studctimelbl.Text = "Label2"
        '
        'studccodelbl
        '
        Me.studccodelbl.AutoSize = True
        Me.studccodelbl.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studccodelbl.Location = New System.Drawing.Point(144, 75)
        Me.studccodelbl.Name = "studccodelbl"
        Me.studccodelbl.Size = New System.Drawing.Size(56, 21)
        Me.studccodelbl.TabIndex = 6
        Me.studccodelbl.Text = "Label1"
        '
        'studcnametxtlink
        '
        Me.studcnametxtlink.AutoSize = True
        Me.studcnametxtlink.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studcnametxtlink.LinkColor = System.Drawing.Color.Black
        Me.studcnametxtlink.Location = New System.Drawing.Point(142, 17)
        Me.studcnametxtlink.Name = "studcnametxtlink"
        Me.studcnametxtlink.Size = New System.Drawing.Size(113, 28)
        Me.studcnametxtlink.TabIndex = 5
        Me.studcnametxtlink.TabStop = True
        Me.studcnametxtlink.Text = "LinkLabel1"
        '
        'pb_image
        '
        Me.pb_image.BackColor = System.Drawing.Color.Transparent
        Me.pb_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_image.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.pb_image.HoverState.ImageSize = New System.Drawing.Size(100, 100)
        Me.pb_image.Image = CType(resources.GetObject("pb_image.Image"), System.Drawing.Image)
        Me.pb_image.ImageOffset = New System.Drawing.Point(0, 0)
        Me.pb_image.ImageRotate = 0!
        Me.pb_image.ImageSize = New System.Drawing.Size(100, 100)
        Me.pb_image.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pb_image.Location = New System.Drawing.Point(8, 18)
        Me.pb_image.Name = "pb_image"
        Me.pb_image.PressedState.ImageSize = New System.Drawing.Size(100, 100)
        Me.pb_image.Size = New System.Drawing.Size(121, 121)
        Me.pb_image.TabIndex = 4
        Me.pb_image.UseTransparentBackground = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(-6, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 10)
        Me.Panel1.TabIndex = 8
        '
        'StudCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.studctimelbl)
        Me.Controls.Add(Me.studccodelbl)
        Me.Controls.Add(Me.studcnametxtlink)
        Me.Controls.Add(Me.pb_image)
        Me.Name = "StudCourse"
        Me.Size = New System.Drawing.Size(525, 156)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents studctimelbl As Label
    Public WithEvents studccodelbl As Label
    Public WithEvents studcnametxtlink As LinkLabel
    Public WithEvents pb_image As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Panel1 As Panel
End Class
