Imports System.Data.SqlClient

Public Class frmDisplayUsers
    Dim strConn As String = Configuration.ConfigurationManager.ConnectionStrings("Connection1").ConnectionString
    Private sqlCon As SqlConnection
    Private cmd As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnToMain3.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvDisplayUser.CellContentClick


    End Sub

    Private Sub frmDisplayUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sqlCon = New SqlConnection(strConn)
            Dim query As String = "SELECT * FROM tblUsers"
            cmd = New SqlCommand(query, sqlCon)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            gvDisplayUser.DataSource = dt

        Catch
            MessageBox.Show("tblUser not created, create tblUser in the Main Menu")
        End Try


    End Sub
End Class