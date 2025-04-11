<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studexamdata
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
        Me.typeofexam = New System.Windows.Forms.LinkLabel()
        Me.assessno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'typeofexam
        '
        Me.typeofexam.AutoSize = True
        Me.typeofexam.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeofexam.LinkColor = System.Drawing.Color.Black
        Me.typeofexam.Location = New System.Drawing.Point(78, 14)
        Me.typeofexam.Name = "typeofexam"
        Me.typeofexam.Size = New System.Drawing.Size(90, 29)
        Me.typeofexam.TabIndex = 0
        Me.typeofexam.TabStop = True
        Me.typeofexam.Text = "LinkLabel1"
        '
        'assessno
        '
        Me.assessno.AutoSize = True
        Me.assessno.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assessno.Location = New System.Drawing.Point(3, 14)
        Me.assessno.Name = "assessno"
        Me.assessno.Size = New System.Drawing.Size(60, 29)
        Me.assessno.TabIndex = 1
        Me.assessno.Text = "Label1"
        '
        'studexamdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.assessno)
        Me.Controls.Add(Me.typeofexam)
        Me.Name = "studexamdata"
        Me.Size = New System.Drawing.Size(509, 58)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents typeofexam As LinkLabel
    Friend WithEvents assessno As Label
End Class
