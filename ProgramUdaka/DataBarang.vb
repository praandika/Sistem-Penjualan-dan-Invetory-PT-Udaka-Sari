Imports CrystalDecisions.CrystalReports.Engine
Public Class DataBarang
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim barang As DataTable

    Sub Kolom()
        DGBarang.DataSource = barang
        DGBarang.Columns(0).Width = 80
        DGBarang.Columns(1).Width = 435
        DGBarang.Columns(2).Width = 140
        DGBarang.Columns(3).Width = 100
        DGBarang.Columns(3).DefaultCellStyle.Format = "###,###,###"
        DGBarang.Columns(4).Width = 100
        DGBarang.Columns(4).DefaultCellStyle.Format = "###,###,###"
        DGBarang.Columns(5).Width = 100
        DGBarang.Columns(6).Width = 100
    End Sub

    Public Sub Data_Record()
        barang = Proses.ExecuteQuery("SELECT * FROM barang ORDER BY ID_BARANG DESC")
        Call Kolom()
    End Sub

    Sub Cari_Data()
        barang = Proses.ExecuteQuery("SELECT * FROM barang WHERE NAMA_BARANG LIKE '%" & TextCari.Text & "%' ORDER BY NAMA_BARANG ASC")
        Call Kolom()
    End Sub

    Private Sub Data_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        TextBrg.Visible = False
        Rb_Nama.Checked = True
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        TambahBarang.Show()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        UbahBarang.TextKodeUbah.Text = TextKodeUbah.Text
        UbahBarang.Show()
    End Sub

    Private Sub TextCari_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If Rb_Kode.Checked = True Then
            Dim Dv As New DataView(barang)
            Dv.RowFilter = String.Format("ID_BARANG LIKE '%{0}%'", TextCari.Text)
            DGBarang.DataSource = Dv
        ElseIf Rb_Nama.Checked = True Then
            Dim Dv As New DataView(barang)
            Dv.RowFilter = String.Format("NAMA_BARANG LIKE '%{0}%'", TextCari.Text)
            DGBarang.DataSource = Dv
            'Call Cari_Data()
        End If
    End Sub

    Private Sub DGBarang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBarang.CellClick
        Dim baris As Integer
        With DGBarang
            baris = .CurrentRow.Index
            TextKodeUbah.Text = .Item(0, baris).Value
            TextBrg.Text = .Item(1, baris).Value
        End With
    End Sub

    Private Sub BtnBrgDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrgDetail.Click
        DataBarangDetail.TextKode.Text = TextKodeUbah.Text
        DataBarangDetail.LabelNamaBrg.Text = TextBrg.Text
        DataBarangDetail.Show()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        FormLaporanBarang.CRViewBarang.ReportSource = "ReportBarang.rpt"
        FormLaporanBarang.CRViewBarang.SelectionFormula = "{pengguna1.NAMA_DEPAN} = '" + MenuUtama.LabelNama.Text + "'"
        FormLaporanBarang.CRViewBarang.RefreshReport()
        FormLaporanBarang.ShowDialog()
    End Sub

    Private Sub DGBarang_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGBarang.CellFormatting
        If DGBarang.Columns(e.ColumnIndex).Name = "STOK_BARANG" Then
            If (Convert.ToInt64(e.Value) <= 10) Then
                e.CellStyle.BackColor = Color.IndianRed
                e.CellStyle.ForeColor = Color.LavenderBlush
            ElseIf (Convert.ToInt64(e.Value) <= 15) Then
                e.CellStyle.BackColor = Color.LightSalmon
                e.CellStyle.ForeColor = Color.DarkRed
            Else
                e.CellStyle.BackColor = Color.PaleGreen
                e.CellStyle.ForeColor = Color.DarkGreen
            End If
        End If
    End Sub
End Class