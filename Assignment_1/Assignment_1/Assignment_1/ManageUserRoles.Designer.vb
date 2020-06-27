<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageUserRoles
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
        Me.UserRolesGroup = New System.Windows.Forms.GroupBox()
        Me.btnInsertUserRole = New System.Windows.Forms.Button()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstUserRoles = New System.Windows.Forms.ListBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnToMain1 = New System.Windows.Forms.Button()
        Me.UserRolesGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserRolesGroup
        '
        Me.UserRolesGroup.Controls.Add(Me.btnInsertUserRole)
        Me.UserRolesGroup.Controls.Add(Me.cboRole)
        Me.UserRolesGroup.Controls.Add(Me.Label2)
        Me.UserRolesGroup.Controls.Add(Me.cboUser)
        Me.UserRolesGroup.Controls.Add(Me.Label1)
        Me.UserRolesGroup.Location = New System.Drawing.Point(23, 27)
        Me.UserRolesGroup.Name = "UserRolesGroup"
        Me.UserRolesGroup.Size = New System.Drawing.Size(766, 136)
        Me.UserRolesGroup.TabIndex = 0
        Me.UserRolesGroup.TabStop = False
        Me.UserRolesGroup.Text = "Assigning Roles to Users"
        '
        'btnInsertUserRole
        '
        Me.btnInsertUserRole.Location = New System.Drawing.Point(578, 25)
        Me.btnInsertUserRole.Name = "btnInsertUserRole"
        Me.btnInsertUserRole.Size = New System.Drawing.Size(148, 85)
        Me.btnInsertUserRole.TabIndex = 4
        Me.btnInsertUserRole.Text = "Insert Users and Roles"
        Me.btnInsertUserRole.UseVisualStyleBackColor = True
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(294, 68)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(251, 28)
        Me.cboRole.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Role :"
        '
        'cboUser
        '
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(25, 68)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(246, 28)
        Me.cboUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select User :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Current Roles for Selected User"
        '
        'lstUserRoles
        '
        Me.lstUserRoles.FormattingEnabled = True
        Me.lstUserRoles.ItemHeight = 20
        Me.lstUserRoles.Location = New System.Drawing.Point(36, 262)
        Me.lstUserRoles.Name = "lstUserRoles"
        Me.lstUserRoles.Size = New System.Drawing.Size(325, 304)
        Me.lstUserRoles.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(389, 512)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(145, 54)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh Listbox"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnToMain1
        '
        Me.btnToMain1.Location = New System.Drawing.Point(553, 512)
        Me.btnToMain1.Name = "btnToMain1"
        Me.btnToMain1.Size = New System.Drawing.Size(196, 54)
        Me.btnToMain1.TabIndex = 4
        Me.btnToMain1.Text = "Return to Main Menu"
        Me.btnToMain1.UseVisualStyleBackColor = True
        '
        'frmManageUserRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 623)
        Me.Controls.Add(Me.btnToMain1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lstUserRoles)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UserRolesGroup)
        Me.Name = "frmManageUserRoles"
        Me.Text = "ManageUserRoles"
        Me.UserRolesGroup.ResumeLayout(False)
        Me.UserRolesGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserRolesGroup As GroupBox
    Friend WithEvents btnInsertUserRole As Button
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboUser As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstUserRoles As ListBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnToMain1 As Button
End Class
