Imports System.Data.SqlClient

Public Class frmManageUser
    Dim strConn As String = Configuration.ConfigurationManager.ConnectionStrings("Connection1").ConnectionString
    Dim strConnMaster As String = Configuration.ConfigurationManager.ConnectionStrings("dbMaster").ConnectionString
    Private sqlCon As SqlConnection

    Private Sub LoadData()
        Dim strQuery As String
        strQuery = "SELECT * FROM tblUsers"
        sqlCon = New SqlConnection(strConn)
        Using (sqlCon)
            Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
            sqlCon.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()

            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    txtFirstName.Text = sqlReader.GetString(1)
                    txtLastName.Text = sqlReader.GetString(2)
                    txtAge.Text = sqlReader.GetValue(3)
                    txtUserName.Text = sqlReader.GetString(4)
                    txtPassword.Text = sqlReader.GetString(5)
                End While
            End If
            sqlReader.Close()
        End Using
    End Sub

    Private Sub AddLogin()
        sqlCon = New SqlConnection(strConnMaster)
        Dim username As String = ""
        Dim password As String = ""
        username = txtUserName.Text
        password = txtPassword.Text
        Dim msg As String
        msg = "CREATE LOGIN " & username & " WITH PASSWORD = " & "'" & password & "'" & vbNewLine & "CREATE USER " & username & " FROM LOGIN " & username
        MessageBox.Show(msg)
        Try
            Using (sqlCon)
                Dim sqlComm As New SqlCommand
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "CREATE LOGIN " & username & " WITH PASSWORD = " & "'" & password & "'"
                sqlComm.CommandType = CommandType.Text
                sqlCon.Open()
                Dim rowsAffected As Integer = sqlComm.ExecuteNonQuery()
                If rowsAffected = -1 Then 'sqlComm.ExecuteNonQuery() return -1 if subroutinue works proper.
                    MessageBox.Show("Login has been created successsfully")
                End If
                sqlCon.Close()
            End Using
        Catch
            MessageBox.Show("Login creation has failed")
        End Try
    End Sub


    Private Sub AddUser()
        sqlCon = New SqlConnection(strConn)
        Dim username As String = ""
        username = txtUserName.Text
        Dim msg As String = ""
        msg = "CREATING USER " & username
        MessageBox.Show(msg)

        Using (sqlCon)
            Try
                Dim sqlComm As New SqlCommand
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "CREATE USER " & username & " FROM LOGIN " & username
                sqlComm.CommandType = CommandType.Text
                sqlCon.Open()
                Dim rowsAffected As Integer = sqlComm.ExecuteNonQuery()
                If rowsAffected = -1 Then 'sqlComm.ExecuteNonQuery() return -1 if subroutinue works proper.
                    MessageBox.Show("User records has been inserted successfully")
                End If
                sqlCon.Close()
            Catch
                MessageBox.Show("User records has not been inserted")
            End Try
        End Using
    End Sub

    Private Sub InsertNewRecord()
        sqlCon = New SqlConnection(strConn)
        Try
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "uspInsertUserData"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("FirstName", txtFirstName.Text)
                sqlComm.Parameters.AddWithValue("LastName", txtLastName.Text)
                sqlComm.Parameters.AddWithValue("Age", Integer.Parse(txtAge.Text))
                sqlComm.Parameters.AddWithValue("UserName", txtUserName.Text)
                sqlComm.Parameters.AddWithValue("Password", txtPassword.Text)
                sqlCon.Open()


                Dim insertAffected As Integer = sqlComm.ExecuteNonQuery()
                If insertAffected > 0 Then
                    MessageBox.Show("Records has been inserted successfully")
                End If

            End Using
            LoadData()
        Catch
            MessageBox.Show("Insertion into databases has failed")
        End Try
    End Sub

    Private Sub UpdateRecord()
        sqlCon = New SqlConnection(strConn)

        Try

            Using (sqlCon)
                Dim sqlComm As New SqlCommand

                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "uspUpdateUserData"
                sqlComm.CommandType = CommandType.StoredProcedure

                sqlComm.Parameters.AddWithValue("UserID", txtSearchID.Text)
                sqlComm.Parameters.AddWithValue("FirstName", txtFirstName.Text)
                sqlComm.Parameters.AddWithValue("LastName", txtLastName.Text)
                sqlComm.Parameters.AddWithValue("Age", Integer.Parse(txtAge.Text))
                sqlComm.Parameters.AddWithValue("UserName", txtUserName.Text)
                sqlComm.Parameters.AddWithValue("Password", txtPassword.Text)
                sqlCon.Open()

                Dim rowsAffected As Integer = sqlComm.ExecuteNonQuery()
                If rowsAffected > 0 Then 'sqlComm.ExecuteNonQuery() returns 1 when subroutinue works proper.
                    MessageBox.Show("Record has been updated successfully")
                End If
            End Using
            LoadData()
        Catch
            MessageBox.Show("No User Data Updated")
        End Try
    End Sub

    Private Sub DeleteRecord()
        sqlCon = New SqlConnection(strConn)
        Try
            Using (sqlCon)
                Dim sqlComm As New SqlCommand
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "uspDeleteUserData"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("UserID", Integer.Parse(txtSearchID.Text))
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                Dim msg As String = ""
                msg = "UserID " + txtSearchID.Text + " has been deleted"
                MessageBox.Show(msg)

            End Using
            LoadData()
        Catch
            MessageBox.Show("No User Data deleted")
        End Try
    End Sub

    '=========================================================== interface objects =====================================================================================
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        AddLogin()
        AddUser()
        InsertNewRecord()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnToMain2_Click(sender As Object, e As EventArgs) Handles btnToMain2.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub frmManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlCon = New SqlConnection(strConn)
        Try
            Using (sqlCon)

                Dim sqlComm As New SqlCommand
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "SELECT * FROM tblUsers WHERE UserID = " & Integer.Parse(txtSearchID.Text)
                sqlComm.CommandType = CommandType.Text
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        txtFirstName.Text = sqlReader.GetString(1)
                        txtLastName.Text = sqlReader.GetString(2)
                        txtAge.Text = sqlReader.GetValue(3)
                        txtUserName.Text = sqlReader.GetString(4)
                        txtPassword.Text = sqlReader.GetString(5)
                    End While
                End If

                Dim HasRow As Integer = sqlReader.HasRows
                If HasRow > -1 Then
                    MessageBox.Show("UserID not found")
                End If

                sqlReader.Close()
            End Using
        Catch
            MessageBox.Show("UserID not found")
        End Try

    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateRecord()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteRecord()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class