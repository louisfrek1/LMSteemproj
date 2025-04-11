Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms
Imports MySqlConnector

Public Class TCourseFeed
    Public usercon As TDisplayCourses
    Public Function strconnection() As MySqlConnection

        Return New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")

    End Function
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Dim originalTextBoxHeight As Integer
    Dim originalLineCount As Integer


    Public Sub switchPanelTCF(ByVal panel As Form)
        'switch panel from mainframe

        cfeedpanel.Controls.Clear()
        panel.TopLevel = False
        cfeedpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanelTCF1(ByVal panel As Form)
        'switch panel from mainframe

        TMainForm.Tmainpanel.Controls.Clear()
        panel.TopLevel = False
        TMainForm.Tmainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub create(ByVal sql As String)

        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    'MessageBox.Show("FAILED TO SAVE THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub GenerateDynamicUserControl2()
        flayoutpanefeed.BringToFront()
        cfeedpanel.SendToBack()
        flayoutpanefeed.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems2()

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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles streambtn.Click
        GenerateDynamicUserControl2()
        TCourses.addassessmentbtn.Visible = False
        flayoutpanefeed.Visible = True
        postbtn.Visible = True
        postTxt.Visible = True
        assessbtn.Checked = False
        streambtn.Checked = True
        TCAssessment.Hide()
    End Sub

    Private Sub assessbtn_Click(sender As Object, e As EventArgs) Handles assessbtn.Click
        TCourses.addassessmentbtn.Visible = True
        flayoutpanefeed.Visible = False
        cfeedpanel.Visible = True
        postbtn.Visible = False
        postTxt.Visible = False
        streambtn.Checked = False
        assessbtn.Checked = True
        While Me.cfeedpanel.Controls.Count > 0
            Me.cfeedpanel.Controls(0).Dispose()
        End While
        switchPanelTCF(TCAssessment)
    End Sub

    Private Sub TCourseFeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDynamicUserControl2()
        TCourses.addcoursebtn.Visible = False
        postTxt.BringToFront()
        cfeedpanel.Visible = False
        postbtn.BringToFront()
        flayoutpanefeed.BringToFront()

        originalTextBoxHeight = postTxt.Height
        originalTextBoxHeight = postTxt.Height
        originalLineCount = postTxt.Lines.Length

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        While TMainForm.Tmainpanel.Controls.Count > 0
            TMainForm.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelTCF1(TCourses)
    End Sub

    Private Sub postTxt_TextChanged(sender As Object, e As EventArgs) Handles postTxt.TextChanged
        Dim currentLineCount As Integer = postTxt.Lines.Length

        If currentLineCount > originalLineCount Then
            ' Calculate the new height based on the line count difference
            Dim lineHeight As Integer = TextRenderer.MeasureText("A", postTxt.Font).Height
            Dim heightDifference As Integer = (currentLineCount - originalLineCount) * lineHeight
            postTxt.Size = New Size(postTxt.Width, postTxt.Height + heightDifference)

            ' Update the original line count
            originalLineCount = currentLineCount
        End If
    End Sub

    Private Sub postTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles postTxt.KeyDown
        If e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift Then
            ' Shift + Enter was pressed, insert a new line
            postTxt.AppendText(vbCrLf)
            e.Handled = True

            ' Change the TextBox size (optional)
            postTxt.Size = New Size(postTxt.Width, postTxt.Height + 20) ' Adjust the height as neede

        End If

        If e.KeyCode = Keys.Back Then
            If postTxt.Height > originalTextBoxHeight Then
                ' Reduce the TextBox height by 20, but ensure it doesn't go below the original size
                postTxt.Size = New Size(postTxt.Width, Math.Max(originalTextBoxHeight, postTxt.Height - 20))
                e.Handled = True ' Suppress the default Backspace key behavior
            End If
        End If
    End Sub

    Private Sub postbtn_Click(sender As Object, e As EventArgs) Handles postbtn.Click
        Dim currentDate As String = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt")
        If postTxt.Text = "" Then
            MessageBox.Show("Please enter character first")
        Else
            Try
                create("INSERT INTO tannouncement(idnum,firstname,lastname,date,coursename,coursegcode,content)VALUES('" & TCourses.Label1.Text & "','" & TSignin.fname & "','" & TSignin.lname & "','" & currentDate & "','" & coursenametlbl.Text & "','" & coursegcode.Text & "','" & postTxt.Text & "')")
                create("INSERT INTO notifyannounstudent(tidnum,tfname,tlname,time,coursename,coursegcode)VALUES('" & TSignin.idnum & "','" & TSignin.fname & "','" & TSignin.lname & "','" & currentDate & "','" & coursenametlbl.Text & "','" & coursegcode.Text & "')")
                GenerateDynamicUserControl2()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class