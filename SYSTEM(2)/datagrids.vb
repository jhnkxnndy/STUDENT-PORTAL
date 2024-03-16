Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class datagrids

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

    Private Sub signup()
        ' Set up connection string
        sqlConn.ConnectionString = "server=" & server & ";" & "user id=" & username & ";" & "password=" & password & ";" & "database=" & database

        ' Open the connection
        sqlConn.Open()

        ' Create the command
        Dim sqlCmd As New MySqlCommand()
        sqlCmd.Connection = sqlConn

        ' Set the SQL command text
        sqlCmd.CommandText = "SELECT StudentID, FirstName, Surname, EmailAdd, Course, Age FROM myconnector.myconnector"

        ' Execute the command and get the reader
        Dim stdInfoReader As MySqlDataReader = sqlCmd.ExecuteReader()

        ' Read the data from the reader
        While stdInfoReader.Read()
            ' Process the data from std_info table
            ' For example:
            Dim StudentId As String = stdInfoReader("StudentID").ToString()
            Dim FirstName As String = stdInfoReader("FirstName").ToString()
            Dim Surname As String = stdInfoReader("Surname").ToString()
            Dim EmailAdd As String = stdInfoReader("EmailAdd").ToString()
            Dim Course As String = stdInfoReader("Course").ToString()
            Dim Age As Integer = Convert.ToInt32(stdInfoReader("Age"))
            Console.WriteLine("student_id: " & StudentId & ", FirstName: " & FirstName & ", Surname: " & Surname & ", EmailAdd: " & EmailAdd & ", Course: " & Course & ", Age: " & Age)
        End While
        stdInfoReader.Close()

        ' Close the connection before loading data into DataGridView
        sqlConn.Close()

        ' Open the connection again
        sqlConn.Open()

        ' Load the data into DataGridView
     
        sqlDR = sqlCmd.ExecuteReader
        sqlDt.Load(sqlDR)
        DataGridView3.Refresh()
        sqlDR.Close()
        sqlConn.Close()
        DataGridView3.DataSource = sqlDt
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub datagrids_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView3.Refresh()
        signup()
        DataGridView3.Show()


    End Sub
End Class