Imports System.Data.SqlClient
Imports MySqlConnector
Imports Newtonsoft.Json.Linq

Public Class studaddclass

    Dim con As New MySqlConnection("Server=localhost; user=root; password=; database=teem")
    Dim connectionString As String = "Server=localhost; user=root; password=; database=teem"
    Dim connection As New SqlConnection(connectionString)
    Dim str As String
    Public coname As String
    Public cocode As String
    Public coday As String
    Public cotime As String
    Public coterm As String
    Public coroom As String
    Public coprog As String
    Public cotid As Integer

    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        MainForm.mainpanel.Controls.Clear()
        panel.TopLevel = False
        MainForm.mainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If txtsearchgcode.Text = "" Then
            MessageBox.Show("There's no such code.", "Message..")
        Else
            Try
                str = "SELECT * FROM teach_addcourse1 WHERE coursegcode=@coursegcode"
                con.Open()

                Dim mysC As New MySqlCommand(str, con)
                mysC.Parameters.AddWithValue("@coursegcode", txtsearchgcode.Text)

                Dim DR As MySqlDataReader = mysC.ExecuteReader()

                If DR.HasRows Then
                    While DR.Read
                        coname = DR.GetString("coursename")
                        cocode = DR.GetString("coursecode")
                        coday = DR.GetString("day")
                        cotime = DR.GetString("time")
                        coterm = DR.GetString("term")
                        coprog = DR.GetString("program")
                        coroom = DR.GetString("room")
                        cotid = DR.GetInt32("id")



                    End While
                    cnamelbl.Visible = True
                    ccodelbl.Visible = True
                    cdaylbl.Visible = True
                    ctermlbl.Visible = True
                    ctimelbl.Visible = True
                    cproglbl.Visible = True
                    croomlbl.Visible = True
                    cnamelbl.Text += coname
                    ccodelbl.Text += cocode
                    cdaylbl.Text += coday
                    ctimelbl.Text += cotime
                    ctermlbl.Text += coterm
                    cproglbl.Text += coprog
                    croomlbl.Text += coroom

                Else
                    'MessageBox.Show("Username and password did not match.")
                End If

            Catch ex As Exception
                'MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub studaddclass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnamelbl.Visible = False
        ccodelbl.Visible = False
        cdaylbl.Visible = False
        ctermlbl.Visible = False
        ctimelbl.Visible = False
        cproglbl.Visible = False
        croomlbl.Visible = False
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If txtsearchgcode.Text = "" Then
            MessageBox.Show("There's no such code.", "Message..")
        Else
            Try
                con.Open()

                Dim theQuery As String = "SELECT * FROM studaddclass WHERE coursegcode=@coursegcode and id=@id"

                Dim cmd1 As MySqlCommand = New MySqlCommand(theQuery, con)
                cmd1.Parameters.AddWithValue("coursegcode", txtsearchgcode.Text)
                cmd1.Parameters.AddWithValue("@id", StudSign.idnum)

                Using reader As MySqlDataReader = cmd1.ExecuteReader()
                    If reader.HasRows Then
                        MsgBox("Course already exist!", MsgBoxStyle.Exclamation, "Add another course!")
                        txtsearchgcode.Clear()
                        cnamelbl.Visible = False
                        ccodelbl.Visible = False
                        cdaylbl.Visible = False
                        ctermlbl.Visible = False
                        ctimelbl.Visible = False
                        cproglbl.Visible = False
                        croomlbl.Visible = False

                    Else
                        create("INSERT INTO studaddclass(coursename,coursecode,coursegcode,time,tidnum,id,studfname,studlname)VALUES('" & coname & "','" & cocode & "','" & txtsearchgcode.Text & "','" & cotime & "','" & cotid & "','" & StudSign.idnum & "','" & StudSign.fname & "','" & StudSign.lname & "')")
                        txtsearchgcode.Clear()
                        cnamelbl.Visible = False
                        ccodelbl.Visible = False
                        cdaylbl.Visible = False
                        ctermlbl.Visible = False
                        ctimelbl.Visible = False
                        cproglbl.Visible = False
                        croomlbl.Visible = False
                    End If
                End Using
                ' The connection will be automatically closed when exiting this block
            Catch ex As Exception
                'MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                con.Close()
            End Try

        End If
    End Sub

End Class