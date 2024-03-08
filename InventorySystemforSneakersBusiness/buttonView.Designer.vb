<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buttonView
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        grdProducts = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        lblTotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        btnSearch = New Guna.UI2.WinForms.Guna2Button()
        txtSearch = New TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Search = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cmbSearch = New ComboBox()
        CType(grdProducts, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' grdProducts
        ' 
        grdProducts.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        grdProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdProducts.ColumnHeadersHeight = 25
        grdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdProducts.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdProducts.DefaultCellStyle = DataGridViewCellStyle3
        grdProducts.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdProducts.Location = New Point(10, 129)
        grdProducts.Margin = New Padding(3, 4, 3, 4)
        grdProducts.Name = "grdProducts"
        grdProducts.RowHeadersVisible = False
        grdProducts.RowHeadersWidth = 51
        grdProducts.RowTemplate.Height = 25
        grdProducts.Size = New Size(1336, 568)
        grdProducts.TabIndex = 0
        grdProducts.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        grdProducts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        grdProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        grdProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        grdProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        grdProducts.ThemeStyle.BackColor = Color.White
        grdProducts.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdProducts.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        grdProducts.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        grdProducts.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdProducts.ThemeStyle.HeaderStyle.ForeColor = Color.White
        grdProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdProducts.ThemeStyle.HeaderStyle.Height = 25
        grdProducts.ThemeStyle.ReadOnly = False
        grdProducts.ThemeStyle.RowsStyle.BackColor = Color.White
        grdProducts.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grdProducts.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdProducts.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        grdProducts.ThemeStyle.RowsStyle.Height = 25
        grdProducts.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdProducts.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Id"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Brand"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Model"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Size"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Colorways"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Description"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Quantity"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Price"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Created_at"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderColor = Color.Black
        Guna2Panel1.BorderThickness = 1
        Guna2Panel1.Controls.Add(lblTotalPrice)
        Guna2Panel1.Controls.Add(btnAdd)
        Guna2Panel1.Controls.Add(Guna2HtmlLabel1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Top
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Margin = New Padding(3, 4, 3, 4)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(1360, 69)
        Guna2Panel1.TabIndex = 1
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.BackColor = Color.Transparent
        lblTotalPrice.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalPrice.ForeColor = Color.Red
        lblTotalPrice.Location = New Point(1176, 15)
        lblTotalPrice.Margin = New Padding(3, 4, 3, 4)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(17, 34)
        lblTotalPrice.TabIndex = 4
        lblTotalPrice.Text = "0"
        ' 
        ' btnAdd
        ' 
        btnAdd.BorderRadius = 5
        btnAdd.Cursor = Cursors.Hand
        btnAdd.CustomizableEdges = CustomizableEdges1
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.Green
        btnAdd.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.White
        btnAdd.Image = My.Resources.Resources.button
        btnAdd.ImageAlign = HorizontalAlignment.Left
        btnAdd.ImageOffset = New Point(15, 0)
        btnAdd.ImageSize = New Size(30, 30)
        btnAdd.Location = New Point(10, 5)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAdd.Size = New Size(177, 60)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.TextOffset = New Point(10, 0)
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(1025, 16)
        Guna2HtmlLabel1.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(138, 31)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Total Price:"
        ' 
        ' btnDelete
        ' 
        btnDelete.BorderRadius = 5
        btnDelete.Cursor = Cursors.Hand
        btnDelete.CustomizableEdges = CustomizableEdges5
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.Red
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Image = My.Resources.Resources.deleteicon
        btnDelete.ImageAlign = HorizontalAlignment.Left
        btnDelete.ImageOffset = New Point(10, 0)
        btnDelete.Location = New Point(1157, 705)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnDelete.Size = New Size(190, 75)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.TextOffset = New Point(10, 0)
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BorderRadius = 5
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.CustomizableEdges = CustomizableEdges7
        btnUpdate.DisabledState.BorderColor = Color.DarkGray
        btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray
        btnUpdate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUpdate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUpdate.FillColor = Color.Gold
        btnUpdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.DimGray
        btnUpdate.Image = My.Resources.Resources.update
        btnUpdate.ImageAlign = HorizontalAlignment.Left
        btnUpdate.ImageOffset = New Point(8, 0)
        btnUpdate.ImageSize = New Size(18, 18)
        btnUpdate.Location = New Point(960, 705)
        btnUpdate.Margin = New Padding(3, 4, 3, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnUpdate.Size = New Size(190, 75)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.TextOffset = New Point(10, 0)
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.Controls.Add(btnSearch)
        Guna2Panel2.Controls.Add(txtSearch)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel3)
        Guna2Panel2.Controls.Add(Search)
        Guna2Panel2.Controls.Add(cmbSearch)
        Guna2Panel2.CustomBorderColor = Color.Black
        Guna2Panel2.CustomBorderThickness = New Padding(0, 0, 0, 1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges11
        Guna2Panel2.Dock = DockStyle.Top
        Guna2Panel2.Location = New Point(0, 69)
        Guna2Panel2.Margin = New Padding(3, 4, 3, 4)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel2.Size = New Size(1360, 52)
        Guna2Panel2.TabIndex = 3
        ' 
        ' btnSearch
        ' 
        btnSearch.BorderRadius = 10
        btnSearch.Cursor = Cursors.Hand
        btnSearch.CustomizableEdges = CustomizableEdges9
        btnSearch.DisabledState.BorderColor = Color.DarkGray
        btnSearch.DisabledState.CustomBorderColor = Color.DarkGray
        btnSearch.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSearch.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSearch.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(613, 8)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnSearch.Size = New Size(137, 31)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(74, 8)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search here..."
        txtSearch.Size = New Size(211, 27)
        txtSearch.TabIndex = 2
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(321, 8)
        Guna2HtmlLabel3.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(127, 30)
        Guna2HtmlLabel3.TabIndex = 1
        Guna2HtmlLabel3.Text = "Column Type"
        ' 
        ' Search
        ' 
        Search.BackColor = Color.Transparent
        Search.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Search.Location = New Point(6, 8)
        Search.Margin = New Padding(3, 4, 3, 4)
        Search.Name = "Search"
        Search.Size = New Size(66, 30)
        Search.TabIndex = 1
        Search.Text = "Search"
        ' 
        ' cmbSearch
        ' 
        cmbSearch.FormattingEnabled = True
        cmbSearch.Items.AddRange(New Object() {"ID", "Brand", "Model", "Size", "Colorways", "Price", "Quantity"})
        cmbSearch.Location = New Point(447, 8)
        cmbSearch.Margin = New Padding(3, 4, 3, 4)
        cmbSearch.Name = "cmbSearch"
        cmbSearch.Size = New Size(138, 28)
        cmbSearch.TabIndex = 0
        ' 
        ' buttonView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1360, 796)
        Controls.Add(Guna2Panel2)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(Guna2Panel1)
        Controls.Add(grdProducts)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "buttonView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "buttonView"
        CType(grdProducts, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grdProducts As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Search As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
