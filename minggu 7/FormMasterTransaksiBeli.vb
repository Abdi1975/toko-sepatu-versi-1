Imports vb = Microsoft.VisualBasic



Public Class FormMasterTransaksiBeli
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim transaksibeli As DataTable
    Dim Data As DataSet
    Dim a As Integer

    Sub Data_Supplier()
        transaksibeli = Proses.ExecuteQuery("SELECT * FROM supplier")
        If transaksibeli.Rows.Count = 0 Then
        Else
            ComboBoxSupplier.Items.Clear()
            With transaksibeli.Columns(1)
                For a = 0 To transaksibeli.Rows.Count - 1
                    ComboBoxSupplier.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub


    Sub Data_Sepatu()
        transaksibeli = Proses.ExecuteQuery("SELECT * FROM barang")
        If transaksibeli.Rows.Count = 0 Then
        Else
            ComboBoxIDSepatu.Items.Clear()
            With transaksibeli.Columns(1)
                For a = 0 To transaksibeli.Rows.Count - 1
                    ComboBoxIDSepatu.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub


    Sub Data_Record_Pembelian()
        'Dim NoTransaksi As String
        'txtNoTransaksi.Text = NoTransaksi
        'NoTransaksi = txtNoTransaksi.Text

        'transaksibeli = Proses.ExecuteQuery("SELECT kode_trans_beli as 'KODE TRANSAKSI', kode_barang as 'KODE BARANG', nama_barang as 'NAMA BARANG', harga_beli as 'HARGA BELI', jumlah as 'Jumlah', sub_total as 'Total', warna as 'Warna', size as 'Ukuran'  FROM detail_trans_beli where kode_trans_beli = '" & TextBoxNoTransaksi.Text & "' ")
        transaksibeli = Proses.ExecuteQuery("SELECT detail_trans_beli . kode_trans_beli AS 'KODE TRANSAKSI', detail_trans_beli.kode_barang AS 'KODE BARANG', detail_trans_beli.nama_barang AS 'NAMA BARANG', detail_trans_beli.harga_beli AS 'HARGA BELI', detail_trans_beli.jumlah AS 'Jumlah', detail_trans_beli.sub_total AS 'Total', warna.nama_warna AS 'Warna', size.nama_size AS 'Ukuran' FROM detail_trans_beli INNER JOIN warna INNER JOIN size ON detail_trans_beli.warna = warna.kode_warna AND detail_trans_beli.size = size.kode_size WHERE kode_trans_beli = '" & TextBoxNoTransaksi.Text & "' ")

        DataGridViewBeliBarang.DataSource = transaksibeli
        DataGridViewBeliBarang.Columns(0).Visible = False
        DataGridViewBeliBarang.Columns(1).Width = 80
        DataGridViewBeliBarang.Columns(2).Width = 260
        DataGridViewBeliBarang.Columns(3).Width = 140
        DataGridViewBeliBarang.Columns(4).Width = 50
        DataGridViewBeliBarang.Columns(5).Width = 140
        DataGridViewBeliBarang.Columns(6).Width = 160
        DataGridViewBeliBarang.Columns(7).Width = 50


        DataGridViewBeliBarang.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBeliBarang.Columns(5).DefaultCellStyle.Format = "N0"  ' Format untuk Total Harga (tanpa notasi ilmiah)
        DataGridViewBeliBarang.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewBeliBarang.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub



    Sub No_Transaksi_Otomatis()
        'Dim tgl = Format(Tgl_Lahir.Value.Date, "yyyy-MM-dd")

        transaksibeli = Proses.ExecuteQuery("SELECT * FROM trans_beli order by kode_trans_beli desc")
        If transaksibeli.Rows.Count = 0 Then
            TextBoxNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "-001"
        Else
            With transaksibeli.Rows(0)
                TextBoxNoTransaksi.Text = .Item("kode_trans_beli")
            End With
            TextBoxNoTransaksi.Text = Val(Microsoft.VisualBasic.Mid(TextBoxNoTransaksi.Text, 12, 3)) + 1
            If Len(TextBoxNoTransaksi.Text) = 1 Then
                TextBoxNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "-00" & TextBoxNoTransaksi.Text & ""
            ElseIf Len(TextBoxNoTransaksi.Text) = 2 Then
                TextBoxNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "-0" & TextBoxNoTransaksi.Text & ""
            ElseIf Len(TextBoxNoTransaksi.Text) = 3 Then
                TextBoxNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "" & TextBoxNoTransaksi.Text & ""
            End If
        End If
    End Sub

    Sub User()
        TextBoxUser.Text = userlogin
    End Sub

    Sub Atur_Awal_Form()
        ComboBoxIDSepatu.Text = "Pilih Sepatu"
        TextBoxNamaSepatu.Text = ""
        TextBoxHargaBeli.Text = ""
        TextBoxStok.Text = ""
        TextBoxJumlah.Text = ""
        TextBoxTotalHarga.Text = ""
        TextBoxWarna.Text = ""
        TextBoxUkuran.Text = ""
        TextBoxNoTransaksi.Enabled = False
        TextBoxUser.Enabled = False
        ComboBoxIDSepatu.Focus()

        Call Data_Sepatu()
        Call Data_Supplier()
        Call Data_Record_Pembelian()
        Call No_Transaksi_Otomatis()
        Call User()
    End Sub

    Private Sub FormMasterTransaksiBeli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur_Awal_Form()
        'txtUserTS.Text = userlogin
        ComboBoxIDSepatu.Focus()
    End Sub


    Private Sub ComboBoxSepatu_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIDSepatu.SelectedIndexChanged
        transaksibeli = Proses.ExecuteQuery("SELECT * FROM barang where kode_barang = '" & vb.Left(ComboBoxIDSepatu.Text, 7) & "'")

        'transaksibeli = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'KD BRG', barang.nama_barang AS 'NAMA BRG', kategori.nama_kategori AS 'KATEGORI', merk.nama_merk AS 'MERK', barang.harga_beli AS 'BELI', barang.harga_jual AS 'JUAL',warna.nama_warna AS 'WARNA', size.nama_size AS 'UKURAN', barang.stok AS 'STOK' , satuan.keterangan AS 'SATUAN' FROM barang INNER JOIN kategori ON barang.kategori = kategori.kode_kategori INNER JOIN merk ON barang.kode_merk = merk.kode_merk INNER JOIN warna ON barang.kode_warna = warna.kode_warna INNER JOIN size ON barang.kode_size = size.kode_size INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan WHERE barang.kode_barang = '" & vb.Left(cmbSepatu.Text, 7) & "'")
        If transaksibeli.Rows.Count = 0 Then
        Else
            TextBoxNamaSepatu.Text = transaksibeli.Rows(0).Item("nama_barang")
            TextBoxHargaBeli.Text = transaksibeli.Rows(0).Item("harga_beli")
            TextBoxStok.Text = transaksibeli.Rows(0).Item("stok")
            TextBoxWarna.Text = transaksibeli.Rows(0).Item("kode_warna")
            TextBoxUkuran.Text = transaksibeli.Rows(0).Item("kode_size")
            TextBoxJumlah.Focus()
        End If
    End Sub

    Private Sub ComboBoxSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSupplier.SelectedIndexChanged
        ComboBoxIDSepatu.Focus()
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        On Error GoTo Keluar

        If MsgBox("Apakah Anda Yakin Akan Membatalkan Transaksi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Dim i As Integer

            i = DataGridViewBeliBarang.CurrentRow.Index

            For i = 0 To DataGridViewBeliBarang.Rows.Count - 1
                transaksibeli = Proses.ExecuteQuery("SELECT * FROM barang where kode_barang = '" & DataGridViewBeliBarang.Item(1, i).Value & "'")
                If transaksibeli.Rows.Count = 0 Then
                Else
                    'If MsgBox("Apakah Anda Yakin Akan Membatalkan Transaksi Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                    Dim Jumlah = Val(transaksibeli.Rows(0).Item("stok")) - Val(DataGridViewBeliBarang.Item(4, i).Value)
                    SQL = "UPDATE barang set stok = '" & CInt(Jumlah) & "' where kode_barang = '" & DataGridViewBeliBarang.Item(1, i).Value & "'"
                    Proses.ExecuteNonQuery(SQL)
                    'End If

                End If
            Next
            SQL = "DELETE FROM detail_trans_beli where kode_trans_beli ='" & TextBoxNoTransaksi.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Transaksi sudah dibatalkan...!!", "Pembatalan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call Atur_Awal_Form()
            Call No_Transaksi_Otomatis()
            Call Data_Record_Pembelian()
        End If

Keluar:
    End Sub


    Private Sub ButtonProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProses.Click
        If MsgBox("Apakah Anda Yakin Akan Memproses Transaksi ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                SQL = "INSERT INTO trans_beli (kode_trans_beli, kode_supplier, username, total, tanggal_trans_beli) VALUES ('" & TextBoxNoTransaksi.Text & "','" & vb.Left(ComboBoxSupplier.SelectedItem, 7) & "','" & userlogin & "','" & TextBoxTotalHarga.Text & "','" & Format(Now, "yyyy-MM-dd") & "')"
                Proses.ExecuteNonQuery(SQL)

                MessageBox.Show("Transaksi Pembelian Berhasil", "Sukses", MessageBoxButtons.OK)

                'FrmRptNotaDetailPembelian.ShowDialog()

                Proses.CloseConn()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try

        End If
        Call No_Transaksi_Otomatis()
        Call Atur_Awal_Form()

    End Sub




    Private Sub TextBoxJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxJumlah.KeyPress


        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TextBoxJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                If ComboBoxSupplier.Text = "Pilih Supplier" Then ComboBoxSupplier.Focus() : Exit Sub
                'If Val(TxtStockBrg.Text) < Val(TxtJml.Text) Then MsgBox("maaf,stock tidak mencukupi ") : Exit Sub
                Call total_harga()
                Call update_stock()
            Case Else
                e.KeyChar = Chr(0)
        End Select


        If (Not Char.IsControl(e.KeyChar) _
     AndAlso (Not Char.IsDigit(e.KeyChar) _
     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub total_harga()
        Dim total_harga = Val(TextBoxJumlah.Text) * Val(TextBoxHargaBeli.Text)
        SQL = "insert into detail_trans_beli " _
            & "(kode_trans_beli, kode_barang, nama_barang, harga_beli, jumlah, sub_total, warna, size) VALUES " _
            & "('" & TextBoxNoTransaksi.Text & "','" & vb.Left(ComboBoxIDSepatu.Text, 7) & "','" & TextBoxNamaSepatu.Text & "' " _
            & ",'" & TextBoxHargaBeli.Text & "','" & TextBoxJumlah.Text & "','" & total_harga & "','" & TextBoxWarna.Text & "','" & TextBoxUkuran.Text & "')"

        'SQL = "insert into detail_trans_beli " _
        '    & "(kode_barang, nama_barang, harga_beli, jumlah, sub_total) VALUES " _
        '    & "('" & vb.Left(cmbSepatu.Text, 7) & "','" & txtNamaSepatu.Text & "' " _
        '    & ",'" & txtHargaBeli.Text & "','" & txtJumlah.Text & "','" & total_harga & "')"
        Proses.ExecuteNonQuery(SQL)

    End Sub


    '    INSERT INTO detail_trans_beli
    '(kode_trans_beli, kode_barang, harga_beli, jumlah`, sub_total) 
    'VALUES ('" & txtNoTransaksi & "', 'cmbSepatu', '10', '10', '100'); 



    Private Sub update_stock()
        Dim stok = Val(TextBoxStok.Text) + Val(TextBoxJumlah.Text)
        SQL = "update barang set stok = '" & stok & "' where kode_barang = '" & vb.Left(ComboBoxIDSepatu.Text, 7) & "'"
        Proses.ExecuteNonQuery(SQL)
        ComboBoxIDSepatu.Text = "Pilih Sepatu"
        'cmbSupplier.Text = "Pilih Supplier"
        TextBoxNamaSepatu.Text = ""
        TextBoxHargaBeli.Text = ""
        TextBoxStok.Text = ""
        TextBoxJumlah.Text = ""
        TextBoxWarna.Text = ""
        TextBoxUkuran.Text = ""


        ComboBoxSupplier.Focus()


        Call Data_Record_Pembelian()
        TextBoxTotalHarga.Text = ""

        Dim i As Integer
        Dim total As Double

        total = 0
        For i = 0 To DataGridViewBeliBarang.Rows.Count - 1
            total += Val(DataGridViewBeliBarang.Item(5, i).Value)
        Next
        TextBoxTotalHarga.Text = Format(Val(Replace(total, ".", "")))

    End Sub

    Private Sub TextBoxHargaBeli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxHargaBeli.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            TextBoxStok.Focus()
        End If
    End Sub

    Private Sub TextBoxStok_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxStok.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            TextBoxJumlah.Focus()
        End If
    End Sub

    Private Sub ButtonTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTutup.Click

        If MsgBox("Apakah Anda Yakin Akan Menutup Form Pembelian Barang Ini ??", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBoxIDSepatu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxIDSepatu.KeyPress
        'Koding Agar Tekan Enter Mau Pindah Ke Text Box Berikutnya
        If Asc(e.KeyChar) = 13 Then
            TextBoxJumlah.Focus()
        End If
    End Sub

    Private Sub DataGridViewBeliBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBeliBarang.CellContentClick

    End Sub

    Private Sub TextBoxNoTransaksi_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNoTransaksi.TextChanged

    End Sub
End Class