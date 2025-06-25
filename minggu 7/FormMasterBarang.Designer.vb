<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMasterBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterBarang))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxSatuan = New System.Windows.Forms.ComboBox()
        Me.ComboBoxUkuran = New System.Windows.Forms.ComboBox()
        Me.ComboBoxWarna = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMerk = New System.Windows.Forms.ComboBox()
        Me.ComboBoxKategori = New System.Windows.Forms.ComboBox()
        Me.TextBoxStok = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaJual = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaBeli = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaSepatu = New System.Windows.Forms.TextBox()
        Me.TextBoxKodeSepatu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.RadioButtonUkuran = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMerk = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKategori = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNamaSepatu = New System.Windows.Forms.RadioButton()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Data Sepatu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxSatuan)
        Me.GroupBox1.Controls.Add(Me.ComboBoxUkuran)
        Me.GroupBox1.Controls.Add(Me.ComboBoxWarna)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMerk)
        Me.GroupBox1.Controls.Add(Me.ComboBoxKategori)
        Me.GroupBox1.Controls.Add(Me.TextBoxStok)
        Me.GroupBox1.Controls.Add(Me.TextBoxHargaJual)
        Me.GroupBox1.Controls.Add(Me.TextBoxHargaBeli)
        Me.GroupBox1.Controls.Add(Me.TextBoxNamaSepatu)
        Me.GroupBox1.Controls.Add(Me.TextBoxKodeSepatu)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 217)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Sepatu"
        '
        'ComboBoxSatuan
        '
        Me.ComboBoxSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSatuan.FormattingEnabled = True
        Me.ComboBoxSatuan.Location = New System.Drawing.Point(400, 65)
        Me.ComboBoxSatuan.Name = "ComboBoxSatuan"
        Me.ComboBoxSatuan.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxSatuan.TabIndex = 19
        Me.ComboBoxSatuan.Text = "Pilih Satuan"
        '
        'ComboBoxUkuran
        '
        Me.ComboBoxUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUkuran.FormattingEnabled = True
        Me.ComboBoxUkuran.Location = New System.Drawing.Point(400, 27)
        Me.ComboBoxUkuran.Name = "ComboBoxUkuran"
        Me.ComboBoxUkuran.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxUkuran.TabIndex = 18
        Me.ComboBoxUkuran.Text = "Pilih Ukuran"
        '
        'ComboBoxWarna
        '
        Me.ComboBoxWarna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxWarna.FormattingEnabled = True
        Me.ComboBoxWarna.Location = New System.Drawing.Point(103, 183)
        Me.ComboBoxWarna.Name = "ComboBoxWarna"
        Me.ComboBoxWarna.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxWarna.TabIndex = 17
        Me.ComboBoxWarna.Text = "Pilih Warna"
        '
        'ComboBoxMerk
        '
        Me.ComboBoxMerk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMerk.FormattingEnabled = True
        Me.ComboBoxMerk.Location = New System.Drawing.Point(103, 146)
        Me.ComboBoxMerk.Name = "ComboBoxMerk"
        Me.ComboBoxMerk.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxMerk.TabIndex = 16
        Me.ComboBoxMerk.Text = "Pilih Merk"
        '
        'ComboBoxKategori
        '
        Me.ComboBoxKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxKategori.FormattingEnabled = True
        Me.ComboBoxKategori.Location = New System.Drawing.Point(103, 104)
        Me.ComboBoxKategori.Name = "ComboBoxKategori"
        Me.ComboBoxKategori.Size = New System.Drawing.Size(184, 21)
        Me.ComboBoxKategori.TabIndex = 15
        Me.ComboBoxKategori.Text = "Pilih Kategori"
        '
        'TextBoxStok
        '
        Me.TextBoxStok.Location = New System.Drawing.Point(400, 184)
        Me.TextBoxStok.Name = "TextBoxStok"
        Me.TextBoxStok.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxStok.TabIndex = 14
        '
        'TextBoxHargaJual
        '
        Me.TextBoxHargaJual.Location = New System.Drawing.Point(400, 146)
        Me.TextBoxHargaJual.Name = "TextBoxHargaJual"
        Me.TextBoxHargaJual.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxHargaJual.TabIndex = 13
        '
        'TextBoxHargaBeli
        '
        Me.TextBoxHargaBeli.Location = New System.Drawing.Point(400, 104)
        Me.TextBoxHargaBeli.Name = "TextBoxHargaBeli"
        Me.TextBoxHargaBeli.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxHargaBeli.TabIndex = 12
        '
        'TextBoxNamaSepatu
        '
        Me.TextBoxNamaSepatu.Location = New System.Drawing.Point(103, 65)
        Me.TextBoxNamaSepatu.Name = "TextBoxNamaSepatu"
        Me.TextBoxNamaSepatu.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxNamaSepatu.TabIndex = 11
        '
        'TextBoxKodeSepatu
        '
        Me.TextBoxKodeSepatu.Location = New System.Drawing.Point(103, 27)
        Me.TextBoxKodeSepatu.Name = "TextBoxKodeSepatu"
        Me.TextBoxKodeSepatu.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxKodeSepatu.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Stok"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Harga Jual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(331, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Harga Beli"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(331, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Satuan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(331, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Ukuran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Warna"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Merk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Sepatu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Sepatu"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxCari)
        Me.GroupBox2.Controls.Add(Me.RadioButtonUkuran)
        Me.GroupBox2.Controls.Add(Me.RadioButtonMerk)
        Me.GroupBox2.Controls.Add(Me.RadioButtonKategori)
        Me.GroupBox2.Controls.Add(Me.RadioButtonNamaSepatu)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 63)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Cari Barang"
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Location = New System.Drawing.Point(315, 28)
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(254, 20)
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
        Me.DataGridViewBarang.Location = New System.Drawing.Point(12, 370)
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.Size = New System.Drawing.Size(838, 286)
        Me.DataGridViewBarang.TabIndex = 3
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.Silver
        Me.ButtonBatal.Location = New System.Drawing.Point(309, 662)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBatal.TabIndex = 20
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.Red
        Me.ButtonHapus.Location = New System.Drawing.Point(208, 662)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 19
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonUbah
        '
        Me.ButtonUbah.BackColor = System.Drawing.Color.Yellow
        Me.ButtonUbah.Location = New System.Drawing.Point(113, 662)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 18
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.Lime
        Me.ButtonSimpan.Location = New System.Drawing.Point(19, 662)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 17
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(630, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 230)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'FormMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 696)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.DataGridViewBarang)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterBarang"
        Me.Text = "FormMasterBarang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxSatuan As ComboBox
    Friend WithEvents ComboBoxUkuran As ComboBox
    Friend WithEvents ComboBoxWarna As ComboBox
    Friend WithEvents ComboBoxMerk As ComboBox
    Friend WithEvents ComboBoxKategori As ComboBox
    Friend WithEvents TextBoxStok As TextBox
    Friend WithEvents TextBoxHargaJual As TextBox
    Friend WithEvents TextBoxHargaBeli As TextBox
    Friend WithEvents TextBoxNamaSepatu As TextBox
    Friend WithEvents TextBoxKodeSepatu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents RadioButtonUkuran As RadioButton
    Friend WithEvents RadioButtonMerk As RadioButton
    Friend WithEvents RadioButtonKategori As RadioButton
    Friend WithEvents RadioButtonNamaSepatu As RadioButton
    Friend WithEvents DataGridViewBarang As DataGridView
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonUbah As Button
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
