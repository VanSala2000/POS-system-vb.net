<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModelForm
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        btnReset = New Guna.UI2.WinForms.Guna2Button()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        txtModel = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        btnReset.Location = New Point(291, 109)
        btnReset.Name = "btnReset"
        btnReset.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnReset.Size = New Size(139, 35)
        btnReset.TabIndex = 14
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
        btnSave.Location = New Point(123, 109)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSave.Size = New Size(139, 35)
        btnSave.TabIndex = 15
        btnSave.Text = "SAVE"
        ' 
        ' txtModel
        ' 
        txtModel.Animated = True
        txtModel.CustomizableEdges = CustomizableEdges5
        txtModel.DefaultText = ""
        txtModel.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtModel.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtModel.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtModel.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtModel.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtModel.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtModel.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtModel.Location = New Point(82, 58)
        txtModel.Name = "txtModel"
        txtModel.PasswordChar = ChrW(0)
        txtModel.PlaceholderText = ""
        txtModel.SelectedText = ""
        txtModel.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtModel.Size = New Size(386, 36)
        txtModel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtModel.TabIndex = 13
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(210, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(137, 27)
        Guna2HtmlLabel1.TabIndex = 12
        Guna2HtmlLabel1.Text = "ADD MODEL"
        ' 
        ' ModelForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 188)
        Controls.Add(btnReset)
        Controls.Add(btnSave)
        Controls.Add(txtModel)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ModelForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModelForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtModel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
