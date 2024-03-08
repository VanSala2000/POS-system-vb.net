Imports MySql.Data.MySqlClient

Public Class buttonAccountSettings

    Sub childform(ByVal panel As Form)
        mainPanel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        mainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub buttonAccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        childform(buttonChangePassword)
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        childform(buttonChangePassword)
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        childform(buttonCreateAccount)
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        childform(buttonDeleteAccount)
    End Sub
End Class