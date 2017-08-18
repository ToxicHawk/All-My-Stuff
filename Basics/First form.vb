Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Input.Click
        Dim x As Integer = TextBox1.Text
        If x Mod 2 = 0 Then
            MsgBox("Even")
        Else
            MsgBox("Odd")


        End If
    End Sub
End Class
