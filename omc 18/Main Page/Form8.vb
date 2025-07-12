Public Class Form8
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub PictureBox6_Click_2(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ContextMenuStrip1.Show(PictureBox5, New Point(0, PictureBox5.Height))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form15.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)

    End Sub
End Class