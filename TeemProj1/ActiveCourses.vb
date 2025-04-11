Imports MySqlConnector

Public Class ActiveCourses

    Dim str As String
    Dim con As New MySqlConnection("Server=localhost;user=root;password=;database=teem")
    Public cteemc As String

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActiveCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDynamicUserControl12()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub GenerateDynamicUserControl12()
        'flpaneIcon.BringToFront()
        FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems12()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studnotifyuc

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studnotifyuc()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).Label1.Text = row("firstname").ToString() + row("lastname").ToString()
                        listItems(i).Label2.Text = "Posted an announcement on " + row("coursename").ToString()

                        FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub

    Public Sub GenerateDynamicUserControl13()
        'flpaneIcon.BringToFront()
        FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems13()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studnotifyuc

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studnotifyuc()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).Label1.Text = row("firstname").ToString() + row("lastname").ToString()
                        listItems(i).Label2.Text = "Posted an announcement on " + row("coursename").ToString()

                        FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub

    Public Sub GenerateDynamicUserControl14()
        'flpaneIcon.BringToFront()
        FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems14()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studnotifyuc

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studnotifyuc()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).Label1.Text = row("firstname").ToString() + row("lastname").ToString()
                        listItems(i).Label2.Text = "Posted an announcement on " + row("coursename").ToString()

                        FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub

    Public Sub GenerateDynamicUserControl15()
        'flpaneIcon.BringToFront()
        FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems15()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studnotifyuc

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studnotifyuc()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).Label1.Text = row("firstname").ToString() + row("lastname").ToString()
                        listItems(i).Label2.Text = "Posted an announcement on " + row("coursename").ToString()

                        FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub
End Class