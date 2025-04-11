Imports MySqlConnector
Imports System.IO

Public Class TDboard

    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)
    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        greatpanel.Controls.Clear()
        panel.TopLevel = False
        greatpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanel1(ByVal panel As Form)
        'switch panel from mainframe

        studentlistpanel.Controls.Clear()
        panel.TopLevel = False
        studentlistpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanel2(ByVal panel As Form)
        'switch panel from mainframe

        topstudentpanel.Controls.Clear()
        panel.TopLevel = False
        topstudentpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanelTP(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub TDboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropdownpanel.Visible = False

        Dim connection As New MySqlConnection(connStr)
        Dim command As New MySqlCommand("SELECT picture FROM teach_register WHERE id = @userId", connection)
        command.Parameters.AddWithValue("@userId", TSignin.idnum Or TSignup.idnum) ' Replace with the actual user ID

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                ' Check if the BLOB data is not DBNull.
                If Not reader.IsDBNull(0) Then
                    ' Read the BLOB data into a byte array.
                    Dim imageData As Byte() = DirectCast(reader.GetValue(0), Byte())

                    ' Close the reader and connection.
                    reader.Close()
                    connection.Close()

                    ' Load the byte array into a PictureBox control to display the image.
                    Dim ms As New MemoryStream(imageData)
                    profilebtn.Image = Image.FromStream(ms)
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
        While Me.greatpanel.Controls.Count > 0
            Me.greatpanel.Controls(0).Dispose()
        End While
        switchPanel(studentperformanceoanel)

        While Me.studentlistpanel.Controls.Count > 0
            Me.studentlistpanel.Controls(0).Dispose()
        End While
        switchPanel1(Tstudentlists)

        While Me.topstudentpanel.Controls.Count > 0
            Me.topstudentpanel.Controls(0).Dispose()
        End While
        switchPanel2(topstudent)

    End Sub

    Private Sub greatpanel_Paint(sender As Object, e As PaintEventArgs) Handles greatpanel.Paint

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanelTP(TMenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub
End Class