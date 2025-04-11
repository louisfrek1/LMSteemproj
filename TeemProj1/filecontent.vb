Public Class filecontent
    Private Sub filecontent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDynamicUserControl6()
    End Sub

    Public Sub GenerateDynamicUserControl6()
        FlowLayoutPanel1.Controls.Clear()

        Dim objbll As New ClassBLL()
        Dim dt As DataTable = objbll.GetItems6()

        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listItems(dt.Rows.Count - 0) As TFileContent

                For i As Integer = 0 To 0
                    For Each row As DataRow In dt.Rows
                        listItems(i) = New TFileContent()

                        'Dim MS As New MemoryStream(DirectCast(row("image"), Byte()))
                        'listItems(i).pb_image.Image = New Bitmap(MS)

                        listItems(i).pdfnamelink.Text = row("filename").ToString()

                        FlowLayoutPanel1.Controls.Add(listItems(i))

                        'AddHandler listItems(i).Click, AddressOf Me.pb_image_Click
                    Next
                Next

            End If
        End If
    End Sub
End Class