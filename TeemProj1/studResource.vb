Imports MySqlConnector

Public Class studResource
    Public _cournameres As String
    Dim str As String
    Public coursenameres1 As String
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

    Public Sub switchPanelSR(ByVal panel As Form)
        'switch panel from mainframe

        ResourceForm.flayoutres.Controls.Clear()
        panel.TopLevel = False
        ResourceForm.flayoutres.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub studResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler cnmalink.Click, Sub(senderLabel As Object, eLabel As EventArgs)
                                       Me.OnClick(eLabel)
                                   End Sub
    End Sub

    Public Sub GenerateDynamicUserControl9()
        StudFile.FlowLayoutPanel1.BringToFront()
        StudFile.FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems9()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studfilecontent

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studfilecontent()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))
                        'listItems(i).pb_image.Image = New Bitmap(MS)

                        listItems(i).filenamestud.Text = row("filename").ToString()

                        StudFile.FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next

            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub cnmalink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cnmalink.LinkClicked
        ResourceForm.flayoutres.BringToFront()
        Try
            str = "SELECT * FROM tuploadfile WHERE coursename=@cname1"
            con.Open()

            Dim mysC As New MySqlCommand(str, con)
            mysC.Parameters.AddWithValue("@cname1", cnmalink.Text)

            Dim DR As MySqlDataReader = mysC.ExecuteReader()

            If DR.HasRows Then
                While DR.Read
                    coursenameres1 = DR.GetString("coursename")
                    coursegcoderes = DR.GetString("coursegcode")
                End While
                While ResourceForm.flayoutres.Controls.Count > 0
                    ResourceForm.flayoutres.Controls(0).Dispose()
                End While
                switchPanelSR(StudFile)
                StudFile.Label1.Text = coursenameres1
                StudFile.Label2.Text = coursegcoderes
                GenerateDynamicUserControl9()

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
