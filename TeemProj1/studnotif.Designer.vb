<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studnotif
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.panelnot1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelnot2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelnot3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelnot4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'panelnot1
        '
        Me.panelnot1.AutoScroll = True
        Me.panelnot1.Location = New System.Drawing.Point(0, 0)
        Me.panelnot1.Name = "panelnot1"
        Me.panelnot1.Size = New System.Drawing.Size(318, 134)
        Me.panelnot1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'panelnot2
        '
        Me.panelnot2.AutoScroll = True
        Me.panelnot2.Location = New System.Drawing.Point(0, 140)
        Me.panelnot2.Name = "panelnot2"
        Me.panelnot2.Size = New System.Drawing.Size(318, 134)
        Me.panelnot2.TabIndex = 1
        '
        'panelnot3
        '
        Me.panelnot3.AutoScroll = True
        Me.panelnot3.Location = New System.Drawing.Point(0, 280)
        Me.panelnot3.Name = "panelnot3"
        Me.panelnot3.Size = New System.Drawing.Size(318, 134)
        Me.panelnot3.TabIndex = 2
        '
        'panelnot4
        '
        Me.panelnot4.AutoScroll = True
        Me.panelnot4.Location = New System.Drawing.Point(0, 420)
        Me.panelnot4.Name = "panelnot4"
        Me.panelnot4.Size = New System.Drawing.Size(318, 134)
        Me.panelnot4.TabIndex = 3
        '
        'studnotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(340, 376)
        Me.Controls.Add(Me.panelnot4)
        Me.Controls.Add(Me.panelnot3)
        Me.Controls.Add(Me.panelnot2)
        Me.Controls.Add(Me.panelnot1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "studnotif"
        Me.Text = "studnotif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents panelnot1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents panelnot4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelnot3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelnot2 As Guna.UI2.WinForms.Guna2Panel
End Class
