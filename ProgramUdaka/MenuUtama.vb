Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class MenuUtama
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Public combox As String
    Dim Proses As New ClsKoneksi

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

    Sub Data_Foto()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT * FROM pengguna WHERE USERNAME = '" & LabelUsername.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            PictureBox3.ImageLocation = RD("DESK")
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Conn.Close()
    End Sub

    Private Sub MenuUtama_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dim pesan
        'pesan = MsgBox("Anda Yakin Logout?", vbQuestion + vbYesNo)
        'If pesan = vbYes Then
        'e.Cancel = False
        'Login.Visible = True
        'ElseIf pesan = vbNo Then
        'e.Cancel = True
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        Dim pesan
        pesan = MsgBox("Logout", vbQuestion + vbYesNo)
        If pesan = vbYes Then
            Me.Close()
            Notifikasi.Close()
            NotifikasiJatuhTempo.Close()
            Login.Visible = True
            Login.Txtuser.Focus()
        End If
    End Sub

    Private Sub BtnHamburger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHamburger.Click
        If SideBar.Width = 250 Then
            SideBar.Width = 85
        Else
            SideBar.Width = 250
        End If
    End Sub

    Public Sub TampilForm(ByVal FormPanel As System.Object)
        If (Content.Controls.Count > 0) Then
            Content.Controls.RemoveAt(0)
            Dim fh As Form
            fh = FormPanel
            fh.TopLevel = False
            fh.Dock = DockStyle.Fill
            Content.Controls.Add(fh)
            Content.Tag = fh
            fh.Show()
        End If
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        DateTimePicker1.Visible = False
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMaximize.Click
        WindowState = FormWindowState.Maximized
        BtnNormal.Visible = True
        BtnMaximize.Visible = False
    End Sub

    Private Sub BtnNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNormal.Click
        WindowState = FormWindowState.Normal
        BtnMaximize.Visible = True
        BtnNormal.Visible = False
    End Sub

    Private Sub BtnStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatus.Click
        SideButton.Height = BtnStatus.Height
        SideButton.Top = BtnStatus.Top
        LblHeader.Text = "Informasi"
        Call TampilForm(New Stats)
    End Sub

    Private Sub BtnDataBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataBarang.Click
        SideButton.Height = BtnDataBarang.Height
        SideButton.Top = BtnDataBarang.Top
        LblHeader.Text = "Data Barang"
        Call TampilForm(New DataBarang)
    End Sub

    Private Sub BtnDataPelanggan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataPelanggan.Click
        SideButton.Height = BtnDataPelanggan.Height
        SideButton.Top = BtnDataPelanggan.Top
        LblHeader.Text = "Data Pelanggan"
        Call TampilForm(New DataPelanggan)
    End Sub

    Private Sub BtnDataSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataSupplier.Click
        SideButton.Height = BtnDataSupplier.Height
        SideButton.Top = BtnDataSupplier.Top
        LblHeader.Text = "Data Supplier"
        Call TampilForm(New DataSupplier)
    End Sub

    Private Sub BtnDataPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataPenjualan.Click
        SideButton.Height = BtnDataPenjualan.Height
        SideButton.Top = BtnDataPenjualan.Top
        LblHeader.Text = "Data Penjualan"
        Call TampilForm(New DataPenjualan)
    End Sub

    Private Sub BtnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPenjualan.Click
        SideButton.Height = BtnPenjualan.Height
        SideButton.Top = BtnPenjualan.Top
        LblHeader.Text = "Penjualan"
        Call TampilForm(New Penjualan)
    End Sub

    Private Sub BtnPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPembelian.Click
        SideButton.Height = BtnPembelian.Height
        SideButton.Top = BtnPembelian.Top
        LblHeader.Text = "Purchase Order"
        Call TampilForm(New Pembelian)
    End Sub

    Private Sub BtnDataPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataPembelian.Click
        SideButton.Height = BtnDataPembelian.Height
        SideButton.Top = BtnDataPembelian.Top
        LblHeader.Text = "Data Purchase Order"
        Call TampilForm(New DataPembelian)
    End Sub

    Private Sub BtnBarangMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBarangMasuk.Click
        SideButton.Height = BtnBarangMasuk.Height
        SideButton.Top = BtnBarangMasuk.Top
        LblHeader.Text = "Menu Barang Masuk"
        Call TampilForm(New MenuBarangMasuk)
    End Sub

    Private Sub BtnRetur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetur.Click
        SideButton.Height = BtnRetur.Height
        SideButton.Top = BtnRetur.Top
        LblHeader.Text = "Menu Retur"
        Call TampilForm(New MenuRetur)
    End Sub

    Private Sub BtnCatatanPembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCatatanPembayaran.Click
        SideButton.Height = BtnCatatanPembayaran.Height
        SideButton.Top = BtnCatatanPembayaran.Top
        LblHeader.Text = "Menu Catatan Pembayaran"
        Call TampilForm(New MenuCatatanPembayaran)
    End Sub

    Private Sub BtnStokOpname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStokOpname.Click
        SideButton.Height = BtnStokOpname.Height
        SideButton.Top = BtnStokOpname.Top
        LblHeader.Text = "Stok Opname"
        Call TampilForm(New DataStokOpname)
    End Sub

    Private Sub BtnAkunSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAkunSetting.Click
        KelolaAdmin.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Profile.TextKode.Text = LabelUsername.Text
        Profile.LabelUser.Text = LabelUsername.Text
        Profile.Show()
    End Sub

    Private Sub LabelNama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelNama.Click
        Profile.TextKode.Text = LabelUsername.Text
        Profile.LabelUser.Text = LabelUsername.Text
        Profile.Show()
    End Sub

    Private Sub LabelUsername_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelUsername.TextChanged
        Call Data_Foto()
    End Sub

    Private Sub BtnDataPendapatan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataPendapatan.Click
        SideButton.Height = BtnDataPendapatan.Height
        SideButton.Top = BtnDataPendapatan.Top
        LblHeader.Text = "Data Pendapatan"
        Call TampilForm(New DataPendapatan)
    End Sub
End Class