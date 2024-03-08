<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierSearchProduct
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        grdSearchProduct = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        btnColumn = New DataGridViewButtonColumn()
        btnSearch = New Guna.UI2.WinForms.Guna2Button()
        txtSearch = New TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Search = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cmbSearch = New ComboBox()
        CType(grdSearchProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Me
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.Cursor = Cursors.Hand
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox2.FillColor = Color.White
        Guna2ControlBox2.IconColor = Color.DimGray
        Guna2ControlBox2.Location = New Point(1138, 16)
        Guna2ControlBox2.Margin = New Padding(3, 4, 3, 4)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox2.Size = New Size(25, 24)
        Guna2ControlBox2.TabIndex = 7
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.Cursor = Cursors.Hand
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges5
        Guna2ControlBox1.FillColor = Color.White
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(1170, 16)
        Guna2ControlBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2ControlBox1.Size = New Size(25, 24)
        Guna2ControlBox1.TabIndex = 8
        ' 
        ' grdSearchProduct
        ' 
        grdSearchProduct.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        grdSearchProduct.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdSearchProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdSearchProduct.ColumnHeadersHeight = 17
        grdSearchProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdSearchProduct.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, btnColumn})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdSearchProduct.DefaultCellStyle = DataGridViewCellStyle3
        grdSearchProduct.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdSearchProduct.Location = New Point(14, 83)
        grdSearchProduct.Margin = New Padding(3, 4, 3, 4)
        grdSearchProduct.Name = "grdSearchProduct"
        grdSearchProduct.RowHeadersVisible = False
        grdSearchProduct.RowHeadersWidth = 51
        grdSearchProduct.RowTemplate.Height = 25
        grdSearchProduct.Size = New Size(1182, 632)
        grdSearchProduct.TabIndex = 9
        grdSearchProduct.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        grdSearchProduct.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        grdSearchProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        grdSearchProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        grdSearchProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        grdSearchProduct.ThemeStyle.BackColor = Color.White
        grdSearchProduct.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdSearchProduct.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        grdSearchProduct.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        grdSearchProduct.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdSearchProduct.ThemeStyle.HeaderStyle.ForeColor = Color.White
        grdSearchProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdSearchProduct.ThemeStyle.HeaderStyle.Height = 17
        grdSearchProduct.ThemeStyle.ReadOnly = False
        grdSearchProduct.ThemeStyle.RowsStyle.BackColor = Color.White
        grdSearchProduct.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grdSearchProduct.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdSearchProduct.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        grdSearchProduct.ThemeStyle.RowsStyle.Height = 25
        grdSearchProduct.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdSearchProduct.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 97.01071F
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.FillWeight = 97.01071F
        Column2.HeaderText = "Brand"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 97.01071F
        Column3.HeaderText = "Model"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.FillWeight = 97.01071F
        Column4.HeaderText = "Size"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.FillWeight = 97.01071F
        Column5.HeaderText = "Colorways"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.FillWeight = 97.01071F
        Column6.HeaderText = "Description"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.FillWeight = 97.01071F
        Column7.HeaderText = "Quantity"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.FillWeight = 97.01071F
        Column8.HeaderText = "Price"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        ' 
        ' btnColumn
        ' 
        btnColumn.DividerWidth = 5
        btnColumn.FillWeight = 55F
        btnColumn.HeaderText = ""
        btnColumn.MinimumWidth = 6
        btnColumn.Name = "btnColumn"
        btnColumn.Resizable = DataGridViewTriState.True
        btnColumn.SortMode = DataGridViewColumnSortMode.Automatic
        btnColumn.Text = "Add"
        btnColumn.UseColumnTextForButtonValue = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BorderRadius = 10
        btnSearch.Cursor = Cursors.Hand
        btnSearch.CustomizableEdges = CustomizableEdges1
        btnSearch.DisabledState.BorderColor = Color.DarkGray
        btnSearch.DisabledState.CustomBorderColor = Color.DarkGray
        btnSearch.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSearch.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSearch.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(621, 29)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSearch.Size = New Size(137, 31)
        btnSearch.TabIndex = 14
        btnSearch.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(82, 29)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search here..."
        txtSearch.Size = New Size(211, 27)
        txtSearch.TabIndex = 13
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(329, 29)
        Guna2HtmlLabel3.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(127, 30)
        Guna2HtmlLabel3.TabIndex = 11
        Guna2HtmlLabel3.Text = "Column Type"
        ' 
        ' Search
        ' 
        Search.BackColor = Color.Transparent
        Search.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Search.Location = New Point(14, 29)
        Search.Margin = New Padding(3, 4, 3, 4)
        Search.Name = "Search"
        Search.Size = New Size(66, 30)
        Search.TabIndex = 12
        Search.Text = "Search"
        ' 
        ' cmbSearch
        ' 
        cmbSearch.FormattingEnabled = True
        cmbSearch.Items.AddRange(New Object() {"ID", "Brand", "Model", "Size", "Colorways", "Price", "Quantity"})
        cmbSearch.Location = New Point(455, 29)
        cmbSearch.Margin = New Padding(3, 4, 3, 4)
        cmbSearch.Name = "cmbSearch"
        cmbSearch.Size = New Size(138, 28)
        cmbSearch.TabIndex = 10
        ' 
        ' CashierSearchProduct
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1209, 793)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Search)
        Controls.Add(cmbSearch)
        Controls.Add(grdSearchProduct)
        Controls.Add(Guna2ControlBox2)
        Controls.Add(Guna2ControlBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "CashierSearchProduct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CashierSearchProduct"
        CType(grdSearchProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents grdSearchProduct As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Search As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btnColumn As DataGridViewButtonColumn
End Class
