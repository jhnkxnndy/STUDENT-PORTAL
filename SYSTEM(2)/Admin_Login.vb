Imports MySql.Data.MySqlClient

Public Class Admin_Login
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click, MyBase.Load
        Hide()
        login.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim db As New MY_DB()
        db.openConnection()

        Dim selectDbQuery As String = "USE myconnector"
        Dim selectDbCommand As New MySqlCommand(selectDbQuery, db.getConnection)


        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `admin`  WHERE `username` = @username AND `password` = @password", db.getConnection)
        selectDbCommand.ExecuteNonQuery()

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtAdminPass.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            MsgBox("Successfully logged in!")
            Controls.Clear()
            InitializeComponent()
            EditData.DataGridView2.Refresh()
            EditData.Hide()
            admin_interface.TopLevel = False
            Form1.Controls.Add(admin_interface)
            admin_interface.BringToFront()
            admin_interface.Show()
            EditData.DataGridView2.Refresh()
        Else

            MsgBox("Incorrect Credentials!", MsgBoxStyle.Critical, "Login Error!")
            Controls.Clear()
            InitializeComponent()

            Me.BringToFront()
            Me.Show()

        End If
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub


    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Dispose()
        Form1.Guna2Button2.Show()
    End Sub
End Class