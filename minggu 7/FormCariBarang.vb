Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data
Imports vb = Microsoft.VisualBasic

Public Class FormCariBarang

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim barang As DataTable
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer
    Dim kode_barang, search_name, search_condition, search_d As String



    Sub Data_Record()
        'barang = Proses.ExecuteQuery("SELECT * FROM barang")
        'tblbarang = Proses.ExecuteQuery("SELECT tblbarang.id_barang, tblbarang.nm_barang, tblmerk.merk, tblsatuan.satuan, tblbarang.hrg_beli, tblbarang.hrg_jual, tblbarang.stock FROM tblbarang INNER JOIN tblmerk INNER JOIN tblsatuan ON tblbarang.merk_barang = tblmerk.id_merk AND tblsatuan.id_satuan = tblbarang.satuan")

        barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                     & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                     & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                     & "FROM barang " _
                                     & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                     & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                     & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                     & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                     & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan ORDER BY kode_barang ASC")

        'barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'KD BRG', barang.nama_barang AS 'NAMA BRG', kategori.nama_kategori AS 'KATEGORI', merk.nama_merk AS 'MERK', barang.harga_beli AS 'BELI', barang.harga_jual AS 'JUAL',warna.nama_warna AS 'WARNA', size.nama_size AS 'UKURAN', barang.stok AS 'STOK' , satuan.keterangan as 'SATUAN' FROM barang INNER JOIN kategori ON barang.kategori = kategori.kode_kategori INNER JOIN merk ON barang.kode_merk = merk.kode_merk INNER JOIN warna ON barang.kode_warna = warna.kode_warna INNER JOIN size ON barang.kode_size = size.kode_size INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan")

        DataGridViewBarang.DataSource = barang
        DataGridViewBarang.Columns(0).Width = 50
        DataGridViewBarang.Columns(1).Width = 220
        DataGridViewBarang.Columns(6).Width = 80
        DataGridViewBarang.Columns(7).Width = 50
        DataGridViewBarang.Columns(8).Width = 50
        DataGridViewBarang.Columns(9).Width = 70


        DataGridViewBarang.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DGBarang.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                     & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                     & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                     & "FROM barang " _
                                     & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                     & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                     & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                     & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                     & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan ORDER BY kode_barang ASC"

        Dim mycommand As New MySqlCommand
        mycommand.Connection = Proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim totalbarang As Integer
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()

        totalbarang = 0
        If (mydata.HasRows) Then
            While (mydata.Read)
                totalbarang = totalbarang + 1
            End While
        End If
        LabelTotalBarang.Text = Val(totalbarang)
        Proses.CloseConn()



    End Sub

    Private Sub TextBoxCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCari.TextChanged
        If RadioButtonNamaSepatu.Checked = True Then
            barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                         & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                             & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                             & "FROM barang " _
                                             & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                             & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                             & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                             & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                             & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan " _
                                             & "where barang.nama_barang LIKE '%" & TextBoxCari.Text & "%' ORDER BY barang.kode_barang ASC")
            DataGridViewBarang.DataSource = barang
            TextBoxCari.Focus()

        ElseIf RadioButtonKategori.Checked = True Then
            barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                         & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                         & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                         & "FROM barang " _
                                         & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                         & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                         & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                         & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                         & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan " _
                                         & "where kategori.nama_kategori LIKE '%" & TextBoxCari.Text & "%' ORDER BY barang.kode_barang ASC")
            DataGridViewBarang.DataSource = barang
            TextBoxCari.Focus()

        ElseIf RadioButtonMerk.Checked = True Then
            barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                         & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                         & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                         & "FROM barang " _
                                         & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                         & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                         & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                         & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                         & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan " _
                                         & "where merk.nama_merk LIKE '%" & TextBoxCari.Text & "%' ORDER BY barang.kode_barang ASC")
            DataGridViewBarang.DataSource = barang
            TextBoxCari.Focus()

        ElseIf RadioButtonUkuran.Checked = True Then

            barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                         & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                         & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                         & "FROM barang " _
                                         & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                         & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                         & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                         & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                         & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan " _
                                         & "where size.nama_size LIKE '%" & Val(TextBoxCari.Text) & "' ORDER BY barang.kode_barang ASC")
            DataGridViewBarang.DataSource = barang
            TextBoxCari.Focus()
        End If
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Me.Close()

    End Sub

    Private Sub DataGridViewBarang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewBarang.DoubleClick

        'FormMasterTransaksiJual.txtKodeSepatu.Text = DGBarang.SelectedCells(0).Value
        'FormMasterTransaksiJual.txtNamaSepatu.Text = DGBarang.SelectedCells(1).Value
        'FormMasterTransaksiJual.cmbKategori.Text = DGBarang.SelectedCells(2).Value
        'cmbMerk.Text = DGBarang.SelectedCells(3).Value
        'FormMasterTransaksiJual.txtHargaBeli.Text = DGBarang.SelectedCells(4).Value
        'FormMasterTransaksiJual.txtHargaJual.Text = DGBarang.SelectedCells(5).Value
        'FormMasterTransaksiJual.txtWarna.Text = DGBarang.SelectedCells(6).Value
        'FormMasterTransaksiJual.cmbUkuran.Text = DGBarang.SelectedCells(7).Value
        'FormMasterTransaksiJual.txtStok.Text = DGBarang.SelectedCells(8).Value
        'FormMasterTransaksiJual.txt.Text = DGBarang.SelectedCells(9).Value

        FormMasterTransaksiJual.ComboBoxSepatu.Text = DataGridViewBarang.SelectedCells(0).Value
        FormMasterTransaksiJual.TextBoxNamaSepatu.Text = DataGridViewBarang.SelectedCells(1).Value
        'FormMasterTransaksiJual.txtWarna.Text = DGBarang.SelectedCells(6).Value
        'FormMasterTransaksiJual.txtUkuran.Text = DGBarang.SelectedCells(7).Value
        FormMasterTransaksiJual.TextBoxHargaJual.Text = DataGridViewBarang.SelectedCells(5).Value
        FormMasterTransaksiJual.TextBoxStok.Text = DataGridViewBarang.SelectedCells(8).Value



        Me.Close()
        FormMasterTransaksiJual.TextBoxJumlah.Focus()

        'btnSimpan.Enabled = False
        'btnUbah.Enabled = True
        'btnHapus.Enabled = True
        'btnBatal.Enabled = True
        'BtnKoreksiStock.Enabled = True

        'txtNamaSepatu.Focus()

        'Call Data_Record()

    End Sub

    Private Sub FormCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Data_Record()
    End Sub

    Private Sub ButtonRedresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        Data_Record()
    End Sub

    Private Sub ButtonPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPilih.Click
        DataGridViewBarang_DoubleClick(sender, e)
    End Sub

End Class