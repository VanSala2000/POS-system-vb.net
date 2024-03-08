Public Class AdminDashboard
    Sub childform(ByVal panel As Form)
        mainPanel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        mainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Logging out...")
            Me.Close()

            Dim frmShow As New Form1
            Form1.Show()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        childform(buttonDashboard)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        childform(buttonView)
    End Sub

    Private Sub btnAccountSettings_Click(sender As Object, e As EventArgs) Handles btnAccountSettings.Click
        childform(buttonAccountSettings)
    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint
        childform(buttonDashboard)
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        buttonBrand.ShowDialog()
    End Sub
    Private Sub btnSalesHistory_Click(sender As Object, e As EventArgs) Handles btnSalesHistory.Click
        childform(buttonSalesHistory)
    End Sub
End Class