Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormMasterKategori

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim kategori As DataTable



    Sub Data_Record()
        kategori = Proses.ExecuteQuery("SELECT * FROM kategori")
        DataGridViewKategori.DataSource = kategori
        DataGridViewKategori.Columns(0).Width = 125
        DataGridViewKategori.Columns(1).Width = 180
    End Sub


    Sub Kode_Otomatis()
        kategori = Proses.ExecuteQuery("SELECT * FROM kategori order by kode_kategori desc")

        If kategori.Rows.Count = 0 Then
            TextBoxKodeKategori.Text = "KTG-001"
        Else
            With kategori.Rows(0)
                TextBoxKodeKategori.Text = .Item("kode_kategori")
            End With
            TextBoxKodeKategori.Text = Val(Microsoft.VisualBasic.Mid(TextBoxKodeKategori.Text, 5, 3)) + 1

            If Len(TextBoxKodeKategori.Text) = 1 Then
                TextBoxKodeKategori.Text = "KTG-00" & TextBoxKodeKategori.Text & ""
            ElseIf Len(TextBoxKodeKategori.Text) = 2 Then
                TextBoxKodeKategori.Text = "KTG-0" & TextBoxKodeKategori.Text & ""
            ElseIf Len(TextBoxKodeKategori.Text) = 3 Then
                TextBoxKodeKategori.Text = "KTG-" & TextBoxKodeKategori.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        ButtonSimpan.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxKodeKategori.Enabled = False
        TextBoxNamaKategori.Text = ""
        TextBoxNamaKategori.Focus()
    End Sub



    Private Sub FormMasterSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()

    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        'If txtNamaKategori.Text = "" Then txtNamaKategori.Focus() : Exit Sub


        If TextBoxNamaKategori.Text = "" Then
            MsgBox("Nama Ukuran Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxNamaKategori.Focus() : Exit Sub
        End If
        Try
            SQL = "INSERT INTO kategori VALUES ('" & TextBoxKodeKategori.Text & "','" & TextBoxNamaKategori.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data Kategori Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
            Call Atur()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        'If txtNamaKategori.Text = "" Then txtNamaKategori.Focus() : Exit Sub

        If TextBoxNamaKategori.Text = "" Then
            MsgBox("Nama Ukuran Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxNamaKategori.Focus() : Exit Sub

        End If

        Try
            SQL = "UPDATE kategori set nama_kategori = '" & TextBoxNamaKategori.Text & "' where kode_kategori ='" & TextBoxKodeKategori.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data Berhasil Diperharui", MsgBoxStyle.OkOnly, "Sukses")
            Call Atur()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub


    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If MsgBox("Apakah Anda Yakin Akan Menghapus Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try
                SQL = "DELETE FROM kategori where kode_kategori = '" & TextBoxKodeKategori.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()
                'End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If
    End Sub
    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If TextBoxNamaKategori.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub DataGridViewKategori_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewKategori.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        TextBoxKodeKategori.Text = DataGridViewKategori.SelectedCells(0).Value
        TextBoxNamaKategori.Text = DataGridViewKategori.SelectedCells(1).Value

        TextBoxNamaKategori.Focus()


        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True

        ButtonSimpan.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

    Private Sub TextBoxNamaKategori_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNamaKategori.KeyPress
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