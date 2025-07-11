Public Class Form16
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Form17.Show()
        Me.Hide()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Form18.Show()
        Me.Hide()
    End Sub

    Private Sub SellersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellersToolStripMenuItem.Click
        Form19.Show()
        Me.Hide()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Form23.Show()
        Me.Hide()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Me.Show()

    End Sub
End Class