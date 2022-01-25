Imports MySql.Data.MySqlClient
Public Class DaftarJatuhTempo
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public CMD As MySqlCommand
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim jatuhtempo As DataTable
    Dim tanggal As Date = Now
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Sub Data_Record()
        jatuhtempo = Proses.ExecuteQuery("SELECT NO_NOTA, FORMAT(GRAND_TOTAL,0) as GRAND_TOTAL, FORMAT(SISA_TAGIHAN,0) SISA_TAGIHAN, JATUH_TEMPO FROM penjualan WHERE JATUH_TEMPO <= '" & Format(tanggal, "yyyy-MM-dd") & "' AND STATUS_TRANSAKSI = 'UTANG' ORDER BY JATUH_TEMPO ASC")
        DGJatuhTempo.DataSource = jatuhtempo
        DGJatuhTempo.Columns(0).Width = 250
        DGJatuhTempo.Columns(1).Width = 250
        DGJatuhTempo.Columns(1).Width = 250
        DGJatuhTempo.Columns(1).Width = 250
    End Sub

    Private Sub DaftarJatuhTempo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DaftarJatuhTempo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub
End Class