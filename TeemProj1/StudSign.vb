Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Design
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class StudSign

    Dim con As New MySqlConnection("Server=localhost;port=3307; user=root; password=; database=teem")
    Dim str As String
    Public email As String
    Public usname As String
    Public fname As String
    Public idnum As Integer
    Public schoolna As String
    Public connum As Integer
    Public lname As String

    Public Function Open() As MySqlConnection
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSignUp.LinkClicked

        While MainChoose.PanelSign.Controls.Count > 0
            MainChoose.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(StudSignUp)

    End Sub
    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        MainChoose.PanelSign.Controls.Clear()
        panel.TopLevel = False
        MainChoose.PanelSign.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanel1(ByVal panel As Form)
        'switch panel from mainframe

        MainForm.mainpanel.Controls.Clear()
        panel.TopLevel = False
        MainForm.mainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        If txtUn.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Username and Password are required.", "Message..")
        Else
            Try
                str = "SELECT * FROM registration WHERE username=@username AND password=@password"
                con.Open()

                Dim mysC As New MySqlCommand(str, con)
                mysC.Parameters.AddWithValue("@username", txtUn.Text)
                mysC.Parameters.AddWithValue("@password", txtPass.Text)

                Dim DR As MySqlDataReader = mysC.ExecuteReader()

                If DR.HasRows Then
                    While DR.Read
                        fname = DR.GetString("firstname")
                        lname = DR.GetString("lastname")
                        email = DR.GetString("email")
                        usname = DR.GetString("username")
                        idnum = DR.GetInt32("id")
                        schoolna = DR.GetString("school")
                        connum = DR.GetInt32("contactnum")
                    End While
                    txtPass.Clear()
                    txtUn.Clear()
                    MainForm.Show()
                    MainChoose.Hide()
                Else
                    MessageBox.Show("Username and password did not match.")
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If



    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        While MainChoose.PanelSign.Controls.Count > 0
            MainChoose.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(PanelChoose)
    End Sub

    Private Sub StudSign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            If txtUn.Text = "" Or txtPass.Text = "" Then
                MessageBox.Show("Username and Password are required.", "Message..")
            Else
                Try
                    str = "SELECT * FROM registration WHERE username=@username AND password=@password"
                    con.Open()

                    Dim mysC As New MySqlCommand(str, con)
                    mysC.Parameters.AddWithValue("@username", txtUn.Text)
                    mysC.Parameters.AddWithValue("@password", txtPass.Text)

                    Dim DR As MySqlDataReader = mysC.ExecuteReader()

                    If DR.HasRows Then
                        While DR.Read
                            fname = DR.GetString("firstname")
                            lname = DR.GetString("lastname")
                            email = DR.GetString("email")
                            usname = DR.GetString("username")
                            idnum = DR.GetInt32("id")
                            schoolna = DR.GetString("school")
                            connum = DR.GetInt32("contactnum")

                        End While

                        MainForm.Show()
                        MainChoose.Hide()
                    Else
                        MessageBox.Show("Username and password did not match.")
                    End If

                Catch ex As Exception
                    'MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub showpass_Click(sender As Object, e As EventArgs) Handles showpass.Click
        If txtPass.UseSystemPasswordChar = False Then
            txtPass.UseSystemPasswordChar = True
        Else
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        txtPass.UseSystemPasswordChar = True
    End Sub
End Class