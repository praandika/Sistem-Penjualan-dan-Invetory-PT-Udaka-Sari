Public Class MenuBarangMasuk

    Private Sub BtnBarangMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBarangMasuk.Click
        MenuUtama.LblHeader.Text = "Barang Masuk"
        Call MenuUtama.TampilForm(New BarangMasuk)
    End Sub

    Private Sub BtnDataBarangMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataBarangMasuk.Click
        MenuUtama.LblHeader.Text = "Data Barang Masuk"
        Call MenuUtama.TampilForm(New DataBarangMasuk)
    End Sub

    Private Sub BtnBarangKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBarangKeluar.Click
        MenuUtama.LblHeader.Text = "Barang Keluar"
        Call MenuUtama.TampilForm(New BarangKeluar)
    End Sub

    Private Sub BtnDataBarangKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataBarangKeluar.Click
        MenuUtama.LblHeader.Text = "Data Barang Keluar"
        Call MenuUtama.TampilForm(New DataBarangKeluar)
    End Sub
End Class