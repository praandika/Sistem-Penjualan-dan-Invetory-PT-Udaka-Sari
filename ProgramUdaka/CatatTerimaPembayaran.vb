Public Class CatatTerimaPembayaran
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim penjualan As DataTable
    Dim txt1, txt2, txt3, txt4 As Long
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Sub DGKolom()
        DGCatatPembayaran.DataSource = penjualan
        DGCatatPembayaran.Columns(0).Width = 100
        DGCatatPembayaran.Columns(1).Width = 100
        DGCatatPembayaran.Columns(2).Width = 100
        DGCatatPembayaran.Columns(3).Width = 100
        DGCatatPembayaran.Columns(4).Width = 120
        DGCatatPembayaran.Columns(5).Width = 100
        DGCatatPembayaran.Columns(5).DefaultCellStyle.Format = "###,###,###,0"
        DGCatatPembayaran.Columns(6).Width = 100
        DGCatatPembayaran.Columns(6).DefaultCellStyle.Format = "###,###,###,0"
        DGCatatPembayaran.Columns(7).Width = 100
        DGCatatPembayaran.Columns(7).DefaultCellStyle.Format = "###,###,###,0"
        DGCatatPembayaran.Columns(8).Width = 100
        DGCatatPembayaran.Columns(9).Width = 100
        DGCatatPembayaran.Columns(10).Width = 100
        DGCatatPembayaran.Columns(11).Width = 100
    End Sub

    Sub Data_Record()
        penjualan = Proses.ExecuteQuery("SELECT penjualan.NO_NOTA, pelanggan.NAMA_PELANGGAN, penjualan.TGL_TRANSAKSI, penjualan.TGL_PEMBAYARAN, penjualan.JENIS_PEMBAYARAN, penjualan.GRAND_TOTAL, penjualan.BAYAR, penjualan.SISA_TAGIHAN, penjualan.JATUH_TEMPO, penjualan.STATUS_TRANSAKSI, penjualan.ID_PENJUALAN, penjualan.ID_PELANGGAN FROM penjualan INNER JOIN pelanggan ON pelanggan.ID_PELANGGAN = penjualan.ID_PELANGGAN WHERE penjualan.STATUS_TRANSAKSI = 'UTANG' OR penjualan.STATUS_TRANSAKSI = 'JATUH TEMPO' ORDER BY penjualan.NO_NOTA DESC")
        Call DGKolom()
    End Sub

    Sub HitungDanSimpan()
        Dim grand, sisa, bayar, pembayaran As Integer
        grand = Val(TextGrandTotal.Text)
        pembayaran = Val(TextJmlBayarVisible.Text)
        bayar = Val(TextBayar.Text)
        sisa = Val(TextSisa.Text)

        If pembayaran > sisa Then
            MsgBoxWarning.TextMsg.Text = "Jumlah pembayaran tidak sesuai"
            MsgBoxWarning.ShowDialog()
        Else
            bayar = bayar + pembayaran
            sisa = grand - bayar
            TextBayar.Text = bayar
            TextSisa.Text = sisa

            If TextSisa.Text = 0 Then
                LabelStatus.Text = "LUNAS"
            End If

            SQL = "UPDATE penjualan SET TGL_PEMBAYARAN = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', BAYAR = '" & TextBayar.Text & "', SISA_TAGIHAN = '" & TextSisa.Text & "', STATUS_TRANSAKSI = '" & LabelStatus.Text & "' WHERE ID_PENJUALAN = '" & TextKode.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "catatan sudah tersimpan"
            MsgBoxBerhasil.ShowDialog()
            Call Data_Record()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CatatTerimaPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextKode.Visible = False
        TextGrandTotal.Visible = False
        TextSisa.Visible = False
        TextBayar.Visible = False
        TextJmlBayarVisible.Visible = False
        Call Data_Record()
    End Sub

    Private Sub CatatTerimaPembayaran_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub DGCatatPembayaran_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCatatPembayaran.CellClick
        Dim baris As Integer
        With DGCatatPembayaran
            baris = .CurrentRow.Index
            TextKode.Text = .Item(10, baris).Value
            TextGrandTotal.Text = .Item(5, baris).Value
            TextSisa.Text = .Item(7, baris).Value
            TextBayar.Text = .Item(6, baris).Value
            LabelNota.Text = .Item(0, baris).Value
            LabelNamaPel.Text = .Item(1, baris).Value
            LabelTglJatuhTempo.Text = .Item(8, baris).Value
            LabelGrandTotal.Text = .Item(5, baris).Value
            LabelBayar.Text = .Item(6, baris).Value
            LabelSisa.Text = .Item(7, baris).Value
            LabelStatus.Text = .Item(9, baris).Value
        End With
    End Sub

    Private Sub LabelGrandTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelGrandTotal.TextChanged
        txt1 = LabelGrandTotal.Text
        LabelGrandTotal.Text = Format(Val(txt1), "###,###,0")
    End Sub

    Private Sub LabelSisa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelSisa.TextChanged
        txt2 = LabelSisa.Text
        LabelSisa.Text = Format(Val(txt2), "###,###,0")
    End Sub

    Private Sub TextJumlahPembayaran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextJumlahPembayaran.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            PanelNotif.Location = New Point(421, 204)
            Do Until PanelNotif.Location.Y = 225
                PanelNotif.Location = New Point(421, PanelNotif.Location.Y + 1)
                System.Threading.Thread.Sleep(1)
            Loop
        End If
    End Sub

    Private Sub TextJumlahPembayaran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextJumlahPembayaran.TextChanged
        If TextJumlahPembayaran.Text = "" Or Not IsNumeric(TextJumlahPembayaran.Text) Then
            Exit Sub
        End If
        txt3 = TextJumlahPembayaran.Text
        TextJumlahPembayaran.Text = Format(Val(txt3), "###,###,0")
        TextJumlahPembayaran.SelectionStart = Len(TextJumlahPembayaran.Text)
        TextJmlBayarVisible.Text = CLng(TextJumlahPembayaran.Text)
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        TextJmlBayarVisible.Clear()
        TextJumlahPembayaran.Clear()
        TextJumlahPembayaran.Focus()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Call HitungDanSimpan()
        TextJumlahPembayaran.Clear()
    End Sub

    Private Sub PanelNotif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelNotif.Click
        Do Until PanelNotif.Location.Y = 204
            PanelNotif.Location = New Point(421, PanelNotif.Location.Y - 1)
            System.Threading.Thread.Sleep(1)
        Loop
    End Sub

    Private Sub LblNotif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNotif.Click
        Do Until PanelNotif.Location.Y = 204
            PanelNotif.Location = New Point(421, PanelNotif.Location.Y - 1)
            System.Threading.Thread.Sleep(1)
        Loop
    End Sub

    Private Sub LabelBayar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelBayar.TextChanged
        txt4 = LabelBayar.Text
        LabelBayar.Text = Format(Val(txt4), "###,###,0")
    End Sub

    Private Sub DGCatatPembayaran_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGCatatPembayaran.CellFormatting
        If DGCatatPembayaran.Columns(e.ColumnIndex).Name = "STATUS_TRANSAKSI" Then
            If (Convert.ToString(e.Value) = "JATUH TEMPO") Then
                e.CellStyle.BackColor = Color.LightPink
            End If
        End If
    End Sub
End Class