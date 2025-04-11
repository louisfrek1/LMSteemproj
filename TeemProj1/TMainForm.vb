Imports System.IO
Imports Guna.UI2.WinForms

Public Class TMainForm
    Private Sub btnDBoard_CheckedChanged(sender As Object, e As EventArgs) Handles btnTCalendar.CheckedChanged, btnTCourses.CheckedChanged, btnTResource.CheckedChanged, btnTStudent.CheckedChanged, btnTDBoard.CheckedChanged
        moveImageBox(sender)
    End Sub

    Public Sub switchPanelT(ByVal panel As Form)
        'switch panel from mainframe

        Tmainpanel.Controls.Clear()
        panel.TopLevel = False
        Tmainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub TMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageslider.Visible = False
        While Me.Tmainpanel.Controls.Count > 0
            Me.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelT(TDboard)
    End Sub

    Private Sub moveImageBox(sender As Object)
        'to move imageslider when clicked
        Dim b As Guna2Button = DirectCast(sender, Guna2Button)
        imageslider.Location = New Point(b.Location.X + 106, b.Location.Y - 37)
        'imageslider.SendToBack()

    End Sub

    Private Sub btnTDBoard_Click(sender As Object, e As EventArgs) Handles btnTDBoard.Click
        imageslider.Visible = True
        While Me.Tmainpanel.Controls.Count > 0
            Me.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelT(TDboard)
    End Sub

    Private Sub btnTStudent_Click(sender As Object, e As EventArgs) Handles btnTStudent.Click
        imageslider.Visible = True
        While Me.Tmainpanel.Controls.Count > 0
            Me.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelT(TStudent)
    End Sub

    Private Sub btnTResource_Click(sender As Object, e As EventArgs) Handles btnTResource.Click
        imageslider.Visible = True
        While Me.Tmainpanel.Controls.Count > 0
            Me.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelT(TResource)
        GenerateDynamicUserControl5()
    End Sub

    Private Sub btnTCourses_Click(sender As Object, e As EventArgs) Handles btnTCourses.Click
        imageslider.Visible = True
        While Me.Tmainpanel.Controls.Count > 0
            Me.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelT(TCourses)
    End Sub

    Private Sub btnTCalendar_Click(sender As Object, e As EventArgs) Handles btnTCalendar.Click
        imageslider.Visible = True
        While Me.Tmainpanel.Controls.Count > 0
            Me.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelT(TCalendar)
    End Sub

    Private Sub btnTSettings_Click(sender As Object, e As EventArgs)
        imageslider.Visible = True
        While Me.Tmainpanel.Controls.Count > 0
            Me.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelT(TSettings)
    End Sub

    Public Sub GenerateDynamicUserControl5()
        TResource.FlowLayoutPanel1.BringToFront()
        TResource.FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems5()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As ResourceUser

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New ResourceUser()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))
                        'listItems(i).pb_image.Image = New Bitmap(MS)

                        listItems(i).cnmalink.Text = row("coursename").ToString()
                        listItems(i).label1.Text = row("coursegcode").ToString()


                        TResource.FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next

            End If
        End If
    End Sub

    Private Sub Tmainpanel_Paint(sender As Object, e As PaintEventArgs) Handles Tmainpanel.Paint

    End Sub

    Private Sub imageslider_Click(sender As Object, e As EventArgs) Handles imageslider.Click

    End Sub
End Class