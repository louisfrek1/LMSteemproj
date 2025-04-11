<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainChoose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainChoose))
        Me.PanelSign = New Guna.UI2.WinForms.Guna2Panel()
        Me.SuspendLayout()
        '
        'PanelSign
        '
        Me.PanelSign.BackColor = System.Drawing.Color.Transparent
        Me.PanelSign.Location = New System.Drawing.Point(118, 101)
        Me.PanelSign.Name = "PanelSign"
        Me.PanelSign.Size = New System.Drawing.Size(773, 496)
        Me.PanelSign.TabIndex = 4
        '
        'MainChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1001, 666)
        Me.Controls.Add(Me.PanelSign)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1019, 713)
        Me.Name = "MainChoose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TEEM"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelSign As Guna.UI2.WinForms.Guna2Panel
End Class
