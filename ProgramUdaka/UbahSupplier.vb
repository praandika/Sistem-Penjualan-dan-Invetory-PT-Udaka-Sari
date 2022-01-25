Imports MySql.Data.MySqlClient
Public Class UbahSupplier
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
        SQL = "SELECT * FROM supplier WHERE ID_SUPPLIER = '" & TextKodeSup.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextNamaSup.Text = RD("NAMA_SUPPLIER")
            TextAlamatSup.Text = RD("ALAMAT_SUPPLIER")
            TextEmailSup.Text = RD("EMAIL_SUPPLIER")
            TextTelpSup.Text = RD("NO_TELP_SUPPLIER")
        End If
        Conn.Close()
    End Sub

    Private Sub UbahSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextKodeSup.Enabled = False
        Call Data_Textbox()
    End Sub

    Private Sub UbahSupplier_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextAlamatSup.Text = "" Or
            TextEmailSup.Text = "" Or
            TextKodeSup.Text = "" Or
            TextNamaSup.Text = "" Or
            TextTelpSup.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap!, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
        Else
            SQL = "UPDATE supplier SET NAMA_SUPPLIER = '" & TextNamaSup.Text & "', ALAMAT_SUPPLIER = '" & TextAlamatSup.Text & "', NO_TELP_SUPPLIER = '" & TextTelpSup.Text & "', EMAIL_SUPPLIER = '" & TextEmailSup.Text & "' WHERE ID_SUPPLIER = '" & TextKodeSup.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "Data supplier sudah terubah"
            MsgBoxBerhasil.ShowDialog()
            MenuUtama.TampilForm(New DataSupplier)
            Me.Close()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextTelpSup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextTelpSup.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            PanelNotif.Location = New Point(140, 177)
            Do Until PanelNotif.Location.Y = 197
                PanelNotif.Location = New Point(140, PanelNotif.Location.Y + 1)
                System.Threading.Thread.Sleep(1)
            Loop
        End If
    End Sub

    Private Sub PanelNotif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelNotif.Click
        Do Until PanelNotif.Location.Y = 177
            PanelNotif.Location = New Point(140, PanelNotif.Location.Y - 1)
            System.Threading.Thread.Sleep(1)
        Loop
    End Sub

    Private Sub LblNotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNotif.Click
        Do Until PanelNotif.Location.Y = 177
            PanelNotif.Location = New Point(140, PanelNotif.Location.Y - 1)
            System.Threading.Thread.Sleep(1)
        Loop
    End Sub
End Class