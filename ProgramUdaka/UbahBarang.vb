Imports MySql.Data.MySqlClient
Public Class UbahBarang
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public CMD As MySqlCommand
    Dim SQL, CEK As String
    Dim txt1, txt2 As Long
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
        SQL = "SELECT * FROM barang WHERE ID_BARANG = '" & TextKodeUbah.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextNamaUbah.Text = RD("NAMA_BARANG")
            ComboxJenisUbah.Text = RD("JENIS_BARANG")
            TextHrgBeliUbah.Text = RD("HARGA_BELI")
            TextHrgJualUbah.Text = RD("HARGA_JUAL")
            TextMin.Text = RD("STOK_MIN")
        End If
        Conn.Close()
    End Sub

    Private Sub UbahBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextKodeUbah.Enabled = False
        TextMin.Visible = False
        Call Data_Textbox()
    End Sub

    Private Sub TextHrgBeliUbah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextHrgBeliUbah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub TextHrgBeliUbah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextHrgBeliUbah.TextChanged
        If TextHrgBeliUbah.Text = "" Or Not IsNumeric(TextHrgBeliUbah.Text) Then
            Exit Sub
        End If
        txt1 = TextHrgBeliUbah.Text
        TextHrgBeliUbah.Text = Format(Val(txt1), "###,###")
        TextHrgBeliUbah.SelectionStart = Len(TextHrgBeliUbah.Text)
    End Sub

    Private Sub TextHrgJualUbah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextHrgJualUbah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub TextHrgJualUbah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextHrgJualUbah.TextChanged
        If TextHrgJualUbah.Text = "" Or Not IsNumeric(TextHrgJualUbah.Text) Then
            Exit Sub
        End If
        txt2 = TextHrgJualUbah.Text
        TextHrgJualUbah.Text = Format(Val(txt2), "###,###")
        TextHrgJualUbah.SelectionStart = Len(TextHrgJualUbah.Text)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UbahBarang_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextHrgBeliUbah.Text = "" Or
            TextHrgJualUbah.Text = "" Or
            TextKodeUbah.Text = "" Or
            TextNamaUbah.Text = "" Or
            ComboxJenisUbah.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap!, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
            Exit Sub
        Else
            SQL = "UPDATE barang SET NAMA_BARANG = '" & TextNamaUbah.Text & "', JENIS_BARANG = '" & ComboxJenisUbah.Text & "', HARGA_BELI = '" & CLng(TextHrgBeliUbah.Text) & "', HARGA_JUAL = '" & CLng(TextHrgJualUbah.Text) & "', STOK_MIN = '" & TextMin.Text & "' WHERE ID_BARANG = '" & TextKodeUbah.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "Data barang sudah terubah"
            MsgBoxBerhasil.ShowDialog()
            'Dim barangpopup As DataBarang = New DataBarang()
            'barangpopup.Show()
            MenuUtama.TampilForm(New DataBarang)
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub CheckBoxMin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMin.CheckedChanged
        If CheckBoxMin.Checked = True Then
            TextMin.Visible = True
        Else
            TextMin.Visible = False
        End If
    End Sub
End Class