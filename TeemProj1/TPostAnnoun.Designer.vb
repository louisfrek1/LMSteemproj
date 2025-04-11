<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TPostAnnoun
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
        Me.announlbl = New System.Windows.Forms.Label()
        Me.timage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.datelbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.timage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'announlbl
        '
        Me.announlbl.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.announlbl.Location = New System.Drawing.Point(13, 96)
        Me.announlbl.Name = "announlbl"
        Me.announlbl.Size = New System.Drawing.Size(349, 66)
        Me.announlbl.TabIndex = 0
        Me.announlbl.Text = "Announcement:"
        Me.announlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.announlbl.UseCompatibleTextRendering = True
        '
        'timage
        '
        Me.timage.ImageRotate = 0!
        Me.timage.Location = New System.Drawing.Point(20, 11)
        Me.timage.Name = "timage"
        Me.timage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.timage.Size = New System.Drawing.Size(74, 72)
        Me.timage.TabIndex = 1
        Me.timage.TabStop = False
        '
        'namelbl
        '
        Me.namelbl.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.Location = New System.Drawing.Point(123, 18)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(284, 33)
        Me.namelbl.TabIndex = 2
        Me.namelbl.Text = "Name"
        '
        'datelbl
        '
        Me.datelbl.AutoSize = True
        Me.datelbl.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datelbl.Location = New System.Drawing.Point(125, 54)
        Me.datelbl.Name = "datelbl"
        Me.datelbl.Size = New System.Drawing.Size(41, 20)
        Me.datelbl.TabIndex = 3
        Me.datelbl.Text = "Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(-5, 189)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 14)
        Me.Panel1.TabIndex = 4
        '
        'TPostAnnoun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.datelbl)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.timage)
        Me.Controls.Add(Me.announlbl)
        Me.Name = "TPostAnnoun"
        Me.Size = New System.Drawing.Size(423, 196)
        CType(Me.timage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents announlbl As Label
    Friend WithEvents timage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents namelbl As Label
    Friend WithEvents datelbl As Label
    Friend WithEvents Panel1 As Panel
End Class
