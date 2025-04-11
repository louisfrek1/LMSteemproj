﻿Imports MySqlConnector

Public Class studCalenAdd

    Dim connectionString As String = "Server=localhost;port=3306; user=root; password=; database=teem"

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Dim query As String = "INSERT INTO tcalendar (idnum, lastname, coursename, coursecode, title, typeofactivity, date) VALUES (@idnum, @lastname, @coursename, @coursecode, @title, @typeofactivity, @date)"

            Using connection As MySqlConnection = strconnection()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@idnum", StudSign.idnum)
                    cmd.Parameters.AddWithValue("@lastname", StudSign.lname)
                    cmd.Parameters.AddWithValue("@title", txttitle.Text)
                    cmd.Parameters.AddWithValue("@coursename", cmbcname.SelectedItem.ToString)
                    cmd.Parameters.AddWithValue("@coursecode", cmbccode.SelectedItem.ToString)
                    cmd.Parameters.AddWithValue("@typeofactivity", cmbevent.SelectedItem.ToString)
                    cmd.Parameters.AddWithValue("@date", datepcker.Value.ToString("yyyy-MM-dd")) ' Format the date correctly

                    connection.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Saved to database")
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub studCalenAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBoxByID()
    End Sub

    Private Sub PopulateComboBoxByID()
        Try
            Dim connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM studaddclass WHERE id = @id"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", StudSign.idnum)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            cmbcname.Items.Clear()
            cmbccode.Items.Clear()
            While reader.Read()
                cmbcname.Items.Add(reader("coursename").ToString())
                cmbccode.Items.Add(reader("coursecode").ToString())
            End While
            reader.Close()
            connection.Close()
        Catch ex As Exception
            'MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        TCalendar.Panel1.Hide()
    End Sub
End Class