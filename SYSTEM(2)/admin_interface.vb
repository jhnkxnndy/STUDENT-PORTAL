Imports System.Data.Common
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class admin_interface

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


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles AddDataBtn.Click
        EditData.TopLevel = False
        AdminPanel.Controls.Add(EditData)
        EditData.BringToFront()
        EditData.Show()

    End Sub

    Private Sub admin_interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        datagrids.TopLevel = False
        AdminPanel.Controls.Add(datagrids)
        datagrids.BringToFront()
        datagrids.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim prompt As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If prompt = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
            Guna2Button2.Show()

            EditData.Hide()
            Grades.Hide()

            If prompt = DialogResult.No Then
                Me.Show()

            End If
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Grades.Refresh()
        Grades.DataGridView5.Refresh()
        Grades.TopLevel = False
        AdminPanel.Controls.Add(Grades)
        Grades.BringToFront()
        Grades.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        deleteData.TopLevel = False
        AdminPanel.Controls.Add(deleteData)
        deleteData.BringToFront()
        deleteData.Show()
    End Sub
End Class