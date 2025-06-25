Imports Microsoft.Reporting.WinForms

Public Class LaporanPenjualan
    Dim dt As DataTable

    ' Constructor untuk Menerima Data dari FormLaporanBarang
    Public Sub New(data As DataTable)
        InitializeComponent()
        dt = data
    End Sub

    ' Load Data ke ReportViewer saat Form Dibuka
    Private Sub LaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Set DataSource untuk ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt) ' Sesuaikan nama dataset di RDLC
            ReportViewerPenjualan.LocalReport.DataSources.Clear()
            ReportViewerPenjualan.LocalReport.DataSources.Add(rds)
            ReportViewerPenjualan.LocalReport.ReportPath = "C:\Users\acer\source\repos\minggu 7\minggu 7\ReportPenjualan.rdlc" ' Path file laporan
            ReportViewerPenjualan.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ReportViewerPenjualan_Load(sender As Object, e As EventArgs) Handles ReportViewerPenjualan.Load

    End Sub
End Class