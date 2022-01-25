Imports MySql.Data.MySqlClient
Public Class DataPenjualanDetail
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public CMD As MySqlCommand
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim penjualandetail As DataTable
    Dim txt1, txt2 As Long
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
        penjualandetail = Proses.ExecuteQuery("SELECT transaksi.ID_BARANG, barang.NAMA_BARANG, transaksi.HARGA_BARANG, transaksi.QTY, transaksi.TOTAL_HARGA FROM transaksi INNER JOIN barang ON barang.ID_BARANG = transaksi.ID_BARANG WHERE NO_NOTA = '" & TextDetail.Text & "'")
        DGPenjualanDetail.DataSource = penjualandetail
        DGPenjualanDetail.Columns(0).Width = 100
        DGPenjualanDetail.Columns(1).Width = 150
        DGPenjualanDetail.Columns(2).Width = 150
        DGPenjualanDetail.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGPenjualanDetail.Columns(3).Width = 35
        DGPenjualanDetail.Columns(4).Width = 150
        DGPenjualanDetail.Columns(4).DefaultCellStyle.Format = "###,###,###"
    End Sub

    Sub Data_Textbox()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT *, pelanggan.NAMA_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.NO_NOTA = '" & TextDetail.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            'TextDurasiKredit.Text = RD("DURASI_KREDIT")
            TextGrandTotal.Text = RD("GRAND_TOTAL")
            TextJatuhTempo.Text = RD("JATUH_TEMPO")
            TextJenisPembayaran.Text = RD("JENIS_PEMBAYARAN")
            TextSttsTransaksi.Text = RD("STATUS_TRANSAKSI")
            TextTgl.Text = RD("TGL_TRANSAKSI")
            TextPiutang.Text = RD("SISA_TAGIHAN")
            TextCus.Text = RD("NAMA_PELANGGAN")
        End If
        Conn.Close()
    End Sub

    Private Sub DataPenjualanDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        Call Data_Textbox()
        TextDetail.Enabled = False
        'TextDurasiKredit.Enabled = False
        TextGrandTotal.Enabled = False
        TextJatuhTempo.Enabled = False
        TextJenisPembayaran.Enabled = False
        TextSttsTransaksi.Enabled = False
        TextTgl.Enabled = False
        TextCus.Enabled = False
        TextPiutang.Enabled = False
    End Sub

    Private Sub DataPenjualanDetail_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
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

    Private Sub TextGrandTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextGrandTotal.TextChanged
        txt1 = TextGrandTotal.Text
        TextGrandTotal.Text = Format(Val(txt1), "###,###")
    End Sub

    Private Sub TextPiutang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPiutang.TextChanged
        If TextPiutang.Text = Not IsNothing(TextPiutang.Text) Then
            txt2 = TextPiutang.Text
            TextPiutang.Text = Format(Val(txt2), "###,###")
        End If
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanPenjualanDetail.CRViewPenjualanDetail.ReportSource = "ReportPenjualanDetail.rpt"
        FormLaporanPenjualanDetail.CRViewPenjualanDetail.SelectionFormula = "{penjualan1.NO_NOTA} = '" + TextDetail.Text + "' AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "' "
        FormLaporanPenjualanDetail.CRViewPenjualanDetail.RefreshReport()
        FormLaporanPenjualanDetail.ShowDialog()
    End Sub
End Class