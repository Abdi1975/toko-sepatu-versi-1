Public Class Home
    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click

    End Sub

    Private Sub MasterBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterBarangToolStripMenuItem.Click
        ' Buka form Master Barang
        FormMasterBarang.ShowDialog()
    End Sub

    Private Sub MasterKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterKaryawanToolStripMenuItem.Click
        ' Buka form Master Karyawan
        FormKaryawan.ShowDialog()
    End Sub

    Private Sub MasterUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterUserToolStripMenuItem.Click
        ' Buka form Master User
        FormMasterUser.ShowDialog()
    End Sub

    Private Sub MasterSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterSupplierToolStripMenuItem.Click
        ' Buka form Master Supplier
        FormMasterSupplier.ShowDialog()
    End Sub

    Private Sub PenjualanSepatuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanSepatuToolStripMenuItem.Click
        ' Buka form Penjualan Sepatu
        FormMasterTransaksiJual.ShowDialog()
    End Sub

    Private Sub PembelianSepatuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianSepatuToolStripMenuItem.Click
        ' Buka form Pembelian Sepatu
        FormMasterTransaksiBeli.ShowDialog()
    End Sub

    Private Sub DataKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKategoriToolStripMenuItem.Click
        ' Buka form Data Kategori
        FormMasterKategori.ShowDialog()
    End Sub

    Private Sub DataMerkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMerkToolStripMenuItem.Click
        ' Buka form Data Merk
        FormMasterMerk.ShowDialog()
    End Sub

    Private Sub DataWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataWarnaToolStripMenuItem.Click
        ' Buka form Data Warna
        FormMasterWarna.ShowDialog()
    End Sub

    Private Sub DataSatuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSatuanToolStripMenuItem.Click
        ' Buka form Data Satuan
        FormMasterSatuan.ShowDialog()
    End Sub

    Private Sub DataSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSizeToolStripMenuItem.Click
        ' Buka form Data Size
        FormMasterSize.ShowDialog()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        FormLaporanBarang.ShowDialog()
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        FormLaporanKaryawan.ShowDialog()
    End Sub

    Private Sub DataPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenjualanToolStripMenuItem.Click
        FormLaporanPenjualan.ShowDialog()
    End Sub

    Private Sub DataPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPembelianToolStripMenuItem.Click
        FormLaporanPembelian.ShowDialog()
    End Sub

    Private Sub DataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSupplierToolStripMenuItem.Click
        FormLaporanSupplier.ShowDialog()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        If MsgBox("Apakah yakin akan Log Off / Log Out ?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
        End If

        Login.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        If MsgBox("Apakah yakin akan keluar dari aplikasi?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            Login.Close()
        End If
    End Sub

    Private Sub AuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorToolStripMenuItem.Click
        FormAuthor.ShowDialog()
    End Sub

    Private Sub AplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiToolStripMenuItem.Click
        FormTentangAplikasi.ShowDialog()
    End Sub
End Class
