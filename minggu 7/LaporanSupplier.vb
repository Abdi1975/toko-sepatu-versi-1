Imports Microsoft.Reporting.WinForms

Public Class LaporanSupplier
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
            ReportViewerSupplier.LocalReport.DataSources.Clear()
            ReportViewerSupplier.LocalReport.DataSources.Add(rds)
            ReportViewerSupplier.LocalReport.ReportPath = "C:\Users\acer\source\repos\minggu 7\minggu 7\ReportSupplier.rdlc" ' Path file laporan
            ReportViewerSupplier.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class