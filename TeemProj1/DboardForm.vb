Imports MySqlConnector
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class DboardForm
    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Dim conn As New MySqlConnection(connStr)
    Dim str As String
    Public numofclass As String

    Private Sub DboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getteemcode()
        dropdownpanel.Visible = False
        Label1.Text += StudSign.fname + "!"
        noOfClasses()
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
                End If
            End If


        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

        While Me.UpdatePanel.Controls.Count > 0
            Me.Controls(0).Dispose()
        End While
        switchPanel(UpdateForm)
    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        UpdatePanel.Controls.Clear()
        panel.TopLevel = False
        UpdatePanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub getteemcode()
        str = "SELECT * FROM studaddclass WHERE id=@id"
        con.Open()

        Dim mysC As New MySqlCommand(str, con)
        mysC.Parameters.AddWithValue("@id", StudSign.idnum)

        Dim DR As MySqlDataReader = mysC.ExecuteReader()

        If DR.HasRows Then
            ' Initialize a counter for the labels
            Dim labelCounter As Integer = 1

            While DR.Read
                ' Get the coursegcode for the current row
                Dim teemgcode As String = DR.GetString("coursegcode")

                ' Update the labels based on the counter
                If labelCounter = 1 Then
                    Label5.Text = teemgcode
                ElseIf labelCounter = 2 Then
                    Label6.Text = teemgcode
                ElseIf labelCounter = 3 Then
                    Label7.Text = teemgcode
                ElseIf labelCounter = 4 Then
                    Label8.Text = teemgcode
                End If

                ' Increment the counter
                labelCounter += 1
            End While
        Else
            ' Handle no rows found
        End If

        con.Close()
    End Sub


    Public Sub noOfClasses()
        Try
            str = "SELECT count(*) FROM studaddclass WHERE id=@id"
            con.Open()

            Dim mysC As New MySqlCommand(str, con)
            mysC.Parameters.AddWithValue("@id", StudSign.idnum)

            Dim count As Integer = Convert.ToInt32(mysC.ExecuteScalar())

            Label3.Text = count

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub switchPanelcopan(ByVal panel As Form)
        'switch panel from mainframe

        courpan.Controls.Clear()
        panel.TopLevel = False
        courpan.Controls.Add(panel)
        panel.Show()

    End Sub
    Public Sub switchPanel1(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub profilebtn_Click(sender As Object, e As EventArgs)
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanel1(MenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub

    Private Sub dropdownpanel_Paint(sender As Object, e As PaintEventArgs) Handles dropdownpanel.Paint

    End Sub

    Private Sub btnBcourses_Click(sender As Object, e As EventArgs) Handles btnBcourses.Click
        courpan.BringToFront()
        While Me.courpan.Controls.Count > 1
            Me.Controls(1).Dispose()
        End While
        switchPanelcopan(studaddclass)
    End Sub

    Private Sub profilebtn_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanel1(MenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanel1(studnotif)
        Else
            dropdownpanel.Hide()
            studnotif.Hide()

        End If
    End Sub
End Class