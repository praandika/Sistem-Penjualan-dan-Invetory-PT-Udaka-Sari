Public Class TambahAdmin
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Private Sub TambahAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
        KelolaAdmin.Show()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextUser.Text = "" Or
            TextPass.Text = "" Or
            TextDepan.Text = "" Or
            TextBelakang.Text = "" Or
            ComboBoxAkses.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Pastikan kolom tidak kosong!"
            MsgBoxWarning.ShowDialog()
        Else
            SQL = "INSERT INTO pengguna (USERNAME, PASSWORD, NAMA_DEPAN, NAMA_BELAKANG, HAK_AKSES) VALUES ('" & TextUser.Text & "',MD5('" & TextPass.Text & "'),'" & TextDepan.Text & "','" & TextBelakang.Text & "','" & ComboBoxAkses.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "Data baru tersimpan"
            MsgBoxBerhasil.ShowDialog()
            KelolaAdmin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub TambahAdmin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub
End Class