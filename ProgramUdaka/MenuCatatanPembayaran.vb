Public Class MenuCatatanPembayaran
    
    Private Sub BtnCatatTerima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCatatTerima.Click
        CatatTerimaPembayaran.Show()
    End Sub

    Private Sub BtnCatatKirimPembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCatatKirimPembayaran.Click
        CatatKirimPembayaran.Show()
    End Sub
End Class