Imports MySql.Data.MySqlClient
Public Class CariPelangganPenjualan
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pelanggan As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Public Sub Data_Record()
        pelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan")
        DGCariPelanggan.DataSource = pelanggan
        DGCariPelanggan.Columns(0).Width = 100
        DGCariPelanggan.Columns(1).Width = 200
        DGCariPelanggan.Columns(2).Width = 100
        DGCariPelanggan.Columns(3).Width = 100
        DGCariPelanggan.Columns(4).Width = 200
        DGCariPelanggan.Columns(5).Width = 200
    End Sub

    Private Sub CariPelangganPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        Rb_IDpel.Checked = True
        TextPel.Visible = False
        TextKodePel.Visible = False
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If Rb_IDpel.Checked = True Then
            Dim Dv As New DataView(pelanggan)
            Dv.RowFilter = String.Format("ID_PELANGGAN LIKE '%{0}%'", TextCari.Text)
            DGCariPelanggan.DataSource = Dv
        ElseIf Rb_Namapel.Checked = True Then
            Dim Dv As New DataView(pelanggan)
            Dv.RowFilter = String.Format("NAMA_PELANGGAN LIKE '%{0}%'", TextCari.Text)
            DGCariPelanggan.DataSource = Dv
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DGCariPelanggan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCariPelanggan.CellClick
        Dim baris As Integer
        With DGCariPelanggan
            baris = .CurrentRow.Index
            TextKodePel.Text = .Item(0, baris).Value
            TextPel.Text = .Item(1, baris).Value
            Penjualan.TextIDcus.Text = TextKodePel.Text
            Penjualan.TextPel.Text = TextPel.Text
            Penjualan.TextBrgJual.Clear()
            Penjualan.TextIDbrg.Clear()
            Penjualan.TextStok.Clear()
            MenuUtama.TampilForm(Penjualan)
            Me.Close()
        End With
    End Sub

    Private Sub CariPelangganPenjualan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub
End Class