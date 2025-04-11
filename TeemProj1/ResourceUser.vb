Imports MySqlConnector

Public Class ResourceUser
    Public _cournameres As String
    Dim str As String
    Public coursenameres As String
    Public coursecoderes As String
    Public coursegcoderes As String
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")


    Public Property Title As String
        Get
            Return _cournameres
        End Get
        Set(value As String)
            _cournameres = value
            cnmalink.Text = value
        End Set
    End Property
    Private Sub ResourceUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler cnmalink.Click, Sub(senderLabel As Object, eLabel As EventArgs)
                                       Me.OnClick(eLabel)
                                   End Sub
    End Sub

    Public Sub switchPanelTR(ByVal panel As Form)
        'switch panel from mainframe

        TResource.Panel1.Controls.Clear()
        panel.TopLevel = False
        TResource.Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub cnmalink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cnmalink.LinkClicked
        TResource.Panel1.BringToFront()
        TResource.addfilebtn.Visible = True

        Try
            str = "SELECT * FROM teach_addcourse1 WHERE coursename=@cname"
            con.Open()

            Dim mysC As New MySqlCommand(str, con)
            mysC.Parameters.AddWithValue("@cname", cnmalink.Text)

            Dim DR As MySqlDataReader = mysC.ExecuteReader()

            If DR.HasRows Then
                While DR.Read
                    coursenameres = DR.GetString("coursename")
                    coursecoderes = DR.GetString("coursecode")
                    coursegcoderes = DR.GetString("coursegcode")

                End While
                filecontent.Label1.Text = coursenameres
                filecontent.Label2.Text = coursegcoderes
                uploadfile.cnametxt.Text = coursenameres
                uploadfile.ccodetxt.Text = coursecoderes
                uploadfile.cgcodetxt.Text = coursegcoderes

            Else
                'MessageBox.Show("Username and password did not match.")
            End If

            While TResource.Panel1.Controls.Count > 0
                TResource.Panel1.Controls(0).Dispose()
            End While
            switchPanelTR(filecontent)
        Catch ex As Exception
            'MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub
End Class
