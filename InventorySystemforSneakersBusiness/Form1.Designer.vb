<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        btnAdmin = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        Label2 = New Label()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(components)
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
        ' btnLogin
        ' 
        btnLogin.Animated = True
        btnLogin.AutoRoundedCorners = True
        btnLogin.BackColor = Color.Transparent
        btnLogin.BorderRadius = 21
        btnLogin.Cursor = Cursors.Hand
        btnLogin.CustomizableEdges = CustomizableEdges7
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.IndianRed
        btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(54, 129)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnLogin.Size = New Size(180, 45)
        btnLogin.TabIndex = 0
        btnLogin.Text = "USER LOGIN"
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Animated = True
        btnAdmin.AutoRoundedCorners = True
        btnAdmin.BackColor = Color.Transparent
        btnAdmin.BorderRadius = 21
        btnAdmin.Cursor = Cursors.Hand
        btnAdmin.CustomizableEdges = CustomizableEdges5
        btnAdmin.DisabledState.BorderColor = Color.DarkGray
        btnAdmin.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdmin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdmin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdmin.FillColor = Color.IndianRed
        btnAdmin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdmin.ForeColor = Color.White
        btnAdmin.Location = New Point(54, 189)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnAdmin.Size = New Size(180, 45)
        btnAdmin.TabIndex = 0
        btnAdmin.Text = "ADMIN LOGIN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLightLight
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(77, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 32)
        Label1.TabIndex = 1
        Label1.Text = "INVENTORY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLightLight
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(94, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 32)
        Label2.TabIndex = 1
        Label2.Text = "SYSTEM"
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.Cursor = Cursors.Hand
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = Color.White
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(265, 12)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(22, 18)
        Guna2ControlBox1.TabIndex = 2
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox2.Cursor = Cursors.Hand
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox2.FillColor = Color.White
        Guna2ControlBox2.IconColor = Color.DimGray
        Guna2ControlBox2.Location = New Point(237, 12)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox2.Size = New Size(22, 18)
        Guna2ControlBox2.TabIndex = 2
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2DragControl2
        ' 
        Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl2.TargetControl = Me
        Guna2DragControl2.UseTransparentDrag = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(299, 293)
        Controls.Add(Guna2ControlBox2)
        Controls.Add(Guna2ControlBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAdmin)
        Controls.Add(btnLogin)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btnAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
End Class
