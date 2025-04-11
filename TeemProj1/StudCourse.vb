Imports MySqlConnector

Public Class StudCourse

    Public studicon As Image
    Public _cournamestud As String
    Public _ccodestud As Integer
    Public _cgcodestud As String
    Dim str As String
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public cournamestud As String
    Public courcodestud As Integer
    Public courgcodestud As String


    Public Property Icon3 As Image
        Get
            Return studicon
        End Get
        Set(value As Image)
            Icon3 = value
            pb_image.Image = value
        End Set
    End Property

    Public Property studcname As String
        Get
            Return cournamestud
        End Get
        Set(value As String)
            cournamestud = value
            studcnametxtlink.Text = value
        End Set
    End Property

    Public Property studcourcode() As String
        Get
            Return courcodestud
        End Get
        Set(value As String)
            courcodestud = value
            studccodelbl.Text = value
        End Set
    End Property

    Public Property studcourgcode As String
        Get
            Return courgcodestud
        End Get
        Set(value As String)
            courgcodestud = value
            studctimelbl.Text = value
        End Set
    End Property

    Public Sub switchPanelSC(ByVal panel As Form)
        'switch panel from mainframe

        MCourseForm.flayoutcourse.Controls.Clear()
        panel.TopLevel = False
        MCourseForm.flayoutcourse.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub StudCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler studcnametxtlink.Click, Sub(senderLabel As Object, eLabel As EventArgs)
                                               Me.OnClick(eLabel)
                                           End Sub
    End Sub

    Private Sub studcnametxtlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles studcnametxtlink.LinkClicked
        MCourseForm.flayoutcourse.AutoScroll = False
        Try
        str = "SELECT * FROM studaddclass WHERE coursename=@cname"
            con.Open()

            Dim mysC As New MySqlCommand(str, con)
            mysC.Parameters.AddWithValue("@cname", studcnametxtlink.Text)

            Dim DR As MySqlDataReader = mysC.ExecuteReader()

            If DR.HasRows Then
                While DR.Read
                    cournamestud = DR.GetString("coursename")
                    courcodestud = DR.GetString("coursecode")
                    courgcodestud = DR.GetString("coursegcode")
                End While
                While MCourseForm.flayoutcourse.Controls.Count > 0
                    MCourseForm.flayoutcourse.Controls(0).Dispose()
                End While
                switchPanelSC(StudCourseFeed)
                StudCourseFeed.studcoursenametlbl.Text = cournamestud
                StudCourseFeed.studcoursecode.Text = courcodestud
                StudCourseFeed.studcoursegcode.Text = courgcodestud
                studstartexam.Label1.Text = cournamestud
                studstartexam.Label2.Text = courgcodestud


            Else
                'MessageBox.Show("Username and password did not match.")
            End If

        Catch ex As Exception
            'MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
