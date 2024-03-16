Imports Guna.UI2.WinForms

Public Class Form1

    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
        login.TopLevel = False
        Panel1.Controls.Add(login)
        login.BringToFront()
        login.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        signup.TopLevel = False
        Panel1.Controls.Add(signup)
        signup.BringToFront()
        signup.Show()
        Guna2Button2.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Admin_Login.TopLevel = False
        Panel1.Controls.Add(Admin_Login)
        Admin_Login.BringToFront()
        Admin_Login.Show()

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        signup.TopLevel = False
        Panel1.Controls.Add(signup)
        signup.BringToFront()
        signup.Show()
        Guna2Button2.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
