Imports MySql.Data.MySqlClient
Public Class UbahAdmin
    Public RD As MySqlDataReader
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Dim pengguna As DataTable
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
        SQL = "SELECT * FROM pengguna WHERE USERNAME = '" & TextUser.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextPass.Text = RD("PASSWORD")
            TextDepan.Text = RD("NAMA_DEPAN")
            TextBelakang.Text = RD("NAMA_BELAKANG")
            ComboBoxAkses.Text = RD("HAK_AKSES")
        End If
        Conn.Close()
    End Sub

    Private Sub UbahAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextUser.Enabled = False
        Call Data_Textbox()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TextUser.Text = "" Or
            TextPass.Text = "" Or
            TextDepan.Text = "" Or
            TextBelakang.Text = "" Or
            ComboBoxAkses.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Pastikan kolom tidak kosong!"
            MsgBoxWarning.ShowDialog()
        Else
            pengguna = Proses.ExecuteQuery("SELECT * FROM pengguna WHERE PASSWORD = MD5('" & TextPassAdmin.Text & "') AND USERNAME = 'admin'")
            If pengguna.Rows.Count = 0 Then
                MsgBoxWarning.TextMsg.Text = "Password Admin Salah!"
                MsgBoxWarning.ShowDialog()
                TextPassAdmin.Clear()
                TextPassAdmin.Focus()
            Else
                SQL = "UPDATE pengguna SET PASSWORD = MD5('" & TextPass.Text & "'), NAMA_DEPAN = '" & TextDepan.Text & "', NAMA_BELAKANG = '" & TextBelakang.Text & "', HAK_AKSES = '" & ComboBoxAkses.Text & "' WHERE USERNAME = '" & TextUser.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBoxBerhasil.TextMsg.Text = "Data sudah diubah"
                MsgBoxBerhasil.ShowDialog()
                KelolaAdmin.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub UbahAdmin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
        KelolaAdmin.Show()
    End Sub
End Class