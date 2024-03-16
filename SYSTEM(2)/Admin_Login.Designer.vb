<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Login))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        txtAdminPass = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label2 = New Label()
        Label10 = New Label()
        Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), Image)
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(234, -12)
        Guna2CirclePictureBox1.Margin = New Padding(3, 2, 3, 2)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(177, 147)
        Guna2CirclePictureBox1.TabIndex = 27
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' txtAdminPass
        ' 
        txtAdminPass.BackColor = Color.White
        txtAdminPass.BorderColor = SystemColors.ActiveCaptionText
        txtAdminPass.BorderRadius = 10
        txtAdminPass.CustomizableEdges = CustomizableEdges2
        txtAdminPass.DefaultText = ""
        txtAdminPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtAdminPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtAdminPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtAdminPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtAdminPass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtAdminPass.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        txtAdminPass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtAdminPass.IconLeft = CType(resources.GetObject("txtAdminPass.IconLeft"), Image)
        txtAdminPass.IconLeftOffset = New Point(1, 1)
        txtAdminPass.IconLeftSize = New Size(30, 30)
        txtAdminPass.Location = New Point(72, 158)
        txtAdminPass.Name = "txtAdminPass"
        txtAdminPass.PasswordChar = "*"c
        txtAdminPass.PlaceholderForeColor = Color.Black
        txtAdminPass.PlaceholderText = "Password:"
        txtAdminPass.SelectedText = ""
        txtAdminPass.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        txtAdminPass.Size = New Size(376, 34)
        txtAdminPass.TabIndex = 1
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.White
        Guna2Button1.BorderRadius = 15
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges4
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(168, 253)
        Guna2Button1.Margin = New Padding(3, 2, 3, 2)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2Button1.Size = New Size(197, 42)
        Guna2Button1.TabIndex = 25
        Guna2Button1.Text = "Login"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderColor = SystemColors.ActiveCaptionText
        txtUsername.BorderRadius = 10
        txtUsername.CustomizableEdges = CustomizableEdges6
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        txtUsername.ForeColor = Color.Black
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.IconLeft = CType(resources.GetObject("txtUsername.IconLeft"), Image)
        txtUsername.IconLeftOffset = New Point(1, 1)
        txtUsername.IconLeftSize = New Size(30, 30)
        txtUsername.Location = New Point(72, 98)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PlaceholderForeColor = Color.Black
        txtUsername.PlaceholderText = "Username:"
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        txtUsername.Size = New Size(376, 34)
        txtUsername.TabIndex = 0
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BackColor = Color.White
        Guna2Button2.BorderRadius = 15
        Guna2Button2.BorderThickness = 1
        Guna2Button2.CustomizableEdges = CustomizableEdges8
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Transparent
        Guna2Button2.Font = New Font("Segoe UI Variable Small Semibol", 10.8F, FontStyle.Bold)
        Guna2Button2.ForeColor = Color.Black
        Guna2Button2.Location = New Point(168, 312)
        Guna2Button2.Margin = New Padding(3, 2, 3, 2)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        Guna2Button2.Size = New Size(197, 42)
        Guna2Button2.TabIndex = 26
        Guna2Button2.Text = "Student Login"
        ' 
        ' Guna2CheckBox1
        ' 
        Guna2CheckBox1.AutoSize = True
        Guna2CheckBox1.BackColor = Color.White
        Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.CheckedState.BorderRadius = 0
        Guna2CheckBox1.CheckedState.BorderThickness = 0
        Guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.Location = New Point(332, 197)
        Guna2CheckBox1.Margin = New Padding(3, 2, 3, 2)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(108, 19)
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
        Guna2Panel1.Controls.Add(Guna2Button2)
        Guna2Panel1.Controls.Add(txtUsername)
        Guna2Panel1.Controls.Add(Guna2Button1)
        Guna2Panel1.Controls.Add(txtAdminPass)
        Guna2Panel1.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.FillColor = Color.White
        Guna2Panel1.Location = New Point(77, 160)
        Guna2Panel1.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        Guna2Panel1.Size = New Size(534, 373)
        Guna2Panel1.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(157, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(199, 32)
        Label2.TabIndex = 27
        Label2.Text = "ADMIN LOGIN"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.Control
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(108, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 15)
        Label10.TabIndex = 31
        Label10.Text = "GO BACK"
        ' 
        ' Guna2CircleButton1
        ' 
        Guna2CircleButton1.BackColor = Color.Transparent
        Guna2CircleButton1.BackgroundImage = My.Resources.Resources.go_back_2
        Guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton1.FillColor = Color.Transparent
        Guna2CircleButton1.Font = New Font("Segoe UI", 9F)
        Guna2CircleButton1.ForeColor = Color.White
        Guna2CircleButton1.Image = My.Resources.Resources.go_back_2
        Guna2CircleButton1.ImageSize = New Size(54, 51)
        Guna2CircleButton1.Location = New Point(54, 11)
        Guna2CircleButton1.Margin = New Padding(3, 2, 3, 2)
        Guna2CircleButton1.Name = "Guna2CircleButton1"
        Guna2CircleButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton1.Size = New Size(49, 37)
        Guna2CircleButton1.TabIndex = 30
        ' 
        ' Admin_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(648, 553)
        Controls.Add(Label10)
        Controls.Add(Guna2CirclePictureBox1)
        Controls.Add(Guna2CircleButton1)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Admin_Login"
        Text = "Admin_Login"
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtAdminPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
End Class
