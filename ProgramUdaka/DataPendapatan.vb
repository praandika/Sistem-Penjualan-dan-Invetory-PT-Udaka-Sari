Imports MySql.Data.MySqlClient
Public Class DataPendapatan
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pendapatan As DataTable

    Sub Kolom()
        DGPendapatan.DataSource = pendapatan
        DGPendapatan.Columns(0).Width = 80
        DGPendapatan.Columns(1).Width = 305
        DGPendapatan.Columns(2).Width = 100
        DGPendapatan.Columns(3).Width = 100
        DGPendapatan.Columns(4).Width = 100
        DGPendapatan.Columns(5).Width = 135
        DGPendapatan.Columns(6).Width = 115
        DGPendapatan.Columns(7).Width = 120
    End Sub

    Public Sub Data_Record()
        pendapatan = Proses.ExecuteQuery("SELECT transaksi.ID_BARANG, barang.NAMA_BARANG, FORMAT(barang.HARGA_BELI,0) AS HARGA_BELI, FORMAT(barang.HARGA_JUAL,0) AS HARGA_JUAL, SUM(transaksi.QTY) AS JUMLAH_TERJUAL, FORMAT((barang.HARGA_JUAL-barang.HARGA_BELI),0) AS UNTUNG_PER_BARANG, FORMAT((barang.HARGA_JUAL*SUM(transaksi.QTY)),0) AS PENDAPATAN_KOTOR, FORMAT(((barang.HARGA_JUAL-barang.HARGA_BELI)*(SUM(transaksi.QTY))),0) AS PENDAPATAN_BERSIH FROM transaksi INNER JOIN barang ON transaksi.ID_BARANG = barang.ID_BARANG GROUP BY transaksi.ID_BARANG")
        Call Kolom()
    End Sub

    Private Sub DataPendapatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        pendapatan = Proses.ExecuteQuery("SELECT transaksi.ID_BARANG, barang.NAMA_BARANG, FORMAT(barang.HARGA_BELI,0) AS HARGA_BELI, FORMAT(barang.HARGA_JUAL,0) AS HARGA_JUAL, SUM(transaksi.QTY) AS JUMLAH_TERJUAL, FORMAT((barang.HARGA_JUAL-barang.HARGA_BELI),0) AS UNTUNG_PER_BARANG, FORMAT((barang.HARGA_JUAL*SUM(transaksi.QTY)),0) AS PENDAPATAN_KOTOR, FORMAT(((barang.HARGA_JUAL-barang.HARGA_BELI)*(SUM(transaksi.QTY))),0) AS PENDAPATAN_BERSIH FROM transaksi INNER JOIN barang ON transaksi.ID_BARANG = barang.ID_BARANG WHERE transaksi.TGL_TRANSAKSI BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' GROUP BY transaksi.ID_BARANG")
        Call Kolom()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanPendapatan.CRViewPendapatan.ReportSource = "ReportPendapatan.rpt"
        FormLaporanPendapatan.CRViewPendapatan.SelectionFormula = "{transaksi1.TGL_TRANSAKSI}>= #" + Format(DateTimePicker1.Value, "yyyy-MM-dd") + "# AND {transaksi1.TGL_TRANSAKSI} <= #" + Format(DateTimePicker2.Value, "yyyy-MM-dd") + "# AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "' "
        FormLaporanPendapatan.CRViewPendapatan.RefreshReport()
        FormLaporanPendapatan.ShowDialog()
    End Sub
End Class