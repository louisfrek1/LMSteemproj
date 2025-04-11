Imports MySqlConnector
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class studstartexam

    Dim str As String
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public stat As String
    Public item1 As Integer
    Public ques1 As String
    Public choice1a As String
    Public choice1b As String
    Public choice1c As String
    Public choice1d As String
    Public item2 As Integer
    Public ques2 As String
    Public choice2a As String
    Public choice2b As String
    Public choice2c As String
    Public choice2d As String
    Public item3 As Integer
    Public ques3 As String
    Public choice3a As String
    Public choice3b As String
    Public choice3c As String
    Public choice3d As String
    Public item4 As Integer
    Public ques4 As String
    Public choice4a As String
    Public choice4b As String
    Public choice4c As String
    Public choice4d As String
    Public item5 As Integer
    Public ques5 As String
    Public choice5a As String
    Public choice5b As String
    Public choice5c As String
    Public choice5d As String
    Public item6 As Integer
    Public ques6 As String
    Public choice6a As String
    Public choice6b As String
    Public choice6c As String
    Public choice6d As String
    Public item7 As Integer
    Public ques7 As String
    Public choice7a As String
    Public choice7b As String
    Public choice7c As String
    Public choice7d As String
    Public item8 As Integer
    Public ques8 As String
    Public choice8a As String
    Public choice8b As String
    Public choice8c As String
    Public choice8d As String
    Public item9 As Integer
    Public ques9 As String
    Public choice9a As String
    Public choice9b As String
    Public choice9c As String
    Public choice9d As String
    Public item10 As Integer
    Public ques10 As String
    Public choice10a As String
    Public choice10b As String
    Public choice10c As String
    Public choice10d As String

    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Try
            str = "SELECT * FROM examss WHERE coursegcode=@coursegcode"
            con.Open()

            Dim mysC As New MySqlCommand(str, con)
            mysC.Parameters.AddWithValue("@coursegcode", Label2.Text)

            Dim DR As MySqlDataReader = mysC.ExecuteReader()

            If DR.HasRows Then
                While DR.Read
                    item1 = DR.GetInt32("item1")
                    ques1 = DR.GetString("ques1")
                    choice1a = DR.GetString("choice1a")
                    choice1b = DR.GetString("choice1b")
                    choice1c = DR.GetString("choice1c")
                    choice1d = DR.GetString("choice1d")
                    item2 = DR.GetInt32("item2")
                    ques2 = DR.GetString("ques2")
                    choice2a = DR.GetString("choice2a")
                    choice2b = DR.GetString("choice2b")
                    choice2c = DR.GetString("choice2c")
                    choice2d = DR.GetString("choice2d")
                    item3 = DR.GetInt32("item3")
                    ques3 = DR.GetString("ques3")
                    choice3a = DR.GetString("choice3a")
                    choice3b = DR.GetString("choice3b")
                    choice3c = DR.GetString("choice3c")
                    choice3d = DR.GetString("choice3d")
                    item4 = DR.GetInt32("item4")
                    ques4 = DR.GetString("ques4")
                    choice4a = DR.GetString("choice4a")
                    choice4b = DR.GetString("choice4b")
                    choice4c = DR.GetString("choice4c")
                    choice4d = DR.GetString("choice4d")
                    item5 = DR.GetInt32("item5")
                    ques5 = DR.GetString("ques5")
                    choice5a = DR.GetString("choice5a")
                    choice5b = DR.GetString("choice5b")
                    choice5c = DR.GetString("choice5c")
                    choice5d = DR.GetString("choice5d")
                    item6 = DR.GetInt32("item6")
                    ques6 = DR.GetString("ques6")
                    choice6a = DR.GetString("choice6a")
                    choice6b = DR.GetString("choice6b")
                    choice6c = DR.GetString("choice6c")
                    choice6d = DR.GetString("choice6d")
                    item7 = DR.GetInt32("item7")
                    ques7 = DR.GetString("ques7")
                    choice7a = DR.GetString("choice7a")
                    choice7b = DR.GetString("choice7b")
                    choice7c = DR.GetString("choice7c")
                    choice7d = DR.GetString("choice7d")
                    item8 = DR.GetInt32("item8")
                    ques8 = DR.GetString("ques8")
                    choice8a = DR.GetString("choice8a")
                    choice8b = DR.GetString("choice8b")
                    choice8c = DR.GetString("choice8c")
                    choice8d = DR.GetString("choice8d")
                    item9 = DR.GetInt32("item9")
                    ques9 = DR.GetString("ques9")
                    choice9a = DR.GetString("choice9a")
                    choice9b = DR.GetString("choice9b")
                    choice9c = DR.GetString("choice9c")
                    choice9d = DR.GetString("choice9d")
                    item10 = DR.GetInt32("item10")
                    ques10 = DR.GetString("ques10")
                    choice10a = DR.GetString("choice10a")
                    choice10b = DR.GetString("choice10b")
                    choice10c = DR.GetString("choice10c")
                    choice10d = DR.GetString("choice10d")

                End While

                assessmentview.Label1.Text = item1
                assessmentview.ques1.Text = ques1
                assessmentview.multi1a.Text = choice1a
                assessmentview.multi1b.Text = choice1b
                assessmentview.multi1c.Text = choice1c
                assessmentview.multi1d.Text = choice1d
                assessmentview.Label10.Text = item2
                assessmentview.ques2.Text = ques2
                assessmentview.multi2a.Text = choice2a
                assessmentview.multi2b.Text = choice2b
                assessmentview.multi2c.Text = choice2c
                assessmentview.multi2d.Text = choice2d
                assessmentview.Label16.Text = item3
                assessmentview.ques3.Text = ques3
                assessmentview.multi3a.Text = choice3a
                assessmentview.multi3b.Text = choice3b
                assessmentview.multi3c.Text = choice3c
                assessmentview.multi3d.Text = choice3d
                assessmentview.Label22.Text = item4
                assessmentview.ques4.Text = ques4
                assessmentview.multi4a.Text = choice4a
                assessmentview.multi4b.Text = choice4b
                assessmentview.multi4c.Text = choice4c
                assessmentview.multi4d.Text = choice4d
                assessmentview.Label28.Text = item5
                assessmentview.ques5.Text = ques5
                assessmentview.multi5a.Text = choice5a
                assessmentview.multi5b.Text = choice5b
                assessmentview.multi5c.Text = choice5c
                assessmentview.multi5d.Text = choice5d
                assessmentview.Label34.Text = item6
                assessmentview.ques6.Text = ques6
                assessmentview.multi6a.Text = choice6a
                assessmentview.multi6b.Text = choice6b
                assessmentview.multi6c.Text = choice6c
                assessmentview.multi6d.Text = choice6d
                assessmentview.Label40.Text = item7
                assessmentview.ques7.Text = ques7
                assessmentview.multi7a.Text = choice7a
                assessmentview.multi7b.Text = choice7b
                assessmentview.multi7c.Text = choice7c
                assessmentview.multi7d.Text = choice7d
                assessmentview.Label46.Text = item7
                assessmentview.ques8.Text = ques7
                assessmentview.multi8a.Text = choice8a
                assessmentview.multi8b.Text = choice8b
                assessmentview.multi8c.Text = choice8c
                assessmentview.multi8d.Text = choice8d
                assessmentview.Label52.Text = item9
                assessmentview.ques9.Text = ques9
                assessmentview.multi9a.Text = choice9a
                assessmentview.multi9b.Text = choice9b
                assessmentview.multi9c.Text = choice9c
                assessmentview.multi9d.Text = choice9d
                assessmentview.Label58.Text = item10
                assessmentview.ques10.Text = ques10
                assessmentview.multi10a.Text = choice10a
                assessmentview.multi10b.Text = choice10b
                assessmentview.multi10c.Text = choice10c
                assessmentview.multi10d.Text = choice10d
                While Me.Panel1.Controls.Count > 0
                    Me.Panel1.Controls(0).Dispose()
                End While
                switchPanel(assessmentview)
            Else
                MessageBox.Show("Username and password did not match.")
            End If

        Catch ex As Exception
            'MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub studstartexam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class