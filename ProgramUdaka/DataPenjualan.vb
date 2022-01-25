Public Class DataPenjualan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim penjualan As DataTable

    Sub DGKolom()
        DGdatapenjualan.DataSource = penjualan
        DGdatapenjualan.Columns(0).Width = 130
        DGdatapenjualan.Columns(1).Width = 100
        DGdatapenjualan.Columns(2).Width = 170
        DGdatapenjualan.Columns(3).Width = 120
        DGdatapenjualan.Columns(4).Width = 120
        DGdatapenjualan.Columns(5).Width = 120
        DGdatapenjualan.Columns(6).Width = 100
        DGdatapenjualan.Columns(6).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapenjualan.Columns(7).Width = 50
        DGdatapenjualan.Columns(8).Width = 50
        DGdatapenjualan.Columns(9).Width = 100
        DGdatapenjualan.Columns(9).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapenjualan.Columns(10).Width = 100
        DGdatapenjualan.Columns(10).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapenjualan.Columns(11).Width = 100
    End Sub

    Sub Data_Record()
        penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, penjualan.STATUS_TRANSAKSI, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.PAJAK, penjualan.DISKON, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN ORDER BY penjualan.NO_NOTA DESC")
        Call DGKolom()
    End Sub

    Sub Update_Jatuh_Tempo()
        SQL = "UPDATE penjualan SET STATUS_TRANSAKSI = 'JATUH TEMPO', GRAND_TOTAL = (GRAND_TOTAL * 2), SISA_TAGIHAN = (GRAND_TOTAL - BAYAR) WHERE JATUH_TEMPO < '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND STATUS_TRANSAKSI = 'UTANG'"
        Proses.ExecuteNonQuery(SQL)
    End Sub

    Private Sub DataPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Update_Jatuh_Tempo()
        Call Data_Record()
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged

        If ComboxCari.Text = "No Nota" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, penjualan.STATUS_TRANSAKSI, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.PAJAK, penjualan.DISKON, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.NO_NOTA LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Status Transaksi" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, penjualan.STATUS_TRANSAKSI, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.PAJAK, penjualan.DISKON, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.STATUS_TRANSAKSI LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Jenis Pembayaran" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, penjualan.STATUS_TRANSAKSI, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.PAJAK, penjualan.DISKON, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.JENIS_PEMBAYARAN LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Jatuh Tempo" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, penjualan.STATUS_TRANSAKSI, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.PAJAK, penjualan.DISKON, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.JATUH_TEMPO LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()
        ElseIf ComboxCari.Text = "Nama Pelanggan" Then
            penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, penjualan.STATUS_TRANSAKSI, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.PAJAK, penjualan.DISKON, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE pelanggan.NAMA_PELANGGAN LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()
        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.PAJAK, penjualan.DISKON, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.TGL_TRANSAKSI BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' ORDER BY penjualan.TGL_TRANSAKSI ASC")
        Call DGKolom()
    End Sub

    Private Sub DGdatapenjualan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdatapenjualan.CellClick
        Dim baris As Integer
        With DGdatapenjualan
            baris = .CurrentRow.Index
            TextDetail.Text = .Item(0, baris).Value
        End With
    End Sub

    Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click
        DataPenjualanDetail.TextDetail.Text = TextDetail.Text
        DataPenjualanDetail.Show()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanPenjualan.CRViewPenjualan.ReportSource = "ReportPenjualan.rpt"
        FormLaporanPenjualan.CRViewPenjualan.SelectionFormula = "{penjualan1.TGL_TRANSAKSI}>= #" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "# and {penjualan1.TGL_TRANSAKSI} <= #" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "# AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "' "
        FormLaporanPenjualan.CRViewPenjualan.RefreshReport()
        FormLaporanPenjualan.ShowDialog()
    End Sub

    Private Sub DGdatapenjualan_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGdatapenjualan.CellFormatting
        If DGdatapenjualan.Columns(e.ColumnIndex).Name = "STATUS_TRANSAKSI" Then
            If (Convert.ToString(e.Value) = "JATUH TEMPO") Then
                e.CellStyle.BackColor = Color.LightPink
            End If
        End If
    End Sub
End Class