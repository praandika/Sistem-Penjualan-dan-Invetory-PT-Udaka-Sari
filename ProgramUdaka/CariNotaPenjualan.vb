Imports MySql.Data.MySqlClient
Public Class CariNotaPenjualan
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim notapembelian As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Public Sub Data_Record()
        notapembelian = Proses.ExecuteQuery("SELECT penjualan.TGL_TRANSAKSI, penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN INNER JOIN transaksi ON transaksi.NO_NOTA = penjualan.NO_NOTA WHERE transaksi.KELUAR != transaksi.QTY GROUP BY penjualan.NO_NOTA ORDER BY penjualan.NO_NOTA DESC")
        DGCariNota.DataSource = notapembelian
        DGCariNota.Columns(0).Width = 100
        DGCariNota.Columns(1).Width = 200
        DGCariNota.Columns(2).Width = 200
    End Sub

    Private Sub CariNotaPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        TxtNota.Visible = False
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        Dim Dv As New DataView(notapembelian)
        Dv.RowFilter = String.Format("NAMA_PELANGGAN LIKE '%{0}%'", TextCari.Text)
        DGCariNota.DataSource = Dv
    End Sub

    Private Sub DGCariNotaPem_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCariNota.CellClick
        Dim baris As Integer
        With DGCariNota
            baris = .CurrentRow.Index
            TxtNota.Text = .Item(1, baris).Value
            BarangKeluar.TextNotaPenjualan.Text = TxtNota.Text
            Call BarangKeluar.Data_Record_Penjualan()
            Call BarangKeluar.Data_Record()
            MenuUtama.TampilForm(BarangKeluar)
            Me.Close()
        End With
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CariNotaPembelian_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub
End Class