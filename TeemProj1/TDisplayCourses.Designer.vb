<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TDisplayCourses
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TDisplayCourses))
        Me.cnametxtlink = New System.Windows.Forms.LinkLabel()
        Me.ccodelbl = New System.Windows.Forms.Label()
        Me.ctimelbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_image1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.pb_image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cnametxtlink
        '
        Me.cnametxtlink.AutoSize = True
        Me.cnametxtlink.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnametxtlink.LinkColor = System.Drawing.Color.Black
        Me.cnametxtlink.Location = New System.Drawing.Point(144, 17)
        Me.cnametxtlink.Name = "cnametxtlink"
        Me.cnametxtlink.Size = New System.Drawing.Size(113, 28)
        Me.cnametxtlink.TabIndex = 1
        Me.cnametxtlink.TabStop = True
        Me.cnametxtlink.Text = "LinkLabel1"
        '
        'ccodelbl
        '
        Me.ccodelbl.AutoSize = True
        Me.ccodelbl.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccodelbl.Location = New System.Drawing.Point(146, 75)
        Me.ccodelbl.Name = "ccodelbl"
        Me.ccodelbl.Size = New System.Drawing.Size(56, 21)
        Me.ccodelbl.TabIndex = 2
        Me.ccodelbl.Text = "Label1"
        '
        'ctimelbl
        '
        Me.ctimelbl.AutoSize = True
        Me.ctimelbl.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctimelbl.Location = New System.Drawing.Point(145, 103)
        Me.ctimelbl.Name = "ctimelbl"
        Me.ctimelbl.Size = New System.Drawing.Size(57, 21)
        Me.ctimelbl.TabIndex = 3
        Me.ctimelbl.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(0, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 10)
        Me.Panel1.TabIndex = 4
        '
        'pb_image1
        '
        Me.pb_image1.Image = CType(resources.GetObject("pb_image1.Image"), System.Drawing.Image)
        Me.pb_image1.ImageRotate = 0!
        Me.pb_image1.Location = New System.Drawing.Point(20, 21)
        Me.pb_image1.Name = "pb_image1"
        Me.pb_image1.Size = New System.Drawing.Size(109, 103)
        Me.pb_image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_image1.TabIndex = 5
        Me.pb_image1.TabStop = False
        '
        'TDisplayCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pb_image1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ctimelbl)
        Me.Controls.Add(Me.ccodelbl)
        Me.Controls.Add(Me.cnametxtlink)
        Me.Name = "TDisplayCourses"
        Me.Size = New System.Drawing.Size(471, 156)
        CType(Me.pb_image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Public WithEvents cnametxtlink As LinkLabel
    Public WithEvents ccodelbl As Label
    Public WithEvents ctimelbl As Label
    Friend WithEvents pb_image1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
