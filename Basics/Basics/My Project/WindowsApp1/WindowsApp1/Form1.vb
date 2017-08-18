Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Password.PasswordChar = "•"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String = Username.text
        Dim y As String = Password.text
        If x = ("KFC") And y = ("Sauce'em") Then
            MsgBox("You're all set! Welcome!")
        Else
            MsgBox("̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\з= ( ▀ ͜͞ʖ▀) =ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿  BOI GET IT RIGHT")


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim webAddress As String = "https://support.microsoft.com/en-us"
        Process.Start(webAddress)
    End Sub
End Class
