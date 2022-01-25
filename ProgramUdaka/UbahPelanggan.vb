Imports MySql.Data.MySqlClient
Public Class UbahPelanggan
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
        SQL = "SELECT * FROM pelanggan WHERE ID_PELANGGAN = '" & TextKodeCusUbah.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextNamaCusUbah.Text = RD("NAMA_PELANGGAN")
            ComBoxCusUbah.Text = RD("JENIS_PELANGGAN")
            TextAlmtCusUbah.Text = RD("ALAMAT_PELANGGAN")
            TextTelpCusUbah.Text = RD("NO_TELP_PELANGGAN")
            TextMailCusUbah.Text = RD("EMAIL_PELANGGAN")
        End If
        Conn.Close()
    End Sub

    Private Sub UbahPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextKodeCusUbah.Enabled = False
        Call Data_Textbox()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextAlmtCusUbah.Text = "" Or
            TextKodeCusUbah.Text = "" Or
            TextMailCusUbah.Text = "" Or
            TextNamaCusUbah.Text = "" Or
            TextTelpCusUbah.Text = "" Or
            ComBoxCusUbah.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap!, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
            Exit Sub
        End If

        SQL = "UPDATE pelanggan SET NAMA_PELANGGAN = '" & TextNamaCusUbah.Text & "', JENIS_PELANGGAN = '" & ComBoxCusUbah.Text & "', ALAMAT_PELANGGAN = '" & TextAlmtCusUbah.Text & "', NO_TELP_PELANGGAN = '" & TextTelpCusUbah.Text & "', EMAIL_PELANGGAN = '" & TextMailCusUbah.Text & "' WHERE ID_PELANGGAN = '" & TextKodeCusUbah.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MsgBoxBerhasil.TextMsg.Text = "Data pelanggan sudah terubah"
        MsgBoxBerhasil.ShowDialog()
        'Dim pelangganpopuppopup As DataBarang = New DataBarang()
        'pelangganpopup.Show()
        MenuUtama.TampilForm(New DataPelanggan)
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UbahPelanggan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub TextTelpCusUbah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextTelpCusUbah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub
End Class