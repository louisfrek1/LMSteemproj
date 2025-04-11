Imports MySqlConnector

Public Class TSignin

    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Dim str As String
    Public email As String
    Public usname As String
    Public fname As String
    Public lname As String
    Public idnum As Integer
    Public schoolna As String
    Public connum As Integer
    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        MainChoose.PanelSign.Controls.Clear()
        panel.TopLevel = False
        MainChoose.PanelSign.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub LinkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSignUp.LinkClicked
        While MainChoose.PanelSign.Controls.Count > 0
            MainChoose.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(TSignup)
    End Sub

    Private Sub TSignin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtUn.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Username and Password are required.", "Message..")
        Else
            Try
                str = "SELECT * FROM teach_register WHERE email=@email AND password=@password"
                con.Open()

                Dim mysC As New MySqlCommand(str, con)
                mysC.Parameters.AddWithValue("@email", txtUn.Text)
                mysC.Parameters.AddWithValue("@password", txtPass.Text)

                Dim DR As MySqlDataReader = mysC.ExecuteReader()

                If DR.HasRows Then
                    While DR.Read
                        fname = DR.GetString("firstname")
                        email = DR.GetString("email")
                        idnum = DR.GetInt32("id")
                        lname = DR.GetString("lastname")
                        connum = DR.GetInt32("phonenum")


                    End While

                    TMainForm.Show()
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        While MainChoose.PanelSign.Controls.Count > 0
            MainChoose.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(PanelChoose)
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            If txtUn.Text = "" Or txtPass.Text = "" Then
                MessageBox.Show("Username and Password are required.", "Message..")
            Else
                Try
                    str = "SELECT * FROM teach_register WHERE email=@email AND password=@password"
                    con.Open()

                    Dim mysC As New MySqlCommand(str, con)
                    mysC.Parameters.AddWithValue("@email", txtUn.Text)
                    mysC.Parameters.AddWithValue("@password", txtPass.Text)

                    Dim DR As MySqlDataReader = mysC.ExecuteReader()

                    If DR.HasRows Then
                        While DR.Read
                            fname = DR.GetString("firstname")
                            email = DR.GetString("email")
                            idnum = DR.GetInt32("id")
                            lname = DR.GetString("lastname")
                            connum = DR.GetInt32("phonenum")


                        End While

                        TMainForm.Show()
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

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class