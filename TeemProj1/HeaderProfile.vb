Public Class HeaderProfile
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click

    End Sub
    'switch panel for dropdown profile menu
    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        MainForm.mainpanel.Controls.Clear()
        panel.TopLevel = False
        MainForm.mainpanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub switchPanel1(ByVal panel As Form)

    End Sub
    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles profilebtn.Click

    End Sub

    Private Sub HeaderProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class