<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKaryawan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.RichTextBoxAlamat = New System.Windows.Forms.RichTextBox()
        Me.DateTimePickerTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.TextBoxTempatLahir = New System.Windows.Forms.TextBox()
        Me.TextBoxTelepon = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.TextBoxNik = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxCari = New System.Windows.Forms.ComboBox()
        Me.DataGridViewKaryawan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1163, 79)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Data Karyawan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonBatal)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonUbah)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxAlamat)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTanggalLahir)
        Me.GroupBox1.Controls.Add(Me.ComboBoxJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.TextBoxTempatLahir)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelepon)
        Me.GroupBox1.Controls.Add(Me.TextBoxNamaKaryawan)
        Me.GroupBox1.Controls.Add(Me.TextBoxNik)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 397)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Karyawan"
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.Silver
        Me.ButtonBatal.Location = New System.Drawing.Point(303, 354)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBatal.TabIndex = 16
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.Red
        Me.ButtonHapus.Location = New System.Drawing.Point(204, 354)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 15
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonUbah
        '
        Me.ButtonUbah.BackColor = System.Drawing.Color.Yellow
        Me.ButtonUbah.Location = New System.Drawing.Point(108, 354)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 14
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.Lime
        Me.ButtonSimpan.Location = New System.Drawing.Point(15, 354)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 13
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'RichTextBoxAlamat
        '
        Me.RichTextBoxAlamat.Location = New System.Drawing.Point(153, 180)
        Me.RichTextBoxAlamat.Name = "RichTextBoxAlamat"
        Me.RichTextBoxAlamat.Size = New System.Drawing.Size(232, 96)
        Me.RichTextBoxAlamat.TabIndex = 12
        Me.RichTextBoxAlamat.Text = ""
        '
        'DateTimePickerTanggalLahir
        '
        Me.DateTimePickerTanggalLahir.Location = New System.Drawing.Point(271, 143)
        Me.DateTimePickerTanggalLahir.Name = "DateTimePickerTanggalLahir"
        Me.DateTimePickerTanggalLahir.Size = New System.Drawing.Size(114, 20)
        Me.DateTimePickerTanggalLahir.TabIndex = 11
        '
        'ComboBoxJenisKelamin
        '
        Me.ComboBoxJenisKelamin.FormattingEnabled = True
        Me.ComboBoxJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.ComboBoxJenisKelamin.Location = New System.Drawing.Point(153, 102)
        Me.ComboBoxJenisKelamin.Name = "ComboBoxJenisKelamin"
        Me.ComboBoxJenisKelamin.Size = New System.Drawing.Size(232, 21)
        Me.ComboBoxJenisKelamin.TabIndex = 10
        '
        'TextBoxTempatLahir
        '
        Me.TextBoxTempatLahir.Location = New System.Drawing.Point(153, 143)
        Me.TextBoxTempatLahir.Name = "TextBoxTempatLahir"
        Me.TextBoxTempatLahir.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxTempatLahir.TabIndex = 9
        '
        'TextBoxTelepon
        '
        Me.TextBoxTelepon.Location = New System.Drawing.Point(153, 291)
        Me.TextBoxTelepon.Name = "TextBoxTelepon"
        Me.TextBoxTelepon.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxTelepon.TabIndex = 8
        '
        'TextBoxNamaKaryawan
        '
        Me.TextBoxNamaKaryawan.Location = New System.Drawing.Point(153, 65)
        Me.TextBoxNamaKaryawan.Name = "TextBoxNamaKaryawan"
        Me.TextBoxNamaKaryawan.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxNamaKaryawan.TabIndex = 7
        '
        'TextBoxNik
        '
        Me.TextBoxNik.Location = New System.Drawing.Point(153, 26)
        Me.TextBoxNik.Name = "TextBoxNik"
        Me.TextBoxNik.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxNik.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "No. Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tempat Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIK"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxCari)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCari)
        Me.GroupBox2.Location = New System.Drawing.Point(395, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 60)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Location = New System.Drawing.Point(308, 27)
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(432, 20)
        Me.TextBoxCari.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Berdasarkan"
        '
        'ComboBoxCari
        '
        Me.ComboBoxCari.FormattingEnabled = True
        Me.ComboBoxCari.Items.AddRange(New Object() {"NIK", "Nama Karyawan", "No. Telepon"})
        Me.ComboBoxCari.Location = New System.Drawing.Point(112, 26)
        Me.ComboBoxCari.Name = "ComboBoxCari"
        Me.ComboBoxCari.Size = New System.Drawing.Size(171, 21)
        Me.ComboBoxCari.TabIndex = 11
        '
        'DataGridViewKaryawan
        '
        Me.DataGridViewKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKaryawan.Location = New System.Drawing.Point(395, 148)
        Me.DataGridViewKaryawan.Name = "DataGridViewKaryawan"
        Me.DataGridViewKaryawan.Size = New System.Drawing.Size(751, 331)
        Me.DataGridViewKaryawan.TabIndex = 4
        '
        'FormKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 491)
        Me.Controls.Add(Me.DataGridViewKaryawan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormKaryawan"
        Me.Text = "FormKaryawan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBoxAlamat As RichTextBox
    Friend WithEvents DateTimePickerTanggalLahir As DateTimePicker
    Friend WithEvents ComboBoxJenisKelamin As ComboBox
    Friend WithEvents TextBoxTempatLahir As TextBox
    Friend WithEvents TextBoxTelepon As TextBox
    Friend WithEvents TextBoxNamaKaryawan As TextBox
    Friend WithEvents TextBoxNik As TextBox
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonUbah As Button
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxCari As ComboBox
    Friend WithEvents DataGridViewKaryawan As DataGridView
End Class
