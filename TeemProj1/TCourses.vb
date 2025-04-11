Imports System.IO
Imports MySqlConnector

Public Class TCourses
    Private ReadOnly pb_image As Object
    Private cnametxtlink As TDisplayCourses
    'Private ccodelbl As Object
    'Private ctimelbl As Object
    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)

    Public Sub switchPanelTC(ByVal panel As Form)
        'switch panel from mainframe

        addcoursepan.Controls.Clear()
        panel.TopLevel = False
        addcoursepan.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanelTAdd(ByVal panel As Form)
        'switch panel from mainframe

        TMainForm.Tmainpanel.Controls.Clear()
        panel.TopLevel = False
        TMainForm.Tmainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanelTP(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanelTAC(ByVal panel As Form)
        'switch panel from mainframe

        TMainForm.Tmainpanel.Controls.Clear()
        panel.TopLevel = False
        TMainForm.Tmainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub addcoursebtn_Click(sender As Object, e As EventArgs) Handles addcoursebtn.Click
        addcoursepan.Visible = True
        addcoursepan.BringToFront()
        flpaneIcon.SendToBack()
        While Me.addcoursepan.Controls.Count > 0
            Me.addcoursepan.Controls(0).Dispose()
        End While
        switchPanelTC(TAddCourse)
    End Sub





    Public Sub GenerateDynamicUserControl()
        'flpaneIcon.BringToFront()
        flpaneIcon.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As TDisplayCourses

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New TDisplayCourses()

                        Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).pb_image1.Image = Image.FromStream(MS)
                        listItems(i).cnametxtlink.Text = row("coursename").ToString()
                        listItems(i).ccodelbl.Text = row("coursecode").ToString()
                        listItems(i).ctimelbl.Text = row("time").ToString()

                        flpaneIcon.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub



    Private Sub TCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpaneIcon.BringToFront()
        addcoursepan.SendToBack()
        addassessmentbtn.Visible = False
        dropdownpanel.Visible = False
        Label1.Text = TSignin.idnum
        GenerateDynamicUserControl()

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
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub flpaneIcon_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub addassessmentbtn_Click(sender As Object, e As EventArgs) Handles addassessmentbtn.Click
        While Me.addcoursepan.Controls.Count > 0
            Me.addcoursepan.Controls(0).Dispose()
        End While
        switchPanelTC(TCreateAssess)
    End Sub

    Private Sub profilebtn_Click_1(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanelTP(TMenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub
End Class