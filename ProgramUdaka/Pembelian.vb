Imports MySql.Data.MySqlClient
Public Class Pembelian
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL, txtppn As String
    Dim Proses As New ClsKoneksi
    Dim pembelian As DataTable
    Dim txt1, txt2, txt3, txt4 As Long
    Dim hasildiskon As Integer
    Public confirm As Boolean = False

    Sub Koneksi()
        Try
            Dim SQL As String = "server=localhost;user id=root;password=;database=udakasari"
            Conn = New MySqlConnection(SQL)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            Else
                Conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Kode_Pembelian()
        Dim pembelian As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM pembelian"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            pembelian = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(pembelian))
            Case 1 : TextKodePem.Text = "IDPO.000" + Trim(Str(pembelian)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextKodePem.Text = "IDPO.00" + Trim(Str(pembelian)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextKodePem.Text = "IDPO.0" + Trim(Str(pembelian)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextKodePem.Text = "IDPO." + Trim(Str(pembelian)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Nota_Pembelian()
        Dim nota_pembelian As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JUMLAH FROM pembelian_detail"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            nota_pembelian = Val(RD.Item("JUMLAH").ToString) + 1
        End While
        Select Case Len(Trim(nota_pembelian))
            Case 1 : TextNoPem.Text = "PO.000" + Trim(Str(nota_pembelian)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextNoPem.Text = "PO.00" + Trim(Str(nota_pembelian)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextNoPem.Text = "PO.0" + Trim(Str(nota_pembelian)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextNoPem.Text = "PO." + Trim(Str(nota_pembelian)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Sub Kode_PemDetail()
        Dim id As Single
        Call Koneksi()
        SQL = "SELECT COUNT(*) AS JML FROM pembelian_detail"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        While RD.Read
            id = Val(RD.Item("JML").ToString) + 1
        End While
        Select Case Len(Trim(id))
            Case 1 : TextIDPemDetail.Text = "PD.000" + Trim(Str(id)) + "-" + Format(Now, "yyMMdd")
            Case 2 : TextIDPemDetail.Text = "PD.00" + Trim(Str(id)) + "-" + Format(Now, "yyMMdd")
            Case 3 : TextIDPemDetail.Text = "PD.0" + Trim(Str(id)) + "-" + Format(Now, "yyMMdd")
            Case 4 : TextIDPemDetail.Text = "PD." + Trim(Str(id)) + "-" + Format(Now, "yyMMdd")
        End Select
        Conn.Close()
    End Sub

    Public Sub Data_Record()
        pembelian = Proses.ExecuteQuery("SELECT pembelian_detail.NOTA_PEMBELIAN, pembelian_detail.TGL_BELI, pembelian_detail.ID_SUPPLIER, supplier.NAMA_SUPPLIER, pembelian_detail.ID_BARANG, barang.NAMA_BARANG, pembelian_detail.HARGA_BELI_BARANG, pembelian_detail.QTY_BELI, pembelian_detail.TOTAL_HARGA_BELI, barang.STOK_BARANG, pembelian_detail.ID_DETAIL FROM pembelian_detail INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian_detail.ID_SUPPLIER INNER JOIN barang ON barang.ID_BARANG = pembelian_detail.ID_BARANG WHERE NOTA_PEMBELIAN = '" & TextNoPem.Text & "'")
        DGPembelian.DataSource = pembelian
        DGPembelian.Columns(0).Width = 100
        DGPembelian.Columns(1).Width = 100
        DGPembelian.Columns(2).Width = 100
        DGPembelian.Columns(3).Width = 100
        DGPembelian.Columns(4).Width = 100
        DGPembelian.Columns(5).Width = 100
        DGPembelian.Columns(6).Width = 100
        DGPembelian.Columns(6).DefaultCellStyle.Format = "###,###,###"
        DGPembelian.Columns(7).Width = 100
        DGPembelian.Columns(8).Width = 100
        DGPembelian.Columns(8).DefaultCellStyle.Format = "###,###,###"
        DGPembelian.Columns(9).Width = 100
        DGPembelian.Columns(10).Width = 100
    End Sub

    Sub Hitung_Total()
        Dim grand, qty As Integer
        For baris As Integer = 0 To DGPembelian.RowCount - 1
            grand = grand + DGPembelian.Rows(baris).Cells(8).Value
            TextGrandTotalBeli.Text = Format(Val(grand), "Rp, ###,###,###")
            TextGrandVisible.Text = grand
            hasildiskon = grand
        Next
        For row As Integer = 0 To DGPembelian.RowCount - 1
            qty = qty + DGPembelian.Rows(row).Cells(7).Value
            TextTotalQTY.Text = qty
        Next
    End Sub

    Sub ppn()
        Dim total, hasil, ppn As Long
        total = Val(TextGrandVisible.Text)
        hasil = total * 0.1
        ppn = total + hasil
        TextGrandTotalBeli.Text = Format(Val(ppn), "Rp, ###,###,###")
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
            TextGrandTotalBeli.Text = Format(Val(hasil), "Rp, ###,###,###")
        ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
            harga_awal = TextTagihan.Text
            diskon = TextDisc.Text
            harga_akhir = (diskon / 100) * harga_awal
            hasil = harga_awal - harga_akhir
            TextTagihan.Text = hasil
            hasildiskon = hasil
            TextGrandTotalBeli.Text = Format(Val(hasil), "Rp, ###,###,###")
        End If
    End Sub

    Sub Hapus_Total()
        Dim jumlah, harga As Integer
        jumlah = Val(TextGrandVisible.Text)
        harga = Val(TextHargaVisible.Text)
        jumlah = jumlah - harga
        TextGrandVisible.Text = jumlah
        TextGrandTotalBeli.Text = Format(Val(jumlah), "Rp, ###,###,###")
    End Sub

    Sub Hitung_Piutang_Beli()
        If CBPajak.Checked = True Then
            If ComboxJenisBayar.Text = "CASH" Then
                TextTagihan.Text = "0"
                TextBayar.Text = TextHasilPPN.Text
                TextSttsPem.Text = "LUNAS"
                TextBayar.Enabled = False
                TextTagihan.Enabled = False
                BtnReset.Enabled = False
                BtnReset.BackColor = Color.Gray
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                TextTagihan.Text = TextHasilPPN.Text
                TextSttsPem.Text = "UTANG"
                TextBayar.Enabled = True
                TextTagihan.Enabled = False
                BtnReset.Enabled = True
                BtnReset.BackColor = Color.DarkRed
                TextBayar.Clear()
            End If
        Else
            If ComboxJenisBayar.Text = "CASH" Then
                TextTagihan.Text = "0"
                TextBayar.Text = TextGrandVisible.Text
                TextSttsPem.Text = "LUNAS"
                TextBayar.Enabled = False
                TextTagihan.Enabled = False
                BtnReset.Enabled = False
                BtnReset.BackColor = Color.Gray
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                TextTagihan.Text = TextGrandVisible.Text
                TextSttsPem.Text = "UTANG"
                TextBayar.Enabled = True
                TextTagihan.Enabled = False
                BtnReset.Enabled = True
                BtnReset.BackColor = Color.DarkRed
                TextBayar.Clear()
            End If
        End If
    End Sub

    Private Sub DGPembelian_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGPembelian.Click
        Dim baris As Integer
        With DGPembelian
            baris = .CurrentRow.Index
            TextIDPemDetailVisible.Text = .Item(10, baris).Value
            TextKodeBrg.Text = .Item(4, baris).Value
            TextBrgBeli.Text = .Item(5, baris).Value
            TextIn.Text = .Item(7, baris).Value
            TextStokBrg.Text = .Item(9, baris).Value
            TextHargaVisible.Text = .Item(8, baris).Value

            If TextIDPemDetailVisible.Text = .Item(10, baris).Value Then
                BtnHapus.Enabled = True
                BtnHapus.BackColor = Color.DarkRed
            End If
        End With
    End Sub

    Private Sub TextHargaBeli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextHargaBeli.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextQTYBeli.Focus()
        End If
    End Sub

    Private Sub TextHargaBeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextHargaBeli.TextChanged
        If TextHargaBeli.Text = "" Or Not IsNumeric(TextHargaBeli.Text) Then
            Exit Sub
        End If
        txt1 = TextHargaBeli.Text
        TextHargaBeli.Text = Format(Val(txt1), "###,###")
        TextHargaBeli.SelectionStart = Len(TextHargaBeli.Text)
    End Sub

    Private Sub TextTotalBeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTotalBeli.TextChanged
        If TextTotalBeli.Text = "" Or Not IsNumeric(TextTotalBeli.Text) Then
            Exit Sub
        End If
        txt2 = TextTotalBeli.Text
        TextTotalBeli.Text = Format(Val(txt2), "###,###")
        TextTotalBeli.SelectionStart = Len(TextTotalBeli.Text)
    End Sub

    Private Sub TextBayar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBayar.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Masukkan nominal!"
                MsgBoxWarning.ShowDialog()
                TextTagihan.Clear()
                TextTagihan.Text = TextGrandVisible.Text
            Else
                TextTagihan.Text = TextGrandVisible.Text - TextBayar.Text
            End If
        End If
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
                TextTagihan.Text = TextHasilPPN.Text
            Else
                TextTagihan.Text = TextGrandVisible.Text
            End If
        Else
            If CBPajak.Checked = True Then
                TextTagihan.Text = hasildiskon - TextBayar.Text
                If TextBayar.Text = hasildiskon Then
                    TextSttsPem.Text = "LUNAS"
                    ComboxJenisBayar.Text = "CASH"
                End If
            Else
                TextTagihan.Text = hasildiskon - TextBayar.Text
                If TextBayar.Text = hasildiskon Then
                    TextSttsPem.Text = "LUNAS"
                    ComboxJenisBayar.Text = "CASH"
                End If
            End If
        End If
    End Sub

    Private Sub TextTagihan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTagihan.TextChanged
        If TextTagihan.Text = "" Or Not IsNumeric(TextTagihan.Text) Then
            Exit Sub
        End If
        If ComboxJenisBayar.Text = "CASH" Then
            TextTagihan.Text = "0"
        Else
            txt4 = TextTagihan.Text
            TextTagihan.Text = Format(Val(txt4), "###,###")
            TextTagihan.SelectionStart = Len(TextTagihan.Text)
        End If
    End Sub

    Private Sub BtnCariSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariSup.Click
        CariSupplierPembelian.Show()
    End Sub

    Private Sub BtnCariBrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariBrg.Click
        CariBarangPembelian.Show()
    End Sub

    Private Sub TextSup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextSup.KeyPress
        CariSupplierPembelian.Show()
    End Sub

    Private Sub TextBrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBrgBeli.KeyPress
        CariBarangPembelian.Show()
    End Sub

    Private Sub TextSup_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextSup.MouseDown
        CariSupplierPembelian.Show()
    End Sub

    Private Sub TextBrg_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBrgBeli.MouseDown
        CariBarangPembelian.Show()
    End Sub

    Private Sub TextGrandTotalBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextGrandTotalBeli.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub TextSisa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = Chr(0)
    End Sub

    Private Sub TextTotalBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextTotalBeli.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub TextHargaBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextHargaBeli.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub ComboxJenisBayar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboxJenisBayar.KeyDown
        If e.KeyCode = Keys.Enter Or Keys.Tab Then
            TextTagihan.Focus()
        End If
    End Sub

    Private Sub ComboxJenisBayar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboxJenisBayar.SelectedIndexChanged
        Call Hitung_Piutang_Beli()
    End Sub

    Private Sub Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextDisc.Text = 0
        txtppn = ""
        Call Kode_Pembelian()
        Call Nota_Pembelian()
        Call Kode_PemDetail()
        Call Data_Record()
        Call Hitung_Total()
        CBPajak.Visible = False
        TextIn.Visible = False
        TextHrgBrgVisible.Visible = False
        TextHasilPPN.Visible = False
        TextGrandVisible.Visible = False
        TextIDPemDetailVisible.Visible = False
        TextHargaVisible.Visible = False
        TextIDPemDetail.Enabled = False
        TextKodePem.Enabled = False
        TextNoPem.Enabled = False
        TextKodeSup.Enabled = False
        TextKodeBrg.Enabled = False
        TextStokBrg.Enabled = False
        TextSttsPem.Enabled = False
        TextIn.Enabled = False
        BtnHapus.Enabled = False
        BtnHapus.BackColor = Color.Gray
        BtnSimpan.Enabled = False
        BtnSimpan.BackColor = Color.Gray
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If TextKodePem.Text = "" Or
            TextSup.Text = "" Or
            TextKodeSup.Text = "" Or
            TextBrgBeli.Text = "" Or
            TextKodeBrg.Text = "" Or
            TextHargaBeli.Text = "" Or
            TextQTYBeli.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data belum lengkap, pastikan semua form terisi"
            MsgBoxWarning.ShowDialog()
        End If

        TextTotalBeli.Text = TextHargaBeli.Text * TextQTYBeli.Text
        Call Hitung_Total()

        SQL = "INSERT INTO pembelian_detail VALUES ('" & TextKodeBrg.Text & "','" & TextKodeSup.Text & "','" & TextIDPemDetail.Text & "','" & TextNoPem.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & CLng(TextHargaBeli.Text) & "','" & TextQTYBeli.Text & "','" & TextQTYBeli.Text & "','" & CLng(TextTotalBeli.Text) & "',0)"
        Proses.ExecuteNonQuery(SQL)
        SQL = "INSERT INTO barang_detail VALUES ('" & TextKodeBrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Pembelian barang dengan nota " & TextNoPem.Text & "','" & TextQTYBeli.Text & "','0','" & MenuUtama.LabelUsername.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        Call Data_Record()
        Call Hitung_Total()
        Call Kode_PemDetail()
        TextHargaBeli.Clear()
        TextQTYBeli.Clear()
        TextTotalBeli.Clear()
        TextBrgBeli.Clear()
        TextHrgBrgVisible.Clear()
        BtnSimpan.Enabled = True
        BtnSimpan.BackColor = Color.ForestGreen
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If DGPembelian.CurrentRow.Index <> DGPembelian.NewRowIndex Then
            If TextIn.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Barang belum dipilih!, silahkan pilih barang"
                MsgBoxWarning.ShowDialog()
            Else
                If confirm = True Then
                    SQL = "DELETE FROM pembelian_detail WHERE ID_DETAIL = '" & TextIDPemDetailVisible.Text & "'"
                    Proses.ExecuteNonQuery(SQL)
                    SQL = "INSERT INTO barang_detail VALUES ('" & TextKodeBrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Barang dihapus dari nota pembelian " & TextNoPem.Text & "','0','" & TextIn.Text & "','" & MenuUtama.LabelUsername.Text & "')"
                    Proses.ExecuteNonQuery(SQL)
                    MsgBoxBerhasil.TextMsg.Text = "Purchase order berhasil dihapus"
                    MsgBoxBerhasil.ShowDialog()
                    DGPembelian.Rows.RemoveAt(DGPembelian.CurrentRow.Index)
                    BtnHapus.Enabled = False
                    BtnHapus.BackColor = Color.Gray
                    Call Hapus_Total()
                    TextIn.Clear()
                    Call Data_Record()
                    Call Kode_PemDetail()
                    TextIDPemDetailVisible.Clear()
                    ComboxJenisBayar.Text = ""
                    TextBayar.Clear()
                    TextTagihan.Clear()
                    TextSttsPem.Clear()
                Else
                    Konfirmasi2.LblUser.Text = MenuUtama.LabelUsername.Text
                    Konfirmasi2.Show()
                    Konfirmasi2.TextPass.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub TextQTYBeli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextQTYBeli.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextKodePem.Text = "" Or
            TextSup.Text = "" Or
            TextKodeSup.Text = "" Or
            TextBrgBeli.Text = "" Or
            TextKodeBrg.Text = "" Or
            TextHargaBeli.Text = "" Or
            TextQTYBeli.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Barang belum dipilih!, silahkan pilih barang"
                MsgBoxWarning.ShowDialog()
            End If

            TextTotalBeli.Text = TextHargaBeli.Text * TextQTYBeli.Text
            Call Hitung_Total()

            SQL = "INSERT INTO pembelian_detail VALUES ('" & TextKodeBrg.Text & "','" & TextKodeSup.Text & "','" & TextIDPemDetail.Text & "','" & TextNoPem.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & CLng(TextHargaBeli.Text) & "','" & TextQTYBeli.Text & "','" & TextQTYBeli.Text & "','" & CLng(TextTotalBeli.Text) & "',0)"
            Proses.ExecuteNonQuery(SQL)
            SQL = "INSERT INTO barang_detail VALUES ('" & TextKodeBrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Pembelian barang dengan nota " & TextNoPem.Text & "','" & TextQTYBeli.Text & "','0','" & MenuUtama.LabelUsername.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            Call Data_Record()
            Call Hitung_Total()
            Call Kode_PemDetail()
            TextHargaBeli.Clear()
            TextQTYBeli.Clear()
            TextTotalBeli.Clear()
            TextBrgBeli.Clear()
            TextHrgBrgVisible.Clear()
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If ComboxJenisBayar.Text = "" Or
            TextBayar.Text = "" Or
            TextTagihan.Text = "" Or
            TextSttsPem.Text = "" Then
            MsgBoxWarning.TextMsg.Text = "Data pembayaran belum lengkap!"
            MsgBoxWarning.ShowDialog()
        Else
            If TextTagihan.Text < 0 Then
                MsgBoxWarning.TextMsg.Text = "Pembayaran melebihi tagihan"
                MsgBoxWarning.ShowDialog()
            Else
                SQL = "INSERT INTO pembelian VALUES ('" & TextKodePem.Text & "','" & TextKodeSup.Text & "','" & TextNoPem.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & ComboxJenisBayar.Text & "','" & hasildiskon & "','" & TextTotalQTY.Text & "','" & txtppn & "','" & TextDisc.Text & "%','" & CLng(TextBayar.Text) & "','" & CLng(TextTagihan.Text) & "','" & TextSttsPem.Text & "','" & MenuUtama.LabelNama.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBoxBerhasil.TextMsg.Text = "Data purchase order sudah disimpan"
                MsgBoxBerhasil.ShowDialog()
                Call Kode_Pembelian()

                TextKodeSup.Clear()
                TextKodeBrg.Clear()
                TextHargaBeli.Clear()
                TextQTYBeli.Clear()
                TextGrandTotalBeli.Clear()
                TextBayar.Clear()
                TextTagihan.Clear()
                ComboxJenisBayar.Text = ""
                TextSttsPem.Clear()
                TextTotalBeli.Clear()
                TextDisc.Text = "0"

                FormPurchaseOrder.CRViewPO.ReportSource = "ReportPO.rpt"
                FormPurchaseOrder.CRViewPO.SelectionFormula = "{pembelian1.NOTA_PEMBELIAN} = '" + TextNoPem.Text + "' AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "' "
                FormPurchaseOrder.CRViewPO.RefreshReport()
                FormPurchaseOrder.ShowDialog()
                Call Nota_Pembelian()
                Call Data_Record()
            End If
        End If
    End Sub

    Private Sub TextQTYBeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextQTYBeli.TextChanged
        Dim total, harga, qty As Integer
        harga = Val(TextHrgBrgVisible.Text)
        qty = Val(TextQTYBeli.Text)
        total = harga * qty
        'TextTotalVisible.Text = total
        TextTotalBeli.Text = total
    End Sub

    Private Sub CBPajak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPajak.CheckedChanged
        If CBPajak.Checked = True Then
            Call ppn()
            If ComboxJenisBayar.Text = "CASH" Then
                TextBayar.Text = TextHasilPPN.Text
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                TextTagihan.Text = TextHasilPPN.Text
            End If
        Else
            Call Hitung_Total()
            If ComboxJenisBayar.Text = "CASH" Then
                TextBayar.Text = TextGrandVisible.Text
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                TextTagihan.Text = TextGrandVisible.Text
            End If
        End If
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        If CBPajak.Checked = True Then
            TextTagihan.Clear()
            TextTagihan.Text = hasildiskon
            TextBayar.Clear()
        Else
            TextTagihan.Clear()
            TextTagihan.Text = hasildiskon
            TextBayar.Clear()
        End If
    End Sub

    Private Sub BtnHitungDiskon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitungDiskon.Click
        Call HitungDiskon()
    End Sub

    Private Sub TextDisc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextDisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call HitungDiskon()
        End If
    End Sub

    Private Sub TextDisc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextDisc.TextChanged

        Dim bayar, sisa As Integer
        If TextDisc.Text = "" Then
            If ComboxJenisBayar.Text = "CASH" Then
                If CBPajak.Checked = True Then
                    TextBayar.Text = TextHasilPPN.Text
                    bayar = TextBayar.Text
                    TextGrandTotalBeli.Text = Format(Val(bayar), "Rp, ###,###,###")
                Else
                    TextBayar.Text = TextGrandVisible.Text
                    bayar = TextBayar.Text
                    TextGrandTotalBeli.Text = Format(Val(bayar), "Rp, ###,###,###")
                End If
            ElseIf ComboxJenisBayar.Text = "ANGSURAN" Then
                If CBPajak.Checked = True Then
                    TextTagihan.Text = TextHasilPPN.Text
                    sisa = TextTagihan.Text
                    TextGrandTotalBeli.Text = Format(Val(sisa), "Rp, ###,###,###")
                Else
                    TextTagihan.Text = TextGrandVisible.Text
                    sisa = TextTagihan.Text
                    TextGrandTotalBeli.Text = Format(Val(sisa), "Rp, ###,###,###")
                End If
            End If
        End If
    End Sub
End Class