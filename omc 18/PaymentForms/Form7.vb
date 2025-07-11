Public Class Form7


    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStoreName.Text = "ATELIER"
        lblDate.Text = "Wednesday, June 12, 2025"
        lblStatus.Text = "Status : Paid"
        lblThanks.Text = "Thank you for shopping with us !"

        ' Setup DataGridView
        With dgvReceipt
            .ColumnCount = 3
            .Columns(0).Name = "Qty"
            .Columns(1).Name = "Item"
            .Columns(2).Name = "Amount"
            .Rows.Add("01", "Crochet bottle case", "RM 18")
            .Rows.Add("02", "Tote bag", "RM 20")
            .Rows.Add("03", "Crochet Flower", "RM 10")
            .Rows.Add("04", "Bookmark", "RM 15")
            .Rows.Add("05", "Beaded bracelet", "RM 12")
            .ReadOnly = True
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        ' Total section
        lblItemCount.Text = "Item Count : 8"
        lblTotal.Text = "Total : RM 75"
        lblCardHolder.Text = "Card Holder :"
        lblCardNumber.Text = "Card Number :"
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fntHeader As New Font("Georgia", 16, FontStyle.Bold)
        Dim fntSub As New Font("Georgia", 12)
        Dim fntNormal As New Font("Georgia", 10)
        Dim yPos As Integer = 100

        ' Store name and date
        e.Graphics.DrawString(lblStoreName.Text, fntHeader, Brushes.Black, 100, yPos)
        yPos += 30
        e.Graphics.DrawString(lblDate.Text, fntSub, Brushes.Black, 100, yPos)
        yPos += 40

        ' Table headers
        e.Graphics.DrawString("Qty", fntNormal, Brushes.Black, 100, yPos)
        e.Graphics.DrawString("Item", fntNormal, Brushes.Black, 150, yPos)
        e.Graphics.DrawString("Amount", fntNormal, Brushes.Black, 400, yPos)
        yPos += 20

        ' Data rows
        For Each row As DataGridViewRow In dgvReceipt.Rows
            e.Graphics.DrawString(row.Cells(0).Value.ToString(), fntNormal, Brushes.Black, 100, yPos)
            e.Graphics.DrawString(row.Cells(1).Value.ToString(), fntNormal, Brushes.Black, 150, yPos)
            e.Graphics.DrawString(row.Cells(2).Value.ToString(), fntNormal, Brushes.Black, 400, yPos)
            yPos += 20
        Next

        ' Summary
        yPos += 20
        e.Graphics.DrawString(lblItemCount.Text, fntNormal, Brushes.Black, 100, yPos)
        e.Graphics.DrawString(lblTotal.Text, fntNormal, Brushes.Black, 350, yPos)
        yPos += 20
        e.Graphics.DrawString(lblCardHolder.Text, fntNormal, Brushes.Black, 100, yPos)
        yPos += 20
        e.Graphics.DrawString(lblCardNumber.Text, fntNormal, Brushes.Black, 100, yPos)
        yPos += 20
        e.Graphics.DrawString(lblStatus.Text, fntNormal, Brushes.Black, 100, yPos)
        yPos += 40
        e.Graphics.DrawString(lblThanks.Text, fntNormal, Brushes.Black, 100, yPos)
    End Sub

End Class