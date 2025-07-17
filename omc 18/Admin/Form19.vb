Public Class Form19
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Form17.Show()
        Me.Hide()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Form18.Show()
        Me.Hide()
    End Sub

    Private Sub SellersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellersToolStripMenuItem.Click
        Me.Show()
    End Sub


    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Form16.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form23.Show()
        Me.Hide()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Me.Show()
    End Sub

    Private Sub btnVerified_Click(sender As Object, e As EventArgs) Handles btnVerified.Click
        Form20.Show()
        Me.Hide()
    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        Form21.Show()
        Me.Hide()
    End Sub

    Private Sub btnRejected_Click(sender As Object, e As EventArgs) Handles btnRejected.Click
        Form22.Show()
        Me.Hide()
    End Sub
    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Form26.Show()
        Me.Hide()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsToolStripMenuItem.Click
        Form31.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Close()
    End Sub
End Class