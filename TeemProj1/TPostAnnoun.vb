Imports MySqlConnector

Public Class TPostAnnoun

    Public ticon As Image
    Public _tname As String
    Public _pdate As String
    Public _pcontent As String
    Dim str As String
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public tname As String
    Public pdate As Integer
    Public pcontent As String

    Public Property Ticon1 As Image
        Get
            Return ticon
        End Get
        Set(value As Image)
            ticon = value
            timage.Image = value
        End Set
    End Property

    Public Property Teachname As String
        Get
            Return _tname
        End Get
        Set(value As String)
            _tname = value
            namelbl.Text = value
        End Set
    End Property

    Public Property Pdate1 As String
        Get
            Return _pdate
        End Get
        Set(value As String)
            _pdate = value
            datelbl.Text = value
        End Set
    End Property

    Public Property Pocontent As String
        Get
            Return _pcontent
        End Get
        Set(value As String)
            _pcontent = value
            announlbl.Text = value
        End Set
    End Property

    Private Sub namelbl_Click(sender As Object, e As EventArgs) Handles namelbl.Click

    End Sub

    Private Sub announlbl_Click(sender As Object, e As EventArgs) Handles announlbl.Click

    End Sub

    Private Sub TPostAnnoun_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
