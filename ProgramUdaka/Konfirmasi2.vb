Imports MySql.Data.MySqlClient
Public Class Konfirmasi2
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
                    Pembelian.confirm = True
                    If Pembelian.confirm = True Then
                        Me.Close()
                        TextPass.Clear()
                        SQL = "DELETE FROM pembelian_detail WHERE ID_DETAIL = '" & Pembelian.TextIDPemDetailVisible.Text & "'"
                        Proses.ExecuteNonQuery(SQL)
                        SQL = "INSERT INTO log VALUES ('" & Format(MenuUtama.DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','" & MenuUtama.LabelUsername.Text & "','Menghapus barang " & Pembelian.TextBrgBeli.Text & " dari nota penjualan','" & Pembelian.TextIDPemDetailVisible.Text & "')"
                        Proses.ExecuteNonQuery(SQL)
                        SQL = "INSERT INTO barang_detail VALUES ('" & Pembelian.TextKodeBrg.Text & "','" & Format(Pembelian.DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(Pembelian.DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss") & "','Barang dihapus dari nota pembelian " & Pembelian.TextNoPem.Text & "','0','" & Pembelian.TextIn.Text & "','" & MenuUtama.LabelUsername.Text & "')"
                        Proses.ExecuteNonQuery(SQL)
                        MsgBoxBerhasil.TextMsg.Text = "data sudah terhapus"
                        MsgBoxBerhasil.ShowDialog()
                        Pembelian.DGPembelian.Rows.RemoveAt(Pembelian.DGPembelian.CurrentRow.Index)
                        Pembelian.BtnHapus.Enabled = False
                        Pembelian.BtnHapus.BackColor = Color.Gray
                        Call Pembelian.Hapus_Total()
                        Pembelian.TextIn.Clear()
                        Call Pembelian.Data_Record()
                        Call Pembelian.Kode_PemDetail()
                        Pembelian.TextIDPemDetailVisible.Clear()
                        Pembelian.ComboxJenisBayar.Text = ""
                        Pembelian.TextBayar.Clear()
                        Pembelian.TextTagihan.Clear()
                        Pembelian.TextSttsPem.Clear()
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

    Private Sub Konfirmasi2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextPass.Focus()
        Call Data_Foto()
    End Sub
End Class