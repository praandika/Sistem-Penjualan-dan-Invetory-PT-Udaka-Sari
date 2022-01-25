Imports MySql.Data.MySqlClient
Public Class UbahStokOpname
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public CMD As MySqlCommand
    Dim SQL As String
    Dim Proses As New ClsKoneksi
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

    Sub Data_Textbox()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT stok_opname.ID_STOK_OPNAME, stok_opname.ID_BARANG, barang.NAMA_BARANG, stok_opname.STOK_BRG_OPNAME, stok_opname.JUMLAH_BAIK, stok_opname.JUMLAH_RUSAK, stok_opname.JUMLAH_HILANG, stok_opname.SELISIH FROM stok_opname INNER JOIN barang ON barang.ID_BARANG = stok_opname.ID_BARANG WHERE ID_STOK_OPNAME = '" & TextKodeStokOpname.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextBrg.Text = RD("NAMA_BARANG")
            TextKodeBrg.Text = RD("ID_BARANG")
            TextStok.Text = RD("STOK_BRG_OPNAME")
            TextBaik.Text = RD("JUMLAH_BAIK")
            TextRusak.Text = RD("JUMLAH_RUSAK")
            TextHilang.Text = RD("JUMLAH_HILANG")
            TextSelisih.Text = RD("SELISIH")
        End If
        Conn.Close()
    End Sub

    Public Sub Hitung_Stok_Opname()
        Dim selisih, stok, baik, rusak, hilang As Integer
        stok = Val(TextStok.Text)
        rusak = Val(TextRusak.Text)
        hilang = Val(TextHilang.Text)
        baik = stok - (rusak + hilang)
        TextBaik.Text = baik
        selisih = stok - baik
        TextSelisih.Text = selisih
    End Sub

    Private Sub UbahStokOpname_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextKodeStokOpname.Enabled = False
        TextBrg.Enabled = False
        TextKodeBrg.Enabled = False
        TextStok.Enabled = False
        TextSelisih.Enabled = False
        DateTimePicker1.Enabled = False
        TextBaik.Enabled = False
        Call Data_Textbox()
    End Sub

    Private Sub UbahStokOpname_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        SQL = "UPDATE stok_opname SET TGL_UBAH_STOK_OPNAME = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', JUMLAH_BAIK = '" & TextBaik.Text & "', JUMLAH_RUSAK = '" & TextRusak.Text & "', JUMLAH_HILANG = '" & TextHilang.Text & "', SELISIH = '" & TextSelisih.Text & "' WHERE ID_STOK_OPNAME = '" & TextKodeStokOpname.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        SQL = "INSERT INTO barang_detail VALUES ('" & TextKodeBrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Stok opname dengan kode " & TextKodeStokOpname.Text & "','" & TextBaik.Text & "','" & TextSelisih.Text & "','" & MenuUtama.LabelUsername.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MsgBoxBerhasil.TextMsg.Text = "Data stok opname sudah terubah"
        MsgBoxBerhasil.ShowDialog()
        MenuUtama.TampilForm(New DataStokOpname)
        Me.Close()
    End Sub

    Private Sub TextRusak_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextRusak.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub TextRusak_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextRusak.TextChanged
        Call Hitung_Stok_Opname()
    End Sub

    Private Sub TextHilang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextHilang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub TextHilang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextHilang.TextChanged
        Call Hitung_Stok_Opname()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class