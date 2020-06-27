Imports System.Data.SqlClient


Public Class frmMainMenu
    Dim strConn As String = Configuration.ConfigurationManager.ConnectionStrings("Connection1").ConnectionString
    Private sqlCon As SqlConnection
    Private Sub CreateUserTable()
        sqlCon = New SqlConnection(strConn)
        Try
            Using (sqlCon)
                Dim sqlComm As New SqlCommand 'Create instance of SqlCommand as sqlComm
                sqlComm.Connection = sqlCon 'get connection from SqlCommand Instance
                sqlComm.CommandText = "uspCreateUsersTable" '
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                MessageBox.Show("tblUser created")
            End Using
        Catch
            MessageBox.Show("Table already created")
        End Try
    End Sub

    Private Sub DropUserTable()
        sqlCon = New SqlConnection(strConn)

        Try

            Using (sqlCon)
                Dim sqlComm As New SqlCommand 'Create instance of SqlCommand as sqlComm
                sqlComm.Connection = sqlCon 'get connection from SqlCommand Instance
                sqlComm.CommandText = "uspDropUsersTable" '
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                MessageBox.Show("tblUser dropped")
            End Using

        Catch
            MessageBox.Show("Table already dropped")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles ManageUserBox.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDisplayUser.Click
        Me.Hide()
        frmDisplayUsers.Show()
    End Sub

    Private Sub TestConBtn_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        Try
            sqlCon = New SqlConnection(strConn)
            sqlCon.Open()
            MessageBox.Show("Connection Successful", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            sqlCon.Close()
        Catch
            MessageBox.Show("Connection Failed")
        End Try

    End Sub

    Private Sub BtnExtAp_Click(sender As Object, e As EventArgs) Handles btnExitApplication.Click
        'button exit here
        Application.Exit()
    End Sub

    Private Sub ManUsrRolBtn_Click(sender As Object, e As EventArgs) Handles btnManageUsersRoles.Click
        Try
            Me.Hide()
            frmManageUserRoles.Show()
        Catch
            MessageBox.Show("Users table not created, Managing User Roles unable to access")
        End Try
    End Sub

    Private Sub ManUsrBtn_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        Me.Hide()
        frmManageUser.Show()
    End Sub

    Private Sub CreUsrTabBtn_Click(sender As Object, e As EventArgs) Handles btnCreateUserTable.Click
        CreateUserTable()
    End Sub

    Private Sub btnDropUserTable_Click(sender As Object, e As EventArgs) Handles btnDropUserTable.Click
        DropUserTable()
    End Sub

    Private Sub btnDisplayLogin_Click(sender As Object, e As EventArgs) Handles btnDisplayLogin.Click
        Me.Hide()
        frmDisplayUserLogin.Show()
    End Sub
End Class
