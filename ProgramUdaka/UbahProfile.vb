Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing
Public Class UbahProfile
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public PathFile As String = Nothing
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

    Sub Data_Foto()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT * FROM pengguna WHERE USERNAME = '" & TextUser.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            TextDesk.Text = RD("FOTO")
            TextAlamat.Text = RD("DESK")
            PictureBox2.ImageLocation = RD("DESK")
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Conn.Close()
    End Sub

    Private Sub UbahProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextUser.Enabled = False
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Profile.LabelUser.Text = TextUser.Text
        Profile.TextKode.Text = TextUser.Text
        Profile.Show()
        Me.Close()
    End Sub

    Private Sub UbahProfile_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFoto.Click
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|GIF FIles(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.Image = New Bitmap(OpenFileDialog1.FileName)
            PathFile = OpenFileDialog1.FileName
            TextDesk.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            TextAlamat.Text = OpenFileDialog1.FileName
            PictureBox2.Image = Image.FromFile(TextAlamat.Text)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox2.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextAlamat.Text = "" Or
            TextBelakang.Text = "" Or
            TextDepan.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data Belum Lengkap, Pastikan Semua FORM Terisi"
            MsgBoxWarning.BackColor = Color.FromArgb(250, 250, 250)
            MsgBoxWarning.Label1.ForeColor = Color.FromArgb(150, 150, 150)
            MsgBoxWarning.TextMsg.ForeColor = Color.FromArgb(150, 150, 150)
            MsgBoxWarning.TextMsg.BackColor = Color.FromArgb(250, 250, 250)
            MsgBoxWarning.ShowDialog()
        Else
            Try
                Call Koneksi()
                SQL = "UPDATE `pengguna` SET `NAMA_DEPAN`=@nd,`NAMA_BELAKANG`=@nb,`DESK`=@desk,`FOTO`=@foto WHERE `USERNAME`=@ID"
                CMD = New MySqlCommand(SQL, Conn)
                With CMD.Parameters
                    .Add("@nd", MySqlDbType.VarChar, 30).Value = TextDepan.Text.Trim
                    .Add("@nb", MySqlDbType.VarChar, 50).Value = TextBelakang.Text.Trim
                    .Add("@desk", MySqlDbType.VarChar, 255).Value = TextAlamat.Text.Trim
                    .Add("@foto", MySqlDbType.VarChar, 255).Value = TextDesk.Text.Trim
                    .Add("@ID", MySqlDbType.VarChar, 20).Value = TextUser.Text.Trim
                End With
                CMD.ExecuteNonQuery()
                CMD = Nothing
                MsgBoxBerhasil.TextMsg.Text = "Data profil sudah terubah"
                MsgBoxBerhasil.BackColor = Color.FromArgb(250, 250, 250)
                MsgBoxBerhasil.Label1.ForeColor = Color.FromArgb(150, 150, 150)
                MsgBoxBerhasil.TextMsg.ForeColor = Color.FromArgb(150, 150, 150)
                MsgBoxBerhasil.TextMsg.BackColor = Color.FromArgb(250, 250, 250)
                MsgBoxBerhasil.ShowDialog()
                Me.Close()
                MenuUtama.Close()
                Notifikasi.Close()
                NotifikasiJatuhTempo.Close()
                Login.Visible = True
                Login.Txtuser.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextUser.TextChanged
        Call Data_Foto()
    End Sub
End Class