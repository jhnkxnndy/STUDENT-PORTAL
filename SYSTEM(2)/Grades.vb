Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Grades

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

    Private Sub viewer()
        
        sqlConn.ConnectionString = "server=" & server & ";" & "user id=" & username & ";" & "password=" & password & ";" & "database=" & database

        
        sqlConn.Open()

        
        Dim sqlCmd As New MySqlCommand()
        sqlCmd.Connection = sqlConn

        
        sqlCmd.CommandText = "USE myconnector; SELECT stdmgmt.StudentID, grade_records.CSC3, grade_records.CSC4, grade_records.GElec, grade_records.CW101, grade_records.HUM2, grade_records.NSTP2, grade_records.DS101, grade_records.FILDIS, grade_records.PE
                         FROM (SELECT StudentID FROM stdmgmt) AS stdmgmt
                         LEFT JOIN grade_records ON stdmgmt.StudentID = grade_records.StudentID"

        
        Dim stdInfoReader As MySqlDataReader = sqlCmd.ExecuteReader()

      
        stdInfoReader.Read()
         
       
        Dim StudentId As String = stdInfoReader("StudentID").ToString()
        Dim CSC3 As String = stdInfoReader("CSC3").ToString()
        Dim CSC4 As String = stdInfoReader("CSC4").ToString()
        Dim GElec As String = stdInfoReader("GElec").ToString()
        Dim CW101 As String = stdInfoReader("CW101").ToString()
        Dim HUM2 As String = stdInfoReader("HUM2").ToString()
        Dim NSTP2 As String = stdInfoReader("NSTP2").ToString()
        Dim DS101 As String = stdInfoReader("DS101").ToString()
        Dim FILDIS As String = stdInfoReader("FILDIS").ToString()
        Dim PE As String = stdInfoReader("PE").ToString()

        Console.WriteLine("student_id: " & StudentId & ", CSC3: " & CSC3 & ", CSC4: " & CSC4 & ", GElec: " & GElec & ", CW101: " & CW101 & ", HUM2: " & HUM2 & ", NSTP2: " & NSTP2 & ", DS101: " & DS101 & ", FILDIS: " & FILDIS & ", PE: " & PE)


       

        stdInfoReader.Close()
        sqlConn.Close()


        
        sqlConn.Open()
        sqlDR = sqlCmd.ExecuteReader
        sqlDt.Load(sqlDR)
        DataGridView5.Refresh()
        sqlDR.Close()
        sqlConn.Close()
        DataGridView5.DataSource = sqlDt
        DataGridView5.ReadOnly = False

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim connectionString As String = "server=" + server + ";user id=" + username + ";password=" + password + ";database=" + database

        
        Using sqlConn As New MySqlConnection(connectionString)
            
            Using sqlCmd As New MySqlCommand()
                Try
                   
                    sqlCmd.Connection = sqlConn
                    
                    sqlConn.Open()

                 
                    sqlCmd.CommandText = "USE myconnector; UPDATE grade_records
                       SET 
                       StudentID = @StudentID,
                       CSC3 = @CSC3,
                       CSC4 = @CSC4,
                       GElec = @GElec,
                       CW101 = @CW101,
                       HUM2 = @HUM2,
                       NSTP2 = @NSTP2,
                       DS101 = @DS101,
                       FILDIS = @FILDIS,
                       PE = @PE
                       WHERE 
                       StudentID = @StudentID;"

                    sqlCmd.CommandType = CommandType.Text
                    ' Clear existing parameters to avoid duplicates
                    sqlCmd.Parameters.Clear()

                    ' Add parameters
                    sqlCmd.Parameters.AddWithValue("@StudentID", txtSID.Text)
                    sqlCmd.Parameters.AddWithValue("@CSC3", txtBox1.Text)
                    sqlCmd.Parameters.AddWithValue("@CSC4", txtBox2.Text)
                    sqlCmd.Parameters.AddWithValue("@GElec", txtBox3.Text)
                    sqlCmd.Parameters.AddWithValue("@CW101", txtBox4.Text)
                    sqlCmd.Parameters.AddWithValue("@HUM2", txtBox5.Text)
                    sqlCmd.Parameters.AddWithValue("@NSTP2", txtBox6.Text)
                    sqlCmd.Parameters.AddWithValue("@DS101", txtBox7.Text)
                    sqlCmd.Parameters.AddWithValue("@FILDIS", txtBox8.Text)
                    sqlCmd.Parameters.AddWithValue("@PE", txtBox9.Text)


                    ' Execute the SQL command
                    Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()

                    ' Check if any rows were affected
                    If rowsAffected > 0 Then
                        DataGridView5.Refresh()
                        MessageBox.Show("The update was successful!", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' The update was successful, handle accordingly
                    Else
                        ' No rows were affected, handle accordingly
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
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

    Private Sub datagridview5_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub

    Private Sub updateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView5.Refresh()
        viewer()
    End Sub

    Private Sub DataGridView5_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick
        Try
            txtSID.Text = DataGridView5.SelectedRows(0).Cells(0).Value.ToString
            txtBox1.Text = DataGridView5.SelectedRows(0).Cells(1).Value.ToString
            txtBox2.Text = DataGridView5.SelectedRows(0).Cells(2).Value.ToString
            txtBox3.Text = DataGridView5.SelectedRows(0).Cells(3).Value.ToString
            txtBox4.Text = DataGridView5.SelectedRows(0).Cells(4).Value.ToString
            txtBox5.Text = DataGridView5.SelectedRows(0).Cells(5).Value.ToString
            txtBox6.Text = DataGridView5.SelectedRows(0).Cells(6).Value.ToString
            txtBox7.Text = DataGridView5.SelectedRows(0).Cells(7).Value.ToString
            txtBox8.Text = DataGridView5.SelectedRows(0).Cells(8).Value.ToString
            txtBox9.Text = DataGridView5.SelectedRows(0).Cells(9).Value.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox1.TextChanged

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim connectionString As String = "server=" + server + ";user id=" + username + ";password=" + password + ";database=" + database

        ' Create a new MySqlConnection with the constructed connection string
        Using sqlConn As New MySqlConnection(connectionString)
            ' Define the MySqlCommand within the Using block to ensure proper disposal
            sqlConn.ConnectionString = "server =" + server + ";" + "user id  =" + username + ";" _
       + "password =" + password + ";" + "database =" + database



            Try
                sqlConn.Open()
                sqlquery = "INSERT INTO myconnector.grade_records (StudentID, CSC3, CSC4, GElec, CW101, HUM2, NSTP2, DS101, FILDIS, PE) " &
           "VALUES ('" & txtSID.Text & "','" & txtBox1.Text & "','" & txtBox2.Text & "','" & txtBox3.Text & "','" & txtBox4.Text & "','" & txtBox5.Text & "','" & txtBox6.Text &
           "','" & txtBox7.Text & "', '" & txtBox8.Text & "','" & txtBox9.Text & "')"


                sqlCmd = New MySqlCommand(sqlquery, sqlConn)
                sqlDR = sqlCmd.ExecuteReader
                MessageBox.Show("The data was added successfully!", "Add Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtSID.Text = ""
                txtBox1.Text = ""
                txtBox2.Text = ""
                txtBox3.Text = ""
                txtBox4.Text = ""
                txtBox5.Text = ""
                txtBox6.Text = ""
                txtBox7.Text = ""
                txtBox8.Text = ""
                txtBox9.Text = ""

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
End Class
