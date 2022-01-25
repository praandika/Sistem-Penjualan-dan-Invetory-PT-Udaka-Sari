Imports MySql.Data.MySqlClient
Public Class TambahStokOpname
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
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

    Sub Kode_StokOpname()
        Dim brgmasuk As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM stok_opname"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            brgmasuk = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(brgmasuk))
            Case 1 : TextKodeStokOpname.Text = "SO.000" + Trim(Str(brgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextKodeStokOpname.Text = "SO.00" + Trim(Str(brgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextKodeStokOpname.Text = "SO.0" + Trim(Str(brgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextKodeStokOpname.Text = "SO." + Trim(Str(brgmasuk)) + "-" + Format(Now, "yyMMdd")
        End Select
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

    Private Sub TambahStokOpname_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_StokOpname()
        TextKodeStokOpname.Enabled = False
        TextKodeBrg.Enabled = False
        TextStok.Enabled = False
        TextSelisih.Enabled = False
        TextBaik.Enabled = False
    End Sub

    Private Sub TambahStokOpname_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextKodeStokOpname.Text = "" Or
            TextBrg.Text = "" Or
            TextKodeBrg.Text = "" Or
            TextStok.Text = "" Or
            TextBaik.Text = "" Or
            TextRusak.Text = "" Or
            TextHilang.Text = "" Or
            TextSelisih.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap!, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
            Exit Sub
        End If

        SQL = "INSERT INTO stok_opname VALUES ('" & TextKodeStokOpname.Text & "','" & TextKodeBrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & TextStok.Text & "','" & TextBaik.Text & "','" & TextRusak.Text & "','" & TextHilang.Text & "','" & TextSelisih.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        SQL = "UPDATE barang SET STOK_BARANG = '" & TextBaik.Text & "' WHERE ID_BARANG = '" & TextKodeBrg.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        SQL = "INSERT INTO barang_detail VALUES ('" & TextKodeBrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Stok opname dengan kode " & TextKodeStokOpname.Text & "','" & TextBaik.Text & "','" & TextSelisih.Text & "','" & MenuUtama.LabelUsername.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MsgBoxBerhasil.TextMsg.Text = "Data baru tersimpan"
        MsgBoxBerhasil.ShowDialog()
        'Dim barang As DataBarang = New DataBarang()
        'barang.Show()
        Call Kode_StokOpname()
        TextBrg.Clear()
        TextKodeBrg.Text = ""
        TextStok.Clear()
        TextBaik.Clear()
        TextRusak.Clear()
        TextHilang.Clear()
        TextSelisih.Clear()
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
        MenuUtama.TampilForm(New DataStokOpname)
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCariPel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariPel.Click
        CariBarangStokOpname.Show()
    End Sub

    Private Sub TextBrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBrg.KeyPress
        CariBarangStokOpname.Show()
    End Sub

    Private Sub TextBrg_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBrg.MouseDown
        CariBarangStokOpname.Show()
    End Sub
End Class