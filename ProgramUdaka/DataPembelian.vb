Public Class DataPembelian
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pembelian As DataTable

    Sub DGKolom()
        DGdatapembelian.DataSource = pembelian
        DGdatapembelian.Columns(0).Width = 130
        DGdatapembelian.Columns(1).Width = 170
        DGdatapembelian.Columns(2).Width = 120
        DGdatapembelian.Columns(3).Width = 200
        DGdatapembelian.Columns(4).Width = 200
        DGdatapembelian.Columns(4).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapembelian.Columns(5).Width = 200
        DGdatapembelian.Columns(5).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapembelian.Columns(6).Width = 200
    End Sub

    Sub Data_Record()
        pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TOTAL_QTY, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER ORDER BY pembelian.NOTA_PEMBELIAN DESC")
        Call DGKolom()
    End Sub

    Private Sub DataPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        'If Rb_KodePem.Checked = True Then
        'Dim Dv As New DataView(pembelian)
        'Dv.RowFilter = String.Format("ID_PEMBELIAN LIKE '%{0}%'", TextCari.Text)
        'DGdatapembelian.DataSource = Dv
        'ElseIf Rb_Nota.Checked = True Then
        'Dim Dv As New DataView(pembelian)
        'Dv.RowFilter = String.Format("NOTA_PEMBELIAN LIKE '%{0}%'", TextCari.Text)
        'DGdatapembelian.DataSource = Dv
        'End If
        If ComboxCari.Text = "No Nota" Then
            pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TOTAL_QTY, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.NOTA_PEMBELIAN LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Status Transaksi" Then
            pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TOTAL_QTY, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.STATUS_TRANSAKSI_BELI LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Jenis Pembayaran" Then
            pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TOTAL_QTY, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.PEMBAYARAN LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Jatuh Tempo" Then
            pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TOTAL_QTY, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.JATUH_TEMPO_BELI LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()
        ElseIf ComboxCari.Text = "Nama Supplier" Then
            pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TOTAL_QTY, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE supplier.NAMA_SUPPLIER LIKE '%" & TextCari.Text & "%'")
            Call DGKolom()
        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        pembelian = Proses.ExecuteQuery("SELECT pembelian.NOTA_PEMBELIAN, supplier.NAMA_SUPPLIER, pembelian.TGL_BELI, pembelian.TOTAL_QTY, pembelian.PEMBAYARAN, pembelian.TAGIHAN, pembelian.STATUS_TRANSAKSI_BELI FROM pembelian INNER JOIN supplier ON supplier.ID_SUPPLIER = pembelian.ID_SUPPLIER WHERE pembelian.TGL_BELI BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'")
        Call DGKolom()
    End Sub

    Private Sub DGdatapembelian_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdatapembelian.CellClick
        Dim baris As Integer
        With DGdatapembelian
            baris = .CurrentRow.Index
            TextDetail.Text = .Item(0, baris).Value
        End With
    End Sub

    Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click
        DataPembelianDetail.TextDetail.Text = TextDetail.Text
        DataPembelianDetail.Show()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanPembelian.CRViewPembelian.ReportSource = "ReportPembelian.rpt"
        FormLaporanPembelian.CRViewPembelian.SelectionFormula = "{pembelian1.TGL_BELI}>= #" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "# and {pembelian1.TGL_BELI} <= #" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "# AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "' "
        FormLaporanPembelian.CRViewPembelian.RefreshReport()
        FormLaporanPembelian.ShowDialog()
    End Sub
End Class