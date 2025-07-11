<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form21
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
        Me.btnPending = New System.Windows.Forms.Button()
        Me.btnVerified = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnRejected = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Thistle
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.DashboardToolStripMenuItem, Me.UsersToolStripMenuItem, Me.SellersToolStripMenuItem, Me.ProductsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 30)
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
        'btnPending
        '
        Me.btnPending.BackColor = System.Drawing.Color.Black
        Me.btnPending.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPending.Location = New System.Drawing.Point(747, 72)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.Size = New System.Drawing.Size(89, 29)
        Me.btnPending.TabIndex = 12
        Me.btnPending.Text = "Pending"
        Me.btnPending.UseVisualStyleBackColor = False
        '
        'btnVerified
        '
        Me.btnVerified.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVerified.ForeColor = System.Drawing.Color.Black
        Me.btnVerified.Location = New System.Drawing.Point(661, 72)
        Me.btnVerified.Name = "btnVerified"
        Me.btnVerified.Size = New System.Drawing.Size(89, 29)
        Me.btnVerified.TabIndex = 11
        Me.btnVerified.Text = "Verified"
        Me.btnVerified.UseVisualStyleBackColor = False
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAll.ForeColor = System.Drawing.Color.Black
        Me.btnAll.Location = New System.Drawing.Point(575, 72)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(89, 29)
        Me.btnAll.TabIndex = 10
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'btnRejected
        '
        Me.btnRejected.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRejected.ForeColor = System.Drawing.Color.Black
        Me.btnRejected.Location = New System.Drawing.Point(833, 72)
        Me.btnRejected.Name = "btnRejected"
        Me.btnRejected.Size = New System.Drawing.Size(89, 29)
        Me.btnRejected.TabIndex = 9
        Me.btnRejected.Text = "Rejected"
        Me.btnRejected.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Sellers"
        '
        'Form21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(965, 545)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPending)
        Me.Controls.Add(Me.btnVerified)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnRejected)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form21"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form21"
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
    Friend WithEvents btnPending As Button
    Friend WithEvents btnVerified As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents btnRejected As Button
    Friend WithEvents Label1 As Label
End Class
