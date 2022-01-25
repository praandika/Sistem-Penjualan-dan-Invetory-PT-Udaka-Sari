Imports MySql.Data.MySqlClient
Public Class Login
    Dim DR As MySqlDataReader
    Dim CMD As MySqlCommand
    Dim DA As MySqlDataAdapter
    Dim conn As MySqlConnection
    Dim SQL As String
    Dim Proses As New ClsKoneksi

    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;" _
        & "user id=root;" _
        & "password=;" _
        & "database=udakasari")

        conn.Open()
        If conn.State <> ConnectionState.Open Then
            MsgBox("Koneksi Gagal", MsgBoxStyle.Critical, "Access Failed")
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        DateTimePicker1.Visible = False
    End Sub

    Private Sub Txtuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txtpass.Focus()
        End If
    End Sub

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Try
                Call Koneksi()
                CMD = New MySqlCommand("SELECT * FROM pengguna WHERE USERNAME='" + Trim(Txtuser.Text) + "' AND PASSWORD=MD5('" + Trim(Txtpass.Text) + "') ", conn)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Me.Hide()

                If DR("HAK_AKSES").ToString = "Penjualan" Then
                    MenuUtama.Show()
                    MenuUtama.TampilForm(New Stats)
                    MenuUtama.LblHeader.Text = "Informasi"
                    MenuUtama.BtnBarangMasuk.Enabled = False
                    MenuUtama.BtnDataPembelian.Enabled = False
                    MenuUtama.BtnDataSupplier.Enabled = False
                    MenuUtama.BtnStokOpname.Enabled = False
                    MenuUtama.BtnAkunSetting.Enabled = False
                    MenuUtama.BtnPembelian.Enabled = False
                    
                    MenuUtama.BtnBarangMasuk.BackColor = Color.LightGray
                    MenuUtama.BtnDataPembelian.BackColor = Color.LightGray
                    MenuUtama.BtnDataSupplier.BackColor = Color.LightGray
                    MenuUtama.BtnStokOpname.BackColor = Color.LightGray
                    MenuUtama.BtnAkunSetting.BackColor = Color.LightGray
                    MenuUtama.BtnPembelian.BackColor = Color.LightGray

                    MenuUtama.LabelNama.Text = DR("NAMA_DEPAN")
                    MenuUtama.LabelUsername.Text = DR("USERNAME")
                    MenuUtama.LabelHakAkses.Text = DR("HAK_AKSES")

                ElseIf DR("HAK_AKSES").ToString = "Inventory" Then
                    MenuUtama.Show()
                    MenuUtama.TampilForm(New Stats)
                    MenuUtama.LblHeader.Text = "Informasi"
                    MenuUtama.BtnDataPelanggan.Enabled = False
                    MenuUtama.BtnDataPenjualan.Enabled = False
                    MenuUtama.BtnPenjualan.Enabled = False
                    MenuUtama.BtnDataPendapatan.Enabled = False
                    MenuUtama.BtnCatatanPembayaran.Enabled = False
                    MenuUtama.BtnAkunSetting.Enabled = False

                    MenuUtama.BtnDataPelanggan.BackColor = Color.LightGray
                    MenuUtama.BtnDataPenjualan.BackColor = Color.LightGray
                    MenuUtama.BtnPenjualan.BackColor = Color.LightGray
                    MenuUtama.BtnDataPendapatan.BackColor = Color.LightGray
                    MenuUtama.BtnCatatanPembayaran.BackColor = Color.LightGray
                    MenuUtama.BtnAkunSetting.BackColor = Color.LightGray

                    MenuUtama.LabelNama.Text = DR("NAMA_DEPAN")
                    MenuUtama.LabelUsername.Text = DR("USERNAME")
                    MenuUtama.LabelHakAkses.Text = DR("HAK_AKSES")

                Else
                    MenuUtama.Show()
                    MenuUtama.TampilForm(New Stats)
                    MenuUtama.LblHeader.Text = "Informasi"
                    MenuUtama.LabelNama.Text = DR("NAMA_DEPAN")
                    MenuUtama.LabelUsername.Text = DR("USERNAME")
                    MenuUtama.LabelHakAkses.Text = DR("HAK_AKSES")
                    'SQL = "INSERT INTO log VALUES ('" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','" & Txtuser.Text & "','Melakukan login','" & DR("NAMA_DEPAN") & "')"
                    'Proses.ExecuteNonQuery(SQL)
                End If

                    Call kosong()
            Else
                MsgBoxWarning.TextMsg.Text = "Username atau password salah!"
                MsgBoxWarning.ShowDialog()
                Call kosong()
                End If
                conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub kosong()
        Txtuser.Text = ""
        Txtpass.Text = ""
        'ComboxStts.Text = ""
        Txtuser.Focus()
    End Sub

    Private Sub ShutDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutDown.Click
        Dim pesan
        pesan = MsgBox("Matikan Sistem", vbQuestion + vbYesNo)
        If pesan = vbYes Then
            Me.Close()
        Else
            Txtuser.Focus()
        End If
    End Sub
End Class
