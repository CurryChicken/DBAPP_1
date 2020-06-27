Imports System.Data.SqlClient

Public Class frmDisplayUserLogin
    Dim strConn As String = Configuration.ConfigurationManager.ConnectionStrings("dbMaster").ConnectionString
    Private sqlCon As SqlConnection
    Private cmd As SqlCommand
    Private Sub DisplayUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlCon = New SqlConnection(strConn)
        Dim query As String = "SELECT name FROM master.sys.sql_logins"
        cmd = New SqlCommand(query, sqlCon)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        gvDisplayLogin.DataSource = dt

    End Sub

    Private Sub btnToMain3_Click(sender As Object, e As EventArgs) Handles btnToMain3.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvDisplayLogin.CellContentClick

    End Sub
End Class