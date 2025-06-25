<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCariBarang))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.RadioButtonUkuran = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMerk = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKategori = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNamaSepatu = New System.Windows.Forms.RadioButton()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelTotalBarang = New System.Windows.Forms.Label()
        Me.ButtonPilih = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 66)
        Me.Panel1.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(339, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(228, 42)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Cari Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox2.Controls.Add(Me.TextBoxCari)
        Me.GroupBox2.Controls.Add(Me.RadioButtonUkuran)
        Me.GroupBox2.Controls.Add(Me.RadioButtonMerk)
        Me.GroupBox2.Controls.Add(Me.RadioButtonKategori)
        Me.GroupBox2.Controls.Add(Me.RadioButtonNamaSepatu)
        Me.GroupBox2.Location = New System.Drawing.Point(-2, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(899, 63)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Cari Barang"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(648, 26)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 16
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Location = New System.Drawing.Point(315, 28)
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(316, 20)
        Me.TextBoxCari.TabIndex = 15
        '
        'RadioButtonUkuran
        '
        Me.RadioButtonUkuran.AutoSize = True
        Me.RadioButtonUkuran.Location = New System.Drawing.Point(237, 29)
        Me.RadioButtonUkuran.Name = "RadioButtonUkuran"
        Me.RadioButtonUkuran.Size = New System.Drawing.Size(60, 17)
        Me.RadioButtonUkuran.TabIndex = 3
        Me.RadioButtonUkuran.TabStop = True
        Me.RadioButtonUkuran.Text = "Ukuran"
        Me.RadioButtonUkuran.UseVisualStyleBackColor = True
        '
        'RadioButtonMerk
        '
        Me.RadioButtonMerk.AutoSize = True
        Me.RadioButtonMerk.Location = New System.Drawing.Point(182, 29)
        Me.RadioButtonMerk.Name = "RadioButtonMerk"
        Me.RadioButtonMerk.Size = New System.Drawing.Size(49, 17)
        Me.RadioButtonMerk.TabIndex = 2
        Me.RadioButtonMerk.TabStop = True
        Me.RadioButtonMerk.Text = "Merk"
        Me.RadioButtonMerk.UseVisualStyleBackColor = True
        '
        'RadioButtonKategori
        '
        Me.RadioButtonKategori.AutoSize = True
        Me.RadioButtonKategori.Location = New System.Drawing.Point(112, 29)
        Me.RadioButtonKategori.Name = "RadioButtonKategori"
        Me.RadioButtonKategori.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonKategori.TabIndex = 1
        Me.RadioButtonKategori.TabStop = True
        Me.RadioButtonKategori.Text = "Kategori"
        Me.RadioButtonKategori.UseVisualStyleBackColor = True
        '
        'RadioButtonNamaSepatu
        '
        Me.RadioButtonNamaSepatu.AutoSize = True
        Me.RadioButtonNamaSepatu.Location = New System.Drawing.Point(16, 29)
        Me.RadioButtonNamaSepatu.Name = "RadioButtonNamaSepatu"
        Me.RadioButtonNamaSepatu.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonNamaSepatu.TabIndex = 0
        Me.RadioButtonNamaSepatu.TabStop = True
        Me.RadioButtonNamaSepatu.Text = "Nama Sepatu"
        Me.RadioButtonNamaSepatu.UseVisualStyleBackColor = True
        '
        'DataGridViewBarang
        '
        Me.DataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarang.Location = New System.Drawing.Point(-2, 138)
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.Size = New System.Drawing.Size(899, 234)
        Me.DataGridViewBarang.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 398)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 20)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Jumlah Barang"
        '
        'LabelTotalBarang
        '
        Me.LabelTotalBarang.AutoSize = True
        Me.LabelTotalBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalBarang.Location = New System.Drawing.Point(155, 398)
        Me.LabelTotalBarang.Name = "LabelTotalBarang"
        Me.LabelTotalBarang.Size = New System.Drawing.Size(35, 20)
        Me.LabelTotalBarang.TabIndex = 44
        Me.LabelTotalBarang.Text = "Null"
        '
        'ButtonPilih
        '
        Me.ButtonPilih.BackColor = System.Drawing.Color.Lime
        Me.ButtonPilih.Location = New System.Drawing.Point(663, 395)
        Me.ButtonPilih.Name = "ButtonPilih"
        Me.ButtonPilih.Size = New System.Drawing.Size(82, 28)
        Me.ButtonPilih.TabIndex = 45
        Me.ButtonPilih.Text = "Pilih"
        Me.ButtonPilih.UseVisualStyleBackColor = False
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.Silver
        Me.ButtonBatal.Location = New System.Drawing.Point(760, 395)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 28)
        Me.ButtonBatal.TabIndex = 46
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'FormCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 438)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonPilih)
        Me.Controls.Add(Me.LabelTotalBarang)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGridViewBarang)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCariBarang"
        Me.Text = "FormCariBarang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents RadioButtonUkuran As RadioButton
    Friend WithEvents RadioButtonMerk As RadioButton
    Friend WithEvents RadioButtonKategori As RadioButton
    Friend WithEvents RadioButtonNamaSepatu As RadioButton
    Friend WithEvents DataGridViewBarang As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelTotalBarang As Label
    Friend WithEvents ButtonPilih As Button
    Friend WithEvents ButtonBatal As Button
End Class
