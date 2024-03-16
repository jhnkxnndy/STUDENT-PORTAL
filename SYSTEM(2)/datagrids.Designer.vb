<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datagrids
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
        DataGridView3 = New DataGridView()
        DataGridView4 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView3
        ' 
        DataGridView3.BackgroundColor = SystemColors.ActiveCaption
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.GridColor = SystemColors.ControlText
        DataGridView3.Location = New Point(40, 64)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.Size = New Size(716, 123)
        DataGridView3.TabIndex = 0
        ' 
        ' DataGridView4
        ' 
        DataGridView4.BackgroundColor = SystemColors.ActiveCaption
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.GridColor = SystemColors.ControlText
        DataGridView4.Location = New Point(40, 281)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.RowHeadersWidth = 51
        DataGridView4.Size = New Size(716, 139)
        DataGridView4.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 31)
        Label1.TabIndex = 2
        Label1.Text = "SIGN UP DATA:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(40, 247)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 31)
        Label2.TabIndex = 3
        Label2.Text = "ADMIN DATA:"
        ' 
        ' datagrids
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(825, 544)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView4)
        Controls.Add(DataGridView3)
        FormBorderStyle = FormBorderStyle.None
        Name = "datagrids"
        Text = "datagrids"
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
