Imports System.Data.SqlClient
Imports MySqlConnector
Imports System.Runtime.CompilerServices

Public Class Tclasses

    Public coursenamecl As String
    Public coursecodecl As Integer
    Public coursegcodecl As String

    Private Sub Tclasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler Guna2Button1.Click, Sub(senderLabel As Object, eLabel As EventArgs)
                                           Me.OnClick(eLabel)
                                       End Sub
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Define the connection string for MySQL
        Dim connectionString As String = "Server=localhost;port=3306; user=root; password=; database=teem"

        ' Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the database connection
            connection.Open()

            ' Define your DELETE query
            Dim deleteQuery As String = "DELETE FROM teach_addcourse1 WHERE id = @id AND coursename=@coursename"


            ' Create a MySqlCommand object
            Dim deleteCommand As New MySqlCommand(deleteQuery, connection)

            ' Add the parameter for the id to delete
            deleteCommand.Parameters.AddWithValue("@id", TSignin.idnum)
            deleteCommand.Parameters.AddWithValue("@coursename", cname.Text)
            ' Execute the DELETE query
            deleteCommand.ExecuteNonQuery()

            Dim deleteQuery1 As String = "DELETE FROM studaddclass WHERE coursecode = @coursecode AND coursename=@coursename"


            ' Create a MySqlCommand object
            Dim deleteCommandstud As New MySqlCommand(deleteQuery1, connection)

            ' Add the parameter for the id to delete
            deleteCommandstud.Parameters.AddWithValue("@coursecode", Label3.Text)
            deleteCommandstud.Parameters.AddWithValue("@coursename", cname.Text)
            ' Execute the DELETE query
            deleteCommandstud.ExecuteNonQuery()


        Catch ex As Exception
            ' Handle any exceptions
            ' MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub

    Private Sub retrievedelcour()

        Dim connectionString As String = "Server=localhost;port=3306; user=root; password=; database=teem"
        Dim connection As New SqlConnection(connectionString)

        Try

            connection.Open()

            Dim insertQuery As String = "INSERT INTO deletedcourse (id, lastname, coursename, coursecode, couresgcode) VALUES (@id, @lastname, @coursename, @coursecode, @coursegcode)"

            Dim command As New SqlCommand(insertQuery, connection)

            command.Parameters.AddWithValue("@id", TSignin.idnum)
            command.Parameters.AddWithValue("@lastname", TSignin.lname)
            command.Parameters.AddWithValue("@coursename", cname.Text)
            command.Parameters.AddWithValue("@coursecode", Label3.Text)
            command.Parameters.AddWithValue("@coursegcode", Label2.Text)

            command.ExecuteNonQuery()

            MessageBox.Show("Data added successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally

            connection.Close()
        End Try
    End Sub
End Class
