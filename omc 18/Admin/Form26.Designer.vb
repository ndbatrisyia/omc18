<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form26
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
        Dim DataGridViewCellStyle67 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle76 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle68 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle69 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle70 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle71 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle72 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle73 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle74 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle75 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRejected = New System.Windows.Forms.Button()
        Me.btnAccepted = New System.Windows.Forms.Button()
        Me.btnRequested = New System.Windows.Forms.Button()
        Me.btnCompleted = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.AdminToolStripMenuItem.Text = "&Admin "
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle67.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle67.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle67.ForeColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle67.SelectionForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle67
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Colum6, Me.Column6})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridView1.Location = New System.Drawing.Point(55, 139)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle76.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle76.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle76.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle76.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle76.SelectionForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle76.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle76
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 30
        DataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle77.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle77.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle77.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle77.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle77.SelectionForeColor = System.Drawing.Color.Purple
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle77
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(861, 352)
        Me.DataGridView1.TabIndex = 15
        '
        'btnRejected
        '
        Me.btnRejected.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRejected.Location = New System.Drawing.Point(747, 72)
        Me.btnRejected.Name = "btnRejected"
        Me.btnRejected.Size = New System.Drawing.Size(89, 29)
        Me.btnRejected.TabIndex = 14
        Me.btnRejected.Text = "Rejected"
        Me.btnRejected.UseVisualStyleBackColor = False
        '
        'btnAccepted
        '
        Me.btnAccepted.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAccepted.Location = New System.Drawing.Point(661, 72)
        Me.btnAccepted.Name = "btnAccepted"
        Me.btnAccepted.Size = New System.Drawing.Size(89, 29)
        Me.btnAccepted.TabIndex = 13
        Me.btnAccepted.Text = "Accepted"
        Me.btnAccepted.UseVisualStyleBackColor = False
        '
        'btnRequested
        '
        Me.btnRequested.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRequested.ForeColor = System.Drawing.Color.Black
        Me.btnRequested.Location = New System.Drawing.Point(575, 72)
        Me.btnRequested.Name = "btnRequested"
        Me.btnRequested.Size = New System.Drawing.Size(89, 29)
        Me.btnRequested.TabIndex = 12
        Me.btnRequested.Text = "Requested"
        Me.btnRequested.UseVisualStyleBackColor = False
        '
        'btnCompleted
        '
        Me.btnCompleted.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompleted.Location = New System.Drawing.Point(833, 72)
        Me.btnCompleted.Name = "btnCompleted"
        Me.btnCompleted.Size = New System.Drawing.Size(89, 29)
        Me.btnCompleted.TabIndex = 11
        Me.btnCompleted.Text = "Completed"
        Me.btnCompleted.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 27)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Orders"
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.Black
        Me.btnAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAll.Location = New System.Drawing.Point(489, 72)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(89, 29)
        Me.btnAll.TabIndex = 16
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle68.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle68.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle68.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle68.SelectionForeColor = System.Drawing.Color.Purple
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle68
        Me.Column1.HeaderText = "No."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 35
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle69.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle69.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.Purple
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle69
        Me.Column2.HeaderText = "Order ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 86
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle70.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle70.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle70.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.Purple
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle70
        Me.Column3.HeaderText = "Student ID"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 86
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle71.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle71.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle71.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.Purple
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle71
        Me.Column4.HeaderText = "Shop Name"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 121
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle72.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle72.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle72.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.Purple
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle72
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 51
        '
        'Column7
        '
        DataGridViewCellStyle73.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle73.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle73.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle73.SelectionForeColor = System.Drawing.Color.Purple
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle73
        Me.Column7.HeaderText = "Request"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 91
        '
        'Colum6
        '
        Me.Colum6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle74.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle74.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle74.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle74.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle74.SelectionForeColor = System.Drawing.Color.Purple
        Me.Colum6.DefaultCellStyle = DataGridViewCellStyle74
        Me.Colum6.HeaderText = "Status"
        Me.Colum6.Items.AddRange(New Object() {"Requested", "Accepted", "Rejected", "Completed"})
        Me.Colum6.MinimumWidth = 6
        Me.Colum6.Name = "Colum6"
        Me.Colum6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Colum6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Colum6.Width = 86
        '
        'Column6
        '
        DataGridViewCellStyle75.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle75.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle75.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle75.Format = "d"
        DataGridViewCellStyle75.NullValue = Nothing
        DataGridViewCellStyle75.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.Purple
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle75
        Me.Column6.HeaderText = "Order Date"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 86
        '
        'Form26
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(965, 545)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRejected)
        Me.Controls.Add(Me.btnAccepted)
        Me.Controls.Add(Me.btnRequested)
        Me.Controls.Add(Me.btnCompleted)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form26"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form26"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRejected As Button
    Friend WithEvents btnAccepted As Button
    Friend WithEvents btnRequested As Button
    Friend WithEvents btnCompleted As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAll As Button
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Colum6 As DataGridViewComboBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
