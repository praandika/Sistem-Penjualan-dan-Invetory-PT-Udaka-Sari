Public Class MenuRetur
    Private Sub BtnReturJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReturJual.Click
        MenuUtama.LblHeader.Text = "Retur Penjualan"
        Call MenuUtama.TampilForm(New DaftarReturPenjualan)
    End Sub

    Private Sub BtnReturBeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReturBeli.Click
        MenuUtama.LblHeader.Text = "Retur Pembelian"
        Call MenuUtama.TampilForm(New DaftarReturPembelian)
    End Sub

    Private Sub BtnDataReturJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataReturJual.Click
        MenuUtama.LblHeader.Text = "Data Retur Penjualan"
        Call MenuUtama.TampilForm(New DataReturPenjualan)
    End Sub

    Private Sub BtnDataReturBeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDataReturBeli.Click
        MenuUtama.LblHeader.Text = "Data Retur Pembelian"
        Call MenuUtama.TampilForm(New DataReturPembelian)
    End Sub

    Private Sub MenuRetur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MenuUtama.LabelHakAkses.Text = "Penjualan" Then
            BtnReturBeli.Enabled = False
            BtnDataReturBeli.Enabled = False
            BtnReturBeli.BackColor = Color.LightGray
            BtnDataReturBeli.BackColor = Color.LightGray
        ElseIf MenuUtama.LabelHakAkses.Text = "Inventory" Then
            BtnReturJual.Enabled = False
            BtnDataReturJual.Enabled = False
            BtnReturJual.BackColor = Color.LightGray
            BtnDataReturJual.BackColor = Color.LightGray
        Else
            BtnReturJual.Enabled = True
            BtnDataReturJual.Enabled = True
        End If
    End Sub
End Class