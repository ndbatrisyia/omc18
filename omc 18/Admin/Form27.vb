Public Class Form27
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
        Form16.Show()
        Me.Hide()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsToolStripMenuItem.Click
        Form31.Show()
        Me.Hide()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Form26.Show()
        Me.Hide()
    End Sub

    Private Sub btnRequested_Click(sender As Object, e As EventArgs) Handles btnRequested.Click
        Me.Show()
    End Sub

    Private Sub btnAccepted_Click(sender As Object, e As EventArgs) Handles btnAccepted.Click
        Form28.Show()
        Me.Hide()
    End Sub

    Private Sub btnRejected_Click(sender As Object, e As EventArgs) Handles btnRejected.Click
        Form29.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompleted_Click(sender As Object, e As EventArgs) Handles btnCompleted.Click
        Form30.Show()
        Me.Hide()
    End Sub
End Class