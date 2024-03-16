Imports Guna.UI2.WinForms
Imports Mysqlx.XDevAPI.Relational

Public Class main_interface


    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button1.MouseHover
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.BackColor = Color.Blue
        Guna2Button1.FillColor = Color.Blue


    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button1.MouseLeave
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.BackColor = Color.Black
        Guna2Button1.FillColor = Color.Black
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button2.MouseHover

        Guna2Button2.ForeColor = Color.White
        Guna2Button2.BackColor = Color.Blue
        Guna2Button2.FillColor = Color.Blue
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button2.MouseLeave
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.BackColor = Color.Black
        Guna2Button2.FillColor = Color.Black
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button3.MouseHover

        Guna2Button3.ForeColor = Color.White
        Guna2Button3.BackColor = Color.Blue
        Guna2Button3.FillColor = Color.Blue
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button4.MouseLeave
        Guna2Button4.ForeColor = Color.White
        Guna2Button4.BackColor = Color.Black
        Guna2Button4.FillColor = Color.Black
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Guna2Button4.MouseHover

        Guna2Button4.ForeColor = Color.White
        Guna2Button4.BackColor = Color.Blue
        Guna2Button4.FillColor = Color.Blue
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Button3.MouseLeave
        Guna2Button3.ForeColor = Color.White
        Guna2Button3.BackColor = Color.Black
        Guna2Button3.FillColor = Color.Black
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Home_Button.TopLevel = False
        Guna2Panel2.Controls.Add(Home_Button)
        Home_Button.BringToFront()
        Home_Button.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        About_NC.TopLevel = False
        Guna2Panel2.Controls.Add(About_NC)
        About_NC.BringToFront()
        About_NC.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Events_Button.TopLevel = False
        Guna2Panel2.Controls.Add(Events_Button)
        Events_Button.BringToFront()
        Events_Button.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click


        Dim prompt As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If prompt = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
            Student_Profile.StudentIDLabel.Text = ""
            Student_Profile.FirstNameLabel.Text = ""
            Student_Profile.LastNameLabel.Text = ""
            Student_Profile.AgeLabel.Text = ""
            Student_Profile.CourseLabel.Text = ""

            Student_Profile.Hide()
            Grade_Records.Hide()
            Home_Button.Hide()
            Events_Button.Hide()
            About_NC.Hide()
            Me.Guna2Panel3.Show()
            Me.Guna2Panel2.Show()

            If prompt = DialogResult.No Then
                Me.Show()

            End If
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click


        About_NC.Hide()
        Home_Button.Hide()
        Student_Profile.TopLevel = False
        Guna2Panel4.Controls.Add(Student_Profile)
        Me.Guna2Panel3.Hide()
        Me.Guna2Panel2.Hide()
        Guna2Panel4.Enabled = True
        Guna2Panel4.Visible = True
        Student_Profile.BringToFront()
        Student_Profile.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Me.Guna2Panel3.Hide()
        Me.Guna2Panel2.Hide()
        Guna2Panel4.Enabled = True
        Guna2Panel4.Visible = True
        About_NC.Hide()
        Home_Button.Hide()
        Grade_Records.TopLevel = False
        Guna2Panel4.Controls.Add(Grade_Records)
        Grade_Records.BringToFront()
        Grade_Records.Show()

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub main_interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class