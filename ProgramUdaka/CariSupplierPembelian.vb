Imports MySql.Data.MySqlClient
Public Class CariSupplierPembelian
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim supplier As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Public Sub Data_Record()
        supplier = Proses.ExecuteQuery("SELECT * FROM supplier")
        DGCariSupplier.DataSource = supplier
        DGCariSupplier.Columns(0).Width = 100
        DGCariSupplier.Columns(1).Width = 200
        DGCariSupplier.Columns(2).Width = 100
        DGCariSupplier.Columns(3).Width = 100
        DGCariSupplier.Columns(4).Width = 200
    End Sub

    Private Sub CariSupplierPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        Rb_IDsup.Checked = True
        TextSup.Visible = False
        TextKodeSup.Visible = False
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged, TextSup.TextChanged, TextKodeSup.TextChanged
        If Rb_IDsup.Checked = True Then
            Dim Dv As New DataView(supplier)
            Dv.RowFilter = String.Format("ID_SUPPLIER LIKE '%{0}%'", TextCari.Text)
            DGCariSupplier.DataSource = Dv
        ElseIf Rb_Namasup.Checked = True Then
            Dim Dv As New DataView(supplier)
            Dv.RowFilter = String.Format("NAMA_SUPPLIER LIKE '%{0}%'", TextCari.Text)
            DGCariSupplier.DataSource = Dv
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DGCariSupplier_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCariSupplier.CellClick
        Dim baris As Integer
        With DGCariSupplier
            baris = .CurrentRow.Index
            TextKodeSup.Text = .Item(0, baris).Value
            TextSup.Text = .Item(1, baris).Value
            Pembelian.TextKodeSup.Text = TextKodeSup.Text
            Pembelian.TextSup.Text = TextSup.Text
            MenuUtama.TampilForm(Pembelian)
            Me.Close()
        End With
    End Sub

    Private Sub CariSupplierPembelian_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub
End Class