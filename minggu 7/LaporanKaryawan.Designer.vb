﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanKaryawan))
        Me.ReportViewerKaryawan = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewerKaryawan
        '
        Me.ReportViewerKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewerKaryawan.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerKaryawan.Name = "ReportViewerKaryawan"
        Me.ReportViewerKaryawan.ServerReport.BearerToken = Nothing
        Me.ReportViewerKaryawan.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewerKaryawan.TabIndex = 0
        '
        'LaporanKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewerKaryawan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaporanKaryawan"
        Me.Text = "LaporanKaryawan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerKaryawan As Microsoft.Reporting.WinForms.ReportViewer
End Class
