Public Class DaftarReturPenjualan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim penjualan As DataTable

    Sub DGKolom()
        DGdatapenjualan.DataSource = penjualan
        DGdatapenjualan.Columns(0).Width = 100
        DGdatapenjualan.Columns(1).Width = 100
        DGdatapenjualan.Columns(2).Width = 100
        DGdatapenjualan.Columns(3).Width = 100
        DGdatapenjualan.Columns(4).Width = 120
        DGdatapenjualan.Columns(5).Width = 100
        DGdatapenjualan.Columns(5).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapenjualan.Columns(6).Width = 100
        DGdatapenjualan.Columns(6).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapenjualan.Columns(7).Width = 100
        DGdatapenjualan.Columns(7).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapenjualan.Columns(8).Width = 100
        DGdatapenjualan.Columns(9).Width = 100
        DGdatapenjualan.Columns(10).Width = 100
        DGdatapenjualan.Columns(11).Width = 100
    End Sub

    Sub Data_Record()
        penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.STATUS_TRANSAKSI ='LUNAS' ORDER BY penjualan.TGL_TRANSAKSI DESC")
        Call DGKolom()
    End Sub

    Private Sub DaftarReturPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextKodePenjualan.Visible = False
        TextKodePel.Visible = False
        TextTotal.Visible = False
        TextBayar.Visible = False
        TextSisa.Visible = False
        Call Data_Record()
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If ComboxCari.Text = "No Nota" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.NO_NOTA LIKE '%" & TextCari.Text & "%' AND penjualan.STATUS_TRANSAKSI ='LUNAS'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Status Transaksi" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.STATUS_TRANSAKSI LIKE '%" & TextCari.Text & "%' AND penjualan.STATUS_TRANSAKSI ='LUNAS'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Jenis Pembayaran" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.JENIS_PEMBAYARAN LIKE '%" & TextCari.Text & "%' AND penjualan.STATUS_TRANSAKSI ='LUNAS'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Jatuh Tempo" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.JATUH_TEMPO LIKE '%" & TextCari.Text & "%' AND penjualan.STATUS_TRANSAKSI ='LUNAS'")
            Call DGKolom()
        ElseIf ComboxCari.Text = "Nama Pelanggan" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE pelanggan.NAMA_PELANGGAN LIKE '%" & TextCari.Text & "%' AND penjualan.STATUS_TRANSAKSI ='LUNAS'")
            Call DGKolom()
        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.TGL_TRANSAKSI BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' AND penjualan.STATUS_TRANSAKSI ='LUNAS'")
        Call DGKolom()
    End Sub

    Private Sub DGdatapenjualan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdatapenjualan.CellClick
        Dim baris As Integer
        With DGdatapenjualan
            baris = .CurrentRow.Index
            TextDetail.Text = .Item(0, baris).Value
            TextKodePenjualan.Text = .Item(10, baris).Value
            TextKodePel.Text = .Item(11, baris).Value
            TextTotal.Text = .Item(5, baris).Value
            TextBayar.Text = .Item(6, baris).Value
            TextSisa.Text = .Item(7, baris).Value
        End With
    End Sub

    Private Sub BtnRetur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetur.Click
        ReturPenjualan.LabelNota.Text = TextDetail.Text
        ReturPenjualan.TextKodePenjualan.Text = TextKodePenjualan.Text
        ReturPenjualan.TextKodePel.Text = TextKodePel.Text
        ReturPenjualan.TextTotal.Text = TextTotal.Text
        ReturPenjualan.TextBayar.Text = TextBayar.Text
        ReturPenjualan.TextSisa.Text = TextSisa.Text
        ReturPenjualan.Show()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuRetur)
        Me.Close()
    End Sub
End Class