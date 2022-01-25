Imports MySql.Data.MySqlClient
Public Class DataBarangMasukDetail
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public CMD As MySqlCommand
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim brgmasukdetail As DataTable
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
        brgmasukdetail = Proses.ExecuteQuery("SELECT barang_masuk_detail.ID_BARANG, barang.NAMA_BARANG, STOK_MASUK FROM barang_masuk_detail INNER JOIN barang ON barang.ID_BARANG = barang_masuk_detail.ID_BARANG WHERE NOTA_BARANG_MASUK = '" & TextNota.Text & "'")
        DGBrgMskDetail.DataSource = brgmasukdetail
        DGBrgMskDetail.Columns(0).Width = 100
        DGBrgMskDetail.Columns(1).Width = 400
        DGBrgMskDetail.Columns(2).Width = 100
    End Sub

    Sub Data_Text()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT barang_masuk.TOTAL_STOK_MASUK, barang_masuk.TANGGAL_MASUK, supplier.NAMA_SUPPLIER FROM barang_masuk INNER JOIN supplier ON supplier.ID_SUPPLIER = barang_masuk.ID_SUPPLIER WHERE barang_masuk.NOTA_BARANG_MASUK = '" & TextNota.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextTgl.Text = RD("TANGGAL_MASUK")
            TextStok.Text = RD("TOTAL_STOK_MASUK")
            TexSup.Text = RD("NAMA_SUPPLIER")
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
        FormLaporanBarangMasukDetail.CRViewBarangMasuk.ReportSource = "ReportBarangMasukDetail.rpt"
        FormLaporanBarangMasukDetail.CRViewBarangMasuk.SelectionFormula = "{barang_masuk1.NOTA_BARANG_MASUK} = '" + TextNota.Text + "' AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanBarangMasukDetail.CRViewBarangMasuk.RefreshReport()
        FormLaporanBarangMasukDetail.ShowDialog()
    End Sub
End Class