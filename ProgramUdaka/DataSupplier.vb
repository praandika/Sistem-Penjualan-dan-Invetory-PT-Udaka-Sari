Public Class DataSupplier
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim supplier As DataTable

    Sub DGKolom()
        DGSupplier.DataSource = supplier
        DGSupplier.Columns(0).Width = 80
        DGSupplier.Columns(1).Width = 300
        DGSupplier.Columns(2).Width = 350
        DGSupplier.Columns(3).Width = 250
        DGSupplier.Columns(4).Width = 150
    End Sub

    Public Sub Data_Record()
        supplier = Proses.ExecuteQuery("SELECT * FROM supplier")
        Call DGKolom()
    End Sub

    Private Sub DataSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
    End Sub

    Private Sub TextCariSup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCariSup.TextChanged
        If ComboxCariSup.Text = "ID Supplier" Then
            supplier = Proses.ExecuteQuery("SELECT * FROM supplier WHERE ID_SUPPLIER LIKE '%" & TextCariSup.Text & "%'")
            Call DGKolom()
        ElseIf ComboxCariSup.Text = "Nama Supplier" Then
            supplier = Proses.ExecuteQuery("SELECT * FROM supplier WHERE NAMA_SUPPLIER LIKE '%" & TextCariSup.Text & "%'")
            Call DGKolom()
        ElseIf ComboxCariSup.Text = "Alamat Supplier" Then
            supplier = Proses.ExecuteQuery("SELECT * FROM supplier WHERE ALAMAT_SUPPLIER LIKE '%" & TextCariSup.Text & "%'")
            Call DGKolom()
        ElseIf ComboxCariSup.Text = "Email Supplier" Then
            supplier = Proses.ExecuteQuery("SELECT * FROM supplier WHERE EMAIL_SUPPLIER LIKE '%" & TextCariSup.Text & "%'")
            Call DGKolom()
        ElseIf ComboxCariSup.Text = "No. Telp" Then
            supplier = Proses.ExecuteQuery("SELECT * FROM supplier WHERE NO_TELP_SUPPLIER LIKE '%" & TextCariSup.Text & "%'")
            Call DGKolom()
        Else
            MsgBoxWarning.TextMsg.Text = "Pilih filter untuk mencari data"
            MsgBoxWarning.ShowDialog()
        End If
    End Sub

    Private Sub DGSupplier_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSupplier.CellClick
        Dim baris As Integer
        With DGSupplier
            baris = .CurrentRow.Index
            TextKodeSup.Text = .Item(0, baris).Value
        End With
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        TambahSupplier.Show()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        UbahSupplier.TextKodeSup.Text = TextKodeSup.Text
        UbahSupplier.Show()
    End Sub
End Class