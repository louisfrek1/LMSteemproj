Imports System.Runtime.CompilerServices
Imports MySqlConnector
Imports System.IO

Public Class MyProfile

    Dim con As New MySqlConnection
    Dim connection As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Dim sql As String
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)

    Public Sub switchPanel1(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savechangebtn.Visible = False
        browsepic.Visible = False
        dropdownpanel.Visible = False
        Me.usenametxt.Text = StudSign.usname
        Me.email.Text = StudSign.email
        Me.uname.Text = StudSign.fname
        Me.idnumbertxt.Text = StudSign.idnum
        Me.schooltxt.Text = StudSign.schoolna
        Me.contacttxt.Text = StudSign.connum

        Dim connection As New MySqlConnection(connStr)
        Dim command As New MySqlCommand("SELECT picture FROM registration WHERE id = @userId", connection)
        command.Parameters.AddWithValue("@userId", StudSign.idnum) ' Replace with the actual user ID

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
                    profilepic.Image = Image.FromStream(ms)
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Guna2CircleButton1_Click_1(sender As Object, e As EventArgs) Handles browsepic.Click
        Try
            Dim ofd As FileDialog = New OpenFileDialog()
            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then
                imgpath = ofd.FileName
                profilepic.ImageLocation = imgpath
            End If

            ofd = Nothing
        Catch ex As Exception
            'MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        browsepic.Visible = True
        savechangebtn.Visible = True
        usenametxt.ReadOnly = False
        email.ReadOnly = False
        contacttxt.ReadOnly = False
        schooltxt.ReadOnly = False
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles savechangebtn.Click
        Try
            ' Check if the profilepic.Image is not null
            If profilepic.Image IsNot Nothing Then
                Dim msstream As New MemoryStream()
                Dim img As New Bitmap(profilepic.Image)
                img.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrimage As Byte() = msstream.GetBuffer() ' Use ToArray() to get the byte array
                Dim filesize As Long = msstream.Length
                msstream.Close()

                con.ConnectionString = connection
                con.Open()

                sql = "UPDATE registration SET username=@username, email=@email, school=@school, contactnum=@contactnum, picture=@picture WHERE id=" & idnumbertxt.Text & ""
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.Parameters.AddWithValue("@username", usenametxt.Text)
                cmd.Parameters.AddWithValue("@email", email.Text)
                cmd.Parameters.AddWithValue("@school", schooltxt.Text)
                cmd.Parameters.AddWithValue("@contactnum", contacttxt.Text)
                cmd.Parameters.AddWithValue("@picture", arrimage)

                Dim x As Integer

                x = cmd.ExecuteNonQuery()

                If x > 0 Then
                    MessageBox.Show("Data Updated")
                Else
                    MessageBox.Show("Data not saved")
                End If

                browsepic.Visible = False
                savechangebtn.Visible = False
                usenametxt.ReadOnly = True
                email.ReadOnly = True
                contacttxt.ReadOnly = True
                schooltxt.ReadOnly = True
                cmd.Parameters.Clear()
                con.Close()
            Else
                'MessageBox.Show("Profile picture is not loaded.")
            End If
        Catch ex As Exception
            'MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub profilebtn_Click(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanel1(MenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub

    Private Sub profilepic_Click(sender As Object, e As EventArgs) Handles profilepic.Click

    End Sub
End Class