Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports Google.Protobuf.WellKnownTypes

Public Class signup
    Dim sqlConn As New [MySqlConnection]
    Dim sqlCmd As New [MySqlCommand]
    Dim sqlDR As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim dtA As New MySqlDataAdapter

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "mysql_admin081105"
    Dim database As String = "myconnector"
    Dim sqlquery As String

    Private bitmap As Bitmap

    Private Function StudentIDExists(studentID As String) As Boolean
        Dim connectionString As String = "server=" & server & ";" & "user id=" & username & ";" & "password=" & password & ";" & "database=" & database

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM myconnector.stdmgmt WHERE StudentID = @StudentID"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@StudentID", studentID)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Dispose()
        Form1.Guna2Button2.Show()
    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        sqlConn.ConnectionString = "server=" & server & ";" & "user id=" & username & ";" & "password=" & password & ";" & "database=" & database
        Dim studentID As String = txtSN.Text.Trim()


        sqlConn.ConnectionString = "server =" + server + ";" + "user id  =" + username + ";" _
        + "password =" + password + ";" + "database =" + database




        Try

            If StudentIDExists(studentID) Then
                DialogResult = MessageBox.Show("Student Number already registered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            sqlConn.Open()

            sqlquery = "Insert into myconnector.stdmgmt(StudentID, FirstName, MiddleName, Surname, EmailAdd, Age, Course, password, DOB)
            values('" & txtSN.Text & "','" & txtFirstName.Text & "','" & txtMidName.Text & "','" & txtLastName.Text & "','" & txtEmailAdd.Text & "','" & txtAge.Text &
            "', '" & cmbCourse.SelectedItem & "','" & txtPassword.Text & "','" & DT_DOB.Value.Date.ToString("yyyy-MM-dd") & "')"

            sqlCmd = New MySqlCommand(sqlquery, sqlConn)
            sqlDR = sqlCmd.ExecuteReader
            MessageBox.Show("The account was created successfully!", "Create New Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            login.Show()
            sqlConn.Close()


        Catch ex As Exception

            'MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
            Form1.Guna2Button2.Show()
            login.Show()
        End Try

        'main_interface.Show()
        'Me.Hide()
        'Form1.Hide()
    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSN_TextChanged(sender As Object, e As EventArgs) Handles txtSN.TextChanged

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
End Class