Public Class UpdateForm
    Dim currentDay As Integer = DateTime.Now.Day
    Dim currentMonthName As String = MonthName(DateTime.Now.Month)

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = currentDay
        Label2.Text = currentMonthName
    End Sub
End Class