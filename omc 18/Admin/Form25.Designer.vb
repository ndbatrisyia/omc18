<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form25
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOutofStock = New System.Windows.Forms.Button()
        Me.btnAvailable = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Thistle
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.DashboardToolStripMenuItem, Me.UsersToolStripMenuItem, Me.SellersToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.PaymentsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.AdminToolStripMenuItem.Text = "&Admin"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.DashboardToolStripMenuItem.Text = "&Dashboard"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.UsersToolStripMenuItem.Text = "&Users"
        '
        'SellersToolStripMenuItem
        '
        Me.SellersToolStripMenuItem.Name = "SellersToolStripMenuItem"
        Me.SellersToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.SellersToolStripMenuItem.Text = "&Sellers"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ProductsToolStripMenuItem.Text = "&Products"
        '
        'btnOutofStock
        '
        Me.btnOutofStock.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOutofStock.ForeColor = System.Drawing.Color.Black
        Me.btnOutofStock.Location = New System.Drawing.Point(771, 72)
        Me.btnOutofStock.Name = "btnOutofStock"
        Me.btnOutofStock.Size = New System.Drawing.Size(101, 29)
        Me.btnOutofStock.TabIndex = 15
        Me.btnOutofStock.Text = "Out of Stock"
        Me.btnOutofStock.UseVisualStyleBackColor = False
        '
        'btnAvailable
        '
        Me.btnAvailable.BackColor = System.Drawing.Color.Black
        Me.btnAvailable.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAvailable.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAvailable.Location = New System.Drawing.Point(686, 72)
        Me.btnAvailable.Name = "btnAvailable"
        Me.btnAvailable.Size = New System.Drawing.Size(89, 29)
        Me.btnAvailable.TabIndex = 14
        Me.btnAvailable.Text = "Available"
        Me.btnAvailable.UseVisualStyleBackColor = False
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAll.ForeColor = System.Drawing.Color.Black
        Me.btnAll.Location = New System.Drawing.Point(600, 72)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(89, 29)
        Me.btnAll.TabIndex = 13
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 27)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Products"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.OrdersToolStripMenuItem.Text = "&Orders"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.PaymentsToolStripMenuItem.Text = "Pa&yments"
        '
        'Form25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(965, 545)
        Me.Controls.Add(Me.btnOutofStock)
        Me.Controls.Add(Me.btnAvailable)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form25"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form25"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnOutofStock As Button
    Friend WithEvents btnAvailable As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
End Class
