Imports MySql.Data.MySqlClient
Public Class UbahPassword
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pengguna As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Private Sub UbahPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextUser.Enabled = False
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub UbahPassword_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub TextPassLama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextPassLama.KeyPress
        If e.KeyChar = Chr(13) Then
            pengguna = Proses.ExecuteQuery("SELECT * FROM pengguna WHERE PASSWORD = MD5( '" & TextPassLama.Text & "' ) AND USERNAME = '" & TextUser.Text & "'")
            If pengguna.Rows.Count = 0 Then
                MsgBoxWarning.TextMsg.Text = "Password salah!"
                MsgBoxWarning.ShowDialog()
                TextPassLama.Focus()
                TextPassLama.Text = ""
            Else
                TextPassBaru.Focus()
            End If
        End If
    End Sub

    Private Sub TextPassBaru_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextPassBaru.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextPassBaru.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Password baru belum dibuat!"
                MsgBoxWarning.ShowDialog()
                TextPassBaru.Focus()
            Else
                TextPassConfirm.Focus()
            End If
        End If
    End Sub

    Private Sub TextPassConfirm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextPassConfirm.KeyPress
        Dim pesan As String
        If e.KeyChar = Chr(13) Then
            If TextPassBaru.Text <> TextPassConfirm.Text Then
                MessageBox.Show("Ulangi Password Konfirmasi!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextPassConfirm.Focus()
                TextPassConfirm.Clear()
            Else
                pesan = MsgBox("Ganti Password?", vbYesNo, "PERTANYAAN")
                If pesan = vbYes Then
                    SQL = "UPDATE pengguna SET PASSWORD = MD5('" & TextPassConfirm.Text & "') WHERE USERNAME = '" & TextUser.Text & "'"
                    Proses.ExecuteNonQuery(SQL)
                    MsgBoxBerhasil.TextMsg.Text = "Password sudah terubah"
                    MsgBoxBerhasil.ShowDialog()
                    Me.Close()
                    MenuUtama.Close()
                    Login.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        pengguna = Proses.ExecuteQuery("SELECT * FROM pengguna WHERE PASSWORD = MD5( '" & TextPassLama.Text & "' ) AND USERNAME = '" & TextUser.Text & "'")
        If pengguna.Rows.Count = 0 Then
            MsgBoxWarning.TextMsg.Text = "Password salah!"
            MsgBoxWarning.ShowDialog()
            TextPassLama.Focus()
            TextPassLama.Text = ""
        Else
            If TextPassBaru.Text <> TextPassConfirm.Text Then
                MessageBox.Show("Ulangi Password Konfirmasi!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextPassConfirm.Focus()
                TextPassConfirm.Clear()
            Else
                Dim pesan As String
                pesan = MsgBox("Ganti Password?", vbYesNo, "PERTANYAAN")
                If pesan = vbYes Then
                    SQL = "UPDATE pengguna SET PASSWORD = MD5('" & TextPassConfirm.Text & "') WHERE USERNAME = '" & TextUser.Text & "'"
                    Proses.ExecuteNonQuery(SQL)
                    MsgBoxBerhasil.TextMsg.Text = "Password sudah terubah"
                    MsgBoxBerhasil.ShowDialog()
                    Me.Close()
                    MenuUtama.Close()
                    Login.Visible = True
                End If
            End If
        End If
    End Sub
End Class