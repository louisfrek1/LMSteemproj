Public Class MenuDropdown


    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        MainChoose.PanelSign.Controls.Clear()
        panel.TopLevel = False
        MainChoose.PanelSign.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        MainForm.Close()
        StudSign.txtUn.Clear()
        StudSign.txtPass.Clear()
        MainChoose.Show()
        StudSignUp.txtUn.Clear()
        StudSignUp.txtPass.Clear()
        StudSignUp.txtEmail.Clear()
        StudSignUp.txtFname.Clear()
        StudSignUp.txtlname.Clear()
        While MainChoose.PanelSign.Controls.Count > 0
            MainChoose.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(PanelChoose)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        MainForm.btnDBoard.Checked = False
        MainForm.btnMCourse.Checked = False
        MainForm.btnCalen.Checked = False
        MainForm.btnRes.Checked = False
        MainForm.imageslider.Visible = False
        switchPanel1(MyProfile)
        DboardForm.dropdownpanel.Hide()
        Me.Hide()
    End Sub

    Public Sub switchPanel1(ByVal panel As Form)
        'switch panel from mainframe

        MainForm.mainpanel.Controls.Clear()
        panel.TopLevel = False
        MainForm.mainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        MainForm.btnDBoard.Checked = False
        MainForm.btnMCourse.Checked = False
        MainForm.btnCalen.Checked = False
        MainForm.btnRes.Checked = False
        MainForm.imageslider.Visible = False
        While MainForm.mainpanel.Controls.Count > 0
            MainForm.mainpanel.Controls(0).Dispose()
        End While
        switchPanel1(TClassList)
    End Sub

    Private Sub MenuDropdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ActiveCourses.Show()
    End Sub
End Class