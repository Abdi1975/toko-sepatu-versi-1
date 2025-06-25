Imports Microsoft.Reporting.WinForms

Public Class LaporanBarang
    Dim dt As DataTable

    ' Constructor untuk Menerima Data dari FormLaporanBarang
    Public Sub New(data As DataTable)
        InitializeComponent()
        dt = data
    End Sub

    ' Load Data ke ReportViewer saat Form Dibuka
    Private Sub LaporanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Set DataSource untuk ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt) ' Sesuaikan nama dataset di RDLC
            ReportViewerBarang.LocalReport.DataSources.Clear()
            ReportViewerBarang.LocalReport.DataSources.Add(rds)
            ReportViewerBarang.LocalReport.ReportPath = "C:\Users\acer\source\repos\minggu 7\minggu 7\ReportBarang.rdlc" ' Path file laporan
            ReportViewerBarang.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ReportViewerBarang_Load(sender As Object, e As EventArgs) Handles ReportViewerBarang.Load

    End Sub
End Class
