Imports System.IO
Imports MySqlConnector

Public Class MCourseForm

    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)

    Public Sub switchPanel1(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        flayoutcourse.BringToFront()
        GenerateDynamicUserControl3()
    End Sub

    Private Sub MCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idnumlblb.Text = StudSign.idnum
        dropdownpanel.Visible = False
        GenerateDynamicUserControl3()
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

    Public Sub GenerateDynamicUserControl3()
        flayoutcourse.BringToFront()
        'changepanel.SendToBack()
        flayoutcourse.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems3()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As StudCourse

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New StudCourse()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))
                        'listItems(i).pb_image.Image = New Bitmap(MS)

                        listItems(i).studcnametxtlink.Text = row("coursename").ToString()
                        listItems(i).studccodelbl.Text = row("coursecode").ToString()
                        listItems(i).studctimelbl.Text = row("time").ToString()

                        flayoutcourse.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next

            End If
        End If
    End Sub

    Private Sub idnumlblb_Click(sender As Object, e As EventArgs) Handles idnumlblb.Click

    End Sub

    Private Sub profilebtn_Click_1(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanel1(MenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub
End Class