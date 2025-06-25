Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormMasterUser
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tbluser As DataTable

    ' Menampilkan data user ke dalam DataGridView
    Sub Data_Record()
        tbluser = Proses.ExecuteQuery("SELECT username, password, nik FROM user ORDER BY nik ASC")
        DataGridViewUser.DataSource = tbluser
        DataGridViewUser.Columns(0).HeaderText = "Username"
        DataGridViewUser.Columns(1).HeaderText = "Password"
        DataGridViewUser.Columns(2).HeaderText = "NIK"
        DataGridViewUser.Columns(0).Width = 120
        DataGridViewUser.Columns(1).Width = 120
        DataGridViewUser.Columns(2).Width = 125
    End Sub

    ' Memuat data dari form karyawan ke ComboBoxNik
    Private Sub FormMasterUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim karyawan As DataTable
        karyawan = Proses.ExecuteQuery("SELECT nik FROM karyawan")
        ComboBoxNik.Items.Clear()
        For Each row As DataRow In karyawan.Rows
            ComboBoxNik.Items.Add(row("nik").ToString())
        Next
        Data_Record()
        ResetForm()
    End Sub

    ' Fungsi untuk tombol Simpan
    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Try
            If ComboBoxNik.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(TextBoxUsername.Text) OrElse String.IsNullOrWhiteSpace(TextBoxPassword.Text) Then
                MsgBox("Mohon lengkapi semua data!", MsgBoxStyle.Exclamation, "Peringatan")
                Return
            End If

            SQL = "INSERT INTO user (nik, username, password) VALUES ('" & ComboBoxNik.Text & "', '" & TextBoxUsername.Text & "', '" & TextBoxPassword.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Informasi")
            Data_Record()
            ResetForm()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menyimpan data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' Fungsi untuk tombol Ubah
    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        Try
            If ComboBoxNik.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(TextBoxUsername.Text) OrElse String.IsNullOrWhiteSpace(TextBoxPassword.Text) Then
                MsgBox("Mohon lengkapi semua data!", MsgBoxStyle.Exclamation, "Peringatan")
                Return
            End If

            SQL = "UPDATE user SET username = '" & TextBoxUsername.Text & "', password = '" & TextBoxPassword.Text & "' WHERE nik = '" & ComboBoxNik.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data berhasil diubah!", MsgBoxStyle.Information, "Informasi")
            Data_Record()
            ResetForm()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat mengubah data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' Fungsi untuk tombol Hapus
    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Try
            If ComboBoxNik.SelectedIndex = -1 Then
                MsgBox("Pilih NIK yang ingin dihapus!", MsgBoxStyle.Exclamation, "Peringatan")
                Return
            End If

            SQL = "DELETE FROM user WHERE nik = '" & ComboBoxNik.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Informasi")
            Data_Record()
            ResetForm()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menghapus data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' Fungsi untuk mereset form setelah operasi selesai
    Private Sub ResetForm()
        ComboBoxNik.SelectedIndex = -1
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        ButtonSimpan.Enabled = False
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
    End Sub

    ' Fungsi untuk menangani perubahan pada ComboBoxNik
    Private Sub ComboBoxNik_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxNik.SelectedIndexChanged
        If ComboBoxNik.SelectedIndex <> -1 Then
            Dim selectedNik As String = ComboBoxNik.SelectedItem.ToString()
            Dim user As DataTable
            user = Proses.ExecuteQuery("SELECT username, password FROM user WHERE nik = '" & selectedNik & "'")

            If user.Rows.Count > 0 Then
                TextBoxUsername.Text = user.Rows(0).Item("username").ToString()
                TextBoxPassword.Text = user.Rows(0).Item("password").ToString()
                ButtonUbah.Enabled = True
                ButtonHapus.Enabled = True
                ButtonSimpan.Enabled = False
            Else
                TextBoxUsername.Clear()
                TextBoxPassword.Clear()
                ButtonUbah.Enabled = False
                ButtonHapus.Enabled = False
                ButtonSimpan.Enabled = True
            End If
        End If
    End Sub

    ' Fungsi untuk menangani double-click pada DataGridView
    Private Sub DataGridViewUser_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewUser.DoubleClick
        If DataGridViewUser.CurrentRow.Index <> -1 Then
            TextBoxUsername.Text = DataGridViewUser.CurrentRow.Cells(0).Value.ToString()
            TextBoxPassword.Text = DataGridViewUser.CurrentRow.Cells(1).Value.ToString()
            ComboBoxNik.Text = DataGridViewUser.CurrentRow.Cells(2).Value.ToString()
            ButtonUbah.Enabled = True
            ButtonHapus.Enabled = True
            ButtonSimpan.Enabled = False
        End If
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If ComboBoxNik.SelectedIndex <> -1 OrElse Not String.IsNullOrWhiteSpace(TextBoxUsername.Text) OrElse Not String.IsNullOrWhiteSpace(TextBoxPassword.Text) Then
            ResetForm() ' Mereset semua input di form
        Else
            Me.Close() ' Menutup form jika tidak ada perubahan
        End If
    End Sub

    ' Menambahkan pengendali tombol Simpan berdasarkan kondisi form
    Private Sub TextBoxUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxUsername.TextChanged
        UpdateButtonState()
    End Sub

    Private Sub TextBoxPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPassword.TextChanged
        UpdateButtonState()
    End Sub

    Private Sub UpdateButtonState()
        ButtonSimpan.Enabled = (Not String.IsNullOrWhiteSpace(TextBoxUsername.Text) AndAlso Not String.IsNullOrWhiteSpace(TextBoxPassword.Text) AndAlso ComboBoxNik.SelectedIndex <> -1)
    End Sub
End Class
