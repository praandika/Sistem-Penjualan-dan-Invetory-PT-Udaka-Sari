Public Class DaftarReturPembelian
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pembelian As DataTable

    Sub DGKolom()
        DGdatapembelian.DataSource = pembelian
        DGdatapembelian.Columns(0).Width = 100
        DGdatapembelian.Columns(1).Width = 100
        DGdatapembelian.Columns(2).Width = 100
        DGdatapembelian.Columns(3).Width = 100
        DGdatapembelian.Columns(4).Width = 120
        DGdatapembelian.Columns(5).Width = 100
        DGdatapembelian.Columns(5).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapembelian.Columns(6).Width = 100
        DGdatapembelian.Columns(6).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapembelian.Columns(7).Width = 100
        DGdatapembelian.Columns(7).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapembelian.Columns(8).Width = 100
        DGdatapembelian.Columns(9).Width = 100
        DGdatapembelian.Columns(10).Width = 100
    End Sub

    Sub Data_Record()
        pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TGL_BAYAR, pembelian.JENIS_BAYAR, pembelian.GRAND_TOTAL_BELI, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI, pembelian.ID_PEMBELIAN, pembelian.ID_SUPPLIER FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.STATUS_TRANSAKSI_BELI = 'LUNAS' ORDER BY pembelian.TGL_BELI DESC")
        Call DGKolom()
    End Sub

    Private Sub DaftarReturPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextKodePembelian.Visible = False
        TextKodeSup.Visible = False
        TextTotal.Visible = False
        TextBayar.Visible = False
        TextSisa.Visible = False
        Call Data_Record()
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If ComboxCari.Text = "No Nota" Then
            pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TGL_BAYAR, pembelian.JENIS_BAYAR, pembelian.GRAND_TOTAL_BELI, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI, pembelian.ID_PEMBELIAN, pembelian.ID_SUPPLIER FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.NOTA_PEMBELIAN LIKE '%" & TextCari.Text & "%' AND pembelian.STATUS_TRANSAKSI_BELI = 'LUNAS'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Jenis Pembayaran" Then
            pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TGL_BAYAR, pembelian.JENIS_BAYAR, pembelian.GRAND_TOTAL_BELI, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI, pembelian.ID_PEMBELIAN, pembelian.ID_SUPPLIER FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.PEMBAYARAN LIKE '%" & TextCari.Text & "%' AND pembelian.STATUS_TRANSAKSI_BELI = 'LUNAS'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Nama Supplier" Then
            pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TGL_BAYAR, pembelian.JENIS_BAYAR, pembelian.GRAND_TOTAL_BELI, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI, pembelian.ID_PEMBELIAN, pembelian.ID_SUPPLIER FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE supplier.NAMA_SUPPLIER LIKE '%" & TextCari.Text & "%' AND pembelian.STATUS_TRANSAKSI_BELI = 'LUNAS'")
            Call DGKolom()
        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TGL_BAYAR, pembelian.JENIS_BAYAR, pembelian.GRAND_TOTAL_BELI, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI, pembelian.ID_PEMBELIAN, pembelian.ID_SUPPLIER FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.TGL_BELI BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' AND pembelian.STATUS_TRANSAKSI_BELI = 'LUNAS'")
        Call DGKolom()
    End Sub

    Private Sub DGdatapembelian_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdatapembelian.CellClick
        Dim baris As Integer
        With DGdatapembelian
            baris = .CurrentRow.Index
            TextDetail.Text = .Item(0, baris).Value
            TextKodePembelian.Text = .Item(9, baris).Value
            TextKodeSup.Text = .Item(10, baris).Value
            TextTotal.Text = .Item(5, baris).Value
            TextBayar.Text = .Item(6, baris).Value
            TextSisa.Text = .Item(7, baris).Value
        End With
    End Sub

    Private Sub BtnRetur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetur.Click
        ReturPembelian.LabelNota.Text = TextDetail.Text
        ReturPembelian.TextKodePembelian.Text = TextKodePembelian.Text
        ReturPembelian.TextKodeSup.Text = TextKodeSup.Text
        ReturPembelian.TextTotal.Text = TextTotal.Text
        ReturPembelian.TextBayar.Text = TextBayar.Text
        ReturPembelian.TextSisa.Text = TextSisa.Text
        ReturPembelian.Show()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuRetur)
        Me.Close()
    End Sub
End Class