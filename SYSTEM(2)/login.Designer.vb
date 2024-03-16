<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        StudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Password = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Label2 = New Label()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StudentID
        ' 
        StudentID.BackColor = Color.White
        StudentID.BorderColor = SystemColors.ActiveCaptionText
        StudentID.BorderRadius = 20
        StudentID.CustomizableEdges = CustomizableEdges1
        StudentID.DefaultText = ""
        StudentID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        StudentID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        StudentID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        StudentID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        StudentID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        StudentID.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold)
        StudentID.ForeColor = Color.Black
        StudentID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        StudentID.IconLeft = CType(resources.GetObject("StudentID.IconLeft"), Image)
        StudentID.IconLeftOffset = New Point(1, 1)
        StudentID.IconLeftSize = New Size(30, 30)
        StudentID.Location = New Point(91, 99)
        StudentID.MaxLength = 9
        StudentID.Name = "StudentID"
        StudentID.PasswordChar = ChrW(0)
        StudentID.PlaceholderForeColor = Color.Black
        StudentID.PlaceholderText = "Student No."
        StudentID.SelectedText = ""
        StudentID.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        StudentID.Size = New Size(403, 64)
        StudentID.TabIndex = 0
        ' 
        ' Password
        ' 
        Password.BackColor = Color.White
        Password.BorderColor = SystemColors.ActiveCaptionText
        Password.BorderRadius = 20
        Password.CustomizableEdges = CustomizableEdges3
        Password.DefaultText = ""
        Password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Password.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold)
        Password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Password.IconLeft = CType(resources.GetObject("Password.IconLeft"), Image)
        Password.IconLeftOffset = New Point(1, 1)
        Password.IconLeftSize = New Size(30, 30)
        Password.Location = New Point(91, 176)
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.PlaceholderForeColor = Color.Black
        Password.PlaceholderText = "Password:"
        Password.SelectedText = ""
        Password.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Password.Size = New Size(403, 64)
        Password.TabIndex = 1
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.White
        Guna2Button1.BorderColor = SystemColors.ActiveCaptionText
        Guna2Button1.BorderRadius = 15
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges5
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.White
        Guna2Button1.Font = New Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(196, 300)
        Guna2Button1.Margin = New Padding(3, 2, 3, 2)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button1.Size = New Size(197, 62)
        Guna2Button1.TabIndex = 2
        Guna2Button1.Text = "Login"
        ' 
        ' Guna2AnimateWindow1
        ' 
        Guna2AnimateWindow1.Interval = 30
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' Guna2CircleButton1
        ' 
        Guna2CircleButton1.BackColor = Color.Transparent
        Guna2CircleButton1.BackgroundImage = CType(resources.GetObject("Guna2CircleButton1.BackgroundImage"), Image)
        Guna2CircleButton1.Cursor = Cursors.Hand
        Guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton1.FillColor = Color.Gray
        Guna2CircleButton1.Font = New Font("Segoe UI", 9F)
        Guna2CircleButton1.ForeColor = Color.White
        Guna2CircleButton1.Image = CType(resources.GetObject("Guna2CircleButton1.Image"), Image)
        Guna2CircleButton1.ImageSize = New Size(47, 45)
        Guna2CircleButton1.Location = New Point(844, 11)
        Guna2CircleButton1.Margin = New Padding(3, 2, 3, 2)
        Guna2CircleButton1.Name = "Guna2CircleButton1"
        Guna2CircleButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton1.Size = New Size(54, 46)
        Guna2CircleButton1.TabIndex = 22
        ' 
        ' Guna2CheckBox1
        ' 
        Guna2CheckBox1.AutoSize = True
        Guna2CheckBox1.BackColor = Color.White
        Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.CheckedState.BorderRadius = 0
        Guna2CheckBox1.CheckedState.BorderThickness = 0
        Guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.Font = New Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold)
        Guna2CheckBox1.Location = New Point(374, 245)
        Guna2CheckBox1.Margin = New Padding(3, 2, 3, 2)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(120, 20)
        Guna2CheckBox1.TabIndex = 23
        Guna2CheckBox1.Text = "Show Password"
        Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 50
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(Guna2CheckBox1)
        Guna2Panel1.Controls.Add(StudentID)
        Guna2Panel1.Controls.Add(Password)
        Guna2Panel1.Controls.Add(Guna2Button1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.FillColor = Color.White
        Guna2Panel1.Location = New Point(204, 144)
        Guna2Panel1.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        Guna2Panel1.Size = New Size(571, 438)
        Guna2Panel1.TabIndex = 24
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BorderColor = Color.Transparent
        Guna2Panel2.BorderRadius = 20
        Guna2Panel2.Controls.Add(Guna2HtmlLabel1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges7
        Guna2Panel2.FillColor = SystemColors.Control
        Guna2Panel2.Font = New Font("Bahnschrift", 20.25F, FontStyle.Bold)
        Guna2Panel2.Location = New Point(189, 608)
        Guna2Panel2.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel2.Size = New Size(599, 43)
        Guna2Panel2.TabIndex = 24
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Bahnschrift", 20.25F, FontStyle.Bold)
        Guna2HtmlLabel1.Location = New Point(97, 6)
        Guna2HtmlLabel1.Margin = New Padding(3, 2, 3, 2)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(412, 35)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "DEVELOPED BY: Ken, Monica, Kyla"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(213, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 41)
        Label2.TabIndex = 25
        Label2.Text = "SIGN IN"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(942, 739)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2CircleButton1)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents StudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
