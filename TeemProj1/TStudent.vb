Imports MySqlConnector
Imports System.IO

Public Class TStudent

    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)

    Public Sub switchPanelTP(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub
    Public Sub switchPanelTStud(ByVal panel As Form)
        'switch panel from mainframe

        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub TStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropdownpanel.Visible = False
        Label1.Text = TSignin.idnum

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
        While Me.Panel1.Controls.Count > 0
            Me.Panel1.Controls(0).Dispose()
        End While
        switchPanelTStud(StudentEnrolled)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanelTP(TMenuDropdown)
        Else
            dropdownpanel.Hide()
            TMenuDropdown.Hide()

        End If
    End Sub
End Class