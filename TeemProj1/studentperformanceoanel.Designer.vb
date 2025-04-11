<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentperformanceoanel
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
        Me.doinggreatlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 50
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'doinggreatlbl
        '
        Me.doinggreatlbl.BackColor = System.Drawing.Color.Transparent
        Me.doinggreatlbl.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doinggreatlbl.ForeColor = System.Drawing.Color.White
        Me.doinggreatlbl.Location = New System.Drawing.Point(31, 33)
        Me.doinggreatlbl.Name = "doinggreatlbl"
        Me.doinggreatlbl.Size = New System.Drawing.Size(3, 2)
        Me.doinggreatlbl.TabIndex = 0
        Me.doinggreatlbl.Text = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'studentperformanceoanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 88)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.doinggreatlbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "studentperformanceoanel"
        Me.Text = "dsfsd "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents doinggreatlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
End Class
