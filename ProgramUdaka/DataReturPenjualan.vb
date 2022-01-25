Imports MySql.Data.MySqlClient
Public Class DataReturPenjualan
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim penjualan As DataTable

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
        DGdatareturpenjualan.DataSource = penjualan
        DGdatareturpenjualan.Columns(0).Width = 100
        DGdatareturpenjualan.Columns(1).Width = 100
        DGdatareturpenjualan.Columns(2).Width = 100
        DGdatareturpenjualan.Columns(3).Width = 100
        DGdatareturpenjualan.Columns(4).Width = 120
        DGdatareturpenjualan.Columns(5).Width = 100
        DGdatareturpenjualan.Columns(6).Width = 100
        DGdatareturpenjualan.Columns(6).DefaultCellStyle.Format = "###,###,###,0"
        DGdatareturpenjualan.Columns(7).Width = 100
        DGdatareturpenjualan.Columns(8).Width = 100
        DGdatareturpenjualan.Columns(9).Width = 100
        DGdatareturpenjualan.Columns(10).Width = 100
        DGdatareturpenjualan.Columns(11).Width = 100
    End Sub

    Sub Data_Record()
        penjualan = Proses.ExecuteQuery("SELECT retur_penjualan.ID_RETUR_PENJUALAN, barang.NAMA_BARANG, pelanggan.NAMA_PELANGGAN, retur_penjualan.ID_PENJUALAN, retur_penjualan.QTY_NOTA, retur_penjualan.QTY_RETUR, retur_penjualan.TOTAL_RETUR, retur_penjualan.TANGGAL_RETUR, retur_penjualan.ALASAN_RETUR, retur_penjualan.KETERANGAN, retur_penjualan.STATUS_RETUR, retur_penjualan.ID_BARANG FROM retur_penjualan INNER JOIN barang ON barang.ID_BARANG = retur_penjualan.ID_BARANG INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = retur_penjualan.ID_PELANGGAN WHERE retur_penjualan.STATUS_RETUR = 'Ditunda' ORDER BY retur_penjualan.TANGGAL_RETUR DESC")
        Call DGKolom()
    End Sub

    Sub HitungQTY()
        Dim qtybrg, qtyretur, qtyhasil As Integer
        qtybrg = Val(TextQTYBrg.Text)
        qtyretur = Val(TextQTYRetur.Text)

        If qtybrg >= qtyretur Then
            qtyhasil = qtybrg + qtyretur
            TextQTYHasil.Text = qtyhasil
            SQL = "UPDATE barang SET STOK_BARANG = '" & TextQTYHasil.Text & "' WHERE ID_BARANG = '" & TextKdBrg.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            SQL = "UPDATE retur_penjualan SET STATUS_RETUR = 'Selesai' WHERE ID_RETUR_PENJUALAN = '" & TextDetail.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            SQL = "INSERT INTO barang_detail VALUES ('" & TextKdBrg.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Retur penjualan dengan nota " & TextDetail.Text & "','0','" & TextQTYRetur.Text & "','" & MenuUtama.LabelUsername.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "Retur penjualan selesai"
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

    Private Sub TextKdBrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextKdBrg.TextChanged
        Call TampilStok()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Call MenuUtama.TampilForm(New MenuRetur)
        Me.Close()
    End Sub

    Private Sub DataReturPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextKdBrg.Visible = False
        TextQTYBrg.Visible = False
        TextQTYRetur.Visible = False
        TextQTYHasil.Visible = False
        TextBrg.Visible = False
        Call Data_Record()
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If ComboxCari.Text = "Nama Barang" Then
            penjualan = Proses.ExecuteQuery("SELECT retur_penjualan.ID_RETUR_PENJUALAN, barang.NAMA_BARANG, pelanggan.NAMA_PELANGGAN, retur_penjualan.ID_PENJUALAN, retur_penjualan.QTY_NOTA, retur_penjualan.QTY_RETUR, retur_penjualan.TOTAL_RETUR, retur_penjualan.TANGGAL_RETUR, retur_penjualan.ALASAN_RETUR, retur_penjualan.KETERANGAN, retur_penjualan.STATUS_RETUR, retur_penjualan.ID_BARANG FROM retur_penjualan INNER JOIN barang ON barang.ID_BARANG = retur_penjualan.ID_BARANG INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = retur_penjualan.ID_PELANGGAN WHERE retur_penjualan.STATUS_RETUR = 'Ditunda' AND barang.NAMA_BARANG LIKE '%" & TextCari.Text & "%' ORDER BY retur_penjualan.TANGGAL_RETUR DESC")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Nama Pelanggan" Then
            penjualan = Proses.ExecuteQuery("SELECT retur_penjualan.ID_RETUR_PENJUALAN, barang.NAMA_BARANG, pelanggan.NAMA_PELANGGAN, retur_penjualan.ID_PENJUALAN, retur_penjualan.QTY_NOTA, retur_penjualan.QTY_RETUR, retur_penjualan.TOTAL_RETUR, retur_penjualan.TANGGAL_RETUR, retur_penjualan.ALASAN_RETUR, retur_penjualan.KETERANGAN, retur_penjualan.STATUS_RETUR, retur_penjualan.ID_BARANG FROM retur_penjualan INNER JOIN barang ON barang.ID_BARANG = retur_penjualan.ID_BARANG INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = retur_penjualan.ID_PELANGGAN WHERE retur_penjualan.STATUS_RETUR = 'Ditunda' AND pelanggan.NAMA_PELANGGAN LIKE '%" & TextCari.Text & "%' ORDER BY retur_penjualan.TANGGAL_RETUR DESC")
            Call DGKolom()

        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        penjualan = Proses.ExecuteQuery("SELECT retur_penjualan.ID_RETUR_PENJUALAN, barang.NAMA_BARANG, pelanggan.NAMA_PELANGGAN, retur_penjualan.ID_PENJUALAN, retur_penjualan.QTY_NOTA, retur_penjualan.QTY_RETUR, retur_penjualan.TOTAL_RETUR, retur_penjualan.TANGGAL_RETUR, retur_penjualan.ALASAN_RETUR, retur_penjualan.KETERANGAN, retur_penjualan.STATUS_RETUR, retur_penjualan.ID_BARANG FROM retur_penjualan INNER JOIN barang ON barang.ID_BARANG = retur_penjualan.ID_BARANG INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = retur_penjualan.ID_PELANGGAN WHERE retur_penjualan.STATUS_RETUR = 'Ditunda' AND retur_penjualan.TANGGAL_RETUR BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' ORDER BY retur_penjualan.TANGGAL_RETUR DESC '")
        Call DGKolom()
    End Sub

    Private Sub DGdatareturpenjualan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGdatareturpenjualan.CellClick
        Dim baris As Integer
        With DGdatareturpenjualan
            baris = .CurrentRow.Index
            TextDetail.Text = .Item(0, baris).Value
            TextBrg.Text = .Item(1, baris).Value
            TextKdBrg.Text = .Item(11, baris).Value
            TextQTYRetur.Text = .Item(5, baris).Value
        End With
    End Sub

    Private Sub BtnSelesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelesai.Click
        Call HitungQTY()
        Call Data_Record()
    End Sub

    Private Sub BtnCetak1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak1.Click
        FormLaporanReturPenjualan.CRViewLaporanReturJual.ReportSource = "ReportReturPenjualan.rpt"
        FormLaporanReturPenjualan.CRViewLaporanReturJual.SelectionFormula = "{retur_penjualan1.TANGGAL_RETUR} >= #" & Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") & "# and {retur_penjualan1.TANGGAL_RETUR} <= #" & Format(Me.DateTimePicker2.Value, "yyyy-MM-dd") & "# AND {pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanReturPenjualan.CRViewLaporanReturJual.RefreshReport()
        FormLaporanReturPenjualan.ShowDialog()
    End Sub
End Class