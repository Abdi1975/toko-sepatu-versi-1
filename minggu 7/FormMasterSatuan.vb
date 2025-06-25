Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormMasterSatuan

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblsatuan As DataTable


    Sub Data_Record()
        tblsatuan = Proses.ExecuteQuery("SELECT * FROM satuan")
        DataGridViewSatuan.DataSource = tblsatuan
        DataGridViewSatuan.Columns(0).Width = 125
        DataGridViewSatuan.Columns(1).Width = 180
    End Sub


    Sub Kode_Otomatis()
        tblsatuan = Proses.ExecuteQuery("SELECT * FROM satuan order by kode_satuan desc")

        If tblsatuan.Rows.Count = 0 Then
            TextBoxKodeSatuan.Text = "STN-001"
        Else
            With tblsatuan.Rows(0)
                TextBoxKodeSatuan.Text = .Item("kode_satuan")
            End With
            TextBoxKodeSatuan.Text = Val(Microsoft.VisualBasic.Mid(TextBoxKodeSatuan.Text, 5, 3)) + 1

            If Len(TextBoxKodeSatuan.Text) = 1 Then
                TextBoxKodeSatuan.Text = "STN-00" & TextBoxKodeSatuan.Text & ""
            ElseIf Len(TextBoxKodeSatuan.Text) = 2 Then
                TextBoxKodeSatuan.Text = "STN-0" & TextBoxKodeSatuan.Text & ""
            ElseIf Len(TextBoxKodeSatuan.Text) = 3 Then
                TextBoxKodeSatuan.Text = "STN-" & TextBoxKodeSatuan.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        ButtonSimpan.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxKodeSatuan.Enabled = False
        TextBoxNamaSatuan.Text = ""
        TextBoxNamaSatuan.Focus()
    End Sub



    Private Sub FormMasterSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()

    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        If TextBoxNamaSatuan.Text = "" Then
            MsgBox("Nama Satuan Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxNamaSatuan.Focus() : Exit Sub
        End If

        If MsgBox("Apakah Anda Yakin Akan Menyimpan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try

                SQL = "INSERT INTO satuan VALUES ('" & TextBoxKodeSatuan.Text & "','" & TextBoxNamaSatuan.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Satuan Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If

    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        If TextBoxNamaSatuan.Text = "" Then
            MsgBox("Nama Satuan Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxNamaSatuan.Focus() : Exit Sub

        End If


        If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                SQL = "UPDATE satuan set keterangan = '" & TextBoxNamaSatuan.Text & "' where kode_satuan ='" & TextBoxKodeSatuan.Text & "'"
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

                SQL = "DELETE FROM satuan where kode_satuan = '" & TextBoxKodeSatuan.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try

        End If

    End Sub
    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If TextBoxNamaSatuan.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub DataGridViewSatuan_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewSatuan.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        TextBoxKodeSatuan.Text = DataGridViewSatuan.SelectedCells(0).Value
        TextBoxNamaSatuan.Text = DataGridViewSatuan.SelectedCells(1).Value

        TextBoxNamaSatuan.Focus()


        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True

        ButtonSimpan.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

    Private Sub TextBoxNamaSatuan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNamaSatuan.KeyPress
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