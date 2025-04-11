Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports Guna.UI2.WinForms

Public Class AssessmentForm
    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcqcmb.SelectedIndexChanged
        If mcqcmb.SelectedItem = "Short Answer" Then
            txtshortanswer.Visible = True
            checka.Visible = False
            checkb.Visible = False
            checkc.Visible = False
            checkd.Visible = False
            radioa.Visible = False
            radiob.Visible = False
            radioc.Visible = False
            radiod.Visible = False

        ElseIf mcqcmb.SelectedItem = "Multiple Choice" Then
            radioa.Visible = True
            radiob.Visible = True
            radioc.Visible = True
            radiod.Visible = True
            checka.Visible = False
            checkb.Visible = False
            checkc.Visible = False
            checkd.Visible = False
            txtshortanswer.Visible = False

        ElseIf mcqcmb.SelectedItem = "Checkboxes" Then
            checka.Visible = True
            checkb.Visible = True
            checkc.Visible = True
            checkd.Visible = True
            radioa.Visible = False
            radiob.Visible = False
            radioc.Visible = False
            radiod.Visible = False
            txtshortanswer.Visible = False

        End If
    End Sub

    Private Sub AssessmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioa.Visible = False
        radiob.Visible = False
        radioc.Visible = False
        radiod.Visible = False
        checka.Visible = False
        checkb.Visible = False
        checkc.Visible = False
        checkd.Visible = False
        txtshortanswer.Visible = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        For Each control As Control In TCreateAssess.FlowLayoutPanel1.Controls
            If TypeOf control Is UserControl Then
                ' Check if the TextBox is selected for deletion (e.g., based on some condition)
                ' For example, you can use a CheckBox to allow the user to select TextBoxes for deletion
                Dim ucon As UserControl = DirectCast(control, UserControl)

                ' Remove the TextBox from the Panel
                TCreateAssess.FlowLayoutPanel1.Controls.Remove(ucon)

                ' Dispose of the TextBox to release resources
                ucon.Dispose()
            End If
        Next
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub
End Class
