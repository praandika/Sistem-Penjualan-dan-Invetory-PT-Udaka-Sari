Imports MySql.Data.MySqlClient
Public Class DaftarStokMinimal
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public CMD As MySqlCommand
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim stokminimal As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Sub Data_Record()
        stokminimal = Proses.ExecuteQuery("SELECT NAMA_BARANG, STOK_BARANG FROM barang WHERE STOK_BARANG <= STOK_MIN ORDER BY NAMA_BARANG ASC")
        DGStokMinimal.DataSource = stokminimal
        DGStokMinimal.Columns(0).Width = 600
        DGStokMinimal.Columns(1).Width = 100
    End Sub

    Private Sub DaftarStokMinimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DaftarStokMinimal_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub
End Class