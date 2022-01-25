Imports MySql.Data.MySqlClient
Public Class CariBarangStokOpname
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim barang As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Public Sub Data_Record()
        barang = Proses.ExecuteQuery("SELECT ID_BARANG, NAMA_BARANG, STOK_BARANG FROM barang")
        DGCariBarang.DataSource = barang
        DGCariBarang.Columns(0).Width = 100
        DGCariBarang.Columns(1).Width = 200
        DGCariBarang.Columns(2).Width = 100
    End Sub

    Private Sub CariBarangStokOpname_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        Rb_IDbrg.Checked = True
        TextBrg.Visible = False
        TextKodeBrg.Visible = False
        TxtStok.Visible = False
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If Rb_IDbrg.Checked = True Then
            Dim Dv As New DataView(barang)
            Dv.RowFilter = String.Format("ID_BARANG LIKE '%{0}%'", TextCari.Text)
            DGCariBarang.DataSource = Dv
        ElseIf Rb_Namabrg.Checked = True Then
            Dim Dv As New DataView(barang)
            Dv.RowFilter = String.Format("NAMA_BARANG LIKE '%{0}%'", TextCari.Text)
            DGCariBarang.DataSource = Dv
        End If
    End Sub

    Private Sub DGCariBarang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCariBarang.CellClick
        Dim baris As Integer
        With DGCariBarang
            baris = .CurrentRow.Index
            TextKodeBrg.Text = .Item(0, baris).Value
            TextBrg.Text = .Item(1, baris).Value
            TxtStok.Text = .Item(2, baris).Value
            TambahStokOpname.TextKodeBrg.Text = TextKodeBrg.Text
            TambahStokOpname.TextBrg.Text = TextBrg.Text
            TambahStokOpname.TextStok.Text = TxtStok.Text
            TambahStokOpname.Show()
            TambahStokOpname.TextRusak.Focus()
            Me.Close()
        End With
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CariBarangStokOpname_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub DGCariBarang_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGCariBarang.CellFormatting
        If DGCariBarang.Columns(e.ColumnIndex).Name = "STOK_BARANG" Then
            If (Convert.ToInt64(e.Value) <= 10) Then
                e.CellStyle.BackColor = Color.IndianRed
                e.CellStyle.ForeColor = Color.LavenderBlush
            ElseIf (Convert.ToInt64(e.Value) <= 15) Then
                e.CellStyle.BackColor = Color.LightSalmon
                e.CellStyle.ForeColor = Color.DarkRed
            Else
                e.CellStyle.BackColor = Color.PaleGreen
                e.CellStyle.ForeColor = Color.DarkGreen
            End If
        End If
    End Sub
End Class