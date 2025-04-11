Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports MySqlConnector

Public Class TDisplayCourses

    Public icon As Image
    Public _courname As String
    Public _ccodex As Integer
    Public _cgcodex As String
    Dim str As String
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public courname1 As String
    Public courcode1 As Integer
    Public courgcode1 As String
    Public pic As Image

    Public Property Icon1 As Image
        Get
            Return icon
        End Get
        Set(value As Image)
            icon = value
            pb_image1.Image = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _courname
        End Get
        Set(value As String)
            _courname = value
            cnametxtlink.Text = value
        End Set
    End Property

    Public Property Code1() As String
        Get
            Return _ccodex
        End Get
        Set(value As String)
            _ccodex = value
            ccodelbl.Text = value
        End Set
    End Property

    Public Property CTime As String
        Get
            Return _cgcodex
        End Get
        Set(value As String)
            _cgcodex = value
            ctimelbl.Text = value
        End Set
    End Property

    Public Sub switchPanelTC(ByVal panel As Form)
        'switch panel from mainframe

        TCourses.addcoursepan.Controls.Clear()
        panel.TopLevel = False
        TCourses.addcoursepan.Controls.Add(panel)
        panel.Show()

    End Sub


    Public Sub TDisplayCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler cnametxtlink.Click, Sub(senderLabel As Object, eLabel As EventArgs)
                                           Me.OnClick(eLabel)
                                       End Sub
    End Sub


    Public Sub pb_image_Click(sender As Object, e As EventArgs)
        Me.OnClick(e)
        'Me.Hide()
    End Sub

    Private Sub cnametxtlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cnametxtlink.LinkClicked
        TCourses.addcoursepan.BringToFront()
        TCourses.flpaneIcon.SendToBack()
        TCourses.flpaneIcon.Visible = False

        Try
            str = "SELECT * FROM teach_addcourse1 WHERE coursename=@cname"
            con.Open()

            Dim mysC As New MySqlCommand(str, con)
            mysC.Parameters.AddWithValue("@cname", cnametxtlink.Text)

            Dim DR As MySqlDataReader = mysC.ExecuteReader()

            If DR.HasRows Then
                While DR.Read
                    courname1 = DR.GetString("coursename")
                    courcode1 = DR.GetString("coursecode")
                    courgcode1 = DR.GetString("coursegcode")
                End While
                While TCourses.addcoursepan.Controls.Count > 0
                    TCourses.addcoursepan.Controls(0).Dispose()
                End While
                switchPanelTC(TCourseFeed)
                TCourseFeed.coursenametlbl.Text = courname1
                TCourseFeed.coursecode.Text = courcode1
                TCourseFeed.coursegcode.Text = courgcode1
                TCreateAssess.cnametxt.Text = courname1
                TCreateAssess.ccodetxt.Text = courcode1
                TCreateAssess.teemgcode.Text = courgcode1


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
