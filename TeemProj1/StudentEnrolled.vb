Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms
Imports MySqlConnector

Public Class StudentEnrolled

    Dim connectionString As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PopulateComboBoxByID()
        Try
            Dim connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM teach_addcourse1 WHERE id = @id"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", TStudent.Label1.Text)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            classescmb.Items.Clear()
            While reader.Read()
                classescmb.Items.Add(reader("coursegcode").ToString())
            End While
            reader.Close()
            connection.Close()
        Catch ex As Exception
            'MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub classescmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classescmb.SelectedIndexChanged
        Try
            Dim selectedCourse As String = classescmb.SelectedItem.ToString()

            Dim connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Modify the SQL query to select specific columns (column1, column2, column3)
            Dim query As String = "SELECT id, studfname, studlname FROM studaddclass WHERE coursegcode = @coursegcode"

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@coursegcode", selectedCourse)

            Dim adapter As New MySqlDataAdapter(command)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet, "CourseData")

            DGVstud.DataSource = dataSet.Tables("CourseData")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub StudentEnrolled_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBoxByID()
    End Sub

    Private Sub DGVstud_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVstud.CellContentClick

    End Sub

    Private Sub DGVstud_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVstud.CellMouseClick
        If e.Button = MouseButtons.Right Then
            Guna2ContextMenuStrip1.Show(DGVstud, e.Location)
        End If
    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        If DGVstud.SelectedCells.Count > 0 Then
            Dim rowIndex As Integer = DGVstud.SelectedCells(0).RowIndex

            ' Assuming your DataGridView is bound to a DataTable
            Dim dataTable As DataTable = CType(DGVstud.DataSource, DataTable)

            ' Ensure the row index is within valid range
            If rowIndex >= 0 And rowIndex < dataTable.Rows.Count Then
                ' Get the student ID from the first column
                Dim studentID As Integer = Convert.ToInt32(dataTable.Rows(rowIndex)(0))

                ' Update the database
                UpdateDatabase(studentID)

                ' Remove the row from the DataTable
                dataTable.Rows.RemoveAt(rowIndex)

                ' Refresh the DataGridView
                DGVstud.Refresh()
            End If
        End If
    End Sub

    Private Sub UpdateDatabase(studentID As Integer)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Implement your SQL DELETE command
                Dim deleteCommand As String = "DELETE FROM studaddclass WHERE id = @id AND coursegcode=@cgcode"

                Using command As New MySqlCommand(deleteCommand, connection)
                    command.Parameters.AddWithValue("@id", studentID)
                    command.Parameters.AddWithValue("@cgcode", classescmb.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Data deleted successfully.")
        Catch ex As Exception
            MsgBox("An error occurred while deleting data: " & ex.Message)
        End Try
    End Sub
End Class