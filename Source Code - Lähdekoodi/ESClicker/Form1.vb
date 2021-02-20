Public Class Form1

    Private EsClicks As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        EsClicks += 1
        TextBox1.Text = EsClicks
        If EsClicks > 10000 Then
            ' No vittu arvaa 2 kertaa... Oikeasti.
            PictureBox1.Image = My.Resources.KultainenES

            ' EN VITTU TIEDÄ
            Label2.Visible = True
            PictureBox2.Visible = True

            ' Soita ES Laulu
            ESLauluEbin()

        End If
    End Sub

    Sub ESLauluEbin()
        My.Computer.Audio.Play(My.Resources.Song,
        AudioPlayMode.Background)
    End Sub


End Class
