<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDiscount
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtDiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
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
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.ForeColor = Color.Black
        Guna2HtmlLabel1.Location = New Point(54, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(125, 34)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "DISCOUNT"
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Animated = True
        txtDiscount.CustomizableEdges = CustomizableEdges3
        txtDiscount.DefaultText = ""
        txtDiscount.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtDiscount.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtDiscount.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtDiscount.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtDiscount.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtDiscount.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtDiscount.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtDiscount.Location = New Point(63, 52)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.PasswordChar = ChrW(0)
        txtDiscount.PlaceholderText = ""
        txtDiscount.SelectedText = ""
        txtDiscount.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtDiscount.Size = New Size(102, 34)
        txtDiscount.TabIndex = 1
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.Cursor = Cursors.Hand
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox1.FillColor = Color.White
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(197, 12)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox1.Size = New Size(22, 18)
        Guna2ControlBox1.TabIndex = 11
        ' 
        ' AddDiscount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(231, 122)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(txtDiscount)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddDiscount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddDiscount"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txtDiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
