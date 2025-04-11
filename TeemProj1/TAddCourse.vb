Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports MySqlConnector

Public Class TAddCourse

#Region "declaration"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim dadapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim objdatareader As MySqlDataReader
    Public result As String
    Dim str1 As String
    Public cname As String
    Public coursegcode As String
    Public csched As String
    Dim COP As New TCourseFeed
    Private courname As String
    Private coursched As String
    Private courgcode As String

    Public Property stringpass As String
    Public Property stringpass1 As String

    Public Property stringpass2 As String
    Public Function strconnection() As MySqlConnection

        Return New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")

    End Function
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public strcon As MySqlConnection = strconnection()
#End Region

#Region "command"
    Sub autnumber()
        Dim autoID As Single
        mycmd = myconnection.open.CreateCommand
        mycmd.CommandText = "select count(*) as ValueZ from teach_addcourse"
        objdatareader = mycmd.ExecuteReader
        While objdatareader.Read
            autoID = Val(objdatareader.Item("ValueZ").ToString) + 2
        End While
        Select Case Len(Trim(autoID))
            Case 1 : teemcodetxt.Text = "M" + Trim(Str(autoID)) + "E" + Format(Now, "ds")
            Case 2 : teemcodetxt.Text = "T" + Trim(Str(autoID)) + "Z" + Format(Now, "ds")
            Case 3 : teemcodetxt.Text = "C" + Trim(Str(autoID)) + "J" + Format(Now, "ds")
        End Select
        mycmd = myconnection.close.CreateCommand
    End Sub

    Public Sub create(ByVal sql As String)

        Try
            strcon.Open()
            With mycmd
                .Connection = strcon
                .CommandText = sql
                result = mycmd.ExecuteNonQuery
                If result = 0 Then
                    'MessageBox.Show("FAILED TO SAVE THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                End If
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub



#End Region
    Private Sub TAddCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TCourses.addcoursebtn.Visible = False
        idtxt.Text = TSignin.idnum
        lastnametxt.Text = TSignin.lname
    End Sub

    Public Sub switchPanelTAC(ByVal panel As Form)
        'switch panel from mainframe

        TMainForm.Tmainpanel.Controls.Clear()
        panel.TopLevel = False
        TMainForm.Tmainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanelTCS(ByVal panel As Form)
        'switch panel from mainframe

        TCourses.addcoursepan.Controls.Clear()
        panel.TopLevel = False
        TCourses.addcoursepan.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbhour.SelectedIndexChanged
        If cmbhour.SelectedItem = "2 Hours" Then
            cmbtime.Items.Add("8:00 AM - 10:00 AM")
            cmbtime.Items.Add("10:00 AM - 12:00 PM")
            cmbtime.Items.Add("12:30 PM - 2:30 PM")
            cmbtime.Items.Add("2:30 PM - 4:30 PM")
            cmbtime.Items.Add("4:30 PM - 6:30 PM")
            cmbtime.Items.Add("6:30 PM - 8:30 PM")

        Else
            cmbtime.Items.Add("8:00 AM - 9:00 AM")
            cmbtime.Items.Add("9:00 AM - 10:00 PM")
            cmbtime.Items.Add("10:00 AM - 11:00 AM")
            cmbtime.Items.Add("12:30 PM - 1:30 PM")
            cmbtime.Items.Add("1:30 PM - 2:30 PM")
            cmbtime.Items.Add("2:30 PM - 3:30 PM")
            cmbtime.Items.Add("3:30 PM - 4:30 PM")
            cmbtime.Items.Add("5:30 PM - 6:30 PM")
            cmbtime.Items.Add("6:30 PM - 7:30 PM")
            cmbtime.Items.Add("7:30 PM - 8:30 PM")
            cmbtime.Items.Add("8:30 PM - 9:30 PM")
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        While TMainForm.Tmainpanel.Controls.Count > 0
            TMainForm.Tmainpanel.Controls(0).Dispose()
        End While
        switchPanelTAC(TCourses)
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim objbll As New ClassBLL()
        Try
            con.Open()

            Dim theQuery As String = "SELECT * FROM teach_addcourse1 WHERE coursegcode=@coursegcode and id=@id"

            Dim cmd1 As MySqlCommand = New MySqlCommand(theQuery, con)
            cmd1.Parameters.AddWithValue("coursegcode", teemcodetxt.Text)
            cmd1.Parameters.AddWithValue("@id", TSignin.idnum)

            Using reader As MySqlDataReader = cmd1.ExecuteReader()
                If reader.HasRows Then
                    MsgBox("Course already exist!", MsgBoxStyle.Exclamation, "Add another course!")

                Else
                    objbll.SaveItems(idtxt.Text, lastnametxt.Text, txtcname.Text, txtccode.Text, txtctitle.Text, teemcodetxt.Text, cmbcday.SelectedItem.ToString(), cmbhour.SelectedItem.ToString(), cmbtime.SelectedItem.ToString(), cmbterm.SelectedItem.ToString(), txtcroom.Text, cmbcprogram.SelectedItem.ToString(), pb_image.Image)
                    Me.Hide()
                    While TMainForm.Tmainpanel.Controls.Count > 0
                        TMainForm.Tmainpanel.Controls(0).Dispose()
                    End While
                    switchPanelTAC(TCourses)
                End If
            End Using
            ' The connection will be automatically closed when exiting this block
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        autnumber()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles pb_image.Click

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim opendlg As New OpenFileDialog()
        If (opendlg.ShowDialog() = DialogResult.OK) Then
            Dim selectedImage As Image = Image.FromFile(opendlg.FileName)
            pb_image.Image = selectedImage
        End If
    End Sub
End Class