<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayUsers
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
        Me.gvDisplayUser = New System.Windows.Forms.DataGridView()
        Me.btnToMain3 = New System.Windows.Forms.Button()
        CType(Me.gvDisplayUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvDisplayUser
        '
        Me.gvDisplayUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDisplayUser.Location = New System.Drawing.Point(22, 52)
        Me.gvDisplayUser.Name = "gvDisplayUser"
        Me.gvDisplayUser.RowHeadersWidth = 62
        Me.gvDisplayUser.RowTemplate.Height = 28
        Me.gvDisplayUser.Size = New System.Drawing.Size(688, 330)
        Me.gvDisplayUser.TabIndex = 0
        '
        'btnToMain3
        '
        Me.btnToMain3.Location = New System.Drawing.Point(464, 420)
        Me.btnToMain3.Name = "btnToMain3"
        Me.btnToMain3.Size = New System.Drawing.Size(245, 43)
        Me.btnToMain3.TabIndex = 1
        Me.btnToMain3.Text = "Return to Main Menu"
        Me.btnToMain3.UseVisualStyleBackColor = True
        '
        'frmDisplayUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 490)
        Me.Controls.Add(Me.btnToMain3)
        Me.Controls.Add(Me.gvDisplayUser)
        Me.Name = "frmDisplayUsers"
        Me.Text = "View contents of tblUser"
        CType(Me.gvDisplayUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gvDisplayUser As DataGridView
    Friend WithEvents btnToMain3 As Button
End Class
