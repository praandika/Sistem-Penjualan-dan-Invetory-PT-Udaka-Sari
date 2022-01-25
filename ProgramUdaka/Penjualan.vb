Imports MySql.Data.MySqlClient
Public Class Penjualan
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL, txtppn As String
    Dim penjualan As DataTable
    Dim Proses As New ClsKoneksi
    Dim txt1, txt2, txt3, txt4 As Long
    Dim hasildiskon As Integer
    Public confirm As Boolean = False

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
        penjualan = Proses.ExecuteQuery("SELECT transaksi.NO_NOTA, transaksi.TGL_TRANSAKSI, transaksi.ID_PELANGGAN, pelanggan.NAMA_PELANGGAN, transaksi.ID_BARANG, barang.NAMA_BARANG, transaksi.HARGA_BARANG, transaksi.QTY, transaksi.TOTAL_HARGA, barang.STOK_BARANG, transaksi.ID_TRANSAKSI FROM transaksi INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = transaksi.ID_PELANGGAN INNER JOIN barang ON barang.ID_BARANG = transaksi.ID_BARANG WHERE transaksi.NO_NOTA = '" & TextNota.Text & "'")
        DGTransaksi.DataSource = penjualan
        DGTransaksi.Columns(0).Width = 100
        DGTransaksi.Columns(1).Width = 100
        DGTransaksi.Columns(2).Width = 100
        DGTransaksi.Columns(3).Width = 100
        DGTransaksi.Columns(4).Width = 100
        DGTransaksi.Columns(5).Width = 100
        DGTransaksi.Columns(6).Width = 100
        DGTransaksi.Columns(6).DefaultCellStyle.Format = "###,###,###"
        DGTransaksi.Columns(7).Width = 100
        DGTransaksi.Columns(8).Width = 100
        DGTransaksi.Columns(8).DefaultCellStyle.Format = "###,###,###"
        DGTransaksi.Columns(9).Width = 100
        DGTransaksi.Columns(10).Width = 100
    End Sub

    Sub Hitung_Total()
        Dim grand As Integer
        For baris As Integer = 0 To DGTransaksi.RowCount - 1
            grand = grand + DGTransaksi.Rows(baris).Cells(8).Value
            TextGrandTotal.Text = Format(Val(grand), "Rp, ###,###,###")
            TextGrandVisible.Text = grand
            hasildiskon = grand
        Next
    End Sub

    Sub ppn()
        Dim total, hasil, ppn As Long
        total = Val(TextGrandVisible.Text)
        hasil = total * 0.1
        ppn = total + hasil
        TextGrandTotal.Text = Format(Val(ppn), "Rp, ###,###,###")
        TextHasilPPN.Text = ppn
        hasildiskon = ppn
    End Sub

    Sub HitungDiskon()
        Dim harga_awal, harga_akhir, diskon, hasil As Integer
        If ComboxJenisBayar.Text = "CASH" Then
            harga_awal = TextBayar.Text
            diskon = TextDisc.Text
            harga_akhir = (diskon / 100) * harga_awal
            hasil = harga_awal - harga_akhir
            TextBayar.Text = hasil
            hasildiskon = hasil
            TextGrandTotal.Text = Format(Val(hasil), "Rp, ###,###,###")
        ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
            harga_awal = TextSisaTagihan.Text
            diskon = TextDisc.Text
            harga_akhir = (diskon / 100) * harga_awal
            hasil = harga_awal - harga_akhir
            TextSisaTagihan.Text = hasil
            hasildiskon = hasil
            TextGrandTotal.Text = Format(Val(hasil), "Rp, ###,###,###")
        End If
    End Sub

    'Sub minimumDP()
    'Dim DP As Integer
    'If ComboxJenisBayar.Text = "ANGSURAN" Then
    'If CBPajak.Checked = True Then
    'DP = TextHasilPPN.Text * (20 / 100)
    'TextBayar.Text = DP
    'TextSisaTagihan.Text = hasildiskon - TextBayar.Text
    'Else
    'DP = TextGrandVisible.Text * (20 / 100)
    'TextBayar.Text = DP
    'TextSisaTagihan.Text = hasildiskon - TextBayar.Text
    'End If
    'End If
    'End Sub

    Sub Hapus_Total()
        Dim jumlah, harga As Integer
        jumlah = Val(TextGrandVisible.Text)
        harga = Val(TextHargaVisible.Text)
        jumlah = jumlah - harga
        TextGrandVisible.Text = jumlah
        TextGrandTotal.Text = Format(Val(jumlah), "Rp, ###,###,###")
    End Sub

    Sub Kode_Sales()
        Dim sales As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM penjualan"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            sales = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(sales))
            Case 1 : TextSalesID.Text = "SL.000" + Trim(Str(sales)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextSalesID.Text = "SL.00" + Trim(Str(sales)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextSalesID.Text = "SL.0" + Trim(Str(sales)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextSalesID.Text = "SL." + Trim(Str(sales)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Kode_Nota()
        Dim nota As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM transaksi"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            nota = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(nota))
            Case 1 : TextNota.Text = "No.000" + Trim(Str(nota)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextNota.Text = "No.00" + Trim(Str(nota)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextNota.Text = "No.0" + Trim(Str(nota)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextNota.Text = "No." + Trim(Str(nota)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Kode_Transaksi()
        Dim id As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JML FROM transaksi"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            id = Val(RD.Item("JML").ToString) + 1
        End While
        Select Case Len(Trim(id))
            Case 1 : TextKodeTransaksi.Text = "TR.000" + Trim(Str(id)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextKodeTransaksi.Text = "TR.00" + Trim(Str(id)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextKodeTransaksi.Text = "TR.0" + Trim(Str(id)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextKodeTransaksi.Text = "TR." + Trim(Str(id)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Hitung_Piutang()
        If CBPajak.Checked = True Then
            If ComboxJenisBayar.Text = "CASH" Then
                TextSisaTagihan.Text = "0"
                TextBayar.Text = TextHasilPPN.Text
                TextSttsTrans.Text = "LUNAS"
                TextBayar.Enabled = False
                TextSisaTagihan.Enabled = False
                BtnReset.Enabled = False
                BtnReset.BackColor = Color.Gray
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                TextSisaTagihan.Text = TextHasilPPN.Text
                TextSttsTrans.Text = "UTANG"
                TextBayar.Enabled = True
                TextSisaTagihan.Enabled = False
                BtnReset.Enabled = True
                BtnReset.BackColor = Color.DarkRed
                TextBayar.Clear()
            End If
        Else
            If ComboxJenisBayar.Text = "CASH" Then
                TextSisaTagihan.Text = "0"
                TextBayar.Text = TextGrandVisible.Text
                TextSttsTrans.Text = "LUNAS"
                TextBayar.Enabled = False
                TextSisaTagihan.Enabled = False
                BtnReset.Enabled = False
                BtnReset.BackColor = Color.Gray
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                TextSisaTagihan.Text = TextGrandVisible.Text
                TextSttsTrans.Text = "UTANG"
                TextBayar.Enabled = True
                TextSisaTagihan.Enabled = False
                BtnReset.Enabled = True
                BtnReset.BackColor = Color.DarkRed
                TextBayar.Clear()
            End If
        End If
    End Sub

    Private Sub TextHarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextHarga.TextChanged
        If TextHarga.Text = "" Or Not IsNumeric(TextHarga.Text) Then
            Exit Sub
        End If
        txt1 = TextHarga.Text
        TextHarga.Text = Format(Val(txt1), "###,###")
        TextHarga.SelectionStart = Len(TextHarga.Text)
    End Sub

    Private Sub TextTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTotal.TextChanged
        If TextTotal.Text = "" Or Not IsNumeric(TextTotal.Text) Then
            Exit Sub
        End If

        txt2 = TextTotal.Text
        TextTotal.Text = Format(Val(txt2), "###,###")
        TextTotal.SelectionStart = Len(TextTotal.Text)
    End Sub

    Private Sub TextBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBayar.TextChanged
        If TextBayar.Text = "" Or Not IsNumeric(TextBayar.Text) Then
            Exit Sub
        End If
        txt3 = TextBayar.Text
        TextBayar.Text = Format(Val(txt3), "###,###")
        TextBayar.SelectionStart = Len(TextBayar.Text)

        If TextBayar.Text = "" Then
            If CBPajak.Checked = True Then
                TextSisaTagihan.Text = TextHasilPPN.Text
            Else
                TextSisaTagihan.Text = TextGrandVisible.Text
            End If
        Else
            If CBPajak.Checked = True Then
                TextSisaTagihan.Text = hasildiskon - TextBayar.Text
                If TextBayar.Text = hasildiskon Then
                    TextSttsTrans.Text = "LUNAS"
                    ComboxJenisBayar.Text = "CASH"
                End If
            Else
                TextSisaTagihan.Text = hasildiskon - TextBayar.Text
                If TextBayar.Text = hasildiskon Then
                    TextSttsTrans.Text = "LUNAS"
                    ComboxJenisBayar.Text = "CASH"
                End If
            End If
        End If

    End Sub

    Private Sub TextSisaTagihan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextSisaTagihan.TextChanged
        If TextSisaTagihan.Text = "" Or Not IsNumeric(TextSisaTagihan.Text) Then
            Exit Sub
        End If
        If ComboxJenisBayar.Text = "CASH" Then
            TextSisaTagihan.Text = "0"
        Else
            txt4 = TextSisaTagihan.Text
            TextSisaTagihan.Text = Format(Val(txt4), "###,###")
            TextSisaTagihan.SelectionStart = Len(TextSisaTagihan.Text)
        End If
    End Sub

    Private Sub Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextDisc.Text = 0
        txtppn = "-"
        Call Kode_Sales()
        Call Kode_Nota()
        Call Kode_Transaksi()
        'Call DataComboxPelanggan()
        'Call DataComboxBarang()
        'Call AutoComPelanggan()
        'Call AutoComBarang()
        Call Hitung_Total()
        Call Data_Record()
        TextOut.Visible = False
        TextHrgBrgVisible.Visible = False
        TextHasilPPN.Visible = False
        TextGrandVisible.Visible = False
        TextKodeTransaksiVisible.Visible = False
        TextHargaVisible.Visible = False
        TextKodeTransaksi.Enabled = False
        TextSalesID.Enabled = False
        TextNota.Enabled = False
        TextIDcus.Enabled = False
        TextIDbrg.Enabled = False
        TextStok.Enabled = False
        TextSttsTrans.Enabled = False
        TextOut.Enabled = False
        TextSttsTrans.Enabled = False
        BtnHapus.Enabled = False
        BtnHapus.BackColor = Color.Gray
        BtnSimpan.Enabled = False
        BtnSimpan.BackColor = Color.Gray
    End Sub

    'Private Sub ComboxBrg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboxBrg.SelectedIndexChanged
    'Call TampilRincianBarang()
    'End Sub

    'Private Sub ComboxCus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboxCus.SelectedIndexChanged
    'Call TampilIDCus()
    'End Sub

    Private Sub TextHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextHarga.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub TextGrandTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextGrandTotal.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub TextPiutang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = Chr(0)
    End Sub

    Private Sub ComboxJenisBayar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboxJenisBayar.KeyDown
        If e.KeyCode = Keys.Enter Or Keys.Tab Then
            DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub ComboxJenisBayar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboxJenisBayar.SelectedIndexChanged
        Call Hitung_Piutang()
        'Call minimumDP()
    End Sub

    Private Sub TextHarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextHarga.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextQTY.Focus()
        End If
    End Sub

    Private Sub TextTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextTotal.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If TextNota.Text = "" Or
            TextPel.Text = "" Or
            TextIDcus.Text = "" Or
            TextBrgJual.Text = "" Or
            TextIDbrg.Text = "" Or
            TextHarga.Text = "" Or
            TextQTY.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
        End If

        TextStok.Text = TextStok.Text - TextQTY.Text
        If TextStok.Text <= 0 Then
            MsgBoxWarning.TextMsg.Text = "Stok tidak memadai!"
            MsgBoxWarning.ShowDialog()
        Else

            Call Hitung_Total()
            'SQL = "UPDATE barang SET STOK_BARANG = '" & TextStok.Text & "' WHERE ID_BARANG = '" & TextIDbrg.Text & "'"
            'Proses.ExecuteNonQuery(SQL)

            SQL = "INSERT INTO transaksi VALUES ('" & TextIDbrg.Text & "','" & TextIDcus.Text & "','" & TextKodeTransaksi.Text & "','" & TextNota.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & CLng(TextHarga.Text) & "','" & TextQTY.Text & "','" & TextQTY.Text & "','" & CLng(TextTotal.Text) & "',0)"
            Proses.ExecuteNonQuery(SQL)
            SQL = "INSERT INTO barang_detail VALUES ('" & TextIDbrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Penjualan barang dengan nota " & TextNota.Text & "','0','" & TextQTY.Text & "','" & MenuUtama.LabelUsername.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            Call Data_Record()
            Call Hitung_Total()
            Call Kode_Transaksi()
            TextHarga.Clear()
            TextQTY.Clear()
            TextTotal.Clear()
            TextBrgJual.Clear()
            TextHrgBrgVisible.Clear()
            TextStok.Clear()
            BtnSimpan.Enabled = True
            BtnSimpan.BackColor = Color.ForestGreen
        End If
    End Sub

    Private Sub DGTransaksi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGTransaksi.Click
        Dim baris As Integer
        With DGTransaksi
            baris = .CurrentRow.Index
            TextKodeTransaksiVisible.Text = .Item(10, baris).Value
            TextIDbrg.Text = .Item(4, baris).Value
            TextBrgJual.Text = .Item(5, baris).Value
            TextOut.Text = .Item(7, baris).Value
            TextStok.Text = .Item(9, baris).Value
            TextHargaVisible.Text = .Item(8, baris).Value

            If TextKodeTransaksiVisible.Text = .Item(10, baris).Value Then
                BtnHapus.Enabled = True
                BtnHapus.BackColor = Color.DarkRed
            End If
        End With
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        'Konfirmasi.TextIDbrg.Text = TextIDbrg.Text
        'Konfirmasi.TextKodeTransaksiVisible.Text = TextKodeTransaksiVisible.Text
        'Konfirmasi.TextOut.Text = TextOut.Text
        'Konfirmasi.TextStok.Text = TextStok.Text
        'Konfirmasi.ShowDialog()
        If DGTransaksi.CurrentRow.Index <> DGTransaksi.NewRowIndex Then
            If TextOut.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Barang belum dipilih!, silahkan pilih barang"
                MsgBoxWarning.ShowDialog()
            Else
                If confirm = True Then
                    Dim stok, out As Integer
                    stok = Val(TextStok.Text)
                    out = Val(TextOut.Text)
                    stok = out + stok
                    TextStok.Text = stok

                    'SQL = "UPDATE barang SET STOK_BARANG = '" & TextStok.Text & "' WHERE ID_BARANG = '" & TextIDbrg.Text & "'"
                    'Proses.ExecuteNonQuery(SQL)

                    SQL = "DELETE FROM transaksi WHERE ID_TRANSAKSI = '" & TextKodeTransaksiVisible.Text & "'"
                    Proses.ExecuteNonQuery(SQL)
                    'Call Kode_Nota()
                    SQL = "INSERT INTO barang_detail VALUES ('" & TextIDbrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Barang dihapus dari nota penjualan " & TextNota.Text & "','" & TextOut.Text & "','0','" & MenuUtama.LabelUsername.Text & "')"
                    Proses.ExecuteNonQuery(SQL)
                    MsgBoxBerhasil.TextMsg.Text = "Transaksi sudah dibatalkan, transaksi dihapus"
                    MsgBoxBerhasil.ShowDialog()
                    DGTransaksi.Rows.RemoveAt(DGTransaksi.CurrentRow.Index)
                    BtnHapus.Enabled = False
                    BtnHapus.BackColor = Color.Gray
                    Call Hapus_Total()
                    TextOut.Clear()
                    Call Data_Record()
                    Call Kode_Transaksi()
                    TextKodeTransaksiVisible.Clear()
                    ComboxJenisBayar.Text = ""
                    TextBayar.Clear()
                    TextSisaTagihan.Clear()
                    TextSttsTrans.Clear()
                Else
                    Konfirmasi.LblUser.Text = MenuUtama.LabelUsername.Text
                    Konfirmasi.Show()
                    Konfirmasi.TextPass.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If ComboxJenisBayar.Text = "" Or
            TextBayar.Text = "" Or
            TextSisaTagihan.Text = "" Or
            TextSttsTrans.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data pembayaran belum lengkap"
            MsgBoxWarning.ShowDialog()
        Else
            If ComboxJenisBayar.Text = "ANGSURAN" Then
                If TextSisaTagihan.Text < 0 Then
                    MsgBoxWarning.TextMsg.Text = "Pembayaran melebihi tagihan"
                    MsgBoxWarning.ShowDialog()
                Else
                    SQL = "INSERT INTO penjualan VALUES ('" & TextSalesID.Text & "','" & TextIDcus.Text & "','" & TextNota.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & ComboxJenisBayar.Text & "','" & hasildiskon & "','" & txtppn & "','" & TextDisc.Text & "%','" & CLng(TextBayar.Text) & "','" & CLng(TextSisaTagihan.Text) & "','" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "','" & TextSttsTrans.Text & "')"
                    Proses.ExecuteNonQuery(SQL)
                    MsgBoxBerhasil.TextMsg.Text = "Data penjualan sudah disimpan"
                    MsgBoxBerhasil.ShowDialog()
                    Call Kode_Sales()

                    TextIDcus.Clear()
                    TextIDbrg.Clear()
                    TextBrgJual.Clear()
                    TextStok.Clear()
                    TextHarga.Clear()
                    TextQTY.Clear()
                    TextGrandTotal.Clear()
                    TextBayar.Clear()
                    TextSisaTagihan.Clear()
                    ComboxJenisBayar.Text = ""
                    TextSttsTrans.Clear()
                    TextTotal.Clear()

                    FormNota.CRViewNota.ReportSource = "ReportNota.rpt"
                    FormNota.CRViewNota.SelectionFormula = "{penjualan1.NO_NOTA} = '" + TextNota.Text + "' AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "' "
                    FormNota.CRViewNota.RefreshReport()
                    FormNota.ShowDialog()
                    Call Kode_Nota()
                    Call Data_Record()
                End If
            Else
                SQL = "INSERT INTO penjualan VALUES ('" & TextSalesID.Text & "','" & TextIDcus.Text & "','" & TextNota.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & ComboxJenisBayar.Text & "','" & hasildiskon & "','" & txtppn & "','" & TextDisc.Text & " %','" & CLng(TextBayar.Text) & "','" & CLng(TextSisaTagihan.Text) & "','" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "','" & TextSttsTrans.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBoxBerhasil.TextMsg.Text = "Data penjualan sudah disimpan"
                MsgBoxBerhasil.ShowDialog()
                Call Kode_Sales()

                TextIDcus.Clear()
                TextIDbrg.Clear()
                TextBrgJual.Clear()
                TextStok.Clear()
                TextHarga.Clear()
                TextQTY.Clear()
                TextGrandTotal.Clear()
                TextBayar.Clear()
                TextSisaTagihan.Clear()
                ComboxJenisBayar.Text = ""
                TextSttsTrans.Clear()
                TextTotal.Clear()

                FormNota.CRViewNota.ReportSource = "ReportNota.rpt"
                FormNota.CRViewNota.SelectionFormula = "{penjualan1.NO_NOTA} = '" + TextNota.Text + "' AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "' "
                FormNota.CRViewNota.RefreshReport()
                FormNota.ShowDialog()
                Call Kode_Nota()
                Call Data_Record()
            End If

        End If
    End Sub

    Private Sub BtnCariPel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariPel.Click
        CariPelangganPenjualan.Show()
    End Sub

    Private Sub TextPel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextPel.KeyPress
        CariPelangganPenjualan.Show()
    End Sub

    Private Sub TextPel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextPel.MouseDown
        CariPelangganPenjualan.Show()
    End Sub

    Private Sub BtnCariBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariBarang.Click
        CariBarangPenjualan.Show()
    End Sub

    Private Sub TextBrgJual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBrgJual.KeyPress
        CariBarangPenjualan.Show()
    End Sub

    Private Sub TextBrgJual_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBrgJual.MouseDown
        CariBarangPenjualan.Show()
    End Sub

    Private Sub CBPajak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPajak.CheckedChanged
        If CBPajak.Checked = True Then
            Call ppn()
            'Call minimumDP()
            If ComboxJenisBayar.Text = "CASH" Then
                TextBayar.Text = TextHasilPPN.Text
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                TextSisaTagihan.Text = TextHasilPPN.Text
                'TextSisaTagihan.Text = hasildiskon - TextBayar.Text
            End If
            txtppn = "PPN 10%"
        Else
            Call Hitung_Total()
            'Call minimumDP()
            If ComboxJenisBayar.Text = "CASH" Then
                TextBayar.Text = TextGrandVisible.Text
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                TextSisaTagihan.Text = TextGrandVisible.Text
                'TextSisaTagihan.Text = hasildiskon - TextBayar.Text
            End If
            txtppn = "0%"
        End If
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        If CBPajak.Checked = True Then
            TextSisaTagihan.Clear()
            TextSisaTagihan.Text = hasildiskon
            TextBayar.Clear()
        Else
            TextSisaTagihan.Clear()
            TextSisaTagihan.Text = hasildiskon
            TextBayar.Clear()
        End If
    End Sub

    Private Sub TextDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextDisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call HitungDiskon()
        End If
    End Sub

    Private Sub BtnHitungDiskon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitungDiskon.Click
        Call HitungDiskon()
    End Sub

    Private Sub TextDisc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextDisc.TextChanged
        
        Dim bayar, sisa As Integer
        If TextDisc.Text = "" Then
            If ComboxJenisBayar.Text = "CASH" Then
                If CBPajak.Checked = True Then
                    TextBayar.Text = TextHasilPPN.Text
                    bayar = TextBayar.Text
                    TextGrandTotal.Text = Format(Val(bayar), "Rp, ###,###,###")
                Else
                    TextBayar.Text = TextGrandVisible.Text
                    bayar = TextBayar.Text
                    TextGrandTotal.Text = Format(Val(bayar), "Rp, ###,###,###")
                End If
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                If CBPajak.Checked = True Then
                    TextSisaTagihan.Text = TextHasilPPN.Text
                    sisa = TextSisaTagihan.Text
                    TextGrandTotal.Text = Format(Val(sisa), "Rp, ###,###,###")
                Else
                    TextSisaTagihan.Text = TextGrandVisible.Text
                    sisa = TextSisaTagihan.Text
                    TextGrandTotal.Text = Format(Val(sisa), "Rp, ###,###,###")
                End If
            End If
        End If
    End Sub

    Private Sub TextQTY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextQTY.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextNota.Text = "" Or
            TextPel.Text = "" Or
            TextIDcus.Text = "" Or
            TextBrgJual.Text = "" Or
            TextIDbrg.Text = "" Or
            TextHarga.Text = "" Or
            TextQTY.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Data belum lengkap!, pastikan semua form terisi"
                MsgBoxBerhasil.ShowDialog()
            End If

            If TextStok.Text = "" Then
                Exit Sub
            Else
                TextStok.Text = TextStok.Text - TextQTY.Text
            End If

            If TextStok.Text <= 0 Then
                MsgBoxWarning.TextMsg.Text = "Stok tidak memadai!"
                MsgBoxWarning.ShowDialog()
            Else
                Call Hitung_Total()
                'SQL = "UPDATE barang SET STOK_BARANG = '" & TextStok.Text & "' WHERE ID_BARANG = '" & TextIDbrg.Text & "'"
                'Proses.ExecuteNonQuery(SQL)

                SQL = "INSERT INTO transaksi VALUES ('" & TextIDbrg.Text & "','" & TextIDcus.Text & "','" & TextKodeTransaksi.Text & "','" & TextNota.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & CLng(TextHarga.Text) & "','" & TextQTY.Text & "','" & TextQTY.Text & "','" & CLng(TextTotal.Text) & "',0)"
                Proses.ExecuteNonQuery(SQL)
                SQL = "INSERT INTO barang_detail VALUES ('" & TextIDbrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Penjualan barang dengan nota " & TextNota.Text & "','0','" & TextQTY.Text & "','" & MenuUtama.LabelUsername.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                Call Data_Record()
                Call Hitung_Total()
                Call Kode_Transaksi()
                TextHarga.Clear()
                TextQTY.Clear()
                TextTotal.Clear()
                TextBrgJual.Clear()
                TextHrgBrgVisible.Clear()
                TextStok.Clear()
                BtnSimpan.Enabled = True
                BtnSimpan.BackColor = Color.ForestGreen
            End If
        End If
    End Sub

    Private Sub TextQTY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextQTY.TextChanged
        Dim total, harga, qty As Integer
        harga = Val(TextHrgBrgVisible.Text)
        qty = Val(TextQTY.Text)
        total = harga * qty
        'TextTotalVisible.Text = total
        TextTotal.Text = total
    End Sub
End Class
