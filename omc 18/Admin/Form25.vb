Public Class Form25
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
        Me.Show()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Form16.Show()
        Me.Hide()

    End Sub
    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Form23.Show()
        Me.Hide()
    End Sub

    Private Sub btnInStock_Click(sender As Object, e As EventArgs) Handles btnInStock.Click
        Me.Show()
    End Sub

    Private Sub btnOutofStock_Click(sender As Object, e As EventArgs) Handles btnOutofStock.Click
        Form24.Show()
        Me.Hide()
    End Sub
End Class