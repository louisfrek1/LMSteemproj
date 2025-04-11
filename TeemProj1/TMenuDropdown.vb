Public Class TMenuDropdown
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        TMainForm.Close()
        TSignin.txtUn.Clear()
        TSignin.txtPass.Clear()
        TSignup.titlecmb.SelectedItem = ""
        TSignup.txtpass.Clear()
        TSignup.txtemail.Clear()
        TSignup.txtfname.Clear()
        TSignup.txtlname.Clear()
        TSignup.txtphonenum.Clear()
        MainChoose.Show()
    End Sub

    Public Sub switchPanel1(ByVal panel As Form)
        'switch panel from mainframe

        TMainForm.Tmainpanel.Controls.Clear()
        panel.TopLevel = False
        TMainForm.Tmainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TMainForm.btnTDBoard.Checked = False
        TMainForm.btnTStudent.Checked = False
        TMainForm.btnTCourses.Checked = False
        TMainForm.btnTCalendar.Checked = False
        TMainForm.btnTResource.Checked = False
        TMainForm.imageslider.Visible = False
        switchPanel1(TProfile)
        TDboard.dropdownpanel.Hide()
        Me.Hide()
    End Sub

    Private Sub TMenuDropdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        TMainForm.btnTDBoard.Checked = False
        TMainForm.btnTStudent.Checked = False
        TMainForm.btnTCourses.Checked = False
        TMainForm.btnTCalendar.Checked = False
        TMainForm.btnTResource.Checked = False
        TMainForm.imageslider.Visible = False
        switchPanel1(accountsett)
        TDboard.dropdownpanel.Hide()
        Me.Hide()
    End Sub
End Class