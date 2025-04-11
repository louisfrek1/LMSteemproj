Imports System.Runtime.CompilerServices
Imports System.Web.UI.WebControls
Imports MySqlConnector

Public Class studexamdata
    Public assessnoS As String
    Public itemnoS As String
    Public assessnosS As String
    Public coursegcodeS As String
    Dim str As String
    Public Function strconnection() As MySqlConnection

        Return New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")

    End Function
    Dim con As New MySqlConnection("Server=localhost;port=3306; user=root; password=; database=teem")
    Public strcon As MySqlConnection = strconnection()

    Public Property Assess As String
        Get
            Return assessnoS
        End Get
        Set(value As String)
            assessnoS = value
            typeofexam.Text = value
        End Set
    End Property

    Public Property Itemno1 As String
        Get
            Return itemnoS
        End Get
        Set(value As String)
            itemnoS = value
            assessno.Text = value
        End Set
    End Property
    Public Sub switchPanelSE(ByVal panel As Form)
        'switch panel from mainframe

        MainForm.mainpanel.Controls.Clear()
        panel.TopLevel = False
        MainForm.mainpanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub typeofexam_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles typeofexam.LinkClicked
        'MainForm.btnDBoard.Enabled = False
        'MainForm.btnDBoard.FillColor = Color.FromArgb(86, 83, 221)
        'MainForm.btnMCourse.Enabled = False
        'MainForm.btnMCourse.FillColor = Color.FromArgb(86, 83, 221)
        'MainForm.btnCalen.Enabled = False
        'MainForm.btnCalen.FillColor = Color.FromArgb(86, 83, 221)
        'MainForm.btnRes.Enabled = False
        'MainForm.btnRes.FillColor = Color.FromArgb(86, 83, 221)
        Try


            While MainForm.mainpanel.Controls.Count > 0
                MainForm.mainpanel.Controls(0).Dispose()
            End While
            switchPanelSE(studstartexam)
        Catch ex As Exception

        End Try
    End Sub

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

    Private Sub studexamdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
