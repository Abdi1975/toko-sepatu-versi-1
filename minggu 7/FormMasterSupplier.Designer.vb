<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterSupplier))
        Me.DataGridViewSupplier = New System.Windows.Forms.DataGridView()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.RichTextBoxAlamat = New System.Windows.Forms.RichTextBox()
        Me.TextBoxTelepon = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxCari = New System.Windows.Forms.ComboBox()
        Me.TextBoxNamaSupplier = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxWebsite = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxKodeSupplier = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewSupplier
        '
        Me.DataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier.Location = New System.Drawing.Point(395, 154)
        Me.DataGridViewSupplier.Name = "DataGridViewSupplier"
        Me.DataGridViewSupplier.Size = New System.Drawing.Size(751, 331)
        Me.DataGridViewSupplier.TabIndex = 8
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
        Me.RichTextBoxAlamat.Location = New System.Drawing.Point(153, 111)
        Me.RichTextBoxAlamat.Name = "RichTextBoxAlamat"
        Me.RichTextBoxAlamat.Size = New System.Drawing.Size(232, 96)
        Me.RichTextBoxAlamat.TabIndex = 12
        Me.RichTextBoxAlamat.Text = ""
        '
        'TextBoxTelepon
        '
        Me.TextBoxTelepon.Location = New System.Drawing.Point(153, 223)
        Me.TextBoxTelepon.Name = "TextBoxTelepon"
        Me.TextBoxTelepon.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxTelepon.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxCari)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCari)
        Me.GroupBox2.Location = New System.Drawing.Point(395, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 60)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data"
        '
        'ComboBoxCari
        '
        Me.ComboBoxCari.FormattingEnabled = True
        Me.ComboBoxCari.Items.AddRange(New Object() {"Nama Supplier", "Kode Supplier", "Telepon"})
        Me.ComboBoxCari.Location = New System.Drawing.Point(112, 26)
        Me.ComboBoxCari.Name = "ComboBoxCari"
        Me.ComboBoxCari.Size = New System.Drawing.Size(171, 21)
        Me.ComboBoxCari.TabIndex = 11
        '
        'TextBoxNamaSupplier
        '
        Me.TextBoxNamaSupplier.Location = New System.Drawing.Point(153, 65)
        Me.TextBoxNamaSupplier.Name = "TextBoxNamaSupplier"
        Me.TextBoxNamaSupplier.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxNamaSupplier.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "No. Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Website"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Supplier"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxWebsite)
        Me.GroupBox1.Controls.Add(Me.ButtonBatal)
        Me.GroupBox1.Controls.Add(Me.TextBoxEmail)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonUbah)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxAlamat)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelepon)
        Me.GroupBox1.Controls.Add(Me.TextBoxNamaSupplier)
        Me.GroupBox1.Controls.Add(Me.TextBoxKodeSupplier)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 397)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Karyawan"
        '
        'TextBoxWebsite
        '
        Me.TextBoxWebsite.Location = New System.Drawing.Point(153, 298)
        Me.TextBoxWebsite.Name = "TextBoxWebsite"
        Me.TextBoxWebsite.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxWebsite.TabIndex = 18
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(153, 263)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxEmail.TabIndex = 17
        '
        'TextBoxKodeSupplier
        '
        Me.TextBoxKodeSupplier.Location = New System.Drawing.Point(153, 26)
        Me.TextBoxKodeSupplier.Name = "TextBoxKodeSupplier"
        Me.TextBoxKodeSupplier.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxKodeSupplier.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Data Supplier"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1163, 79)
        Me.Panel1.TabIndex = 5
        '
        'FormMasterSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 489)
        Me.Controls.Add(Me.DataGridViewSupplier)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterSupplier"
        Me.Text = "FormMasterSupplier"
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewSupplier As DataGridView
    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonUbah As Button
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents RichTextBoxAlamat As RichTextBox
    Friend WithEvents TextBoxTelepon As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBoxCari As ComboBox
    Friend WithEvents TextBoxNamaSupplier As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxKodeSupplier As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxWebsite As TextBox
    Friend WithEvents TextBoxEmail As TextBox
End Class
