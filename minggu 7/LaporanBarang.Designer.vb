<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanBarang))
        Me.ReportViewerBarang = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewerBarang
        '
        Me.ReportViewerBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewerBarang.LocalReport.ReportEmbeddedResource = "Sepatu_shop.ReportBarang.rdlc"
        Me.ReportViewerBarang.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerBarang.Name = "ReportViewerBarang"
        Me.ReportViewerBarang.ServerReport.BearerToken = Nothing
        Me.ReportViewerBarang.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.ReportViewerBarang.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewerBarang.TabIndex = 0
        '
        'LaporanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewerBarang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaporanBarang"
        Me.Text = "LaporanBarang"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerBarang As Microsoft.Reporting.WinForms.ReportViewer
End Class
