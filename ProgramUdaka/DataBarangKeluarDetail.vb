Imports MySql.Data.MySqlClient
Public Class DataBarangKeluarDetail
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public CMD As MySqlCommand
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim brgkeluardetail As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Sub Koneksi()
        Try
            Dim SQL As String = "server=localhost;user id=root;password=;database=udakasari"
            Conn = New MySqlConnection(SQL)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Data_Record()
        brgkeluardetail = Proses.ExecuteQuery("SELECT barang_keluar_detail.ID_BARANG, barang.NAMA_BARANG, STOK_KELUAR FROM barang_keluar_detail INNER JOIN barang ON barang.ID_BARANG = barang_keluar_detail.ID_BARANG WHERE NOTA_BARANG_KELUAR = '" & TextNota.Text & "'")
        DGBrgMskDetail.DataSource = brgkeluardetail
        DGBrgMskDetail.Columns(0).Width = 100
        DGBrgMskDetail.Columns(1).Width = 400
        DGBrgMskDetail.Columns(2).Width = 100
    End Sub

    Sub Data_Text()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT barang_keluar.TOTAL_STOK_KELUAR, barang_keluar.TANGGAL_KELUAR, pelanggan.NAMA_PELANGGAN FROM barang_keluar INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = barang_keluar.ID_PELANGGAN WHERE barang_keluar.NOTA_BARANG_KELUAR = '" & TextNota.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextTgl.Text = RD("TANGGAL_KELUAR")
            TextStok.Text = RD("TOTAL_STOK_KELUAR")
            TexSup.Text = RD("NAMA_PELANGGAN")
        End If
        Conn.Close()
    End Sub

    Private Sub DataBarangMasukDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        Call Data_Text()
        TextNota.Enabled = False
        TextTgl.Enabled = False
        TextStok.Enabled = False
    End Sub

    Private Sub DataBarangMasukDetail_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanBarangKeluarDetail.CRViewBarangKeluarDetail.ReportSource = "ReportBarangKeluarDetail.rpt"
        FormLaporanBarangKeluarDetail.CRViewBarangKeluarDetail.SelectionFormula = "{barang_keluar1.NOTA_BARANG_KELUAR} = '" + TextNota.Text + "' AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanBarangKeluarDetail.CRViewBarangKeluarDetail.RefreshReport()
        FormLaporanBarangKeluarDetail.ShowDialog()
    End Sub
End Class