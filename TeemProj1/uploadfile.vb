Imports Microsoft.SqlServer
Imports MySqlConnector
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Google.Apis.Auth
Imports Google.Apis.Download
Imports Google.Apis.Drive.v2
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Drive.v2.Data
Imports System.Runtime.CompilerServices
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Web.UI.WebControls

Public Class uploadfile

    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim service As DriveService
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Dim f As New OpenFileDialog
            If f.ShowDialog = DialogResult.OK Then
                TextBox1.Text = f.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetCredentials() As UserCredential
        ' Load the client secrets file to authenticate with Google Drive.
        ' Make sure you have client_secrets.json with your client ID and client secret.
        Dim credPath As String = "C:\Users\Louise Zandra\Downloads"
        Dim scopes As String() = {DriveService.Scope.DriveFile}

        Return GoogleWebAuthorizationBroker.AuthorizeAsync(
                New ClientSecrets With {
                    .ClientId = "215539786590-r4et1bp16b0hrtvrtsiqfnbssldjbloo.apps.googleusercontent.com",
                    .ClientSecret = "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"
                },
                scopes,
                "user",
                Threading.CancellationToken.None,
                New FileDataStore(credPath, True)
            ).Result
    End Function


    Private Function GetDriveService() As DriveService
        ' Initialize the DriveService using the credentials obtained from the Google Cloud Platform.
        Dim credential As UserCredential = GetCredentials()
        If credential Is Nothing Then
            Return Nothing
        End If

        Return New DriveService(New BaseClientService.Initializer() With {
        .HttpClientInitializer = credential,
        .ApplicationName = "YourAppName"
    })
    End Function


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        'Timer1.Start()
        Try
            ' Assuming 'con' is a SqlConnection object
            con.Open()

            sql = "INSERT INTO tuploadfile(filename,coursename,coursecode,coursegcode,id,tfname,tlname)VALUES('" & System.IO.Path.GetFileName(TextBox1.Text) & "','" & cnametxt.Text & "',
                                                                                                            '" & ccodetxt.Text & "','" & cgcodetxt.Text & "','" & TSignin.idnum & "',
                                                                                                            '" & TSignin.fname & "','" & TSignin.lname & "')"

            Using cmd As New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                If TextBox1.Text <> "" Then
                    System.IO.File.Copy(TextBox1.Text, Application.StartupPath & "\Files\" & System.IO.Path.GetFileName(TextBox1.Text))
                End If


                Dim service As DriveService = GetDriveService()
                If service Is Nothing Then
                    MessageBox.Show("Unable to authenticate with Google Drive.")
                    Return
                End If

                Try
                    Dim fileMetadata As New Google.Apis.Drive.v2.Data.File() With {
            .Title = Path.GetFileName(TextBox1.Text),
            .MimeType = "application/octet-stream"
        }

                    Using stream As New FileStream(TextBox1.Text, FileMode.Open)
                        Dim request As FilesResource.InsertMediaUpload = service.Files.Insert(fileMetadata, stream, "application/octet-stream")
                        request.Upload()
                    End Using

                    MessageBox.Show("File uploaded successfully!")
                Catch ex As Exception
                    MessageBox.Show($"An error occurred while uploading the file: {ex.Message}")
                End Try

                TextBox1.Clear()

                'MessageBox.Show("Scanned file uploaded successfully!")
            End Using
        Catch ex As Exception
            ' Handle exceptions here
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Guna2ProgressBar1.Value += 1
            If Guna2ProgressBar1.Value = 100 Then
                Timer1.Stop()

            End If
        Catch ex As Exception
            ' Handle exceptions here
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub uploadfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim credential As UserCredential = GetCredentials()
        Dim service As DriveService = New DriveService(New BaseClientService.Initializer() With {
            .HttpClientInitializer = credential,
            .ApplicationName = "TeemAppPrac"
        })
        idnumtxt.Text = TSignin.idnum
        fnametxt.Text = TSignin.fname
        lnametxt.Text = TSignin.lname
    End Sub
End Class