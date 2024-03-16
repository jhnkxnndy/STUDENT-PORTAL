Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class deleteData
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
        sqlConn.ConnectionString = "server=" & server & ";" & "user id=" & username & ";" & "password=" & password & ";" & "database=" & Database

        ' Open the connection
        sqlConn.Open()

        ' Create the command
        Dim sqlCmd As New MySqlCommand()
        sqlCmd.Connection = sqlConn

        ' Set the SQL command text
        sqlCmd.CommandText = "SELECT StudentID, FirstName, Surname, EmailAdd, Course, Age FROM myconnector.stdmgmt"

        ' Execute the command and get the reader
        Dim stdInfoReader As MySqlDataReader = sqlCmd.ExecuteReader()

        ' Read the data from the reader
        stdInfoReader.Read()
        ' Process the data from std_info table
        ' For example:
        Dim StudentId As String = stdInfoReader("StudentID").ToString()
        Dim FirstName As String = stdInfoReader("FirstName").ToString()
        Dim Surname As String = stdInfoReader("Surname").ToString()
        Dim EmailAdd As String = stdInfoReader("EmailAdd").ToString()
        Dim Course As String = stdInfoReader("Course").ToString()
        Dim Age As Integer = Convert.ToInt32(stdInfoReader("Age"))
        Console.WriteLine("student_id: " & StudentId & ", FirstName: " & FirstName & ", Surname: " & Surname & ", EmailAdd: " & EmailAdd & ", Course: " & Course & ", Age: " & Age)


        ' Close the reader

        stdInfoReader.Close()
        sqlConn.Close()


        'sqlConn.Open()
        'sqlCmd.Connection = sqlConn
        'sqlCmd.CommandText = "SELECT * FROM myconnector.myconnector"

        sqlConn.Open()
        sqlDR = sqlCmd.ExecuteReader
        sqlDt.Load(sqlDR)
        DataGridView6.Refresh()
        sqlDR.Close()
        sqlConn.Close()
        DataGridView6.DataSource = sqlDt
    End Sub
    Private Sub deleteData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView6.Refresh()
        viewer()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim connectionString As String = "server=" + server + ";user id=" + username + ";password=" + password + ";database=" + database
        ' Loop through selected rows in DataGridView
        For Each row As DataGridViewRow In DataGridView6.SelectedRows
            ' Remove row from DataGridView
            DataGridView6.Rows.Remove(row)

            ' Retrieve the StudentID from the selected row
            Dim studentID As String = If(row.Cells(0)?.Value?.ToString(), "")

            ' Check if the studentID is not null or empty
            If Not String.IsNullOrEmpty(studentID) Then
                ' Construct the SQL command to delete the corresponding record from the database
                Dim deleteCommandText As String = "DELETE FROM `myconnector`.`myconnector` WHERE (`StudentID` = '@StudentID');"

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
                                ' The delete was successful, handle accordingly
                            Else
                                ' No rows were affected, handle accordingly
                            End If
                        Catch ex As Exception
                            ' Handle exceptions
                        Finally
                            ' Close the connection
                            sqlConn.Close()
                            DataGridView6.Refresh()
                            viewer()
                        End Try
                    End Using
                End Using
            End If
        Next

        ' Call viewer() after the delete operation is completed for all selected rows
        viewer()


    End Sub

    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick

    End Sub
End Class