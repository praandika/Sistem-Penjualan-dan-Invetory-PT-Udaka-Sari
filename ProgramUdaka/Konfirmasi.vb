Imports MySql.Data.MySqlClient
Public Class Konfirmasi
    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Dim DR As MySqlDataReader
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Dim SQL As String
    Dim Proses As New ClsKoneksi

    Sub Koneksi()
        Conn = New MySqlConnection("server=localhost;" _
        & "user id=root;" _
        & "password=;" _
        & "database=udakasari")

        conn.Open()
        If conn.State <> ConnectionState.Open Then
            MsgBox("Koneksi Gagal", MsgBoxStyle.Critical, "Access Failed")
        End If
    End Sub

    Sub Data_Foto()
        Call Koneksi()
        Dim SQL As String
        SQL = "SELECT * FROM pengguna WHERE USERNAME = '" & LblUser.Text & "'"
        CMD = New MySqlCommand(SQL, Conn)
        RD = CMD.ExecuteReader
        If RD.Read Then
            PictureBox1.ImageLocation = RD("DESK")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Conn.Close()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnKonfirmasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKonfirmasi.Click
        Try
            If TextPass.Text = "" Then
                MsgBoxWarning.TextMsg.Text = "Masukkan password"
                MsgBoxWarning.ShowDialog()
            Else
                Call Koneksi()
                CMD = New MySqlCommand("SELECT * FROM pengguna WHERE USERNAME='" + Trim(LblUser.Text) + "' AND PASSWORD=MD5('" + Trim(TextPass.Text) + "')", Conn)
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Penjualan.confirm = True
                    If Penjualan.confirm = True Then
                        Me.Close()
                        TextPass.Clear()
                        Dim stok, out As Integer
                        stok = Val(Penjualan.TextStok.Text)
                        out = Val(Penjualan.TextOut.Text)
                        stok = out + stok
                        Penjualan.TextStok.Text = stok

                        'SQL = "UPDATE barang SET STOK_BARANG = '" & TextStok.Text & "' WHERE ID_BARANG = '" & TextIDbrg.Text & "'"
                        'Proses.ExecuteNonQuery(SQL)

                        SQL = "DELETE FROM transaksi WHERE ID_TRANSAKSI = '" & Penjualan.TextKodeTransaksiVisible.Text & "'"
                        Proses.ExecuteNonQuery(SQL)
                        'Call Kode_Nota()
                        SQL = "INSERT INTO log VALUES ('" & Format(MenuUtama.DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','" & MenuUtama.LabelUsername.Text & "','Menghapus barang " & Penjualan.TextBrgJual.Text & " dari nota penjualan','" & Penjualan.TextKodeTransaksiVisible.Text & "')"
                        Proses.ExecuteNonQuery(SQL)
                        SQL = "INSERT INTO barang_detail VALUES ('" & Penjualan.TextIDbrg.Text & "','" & Format(Penjualan.DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(Penjualan.DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Barang dihapus dari nota penjualan " & Penjualan.TextNota.Text & "','" & Penjualan.TextOut.Text & "','0','" & MenuUtama.LabelUsername.Text & "')"
                        Proses.ExecuteNonQuery(SQL)
                        MsgBoxBerhasil.TextMsg.Text = "data sudah terhapus"
                        MsgBoxBerhasil.ShowDialog()
                        Penjualan.DGTransaksi.Rows.RemoveAt(Penjualan.DGTransaksi.CurrentRow.Index)
                        Penjualan.BtnHapus.Enabled = False
                        Penjualan.BtnHapus.BackColor = Color.Gray
                        Call Penjualan.Hapus_Total()
                        Penjualan.TextOut.Clear()
                        Call Penjualan.Data_Record()
                        Call Penjualan.Kode_Transaksi()
                        Penjualan.TextKodeTransaksiVisible.Clear()
                        Penjualan.ComboxJenisBayar.Text = ""
                        Penjualan.TextBayar.Clear()
                        Penjualan.TextSisaTagihan.Clear()
                        Penjualan.TextSttsTrans.Clear()
                        MenuUtama.TampilForm(Penjualan)
                    Else
                        MsgBox("Confirm False")
                    End If
                Else
                    MsgBoxWarning.TextMsg.Text = "Password salah"
                    MsgBoxWarning.ShowDialog()
                    TextPass.Clear()
                    TextPass.Focus()
                End If
                Conn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Konfirmasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextPass.Focus()
        Call Data_Foto()
    End Sub
End Class