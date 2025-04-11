Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Enums
Imports MySqlConnector
Imports System.IO

Public Class CalendarForm

    Private listbtnDay As New List(Of Guna2Button)
    Private currentDate As DateTime = DateTime.Today
    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)

    Public Sub switchPanel1(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub CalendarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        AddLabelDayTobtnDay(GetFirstDayOfWeekOfCurrentDate(), GetTotalDaysOfCurrentDate())
        DisplayCurrentDate()
        dropdownpanel.Visible = False
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

    Private Sub profilebtn_Click_1(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanel1(MenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub

    Public Sub switchPanelTCalen(ByVal panel As Form)
        'switch panel from mainframe

        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub DisplayCurrentDate()
        Label1.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtbtnNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayTobtnDay(firstDayAtbtnNumber, totalDay)
        AddPlanTobtnDay(firstDayAtbtnNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub AddNewAppointment(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, Guna2Button).Tag
        If day <> 0 Then
            studCalenAdd.datepcker.Value = New Date(currentDate.Year, currentDate.Month, CType(sender, Guna2Button).Tag)
            Panel1.BringToFront()
            While Me.Panel1.Controls.Count > 0
                Me.Panel1.Controls(0).Dispose()
            End While
            switchPanelTCalen(studCalenAdd)
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub AddPlanTobtnDay(ByVal startDayAtbtnNumber As Integer)

        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        Dim sql As String = $"SELECT * FROM tcalendar WHERE date BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'"
        Dim dt As DataTable = QueryAsDataTable(sql)

        For Each row As DataRow In dt.Rows
            Dim dateset As DateTime = DateTime.Parse(row("date"))
            Dim link As New LinkLabel
            link.Name = $"link{row("lastname")}"
            link.BringToFront()
            link.Text = row("title")
            link.Location = New Point(0, 21)
            'link.ForeColor = Color.Black
            listbtnDay(dateset.Day + (startDayAtbtnNumber - 1)).Controls.Add(link)
        Next
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function
    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listbtnDay.Clear()

        For i As Integer = 1 To totalDays
            Dim btn As New Guna2Button
            btn.Name = $"btnDay{i}"
            'btn.SendToBack()
            btn.Size = New Size(66, 66)
            btn.FillColor = Color.Transparent
            btn.BorderColor = Color.Black
            btn.Cursor = Cursors.Hand
            AddHandler btn.Click, AddressOf AddNewAppointment
            btn.BorderStyle = BorderStyle.FixedSingle
            flDays.Controls.Add(btn)
            listbtnDay.Add(btn)
        Next
    End Sub

    Private Sub AddLabelDayTobtnDay(ByVal startDayAtbtnNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each btn As Guna2Button In listbtnDay
            btn.ButtonMode = ButtonMode.RadioButton
            btn.Controls.Clear()
            btn.Tag = 0
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            'lbl.BringToFront()
            lbl.ForeColor = Color.Black
            lbl.TextAlign = ContentAlignment.TopRight
            lbl.Size = New Size(60, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 9)
            listbtnDay((i - 1) + (startDayAtbtnNumber - 1)).Tag = i
            listbtnDay((i - 1) + startDayAtbtnNumber).Controls.Add(lbl)
        Next
    End Sub

    Private Sub nexbtn_Click(sender As Object, e As EventArgs) Handles nexbtn.Click
        NextMonth()
    End Sub

    Private Sub prevbtn_Click(sender As Object, e As EventArgs) Handles prevbtn.Click
        PrevMonth()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Today()
    End Sub
End Class