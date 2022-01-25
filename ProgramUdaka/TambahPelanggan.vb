Imports MySql.Data.MySqlClient
Public Class TambahPelanggan
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pelanggan As New DataPelanggan
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

    Sub Kode_Otomatis()
        Call Koneksi()
        SQL = ("SELECT * FROM pelanggan WHERE ID_PELANGGAN IN(SELECT MAX(ID_PELANGGAN)FROM pelanggan)")
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            TextKodeCus.Text = "CUS0001"
            RD.Close()
        End If

        If Not RD.HasRows Then
            TextKodeCus.Text = "CUS" + "0001"
            RD.Close()

        Else
            TextKodeCus.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("ID_PELANGGAN").ToString, 4)) + 1
            If Len(TextKodeCus.Text) = 1 Then
                TextKodeCus.Text = "CUS000" & TextKodeCus.Text & ""
            ElseIf Len(TextKodeCus.Text) = 2 Then
                TextKodeCus.Text = "CUS00" & TextKodeCus.Text & ""
            ElseIf Len(TextKodeCus.Text) = 3 Then
                TextKodeCus.Text = "CUS0" & TextKodeCus.Text & ""
            ElseIf Len(TextKodeCus.Text) = 4 Then
                TextKodeCus.Text = "CUS" & TextKodeCus.Text & ""
            End If

            RD.Close()

        End If
        Conn.Close()
    End Sub

    Private Sub TambahPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_Otomatis()
        TextKodeCus.Enabled = False
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextKodeCus.Text = "" Or
            TextNamaCus.Text = "" Or
            ComBoxCus.Text = "" Or
            TextTelpCus.Text = "" Or
            TextAlmtCus.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap!, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
            Exit Sub
        End If

        SQL = "INSERT INTO pelanggan VALUES ('" & TextKodeCus.Text & "','" & TextNamaCus.Text & "','" & ComBoxCus.Text & "','" & TextAlmtCus.Text & "','" & TextTelpCus.Text & "', '" & TextMailCus.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MsgBoxBerhasil.TextMsg.Text = "Data baru tersimpan"
        MsgBoxBerhasil.ShowDialog()
        ' Dim pelanggan As DataPelanggan = New DataPelanggan()
        'pelanggan.Show()
        MenuUtama.TampilForm(New DataPelanggan)

        TextKodeCus.Clear()
        TextNamaCus.Clear()
        TextTelpCus.Clear()
        TextAlmtCus.Clear()
        TextMailCus.Clear()

        Me.Close()
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

    Private Sub TambahPelanggan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub TextTelpCus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextTelpCus.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub
End Class