Imports MySqlConnector

Public Class DTConnection
    Dim conect As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public Function open()
        Try
            conect.Open()
        Catch ex As Exception
        End Try

        Return conect
    End Function

    Public Function close()
        Try
            conect.Close()
        Catch ex As Exception

        End Try
        Return conect
    End Function
End Class
