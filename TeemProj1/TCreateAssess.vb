Imports MySqlConnector
Imports System.Web.UI.WebControls

Public Class TCreateAssess

    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)

    Private Sub coursenametlbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles examtype.SelectedIndexChanged
    End Sub

    Public Sub switchPanelTAS(ByVal panel As Form)
        'switch panel from mainframe

        Me.FlowLayoutPanel1.Controls.Clear()
        panel.TopLevel = False
        Me.FlowLayoutPanel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        While Me.FlowLayoutPanel1.Controls.Count > 0
            Me.FlowLayoutPanel1.Controls(0).Dispose()
        End While
        switchPanelTAS(_20itemsassess)

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles noitemscmb.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Public Sub Createdbtable()
        Dim table1 As String = teemgcode.Text + assessno.Text
        Try
            conn.Open()

            Dim createTableQuery As String = "CREATE TABLE " & table1 & " (
        ID INT AUTO_INCREMENT PRIMARY KEY,
        tidnum INT(11) NOT NULL,
        assesstype VARCHAR(50) NOT NULL,
        assessno INT(11) NOT NULL,
        teemcode VARCHAR(7) NOT NULL,
        itemnum INT(11) NOT NULL,
        question VARCHAR(200) NOT NULL,
        choicea VARCHAR(200) NOT NULL,
        choiceb VARCHAR(200) NOT NULL,
        choicec VARCHAR(200) NOT NULL,
        choiced VARCHAR(200) NOT NULL,
        ans VARCHAR(50) NOT NULL
    )"

            Dim cmd As New MySqlCommand(createTableQuery, conn)
            cmd.ExecuteNonQuery()

            'MessageBox.Show("Table created successfully!")

        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub TCreateAssess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class