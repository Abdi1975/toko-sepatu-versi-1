
Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormMasterMerk


    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblwarna As DataTable

    Sub Data_Record()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM merk")
        DataGridViewMerk.DataSource = tblwarna
        DataGridViewMerk.Columns(0).Width = 125
        DataGridViewMerk.Columns(1).Width = 180
    End Sub

    Sub Kode_Otomatis()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM merk order by kode_merk desc")

        If tblwarna.Rows.Count = 0 Then
            TextBoxIDMerk.Text = "MRK-001"
        Else
            With tblwarna.Rows(0)
                TextBoxIDMerk.Text = .Item("kode_merk")
            End With
            TextBoxIDMerk.Text = Val(Microsoft.VisualBasic.Mid(TextBoxIDMerk.Text, 5, 3)) + 1

            If Len(TextBoxIDMerk.Text) = 1 Then
                TextBoxIDMerk.Text = "MRK-00" & TextBoxIDMerk.Text & ""
            ElseIf Len(TextBoxIDMerk.Text) = 2 Then
                TextBoxIDMerk.Text = "MRK-0" & TextBoxIDMerk.Text & ""
            ElseIf Len(TextBoxIDMerk.Text) = 3 Then
                TextBoxIDMerk.Text = "MRK-" & TextBoxIDMerk.Text & ""
            End If
        End If
    End Sub

    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        ButtonSimpan.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxIDMerk.Enabled = False
        TextBoxMerk.Text = ""
        TextBoxMerk.Focus()
    End Sub

    Private Sub DataSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click

        If TextBoxMerk.Text = "" Then
            MsgBox("Nama Merk Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxMerk.Focus()
        Else

            If MsgBox("Apakah Anda Yakin Akan Menyimpan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                Try
                    SQL = "INSERT INTO merk VALUES ('" & TextBoxIDMerk.Text & "','" & TextBoxMerk.Text & "')"
                    Proses.ExecuteNonQuery(SQL)
                    MsgBox("Data Warna Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                    Call Atur()


                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try
            End If
        End If

    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        'If TxtMerk.Text = "" Then TxtMerk.Focus() : Exit Sub

        If TextBoxMerk.Text = "" Then

            MsgBox("Nama Satuan Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            TextBoxMerk.Focus() : Exit Sub
        End If

        If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                SQL = "UPDATE merk set nama_merk = '" & TextBoxMerk.Text & "' where kode_MERK ='" & TextBoxIDMerk.Text & "'"
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
                SQL = "DELETE FROM merk where kode_merk = '" & TextBoxIDMerk.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If


    End Sub
    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If TextBoxMerk.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub


    Private Sub DataGridViewMerk_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewMerk.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        TextBoxIDMerk.Text = DataGridViewMerk.SelectedCells(0).Value
        TextBoxMerk.Text = DataGridViewMerk.SelectedCells(1).Value

        TextBoxMerk.Focus()


        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True

        ButtonSimpan.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

    Private Sub TextBoxMerk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxMerk.KeyPress
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