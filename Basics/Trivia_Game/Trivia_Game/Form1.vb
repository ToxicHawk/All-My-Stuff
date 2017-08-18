Public Class Form1
    Dim correct As Integer
    Dim score As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        correct = 1
        Button6.Enabled = False
        Question.Text = "Ian Fleming built a Jamaican home named after which one of his James Bond novels?"
        A1.Text = "Goldeneye"
        A2.Text = "Dr. No"
        A3.Text = "Thunderball"
        A4.Text = "On Her Majesty's Secret Service"
        Panel1.Enabled = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        correct = 2
        Button9.Enabled = False
        Question.Text = "What painting is Leonardo DaVinci famous for making?"
        A1.Text = "Starry Night"
        A2.Text = "Mona Lisa"
        A3.Text = "Scream"
        A4.Text = "My First Grade Self Portrait"
        Panel1.Enabled = True

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        correct = 1
        Button8.Enabled = False
        Question.Text = "Which one of the choices was a General that worked for Hitler?"
        A1.Text = "Rommel"
        A2.Text = "Napolean"
        A3.Text = "Maddog Maddus"
        A4.Text = "Leonardo DiCaprio"
        Panel1.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        correct = 4
        Button7.Enabled = False
        Question.Text = "What year did the Berlin wall fall?"
        A1.Text = 1984
        A2.Text = 1985
        A3.Text = 1988
        A4.Text = 1989
        Panel1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        correct = 2
        Button4.Enabled = False
        Question.Text = "What playwrite wrote Hamlet?"
        A1.Text = "Arthur Miller"
        A2.Text = "William Shakespeare"
        A3.Text = "Christopher Marlowe"
        A4.Text = "Pierre Corneille"
        Panel1.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        correct = 4
        Button5.Enabled = False
        Question.Text = "How many novels did Agatha Christie write?"
        A1.Text = 83
        A2.Text = 85
        A3.Text = 80
        A4.Text = "Uncertain"
        Panel1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        correct = 1
        Button1.Enabled = False
        Question.Text = "What car number is Lightning McQueen in cars?"
        A1.Text = 95
        A2.Text = 98
        A3.Text = 93
        A4.Text = 99
        Panel1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        correct = 1
        Button3.Enabled = False
        Question.Text = "What does the tiger represent in Life of Pi"
        A1.Text = "Pi's will of life"
        A2.Text = "Death"
        A3.Text = "Your Mom"
        A4.Text = "Nothing"
        Panel1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        correct = 2
        Button2.Enabled = False
        Question.Text = "What Model number is Arnold Schwarzeneggar in the movie Terminator?"
        A1.Text = 4000
        A2.Text = 3000
        A3.Text = 3050
        A4.Text = 21
        Panel1.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If correct = 1 And A1.Checked = True Then
            score = score + 1
            Panel1.Enabled = False
            CorrectOrNot.Text = "Correct!"
        ElseIf correct = 4 And A4.Checked = True Then
            score = score + 1
            Panel1.Enabled = False
            CorrectOrNot.Text = "Correct!"
        ElseIf correct = 2 And A2.Checked = True Then
            score = score + 1
            Panel1.Enabled = False
            CorrectOrNot.Text = "Correct!"
        ElseIf correct = 3 And A3.Checked = True Then
            score = score + 1
            Panel1.Enabled = False
            CorrectOrNot.Text = "Correct!"
        Else
            CorrectOrNot.Text = "Incorrect, the correct answer was " & correct.ToString
            Panel1.Enabled = False
        End If
        Label1.Text = "Score: " & score.ToString
    End Sub
End Class
