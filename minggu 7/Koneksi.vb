Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System

Public Class Koneksi
    Protected SQL As String
    Public Cn As New MySqlConnection
    Protected cmd As New MySql.Data.MySqlClient.MySqlCommand
    Protected da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Protected ds As New DataSet
    Protected dt As DataTable

    Public Function OpenConn() As Boolean
        Cn = New MySqlConnection("server=localhost;user id=root;password=;database=db_toko_sepatu;")
        Cn.Open()
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub

    Public Function ExecuteQuery(ByVal query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Akses Gagal Broo !!!")
            Return Nothing
            Exit Function
        End If

        cmd = New MySql.Data.MySqlClient.MySqlCommand(query, Cn)
        da = New MySql.Data.MySqlClient.MySqlDataAdapter
        da.SelectCommand = cmd
        ds = New Data.DataSet

        da.Fill(ds)
        dt = ds.Tables(0)

        Return dt
        dt = Nothing
        ds = Nothing
        da = Nothing
        cmd = Nothing

        CloseConn()
    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Akses Gagal Broo !!!") : Exit Sub
        End If
        cmd = New MySql.Data.MySqlClient.MySqlCommand
        cmd.Connection = Cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = Query
        cmd.ExecuteNonQuery()
        cmd = Nothing
        CloseConn()
    End Sub
End Class
