Imports MySql.Data.MySqlClient
Public Class TambahBarang
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL, CEK As String
    Dim Proses As New ClsKoneksi
    Dim txt1, txt2 As Long
    'Dim barang As New DataBarang
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
        SQL = ("SELECT * FROM barang WHERE ID_BARANG IN(SELECT MAX(ID_BARANG)FROM barang)")
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            TextKode.Text = "BRG0001"
            RD.Close()
        End If

        If Not RD.HasRows Then
            TextKode.Text = "BRG" + "0001"
            RD.Close()

        Else
            TextKode.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("ID_BARANG").ToString, 4)) + 1
            If Len(TextKode.Text) = 1 Then
                TextKode.Text = "BRG000" & TextKode.Text & ""
            ElseIf Len(TextKode.Text) = 2 Then
                TextKode.Text = "BRG00" & TextKode.Text & ""
            ElseIf Len(TextKode.Text) = 3 Then
                TextKode.Text = "BRG0" & TextKode.Text & ""
            ElseIf Len(TextKode.Text) = 4 Then
                TextKode.Text = "BRG" & TextKode.Text & ""
            End If

            RD.Close()

        End If
        Conn.Close()
    End Sub

    Private Sub TambahBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_Otomatis()
        TextStok.Text = "0"
        TextMin.Text = "10"
        TextStok.Visible = False
        TextMin.Visible = False
        TextKode.Enabled = False
    End Sub

    Private Sub TambahBarang_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextKode.Text = "" Or
            TextNama.Text = "" Or
            ComboxJenis.Text = "" Or
            TextHrgBeli.Text = "" Or
            TextHrgJual.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap!, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
            Exit Sub
        End If

        Call Koneksi()
        CEK = ("SELECT NAMA_BARANG FROM barang WHERE NAMA_BARANG = '" & TextNama.Text & "'")
        CMD = New MySqlCommand(CEK, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            SQL = "INSERT INTO barang VALUES ('" & TextKode.Text & "','" & TextNama.Text & "','" & ComboxJenis.Text & "','" & CLng(TextHrgBeli.Text) & "','" & CLng(TextHrgJual.Text) & "','" & TextStok.Text & "','" & TextMin.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "Data baru tersimpan"
            MsgBoxBerhasil.ShowDialog()
            'Dim barang As DataBarang = New DataBarang()
            'barang.Show()
            TextKode.Clear()
            TextNama.Clear()
            ComboxJenis.Text = ""
            TextHrgBeli.Clear()
            TextHrgJual.Clear()
            Call MenuUtama.TampilForm(New DataBarang)
            Me.Close()
            RD.Close()
        Else
            MsgBoxWarning.TextMsg.Text = "Nama barang sudah ada!"
            MsgBoxWarning.ShowDialog()
            RD.Close()
        End If
        Conn.Close()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextHrgBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextHrgBeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub TextHrgBeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextHrgBeli.TextChanged
        If TextHrgBeli.Text = "" Or Not IsNumeric(TextHrgBeli.Text) Then
            Exit Sub
        End If
        txt1 = TextHrgBeli.Text
        TextHrgBeli.Text = Format(Val(txt1), "###,###")
        TextHrgBeli.SelectionStart = Len(TextHrgBeli.Text)
    End Sub

    Private Sub TextHrgJual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextHrgJual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBoxWarning.TextMsg.Text = "Data harus angka!"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub TextHrgJual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextHrgJual.TextChanged
        If TextHrgJual.Text = "" Or Not IsNumeric(TextHrgJual.Text) Then
            Exit Sub
        End If
        txt2 = TextHrgJual.Text
        TextHrgJual.Text = Format(Val(txt2), "###,###")
        TextHrgJual.SelectionStart = Len(TextHrgJual.Text)
    End Sub

    Private Sub CheckBoxStok_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxStok.CheckedChanged
        If CheckBoxStok.Checked = True Then
            TextStok.Visible = True
        Else
            TextStok.Visible = False
        End If
    End Sub

    Private Sub CheckBoxMin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMin.CheckedChanged
        If CheckBoxMin.Checked = True Then
            TextMin.Visible = True
        Else
            TextMin.Visible = False
        End If
    End Sub
End Class