<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanSupplier))
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.DataGridViewSupplier = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCetak
        '
        Me.ButtonCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCetak.Location = New System.Drawing.Point(226, 403)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(363, 43)
        Me.ButtonCetak.TabIndex = 6
        Me.ButtonCetak.Text = "CETAK"
        Me.ButtonCetak.UseVisualStyleBackColor = False
        '
        'DataGridViewSupplier
        '
        Me.DataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier.Location = New System.Drawing.Point(-3, 78)
        Me.DataGridViewSupplier.Name = "DataGridViewSupplier"
        Me.DataGridViewSupplier.Size = New System.Drawing.Size(806, 319)
        Me.DataGridViewSupplier.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 75)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Supplier"
        '
        'FormLaporanSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonCetak)
        Me.Controls.Add(Me.DataGridViewSupplier)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLaporanSupplier"
        Me.Text = "FormLaporanSupplier"
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonCetak As Button
    Friend WithEvents DataGridViewSupplier As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
