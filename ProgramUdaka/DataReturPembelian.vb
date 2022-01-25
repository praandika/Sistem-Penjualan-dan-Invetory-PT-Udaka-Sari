Imports MySql.Data.MySqlClient
Public Class DataReturPembelian
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pembelian As DataTable

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

    Sub DGKolom()
        DGdatapembelian.DataSource = pembelian
        DGdatapembelian.Columns(0).Width = 100
        DGdatapembelian.Columns(1).Width = 100
        DGdatapembelian.Columns(2).Width = 100
        DGdatapembelian.Columns(3).Width = 100
        DGdatapembelian.Columns(4).Width = 120
        DGdatapembelian.Columns(5).Width = 100
        DGdatapembelian.Columns(6).Width = 100
        DGdatapembelian.Columns(6).DefaultCellStyle.Format = "###,###,###,0"
        DGdatapembelian.Columns(7).Width = 100
        DGdatapembelian.Columns(8).Width = 100
        DGdatapembelian.Columns(9).Width = 100
        DGdatapembelian.Columns(10).Width = 100
        DGdatapembelian.Columns(11).Width = 100
    End Sub

    Sub ComboxSupplier()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT NAMA_SUPPLIER FROM supplier"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            Do While RD.Read
                ComboBoxSupplier.Items.Add(RD("NAMA_SUPPLIER"))
            Loop
        End If
        Conn.Close()
    End Sub

    Sub Data_Record()
        pembelian = Proses.ExecuteQuery("SELECT retur_pembelian.ID_RETUR_PEMBELIAN, barang.NAMA_BARANG, supplier.NAMA_SUPPLIER, retur_pembelian.ID_PEMBELIAN, retur_pembelian.QTY_NOTA_BELI, retur_pembelian.QTY_RETUR_BELI, retur_pembelian.TOTAL_RETUR_BELI, retur_pembelian.TANGGAL_RETUR_BELI, retur_pembelian.ALASAN_RETUR_BELI, retur_pembelian.KETERANGAN_RETUR, retur_pembelian.STATUS_RETUR_BELI, retur_pembelian.ID_BARANG FROM retur_pembelian INNER JOIN barang ON barang.ID_BARANG = retur_pembelian.ID_BARANG INNER JOIN supplier ON supplier.ID_SUPPLIER = retur_pembelian.ID_SUPPLIER WHERE retur_pembelian.STATUS_RETUR_BELI = 'Ditunda' ORDER BY retur_pembelian.TANGGAL_RETUR_BELI DESC")
        Call DGKolom()
    End Sub

    Sub Hitung_QTY()
        Dim qtybrg, qtyretur, qtyhasil As Integer
        qtybrg = Val(TextQTYBrg.Text)
        qtyretur = Val(TextQTYRetur.Text)

        If qtybrg >= qtyretur Then
            qtyhasil = qtybrg - qtyretur
            TextQTYHasil.Text = qtyhasil
            SQL = "UPDATE barang SET STOK_BARANG = '" & TextQTYHasil.Text & "' WHERE ID_BARANG = '" & TextKdBrg.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            SQL = "UPDATE retur_pembelian SET STATUS_RETUR_BELI = 'Selesai' WHERE ID_RETUR_PEMBELIAN = '" & TextDetail.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            SQL = "INSERT INTO barang_detail VALUES ('" & TextKdBrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Retur pembelian dengan nota " & TextDetail.Text & "','" & TextQTYRetur.Text & "','0','" & MenuUtama.LabelUsername.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "Retur pembelian selesai"
            MsgBoxBerhasil.ShowDialog()
        Else
            MsgBoxWarning.TextMsg.Text = "Stok barang tidak mencukupi"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Sub TampilStok()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT STOK_BARANG FROM barang WHERE ID_BARANG = '" & TextKdBrg.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextQTYBrg.Text = RD.Item("STOK_BARANG")
        End If
        Conn.Close()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuRetur)
        Me.Close()
    End Sub

    Private Sub TextKdBrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextKdBrg.TextChanged
        Call TampilStok()
    End Sub

    Private Sub DataReturPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        Call ComboxSupplier()
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If ComboxCari.Text = "Nama Barang" Then
            pembelian = Proses.ExecuteQuery("SELECT retur_pembelian.ID_RETUR_PEMBELIAN, barang.NAMA_BARANG, supplier.NAMA_SUPPLIER, retur_pembelian.ID_PEMBELIAN, retur_pembelian.QTY_NOTA_BELI, retur_pembelian.QTY_RETUR_BELI, retur_pembelian.TOTAL_RETUR_BELI, retur_pembelian.TANGGAL_RETUR_BELI, retur_pembelian.ALASAN_RETUR_BELI, retur_pembelian.KETERANGAN_RETUR, retur_pembelian.STATUS_RETUR_BELI, retur_pembelian.ID_BARANG FROM retur_pembelian INNER JOIN barang ON barang.ID_BARANG = retur_pembelian.ID_BARANG INNER JOIN supplier ON supplier.ID_SUPPLIER = retur_pembelian.ID_SUPPLIER WHERE retur_pembelian.STATUS_RETUR_BELI = 'Ditunda' AND barang.NAMA_BARANG LIKE '%" & TextCari.Text & "%' ORDER BY retur_pembelian.TANGGAL_RETUR_BELI DESC")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Nama Supplier" Then
            pembelian = Proses.ExecuteQuery("SELECT retur_pembelian.ID_RETUR_PEMBELIAN, barang.NAMA_BARANG, supplier.NAMA_SUPPLIER, retur_pembelian.ID_PEMBELIAN, retur_pembelian.QTY_NOTA_BELI, retur_pembelian.QTY_RETUR_BELI, retur_pembelian.TOTAL_RETUR_BELI, retur_pembelian.TANGGAL_RETUR_BELI, retur_pembelian.ALASAN_RETUR_BELI, retur_pembelian.KETERANGAN_RETUR, retur_pembelian.STATUS_RETUR_BELI, retur_pembelian.ID_BARANG FROM retur_pembelian INNER JOIN barang ON barang.ID_BARANG = retur_pembelian.ID_BARANG INNER JOIN supplier ON supplier.ID_SUPPLIER = retur_pembelian.ID_SUPPLIER WHERE retur_pembelian.STATUS_RETUR_BELI = 'Ditunda' AND supplier.NAMA_SUPPLIER LIKE '%" & TextCari.Text & "%' ORDER BY retur_pembelian.TANGGAL_RETUR_BELI DESC")
            Call DGKolom()

        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        pembelian = Proses.ExecuteQuery("SELECT retur_pembelian.ID_RETUR_PEMBELIAN, barang.NAMA_BARANG, supplier.NAMA_SUPPLIER, retur_pembelian.ID_PEMBELIAN, retur_pembelian.QTY_NOTA_BELI, retur_pembelian.QTY_RETUR_BELI, retur_pembelian.TOTAL_RETUR_BELI, retur_pembelian.TANGGAL_RETUR_BELI, retur_pembelian.ALASAN_RETUR_BELI, retur_pembelian.KETERANGAN_RETUR, retur_pembelian.STATUS_RETUR_BELI, retur_pembelian.ID_BARANG FROM retur_pembelian INNER JOIN barang ON barang.ID_BARANG = retur_pembelian.ID_BARANG INNER JOIN supplier ON supplier.ID_SUPPLIER = retur_pembelian.ID_SUPPLIER WHERE retur_pembelian.STATUS_RETUR_BELI = 'Ditunda' AND retur_pembelian.TANGGAL_RETUR_BELI BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' ORDER BY retur_pembelian.TANGGAL_RETUR_BELI DESC ")
        Call DGKolom()
    End Sub

    Private Sub DGdatapenjualan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdatapembelian.CellClick
        Dim baris As Integer
        With DGdatapembelian
            baris = .CurrentRow.Index
            TextDetail.Text = .Item(0, baris).Value
            TextBrg.Text = .Item(1, baris).Value
            TextKdBrg.Text = .Item(11, baris).Value
            TextQTYRetur.Text = .Item(5, baris).Value
        End With
    End Sub

    Private Sub BtnSelesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelesai.Click
        Call Hitung_QTY()
        Call Data_Record()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormReturPembelian.CRViewReturPembelian.ReportSource = "ReportNotaReturPembelian.rpt"
        FormReturPembelian.CRViewReturPembelian.SelectionFormula = "{supplier1.NAMA_SUPPLIER} = '" & ComboBoxSupplier.Text & "' and {retur_pembelian1.TANGGAL_RETUR_BELI} >= #" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "# and {retur_pembelian1.TANGGAL_RETUR_BELI} <= #" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "# and {retur_pembelian1.STATUS_RETUR_BELI} = 'Ditunda' AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormReturPembelian.CRViewReturPembelian.RefreshReport()
        FormReturPembelian.ShowDialog()
    End Sub

    Private Sub BtnCetak1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak1.Click
        FormLaporanReturPembelian.CRViewLaporanReturBeli.ReportSource = "ReportReturPembelian.rpt"
        FormLaporanReturPembelian.CRViewLaporanReturBeli.SelectionFormula = "{retur_pembelian1.TANGGAL_RETUR_BELI} >= #" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "# and {retur_pembelian1.TANGGAL_RETUR_BELI} <= #" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "# AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanReturPembelian.CRViewLaporanReturBeli.RefreshReport()
        FormLaporanReturPembelian.ShowDialog()
    End Sub
End Class