Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC.Rfc8032
Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub


    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged


        If Guna2CheckBox1.Checked = False Then
            Password.PasswordChar = "*"
        Else
            Password.PasswordChar = ""
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click


        Dim db As New MY_DB()
        db.openConnection()

        Dim selectDbQuery As String = "USE myconnector"
        Dim selectDbCommand As New MySqlCommand(selectDbQuery, db.getConnection)

        selectDbCommand.ExecuteNonQuery()
        Dim useradapter As New MySqlDataAdapter()
        Dim usertable As New DataTable()
        Dim gradesadapter As New MySqlDataAdapter()
        Dim gradestable As New DataTable()


        Dim usercommand As New MySqlCommand("SELECT * FROM `stdmgmt`  WHERE `StudentID` = @username AND `password` = @pass", db.getConnection)
        usercommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = StudentID.Text
        usercommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text

        Dim gradesCommand As New MySqlCommand("SELECT * FROM grade_records WHERE StudentID = @StudentID", db.getConnection)
        gradesCommand.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = StudentID.Text



        useradapter.SelectCommand = usercommand
        useradapter.Fill(usertable)
        gradesadapter.SelectCommand = gradesCommand
        gradesadapter.Fill(gradestable)

        If usertable.Rows.Count > 0 Then
            MsgBox("Successfully logged in!")


            main_interface.Guna2Panel3.Show()

            Student_Profile.StudentIDLabel.Text = ""
            Student_Profile.FirstNameLabel.Text = ""
            Student_Profile.MNLabel.Text = ""
            Student_Profile.LastNameLabel.Text = ""
            Student_Profile.AgeLabel.Text = ""
            Student_Profile.CourseLabel.Text = ""

            Dim studentID As String = usertable.Rows(0)("StudentID").ToString()
            Dim firstName As String = usertable.Rows(0)("FirstName").ToString()
            Dim midName As String = usertable.Rows(0)("MiddleName").ToString()
            Dim surName As String = usertable.Rows(0)("Surname").ToString()
            Dim emailadd As String = usertable.Rows(0)("EmailAdd").ToString()
            Dim course As String = usertable.Rows(0)("Course").ToString()
            Dim age As Integer = Convert.ToInt32(usertable.Rows(0)("Age"))
            Dim dob As String = usertable.Rows(0).Field(Of DateTime)("DOB")



            ' For Labels
            Student_Profile.StudentIDLabel.Text = studentID
            Student_Profile.FirstNameLabel.Text = firstName
            Student_Profile.MNLabel.Text = midName
            Student_Profile.LastNameLabel.Text = surName
            Student_Profile.CourseLabel.Text = course
            Student_Profile.AgeLabel.Text = age.ToString()
            Student_Profile.DOBLabel.Text = dob

            Grade_Records.StdIDLabel.Text = studentID
            Grade_Records.NameLabel.Text = surName + (", ") + firstName + (" ") + midName
            Grade_Records.CourseLabel.Text = course

            If gradestable.Rows.Count > 0 Then
                Dim csc3 As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("CSC3").ToString()), gradestable.Rows(0)("CSC3").ToString(), "n/a")
                Dim csc4 As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("CSC4").ToString()), gradestable.Rows(0)("CSC4").ToString(), "n/a")
                Dim gelec As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("GElec").ToString()), gradestable.Rows(0)("GElec").ToString(), "n/a")
                Dim cw101 As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("CW101").ToString()), gradestable.Rows(0)("CW101").ToString(), "n/a")
                Dim hum2 As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("HUM2").ToString()), gradestable.Rows(0)("HUM2").ToString(), "n/a")
                Dim nstp2 As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("NSTP2").ToString()), gradestable.Rows(0)("NSTP2").ToString(), "n/a")
                Dim ds101 As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("DS101").ToString()), gradestable.Rows(0)("DS101").ToString(), "n/a")
                Dim fildis As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("FILDIS").ToString()), gradestable.Rows(0)("FILDIS").ToString(), "n/a")
                Dim pe As String = If(Not String.IsNullOrEmpty(gradestable.Rows(0)("PE").ToString()), gradestable.Rows(0)("PE").ToString(), "n/a")

                ' For Labels on Grade_Records form
                Grade_Records.g1.Text = csc3
                Grade_Records.g2.Text = csc4
                Grade_Records.g3.Text = gelec
                Grade_Records.g4.Text = cw101
                Grade_Records.g5.Text = hum2
                Grade_Records.g6.Text = nstp2
                Grade_Records.g7.Text = ds101
                Grade_Records.g8.Text = fildis
                Grade_Records.g9.Text = pe
            Else
                Grade_Records.g1.Text = "n/a"
                Grade_Records.g2.Text = "n/a"
                Grade_Records.g3.Text = "n/a"
                Grade_Records.g4.Text = "n/a"
                Grade_Records.g5.Text = "n/a"
                Grade_Records.g6.Text = "n/a"
                Grade_Records.g7.Text = "n/a"
                Grade_Records.g8.Text = "n/a"
                Grade_Records.g9.Text = "n/a"
            End If

            Controls.Clear()
            InitializeComponent()
            Student_Profile.Hide()

            main_interface.TopLevel = False
            Form1.Controls.Add(main_interface)
            main_interface.BringToFront()
            main_interface.Show()

        Else
            DialogResult = MsgBox("Incorrect or Missing Credentials!", MsgBoxStyle.Critical, "Login Error!")

            If DialogResult = DialogResult.OK Then
                StudentID.Text = ""
                Password.Text = ""
                Me.BringToFront()
                Me.Show()

            End If


        End If

        'Me.Show()
        'Controls.Clear()
        'InitializeComponent()
        'Me.Hide()
        'Form1.Show()
        'Me.Show()




        'Dim conn As New MySqlConnection("Data source=localhost;database=myconnector;username=root;password=mysql_admin081105")
        'conn.Open()
        'Dim cmd As New MySqlCommand("SELECT * From myconnector where username=@StudentID AND password=@EmailAdd", conn)
        'cmd.Parameters.AddWithValue("@StudentID", StudentID.Text.Trim()) 'Assuming StudentID is a textbox where user inputs username
        'cmd.Parameters.AddWithValue("@EmailAdd", Password.Text.Trim()) 'Assuming Password is a textbox where user inputs password
        'Dim reader As MySqlDataReader = cmd.ExecuteReader()

        'If reader.Read() Then
        'main_interface.Show()
        'Me.Hide()
        'Form1.Hide()
        'Else
        'MsgBox("Check username or password!")
        'End If

        'main_interface.TopLevel = False
        'Form1.Controls.Add(main_interface)
        'main_interface.BringToFront()
        'main_interface.Show()
    End Sub

    Public Sub StudentID_TextChanged(sender As Object, e As EventArgs) Handles StudentID.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class