<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettlePaymentForm
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtEnterAmount = New Guna.UI2.WinForms.Guna2TextBox()
        btnPrint = New Guna.UI2.WinForms.Guna2Button()
        txtChangeAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        txtTotalAmountProduct = New Guna.UI2.WinForms.Guna2TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        grdSettlePayment = New Guna.UI2.WinForms.Guna2DataGridView()
        ColumnBrand = New DataGridViewTextBoxColumn()
        ColumnModel = New DataGridViewTextBoxColumn()
        ColumnSize = New DataGridViewTextBoxColumn()
        ColumnColorways = New DataGridViewTextBoxColumn()
        ColumnQTY = New DataGridViewTextBoxColumn()
        ColumnPrice = New DataGridViewTextBoxColumn()
        CType(grdSettlePayment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(656, 38)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(233, 33)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "ENTER AMOUNT"
        ' 
        ' txtEnterAmount
        ' 
        txtEnterAmount.CustomizableEdges = CustomizableEdges9
        txtEnterAmount.DefaultText = ""
        txtEnterAmount.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtEnterAmount.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtEnterAmount.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEnterAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEnterAmount.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEnterAmount.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtEnterAmount.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEnterAmount.Location = New Point(585, 168)
        txtEnterAmount.Name = "txtEnterAmount"
        txtEnterAmount.PasswordChar = ChrW(0)
        txtEnterAmount.PlaceholderText = "Enter amount..."
        txtEnterAmount.SelectedText = ""
        txtEnterAmount.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtEnterAmount.Size = New Size(378, 49)
        txtEnterAmount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtEnterAmount.TabIndex = 1
        ' 
        ' btnPrint
        ' 
        btnPrint.BorderRadius = 10
        btnPrint.CustomizableEdges = CustomizableEdges3
        btnPrint.DisabledState.BorderColor = Color.DarkGray
        btnPrint.DisabledState.CustomBorderColor = Color.DarkGray
        btnPrint.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPrint.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPrint.FillColor = Color.IndianRed
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(656, 356)
        btnPrint.Name = "btnPrint"
        btnPrint.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnPrint.Size = New Size(233, 56)
        btnPrint.TabIndex = 2
        btnPrint.Text = "PRINT"
        ' 
        ' txtChangeAmount
        ' 
        txtChangeAmount.CustomizableEdges = CustomizableEdges5
        txtChangeAmount.DefaultText = ""
        txtChangeAmount.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtChangeAmount.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtChangeAmount.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtChangeAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtChangeAmount.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtChangeAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtChangeAmount.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtChangeAmount.Location = New Point(585, 269)
        txtChangeAmount.Name = "txtChangeAmount"
        txtChangeAmount.PasswordChar = ChrW(0)
        txtChangeAmount.PlaceholderText = ""
        txtChangeAmount.SelectedText = ""
        txtChangeAmount.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtChangeAmount.Size = New Size(240, 49)
        txtChangeAmount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtChangeAmount.TabIndex = 1
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(585, 236)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(79, 27)
        Guna2HtmlLabel2.TabIndex = 0
        Guna2HtmlLabel2.Text = "Change"
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.Cursor = Cursors.Hand
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox1.FillColor = Color.White
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(961, 13)
        Guna2ControlBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox1.Size = New Size(25, 24)
        Guna2ControlBox1.TabIndex = 12
        ' 
        ' txtTotalAmountProduct
        ' 
        txtTotalAmountProduct.CustomizableEdges = CustomizableEdges7
        txtTotalAmountProduct.DefaultText = ""
        txtTotalAmountProduct.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtTotalAmountProduct.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtTotalAmountProduct.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTotalAmountProduct.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTotalAmountProduct.Enabled = False
        txtTotalAmountProduct.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTotalAmountProduct.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotalAmountProduct.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTotalAmountProduct.Location = New Point(585, 92)
        txtTotalAmountProduct.Name = "txtTotalAmountProduct"
        txtTotalAmountProduct.PasswordChar = ChrW(0)
        txtTotalAmountProduct.PlaceholderText = ""
        txtTotalAmountProduct.SelectedText = ""
        txtTotalAmountProduct.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtTotalAmountProduct.Size = New Size(378, 49)
        txtTotalAmountProduct.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtTotalAmountProduct.TabIndex = 1
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' grdSettlePayment
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        grdSettlePayment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdSettlePayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdSettlePayment.ColumnHeadersHeight = 22
        grdSettlePayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdSettlePayment.Columns.AddRange(New DataGridViewColumn() {ColumnBrand, ColumnModel, ColumnSize, ColumnColorways, ColumnQTY, ColumnPrice})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdSettlePayment.DefaultCellStyle = DataGridViewCellStyle3
        grdSettlePayment.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdSettlePayment.Location = New Point(12, 24)
        grdSettlePayment.Name = "grdSettlePayment"
        grdSettlePayment.RowHeadersVisible = False
        grdSettlePayment.RowHeadersWidth = 51
        grdSettlePayment.RowTemplate.Height = 29
        grdSettlePayment.Size = New Size(545, 480)
        grdSettlePayment.TabIndex = 13
        grdSettlePayment.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        grdSettlePayment.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        grdSettlePayment.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        grdSettlePayment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        grdSettlePayment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        grdSettlePayment.ThemeStyle.BackColor = Color.White
        grdSettlePayment.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdSettlePayment.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        grdSettlePayment.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        grdSettlePayment.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdSettlePayment.ThemeStyle.HeaderStyle.ForeColor = Color.White
        grdSettlePayment.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdSettlePayment.ThemeStyle.HeaderStyle.Height = 22
        grdSettlePayment.ThemeStyle.ReadOnly = False
        grdSettlePayment.ThemeStyle.RowsStyle.BackColor = Color.White
        grdSettlePayment.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grdSettlePayment.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdSettlePayment.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        grdSettlePayment.ThemeStyle.RowsStyle.Height = 29
        grdSettlePayment.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdSettlePayment.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' ColumnBrand
        ' 
        ColumnBrand.HeaderText = "Brand"
        ColumnBrand.MinimumWidth = 6
        ColumnBrand.Name = "ColumnBrand"
        ' 
        ' ColumnModel
        ' 
        ColumnModel.HeaderText = "Model"
        ColumnModel.MinimumWidth = 6
        ColumnModel.Name = "ColumnModel"
        ' 
        ' ColumnSize
        ' 
        ColumnSize.HeaderText = "Size"
        ColumnSize.MinimumWidth = 6
        ColumnSize.Name = "ColumnSize"
        ' 
        ' ColumnColorways
        ' 
        ColumnColorways.HeaderText = "Colorways"
        ColumnColorways.MinimumWidth = 6
        ColumnColorways.Name = "ColumnColorways"
        ' 
        ' ColumnQTY
        ' 
        ColumnQTY.HeaderText = "Quantity"
        ColumnQTY.MinimumWidth = 6
        ColumnQTY.Name = "ColumnQTY"
        ' 
        ' ColumnPrice
        ' 
        ColumnPrice.HeaderText = "Price"
        ColumnPrice.MinimumWidth = 6
        ColumnPrice.Name = "ColumnPrice"
        ' 
        ' SettlePaymentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(998, 527)
        Controls.Add(grdSettlePayment)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(btnPrint)
        Controls.Add(txtChangeAmount)
        Controls.Add(txtTotalAmountProduct)
        Controls.Add(txtEnterAmount)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SettlePaymentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SettlePaymentForm"
        CType(grdSettlePayment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEnterAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtChangeAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents txtTotalAmountProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents grdSettlePayment As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ColumnBrand As DataGridViewTextBoxColumn
    Friend WithEvents ColumnModel As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSize As DataGridViewTextBoxColumn
    Friend WithEvents ColumnColorways As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQTY As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrice As DataGridViewTextBoxColumn
End Class
