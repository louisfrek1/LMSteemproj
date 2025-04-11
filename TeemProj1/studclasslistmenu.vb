Imports MySqlConnector

Public Class studclasslistmenu
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim connectionString As String = "Server=localhost;port=3306; user=root; password=; database=teem"

        ' Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the database connection
            connection.Open()

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

    Private Sub studclasslistmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Guna2Button1.Click, Sub(senderLabel As Object, eLabel As EventArgs)
                                           Me.OnClick(eLabel)
                                       End Sub
    End Sub
End Class
