Imports MySql.Data.MySqlClient
Public Class DataBarangKeluar
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim brgkeluar As DataTable

    Sub Kolom()
        DGBarang.DataSource = brgkeluar
        DGBarang.Columns(0).Width = 150
        DGBarang.Columns(1).Width = 150
        DGBarang.Columns(2).Width = 500
        DGBarang.Columns(3).Width = 100
    End Sub

    Public Sub Data_Record()
        brgkeluar = Proses.ExecuteQuery("SELECT barang_keluar.ID_BARANG_KELUAR, barang_keluar.NOTA_BARANG_KELUAR, pelanggan.NAMA_PELANGGAN, barang_keluar.TOTAL_STOK_KELUAR, barang_keluar.TANGGAL_KELUAR FROM barang_keluar INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = barang_keluar.ID_PELANGGAN ORDER BY barang_keluar.ID_BARANG_KELUAR DESC")
        Call Kolom()
    End Sub

    Private Sub DataBarangMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub DGBarang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBarang.CellClick
        Dim baris As Integer
        With DGBarang
            baris = .CurrentRow.Index
            TextDtl.Text = .Item(1, baris).Value
        End With
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        brgkeluar = Proses.ExecuteQuery("SELECT barang_keluar.ID_BARANG_KELUAR, barang_keluar.NOTA_BARANG_KELUAR, pelanggan.NAMA_PELANGGAN, barang_keluar.TOTAL_STOK_KELUAR, barang_keluar.TANGGAL_KELUAR FROM barang_keluar INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = barang_keluar.ID_PELANGGAN WHERE barang_keluar.TANGGAL_KELUAR BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'")
        Call Kolom()
    End Sub

    Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click
        DataBarangKeluarDetail.TextNota.Text = TextDtl.Text
        DataBarangKeluarDetail.Show()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuBarangMasuk)
        Me.Close()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanBarangKeluar.CRViewBarangKeluar.ReportSource = "ReportBarangKeluar.rpt"
        FormLaporanBarangKeluar.CRViewBarangKeluar.SelectionFormula = "{barang_keluar1.TANGGAL_KELUAR} >= #" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "# and {barang_keluar1.TANGGAL_KELUAR} <= #" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "# AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanBarangKeluar.CRViewBarangKeluar.RefreshReport()
        FormLaporanBarangKeluar.ShowDialog()
    End Sub
End Class