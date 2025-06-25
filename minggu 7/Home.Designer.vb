<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanSepatuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianSepatuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataWarnaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSatuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.SetupToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.TentangToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterBarangToolStripMenuItem, Me.MasterKaryawanToolStripMenuItem, Me.MasterUserToolStripMenuItem, Me.MasterSupplierToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'MasterBarangToolStripMenuItem
        '
        Me.MasterBarangToolStripMenuItem.Name = "MasterBarangToolStripMenuItem"
        Me.MasterBarangToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MasterBarangToolStripMenuItem.Text = "Master Barang"
        '
        'MasterKaryawanToolStripMenuItem
        '
        Me.MasterKaryawanToolStripMenuItem.Name = "MasterKaryawanToolStripMenuItem"
        Me.MasterKaryawanToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MasterKaryawanToolStripMenuItem.Text = "Master Karyawan"
        '
        'MasterUserToolStripMenuItem
        '
        Me.MasterUserToolStripMenuItem.Name = "MasterUserToolStripMenuItem"
        Me.MasterUserToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MasterUserToolStripMenuItem.Text = "Master User"
        '
        'MasterSupplierToolStripMenuItem
        '
        Me.MasterSupplierToolStripMenuItem.Name = "MasterSupplierToolStripMenuItem"
        Me.MasterSupplierToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MasterSupplierToolStripMenuItem.Text = "Master Supplier"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanSepatuToolStripMenuItem, Me.PembelianSepatuToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanSepatuToolStripMenuItem
        '
        Me.PenjualanSepatuToolStripMenuItem.Name = "PenjualanSepatuToolStripMenuItem"
        Me.PenjualanSepatuToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.PenjualanSepatuToolStripMenuItem.Text = "Penjualan Sepatu"
        '
        'PembelianSepatuToolStripMenuItem
        '
        Me.PembelianSepatuToolStripMenuItem.Name = "PembelianSepatuToolStripMenuItem"
        Me.PembelianSepatuToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.PembelianSepatuToolStripMenuItem.Text = "Pembelian Sepatu"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKategoriToolStripMenuItem, Me.DataMerkToolStripMenuItem, Me.DataWarnaToolStripMenuItem, Me.DataSatuanToolStripMenuItem, Me.DataSizeToolStripMenuItem})
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'DataKategoriToolStripMenuItem
        '
        Me.DataKategoriToolStripMenuItem.Name = "DataKategoriToolStripMenuItem"
        Me.DataKategoriToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DataKategoriToolStripMenuItem.Text = "Data Kategori"
        '
        'DataMerkToolStripMenuItem
        '
        Me.DataMerkToolStripMenuItem.Name = "DataMerkToolStripMenuItem"
        Me.DataMerkToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DataMerkToolStripMenuItem.Text = "Data Merk"
        '
        'DataWarnaToolStripMenuItem
        '
        Me.DataWarnaToolStripMenuItem.Name = "DataWarnaToolStripMenuItem"
        Me.DataWarnaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DataWarnaToolStripMenuItem.Text = "Data Warna"
        '
        'DataSatuanToolStripMenuItem
        '
        Me.DataSatuanToolStripMenuItem.Name = "DataSatuanToolStripMenuItem"
        Me.DataSatuanToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DataSatuanToolStripMenuItem.Text = "Data Satuan"
        '
        'DataSizeToolStripMenuItem
        '
        Me.DataSizeToolStripMenuItem.Name = "DataSizeToolStripMenuItem"
        Me.DataSizeToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DataSizeToolStripMenuItem.Text = "Data Size"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataKaryawanToolStripMenuItem, Me.DataPenjualanToolStripMenuItem, Me.DataPembelianToolStripMenuItem, Me.DataSupplierToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataKaryawanToolStripMenuItem
        '
        Me.DataKaryawanToolStripMenuItem.Name = "DataKaryawanToolStripMenuItem"
        Me.DataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataKaryawanToolStripMenuItem.Text = "Data Karyawan"
        '
        'DataPenjualanToolStripMenuItem
        '
        Me.DataPenjualanToolStripMenuItem.Name = "DataPenjualanToolStripMenuItem"
        Me.DataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataPenjualanToolStripMenuItem.Text = "Data Penjualan"
        '
        'DataPembelianToolStripMenuItem
        '
        Me.DataPembelianToolStripMenuItem.Name = "DataPembelianToolStripMenuItem"
        Me.DataPembelianToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataPembelianToolStripMenuItem.Text = "Data Pembelian"
        '
        'DataSupplierToolStripMenuItem
        '
        Me.DataSupplierToolStripMenuItem.Name = "DataSupplierToolStripMenuItem"
        Me.DataSupplierToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataSupplierToolStripMenuItem.Text = "Data Supplier"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuthorToolStripMenuItem, Me.AplikasiToolStripMenuItem})
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AuthorToolStripMenuItem.Text = "Author"
        '
        'AplikasiToolStripMenuItem
        '
        Me.AplikasiToolStripMenuItem.Name = "AplikasiToolStripMenuItem"
        Me.AplikasiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AplikasiToolStripMenuItem.Text = "Aplikasi"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOffToolStripMenuItem, Me.KeluarToolStripMenuItem1})
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.LogOffToolStripMenuItem.Text = "Log Off"
        '
        'KeluarToolStripMenuItem1
        '
        Me.KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        Me.KeluarToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.KeluarToolStripMenuItem1.Text = "Keluar"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanSepatuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianSepatuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMerkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataWarnaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSatuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuthorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LogOffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
