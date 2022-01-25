Imports MySql.Data.MySqlClient
Public Class KelolaAdmin
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim pengguna As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Sub Kolom()
        DGadmin.DataSource = pengguna
        DGadmin.Columns(0).Width = 150
        DGadmin.Columns(1).Width = 100
        DGadmin.Columns(2).Width = 100
    End Sub

    Sub Data_Record()
        pengguna = Proses.ExecuteQuery("SELECT USERNAME, NAMA_DEPAN, NAMA_BELAKANG FROM pengguna")
        Call Kolom()
    End Sub

    Sub Cari_Data()
        pengguna = Proses.ExecuteQuery("SELECT USERNAME, NAMA_DEPAN, NAMA_BELAKANG FROM pengguna WHERE USERNAME LIKE '%" & TextCari.Text & "%'")
        Call Kolom()
    End Sub

    Private Sub KelolaAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        TextKode.Enabled = False
    End Sub

    Private Sub TextCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextCari.TextChanged
        Call Cari_Data()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub KelolaAdmin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim hapus
        hapus = MsgBox("Apakah Anda Yakin Menghapus Data Ini?", vbQuestion + vbYesNo)
        If hapus = vbYes Then
            SQL = "DELETE FROM pengguna WHERE USERNAME = '" & TextKode.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBoxBerhasil.TextMsg.Text = "Data pengguna sudah terhapus"
            MsgBoxBerhasil.ShowDialog()
            Call Data_Record()
            TextKode.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        TambahAdmin.Show()
        Me.Close()
    End Sub

    Private Sub DGadmin_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGadmin.CellClick
        Dim baris As Integer
        With DGadmin
            baris = .CurrentRow.Index
            TextKode.Text = .Item(0, baris).Value
        End With
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        UbahAdmin.TextUser.Text = TextKode.Text
        UbahAdmin.Show()
        Me.Close()
    End Sub
End Class