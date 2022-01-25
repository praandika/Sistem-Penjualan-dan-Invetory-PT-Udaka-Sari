Public Class DataPelanggan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pelanggan As DataTable
    Sub DGKolom()
        DGpelanggan.DataSource = pelanggan
        DGpelanggan.Columns(0).Width = 80
        DGpelanggan.Columns(1).Width = 300
        DGpelanggan.Columns(2).Width = 100
        DGpelanggan.Columns(3).Width = 400
        DGpelanggan.Columns(4).Width = 100
        DGpelanggan.Columns(5).Width = 250
    End Sub

    Sub Data_Record()
        pelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan ORDER BY NAMA_PELANGGAN ASC")
        Call DGKolom()
    End Sub

    Private Sub DataPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        If ComboxCari.Text = "ID Pelanggan" Then
            pelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan WHERE ID_PELANGGAN LIKE '%" & TextCari.Text & "%' ORDER BY NAMA_PELANGGAN ASC")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Nama Pelanggan" Then
            pelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan WHERE NAMA_PELANGGAN LIKE '%" & TextCari.Text & "%' ORDER BY NAMA_PELANGGAN ASC")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Jenis Pelanggan" Then
            pelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan WHERE JENIS_PELANGGAN LIKE '%" & TextCari.Text & "%' ORDER BY NAMA_PELANGGAN ASC")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Alamat Pelanggan" Then
            pelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan WHERE ALAMAT_PELANGGAN LIKE '%" & TextCari.Text & "%' ORDER BY NAMA_PELANGGAN ASC")
            Call DGKolom()

        ElseIf ComboxCari.Text = "No Telp Pelanggan" Then
            pelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan WHERE NO_TELP_PELANGGAN LIKE '%" & TextCari.Text & "%' ORDER BY NAMA_PELANGGAN ASC")
            Call DGKolom()

        ElseIf ComboxCari.Text = "Email Pelanggan" Then
            pelanggan = Proses.ExecuteQuery("SELECT * FROM pelanggan WHERE EMAIL_PELANGGAN LIKE '%" & TextCari.Text & "%' ORDER BY NAMA_PELANGGAN ASC")
            Call DGKolom()
        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        TambahPelanggan.Show()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        UbahPelanggan.TextKodeCusUbah.Text = TextKodeCusUbah.Text
        UbahPelanggan.Show()
    End Sub

    Private Sub DGpelanggan_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGpelanggan.CellClick
        Dim baris As Integer
        With DGpelanggan
            baris = .CurrentRow.Index
            TextKodeCusUbah.Text = .Item(0, baris).Value
        End With
    End Sub
End Class