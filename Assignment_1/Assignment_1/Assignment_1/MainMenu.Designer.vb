<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ManageUserBox = New System.Windows.Forms.GroupBox()
        Me.btnManageUsersRoles = New System.Windows.Forms.Button()
        Me.btnDisplayUser = New System.Windows.Forms.Button()
        Me.btnManageUser = New System.Windows.Forms.Button()
        Me.MaintainTableBox = New System.Windows.Forms.GroupBox()
        Me.btnDropUserTable = New System.Windows.Forms.Button()
        Me.btnCreateUserTable = New System.Windows.Forms.Button()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.btnExitApplication = New System.Windows.Forms.Button()
        Me.btnDisplayLogin = New System.Windows.Forms.Button()
        Me.ManageUserBox.SuspendLayout()
        Me.MaintainTableBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Menu for Application to Administer a Database"
        '
        'ManageUserBox
        '
        Me.ManageUserBox.Controls.Add(Me.btnDisplayLogin)
        Me.ManageUserBox.Controls.Add(Me.btnManageUsersRoles)
        Me.ManageUserBox.Controls.Add(Me.btnDisplayUser)
        Me.ManageUserBox.Controls.Add(Me.btnManageUser)
        Me.ManageUserBox.Location = New System.Drawing.Point(46, 85)
        Me.ManageUserBox.Name = "ManageUserBox"
        Me.ManageUserBox.Size = New System.Drawing.Size(239, 279)
        Me.ManageUserBox.TabIndex = 1
        Me.ManageUserBox.TabStop = False
        Me.ManageUserBox.Text = "Manage Users"
        '
        'btnManageUsersRoles
        '
        Me.btnManageUsersRoles.Location = New System.Drawing.Point(24, 107)
        Me.btnManageUsersRoles.Name = "btnManageUsersRoles"
        Me.btnManageUsersRoles.Size = New System.Drawing.Size(171, 35)
        Me.btnManageUsersRoles.TabIndex = 2
        Me.btnManageUsersRoles.Text = "Manage Users Roles"
        Me.btnManageUsersRoles.UseVisualStyleBackColor = True
        '
        'btnDisplayUser
        '
        Me.btnDisplayUser.Location = New System.Drawing.Point(24, 163)
        Me.btnDisplayUser.Name = "btnDisplayUser"
        Me.btnDisplayUser.Size = New System.Drawing.Size(171, 35)
        Me.btnDisplayUser.TabIndex = 1
        Me.btnDisplayUser.Text = "Display User"
        Me.btnDisplayUser.UseVisualStyleBackColor = True
        '
        'btnManageUser
        '
        Me.btnManageUser.Location = New System.Drawing.Point(24, 48)
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.Size = New System.Drawing.Size(171, 35)
        Me.btnManageUser.TabIndex = 0
        Me.btnManageUser.Text = "Manage Users"
        Me.btnManageUser.UseVisualStyleBackColor = True
        '
        'MaintainTableBox
        '
        Me.MaintainTableBox.Controls.Add(Me.btnDropUserTable)
        Me.MaintainTableBox.Controls.Add(Me.btnCreateUserTable)
        Me.MaintainTableBox.Location = New System.Drawing.Point(484, 85)
        Me.MaintainTableBox.Name = "MaintainTableBox"
        Me.MaintainTableBox.Size = New System.Drawing.Size(239, 279)
        Me.MaintainTableBox.TabIndex = 2
        Me.MaintainTableBox.TabStop = False
        Me.MaintainTableBox.Text = "Maintain Tables"
        '
        'btnDropUserTable
        '
        Me.btnDropUserTable.Location = New System.Drawing.Point(34, 107)
        Me.btnDropUserTable.Name = "btnDropUserTable"
        Me.btnDropUserTable.Size = New System.Drawing.Size(171, 35)
        Me.btnDropUserTable.TabIndex = 4
        Me.btnDropUserTable.Text = "Drop Users Table"
        Me.btnDropUserTable.UseVisualStyleBackColor = True
        '
        'btnCreateUserTable
        '
        Me.btnCreateUserTable.Location = New System.Drawing.Point(34, 48)
        Me.btnCreateUserTable.Name = "btnCreateUserTable"
        Me.btnCreateUserTable.Size = New System.Drawing.Size(171, 35)
        Me.btnCreateUserTable.TabIndex = 3
        Me.btnCreateUserTable.Text = "Create Users Table"
        Me.btnCreateUserTable.UseVisualStyleBackColor = True
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Location = New System.Drawing.Point(70, 390)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(171, 65)
        Me.btnTestConnection.TabIndex = 3
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'btnExitApplication
        '
        Me.btnExitApplication.Location = New System.Drawing.Point(518, 390)
        Me.btnExitApplication.Name = "btnExitApplication"
        Me.btnExitApplication.Size = New System.Drawing.Size(171, 65)
        Me.btnExitApplication.TabIndex = 3
        Me.btnExitApplication.Text = "Exit Application"
        Me.btnExitApplication.UseVisualStyleBackColor = True
        '
        'btnDisplayLogin
        '
        Me.btnDisplayLogin.Location = New System.Drawing.Point(24, 218)
        Me.btnDisplayLogin.Name = "btnDisplayLogin"
        Me.btnDisplayLogin.Size = New System.Drawing.Size(171, 35)
        Me.btnDisplayLogin.TabIndex = 3
        Me.btnDisplayLogin.Text = "Display User Login"
        Me.btnDisplayLogin.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 496)
        Me.Controls.Add(Me.btnExitApplication)
        Me.Controls.Add(Me.btnTestConnection)
        Me.Controls.Add(Me.MaintainTableBox)
        Me.Controls.Add(Me.ManageUserBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMainMenu"
        Me.Text = "Application to Manage a Database"
        Me.ManageUserBox.ResumeLayout(False)
        Me.MaintainTableBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ManageUserBox As GroupBox
    Friend WithEvents btnManageUsersRoles As Button
    Friend WithEvents btnDisplayUser As Button
    Friend WithEvents btnManageUser As Button
    Friend WithEvents MaintainTableBox As GroupBox
    Friend WithEvents btnDropUserTable As Button
    Friend WithEvents btnCreateUserTable As Button
    Friend WithEvents btnTestConnection As Button
    Friend WithEvents btnExitApplication As Button
    Friend WithEvents btnDisplayLogin As Button
End Class
