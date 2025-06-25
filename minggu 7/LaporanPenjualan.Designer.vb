<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanPenjualan))
        Me.ReportViewerPenjualan = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewerPenjualan
        '
        Me.ReportViewerPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewerPenjualan.LocalReport.ReportEmbeddedResource = "Sepatu_shop.ReportPenjualan.rdlc"
        Me.ReportViewerPenjualan.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerPenjualan.Name = "ReportViewerPenjualan"
        Me.ReportViewerPenjualan.ServerReport.BearerToken = Nothing
        Me.ReportViewerPenjualan.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewerPenjualan.TabIndex = 0
        '
        'LaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewerPenjualan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaporanPenjualan"
        Me.Text = "LaporanPenjualan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerPenjualan As Microsoft.Reporting.WinForms.ReportViewer
End Class
