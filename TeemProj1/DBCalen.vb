Imports MySqlConnector
Module DBCalen
    Private cn As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")

    Public Sub Connect()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub

    Public Function InsertUpdateDelete(ByVal sql As String) As Boolean
        Connect()
        Dim cmd As New MySqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery() > 0
    End Function

    Public Function IsConfirm(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Dim da As New MySqlDataAdapter(sql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "result")
        Return ds.Tables("result")
    End Function

End Module
