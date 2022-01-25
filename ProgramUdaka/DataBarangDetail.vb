Public Class DataBarangDetail
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim barangdetail As DataTable
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Sub DGKolom()
        DGBarangDetail.DataSource = barangdetail
        DGBarangDetail.Columns(0).Width = 90
        DGBarangDetail.Columns(1).Width = 120
        DGBarangDetail.Columns(2).Width = 480
        DGBarangDetail.Columns(3).Width = 70
        DGBarangDetail.Columns(4).Width = 70
    End Sub

    Sub DataRecord()
        barangdetail = Proses.ExecuteQuery("SELECT USERNAME, TANGGAL_WAKTU, DESKRIPSI, QTY_IN, QTY_OUT FROM barang_detail WHERE ID_BARANG = '" & TextKode.Text & "' ORDER BY TANGGAL_WAKTU DESC")
        Call DGKolom()
    End Sub

    Private Sub DataBarangDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DataRecord()
    End Sub

    Private Sub BtnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DataBarangDetail_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub
End Class