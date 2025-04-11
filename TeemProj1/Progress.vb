Public Class Progress
    Private Sub Guna2WinProgressIndicator1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Guna2ProgressBar1.Value += 2
        If Me.Guna2ProgressBar1.Value <= 30 Then
            Me.Text = "Please Wait..."
        ElseIf Me.Guna2ProgressBar1.Value <= 50 Then
            Me.Text = "Please Wait..."
        ElseIf Me.Guna2ProgressBar1.Value <= 75 Then
            Me.Text = "Please Wait... Almost Done"
        ElseIf Me.Guna2ProgressBar1.Value <= 100 Then
            Me.Text = "Almost Done"
            If Me.Guna2ProgressBar1.Value = 100 Then
                Me.Timer1.Dispose()
                MainChoose.Show()
                Me.Hide()

            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class