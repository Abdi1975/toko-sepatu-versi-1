Imports System.Data.Odbc

Public Class FormKaryawan

    Private PathFile As String = Nothing
    Dim sql As String
    Dim Proses As New Koneksi
    Dim karyawan As DataTable

    Sub Data_Record()
        karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan ORDER BY nik ASC")
        DataGridViewKaryawan.DataSource = karyawan
        DataGridViewKaryawan.Columns(0).Width = 50
        DataGridViewKaryawan.Columns(1).Width = 170
        DataGridViewKaryawan.Columns(2).Width = 70
        DataGridViewKaryawan.Columns(3).Width = 80
        DataGridViewKaryawan.Columns(4).Width = 80
        DataGridViewKaryawan.Columns(5).Width = 170
        DataGridViewKaryawan.Columns(6).Width = 100
    End Sub


    Sub Data_Edit()
        karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan where nik ='" & TextBoxNik.Text & "'")
        DataGridViewKaryawan.DataSource = karyawan
        DataGridViewKaryawan.Columns(0).Width = 50
        DataGridViewKaryawan.Columns(1).Width = 170
        DataGridViewKaryawan.Columns(2).Width = 70
        DataGridViewKaryawan.Columns(3).Width = 80
        DataGridViewKaryawan.Columns(4).Width = 80
        DataGridViewKaryawan.Columns(5).Width = 170
        DataGridViewKaryawan.Columns(6).Width = 100
    End Sub

    Sub Kode_Otomatis()

        'nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan
        karyawan = Proses.ExecuteQuery("SELECT * FROM karyawan order by nik desc")

        'karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan order by nik desc")

        If karyawan.Rows.Count = 0 Then
            TextBoxNik.Text = "NIK-001"
        Else
            With karyawan.Rows(0)
                TextBoxNik.Text = .Item("nik")
            End With

            TextBoxNik.Text = Val(Microsoft.VisualBasic.Mid(TextBoxNik.Text, 5, 3)) + 1

            If Len(TextBoxNik.Text) = 1 Then
                TextBoxNik.Text = "NIK-00" & TextBoxNik.Text & ""
            ElseIf Len(TextBoxNik.Text) = 2 Then
                TextBoxNik.Text = "NIK-0" & TextBoxNik.Text & ""
            ElseIf Len(TextBoxNik.Text) = 3 Then
                TextBoxNik.Text = "NIK-" & TextBoxNik.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        ButtonSimpan.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxNik.Enabled = False
        TextBoxNamaKaryawan.ReadOnly = False
        TextBoxNamaKaryawan.Text = ""
        RichTextBoxAlamat.Text = ""
        TextBoxTelepon.Text = ""
        DateTimePickerTanggalLahir.Text = Format(Now, "")
        TextBoxTempatLahir.Text = ""
        TextBoxCari.Text = ""
        ComboBoxCari.Text = "Nama Karyawan"
        TextBoxNamaKaryawan.Focus()
    End Sub


    Private Sub FormKaryawan_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()

    End Sub


    Private Sub ButtonSimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click

        Dim tgl = Format(DateTimePickerTanggalLahir.Value.Date, "yyyy-MM-dd")

        If TextBoxNamaKaryawan.Text = "" Then
            MsgBox("Nama Karyawan Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxNamaKaryawan.Focus()
        ElseIf RichTextBoxAlamat.Text = "" Then
            MsgBox("Alamat Karyawan Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            RichTextBoxAlamat.Focus()

        ElseIf ComboBoxJenisKelamin.Text = "" Then
            MsgBox("Silahkan Pilih Jenis Kelamin", MsgBoxStyle.Exclamation, "Gagal")
            ComboBoxJenisKelamin.Focus()

        ElseIf TextBoxTempatLahir.Text = "" Then
            MsgBox("Tempat Lahir Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxTempatLahir.Focus()

        ElseIf DateTimePickerTanggalLahir.Text = Format(Now, ) Then
            MsgBox("Pilih tanggal lahir karyawan")
            DateTimePickerTanggalLahir.Focus()

        ElseIf TextBoxTelepon.Text = "" Then
            MsgBox("Nomor Telepon Tidak Boleh Kosong", MsgBoxStyle.Critical, "error")
            TextBoxTelepon.Focus()

        Else

            If MsgBox("Apakah Anda Yakin Akan Menyimpan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

                Try
                    sql = "insert into karyawan (nik, nama, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, no_telepon) values ( '" & TextBoxNik.Text & "','" & TextBoxNamaKaryawan.Text & "','" & ComboBoxJenisKelamin.Text & "','" & TextBoxTempatLahir.Text & "','" & tgl & "', '" & RichTextBoxAlamat.Text & "','" & TextBoxTelepon.Text & "')"
                    Proses.ExecuteNonQuery(sql)
                    MessageBox.Show("data baru telah disimpan..!!", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Atur()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try
            End If

        End If

    End Sub


    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        Dim tgl = Format(DateTimePickerTanggalLahir.Value.Date, "yyyy-MM-dd")

        ' Validasi inputan
        If TextBoxNamaKaryawan.Text = "" Then
            MsgBox("Nama Karyawan Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxNamaKaryawan.Focus()
        ElseIf RichTextBoxAlamat.Text = "" Then
            MsgBox("Alamat Karyawan Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            RichTextBoxAlamat.Focus()
        ElseIf ComboBoxJenisKelamin.Text = "" Then
            MsgBox("Silahkan Pilih Jenis Kelamin", MsgBoxStyle.Exclamation, "Gagal")
            ComboBoxJenisKelamin.Focus()
        ElseIf TextBoxTempatLahir.Text = "" Then
            MsgBox("Tempat Lahir Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxTempatLahir.Focus()
        ElseIf DateTimePickerTanggalLahir.Text = Format(Now, "") Then
            MsgBox("Pilih tanggal lahir karyawan")
            DateTimePickerTanggalLahir.Focus()
        ElseIf TextBoxTelepon.Text = "" Then
            MsgBox("Nomor Telepon Tidak Boleh Kosong", MsgBoxStyle.Critical, "error")
            TextBoxTelepon.Focus()
        Else
            ' Konfirmasi untuk mengubah data
            If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                Try
                    ' Query untuk mengupdate data berdasarkan NIK
                    sql = "UPDATE karyawan set nama = '" & TextBoxNamaKaryawan.Text & "', jenis_kelamin = '" & ComboBoxJenisKelamin.Text & "', tempat_lahir = '" & TextBoxTempatLahir.Text & "', tanggal_lahir = '" & tgl & "', alamat ='" & RichTextBoxAlamat.Text & "', no_telepon ='" & TextBoxTelepon.Text & "' where nik = '" & TextBoxNik.Text & "'"
                    Proses.ExecuteNonQuery(sql)
                    MessageBox.Show("Data sudah diperbaiki...!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Atur()  ' Mengatur ulang tampilan
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try
            End If
        End If
    End Sub




    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        ' Konfirmasi penghapusan
        If MsgBox("Apakah anda ingin menghapus data ini ?", MsgBoxStyle.OkCancel, "Konfirmasi !") = MsgBoxResult.Ok Then
            Try
                ' Menghapus data berdasarkan NIK yang dipilih
                sql = "DELETE FROM karyawan WHERE nik = '" & TextBoxNik.Text & "'; "
                Proses.ExecuteNonQuery(sql)
                MessageBox.Show("Data sudah dihapus...!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Atur()  ' Mengatur ulang tampilan
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If
    End Sub




    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If TextBoxNamaKaryawan.Text.Count > 0 Then
            Call Atur()
            TextBoxTelepon.Text = ""
            RichTextBoxAlamat.Text = ""
            TextBoxTempatLahir.Text = ""
            Format(DateTimePickerTanggalLahir.Value, "YYYY-MM-DD")
        ElseIf TextBoxNamaKaryawan.Focus Then
            Me.Close()
        Else
            End
        End If
    End Sub



    Private Sub DataGridViewKaryawan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewKaryawan.DoubleClick
        ' Menangkap nilai yang dipilih pada DataGridView dan memuatnya ke dalam input form
        TextBoxNik.Text = DataGridViewKaryawan.SelectedCells(0).Value
        TextBoxNamaKaryawan.Text = DataGridViewKaryawan.SelectedCells(1).Value
        ComboBoxJenisKelamin.Text = DataGridViewKaryawan.SelectedCells(2).Value
        TextBoxTempatLahir.Text = DataGridViewKaryawan.SelectedCells(3).Value
        DateTimePickerTanggalLahir.Value = DataGridViewKaryawan.SelectedCells(4).Value
        RichTextBoxAlamat.Text = DataGridViewKaryawan.SelectedCells(5).Value
        TextBoxTelepon.Text = DataGridViewKaryawan.SelectedCells(6).Value

        ' Memfokuskan pada TextBox Nama Karyawan
        TextBoxNamaKaryawan.Focus()

        ' Mengaktifkan tombol untuk mengubah atau menghapus
        ButtonUbah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonSimpan.Enabled = False

        ' Memanggil fungsi untuk edit data yang sesuai
        Call Data_Edit()
    End Sub


    Private Sub TextBoxCari_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCari.TextChanged

        If ComboBoxCari.SelectedItem = "Nama Karyawan" Then
            karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan where nama like '%" & TextBoxCari.Text & "%' order by nik asc")
            DataGridViewKaryawan.DataSource = karyawan
            TextBoxCari.Focus()
        ElseIf ComboBoxCari.SelectedItem = "NIK" Then
            karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan where NIK like '%" & TextBoxCari.Text & "%' order by nik asc")
            DataGridViewKaryawan.DataSource = karyawan
            TextBoxCari.Focus()
        ElseIf ComboBoxCari.SelectedItem = "No Telepon" Then
            karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan where no_telepon like '%" & TextBoxCari.Text & "%' order by nik asc")
            DataGridViewKaryawan.DataSource = karyawan
            TextBoxCari.Focus()
        End If


    End Sub

    Private Sub TextBoxCari_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBoxCari.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            'MsgBox("Masukan Pencarian Tanpa Menggunakan Enter")
            Call DataGridViewKaryawan_DoubleClick(sender, e)
            TextBoxCari.Text = ""
            TextBoxNamaKaryawan.Focus()
        End If
    End Sub

    Private Sub TextBoxNamaKaryawan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNamaKaryawan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ComboBoxJenisKelamin.Focus()
        End If
    End Sub

    Private Sub ComboBoxJenisKelamin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxJenisKelamin.SelectedIndexChanged
        TextBoxTempatLahir.Focus()

    End Sub

    Private Sub TextBoxTempatLahir_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTempatLahir.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DateTimePickerTanggalLahir.Focus()
        End If
    End Sub

    Private Sub RichTectBoxAlamat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBoxAlamat.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBoxTelepon.Focus()
        End If
    End Sub

    Private Sub TextBoxTelpon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTelepon.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
     AndAlso (Not Char.IsDigit(e.KeyChar) _
     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If ButtonSimpan.Enabled = True Then
            If Asc(e.KeyChar) = 13 Then
                ButtonSimpan.Focus()
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                ButtonUbah.Focus()
            End If
        End If



    End Sub

    Private Sub ButtonSimpan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ButtonSimpan.KeyPress

        If ButtonSimpan.Enabled = True Then
            If Asc(e.KeyChar) = 13 Then
                ButtonSimpan_Click_1(sender, e)
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                ButtonUbah_Click(sender, e)

            End If
        End If

    End Sub

    Private Sub DataGridViewKaryawan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKaryawan.CellContentClick

    End Sub
End Class