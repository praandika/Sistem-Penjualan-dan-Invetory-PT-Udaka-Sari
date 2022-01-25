Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Profile
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
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
        SQL = "SELECT * FROM pengguna WHERE USERNAME = '" & LabelUser.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            LabelDepan.Text = RD("NAMA_DEPAN")
            LabelBelakang.Text = RD("NAMA_BELAKANG")
            LabelAkses.Text = RD("HAK_AKSES")
            PictureBox2.ImageLocation = RD("DESK")
            'PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Conn.Close()
    End Sub

    Private Sub Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Textbox()
        Call Koneksi()
        TextKode.Visible = False
    End Sub

    Private Sub Profile_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPass.Click
        UbahPassword.TextUser.Text = LabelUser.Text
        UbahPassword.Show()
        Me.Close()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        UbahProfile.TextDepan.Text = LabelDepan.Text
        UbahProfile.TextBelakang.Text = LabelBelakang.Text
        UbahProfile.TextUser.Text = LabelUser.Text
        UbahProfile.Show()
        Me.Close()
    End Sub

    Private Sub TextKode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextKode.TextChanged
        Call Data_Textbox()
    End Sub
End Class