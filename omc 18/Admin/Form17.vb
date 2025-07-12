Public Class Form17
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Me.Show()
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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Form21.Show()
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
End Class