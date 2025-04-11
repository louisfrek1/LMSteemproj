Imports Guna.UI2.WinForms

Public Class MainForm



    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        mainpanel.Controls.Clear()
        panel.TopLevel = False
        mainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub moveImageBox(sender As Object)
        'to move imageslider when clicked
        Dim b As Guna2Button = DirectCast(sender, Guna2Button)
        imageslider.Location = New Point(b.Location.X + 106, b.Location.Y - 37)
        'imageslider.SendToBack()

    End Sub




    Private Sub btnDBoard_CheckedChanged(sender As Object, e As EventArgs) Handles btnRes.CheckedChanged, btnMCourse.CheckedChanged, btnDBoard.CheckedChanged, btnCalen.CheckedChanged
        'imageslider.Visible = True
        moveImageBox(sender)
    End Sub

    Private Sub btnDBoard_Click(sender As Object, e As EventArgs) Handles btnDBoard.Click
        imageslider.Visible = True
        While Me.mainpanel.Controls.Count > 0
            Me.mainpanel.Controls(0).Dispose()
        End While
        switchPanel(DboardForm)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageslider.Visible = True
        While Me.mainpanel.Controls.Count > 0
            Me.mainpanel.Controls(0).Dispose()
        End While
        switchPanel(DboardForm)


    End Sub

    Private Sub btnMCourse_Click(sender As Object, e As EventArgs) Handles btnMCourse.Click
        imageslider.Visible = True
        While Me.mainpanel.Controls.Count > 0
            Me.mainpanel.Controls(0).Dispose()
        End While
        switchPanel(MCourseForm)
    End Sub

    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        imageslider.Visible = True
        While Me.mainpanel.Controls.Count > 0
            Me.mainpanel.Controls(0).Dispose()
        End While
        switchPanel(ResourceForm)
    End Sub


    Private Sub btnCalen_Click(sender As Object, e As EventArgs) Handles btnCalen.Click
        imageslider.Visible = True
        While Me.mainpanel.Controls.Count > 0
            Me.mainpanel.Controls(0).Dispose()
        End While
        switchPanel(CalendarForm)
    End Sub

End Class
