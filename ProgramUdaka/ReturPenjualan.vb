Imports MySql.Data.MySqlClient
Public Class ReturPenjualan
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim returjual As DataTable
    Dim txt1, txt2, txt3 As Long
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

    Sub Data_Record()
        returjual = Proses.ExecuteQuery("SELECT transaksi.ID_BARANG, barang.NAMA_BARANG, transaksi.HARGA_BARANG, transaksi.BISA_RETUR AS QTY, transaksi.TOTAL_HARGA, transaksi.ID_TRANSAKSI FROM transaksi INNER JOIN barang ON barang.ID_BARANG = transaksi.ID_BARANG WHERE NO_NOTA = '" & LabelNota.Text & "'")
        DGReturPenjualan.DataSource = returjual
        DGReturPenjualan.Columns(0).Width = 100
        DGReturPenjualan.Columns(1).Width = 150
        DGReturPenjualan.Columns(2).Width = 150
        DGReturPenjualan.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGReturPenjualan.Columns(3).Width = 35
        DGReturPenjualan.Columns(4).Width = 150
        DGReturPenjualan.Columns(4).DefaultCellStyle.Format = "###,###,###"
        DGReturPenjualan.Columns(5).Width = 100
    End Sub

    Sub Data_Textbox()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT *, pelanggan.NAMA_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.NO_NOTA = '" & LabelNota.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            'TextDurasiKredit.Text = RD("DURASI_KREDIT")
            TextTotal.Text = RD("GRAND_TOTAL")
            TextBayar.Text = RD("BAYAR")
            LabelStatus.Text = RD("STATUS_TRANSAKSI")
            LabelTgl.Text = RD("TGL_TRANSAKSI")
            LabelSisa.Text = RD("SISA_TAGIHAN")
            LabelNamaPel.Text = RD("NAMA_PELANGGAN")
        End If
        Conn.Close()
    End Sub

    Sub Kode_Otomatis()
        Dim returjual As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM retur_penjualan"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            returjual = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(returjual))
            Case 1 : TextKodeRetur.Text = "RJ.000" + Trim(Str(returjual)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextKodeRetur.Text = "RJ.00" + Trim(Str(returjual)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextKodeRetur.Text = "RJ.0" + Trim(Str(returjual)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextKodeRetur.Text = "RJ." + Trim(Str(returjual)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Public Sub Hitung_Retur()
        Dim total, bayar, qty, qtyretur, totalretur, sisa, hargabarang As Integer
        hargabarang = Val(TextHarga.Text)
        qtyretur = Val(TextQTYRetur.Text)
        total = Val(TextTotal.Text)
        bayar = Val(TextBayar.Text)
        sisa = Val(TextSisa.Text)
        qty = Val(LabelQTY.Text)
        If qtyretur > qty Then
            MsgBoxWarning.TextMsg.Text = "Retur melebihi kuantitas"
            MsgBoxWarning.ShowDialog()
            TextQTYRetur.Clear()
        Else
            totalretur = qtyretur * hargabarang
            TextTotalRetur.Text = totalretur
            LabelTotalRetur.Text = TextTotalRetur.Text
        End If
    End Sub

    Sub Hitung_Bisa_Retur()
        Dim retur, bisa, hasil As Integer
        retur = Val(TextQTYRetur.Text)
        bisa = Val(TextBisaRetur.Text)
        If retur > bisa Then
            MsgBoxWarning.TextMsg.Text = "Retur melebihi kuantitas!"
            MsgBoxWarning.ShowDialog()
        Else
            hasil = bisa - retur
            TextBisaRetur.Text = hasil
        End If
    End Sub

    Private Sub ReturPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_Otomatis()
        Call Data_Textbox()
        Call Data_Record()
        TextKodePenjualan.Visible = False
        TextKodePel.Visible = False
        TextKodeBrg.Visible = False
        TextHarga.Visible = False
        TextSisa.Visible = False
        TextTotalRetur.Visible = False
        TextKet.Visible = False
        TextKodeRetur.Visible = False
        TextTotal.Visible = False
        TextBayar.Visible = False
        TextStatusRetur.Visible = False
        DateTimePicker1.Enabled = False
        
        TextKet.Text = "Tukar Barang"
        TextStatusRetur.Text = "Ditunda"
        TextTotalRetur.Text = "0"
        TextHarga.Text = "0"
        LabelSisa.Text = TextSisa.Text
        LabelTotalRetur.Text = TextTotalRetur.Text
        LabelHrgBrg.Text = TextHarga.Text
        If LabelStatus.Text = "LUNAS" Then
            BtnSimpan.Enabled = True
        Else
            BtnSimpan.Enabled = False
            BtnSimpan.BackColor = Color.Gray
        End If
    End Sub

    Private Sub ReturPenjualan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DGReturPenjualan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGReturPenjualan.CellClick
        Dim baris As Integer
        With DGReturPenjualan
            baris = .CurrentRow.Index
            TextKodeBrg.Text = .Item(0, baris).Value
            LabelNamaBrg.Text = .Item(1, baris).Value
            LabelHrgBrg.Text = .Item(2, baris).Value
            LabelQTY.Text = .Item(3, baris).Value
            TextHarga.Text = .Item(2, baris).Value
            TextBisaRetur.Text = .Item(3, baris).Value
            TextDetail.Text = .Item(5, baris).Value
        End With
    End Sub

    Private Sub LabelSisa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelSisa.TextChanged
        txt2 = LabelSisa.Text
        LabelSisa.Text = Format(Val(txt2), "###,###,0")
        'TextSisaTagihan.SelectionStart = Len(TextSisaTagihan.Text)
    End Sub

    Private Sub LabelHrgBrg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelHrgBrg.TextChanged
        txt1 = LabelHrgBrg.Text
        LabelHrgBrg.Text = Format(Val(txt1), "###,###,0")
    End Sub

    Private Sub LabelTotalRetur_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelTotalRetur.TextChanged
        txt3 = LabelTotalRetur.Text
        LabelTotalRetur.Text = Format(Val(txt3), "###,###,0")
    End Sub

    Private Sub TextQTYRetur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextQTYRetur.TextChanged
        Call Hitung_Retur()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If RichTextBox1.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Lengkapi alasan retur!"
            MsgBoxWarning.ShowDialog()
        Else
            Call Hitung_Bisa_Retur()
            SQL = "INSERT INTO retur_penjualan VALUES ('" & TextKodeRetur.Text & "','" & TextKodeBrg.Text & "','" & TextKodePel.Text & "','" & TextKodePenjualan.Text & "','" & LabelNota.Text & "','" & LabelQTY.Text & "','" & TextQTYRetur.Text & "','" & TextTotalRetur.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & RichTextBox1.Text & "','" & TextKet.Text & "','" & TextStatusRetur.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            SQL = "UPDATE transaksi SET BISA_RETUR = '" & TextBisaRetur.Text & "' WHERE ID_TRANSAKSI = '" & TextDetail.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "Data retur sudah tersimpan"
            MsgBoxBerhasil.ShowDialog()
            Call Kode_Otomatis()
            Call Data_Record()
            TextQTYRetur.Clear()
            RichTextBox1.Clear()
        End If
    End Sub
End Class