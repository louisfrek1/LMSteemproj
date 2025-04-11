Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports MySqlConnector
Imports System.Data.Common
Imports System.Web.UI.WebControls
Imports System.Runtime.CompilerServices

Public Class StudSignUp

    Public Function strconnection() As MySqlConnection

        Return New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")

    End Function
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Dim str As String
    Public fname As String
    Public lname As String
    Public usname As String
    Public email As String
    Public idnum As Integer
    Public schoolna As String
    Public connum As Integer
    Public img As Image

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        While MainChoose.PanelSign.Controls.Count > 0
            MainChoose.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(StudSign)
    End Sub
    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        MainChoose.PanelSign.Controls.Clear()
        panel.TopLevel = False
        MainChoose.PanelSign.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSUp.Click

        If txtUn.Text = "" And txtPass.Text = "" And txtFname.Text = "" And txtlname.Text = "" And txtEmail.Text = "" Then
            MessageBox.Show("Please fill all the field")
        Else
            Try

                create("INSERT INTO registration(username,password,firstname,lastname,email)VALUES('" & txtUn.Text & "','" & txtPass.Text & "','" & txtFname.Text & "','" & txtlname.Text & "','" & txtEmail.Text & "')")

                While MainChoose.PanelSign.Controls.Count > 0
                    MainChoose.PanelSign.Controls(0).Dispose()
                End While
                switchPanel(StudSign)

            Catch ex As Exception

            End Try
        End If


    End Sub

    'to save data to phpmyadmin
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
            'MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    'to load data

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

    Private Sub StudSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFname.TabIndex = 0
        txtlname.TabIndex = 1
        txtUn.TabIndex = 2
        txtPass.TabIndex = 3
        txtEmail.TabIndex = 4
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