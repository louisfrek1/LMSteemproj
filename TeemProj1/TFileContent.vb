Imports MySqlConnector

Public Class TFileContent
    Public _filename As String
    Dim str As String
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")

    Public Property Title As String
        Get
            Return _filename
        End Get
        Set(value As String)
            _filename = value
            pdfnamelink.Text = value
        End Set
    End Property
    Private Sub TFileContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pdfnamelink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles pdfnamelink.LinkClicked

    End Sub
End Class
