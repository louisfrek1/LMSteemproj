Imports MySqlConnector
Imports System.IO

Public Class TClassList
    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)
    Public Sub switchPanelTP(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub TClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropdownpanel.Visible = False
        GenerateDynamicUserControl11()

        Dim connection As New MySqlConnection(connStr)
        Dim command As New MySqlCommand("SELECT picture FROM registration WHERE id = @userId", connection)
        command.Parameters.AddWithValue("@userId", StudSign.idnum Or StudSignUp.idnum) ' Replace with the actual user ID

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

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanelTP(MenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub


    Public Sub GenerateDynamicUserControl11()
        'flpaneIcon.BringToFront()
        FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems11()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studclasslistmenu

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studclasslistmenu()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))
                        'listItems(i).pb_image.Image = New Bitmap(MS)

                        listItems(i).cname.Text = row("coursename").ToString()
                        listItems(i).Label2.Text = row("coursegcode").ToString()
                        listItems(i).Label3.Text = row("coursecode").ToString()

                        FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub
End Class