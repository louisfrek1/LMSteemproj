Imports System.Runtime.CompilerServices
Imports MySqlConnector

Public Class TSignup
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
    Public Sub create(ByVal sql As String)

        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    'MessageBox.Show("FAILED TO SAVE THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        MainChoose.PanelSign.Controls.Clear()
        panel.TopLevel = False
        MainChoose.PanelSign.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        While MainChoose.PanelSign.Controls.Count > 0
            MainChoose.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(StudSign)
    End Sub

    Private Sub btnSUp_Click(sender As Object, e As EventArgs) Handles btnSUp.Click
        If txtfname.Text = "" And txtlname.Text = "" And txtfname.Text = "" And txtlname.Text = "" And txtemail.Text = "" And txtpass.Text = "" And txtphonenum.Text = "" Then
            MessageBox.Show("Please fill all the field")
        Else
            Try
                create("INSERT INTO teach_register(title,firstname,lastname,password,email,phonenum)VALUES('" & titlecmb.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtpass.Text & "','" & txtemail.Text & "','" & txtphonenum.Text & "')")


                While MainChoose.PanelSign.Controls.Count > 0
                    MainChoose.PanelSign.Controls(0).Dispose()
                End While
                switchPanel(TSignin)

            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub TSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlecmb.TabIndex = 0
        txtfname.TabIndex = 1
        txtlname.TabIndex = 2
        txtemail.TabIndex = 3
        txtpass.TabIndex = 4
        txtphonenum.TabIndex = 5
    End Sub

    Private Sub showpass_Click(sender As Object, e As EventArgs) Handles showpass.Click
        If txtpass.UseSystemPasswordChar = False Then
            txtpass.UseSystemPasswordChar = True
        Else
            txtpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        txtpass.UseSystemPasswordChar = True
    End Sub
End Class