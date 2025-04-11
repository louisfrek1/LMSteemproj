Public Class MainChoose


    Private Sub btnStudent_Click(sender As Object, e As EventArgs)


        While Me.PanelSign.Controls.Count > 0
            Me.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(StudSign)
    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        'switch panel from mainframe

        PanelSign.Controls.Clear()
        panel.TopLevel = False
        PanelSign.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub MainChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While Me.PanelSign.Controls.Count > 0
            Me.PanelSign.Controls(0).Dispose()
        End While
        switchPanel(PanelChoose)
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs)

    End Sub
End Class