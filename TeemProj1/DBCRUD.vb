Imports MySqlConnector
Imports MySqlConnector.MySqlClient

Module DBCRUD

    Public Function strconnection() As MySqlConnection

        Return New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")

    End Function
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Function open() As MySqlConnection
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function

    Public Function Close() As MySqlConnection
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function

    Public Sub create(ByVal sql As String)

        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO SAVE THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)

        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.dataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("DATA FAILED TO UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'MessageBox.Show("DATA HAS BEEN UPDATED IN THE DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("DATA FAILED TO DELETE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'MessageBox.Show("DATA HAS BEEN DELETED IN THE DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub search(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("NO MATCH FOUND IN THE DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'MessageBox.Show("DATA HAS BEEN FOUND IN THE DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try

    End Sub
End Module
