Imports MySql.Data.MySqlClient
Public Class DataBarangMasuk
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim brgmasuk As DataTable

    Sub Kolom()
        DGBarang.DataSource = brgmasuk
        DGBarang.Columns(0).Width = 150
        DGBarang.Columns(1).Width = 150
        DGBarang.Columns(2).Width = 500
        DGBarang.Columns(3).Width = 100
    End Sub

    Public Sub Data_Record()
        brgmasuk = Proses.ExecuteQuery("SELECT barang_masuk.ID_BARANG_MASUK, barang_masuk.NOTA_BARANG_MASUK, supplier.NAMA_SUPPLIER, barang_masuk.TOTAL_STOK_MASUK, barang_masuk.TANGGAL_MASUK FROM barang_masuk INNER JOIN supplier ON supplier.ID_SUPPLIER = barang_masuk.ID_SUPPLIER ORDER BY barang_masuk.ID_BARANG_MASUK DESC")
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
        brgmasuk = Proses.ExecuteQuery("SELECT barang_masuk.ID_BARANG_MASUK, barang_masuk.NOTA_BARANG_MASUK, supplier.NAMA_SUPPLIER, barang_masuk.TOTAL_STOK_MASUK, barang_masuk.TANGGAL_MASUK FROM barang_masuk INNER JOIN supplier ON supplier.ID_SUPPLIER = barang_masuk.ID_SUPPLIER WHERE barang_masuk.TANGGAL_MASUK BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'")
        Call Kolom()
    End Sub

    Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click
        DataBarangMasukDetail.TextNota.Text = TextDtl.Text
        DataBarangMasukDetail.Show()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuBarangMasuk)
        Me.Close()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanBarangMasuk.CRViewBarangMasuk.ReportSource = "ReportBarangMasuk.rpt"
        FormLaporanBarangMasuk.CRViewBarangMasuk.SelectionFormula = "{barang_masuk1.TANGGAL_MASUK} >= #" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "# and {barang_masuk1.TANGGAL_MASUK} <= #" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "# AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanBarangMasuk.CRViewBarangMasuk.RefreshReport()
        FormLaporanBarangMasuk.ShowDialog()
    End Sub
End Class