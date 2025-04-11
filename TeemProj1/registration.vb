Public Class registration

    ''save to database registration
    Public Property FirstName() As String

    Public Property Username() As String

    Public Property Password() As String

    Public Property Email() As String

    Private Shared TheError As String = "Username not found"

    Public Shared Sub ShowError()
        MessageBox.Show(TheError)
    End Sub

    Public Shared Function IsEqual(user1 As registration, user2 As registration)

        If (user1 Is Nothing Or user2 Is Nothing) Then
            TheError = "Username not found"
            Return False

        End If

        If (user1.Username <> user2.Username) Then
            TheError = "Username not found"
            Return False

        ElseIf (user1.Password <> user2.Password) Then
            TheError = "Username and Password does not match"
            Return False
        End If

        Return True

    End Function
End Class
