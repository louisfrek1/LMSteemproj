Imports MySqlConnector
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
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
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class studfilecontent

    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public _filename As String
    Dim sql As String

    Public Property Title As String
        Get
            Return _filename
        End Get
        Set(value As String)
            _filename = value
            filenamestud.Text = value
        End Set
    End Property
    Private Sub studfilecontent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler filenamestud.Click, Sub(senderLabel As Object, eLabel As EventArgs)
                                           Me.OnClick(eLabel)
                                       End Sub
    End Sub

    Private Sub filenamestud_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles filenamestud.LinkClicked

    End Sub

    Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click
        Dim fileName As String = filenamestud.Text  ' Replace with the actual file name

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.FileName = fileName
        saveFileDialog.Filter = "All Files|*.*|PNG files (*.png)|*.png|JPEG files (*.jpeg;*.jpg)|*.jpeg;*.jpg|PDF files (*.pdf)|*.pdf|PowerPoint files (*.ppt)|*.ppt|Word files (*.docx)|*.docx"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim destinationFilePath As String = saveFileDialog.FileName
            ' You can now save the file to the specified destinationFilePath
            DownloadFileByName(fileName, destinationFilePath)
        End If
    End Sub

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

    Private Sub DownloadFileByName(fileName As String, destinationFilePath As String)
        Dim service As DriveService = GetDriveService()

        If service Is Nothing Then
            MessageBox.Show("Unable to authenticate with Google Drive.")
            Return
        End If

        Try
            ' Search for the file by its name
            Dim request As FilesResource.ListRequest = service.Files.List()
            request.Q = $"title='{fileName}'"
            Dim result As FileList = request.Execute()
            If result IsNot Nothing AndAlso result.Items IsNot Nothing AndAlso result.Items.Count > 0 Then
                ' Get the file ID of the first matching file
                Dim fileId As String = result.Items(0).Id

                ' Download the file
                Dim requestDownload As FilesResource.GetRequest = service.Files.Get(fileId)
                Using fileStream As New FileStream(destinationFilePath, FileMode.Create)
                    requestDownload.Download(fileStream)
                End Using

                MessageBox.Show("File downloaded successfully!")
            Else
                MessageBox.Show("File not found.")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while downloading the file: {ex.Message}")
        End Try
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Try
            con.Open()

            sql = "SELECT * FROM tuploadfile WHERE filename = @filename"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@filename", filenamestud.Text)

            da = New MySqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim filePath As String = Application.StartupPath & "\Files\" & dt.Rows(0).Item("filename").ToString()

                If System.IO.File.Exists(filePath) Then
                    studOpenFile.Show()
                    studOpenFile.Focus()
                    studOpenFile.AxAcroPDF1.src = filePath
                Else
                    MessageBox.Show("File not found.")
                End If
            Else
                MessageBox.Show("No matching record found.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ContextMenuStrip1.Show(Guna2Button1, Location)
    End Sub
End Class
