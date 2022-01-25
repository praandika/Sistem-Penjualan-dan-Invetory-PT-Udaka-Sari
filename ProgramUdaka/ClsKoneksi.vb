Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class ClsKoneksi
    Protected SQL As String
    Protected Cn As New MySqlConnection
    Public Cmd As New MySql.Data.MySqlClient.MySqlCommand
    Public Rd As MySqlDataReader
    Protected Da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Protected Ds As New DataSet
    Protected Dt As DataTable

    Public Function OpenConn() As Boolean
        Cn = New MySqlConnection("server=localhost;" _
       & "user id=root;" _
       & "password=;" _
       & "database=udakasari;" _
       & "Convert Zero Datetime=True")
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

    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If

        Cmd = New MySql.Data.MySqlClient.MySqlCommand(Query, Cn)
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter
        Da.SelectCommand = Cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Ds.Tables(0)
        Return Dt
        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing
        CloseConn()
    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal", MsgBoxStyle.Critical, "Access Failed")
            Exit Sub
        End If
        Cmd = New MySql.Data.MySqlClient.MySqlCommand
        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub
End Class
