Imports MySql.Data.MySqlClient

Public Class FormLaporanKaryawan
    ' Variabel untuk Koneksi
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim strConn As String = "server=127.0.0.1;user id=root;password=;database=db_toko_sepatu"

    ' Load Data saat Form Dibuka
    Private Sub FormLaporanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection(strConn)
        LoadDataBarang()
    End Sub

    ' Fungsi untuk Memuat Data
    Private Sub LoadDataBarang()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM karyawan"
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            DataGridViewKaryawan.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        ' Kirim DataTable ke Form Laporan
        Dim formLaporan As New LaporanKaryawan(dt)
        formLaporan.ShowDialog() ' Tampilkan form laporan
    End Sub

End Class