<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TFileContent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TFileContent))
        Me.pdfnamelink = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.teemcodetxt = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pdfnamelink
        '
        Me.pdfnamelink.AutoSize = True
        Me.pdfnamelink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdfnamelink.LinkColor = System.Drawing.Color.Black
        Me.pdfnamelink.Location = New System.Drawing.Point(20, 14)
        Me.pdfnamelink.Name = "pdfnamelink"
        Me.pdfnamelink.Size = New System.Drawing.Size(90, 20)
        Me.pdfnamelink.TabIndex = 0
        Me.pdfnamelink.TabStop = True
        Me.pdfnamelink.Text = "LinkLabel1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(-1, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 21)
        Me.Panel1.TabIndex = 1
        '
        'teemcodetxt
        '
        Me.teemcodetxt.ActiveLinkColor = System.Drawing.Color.White
        Me.teemcodetxt.AutoSize = True
        Me.teemcodetxt.DisabledLinkColor = System.Drawing.Color.White
        Me.teemcodetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teemcodetxt.ForeColor = System.Drawing.Color.White
        Me.teemcodetxt.LinkColor = System.Drawing.Color.White
        Me.teemcodetxt.Location = New System.Drawing.Point(553, 29)
        Me.teemcodetxt.Name = "teemcodetxt"
        Me.teemcodetxt.Size = New System.Drawing.Size(90, 20)
        Me.teemcodetxt.TabIndex = 2
        Me.teemcodetxt.TabStop = True
        Me.teemcodetxt.Text = "LinkLabel1"
        Me.teemcodetxt.VisitedLinkColor = System.Drawing.Color.White
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(600, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TFileContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.teemcodetxt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pdfnamelink)
        Me.Name = "TFileContent"
        Me.Size = New System.Drawing.Size(643, 62)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pdfnamelink As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents teemcodetxt As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
