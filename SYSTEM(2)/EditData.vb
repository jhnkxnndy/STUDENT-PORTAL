Imports Microsoft.SqlServer
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes

Public Class EditData
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

    Private Sub viewer()
        ' Set up connection string
        sqlConn.ConnectionString = "server=" & server & ";" & "user id=" & username & ";" & "password=" & password & ";" & "database=" & database

        ' Open the connection
        sqlConn.Open()

        ' Create the command
        Dim sqlCmd As New MySqlCommand()
        sqlCmd.Connection = sqlConn

        ' Set the SQL command text
        sqlCmd.CommandText = "SELECT StudentID, FirstName, MiddleName, Surname, EmailAdd, Course, Age, DOB FROM myconnector.stdmgmt"

        ' Execute the command and get the reader
        Dim stdInfoReader As MySqlDataReader = sqlCmd.ExecuteReader()

        ' Read the data from the reader
        stdInfoReader.Read()
        ' Process the data from std_info table
        ' For example:
        Dim StudentId As String = stdInfoReader("StudentID").ToString()
        Dim FirstName As String = stdInfoReader("FirstName").ToString()
        Dim MiddleName As String = stdInfoReader("MiddleName").ToString()
        Dim Surname As String = stdInfoReader("Surname").ToString()
        Dim EmailAdd As String = stdInfoReader("EmailAdd").ToString()
        Dim Course As String = stdInfoReader("Course").ToString()
        Dim Age As Integer = Convert.ToInt32(stdInfoReader("Age"))
        Dim DOB As String = stdInfoReader("DOB").ToString()
        Console.WriteLine("student_id: " & StudentId & ", FirstName: " & FirstName & ", MiddleName: " & MiddleName & ", Surname: " & Surname & ", EmailAdd: " & EmailAdd & ", Course: " & Course & ", Age: " & Age & ", DOB: " & DOB)


        ' Close the reader

        stdInfoReader.Close()
        sqlConn.Close()


        'sqlConn.Open()
        'sqlCmd.Connection = sqlConn
        'sqlCmd.CommandText = "SELECT * FROM myconnector.myconnector"

        sqlConn.Open()
        sqlDR = sqlCmd.ExecuteReader
        sqlDt.Load(sqlDR)
        DataGridView2.Refresh()
        sqlDR.Close()
        sqlConn.Close()
        DataGridView2.DataSource = sqlDt


    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub AddNewDataBtn_Click(sender As Object, e As EventArgs) Handles AddNewDataBtn.Click
        ' Construct the connection string
        Dim connectionString As String = "server=" + server + ";user id=" + username + ";password=" + password + ";database=" + database

        ' Create a new MySqlConnection with the constructed connection string
        Using sqlConn As New MySqlConnection(connectionString)
            ' Define the MySqlCommand within the Using block to ensure proper disposal
            sqlConn.ConnectionString = "server =" + server + ";" + "user id  =" + username + ";" _
       + "password =" + password + ";" + "database =" + database



            Try
                sqlConn.Open()
                sqlquery = "Insert into myconnector.stdmgmt(StudentID, FirstName, MiddleName, Surname, EmailAdd, Course, Age)
            values('" & adminStdID.Text & "','" & adminFN.Text & "','" & adminMN.Text & "','" & adminSN.Text & "','" & adminEAD.Text &
            "','" & adminCourse.SelectedItem & "', '" & adminAge.Text & "')"

                sqlCmd = New MySqlCommand(sqlquery, sqlConn)
                sqlDR = sqlCmd.ExecuteReader
                MessageBox.Show("The data was added successfully!", "Add Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

                adminStdID.Text = ""
                adminFN.Text = ""
                adminSN.Text = ""
                adminMN.Text = ""
                adminEAD.Text = ""
                adminCourse.SelectedItem = ""
                adminAge.Text = ""
                adminDOB.Text = ""

                'admin_interface.Show()
                'Me.Hide()
                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally

            End Try
            viewer()
        End Using
    End Sub


    Private Sub AddData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewer()

    End Sub



    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        ' Construct the connection string
        Dim connectionString As String = "server=" + server + ";user id=" + username + ";password=" + password + ";database=" + database

        ' Create a new MySqlConnection with the constructed connection string
        Using sqlConn As New MySqlConnection(connectionString)
            ' Define the MySqlCommand within the Using block to ensure proper disposal
            Using sqlCmd As New MySqlCommand()
                Try
                    ' Set the connection for the command
                    sqlCmd.Connection = sqlConn
                    ' Open the connection before executing any command
                    sqlConn.Open()

                    ' Set the command text and type
                    sqlCmd.CommandText = "UPDATE myconnector.stdmgmt SET StudentID = @StudentID, FirstName = @FirstName, MiddleName = @MiddleName, Surname = @Surname, EmailAdd = @EmailAdd, Course = @Course, Age = @Age, DOB = @DOB WHERE StudentID = @StudentID"
                    sqlCmd.CommandType = CommandType.Text
                    ' Clear existing parameters to avoid duplicates
                    sqlCmd.Parameters.Clear()

                    ' Add parameters
                    sqlCmd.Parameters.AddWithValue("@StudentID", adminStdID.Text)
                    sqlCmd.Parameters.AddWithValue("@FirstName", adminFN.Text)
                    sqlCmd.Parameters.AddWithValue("@MiddleName", adminMN.Text)
                    sqlCmd.Parameters.AddWithValue("@Surname", adminSN.Text)
                    sqlCmd.Parameters.AddWithValue("@EmailAdd", adminEAD.Text)
                    sqlCmd.Parameters.AddWithValue("@Course", adminCourse.Text)
                    sqlCmd.Parameters.AddWithValue("@Age", adminAge.Text)
                    sqlCmd.Parameters.AddWithValue("@DOB", adminDOB.Text)


                    ' Execute the SQL command
                    Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()

                    ' Check if any rows were affected
                    If rowsAffected > 0 Then
                        DataGridView2.Refresh()
                        MessageBox.Show("The update was successful!", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' The update was successful, handle accordingly
                    Else
                        ' No rows were affected, handle accordingly
                    End If
                Catch ex As Exception
                    ' Handle exceptions
                Finally
                    ' Close the connection after execution
                    sqlConn.Close()
                End Try
            End Using
        End Using

        ' Call viewer() after the SQL operation is completed
        viewer()
    End Sub

    Private Sub DataGridView2_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            adminStdID.Text = DataGridView2.SelectedRows(0).Cells(0).Value.ToString
            adminFN.Text = DataGridView2.SelectedRows(0).Cells(1).Value.ToString
            adminMN.Text = DataGridView2.SelectedRows(0).Cells(2).Value.ToString
            adminSN.Text = DataGridView2.SelectedRows(0).Cells(3).Value.ToString
            adminEAD.Text = DataGridView2.SelectedRows(0).Cells(4).Value.ToString
            adminCourse.Text = DataGridView2.SelectedRows(0).Cells(5).Value.ToString
            adminAge.Text = DataGridView2.SelectedRows(0).Cells(6).Value.ToString

            Dim dobCellValue As Object = DataGridView2.SelectedRows(0).Cells(7).Value

            If dobCellValue IsNot Nothing AndAlso Not DBNull.Value.Equals(dobCellValue) Then
                ' Parse the cell value as a DateTime object
                Dim dobValue As DateTime = Convert.ToDateTime(dobCellValue)
                ' Assign the date portion to the adminDOB textbox
                adminDOB.Text = dobValue.Date.ToString("yyyy-MM-dd")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim connectionString As String = "server=" + server + ";user id=" + username + ";password=" + password + ";database=" + database

        ' Loop through selected rows in DataGridView
        For Each row As DataGridViewRow In DataGridView2.SelectedRows
            ' Retrieve the StudentID from the selected row
            Dim studentID As String = If(row.Cells(0)?.Value?.ToString(), "")

            ' Check if the studentID is not null or empty
            If Not String.IsNullOrEmpty(studentID) Then
                ' Construct the SQL command to delete the corresponding record from the database
                Dim deleteCommandText As String = "DELETE FROM `myconnector`.`stdmgmt` WHERE `StudentID` = @StudentID;"

                ' Create a new MySqlConnection
                Using sqlConn As New MySqlConnection(connectionString)
                    ' Create a new MySqlCommand to execute the delete command
                    Using sqlCmd As New MySqlCommand(deleteCommandText, sqlConn)
                        ' Add parameters to the command
                        sqlCmd.Parameters.AddWithValue("@StudentID", studentID)

                        Try
                            ' Open the connection
                            sqlConn.Open()

                            ' Execute the delete command
                            Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()

                            ' Check if any rows were affected
                            If rowsAffected > 0 Then
                                DataGridView2.Rows.Remove(row)
                                ' The delete was successful, handle accordingly
                            Else
                                ' No rows were affected, handle accordingly
                            End If
                        Catch ex As Exception
                            ' Handle exceptions

                        Finally
                            ' Close the connection
                            sqlConn.Close()
                            DataGridView2.Refresh()
                            Grades.DataGridView5.Refresh()
                        End Try
                    End Using
                End Using
            End If
        Next

        ' Call viewer() after the delete operation is completed for all selected rows
        viewer()

    End Sub
End Class