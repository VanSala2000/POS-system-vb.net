<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buttonDeleteAccount
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Label5 = New Label()
        grdCashierAccounts = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblTotalAccounts = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        CType(grdCashierAccounts, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(489, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(235, 37)
        Label5.TabIndex = 12
        Label5.Text = "Cashier Accounts"
        ' 
        ' grdCashierAccounts
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        grdCashierAccounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdCashierAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdCashierAccounts.ColumnHeadersHeight = 32
        grdCashierAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdCashierAccounts.Columns.AddRange(New DataGridViewColumn() {Column1, Column4, Column5, Column6, Column7, Column8, Column2, Column3, Column9})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdCashierAccounts.DefaultCellStyle = DataGridViewCellStyle3
        grdCashierAccounts.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdCashierAccounts.Location = New Point(12, 61)
        grdCashierAccounts.Name = "grdCashierAccounts"
        grdCashierAccounts.RowHeadersVisible = False
        grdCashierAccounts.RowTemplate.Height = 25
        grdCashierAccounts.Size = New Size(1142, 312)
        grdCashierAccounts.TabIndex = 13
        grdCashierAccounts.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        grdCashierAccounts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        grdCashierAccounts.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        grdCashierAccounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        grdCashierAccounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        grdCashierAccounts.ThemeStyle.BackColor = Color.White
        grdCashierAccounts.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdCashierAccounts.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        grdCashierAccounts.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        grdCashierAccounts.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdCashierAccounts.ThemeStyle.HeaderStyle.ForeColor = Color.White
        grdCashierAccounts.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdCashierAccounts.ThemeStyle.HeaderStyle.Height = 32
        grdCashierAccounts.ThemeStyle.ReadOnly = False
        grdCashierAccounts.ThemeStyle.RowsStyle.BackColor = Color.White
        grdCashierAccounts.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grdCashierAccounts.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdCashierAccounts.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        grdCashierAccounts.ThemeStyle.RowsStyle.Height = 25
        grdCashierAccounts.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdCashierAccounts.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(867, 33)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(167, 18)
        Guna2HtmlLabel1.TabIndex = 14
        Guna2HtmlLabel1.Text = "Total Cashier Accounts:"
        ' 
        ' lblTotalAccounts
        ' 
        lblTotalAccounts.BackColor = Color.Transparent
        lblTotalAccounts.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalAccounts.ForeColor = Color.Red
        lblTotalAccounts.Location = New Point(1061, 33)
        lblTotalAccounts.Name = "lblTotalAccounts"
        lblTotalAccounts.Size = New Size(11, 18)
        lblTotalAccounts.TabIndex = 14
        lblTotalAccounts.Text = "0"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BorderRadius = 5
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.CustomizableEdges = CustomizableEdges1
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
        btnUpdate.Location = New Point(815, 379)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnUpdate.Size = New Size(166, 56)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.TextOffset = New Point(10, 0)
        ' 
        ' btnDelete
        ' 
        btnDelete.BorderRadius = 5
        btnDelete.Cursor = Cursors.Hand
        btnDelete.CustomizableEdges = CustomizableEdges3
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
        btnDelete.Location = New Point(987, 379)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnDelete.Size = New Size(166, 56)
        btnDelete.TabIndex = 16
        btnDelete.Text = "Delete"
        btnDelete.TextOffset = New Point(10, 0)
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "FIRSTNAME"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "LASTNAME"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "GENDER"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "ADDRESS"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "CONTACT NUMBER"
        Column8.Name = "Column8"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "USERNAME"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "PASSWORD"
        Column3.Name = "Column3"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "CREATED AT"
        Column9.Name = "Column9"
        ' 
        ' buttonDeleteAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1166, 440)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(lblTotalAccounts)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(grdCashierAccounts)
        Controls.Add(Label5)
        FormBorderStyle = FormBorderStyle.None
        Name = "buttonDeleteAccount"
        Text = "buttonDeleteAccount"
        CType(grdCashierAccounts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Label5 As Label
    Friend WithEvents grdCashierAccounts As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblTotalAccounts As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
