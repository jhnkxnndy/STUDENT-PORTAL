Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Student_Profile
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



    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub


    Private Sub Student_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Assuming you have a connection string defined
        ' Define your connection string
        'Dim connectionString As String = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & database

        ' Define your SQL query
        'Dim query As String = "SELECT StudentID, FirstName, Surname, Course, Age FROM myconnector.myconnector"

        ' Create a new MySqlConnection
        'Using connection As New MySqlConnection(connectionString)
        ' Create a new MySqlCommand
        'Using command As New MySqlCommand(query, connection)
        'Try
        ' Open the connection
        'Connection.Open()

        ' Create a DataAdapter to fetch data from the database
        'Dim adapter As New MySqlDataAdapter(command)

        ' Create a DataTable to hold the results
        'Dim dataTable As New DataTable()

        ' Fill the DataTable with data from the database
        'adapter.Fill(dataTable)

        ' Check if any rows were returned
        'If dataTable.Rows.Count > 0 Then
        ' Retrieve data from the first row
        'Dim row As DataRow = dataTable.Rows(0)

        ' Assign values to each label
        'ext = row("StudentID").ToString()
        'FirstNameLabel.Text = row("FirstName").ToString()
        'LastNameLabel.Text = row("Surname").ToString()
        ' = row("Course").ToString()
        'AgeLabel.Text = row("Age").ToString()
        'Else
        ' If no rows were returned, display a message or clear labels
        'ext = ""
        'FirstNameLabel.Text = ""
        'LastNameLabel.Text = ""
        'CourseLabel.Text = ""
        'AgeLabel.Text = ""
        'End If
        ' As Exception
        ' Handle exceptions
        'MessageBox.Show("Error: " & ex.Message)
        'End Try



        'End Using
        'End Using
        'Me.Update()
        main_interface.Guna2Panel3.Hide()
        main_interface.Guna2Panel2.Size = New System.Drawing.Size(944, 713)
    End Sub

    Private Sub StudentIDLabel_Click(sender As Object, e As EventArgs) Handles StudentIDLabel.Click

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

    End Sub
End Class