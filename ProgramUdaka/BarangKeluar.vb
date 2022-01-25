Imports MySql.Data.MySqlClient
Public Class BarangKeluar
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim brgkeluardetil, penjualan As DataTable

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

    Sub Kode_BrgKeluar()
        Dim brgkeluar As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM barang_keluar"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            brgkeluar = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(brgkeluar))
            Case 1 : TextKdBrgKeluar.Text = "BK.000" + Trim(Str(brgkeluar)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextKdBrgKeluar.Text = "BK.00" + Trim(Str(brgkeluar)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextKdBrgKeluar.Text = "BK.0" + Trim(Str(brgkeluar)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextKdBrgKeluar.Text = "BK." + Trim(Str(brgkeluar)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Nota_BrgKeluar()
        Dim notabrgkeluar As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM barang_keluar_detail"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            notabrgkeluar = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(notabrgkeluar))
            Case 1 : TextNotaBrgKlr.Text = "NOTA-BK.000" + Trim(Str(notabrgkeluar)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextNotaBrgKlr.Text = "NOTA-BK.00" + Trim(Str(notabrgkeluar)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextNotaBrgKlr.Text = "NOTA-BK.0" + Trim(Str(notabrgkeluar)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextNotaBrgKlr.Text = "NOTA-BK." + Trim(Str(notabrgkeluar)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Kode_BrgKeluarDetail()
        Dim kodeklrdetail As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM barang_keluar_detail"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            kodeklrdetail = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(kodeklrdetail))
            Case 1 : TextKodeKlrDetail.Text = "BK-D.000" + Trim(Str(kodeklrdetail)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextKodeKlrDetail.Text = "BK-D.00" + Trim(Str(kodeklrdetail)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextKodeKlrDetail.Text = "BK-D.0" + Trim(Str(kodeklrdetail)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextKodeKlrDetail.Text = "BK-D." + Trim(Str(kodeklrdetail)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Public Sub Data_Record()
        brgkeluardetil = Proses.ExecuteQuery("SELECT barang_keluar_detail.NOTA_BARANG_KELUAR, barang_keluar_detail.ID_BARANG, barang.NAMA_BARANG, barang_keluar_detail.STOK_KELUAR, barang_keluar_detail.ID_BRG_KLR_DETAIL FROM barang_keluar_detail INNER JOIN barang ON barang.ID_BARANG = barang_keluar_detail.ID_BARANG WHERE NOTA_BARANG_KELUAR = '" & TextNotaBrgKlr.Text & "' ORDER BY NOTA_BARANG_KELUAR DESC")
        DGbrgkeluar.DataSource = brgkeluardetil
        DGbrgkeluar.Columns(0).Width = 150
        DGbrgkeluar.Columns(1).Width = 150
        DGbrgkeluar.Columns(2).Width = 500
        DGbrgkeluar.Columns(3).Width = 100
        DGbrgkeluar.Columns(4).Width = 100
    End Sub

    Public Sub Data_Record_Penjualan()
        penjualan = Proses.ExecuteQuery("SELECT transaksi.ID_TRANSAKSI, transaksi.TGL_TRANSAKSI, transaksi.ID_BARANG, barang.NAMA_BARANG, (transaksi.QTY - transaksi.KELUAR) AS QTY, transaksi.KELUAR, pelanggan.NAMA_PELANGGAN, transaksi.ID_PELANGGAN, transaksi.QTY AS QTY_NOTA FROM transaksi INNER JOIN barang ON barang.ID_BARANG = transaksi.ID_BARANG INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = transaksi.ID_PELANGGAN WHERE NO_NOTA = '" & TextNotaPenjualan.Text & "' AND KELUAR != QTY")
        DGPenjualan.DataSource = penjualan
        DGPenjualan.Columns(0).Width = 100
        DGPenjualan.Columns(1).Width = 100
        DGPenjualan.Columns(2).Width = 100
        DGPenjualan.Columns(3).Width = 350
        DGPenjualan.Columns(4).Width = 70
        DGPenjualan.Columns(5).Width = 70
        DGPenjualan.Columns(6).Width = 300
        DGPenjualan.Columns(7).Width = 100
    End Sub

    'Sub DataComboxPem()
    'Call Koneksi()
    'Dim SQL As String
    'SQL = "SELECT NOTA_PEMBELIAN FROM pembelian"
    'CMD = New MySqlCommand(SQL, Conn)
    'RD = CMD.ExecuteReader
    'If RD.HasRows Then
    'Do While RD.Read
    'ComboxPembelian.Items.Add(RD("NOTA_PEMBELIAN"))
    'Loop
    'End If
    'End Sub

    Sub TampilNamaBrg()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT NAMA_BARANG FROM barang WHERE ID_BARANG = '" & TextKode.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBrg.Text = RD.Item("NAMA_BARANG")
        End If
        Conn.Close()
    End Sub

    Sub TampilNamaCus()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT NAMA_PELANGGAN FROM pelanggan WHERE ID_PELANGGAN = '" & TextKodeCus.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextCus.Text = RD.Item("NAMA_PELANGGAN")
        End If
        Conn.Close()
    End Sub

    Sub TampilStok()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT STOK_BARANG FROM barang WHERE ID_BARANG = '" & TextKode.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextStok.Text = RD.Item("STOK_BARANG")
        End If
        Conn.Close()
    End Sub

    'Sub AutoComPem()
    'Call Koneksi()
    'Dim DT As DataTable
    'CMD = New MySqlCommand("SELECT NOTA_PEMBELIAN FROM pembelian", Conn)
    'DA = New MySqlDataAdapter(CMD)
    'DT = New DataTable
    'DA.Fill(DT)

    'ComboxPembelian.DataSource = DT
    'ComboxPembelian.DisplayMember = "NOTA_PEMBELIAN"
    'ComboxPembelian.ValueMember = "NOTA_PEMBELIAN"

    'ComboxPembelian.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    'ComboxPembelian.AutoCompleteSource = AutoCompleteSource.ListItems
    'End Sub

    Sub Hitung_Total_Stok()
        Dim totalstok As Integer
        For baris As Integer = 0 To DGbrgkeluar.RowCount - 1
            totalstok = totalstok + DGbrgkeluar.Rows(baris).Cells(3).Value
            TextTotalStokKlr.Text = totalstok
        Next
    End Sub

    Private Sub BarangKeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_BrgKeluar()
        Call Nota_BrgKeluar()
        Call Kode_BrgKeluarDetail()
        'Call DataComboxPem()
        'Call AutoComPem()
        Call Data_Record()
        Call Data_Record_Penjualan()
        Call Hitung_Total_Stok()
        TextCus.Enabled = False
        TextBrg.Enabled = False
        TextKdBrgKeluar.Enabled = False
        TextKode.Enabled = False
        TextKodeCus.Enabled = False
        TextNotaBrgKlr.Enabled = False
        TextStok.Enabled = False
        TextTotalStokKlr.Enabled = False
        TextJumlah.Visible = False
        TextQTYJual.Visible = False
        TextKeluar.Visible = False
        TextIDDetail.Visible = False
        TextKodeKlrDetail.Visible = False
        TextQTYVisible.Visible = False
        TextKodeKlrDetailVisible.Visible = False
        BtnHapus.Enabled = False
        BtnHapus.BackColor = Color.Gray
        BtnSimpan.Enabled = False
        BtnSimpan.BackColor = Color.Gray
    End Sub

    Private Sub TextKodeSup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextKodeCus.TextChanged
        Call TampilNamaCus()
    End Sub

    Private Sub TextKode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextKode.TextChanged
        Call TampilNamaBrg()
        Call TampilStok()
    End Sub

    Private Sub DGPembelian_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGPenjualan.Click
        Dim baris As Integer
        With DGPenjualan
            baris = .CurrentRow.Index
            TextIDDetail.Text = .Item(0, baris).Value
            TextKode.Text = .Item(2, baris).Value
            TextKodeCus.Text = .Item(7, baris).Value
            TextQTY.Text = .Item(4, baris).Value
            TextQTYJual.Text = .Item(4, baris).Value
            TextKeluar.Text = .Item(5, baris).Value
        End With
    End Sub

    Private Sub DGbrgmasuk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGbrgkeluar.Click
        Dim baris As Integer
        With DGbrgkeluar
            baris = .CurrentRow.Index
            TextKodeKlrDetailVisible.Text = .Item(4, baris).Value
            TextKode.Text = .Item(1, baris).Value
            TextBrg.Text = .Item(2, baris).Value
            TextQTYVisible.Text = .Item(3, baris).Value

            If TextKodeKlrDetailVisible.Text = .Item(4, baris).Value Then
                BtnHapus.Enabled = True
                BtnHapus.BackColor = Color.DarkRed
            End If
        End With
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If TextKode.Text = "" Or
                TextBrg.Text = "" Or
                TextQTY.Text = "" Or
                TextKodeCus.Text = "" Or
                TextCus.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
        Else
            Dim qty, keluar As Integer
            qty = Val(TextQTYJual.Text)
            keluar = Val(TextQTY.Text)

            If keluar > qty Then
                MsgBoxWarning.TextMsg.Text = "Jumlah barang yang dimasukan tidak sesuai dengan data pada Nota Penjualan"
                MsgBoxWarning.ShowDialog()
                Exit Sub
            Else
                Call Hitung_Total_Stok()
                SQL = "INSERT INTO barang_keluar_detail VALUES ('" & TextKode.Text & "','" & TextIDDetail.Text & "','" & TextKodeKlrDetail.Text & "','" & TextNotaBrgKlr.Text & "','" & TextQTY.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
                Proses.ExecuteNonQuery(SQL)
                SQL = "UPDATE transaksi SET KELUAR = '" & TextQTY.Text & "' WHERE ID_TRANSAKSI = '" & TextIDDetail.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                SQL = "INSERT INTO barang_detail VALUES ('" & TextKode.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Barang keluar dengan nota " & TextNotaBrgKlr.Text & "','" & TextQTY.Text & "','0','" & MenuUtama.LabelUsername.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                Call Data_Record()
                TextKode.Clear()
                TextBrg.Clear()
                TextQTY.Clear()
                TextStok.Clear()
                Call Hitung_Total_Stok()
                Call Data_Record_Penjualan()
                Call Kode_BrgKeluarDetail()
                BtnSimpan.Enabled = True
                BtnSimpan.BackColor = Color.ForestGreen
            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        SQL = "INSERT INTO barang_keluar VALUES ('" & TextKdBrgKeluar.Text & "','" & TextKodeCus.Text & "','" & TextNotaBrgKlr.Text & "','" & TextTotalStokKlr.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
        Proses.ExecuteNonQuery(SQL)
        MsgBoxBerhasil.TextMsg.Text = "Data barang keluar sudah tersimpan"
        MsgBoxBerhasil.ShowDialog()
        TextTotalStokKlr.Clear()
        TextKodeCus.Clear()
        TextCus.Clear()
        Call Kode_BrgKeluar()
        Call Nota_BrgKeluar()
        Call Data_Record()
    End Sub

    'Private Sub ComboxPembelian_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Call Data_Record_Pembelian()
    'End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If DGbrgkeluar.CurrentRow.Index <> DGbrgkeluar.NewRowIndex Then
            If TextKodeKlrDetailVisible.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Barang belum dipilih! Silahkan pilih barang!"
                MsgBoxWarning.ShowDialog()
            Else
                SQL = "DELETE FROM barang_keluar_detail WHERE ID_BRG_KLR_DETAIL = '" & TextKodeKlrDetailVisible.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                SQL = "INSERT INTO barang_detail VALUES ('" & TextKode.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Membatalkan barang keluar pada nota " & TextNotaBrgKlr.Text & "','0','" & TextQTYVisible.Text & "','" & MenuUtama.LabelUsername.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBoxBerhasil.TextMsg.Text = "Data barang keluar sudah terhapus"""
                MsgBoxBerhasil.ShowDialog()
                DGbrgkeluar.Rows.RemoveAt(DGbrgkeluar.CurrentRow.Index)
                BtnHapus.Enabled = False
                BtnHapus.BackColor = Color.Gray
                TextKodeKlrDetailVisible.Clear()
                TextQTYVisible.Clear()
                Call Kode_BrgKeluarDetail()
                Call Data_Record()
                Call Data_Record_Penjualan()
            End If
        End If
    End Sub

    Private Sub TextNotaPembelian_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextNotaPenjualan.Click
        CariNotaPenjualan.Show()
    End Sub

    Private Sub BtnCariNotaBeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariNotaBeli.Click
        CariNotaPenjualan.Show()
    End Sub

    Private Sub TextNotaPembelian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextNotaPenjualan.KeyPress
        CariNotaPenjualan.Show()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuBarangMasuk)
        Me.Close()
    End Sub
End Class