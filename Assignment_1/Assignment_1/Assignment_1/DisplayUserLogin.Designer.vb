<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDisplayUserLogin
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
        Me.btnToMain3 = New System.Windows.Forms.Button()
        Me.gvDisplayLogin = New System.Windows.Forms.DataGridView()
        CType(Me.gvDisplayLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnToMain3
        '
        Me.btnToMain3.Location = New System.Drawing.Point(497, 408)
        Me.btnToMain3.Name = "btnToMain3"
        Me.btnToMain3.Size = New System.Drawing.Size(245, 43)
        Me.btnToMain3.TabIndex = 3
        Me.btnToMain3.Text = "Return to Main Menu"
        Me.btnToMain3.UseVisualStyleBackColor = True
        '
        'gvDisplayLogin
        '
        Me.gvDisplayLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDisplayLogin.Location = New System.Drawing.Point(45, 43)
        Me.gvDisplayLogin.Name = "gvDisplayLogin"
        Me.gvDisplayLogin.RowHeadersWidth = 62
        Me.gvDisplayLogin.RowTemplate.Height = 28
        Me.gvDisplayLogin.Size = New System.Drawing.Size(688, 330)
        Me.gvDisplayLogin.TabIndex = 2
        '
        'DisplayUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 488)
        Me.Controls.Add(Me.btnToMain3)
        Me.Controls.Add(Me.gvDisplayLogin)
        Me.Name = "DisplayUserLogin"
        Me.Text = "Display User Login"
        CType(Me.gvDisplayLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnToMain3 As Button
    Friend WithEvents gvDisplayLogin As DataGridView
End Class
