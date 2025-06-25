Imports MySql.Data.MySqlClient
Imports vb = Microsoft.VisualBasic


Public Class FormMasterTransaksiJual

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim transaksi_jual As DataTable
    Dim Data As DataSet
    Dim a As Integer
    Dim Disc As Double
    Dim grandtotal As Double
    Dim bayar As Double
    Dim kembalian As Double
    Dim totalNoDiskon As Double
    Dim conn As New MySqlConnection("Server=localhost; Database=db_toko_sepatu; Uid=username; Pwd=password;")



    Sub Data_Record_Penjualan()
        'Dim NoTransaksi As String
        'txtNoTransaksi.Text = NoTransaksi
        'NoTransaksi = txtNoTransaksi.Text

        'transaksibeli = Proses.ExecuteQuery("SELECT kode_trans_beli as 'KODE TRANSAKSI', kode_barang as 'KODE BARANG', nama_barang as 'NAMA BARANG', harga_beli as 'HARGA BELI', jumlah as 'Jumlah', sub_total as 'Total', warna as 'Warna', size as 'Ukuran'  FROM detail_trans_beli where kode_trans_beli = '" & txtNoTransaksi.Text & "' ")
        'transaksi_jual = Proses.ExecuteQuery("SELECT detail_trans_beli.kode_trans_beli AS 'KODE TRANSAKSI', detail_trans_beli.kode_barang AS 'KODE BARANG', detail_trans_beli.nama_barang AS 'NAMA BARANG', detail_trans_beli.harga_beli AS 'HARGA BELI', detail_trans_beli.jumlah AS 'Jumlah', detail_trans_beli.sub_total AS 'Total', warna.nama_warna AS 'Warna', size.nama_size AS 'Ukuran' FROM detail_trans_beli INNER JOIN warna INNER JOIN size ON detail_trans_beli.warna = warna.kode_warna AND detail_trans_beli.size = size.kode_size WHERE kode_trans_beli = '" & txtNoTransaksi.Text & "' ")

        transaksi_jual = Proses.ExecuteQuery("SELECT detail_trans_jual.kode_trans_jual AS 'KODE TRANSAKSI', detail_trans_jual.kode_barang AS 'KODE BARANG', detail_trans_jual.nama_barang AS 'NAMA BARANG', detail_trans_jual.harga_jual AS 'HARGA BELI', detail_trans_jual.jumlah AS 'JML BRG', detail_trans_jual.sub_total AS 'TOTAL', warna.nama_warna AS 'WARNA', size.nama_size AS 'UKURAN' FROM detail_trans_jual INNER JOIN warna INNER JOIN size ON detail_trans_jual.warna = warna.kode_warna AND detail_trans_jual.size = size.kode_size WHERE kode_trans_jual = '" & TextBoxNoTransaksi.Text & "'")

        DataGridViewJualBarang.DataSource = transaksi_jual
        DataGridViewJualBarang.Columns(0).Visible = False
        DataGridViewJualBarang.Columns(1).Width = 80
        DataGridViewJualBarang.Columns(2).Width = 260
        DataGridViewJualBarang.Columns(3).Width = 120
        DataGridViewJualBarang.Columns(4).Width = 50
        DataGridViewJualBarang.Columns(5).Width = 160
        DataGridViewJualBarang.Columns(6).Width = 200
        DataGridViewJualBarang.Columns(7).Width = 80

        DataGridViewJualBarang.Columns(3).DefaultCellStyle.Format = "N0"  ' Format untuk Total Harga (tanpa notasi ilmiah)
        DataGridViewJualBarang.Columns(5).DefaultCellStyle.Format = "N0"  ' Format untuk Total Harga (tanpa notasi ilmiah)
        DataGridViewJualBarang.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewJualBarang.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Sub Data_Sepatu()
        transaksi_jual = Proses.ExecuteQuery("SELECT * FROM barang")
        If transaksi_jual.Rows.Count = 0 Then
        Else
            ComboBoxSepatu.Items.Clear()
            With transaksi_jual.Columns(1)
                For a = 0 To transaksi_jual.Rows.Count - 1
                    ComboBoxSepatu.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub No_Transaksi_Otomatis()
        'Dim tgl = Format(Tgl_Lahir.Value.Date, "yyyy-MM-dd")

        transaksi_jual = Proses.ExecuteQuery("SELECT * FROM trans_jual order by kode_trans_jual desc")
        If transaksi_jual.Rows.Count = 0 Then
            TextBoxNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "-001"
        Else
            With transaksi_jual.Rows(0)
                TextBoxNoTransaksi.Text = .Item("kode_trans_jual")
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

        TextBoxPembeli.Focus()
        ComboBoxSepatu.Text = "Pilih Sepatu"

        TextBoxNamaSepatu.Text = ""
        TextBoxHargaJual.Text = ""
        TextBoxStok.Text = ""
        TextBoxJumlah.Text = ""
        TextBoxTotalHarga.Text = ""
        TextBoxWarna.Text = ""
        TextBoxUkuran.Text = ""

        TextBoxBayar.Text = ""
        TextBoxDiskon.Text = "0"
        TextBoxKembalian.Text = ""
        TextBoxTotalBayar.Text = ""


        TextBoxNoTransaksi.Enabled = False
        TextBoxUser.Enabled = False
        TextBoxTotalBayar.Enabled = False
        TextBoxTotalHarga.Enabled = False
        TextBoxKembalian.Enabled = False


        Call Data_Sepatu()
        Call Data_Record_Penjualan()
        Call No_Transaksi_Otomatis()
        Call User()
    End Sub

    Private Sub FormMasterTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur_Awal_Form()

    End Sub

    Private Sub ComboBoxSepatu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSepatu.SelectedIndexChanged

        transaksi_jual = Proses.ExecuteQuery("SELECT * FROM barang where kode_barang = '" & vb.Left(ComboBoxSepatu.Text, 7) & "'")

        If transaksi_jual.Rows.Count = 0 Then
        Else
            TextBoxNamaSepatu.Text = transaksi_jual.Rows(0).Item("nama_barang")
            TextBoxHargaJual.Text = transaksi_jual.Rows(0).Item("harga_jual")
            TextBoxStok.Text = transaksi_jual.Rows(0).Item("stok")
            TextBoxWarna.Text = transaksi_jual.Rows(0).Item("kode_warna")
            TextBoxUkuran.Text = transaksi_jual.Rows(0).Item("kode_size")
            TextBoxJumlah.Focus()
        End If

    End Sub




    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click

        If MsgBox("Apakah Anda Yakin Akan Membatalkan Transaksi Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try
                Dim i As Integer

                i = DataGridViewJualBarang.CurrentRow.Index

                For i = 0 To DataGridViewJualBarang.Rows.Count - 1
                    transaksi_jual = Proses.ExecuteQuery("SELECT * FROM barang where kode_barang = '" & DataGridViewJualBarang.Item(1, i).Value & "'")
                    If transaksi_jual.Rows.Count = 0 Then
                    Else
                        Dim Jumlah = Val(transaksi_jual.Rows(0).Item("stok")) + Val(DataGridViewJualBarang.Item(4, i).Value)
                        SQL = "UPDATE barang set stok = '" & CInt(Jumlah) & "' where kode_barang = '" & DataGridViewJualBarang.Item(1, i).Value & "'"
                        Proses.ExecuteNonQuery(SQL)
                    End If
                Next
                SQL = "DELETE FROM detail_trans_jual where kode_trans_jual ='" & TextBoxNoTransaksi.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MessageBox.Show("Transaksi sudah dibatalkan...!!", "Pembatalan Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call Atur_Awal_Form()
                Call No_Transaksi_Otomatis()
                Call Data_Record_Penjualan()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try

        End If

        'Keluar:
    End Sub


    Private Sub TextBoxPembeli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPembeli.KeyPress
        '   If (Not Char.IsControl(e.KeyChar) _
        'AndAlso (Not Char.IsDigit(e.KeyChar) _
        'AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
        '       e.Handled = True
        '   End If

        Select Case (e.KeyChar)

            Case Chr(13)
                If ComboBoxSepatu.Text = "Pilih Sepatu" Then
                    'If Asc(e.KeyChar) = 13 Then
                    ComboBoxSepatu.Focus() : Exit Sub
                ElseIf TextBoxNamaSepatu.TextLength > 1 Then

                    TextBoxJumlah.Focus()

                End If
            Case Else

        End Select

    End Sub

    Private Sub ButtonTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTutup.Click
        If MsgBox("Apakah Anda Yakin Akan Menutup Form Pembelian Barang Ini ??", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub TextBoxJumlah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxJumlah.KeyPress

        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TextBoxJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                'If txtPembeli.Text = "" Then txtPembeli.Focus() : Exit Sub
                ''If Val(TxtStockBrg.Text) < Val(TxtJml.Text) Then MsgBox("maaf,stock tidak mencukupi ") : Exit Sub

                If TextBoxPembeli.TextLength < 3 Then
                    MsgBox("Nama Pembeli Tidak Boleh Kurang Dari 3 Karakter", TextBoxPembeli.Focus(), "Salah !!!!") : Exit Sub
                ElseIf TextBoxJumlah.TextLength = 0 Then
                    MsgBox("Masukan Jumlah Pembelian Barang", MsgBoxStyle.Information, "QTY Salah") : Exit Sub
                    TextBoxJumlah.Focus()
                End If

                If Val(TextBoxStok.Text) < Val(TextBoxStok.Text) Then MsgBox("Maaf Stock Tidak Mencukupi", MsgBoxStyle.OkCancel, "Error") : Exit Sub
                Call total_harga()
                Call update_stock()

                If Val(TextBoxDiskon.Text) = 0 Then
                    TextBoxTotalBayar.Text = Val(TextBoxTotalHarga.Text)
                End If

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
        Dim total_harga = Val(TextBoxJumlah.Text) * Val(TextBoxHargaJual.Text)
        SQL = "insert into detail_trans_jual " _
            & "(kode_trans_jual, kode_barang, nama_barang, harga_jual, jumlah, sub_total, warna, size) VALUES " _
            & "('" & TextBoxNoTransaksi.Text & "','" & vb.Left(ComboBoxSepatu.Text, 7) & "','" & TextBoxNamaSepatu.Text & "' " _
            & ",'" & TextBoxHargaJual.Text & "','" & TextBoxJumlah.Text & "','" & total_harga & "','" & TextBoxWarna.Text & "','" & TextBoxUkuran.Text & "')"

        'SQL = "insert into detail_trans_jual " _
        '    & "(kode_barang, nama_barang, harga_jual, jumlah, sub_total) VALUES " _
        '    & "('" & vb.Left(cmbSepatu.Text, 7) & "','" & txtNamaSepatu.Text & "' " _
        '    & ",'" & txtHargaJual.Text & "','" & txtJumlah.Text & "','" & total_harga & "')"
        Proses.ExecuteNonQuery(SQL)

    End Sub

    Private Sub update_stock()
        Dim stok = Val(TextBoxStok.Text) - Val(TextBoxJumlah.Text)
        SQL = "update barang set stok = '" & stok & "' where kode_barang = '" & vb.Left(ComboBoxSepatu.Text, 7) & "'"
        Proses.ExecuteNonQuery(SQL)
        'txtPembeli = ""
        ComboBoxSepatu.Text = "Pilih Sepatu"
        TextBoxNamaSepatu.Text = ""
        TextBoxHargaJual.Text = ""
        TextBoxStok.Text = ""
        TextBoxJumlah.Text = ""
        TextBoxWarna.Text = ""
        TextBoxUkuran.Text = ""
        ComboBoxSepatu.Focus()

        Call Data_Record_Penjualan()
        TextBoxTotalHarga.Text = ""

        Dim i As Integer
        Dim total As Double

        total = 0
        For i = 0 To DataGridViewJualBarang.Rows.Count - 1
            total += Val(DataGridViewJualBarang.Item(5, i).Value)
        Next
        TextBoxTotalHarga.Text = Format(Val(Replace(total, ".", "")))


    End Sub




    Sub ProsesTransaksi()
        'SQL = "INSERT INTO trans_jual (kode_trans_jual, pembeli, username, total_belanja, diskon, total_akhir, bayar, kembalian, tanggal_trans_jual) VALUES ('" & txtNoTransaksi.Text & "','" & txtPembeli.Text & "','" & userlogin & "','" & txtTotal.Text & "','" & Val(txtDiskon.Text) & "','" & Val(txtTotalAkhir) & "','" & Val(txtBayar.Text) & "','" & Val(txtKembalian.Text) & "','" & Format(Now.Date) & "')"
        'Proses.ExecuteNonQuery("INSERT INTO trans_jual (kode_trans_jual, pembeli, username, total_belanja, diskon, total_akhir, bayar, kembalian, tanggal_trans_jual) VALUES ('" & txtNoTransaksi.Text & "','" & txtPembeli.Text & "','" & userlogin & "','" & txtTotal.Text & "','" & txtDiskon.Text & "','" & txtTotalAkhir & "','" & txtBayar.Text & "','" & txtKembalian.Text & "','" & Format(Now, da) & "')")

        Try

            If MsgBox("Apakah Anda Yakin Akan Memproses Transaksi Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                SQL = "INSERT INTO trans_jual (kode_trans_jual, pembeli, username, total_belanja, diskon, total_akhir, bayar, kembalian, tanggal_trans_jual) VALUES ('" & TextBoxNoTransaksi.Text & "','" & TextBoxPembeli.Text & "','" & userlogin & "','" & TextBoxTotalHarga.Text & "','" & Val(TextBoxDiskon.Text) & "','" & Val(TextBoxTotalBayar.Text) & "','" & Val(TextBoxBayar.Text) & "','" & Val(TextBoxKembalian.Text) & "','" & Format(Now, "yyyy-MM-dd") & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Transaksi Berhasil Disimpan", MsgBoxStyle.OkOnly, "Sukses")

                '
                'Print.FrmRptNotaPenjualan(True)

                Call No_Transaksi_Otomatis()
                Call Atur_Awal_Form()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub


    Private Sub ButtonProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProses.Click

        If DataGridViewJualBarang.Columns(0).Name = "" Then 'txtBayar.Text = "" Then
            MsgBox("Tidak Ada Sepatu yang Dipilih ", MsgBoxStyle.Critical, "Proses Gagal") : Exit Sub
        ElseIf TextBoxBayar.Text = "" Then 'DGTransaksi.Columns(0).Name = "" Then 
            MsgBox("Masukan Nilai Bayar", MsgBoxStyle.OkOnly, "Proses Gagal")
            TextBoxBayar.Focus() : Exit Sub
        ElseIf bayar < grandtotal Then
            MsgBox("Uang Kurang, Dilarang Ngebon")

        ElseIf Val(TextBoxTotalBayar.TextLength) = 0 Then
            MsgBox("Tidak Ada Transaksi", MsgBoxStyle.OkOnly, "Error") : Exit Sub
        Else
            'If MsgBox("Apakah Anda Yakin Akan Memproses Transaksi ?", vbYesNo, "Konfirmasi") = vbYes Then
            '    SQL = "INSERT INTO trans_jual (kode_trans_jual, pembeli, username, total_belanja, diskon, total_akhir, bayar, kembalian, tanggal_trans_jual) VALUES ('" & txtNoTransaksi.Text & "','" & txtPembeli.Text & "','" & userlogin & "','" & txtTotal.Text & "','" & Val(txtDiskon.Text) & "','" & Val(txtTotalAkhir) & "','" & Val(txtBayar.Text) & "','" & Val(txtKembalian.Text) & "','" & Format(Now, "yyyy-MM-dd") & "')"

            'End If

            'Proses.ExecuteNonQuery(SQL)
            'Call No_Transaksi_Otomatis()
            'Call Atur_Awal_Form()
            Call ProsesTransaksi()
        End If

    End Sub


    Private Sub TextBoxDiskon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxDiskon.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If


        Disc = Val(TextBoxDiskon.Text)
        grandtotal = Val(TextBoxTotalBayar.Text)

        If e.KeyChar = Chr(13) Then
            If (Disc >= 0) And (Disc <= 100) Then
                Disc = Val(TextBoxTotalHarga.Text) * (Disc / 100)
                TextBoxDiskon.Text = Format(Disc, "")
                grandtotal = Val(TextBoxTotalHarga.Text) - Disc
                TextBoxTotalBayar.Text = Format(grandtotal, "")
            Else
                Disc = Val(TextBoxTotalHarga.Text) - Val(TextBoxDiskon.Text)
                TextBoxDiskon.Text = Val(TextBoxDiskon.Text)
                grandtotal = Val(TextBoxTotalHarga.Text) - Val(TextBoxDiskon.Text)
                TextBoxTotalBayar.Text = Format(grandtotal, "")
            End If
            TextBoxBayar.Focus()

        End If


    End Sub

    Private Sub TextBoxBayar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxBayar.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                   AndAlso (Not Char.IsDigit(e.KeyChar) _
                   AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        bayar = Val(TextBoxBayar.Text)
        kembalian = Val(TextBoxKembalian.Text)
        grandtotal = Val(TextBoxTotalBayar.Text)
        totalNoDiskon = Val(TextBoxTotalHarga.Text)


        If TextBoxDiskon.Text = 0 Then
            Call TextBoxDiskon_KeyPress(sender, e)
        End If

        If e.KeyChar = Chr(13) Then
            'If bayar < grandtotal Then
            '    MsgBox("Uang Kurang, Dilarang Ngebon")

            'Else
            kembalian = bayar - Val(TextBoxTotalBayar.Text)
            TextBoxKembalian.Text = Format(kembalian, "")
            If e.KeyChar = Chr(13) Then
                ButtonProses_Click(sender, e)
            End If
            'End If
        End If


    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTutup.Click
        ButtonTutup_Click(sender, e)
    End Sub

    Private Sub ComboBoxSepatu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxSepatu.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBoxJumlah.Focus()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ZHelpUkuranSepatu.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormCariBarang.ShowDialog()

    End Sub



    Private Sub TextBoxBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBayar.TextChanged
        Dim kembalian1 = Val(TextBoxBayar.Text) - Val(TextBoxTotalBayar.Text)

        If kembalian1 < 0 Then
            TextBoxKembalian.Text = Nothing
        Else
            TextBoxKembalian.Text = kembalian1
        End If
    End Sub

    Private Sub TextBoxUkuran_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUkuran.TextChanged

    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FrmRptNotaPenjualan.ShowDialog()

    'End Sub


End Class