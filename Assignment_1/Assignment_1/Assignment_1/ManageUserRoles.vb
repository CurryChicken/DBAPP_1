Imports System.Data.SqlClient

Public Class frmManageUserRoles
    Dim strConn As String =
    Configuration.ConfigurationManager.ConnectionStrings("Connection1").ConnectionString
    Dim strConnMaster As String =
    Configuration.ConfigurationManager.ConnectionStrings("dbMaster").ConnectionString
    Private sqlCon As SqlConnection

    Private Sub DisplayUser()
        Try
            sqlCon = New SqlConnection(strConn)
            Dim sqlComm As String = "SELECT * FROM tblUsers"
            Dim adpt As New SqlDataAdapter(sqlComm, sqlCon)
            Dim ds As New DataSet()
            adpt.Fill(ds, "tblUsers")
            cboUser.DataSource = ds.Tables(0)
            cboUser.DisplayMember = "Username"
            cboUser.ValueMember = "UserID"
        Catch
            MessageBox.Show("tblUser has not been created")
        End Try
    End Sub

    Private Sub DisplayRoles()
        sqlCon = New SqlConnection(strConn)
        Dim sqlComm As String = "SELECT * FROM tblRoles"
        Dim adpt As New SqlDataAdapter(sqlComm, sqlCon)
        Dim ds As New DataSet()
        adpt.Fill(ds, "tblRoles")
        cboRole.DataSource = ds.Tables(0)
        cboRole.DisplayMember = "RoleDesc"
        cboRole.ValueMember = "RoleID"
    End Sub


    Private Sub DisplayListBox()
        Try
            sqlCon = New SqlConnection(strConn)
            Dim user As Integer
            user = Integer.Parse(cboUser.SelectedValue)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "uspselectRoles"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("UserID", user)
            Dim adpt As New SqlDataAdapter(sqlComm)
            Dim ds As New DataSet()
            adpt.Fill(ds, "tblRoles")
            lstUserRoles.DataSource = ds.Tables(0)
            lstUserRoles.DisplayMember = "RoleDesc"
        Catch
        End Try
    End Sub


    Private Sub InsertNewUserRole()
        sqlCon = New SqlConnection(strConn)
        Try
            Using (sqlCon)
                Dim sqlComm As New SqlCommand
                Dim role As Integer
                role = Integer.Parse(cboRole.SelectedValue)
                Dim user As Integer
                user = Integer.Parse(cboUser.SelectedValue)
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "INSERT INTO tblUserRoles(RoleID, UserID) VALUES ('" & role & "','" & user & "')"
                sqlComm.CommandType = CommandType.Text
                sqlCon.Open()
                Dim rowAffected As Integer = sqlComm.ExecuteNonQuery()
                If rowAffected > 0 Then
                    MessageBox.Show("Record has been inserted successfully")
                    DisplayListBox()
                End If
                sqlCon.Close()
            End Using
        Catch
            MessageBox.Show("Assigning Role to Users has failed")
        End Try
    End Sub

    Private Sub addUserRole()
        sqlCon = New SqlConnection(strConn)
        Try
            Using (sqlCon)
                Dim sqlComm As New SqlCommand
                Dim rolename = cboRole.Text
                Dim membername = cboUser.Text
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "sp_addrolemember"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("Rolename", rolename)
                sqlComm.Parameters.AddWithValue("Membername", membername)
                sqlCon.Open()
                sqlCon.Close()
                Dim roleAffected As Integer = sqlComm.CommandType.StoredProcedure
                If roleAffected = 4 Then
                    MessageBox.Show("System stored procedures activiated")

                End If
            End Using
        Catch
            MessageBox.Show("Problem occured in adding users roles")
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnToMain1.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub frmManageUserRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUser()
        DisplayRoles()
        DisplayListBox()
    End Sub

    Private Sub lstUserRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUserRoles.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DisplayListBox()
    End Sub

    Private Sub InstUsrRoleBtn_Click(sender As Object, e As EventArgs) Handles btnInsertUserRole.Click
        addUserRole()
        InsertNewUserRole()
    End Sub

    Private Sub cboUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUser.SelectedIndexChanged

    End Sub
End Class