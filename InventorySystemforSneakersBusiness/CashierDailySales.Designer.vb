<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierDailySales
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        grdDailySales = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        d2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        d1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        CType(grdDailySales, ComponentModel.ISupportInitialize).BeginInit()
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
        ' grdDailySales
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        grdDailySales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdDailySales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdDailySales.ColumnHeadersHeight = 22
        grdDailySales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdDailySales.DefaultCellStyle = DataGridViewCellStyle3
        grdDailySales.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdDailySales.Location = New Point(12, 81)
        grdDailySales.Name = "grdDailySales"
        grdDailySales.RowHeadersVisible = False
        grdDailySales.RowHeadersWidth = 51
        grdDailySales.RowTemplate.Height = 29
        grdDailySales.Size = New Size(916, 375)
        grdDailySales.TabIndex = 0
        grdDailySales.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        grdDailySales.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        grdDailySales.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        grdDailySales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        grdDailySales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        grdDailySales.ThemeStyle.BackColor = Color.White
        grdDailySales.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdDailySales.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        grdDailySales.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        grdDailySales.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdDailySales.ThemeStyle.HeaderStyle.ForeColor = Color.White
        grdDailySales.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        grdDailySales.ThemeStyle.HeaderStyle.Height = 22
        grdDailySales.ThemeStyle.ReadOnly = False
        grdDailySales.ThemeStyle.RowsStyle.BackColor = Color.White
        grdDailySales.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grdDailySales.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grdDailySales.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        grdDailySales.ThemeStyle.RowsStyle.Height = 29
        grdDailySales.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdDailySales.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.BackColor = SystemColors.ButtonHighlight
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges5
        Guna2ControlBox1.FillColor = Color.Transparent
        Guna2ControlBox1.IconColor = Color.Black
        Guna2ControlBox1.Location = New Point(888, 12)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2ControlBox1.Size = New Size(40, 32)
        Guna2ControlBox1.TabIndex = 2
        ' 
        ' d2
        ' 
        d2.Animated = True
        d2.BorderRadius = 6
        d2.Checked = True
        d2.CustomizableEdges = CustomizableEdges1
        d2.FillColor = Color.White
        d2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        d2.Format = DateTimePickerFormat.Long
        d2.Location = New Point(308, 41)
        d2.Margin = New Padding(3, 4, 3, 4)
        d2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        d2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        d2.Name = "d2"
        d2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        d2.Size = New Size(260, 33)
        d2.TabIndex = 16
        d2.Value = New Date(2023, 12, 19, 0, 0, 0, 0)
        ' 
        ' d1
        ' 
        d1.Animated = True
        d1.BorderRadius = 6
        d1.Checked = True
        d1.CustomizableEdges = CustomizableEdges3
        d1.FillColor = Color.White
        d1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        d1.Format = DateTimePickerFormat.Long
        d1.Location = New Point(12, 41)
        d1.Margin = New Padding(3, 4, 3, 4)
        d1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        d1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        d1.Name = "d1"
        d1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        d1.Size = New Size(274, 33)
        d1.TabIndex = 15
        d1.Value = New Date(2023, 12, 19, 0, 0, 0, 0)
        ' 
        ' CashierDailySales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(940, 501)
        Controls.Add(d2)
        Controls.Add(d1)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(grdDailySales)
        FormBorderStyle = FormBorderStyle.None
        Name = "CashierDailySales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CashierDailySales"
        CType(grdDailySales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents grdDailySales As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txtDailySales As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents d2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents d1 As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
