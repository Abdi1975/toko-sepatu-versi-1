Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System

Public Class FormMasterSupplier

    Dim sql As String
    Dim Proses As New Koneksi
    Dim supplier As DataTable


    Dim Kode, Nama, Alamat, Email, Web, Cari As String
    Dim Telp As Int32

    Sub Panggil_Data()

        supplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier ORDER BY kode_supplier ASC")
        DataGridViewSupplier.DataSource = supplier
        DataGridViewSupplier.Columns(0).Width = 50
        DataGridViewSupplier.Columns(1).Width = 110
        DataGridViewSupplier.Columns(2).Width = 235
        DataGridViewSupplier.Columns(3).Width = 100
        DataGridViewSupplier.Columns(4).Width = 150
        DataGridViewSupplier.Columns(5).Width = 170

    End Sub

    Sub Data_Edit()

        supplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier where kode_supplier = '" & TextBoxKodeSupplier.Text & "'")
        DataGridViewSupplier.DataSource = supplier
        DataGridViewSupplier.Columns(0).Width = 50
        DataGridViewSupplier.Columns(1).Width = 110
        DataGridViewSupplier.Columns(2).Width = 235
        DataGridViewSupplier.Columns(3).Width = 100
        DataGridViewSupplier.Columns(4).Width = 150
        DataGridViewSupplier.Columns(5).Width = 170

    End Sub


    Sub Kode_Supplier_Auto()
        supplier = Proses.ExecuteQuery("SELECT * FROM supplier order by kode_supplier desc")

        If supplier.Rows.Count = 0 Then
            TextBoxKodeSupplier.Text = "SPL-001"
        Else
            With supplier.Rows(0)
                TextBoxKodeSupplier.Text = .Item("kode_supplier")
            End With

            TextBoxKodeSupplier.Text = Val(Microsoft.VisualBasic.Mid(TextBoxKodeSupplier.Text, 5, 3)) + 1

            If Len(TextBoxKodeSupplier.Text) = 1 Then
                TextBoxKodeSupplier.Text = "SPL-00" & TextBoxKodeSupplier.Text & ""
            ElseIf Len(TextBoxKodeSupplier.Text) = 2 Then
                TextBoxKodeSupplier.Text = "SPL-0" & TextBoxKodeSupplier.Text & ""
            ElseIf Len(TextBoxKodeSupplier.Text) = 3 Then
                TextBoxKodeSupplier.Text = "SPL-" & TextBoxKodeSupplier.Text & ""
            End If
        End If



    End Sub

    Sub Set_Awal()
        Call Panggil_Data()
        Call Kode_Supplier_Auto()
        ButtonSimpan.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxKodeSupplier.Enabled = False
        TextBoxNamaSupplier.ReadOnly = False
        TextBoxNamaSupplier.Text = ""
        RichTextBoxAlamat.Text = ""
        TextBoxTelepon.Text = ""
        TextBoxEmail.Text = ""
        TextBoxWebsite.Text = ""
        TextBoxCari.Text = ""
        ComboBoxCari.Text = "Nama Supplier"
        TextBoxNamaSupplier.Focus()
    End Sub

    Private Sub FormMasterSuplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Set_Awal()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        If TextBoxNamaSupplier.Text = "" Then
            MsgBox("Nama Supplier Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxNamaSupplier.Focus()
        ElseIf RichTextBoxAlamat.Text = "" Then
            MsgBox("Alamat Supplier Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            RichTextBoxAlamat.Focus()

        ElseIf TextBoxTelepon.Text = "" Then
            MsgBox("Silahkan Masukan No Telp Supplier", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxTelepon.Focus()

        ElseIf TextBoxEmail.Text = "" Then
            MsgBox("Data Email Tidak Boleh Kosong", MsgBoxStyle.Information, "Gagal")
            TextBoxEmail.Focus()

        ElseIf TextBoxWebsite.Text = "" Then
            MsgBox("Website Dari Supplier Tidak Boleh Kosong", MsgBoxStyle.Information, "Gagal")
            TextBoxWebsite.Focus()

        Else
            'Koding Untuk Konfirmasi Yes / No

            If MsgBox("Apakah Anda Yakin Akan Menympan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                Try

                    sql = "INSERT INTO supplier (kode_supplier, nama_supplier, alamat, telepon, email, website) VALUES ('" & TextBoxKodeSupplier.Text & "', '" & TextBoxNamaSupplier.Text & "', '" & RichTextBoxAlamat.Text & "', '" & TextBoxTelepon.Text & "', '" & TextBoxEmail.Text & "', '" & TextBoxWebsite.Text & "')"
                    'sql = "INSERT INTO supplier (kode_supplier, nama_supplier, alamat, telepon, email, website) VALUES (@Kode,@Nama,@Alamat, @Telp, @Email, @Website)"
                    'cmd.Parameters.AddWithValue("@kode", MySqlDbType.VarChar).Value = txtKodeSuplier.Text
                    'cmd.Parameters.AddWithValue("@Nama", MySqlDbType.VarChar).Value = txtNamaSuplier
                    'cmd.Parameters.AddWithValue("@Alamat", MySqlDbType.VarChar).Value = txtAlamatSuplier
                    'cmd.Parameters.AddWithValue("@Telp", MySqlDbType.Int32).Value = txtTelpSuplier
                    'cmd.Parameters.AddWithValue("@Email", MySqlDbType.VarChar).Value = txtEmailSuplier
                    'cmd.Parameters.AddWithValue("@Website", MySqlDbType.VarChar).Value = txtWebSuplier
                    Proses.ExecuteNonQuery(sql)
                    MessageBox.Show("Perubahan Data Suplier Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Set_Awal()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try
            End If

        End If

    End Sub

    'Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click



    '    'Dim conn As New MySqlConnection
    '    'Dim cmd As New MySqlCommand
    '    Dim Cn As New MySqlConnection
    '    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
    '    Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
    '    Dim ds As New DataSet

    '    ' Dim strConnection As String
    '    'conn.ConnectionString = strConnection

    '    Try
    '        Cn.Open()
    '        'cmd.Connection = conn

    '        cmd.CommandText = "INSERT INTO supplier (kode_supplier, nama_supplier, alamat, telepon, email, website) VALUES (@Kode,@Nama,@Alamat, @Telp, @Email, @Website)"
    '        cmd.Prepare()
    '        '(@Kode,@Nama,@Alamat, @Telp, @Email, @Website)
    '        cmd.Parameters.AddWithValue("@kode", MySqlDbType.VarChar).Value = txtKodeSuplier.Text
    '        cmd.Parameters.AddWithValue("@Nama", MySqlDbType.VarChar).Value = txtNamaSuplier
    '        cmd.Parameters.AddWithValue("@Alamat", MySqlDbType.VarChar).Value = txtAlamatSuplier
    '        cmd.Parameters.AddWithValue("@Telp", MySqlDbType.Int32).Value = txtTelpSuplier
    '        cmd.Parameters.AddWithValue("@Email", MySqlDbType.VarChar).Value = txtEmailSuplier
    '        cmd.Parameters.AddWithValue("@Website", MySqlDbType.VarChar).Value = txtWebSuplier

    '        cmd.ExecuteNonQuery()
    '    Catch ex As MySqlException
    '        MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click

        If TextBoxNamaSupplier.Text = "" Then
            MsgBox("Nama Supplier Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            TextBoxNamaSupplier.Focus()
        ElseIf RichTextBoxAlamat.Text = "" Then
            MsgBox("Alamat Supplier Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            RichTextBoxAlamat.Focus()

        ElseIf TextBoxTelepon.Text = "" Then
            MsgBox("Silahkan Masukan No Telp Supplier", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxTelepon.Focus()

        ElseIf TextBoxEmail.Text = "" Then
            MsgBox("Data Email Tidak Boleh Kosong", MsgBoxStyle.Information, "Gagal")
            TextBoxEmail.Focus()

        ElseIf TextBoxWebsite.Text = "" Then
            MsgBox("Website Dari Supplier Tidak Boleh Kosong", MsgBoxStyle.Information, "Gagal")
            TextBoxWebsite.Focus()

        Else
            'Koding Untuk Konfirmasi Yes / No

            If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini?", vbYesNo, "Konfirmasi") = vbYes Then
                Try
                    sql = "UPDATE supplier set nama_supplier = '" & TextBoxNamaSupplier.Text & "', alamat = '" & RichTextBoxAlamat.Text & "', telepon = '" & TextBoxTelepon.Text & "', email = '" & TextBoxEmail.Text & "', website ='" & TextBoxWebsite.Text & "' where kode_supplier = '" & TextBoxKodeSupplier.Text & "'"
                    Proses.ExecuteNonQuery(sql)
                    MessageBox.Show("Perubahan Data Suplier Berhasil Diperbaharui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Set_Awal()


                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try

            End If
        End If

    End Sub




    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        'Konfirmasi penghapusan
        If MsgBox("Apakah anda ingin menghapus data ini ?", MsgBoxStyle.OkCancel, "Konfirmasi !") = MsgBoxResult.Ok Then
            Try
                sql = "DELETE FROM supplier WHERE kode_supplier = '" & TextBoxKodeSupplier.Text & "'"
                Proses.ExecuteNonQuery(sql)
                MessageBox.Show("Data Sudah Dihapus...!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Set_Awal()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If
    End Sub



    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If TextBoxNamaSupplier.Text.Count > 0 Then
            Call Set_Awal()
            TextBoxEmail.Text = ""
            TextBoxTelepon.Text = ""
            RichTextBoxAlamat.Text = ""
            TextBoxEmail.Text = ""
            TextBoxWebsite.Text = ""
            TextBoxCari.Text = ""

        ElseIf TextBoxNamaSupplier.Focus Then
            Me.Close()
        Else
            End
        End If
    End Sub


    Private Sub DataGridViewSupplier_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewSupplier.DoubleClick
        TextBoxKodeSupplier.Text = DataGridViewSupplier.SelectedCells(0).Value
        TextBoxNamaSupplier.Text = DataGridViewSupplier.SelectedCells(1).Value
        RichTextBoxAlamat.Text = DataGridViewSupplier.SelectedCells(2).Value
        TextBoxTelepon.Text = DataGridViewSupplier.SelectedCells(3).Value
        TextBoxEmail.Text = DataGridViewSupplier.SelectedCells(4).Value
        TextBoxWebsite.Text = DataGridViewSupplier.SelectedCells(5).Value

        TextBoxNamaSupplier.Focus()

        ButtonUbah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonSimpan.Enabled = False
        Call Data_Edit()
    End Sub


    Private Sub TextBoxCari_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCari.TextChanged

        'Kode = txtKodeSuplier.Text
        'Nama = txtNamaSuplier.Text
        'Alamat = txtAlamatSuplier.Text
        'Telp = Val(txtTelpSuplier.Text)
        'Email = txtEmailSuplier.Text
        'Web = txtWebSuplier.Text
        'Cari = txtCari.Text

        'txtCari.Text = Cari

        If ComboBoxCari.SelectedItem = "Nama Supplier" Then
            supplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier where nama_supplier like '%" & TextBoxCari.Text & "%' order by kode_supplier asc")
            DataGridViewSupplier.DataSource = supplier
            TextBoxCari.Focus()
        ElseIf ComboBoxCari.SelectedItem = "Kode Supplier" Then
            supplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier where kode_supplier like '%" & TextBoxCari.Text & "%' order by kode_supplier asc")
            DataGridViewSupplier.DataSource = supplier
            TextBoxCari.Focus()
        ElseIf ComboBoxCari.SelectedItem = "Telepon" Then
            supplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier where telepon like '%" & TextBoxCari.Text & "%' order by kode_supplier asc")
            DataGridViewSupplier.DataSource = supplier
            TextBoxCari.Focus()
        End If
    End Sub

    Private Sub TextBoxCari_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBoxCari.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            'MsgBox("Masukan Pencarian Tanpa Menggunakan Enter")
            Call DataGridViewSupplier_DoubleClick(sender, e)
            TextBoxCari.Text = ""
            TextBoxNamaSupplier.Focus()
        End If
    End Sub

    Private Sub ComboBoxCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCari.SelectedIndexChanged

    End Sub

    Private Sub TextBoxNamaSupplier_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNamaSupplier.KeyPress
        If Asc(e.KeyChar) = 13 Then ' Hanya jika Enter ditekan
            RichTextBoxAlamat.Focus()
        End If
    End Sub


    Private Sub RichTextBoxAlamat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBoxAlamat.KeyPress
        'Koding Agar Tekan Enter Mau Pindah Ke Text Box Berikutnya
        If Asc(e.KeyChar) = 13 Then
            TextBoxTelepon.Focus()
        End If
    End Sub

    Private Sub TextBoxTelepon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTelepon.KeyPress
        'Koding Agar Tekan Enter Mau Pindah Ke Text Box Berikutnya
        If Asc(e.KeyChar) = 13 Then
            TextBoxEmail.Focus()
        End If

        If (Not Char.IsControl(e.KeyChar) _
AndAlso (Not Char.IsDigit(e.KeyChar) _
AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxEmail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxEmail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBoxWebsite.Focus()
        End If
    End Sub

    Private Sub TextBoxWebsite_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxWebsite.KeyPress

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
End Class