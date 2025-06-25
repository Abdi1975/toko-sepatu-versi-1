Imports vb = Microsoft.VisualBasic


Public Class FormMasterBarang
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim barang As DataTable
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer



    Public Sub singleqoute()
        Dim ctrl As Control
        Dim txt As TextBox

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                txt = CType(ctrl, TextBox)
                txt.Text = Replace(txt.Text, "'", "''")
            End If
        Next

    End Sub

    Sub Data_Record()

        barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                     & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                     & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                     & "FROM barang " _
                                     & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                     & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                     & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                     & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                     & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan ORDER BY kode_barang ASC")


        DataGridViewBarang.DataSource = barang
        DataGridViewBarang.Columns(0).Width = 50
        DataGridViewBarang.Columns(1).Width = 220
        DataGridViewBarang.Columns(6).Width = 80
        DataGridViewBarang.Columns(7).Width = 50
        DataGridViewBarang.Columns(8).Width = 50
        DataGridViewBarang.Columns(9).Width = 70


        DataGridViewBarang.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(5).DefaultCellStyle.Format = "N0"  ' Format untuk Total Harga (tanpa notasi ilmiah)
        DataGridViewBarang.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBarang.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub


    Sub Data_Kategori()
        barang = Proses.ExecuteQuery("SELECT * FROM kategori")
        If barang.Rows.Count = 0 Then
        Else
            ComboBoxKategori.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    ComboBoxKategori.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Data_Merk()
        barang = Proses.ExecuteQuery("SELECT * FROM merk")
        If barang.Rows.Count = 0 Then
        Else
            ComboBoxMerk.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    ComboBoxMerk.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub


    Sub Data_Warna()
        barang = Proses.ExecuteQuery("SELECT * FROM warna")
        If barang.Rows.Count = 0 Then
        Else
            ComboBoxWarna.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    ComboBoxWarna.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Data_Ukuran()
        barang = Proses.ExecuteQuery("SELECT * FROM size")
        If barang.Rows.Count = 0 Then
        Else
            ComboBoxUkuran.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    ComboBoxUkuran.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub


    Sub Data_Satuan()
        barang = Proses.ExecuteQuery("Select * From satuan")
        If barang.Rows.Count = 0 Then
        Else
            ComboBoxSatuan.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    ComboBoxSatuan.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Private Sub TextBoxNamaSepatu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNamaSepatu.KeyPress

        If Asc(e.KeyChar) = 13 Then
            ComboBoxKategori.Focus()
        End If
    End Sub

    Private Sub ComboBoxKategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxKategori.SelectedIndexChanged
        ComboBoxMerk.Focus()
    End Sub

    Private Sub ComboBoxMerk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMerk.SelectedIndexChanged
        ComboBoxWarna.Focus()
    End Sub

    Private Sub ComboBoxWarna_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxWarna.SelectedIndexChanged
        ComboBoxUkuran.Focus()
    End Sub

    Private Sub ComboBoxUkuran_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxUkuran.SelectedIndexChanged
        ComboBoxSatuan.Focus()
    End Sub

    Private Sub ComboBoxSatuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSatuan.SelectedIndexChanged
        TextBoxHargaBeli.Focus()
    End Sub



    Private Sub TextBoxHargaBeli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxHargaBeli.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            TextBoxHargaJual.Focus()
        End If

    End Sub


    Private Sub TextBoxHargaJual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxHargaJual.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            TextBoxStok.Focus()
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxStok.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If ButtonSimpan.Enabled = True Then
            If Asc(e.KeyChar) = 13 Then
                ButtonSimpan_Click(sender, e)

            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                ButtonUbah_Click(sender, e)
            End If
        End If
    End Sub


    Sub Kode_Otomatis()
        barang = Proses.ExecuteQuery("Select * From barang order by kode_barang desc")
        If barang.Rows.Count = 0 Then
            TextBoxKodeSepatu.Text = "SPT-001"
        Else
            With barang.Rows(0)
                TextBoxKodeSepatu.Text = .Item("kode_barang")
            End With
            TextBoxKodeSepatu.Text = Val(Microsoft.VisualBasic.Mid(TextBoxKodeSepatu.Text, 5, 3)) + 1
            If Len(TextBoxKodeSepatu.Text) = 1 Then
                TextBoxKodeSepatu.Text = "SPT-00" & TextBoxKodeSepatu.Text & ""
            ElseIf Len(TextBoxKodeSepatu.Text) = 2 Then
                TextBoxKodeSepatu.Text = "SPT-0" & TextBoxKodeSepatu.Text & ""
            ElseIf Len(TextBoxKodeSepatu.Text) = 3 Then
                TextBoxKodeSepatu.Text = "SPT-" & TextBoxKodeSepatu.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        TextBoxKodeSepatu.Enabled = False
        TextBoxKodeSepatu.Text = ""
        TextBoxNamaSepatu.Text = ""
        TextBoxNamaSepatu.MaxLength = 100
        TextBoxStok.MaxLength = 100
        ComboBoxKategori.Text = "Pilih Kategori"
        ComboBoxMerk.Text = "Pilih Merk"
        ComboBoxSatuan.Text = "Pilih Satuan"
        ComboBoxWarna.Text = "Pilih Warna"
        ComboBoxUkuran.Text = "Pilih Ukuran"
        TextBoxHargaBeli.Text = ""
        TextBoxHargaJual.Text = ""
        TextBoxStok.Text = ""

        'Mengatur Fungsi Tombol
        ButtonSimpan.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxNamaSepatu.Focus()

        Call Data_Record()
        Call Data_Kategori()
        Call Data_Merk()
        Call Data_Warna()
        Call Data_Ukuran()
        Call Data_Satuan()

        Call Kode_Otomatis()

    End Sub

    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click

        If TextBoxNamaSepatu.Text = "" Then
            MsgBox("Nama Sepatu Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxNamaSepatu.Focus()
        ElseIf TextBoxHargaBeli.Text = "" Then
            MsgBox("Harga Beli Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxHargaBeli.Focus()
        ElseIf TextBoxHargaJual.Text = "" Then
            MsgBox("Harga Jual Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxHargaJual.Focus()
        ElseIf TextBoxStok.Text = "" Then
            MsgBox("Stok Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxStok.Focus()
        Else
            Try

                If MsgBox("Apakah Anda Yakin Menyimpan Data Barang Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                    SQL = "INSERT INTO barang(kode_barang,nama_barang,kategori,kode_merk,harga_beli,harga_jual,kode_warna,kode_size,stok,kode_satuan) VALUES ('" & TextBoxKodeSepatu.Text & "','" & TextBoxNamaSepatu.Text & "','" & vb.Left(ComboBoxKategori.SelectedItem, 7) & "','" & vb.Left(ComboBoxMerk.SelectedItem, 7) & "','" & TextBoxHargaBeli.Text & "','" & TextBoxHargaJual.Text & "','" & vb.Left(ComboBoxWarna.SelectedItem, 7) & "','" & vb.Left(ComboBoxUkuran.SelectedItem, 7) & "','" & TextBoxStok.Text & "', '" & vb.Left(ComboBoxSatuan.Text, 7) & "')"
                    Proses.ExecuteNonQuery(SQL)
                    MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Atur()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try

        End If


    End Sub


    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click

        If TextBoxNamaSepatu.Text = "" Then
            MsgBox("Nama Sepatu Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxNamaSepatu.Focus()
        ElseIf TextBoxHargaBeli.Text = "" Then
            MsgBox("Harga Beli Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxHargaBeli.Focus()
        ElseIf TextBoxHargaJual.Text = "" Then
            MsgBox("Harga Jual Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxHargaJual.Focus()
        ElseIf TextBoxStok.Text = "" Then
            MsgBox("Stok Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxStok.Focus()
        Else
            Try
                If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                    SQL = "UPDATE barang set nama_barang ='" & TextBoxNamaSepatu.Text & "', kategori = '" & ComboBoxKategori.Text & "', kode_merk = '" & ComboBoxMerk.Text & "', harga_beli = '" & TextBoxHargaBeli.Text & "', harga_jual = '" & TextBoxHargaJual.Text & "', kode_warna = '" & ComboBoxWarna.Text & "', kode_size = '" & ComboBoxUkuran.Text & "', stok = '" & TextBoxStok.Text & "', kode_satuan = '" & ComboBoxSatuan.Text & "' where kode_barang ='" & TextBoxKodeSepatu.Text & "',"
                    Proses.ExecuteNonQuery(SQL)
                    MessageBox.Show("Data sudah diperbaiki...!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Atur()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If


    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click

        If MsgBox("Apakah Anda Yakin Akan Menghapus Barang Ini ??", vbYesNo, "Konfirmasi") = vbYes Then
            SQL = "DELETE FROM barang where kode_barang ='" & TextBoxKodeSepatu.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data sudah dihapus...!!", "Penghapusan Sukses",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Atur()
        End If

    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If TextBoxNamaSepatu.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

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

    Private Sub DataGridViewBarang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewBarang.DoubleClick

        TextBoxKodeSepatu.Text = DataGridViewBarang.SelectedCells(0).Value
        TextBoxNamaSepatu.Text = DataGridViewBarang.SelectedCells(1).Value
        ComboBoxKategori.Text = DataGridViewBarang.SelectedCells(2).Value
        ComboBoxMerk.Text = DataGridViewBarang.SelectedCells(3).Value
        TextBoxHargaBeli.Text = DataGridViewBarang.SelectedCells(4).Value
        TextBoxHargaJual.Text = DataGridViewBarang.SelectedCells(5).Value
        ComboBoxWarna.Text = DataGridViewBarang.SelectedCells(6).Value
        ComboBoxUkuran.Text = DataGridViewBarang.SelectedCells(7).Value
        TextBoxStok.Text = DataGridViewBarang.SelectedCells(8).Value
        ComboBoxSatuan.Text = DataGridViewBarang.SelectedCells(9).Value


        TextBoxNamaSepatu.Focus()

        ButtonSimpan.Enabled = False
        ButtonUbah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonBatal.Enabled = True

        TextBoxNamaSepatu.Focus()

        Call Data_Record()
        Call Data_Kategori()
        Call Data_Merk()
        Call Data_Warna()
        Call Data_Ukuran()
        Call Data_Satuan()

    End Sub

    Private Sub DataGridViewBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellContentClick

    End Sub
End Class