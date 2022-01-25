Imports MySql.Data.MySqlClient
Public Class DataPembelianDetail
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public CMD As MySqlCommand
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pembeliandetail As DataTable
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
        pembeliandetail = Proses.ExecuteQuery("SELECT pembelian_detail.ID_BARANG, barang.NAMA_BARANG, pembelian_detail.HARGA_BELI_BARANG, pembelian_detail.QTY_BELI, pembelian_detail.TOTAL_HARGA_BELI, pembelian_detail.MASUK FROM pembelian_detail INNER JOIN barang ON barang.ID_BARANG = pembelian_detail.ID_BARANG WHERE NOTA_PEMBELIAN = '" & TextDetail.Text & "'")
        DGPembelianDetail.DataSource = pembeliandetail
        DGPembelianDetail.Columns(0).Width = 100
        DGPembelianDetail.Columns(1).Width = 150
        DGPembelianDetail.Columns(2).Width = 150
        DGPembelianDetail.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGPembelianDetail.Columns(3).Width = 35
        DGPembelianDetail.Columns(4).Width = 150
        DGPembelianDetail.Columns(4).DefaultCellStyle.Format = "###,###,###"
        DGPembelianDetail.Columns(5).Width = 60
    End Sub

    Sub Data_Textbox()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT *, supplier.NAMA_SUPPLIER FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.NOTA_PEMBELIAN = '" & TextDetail.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextGrandTotal.Text = RD("TOTAL_QTY")
            TextTgl.Text = RD("TGL_BELI")
            TextSup.Text = RD("NAMA_SUPPLIER")
        End If
        Conn.Close()
    End Sub

    Private Sub DataPembelianDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        Call Data_Textbox()
        TextDetail.Enabled = False
        TextGrandTotal.Enabled = False
        TextTgl.Enabled = False
        TextSup.Enabled = False
    End Sub

    Private Sub DataPembelianDetail_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
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
        FormLaporanPembelianDetail.CRViewPembelianDetail.ReportSource = "ReportPembelianDetail.rpt"
        FormLaporanPembelianDetail.CRViewPembelianDetail.SelectionFormula = "{pembelian1.NOTA_PEMBELIAN} ='" + TextDetail.Text + "' AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanPembelianDetail.CRViewPembelianDetail.RefreshReport()
        FormLaporanPembelianDetail.ShowDialog()
    End Sub
End Class