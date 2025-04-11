Imports System.IO
Imports MySqlConnector

Public Class studnotif
    Dim str As String
    Dim con As New MySqlConnection("Server=localhost;user=root;password=;database=teem")
    Public teemgcode As String

    Private Sub studnotif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDynamicUserControl12()
        GenerateDynamicUserControl13()
        GenerateDynamicUserControl14()
        GenerateDynamicUserControl15()
        getteemcode()
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
                    Label1.Text = teemgcode
                ElseIf labelCounter = 2 Then
                    Label2.Text = teemgcode
                ElseIf labelCounter = 3 Then
                    Label3.Text = teemgcode
                ElseIf labelCounter = 4 Then
                    Label4.Text = teemgcode
                End If

                ' Increment the counter
                labelCounter += 1
            End While
        Else
            ' Handle no rows found
        End If

        con.Close()
    End Sub

    Public Sub GenerateDynamicUserControl12()
        'flpaneIcon.BringToFront()
        panelnot1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems12()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studnotifyuc

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studnotifyuc()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).Label1.Text = row("tfname").ToString() + row("tlname").ToString()
                        listItems(i).Label2.Text = "Posted an announcement on " + row("coursename").ToString()
                        listItems(i).Label3.Text = row("time").ToString()

                        panelnot1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub

    Public Sub GenerateDynamicUserControl13()
        'flpaneIcon.BringToFront()
        panelnot2.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems13()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studnotifyuc

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studnotifyuc()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).Label1.Text = row("tfname").ToString() + row("tlname").ToString()
                        listItems(i).Label2.Text = "Posted an announcement on " + row("coursename").ToString()
                        listItems(i).Label3.Text = row("time").ToString()

                        panelnot2.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub

    Public Sub GenerateDynamicUserControl14()
        'flpaneIcon.BringToFront()
        panelnot3.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems14()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studnotifyuc

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studnotifyuc()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).Label1.Text = row("tfname").ToString() + row("tlname").ToString()
                        listItems(i).Label2.Text = "Posted an announcement on " + row("coursename").ToString()
                        listItems(i).Label3.Text = row("time").ToString()

                        panelnot3.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub

    Public Sub GenerateDynamicUserControl15()
        'flpaneIcon.BringToFront()
        panelnot4.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems15()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As studnotifyuc

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New studnotifyuc()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))

                        listItems(i).Label1.Text = row("tfname").ToString() + row("tlname").ToString()
                        listItems(i).Label2.Text = "Posted an announcement on " + row("coursename").ToString()
                        listItems(i).Label3.Text = row("time").ToString()

                        panelnot4.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next
            End If
        End If
    End Sub
End Class