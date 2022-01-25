Imports MySql.Data.MySqlClient
Public Class BarangMasuk
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim brgmasukdetil, pembelian As DataTable

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

    Sub Kode_BrgMasuk()
        Dim brgmasuk As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM barang_masuk"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            brgmasuk = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(brgmasuk))
            Case 1 : TextKdBrgMasuk.Text = "BM.000" + Trim(Str(brgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextKdBrgMasuk.Text = "BM.00" + Trim(Str(brgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextKdBrgMasuk.Text = "BM.0" + Trim(Str(brgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextKdBrgMasuk.Text = "BM." + Trim(Str(brgmasuk)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Nota_BrgMasuk()
        Dim notabrgmasuk As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM barang_masuk_detail"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            notabrgmasuk = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(notabrgmasuk))
            Case 1 : TextNotaBrgMsk.Text = "NOTA-BM.000" + Trim(Str(notabrgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextNotaBrgMsk.Text = "NOTA-BM.00" + Trim(Str(notabrgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextNotaBrgMsk.Text = "NOTA-BM.0" + Trim(Str(notabrgmasuk)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextNotaBrgMsk.Text = "NOTA-BM." + Trim(Str(notabrgmasuk)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Kode_BrgMasukDetail()
        Dim kodemskdetail As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM barang_masuk_detail"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            kodemskdetail = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(kodemskdetail))
            Case 1 : TextKodeMskDetail.Text = "BM-D.000" + Trim(Str(kodemskdetail)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextKodeMskDetail.Text = "BM-D.00" + Trim(Str(kodemskdetail)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextKodeMskDetail.Text = "BM-D.0" + Trim(Str(kodemskdetail)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextKodeMskDetail.Text = "BM-D." + Trim(Str(kodemskdetail)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Public Sub Data_Record()
        brgmasukdetil = Proses.ExecuteQuery("SELECT barang_masuk_detail.NOTA_BARANG_MASUK, barang_masuk_detail.ID_BARANG, barang.NAMA_BARANG, barang_masuk_detail.STOK_MASUK, barang_masuk_detail.ID_BRG_MSK_DETAIL FROM barang_masuk_detail INNER JOIN barang ON barang.ID_BARANG = barang_masuk_detail.ID_BARANG WHERE NOTA_BARANG_MASUK = '" & TextNotaBrgMsk.Text & "' ORDER BY NOTA_BARANG_MASUK DESC")
        DGbrgmasuk.DataSource = brgmasukdetil
        DGbrgmasuk.Columns(0).Width = 150
        DGbrgmasuk.Columns(1).Width = 150
        DGbrgmasuk.Columns(2).Width = 500
        DGbrgmasuk.Columns(3).Width = 100
        DGbrgmasuk.Columns(4).Width = 100
    End Sub

    Public Sub Data_Record_Pembelian()
        pembelian = Proses.ExecuteQuery("SELECT pembelian_detail.ID_DETAIL, pembelian_detail.TGL_BELI, pembelian_detail.ID_BARANG, barang.NAMA_BARANG, pembelian_detail.QTY_BELI, pembelian_detail.MASUK, supplier.NAMA_SUPPLIER, pembelian_detail.ID_SUPPLIER FROM pembelian_detail INNER JOIN barang ON barang.ID_BARANG = pembelian_detail.ID_BARANG INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian_detail.ID_SUPPLIER WHERE NOTA_PEMBELIAN = '" & TextNotaPembelian.Text & "' AND MASUK != QTY_BELI")
        DGPembelian.DataSource = pembelian
        DGPembelian.Columns(0).Width = 100
        DGPembelian.Columns(1).Width = 100
        DGPembelian.Columns(2).Width = 100
        DGPembelian.Columns(3).Width = 350
        DGPembelian.Columns(4).Width = 70
        DGPembelian.Columns(5).Width = 70
        DGPembelian.Columns(6).Width = 300
        DGPembelian.Columns(7).Width = 100
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

    Sub TampilNamaSup()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT NAMA_SUPPLIER FROM supplier WHERE ID_SUPPLIER = '" & TextKodeSup.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextSup.Text = RD.Item("NAMA_SUPPLIER")
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
        Conn.Close
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
        For baris As Integer = 0 To DGbrgmasuk.RowCount - 1
            totalstok = totalstok + DGbrgmasuk.Rows(baris).Cells(3).Value
            TextTotalStokMsk.Text = totalstok
        Next
    End Sub
    Private Sub BarangMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kode_BrgMasuk()
        Call Nota_BrgMasuk()
        Call Kode_BrgMasukDetail()
        'Call DataComboxPem()
        'Call AutoComPem()
        Call Data_Record()
        Call Data_Record_Pembelian()
        Call Hitung_Total_Stok()
        TextSup.Enabled = False
        TextBrg.Enabled = False
        TextKdBrgMasuk.Enabled = False
        TextKode.Enabled = False
        TextKodeSup.Enabled = False
        TextNotaBrgMsk.Enabled = False
        TextStok.Enabled = False
        TextTotalStokMsk.Enabled = False
        TextJumlah.Visible = False
        TextQTYBeli.Visible = False
        TextMasuk.Visible = False
        TextIDDetail.Visible = False
        TextKodeMskDetail.Visible = False
        TextQTYVisible.Visible = False
        TextKodeMskDetailVisible.Visible = False
        BtnHapus.Enabled = False
        BtnHapus.BackColor = Color.Gray
        BtnSimpan.Enabled = False
        BtnSimpan.BackColor = Color.Gray
    End Sub

    Private Sub TextKodeSup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextKodeSup.TextChanged
        Call TampilNamaSup()
    End Sub

    Private Sub TextKode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextKode.TextChanged
        Call TampilNamaBrg()
        Call TampilStok()
    End Sub

    Private Sub DGPembelian_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGPembelian.Click
        Dim baris As Integer
        With DGPembelian
            baris = .CurrentRow.Index
            TextIDDetail.Text = .Item(0, baris).Value
            TextKode.Text = .Item(2, baris).Value
            TextKodeSup.Text = .Item(7, baris).Value
            TextQTY.Text = .Item(4, baris).Value
            TextQTYBeli.Text = .Item(4, baris).Value
            TextMasuk.Text = .Item(5, baris).Value
        End With
    End Sub

    Private Sub DGbrgmasuk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGbrgmasuk.Click
        Dim baris As Integer
        With DGbrgmasuk
            baris = .CurrentRow.Index
            TextKodeMskDetailVisible.Text = .Item(4, baris).Value
            TextKode.Text = .Item(1, baris).Value
            TextBrg.Text = .Item(2, baris).Value
            TextQTYVisible.Text = .Item(3, baris).Value

            If TextKodeMskDetailVisible.Text = .Item(4, baris).Value Then
                BtnHapus.Enabled = True
                BtnHapus.BackColor = Color.DarkRed
            End If
        End With
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If TextKode.Text = "" Or
                TextBrg.Text = "" Or
                TextQTY.Text = "" Or
                TextKodeSup.Text = "" Or
                TextSup.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
        Else
            Dim masuk, qty_beli, total, txtqty, jumlah As Integer
            txtqty = Val(TextQTY.Text)
            masuk = Val(TextMasuk.Text)
            qty_beli = Val(TextQTYBeli.Text)
            jumlah = txtqty + masuk
            total = qty_beli - jumlah

            TextJumlah.Text = jumlah

            If total < 0 Then
                MsgBoxWarning.TextMsg.Text = "Jumlah barang yang dimasukan tidak sesuai dengan data pada Nota Pembelian"
                MsgBoxWarning.ShowDialog()
                Exit Sub
            Else
                Call Hitung_Total_Stok()
                SQL = "INSERT INTO barang_masuk_detail VALUES ('" & TextKode.Text & "','" & TextIDDetail.Text & "','" & TextKodeMskDetail.Text & "','" & TextNotaBrgMsk.Text & "','" & TextQTY.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
                Proses.ExecuteNonQuery(SQL)
                SQL = "UPDATE pembelian_detail SET MASUK = '" & TextJumlah.Text & "' WHERE ID_DETAIL = '" & TextIDDetail.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                SQL = "INSERT INTO barang_detail VALUES ('" & TextKode.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Barang masuk dengan nota " & TextNotaBrgMsk.Text & "','" & TextQTY.Text & "','0','" & MenuUtama.LabelUsername.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                Call Data_Record()
                TextKode.Clear()
                TextBrg.Clear()
                TextQTY.Clear()
                TextStok.Clear()
                Call Hitung_Total_Stok()
                Call Data_Record_Pembelian()
                Call Kode_BrgMasukDetail()
                BtnSimpan.Enabled = True
                BtnSimpan.BackColor = Color.ForestGreen
            End If
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        SQL = "INSERT INTO barang_masuk VALUES ('" & TextKdBrgMasuk.Text & "','" & TextKodeSup.Text & "','" & TextNotaBrgMsk.Text & "','" & TextTotalStokMsk.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
        Proses.ExecuteNonQuery(SQL)
        MsgBoxBerhasil.TextMsg.Text = "Data barang masuk sudah tersimpan"
        MsgBoxBerhasil.ShowDialog()
        TextTotalStokMsk.Clear()
        TextKodeSup.Clear()
        TextSup.Clear()
        Call Kode_BrgMasuk()
        Call Nota_BrgMasuk()
        Call Data_Record()
    End Sub

    'Private Sub ComboxPembelian_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Call Data_Record_Pembelian()
    'End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If DGbrgmasuk.CurrentRow.Index <> DGbrgmasuk.NewRowIndex Then
            If TextKodeMskDetailVisible.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Barang belum dipilih! Silahkan pilih barang!"
                MsgBoxWarning.ShowDialog()
            Else
                SQL = "DELETE FROM barang_masuk_detail WHERE ID_BRG_MSK_DETAIL = '" & TextKodeMskDetailVisible.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                SQL = "INSERT INTO barang_detail VALUES ('" & TextKode.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Membatalkan barang masuk pada nota " & TextNotaBrgMsk.Text & "','0','" & TextQTYVisible.Text & "','" & MenuUtama.LabelUsername.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBoxBerhasil.TextMsg.Text = "Data barang masuk sudah terhapus"""
                MsgBoxBerhasil.ShowDialog()
                DGbrgmasuk.Rows.RemoveAt(DGbrgmasuk.CurrentRow.Index)
                BtnHapus.Enabled = False
                BtnHapus.BackColor = Color.Gray
                TextKodeMskDetailVisible.Clear()
                TextQTYVisible.Clear()
                Call Kode_BrgMasukDetail()
                Call Data_Record()
                Call Data_Record_Pembelian()
            End If
        End If
    End Sub

    Private Sub TextNotaPembelian_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextNotaPembelian.Click
        CariNotaPembelian.Show()
    End Sub

    Private Sub BtnCariNotaBeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariNotaBeli.Click
        CariNotaPembelian.Show()
    End Sub

    Private Sub TextNotaPembelian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextNotaPembelian.KeyPress
        CariNotaPembelian.Show()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuBarangMasuk)
        Me.Close()
    End Sub
End Class