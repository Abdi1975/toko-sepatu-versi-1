Imports Microsoft.Reporting.WinForms

Public Class LaporanKaryawan
    Dim dt As DataTable

    ' Constructor untuk Menerima Data dari FormLaporanBarang
    Public Sub New(data As DataTable)
        InitializeComponent()
        dt = data
    End Sub

    ' Load Data ke ReportViewer saat Form Dibuka
    Private Sub LaporanKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Set DataSource untuk ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt) ' Sesuaikan nama dataset di RDLC
            ReportViewerKaryawan.LocalReport.DataSources.Clear()
            ReportViewerKaryawan.LocalReport.DataSources.Add(rds)
            ReportViewerKaryawan.LocalReport.ReportPath = "C:\Users\acer\source\repos\minggu 7\minggu 7\ReportKaryawan.rdlc" ' Path file laporan
            ReportViewerKaryawan.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class