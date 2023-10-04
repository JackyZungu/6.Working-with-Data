Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String
        'Dim age As Integer
        Dim birthYear As Integer

        YourMessage = "happy Birthday! how old are you now"
        ' InputBox("Enter age")

        MsgBox(YourMessage)

        birthYear = Val(InputBox("Enter birth year"))

        MsgBox("your were born on year" & 2023 - 1996)

        'MsgBox("You are now" & birthYear - 2023 & "years old")
    End Sub
End Class
