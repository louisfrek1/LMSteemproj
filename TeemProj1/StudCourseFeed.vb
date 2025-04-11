Public Class StudCourseFeed

    Public Sub switchPanelSC(ByVal panel As Form)
        'switch panel from mainframe

        MainForm.mainpanel.Controls.Clear()
        panel.TopLevel = False
        MainForm.mainpanel.Controls.Add(panel)
        panel.Show()

    End Sub
    Public Sub GenerateDynamicUserControl4()
        flayoutpanefeed.BringToFront()
        cfeedpanel.SendToBack()
        flayoutpanefeed.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems4()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As TPostAnnoun

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New TPostAnnoun()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))
                        'listItems(i).pb_image.Image = New Bitmap(MS)

                        listItems(i).namelbl.Text = row("firstname").ToString() + " " + row("lastname").ToString()
                        listItems(i).datelbl.Text = row("date").ToString()
                        listItems(i).announlbl.Text = row("content").ToString()

                        flayoutpanefeed.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next

            End If
        End If
    End Sub
    Private Sub StudCourseFeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDynamicUserControl4()
    End Sub

    Private Sub streambtn_Click(sender As Object, e As EventArgs) Handles streambtn.Click
        GenerateDynamicUserControl4()
        assessbtn.Checked = False
        streambtn.Checked = True
    End Sub

    Private Sub assessbtn_Click(sender As Object, e As EventArgs) Handles assessbtn.Click
        GenerateDynamicUserControl7()
        streambtn.Checked = False
        assessbtn.Checked = True

    End Sub

    Public Sub GenerateDynamicUserControl7()
        cfeedpanel.BringToFront()
        'changepanel.SendToBack()
        cfeedpanel.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems7()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studexamdata

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studexamdata()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))
                        'listItems(i).pb_image.Image = New Bitmap(MS)

                        listItems(i).assessno.Text = row("assessno").ToString()
                        listItems(i).typeofexam.Text = row("assesstype").ToString()

                        cfeedpanel.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next

            End If
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        While MainForm.mainpanel.Controls.Count > 0
            MainForm.mainpanel.Controls(0).Dispose()
        End While
        switchPanelSC(MCourseForm)
    End Sub
End Class