<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanPembelian))
        Me.ReportViewerPembelian = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewerPembelian
        '
        Me.ReportViewerPembelian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewerPembelian.LocalReport.ReportEmbeddedResource = "Sepatu_shop.ReportPembelian.rdlc"
        Me.ReportViewerPembelian.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerPembelian.Name = "ReportViewerPembelian"
        Me.ReportViewerPembelian.ServerReport.BearerToken = Nothing
        Me.ReportViewerPembelian.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewerPembelian.TabIndex = 0
        '
        'LaporanPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewerPembelian)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaporanPembelian"
        Me.Text = "LaporanPembelian"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerPembelian As Microsoft.Reporting.WinForms.ReportViewer
End Class
