Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Collections
Public Class Stats
    Dim Proses As New ClsKoneksi
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim tanggal As Date = Today
    Dim akhir, awal, x As Long
    Dim hasil As Integer
    Dim persen As Double
    Dim y As Integer = 0

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

    Sub Notif()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT COUNT(NAMA_BARANG) as NAMA FROM barang WHERE STOK_BARANG <= STOK_MIN"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            LblNotif.Text = RD("NAMA")
        End If
        Conn.Close()
    End Sub

    Sub Notif2()
        Call Koneksi()
        Dim sql As String
        sql = "SELECT COUNT(*) as TGL FROM penjualan WHERE JATUH_TEMPO <= '" & Format(tanggal, "yyyy-MM-dd") & "' AND STATUS_TRANSAKSI ='UTANG'"
        CMD = New MySqlCommand(sql, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            LblJthTempo.Text = RD("TGL")
        End If
        Conn.Close()
    End Sub

    Public Sub ChartPenjualan()
        Call Koneksi()
        Dim query As String
        Try
            query = "SELECT SUM(TOTAL_HARGA) AS TOTAL, DATE_FORMAT(TGL_TRANSAKSI, '%M') AS BULAN, MONTH(TGL_TRANSAKSI) AS ANGKA FROM transaksi WHERE TGL_TRANSAKSI LIKE '" & MenuUtama.LblChart.Text & "%' GROUP BY BULAN ORDER BY ANGKA ASC"
            CMD = New MySqlCommand(query, Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                While RD.Read
                    Chart2.Series("Series1").Points.AddXY(RD.GetString("BULAN"), RD.GetInt32("TOTAL"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub ChartBarang()
        Call Koneksi()
        Dim query As String
        Try
            query = "SELECT SUM(transaksi.QTY) AS QTY, barang.NAMA_BARANG AS BRG FROM transaksi INNER JOIN barang ON transaksi.ID_BARANG = barang.ID_BARANG WHERE transaksi.TGL_TRANSAKSI LIKE '" & MenuUtama.LblChart.Text & "%' GROUP BY BRG ORDER BY QTY DESC LIMIT 5"
            CMD = New MySqlCommand(query, Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                While RD.Read
                    Chart1.Series("Series1").Points.AddXY(RD.GetString("BRG"), RD.GetInt32("QTY"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub ChartPenjualanTahun()
        Call Koneksi()
        Dim query As String
        Try
            query = "SELECT SUM(TOTAL_HARGA) AS TOTAL, DATE_FORMAT(TGL_TRANSAKSI, '%Y') AS TAHUN FROM transaksi GROUP BY TAHUN ORDER BY TAHUN DESC LIMIT 5"
            CMD = New MySqlCommand(query, Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                While RD.Read
                    Chart3.Series("Series1").Points.AddXY(RD.GetInt32("TAHUN"), RD.GetInt32("TOTAL"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub ChartStokBanyak()
        Call Koneksi()
        Dim query As String
        Try
            query = "SELECT NAMA_BARANG, STOK_BARANG FROM barang ORDER BY STOK_BARANG DESC LIMIT 5"
            CMD = New MySqlCommand(query, Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                While RD.Read
                    Chart4.Series("Series1").Points.AddXY(RD.GetString("NAMA_BARANG"), RD.GetInt32("STOK_BARANG"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub ChartStokMinimal()
        Call Koneksi()
        Dim query As String
        Try
            query = "SELECT NAMA_BARANG, STOK_BARANG FROM barang WHERE STOK_BARANG <= STOK_MIN ORDER BY STOK_BARANG DESC LIMIT 5"
            CMD = New MySqlCommand(query, Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                While RD.Read
                    Chart5.Series("Series1").Points.AddXY(RD.GetString("NAMA_BARANG"), RD.GetInt32("STOK_BARANG"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub ChartBarangMasuk()
        Call Koneksi()
        Dim query As String
        Try
            query = "SELECT SUM(TOTAL_STOK_MASUK) AS TOTAL, DATE_FORMAT(TANGGAL_MASUK, '%M') AS BULAN, MONTH(TANGGAL_MASUK) AS ANGKA FROM barang_masuk WHERE DATE_FORMAT(TANGGAL_MASUK,'%Y') = '" & MenuUtama.LblChart.Text & "' GROUP BY BULAN ORDER BY ANGKA ASC"
            CMD = New MySqlCommand(query, Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                While RD.Read
                    Chart6.Series("Series1").Points.AddXY(RD.GetString("BULAN"), RD.GetInt32("TOTAL"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub ChartBarangKeluar()
        Call Koneksi()
        Dim query As String
        Try
            query = "SELECT SUM(QTY) AS TOTAL, DATE_FORMAT(TGL_TRANSAKSI, '%M') AS BULAN, MONTH(TGL_TRANSAKSI) AS ANGKA FROM transaksi WHERE DATE_FORMAT(TGL_TRANSAKSI,'%Y') = '" & MenuUtama.LblChart.Text & "' GROUP BY BULAN ORDER BY ANGKA ASC"
            CMD = New MySqlCommand(query, Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                While RD.Read
                    Chart7.Series("Series1").Points.AddXY(RD.GetString("BULAN"), RD.GetInt32("TOTAL"))
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Sub DataCombox()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT DATE_FORMAT(TGL_TRANSAKSI, '%Y') AS TAHUN FROM transaksi GROUP BY TAHUN"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            Do While RD.Read
                ComboBox1.Items.Add(RD("TAHUN"))
            Loop
        End If
        Conn.Close()
    End Sub

    Sub InfoPenjualan()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(TOTAL_HARGA),0), 0) AS TOTAL FROM transaksi WHERE TGL_TRANSAKSI = '" & Format(tanggal, "yyyy-MM-dd") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblInfoJual.Text = RD.Item("TOTAL")
        End If
        Conn.Close()
    End Sub

    Sub InfoPenjualanBulan()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(TOTAL_HARGA),0), 0) AS TOTAL FROM transaksi WHERE DATE_FORMAT(TGL_TRANSAKSI, '%m') = '" & Format(tanggal, "MM") & "' AND DATE_FORMAT(TGL_TRANSAKSI, '%Y') = '" & Format(tanggal, "yyyy") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblInfoJualBulan.Text = RD.Item("TOTAL")
        End If
        Conn.Close()
    End Sub

    Sub InfoPenjualanTahun()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(TOTAL_HARGA),0), 0) AS TOTAL FROM transaksi WHERE DATE_FORMAT(TGL_TRANSAKSI, '%Y') = '" & Format(tanggal, "yyyy") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblInfoJualTahun.Text = RD.Item("TOTAL")
        End If
        Conn.Close()
    End Sub

    Sub InfoTopSales()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT SUM(transaksi.QTY) AS QTY, barang.NAMA_BARANG AS BRG FROM transaksi INNER JOIN barang ON transaksi.ID_BARANG = barang.ID_BARANG WHERE DATE_FORMAT(transaksi.TGL_TRANSAKSI, '%Y') = '" & Format(tanggal, "yyyy") & "' GROUP BY BRG ORDER BY QTY DESC LIMIT 1"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextTopSales.Text = RD.Item("BRG")
        End If
        Conn.Close()
    End Sub

    Sub InfoPiutang()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(SISA_TAGIHAN), 0),0) AS PIUTANG FROM penjualan"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            lblInfoPiutang.Text = RD.Item("PIUTANG")
        End If
        Conn.Close()
    End Sub

    Sub InfoHutang()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(TAGIHAN), 0),0) AS HUTANG FROM pembelian"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblInfoHutang.Text = RD.Item("HUTANG")
        End If
        Conn.Close()
    End Sub

    Sub InfoTotalStok()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT SUM(STOK_BARANG) AS STOK FROM barang"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblTotalStok.Text = RD.Item("STOK")
        End If
        Conn.Close()
    End Sub

    Sub InfoNilaiStok()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT FORMAT(SUM((HARGA_JUAL*STOK_BARANG)),0) AS NILAI_STOK FROM barang"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblNilaiStok.Text = RD.Item("NILAI_STOK")
        End If
        Conn.Close()
    End Sub

    Sub InfoPenjualanJatuhTempo()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(SISA_TAGIHAN),0),0) AS JATUHTEMPO FROM `penjualan` WHERE JENIS_PEMBAYARAN = 'KREDIT' AND STATUS_TRANSAKSI = 'UTANG' AND JATUH_TEMPO <= '" & Format(tanggal, "yyyy-MM-dd") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblTempo.Text = RD.Item("JATUHTEMPO")
        End If
        Conn.Close()
    End Sub

    Sub InfoPelunasan()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(BAYAR),0), 0) AS PELUNASAN FROM `penjualan` WHERE JENIS_PEMBAYARAN = 'KREDIT' AND TGL_PEMBAYARAN BETWEEN '" & Format(tanggal, "yyyy-MM") & "-01' AND '" & Format(tanggal, "yyyy-MM") & "-31'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblPelunasan.Text = RD.Item("PELUNASAN")
        End If
        Conn.Close()
    End Sub

    Sub InfoNilaiReturPenjualan()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(TOTAL_RETUR),0),0) AS RETUR FROM `retur_penjualan` WHERE TANGGAL_RETUR BETWEEN '" & Format(tanggal, "yyyy-MM") & "-01' AND '" & Format(tanggal, "yyyy-MM") & "-31'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblRetur.Text = RD.Item("RETUR")
        End If
        Conn.Close()
    End Sub

    Sub PenjualanAwal()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(GRAND_TOTAL,0) AS GRAND_TOTAL FROM penjualan WHERE DATE_FORMAT(TGL_TRANSAKSI, '%m') = '" & Format(tanggal, "MM") & "' AND DATE_FORMAT(TGL_TRANSAKSI, '%Y') = '" & Format(tanggal, "yyyy") & "' ORDER BY TGL_TRANSAKSI ASC LIMIT 1"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            awal = RD.Item("GRAND_TOTAL")
        End If
        Conn.Close()
    End Sub

    Sub PenjualanAkhir()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(SUM(GRAND_TOTAL),0) AS TOTAL FROM penjualan WHERE DATE_FORMAT(TGL_TRANSAKSI, '%m') = '" & Format(tanggal, "MM") & "' AND DATE_FORMAT(TGL_TRANSAKSI, '%Y') = '" & Format(tanggal, "yyyy") & "' ORDER BY TGL_TRANSAKSI ASC LIMIT 1"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            akhir = RD.Item("TOTAL")
        End If
        Conn.Close()
    End Sub

    Sub TingkatPertumbuhanPenjualan()
        If akhir = 0 And awal = 0 Then
            LblPersen.Text = 0
        Else
            x = akhir - awal
            persen = x / akhir
            hasil = persen * 100
            LblPersen.Text = hasil
        End If
    End Sub

    Sub InfoJumlahBrgMsk()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(SUM(TOTAL_STOK_MASUK),0) AS STOK_MASUK FROM `barang_masuk` WHERE TANGGAL_MASUK = '" & Format(tanggal, "yyyy-MM-dd") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblInfoBrgMsk.Text = RD.Item("STOK_MASUK")
        End If
        Conn.Close()
    End Sub

    Sub InfoJmlReturJual()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(QTY_RETUR),0),0) AS QTY FROM retur_penjualan WHERE DATE_FORMAT(TANGGAL_RETUR,'%m') = '" & Format(tanggal, "MM") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblInfoReturJual.Text = RD.Item("QTY")
        End If
        Conn.Close()
    End Sub

    Sub InfoJmlReturBeli()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(QTY_RETUR_BELI),0),0) AS QTY FROM retur_pembelian WHERE DATE_FORMAT(TANGGAL_RETUR_BELI,'%m') = '" & Format(tanggal, "MM") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblInfoReturBeli.Text = RD.Item("QTY")
        End If
        Conn.Close()
    End Sub

    Sub InfoReturTertundaJual()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(COUNT(STATUS_RETUR),0),0) AS STATUS FROM retur_penjualan WHERE STATUS_RETUR = 'Ditunda'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblReturJualTunda.Text = RD.Item("STATUS")
        End If
        Conn.Close()
    End Sub

    Sub InfoReturTertundaBeli()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(COUNT(STATUS_RETUR_BELI),0),0) AS STATUS FROM retur_pembelian WHERE STATUS_RETUR_BELI = 'Ditunda'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblReturBeliTunda.Text = RD.Item("STATUS")
        End If
        Conn.Close()
    End Sub

    Sub InfoJumlahRusak()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(JUMLAH_RUSAK),0),0) AS RUSAK FROM stok_opname WHERE DATE_FORMAT(TGL_UBAH_STOK_OPNAME, '%m') = '" & Format(tanggal, "MM") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblStokRusak.Text = RD.Item("RUSAK")
        End If
        Conn.Close()
    End Sub

    Sub InfoJumlahHilang()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT IFNULL(FORMAT(SUM(JUMLAH_HILANG),0),0) AS HILANG FROM stok_opname WHERE DATE_FORMAT(TGL_UBAH_STOK_OPNAME, '%m') = '" & Format(tanggal, "MM") & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            LblStokHilang.Text = RD.Item("HILANG")
        End If
        Conn.Close()
    End Sub

    Sub StokTerbanyak()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT NAMA_BARANG, IFNULL(FORMAT(STOK_BARANG,0),0) AS STOK FROM `barang` ORDER BY STOK_BARANG DESC LIMIT 1"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextStokBanyak.Text = RD.Item("NAMA_BARANG")
            TextQTY.Text = RD.Item("STOK")
        End If
        Conn.Close()
    End Sub

    Private Sub Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblNotif.Visible = False
        LblJthTempo.Visible = False
        If MenuUtama.LblChart.Text = "Label1" Then
            MenuUtama.LblChart.Text = Format(tanggal, "yyyy")
        End If
        LblThn.Text = MenuUtama.LblChart.Text
        LblThn2.Text = MenuUtama.LblChart.Text
        LblTahun1.Text = MenuUtama.LblChart.Text
        LblTahun2.Text = MenuUtama.LblChart.Text
        Call ChartPenjualan()
        Call ChartBarang()
        Call ChartPenjualanTahun()
        Call ChartStokBanyak()
        Call ChartStokMinimal()
        Call ChartBarangMasuk()
        Call ChartBarangKeluar()
        Call InfoPenjualan()
        Call InfoPenjualanBulan()
        Call InfoPenjualanTahun()
        Call InfoPiutang()
        Call InfoHutang()
        Call DataCombox()
        Call InfoTotalStok()
        Call InfoNilaiStok()
        Call InfoPenjualanJatuhTempo()
        Call InfoPelunasan()
        Call InfoNilaiReturPenjualan()
        Call InfoTopSales()
        Call PenjualanAwal()
        Call PenjualanAkhir()
        Call TingkatPertumbuhanPenjualan()
        Call InfoJumlahBrgMsk()
        Call InfoJmlReturJual()
        Call InfoJmlReturBeli()
        Call InfoReturTertundaJual()
        Call InfoReturTertundaBeli()
        Call InfoJumlahRusak()
        Call InfoJumlahHilang()
        Call StokTerbanyak()
        Call Notif()
        Call Notif2()
        If LblNotif.Text > 0 Then
            Notifikasi.Show()
        End If
        If LblJthTempo.Text > 0 Then
            NotifikasiJatuhTempo.Show()
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        MenuUtama.combox = Val(ComboBox1.Text)
        MenuUtama.LblChart.Text = MenuUtama.combox
        MenuUtama.TampilForm(New Stats)
    End Sub
End Class