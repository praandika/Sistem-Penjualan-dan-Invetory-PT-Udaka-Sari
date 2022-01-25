Public Class DataTerimaPembayaran
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim penjualan As DataTable

    Sub DGKolom()
        DGdataterima.DataSource = penjualan
        DGdataterima.Columns(0).Width = 100
        DGdataterima.Columns(1).Width = 100
        DGdataterima.Columns(2).Width = 100
        DGdataterima.Columns(3).Width = 100
        DGdataterima.Columns(4).Width = 120
        DGdataterima.Columns(5).Width = 100
        DGdataterima.Columns(5).DefaultCellStyle.Format = "###,###,###,0"
        DGdataterima.Columns(6).Width = 100
        DGdataterima.Columns(6).DefaultCellStyle.Format = "###,###,###,0"
        DGdataterima.Columns(7).Width = 100
        DGdataterima.Columns(7).DefaultCellStyle.Format = "###,###,###,0"
        DGdataterima.Columns(8).Width = 100
        DGdataterima.Columns(9).Width = 100
        DGdataterima.Columns(10).Width = 100
        DGdataterima.Columns(11).Width = 100
    End Sub

    Sub Data_Record()
        penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.STATUS_TRANSAKSI = 'UTANG' ORDER BY penjualan.TGL_TRANSAKSI DESC")
        Call DGKolom()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuRetur)
        Me.Close()
    End Sub

    Private Sub DataTerimaPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If ComboxCari.Text = "Nama Barang" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.STATUS_TRANSAKSI = 'UTANG' AND barang.NAMA_BARANG LIKE '%" & TextCari.Text & "%' ORDER BY penjualan.TGL_TRANSAKSI DESC")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Nama Pelanggan" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.STATUS_TRANSAKSI = 'UTANG' AND pelanggan.NAMA_PELANGGAN LIKE '%" & TextCari.Text & "%' ORDER BY penjualan.TGL_TRANSAKSI DESC")
            Call DGKolom()

        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.STATUS_TRANSAKSI = 'UTANG' AND penjualan.TGL_TRANSAKSI BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' ORDER BY penjualan.TGL_TRANSAKSI DESC")
        Call DGKolom()
    End Sub

    Private Sub DGdataterima_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdataterima.CellClick
        Dim baris As Integer
        With DGdataterima
            baris = .CurrentRow.Index
            TextDetail.Text = .Item(0, baris).Value
        End With
    End Sub
End Class