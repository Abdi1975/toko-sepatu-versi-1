Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormMasterWarna

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblwarna As DataTable

    Sub Data_Record()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM warna")
        DataGridViewWarna.DataSource = tblwarna
        DataGridViewWarna.Columns(0).Width = 125
        DataGridViewWarna.Columns(1).Width = 180
    End Sub

    Sub Kode_Otomatis()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM warna order by kode_warna desc")

        If tblwarna.Rows.Count = 0 Then
            TextBoxIDWarna.Text = "WRN-001"
        Else
            With tblwarna.Rows(0)
                TextBoxIDWarna.Text = .Item("kode_warna")
            End With
            TextBoxIDWarna.Text = Val(Microsoft.VisualBasic.Mid(TextBoxIDWarna.Text, 5, 3)) + 1

            If Len(TextBoxIDWarna.Text) = 1 Then
                TextBoxIDWarna.Text = "WRN-00" & TextBoxIDWarna.Text & ""
            ElseIf Len(TextBoxIDWarna.Text) = 2 Then
                TextBoxIDWarna.Text = "WRN-0" & TextBoxIDWarna.Text & ""
            ElseIf Len(TextBoxIDWarna.Text) = 3 Then
                TextBoxIDWarna.Text = "WRN-" & TextBoxIDWarna.Text & ""
            End If
        End If
    End Sub

    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        ButtonSimpan.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxIDWarna.Enabled = False
        TextBoxWarna.Text = ""
        TextBoxWarna.Focus()
    End Sub

    Private Sub DataSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click

        If TextBoxWarna.Text = "" Then
            MsgBox("Nama Warna Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxWarna.Focus() : Exit Sub
        End If


        If MsgBox("Apakah Anda Yakin Akan Menyimpan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try

                SQL = "INSERT INTO warna VALUES ('" & TextBoxIDWarna.Text & "','" & TextBoxWarna.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Warna Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If

    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        'If TxtWarna.Text = "" Then TxtWarna.Focus() : Exit Sub
        If TextBoxWarna.Text = "" Then
            MsgBox("Nama Warna Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxWarna.Focus() : Exit Sub
        End If

        If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try
                SQL = "UPDATE warna set nama_warna = '" & TextBoxWarna.Text & "' where kode_warna ='" & TextBoxIDWarna.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil diperharui", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If

    End Sub


    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If MsgBox("Apakah Anda Yakin Akan Menghapus Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                SQL = "DELETE FROM warna where kode_warna = '" & TextBoxIDWarna.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If


    End Sub
    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If TextBoxWarna.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub


    Private Sub DataGridViewWarna_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewWarna.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        TextBoxIDWarna.Text = DataGridViewWarna.SelectedCells(0).Value
        TextBoxWarna.Text = DataGridViewWarna.SelectedCells(1).Value


        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True

        ButtonSimpan.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

    Private Sub TextBoxWarna_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxWarna.KeyPress
        'Koding Agar Tekan Enter Mau Pindah Ke Text Box Berikutnya

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