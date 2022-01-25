Imports MySql.Data.MySqlClient
Public Class DataStokOpname
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim stokopname As DataTable

    Sub Kolom()
        DGStokOpname.DataSource = stokopname
        DGStokOpname.Columns(0).Width = 100
        DGStokOpname.Columns(1).Width = 300
        DGStokOpname.Columns(2).Width = 100
        DGStokOpname.Columns(3).Width = 100
        DGStokOpname.Columns(4).Width = 100
        DGStokOpname.Columns(5).Width = 100
        DGStokOpname.Columns(6).Width = 100
        DGStokOpname.Columns(7).Width = 100
        DGStokOpname.Columns(8).Width = 100
    End Sub

    Public Sub Data_Record()
        stokopname = Proses.ExecuteQuery("SELECT stok_opname.ID_STOK_OPNAME, barang.NAMA_BARANG, stok_opname.TGL_STOK_OPNAME, stok_opname.STOK_BRG_OPNAME, stok_opname.JUMLAH_BAIK, stok_opname.JUMLAH_RUSAK, stok_opname.JUMLAH_HILANG, stok_opname.SELISIH, stok_opname.ID_BARANG FROM stok_opname INNER JOIN barang ON barang.ID_BARANG = stok_opname.ID_BARANG ORDER BY ID_STOK_OPNAME DESC")
        Call Kolom()
    End Sub

    Public Sub Data_Record_Cari_Barang()
        stokopname = Proses.ExecuteQuery("SELECT stok_opname.ID_STOK_OPNAME, barang.NAMA_BARANG, stok_opname.TGL_STOK_OPNAME, stok_opname.STOK_BRG_OPNAME, stok_opname.JUMLAH_BAIK, stok_opname.JUMLAH_RUSAK, stok_opname.JUMLAH_HILANG, stok_opname.SELISIH, stok_opname.ID_BARANG FROM stok_opname INNER JOIN barang ON barang.ID_BARANG = stok_opname.ID_BARANG WHERE NAMA_BARANG LIKE '%" & TextCari.Text & "%' ORDER BY ID_BARANG ASC")
        Call Kolom()
    End Sub

    Private Sub DataStokOpname_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub DGStokOpname_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGStokOpname.CellClick
        Dim baris As Integer
        With DGStokOpname
            baris = .CurrentRow.Index
            'TextKodeUbah.Text = .Item(0, baris).Value
        End With
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        TambahStokOpname.Show()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        stokopname = Proses.ExecuteQuery("SELECT stok_opname.ID_STOK_OPNAME, barang.NAMA_BARANG, stok_opname.TGL_STOK_OPNAME, stok_opname.STOK_BRG_OPNAME, stok_opname.JUMLAH_BAIK, stok_opname.JUMLAH_RUSAK, stok_opname.JUMLAH_HILANG, stok_opname.SELISIH, stok_opname.ID_BARANG FROM stok_opname INNER JOIN barang ON barang.ID_BARANG = stok_opname.ID_BARANG WHERE TGL_STOK_OPNAME BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'")
        Call Kolom()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanStokOpname.CRViewStokOpname.ReportSource = "ReportStokOpname.rpt"
        FormLaporanStokOpname.CRViewStokOpname.SelectionFormula = "{stok_opname1.TGL_STOK_OPNAME}>= #" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "# and {stok_opname1.TGL_STOK_OPNAME} <= #" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "# AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanStokOpname.CRViewStokOpname.RefreshReport()
        FormLaporanStokOpname.ShowDialog()
    End Sub
End Class