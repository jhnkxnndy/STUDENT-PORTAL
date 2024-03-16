<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteData
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        DataGridView6 = New DataGridView()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(DataGridView6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView6
        ' 
        DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView6.Location = New Point(36, 30)
        DataGridView6.Name = "DataGridView6"
        DataGridView6.RowHeadersWidth = 51
        DataGridView6.Size = New Size(743, 327)
        DataGridView6.TabIndex = 0
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(274, 426)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 1
        Guna2Button1.Text = "Delete"
        ' 
        ' deleteData
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(944, 585)
        Controls.Add(Guna2Button1)
        Controls.Add(DataGridView6)
        FormBorderStyle = FormBorderStyle.None
        Name = "deleteData"
        Text = "deleteData"
        CType(DataGridView6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
