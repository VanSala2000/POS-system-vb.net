<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrandForm
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtBrand = New Guna.UI2.WinForms.Guna2TextBox()
        btnReset = New Guna.UI2.WinForms.Guna2Button()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
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
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Me
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(208, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(135, 27)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "ADD BRAND"
        ' 
        ' txtBrand
        ' 
        txtBrand.Animated = True
        txtBrand.CustomizableEdges = CustomizableEdges5
        txtBrand.DefaultText = ""
        txtBrand.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtBrand.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtBrand.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtBrand.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtBrand.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtBrand.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtBrand.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtBrand.Location = New Point(80, 58)
        txtBrand.Name = "txtBrand"
        txtBrand.PasswordChar = ChrW(0)
        txtBrand.PlaceholderText = ""
        txtBrand.SelectedText = ""
        txtBrand.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtBrand.Size = New Size(386, 36)
        txtBrand.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtBrand.TabIndex = 1
        ' 
        ' btnReset
        ' 
        btnReset.BorderRadius = 5
        btnReset.Cursor = Cursors.Hand
        btnReset.CustomizableEdges = CustomizableEdges1
        btnReset.DisabledState.BorderColor = Color.DarkGray
        btnReset.DisabledState.CustomBorderColor = Color.DarkGray
        btnReset.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnReset.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnReset.FillColor = Color.Red
        btnReset.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(289, 109)
        btnReset.Name = "btnReset"
        btnReset.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnReset.Size = New Size(139, 35)
        btnReset.TabIndex = 10
        btnReset.Text = "CANCEL"
        ' 
        ' btnSave
        ' 
        btnSave.Animated = True
        btnSave.BorderRadius = 5
        btnSave.Cursor = Cursors.Hand
        btnSave.CustomizableEdges = CustomizableEdges3
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.DeepSkyBlue
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(121, 109)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSave.Size = New Size(139, 35)
        btnSave.TabIndex = 11
        btnSave.Text = "SAVE"
        ' 
        ' BrandForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 188)
        Controls.Add(btnReset)
        Controls.Add(btnSave)
        Controls.Add(txtBrand)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "BrandForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BrandForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtBrand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
