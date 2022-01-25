Imports MySql.Data.MySqlClient
Public Class TambahSupplier
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim supplier As New DataSupplier
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
        SQL = ("SELECT * FROM supplier WHERE ID_SUPPLIER IN(SELECT MAX(ID_SUPPLIER)FROM supplier)")
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            TextIDsup.Text = "SUP0001"
            RD.Close()
        End If

        If Not RD.HasRows Then
            TextIDsup.Text = "SUP" + "0001"
            RD.Close()

        Else
            TextIDsup.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("ID_SUPPLIER").ToString, 4)) + 1
            If Len(TextIDsup.Text) = 1 Then
                TextIDsup.Text = "SUP000" & TextIDsup.Text & ""
            ElseIf Len(TextIDsup.Text) = 2 Then
                TextIDsup.Text = "SUP00" & TextIDsup.Text & ""
            ElseIf Len(TextIDsup.Text) = 3 Then
                TextIDsup.Text = "SUP0" & TextIDsup.Text & ""
            ElseIf Len(TextIDsup.Text) = 4 Then
                TextIDsup.Text = "SUP" & TextIDsup.Text & ""
            End If

            RD.Close()

        End If
        Conn.Close()
    End Sub

    Private Sub TambahSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_Otomatis()
        TextIDsup.Enabled = False
    End Sub

    Private Sub BtnBatal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextIDsup.Text = "" Or
            TextNamaSup.Text = "" Or
            TextEmailSup.Text = "" Or
            TextTelpSup.Text = "" Or
            TextAlamatSup.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap!, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
            Exit Sub
        End If

        SQL = "INSERT INTO supplier VALUES ('" & TextIDsup.Text & "','" & TextNamaSup.Text & "','" & TextAlamatSup.Text & "','" & TextTelpSup.Text & "','" & TextEmailSup.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MsgBoxBerhasil.TextMsg.Text = "Data baru tersimpan"
        MsgBoxBerhasil.ShowDialog()
        'Dim supplier As DataSupplier = New DataSupplier()
        'supplier.Show()
        MenuUtama.TampilForm(New DataSupplier)

        TextIDsup.Clear()
        TextNamaSup.Clear()
        TextTelpSup.Clear()
        TextAlamatSup.Clear()
        TextEmailSup.Clear()

        Me.Close()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TambahSupplier_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub TextTelpSup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextTelpSup.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub
End Class