<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResourceUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResourceUser))
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.cnmalink = New System.Windows.Forms.LinkLabel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(130, 130)
        Me.Guna2Button1.Location = New System.Drawing.Point(47, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(141, 120)
        Me.Guna2Button1.TabIndex = 0
        '
        'cnmalink
        '
        Me.cnmalink.AutoSize = True
        Me.cnmalink.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnmalink.LinkColor = System.Drawing.Color.Black
        Me.cnmalink.Location = New System.Drawing.Point(54, 107)
        Me.cnmalink.Name = "cnmalink"
        Me.cnmalink.Size = New System.Drawing.Size(90, 29)
        Me.cnmalink.TabIndex = 1
        Me.cnmalink.TabStop = True
        Me.cnmalink.Text = "LinkLabel1"
        Me.cnmalink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(187, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Label1"
        '
        'ResourceUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cnmalink)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Name = "ResourceUser"
        Me.Size = New System.Drawing.Size(238, 165)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cnmalink As LinkLabel
    Friend WithEvents label1 As Label
End Class
