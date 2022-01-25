Imports MySql.Data.MySqlClient
Public Class CariNotaPembelian
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
        notapembelian = Proses.ExecuteQuery("SELECT pembelian.TGL_BELI, pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER INNER JOIN pembelian_detail ON pembelian_detail.NOTA_PEMBELIAN = pembelian.NOTA_PEMBELIAN WHERE pembelian_detail.MASUK != pembelian_detail.QTY_BELI GROUP BY pembelian.NOTA_PEMBELIAN ORDER BY pembelian.NOTA_PEMBELIAN DESC")
        DGCariNotaPem.DataSource = notapembelian
        DGCariNotaPem.Columns(0).Width = 100
        DGCariNotaPem.Columns(1).Width = 200
        DGCariNotaPem.Columns(2).Width = 200
    End Sub

    Private Sub CariNotaPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        TxtNotaPem.Visible = False
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        Dim Dv As New DataView(notapembelian)
        Dv.RowFilter = String.Format("NAMA_SUPPLIER LIKE '%{0}%'", TextCari.Text)
        DGCariNotaPem.DataSource = Dv
    End Sub

    Private Sub DGCariNotaPem_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCariNotaPem.CellClick
        Dim baris As Integer
        With DGCariNotaPem
            baris = .CurrentRow.Index
            TxtNotaPem.Text = .Item(1, baris).Value
            BarangMasuk.TextNotaPembelian.Text = TxtNotaPem.Text
            Call BarangMasuk.Data_Record_Pembelian()
            Call BarangMasuk.Data_Record()
            MenuUtama.TampilForm(BarangMasuk)
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