<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterTransaksiBeli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterTransaksiBeli))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonTutup = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.DataGridViewBeliBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxSupplier = New System.Windows.Forms.ComboBox()
        Me.TextBoxUkuran = New System.Windows.Forms.TextBox()
        Me.ComboBoxIDSepatu = New System.Windows.Forms.ComboBox()
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        Me.TextBoxStok = New System.Windows.Forms.TextBox()
        Me.TextBoxHargaBeli = New System.Windows.Forms.TextBox()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.TextBoxWarna = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaSepatu = New System.Windows.Forms.TextBox()
        Me.TextBoxNoTransaksi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewBeliBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(912, 88)
        Me.Panel1.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(181, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(522, 42)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Transaksi Pembelian Sepatu"
        '
        'TextBoxTotalHarga
        '
        Me.TextBoxTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalHarga.Location = New System.Drawing.Point(695, 660)
        Me.TextBoxTotalHarga.Name = "TextBoxTotalHarga"
        Me.TextBoxTotalHarga.Size = New System.Drawing.Size(192, 26)
        Me.TextBoxTotalHarga.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(597, 663)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 20)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Total Harga"
        '
        'ButtonTutup
        '
        Me.ButtonTutup.BackColor = System.Drawing.Color.Silver
        Me.ButtonTutup.Location = New System.Drawing.Point(233, 660)
        Me.ButtonTutup.Name = "ButtonTutup"
        Me.ButtonTutup.Size = New System.Drawing.Size(93, 29)
        Me.ButtonTutup.TabIndex = 41
        Me.ButtonTutup.Text = "Tutup"
        Me.ButtonTutup.UseVisualStyleBackColor = False
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.Red
        Me.ButtonBatal.Location = New System.Drawing.Point(124, 660)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(93, 29)
        Me.ButtonBatal.TabIndex = 40
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonProses
        '
        Me.ButtonProses.BackColor = System.Drawing.Color.Lime
        Me.ButtonProses.Location = New System.Drawing.Point(14, 660)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(93, 29)
        Me.ButtonProses.TabIndex = 39
        Me.ButtonProses.Text = "Proses"
        Me.ButtonProses.UseVisualStyleBackColor = False
        '
        'DataGridViewBeliBarang
        '
        Me.DataGridViewBeliBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBeliBarang.Location = New System.Drawing.Point(1, 324)
        Me.DataGridViewBeliBarang.Name = "DataGridViewBeliBarang"
        Me.DataGridViewBeliBarang.Size = New System.Drawing.Size(912, 300)
        Me.DataGridViewBeliBarang.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSupplier)
        Me.GroupBox1.Controls.Add(Me.TextBoxUkuran)
        Me.GroupBox1.Controls.Add(Me.ComboBoxIDSepatu)
        Me.GroupBox1.Controls.Add(Me.TextBoxJumlah)
        Me.GroupBox1.Controls.Add(Me.TextBoxStok)
        Me.GroupBox1.Controls.Add(Me.TextBoxHargaBeli)
        Me.GroupBox1.Controls.Add(Me.TextBoxUser)
        Me.GroupBox1.Controls.Add(Me.TextBoxWarna)
        Me.GroupBox1.Controls.Add(Me.TextBoxNamaSepatu)
        Me.GroupBox1.Controls.Add(Me.TextBoxNoTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 225)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(706, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 187)
        Me.Panel2.TabIndex = 24
        '
        'ComboBoxSupplier
        '
        Me.ComboBoxSupplier.FormattingEnabled = True
        Me.ComboBoxSupplier.Location = New System.Drawing.Point(101, 63)
        Me.ComboBoxSupplier.Name = "ComboBoxSupplier"
        Me.ComboBoxSupplier.Size = New System.Drawing.Size(188, 21)
        Me.ComboBoxSupplier.TabIndex = 23
        '
        'TextBoxUkuran
        '
        Me.TextBoxUkuran.Location = New System.Drawing.Point(500, 28)
        Me.TextBoxUkuran.Name = "TextBoxUkuran"
        Me.TextBoxUkuran.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxUkuran.TabIndex = 20
        '
        'ComboBoxIDSepatu
        '
        Me.ComboBoxIDSepatu.FormattingEnabled = True
        Me.ComboBoxIDSepatu.Location = New System.Drawing.Point(101, 101)
        Me.ComboBoxIDSepatu.Name = "ComboBoxIDSepatu"
        Me.ComboBoxIDSepatu.Size = New System.Drawing.Size(188, 21)
        Me.ComboBoxIDSepatu.TabIndex = 19
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxJumlah.Location = New System.Drawing.Point(500, 139)
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxJumlah.TabIndex = 17
        '
        'TextBoxStok
        '
        Me.TextBoxStok.Location = New System.Drawing.Point(500, 101)
        Me.TextBoxStok.Name = "TextBoxStok"
        Me.TextBoxStok.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxStok.TabIndex = 16
        '
        'TextBoxHargaBeli
        '
        Me.TextBoxHargaBeli.Location = New System.Drawing.Point(500, 63)
        Me.TextBoxHargaBeli.Name = "TextBoxHargaBeli"
        Me.TextBoxHargaBeli.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxHargaBeli.TabIndex = 15
        '
        'TextBoxUser
        '
        Me.TextBoxUser.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxUser.Location = New System.Drawing.Point(500, 175)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxUser.TabIndex = 14
        '
        'TextBoxWarna
        '
        Me.TextBoxWarna.Location = New System.Drawing.Point(101, 179)
        Me.TextBoxWarna.Name = "TextBoxWarna"
        Me.TextBoxWarna.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxWarna.TabIndex = 13
        '
        'TextBoxNamaSepatu
        '
        Me.TextBoxNamaSepatu.Location = New System.Drawing.Point(101, 143)
        Me.TextBoxNamaSepatu.Name = "TextBoxNamaSepatu"
        Me.TextBoxNamaSepatu.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxNamaSepatu.TabIndex = 12
        '
        'TextBoxNoTransaksi
        '
        Me.TextBoxNoTransaksi.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxNoTransaksi.Location = New System.Drawing.Point(101, 28)
        Me.TextBoxNoTransaksi.Name = "TextBoxNoTransaksi"
        Me.TextBoxNoTransaksi.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxNoTransaksi.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(445, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(456, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Stok"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Harga Beli"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(443, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Ukuran"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(456, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Warna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Sepatu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Sepatu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Transaksi"
        '
        'FormMasterTransaksiBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxTotalHarga)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ButtonTutup)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.DataGridViewBeliBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterTransaksiBeli"
        Me.Text = "FormMasterTransaksiBeli"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewBeliBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxTotalHarga As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonTutup As Button
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonProses As Button
    Friend WithEvents DataGridViewBeliBarang As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxUkuran As TextBox
    Friend WithEvents ComboBoxIDSepatu As ComboBox
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents TextBoxStok As TextBox
    Friend WithEvents TextBoxHargaBeli As TextBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents TextBoxWarna As TextBox
    Friend WithEvents TextBoxNamaSepatu As TextBox
    Friend WithEvents TextBoxNoTransaksi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxSupplier As ComboBox
    Friend WithEvents Panel2 As Panel
End Class
