Imports System.IO
Imports System.Web.UI.WebControls
Imports MySqlConnector

Public Class TResource

    Dim connStr As String = "Server=localhost;port=3306; user=root; password=; database=teem"
    Dim conn As New MySqlConnection(connStr)


    Public Sub switchPanelTRes(ByVal panel As Form)
        'switch panel from mainframe

        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Public Sub switchPanelTP(ByVal panel As Form)
        'switch panel from mainframe

        dropdownpanel.Controls.Clear()
        panel.TopLevel = False
        dropdownpanel.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub TResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDynamicUserControl5()

        addfilebtn.Visible = False
        Label1.Text = TSignin.idnum
        dropdownpanel.Visible = False


    End Sub

    Public Sub GenerateDynamicUserControl5()
        FlowLayoutPanel1.BringToFront()
        FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems5()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As ResourceUser

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New ResourceUser()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))
                        'listItems(i).pb_image.Image = New Bitmap(MS)

                        listItems(i).cnmalink.Text = row("coursename").ToString()
                        listItems(i).label1.Text = row("coursename").ToString()

                        FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next

            End If
        End If
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click

    End Sub

    Private Sub addfilebtn_Click(sender As Object, e As EventArgs) Handles addfilebtn.Click
        While Panel1.Controls.Count > 0
            Panel1.Controls(0).Dispose()
        End While
        switchPanelTRes(uploadfile)
    End Sub

    Private Sub profilebtn_Click(sender As Object, e As EventArgs) Handles profilebtn.Click
        If dropdownpanel.Visible = False Then
            dropdownpanel.Visible = True
            switchPanelTP(TMenuDropdown)
        Else
            dropdownpanel.Hide()
            MenuDropdown.Hide()

        End If
    End Sub
End Class