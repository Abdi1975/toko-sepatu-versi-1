Public Class FormMasterSize

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim ukuran As DataTable


    Sub Baca_Data()
        ukuran = Proses.ExecuteQuery("SELECT * FROM size")
        DataGridViewUkuran.DataSource = ukuran
        DataGridViewUkuran.Columns(0).Width = 152
        DataGridViewUkuran.Columns(1).Width = 151
    End Sub


    Sub Kode_Ukuran_Auto()
        ukuran = Proses.ExecuteQuery("SELECT * FROM size order by kode_size desc")

        If ukuran.Rows.Count = 0 Then
            TextBoxKodeSize.Text = "SZ-001"
        Else
            With ukuran.Rows(0)
                TextBoxKodeSize.Text = .Item("kode_size")
            End With
            TextBoxKodeSize.Text = Val(Microsoft.VisualBasic.Mid(TextBoxKodeSize.Text, 5, 3)) + 1

            If Len(TextBoxKodeSize.Text) = 1 Then
                TextBoxKodeSize.Text = "SZ-00" & TextBoxKodeSize.Text & ""
            ElseIf Len(TextBoxKodeSize.Text) = 2 Then
                TextBoxKodeSize.Text = "SZ-0" & TextBoxKodeSize.Text & ""
            ElseIf Len(TextBoxKodeSize.Text) = 3 Then
                TextBoxKodeSize.Text = "SZ-" & TextBoxKodeSize.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        Call Baca_Data()
        Call Kode_Ukuran_Auto()

        ButtonSimpan.Enabled = True
        ButtonUbah.Enabled = False
        ButtonHapus.Enabled = False
        TextBoxKodeSize.Enabled = False
        TextBoxSize.Text = ""
        TextBoxSize.Focus()

    End Sub

    Private Sub FormMasterSize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call Baca_Data()

        Call Atur()

    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If TextBoxSize.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If
    End Sub


    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If MsgBox("Apakah Anda Yakin Akan Menghapus Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            SQL = "DELETE FROM size where kode_size = '" & TextBoxKodeSize.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data berhasil dihapus", MsgBoxStyle.OkOnly, "Sukses")
            Call Atur()
        End If

    End Sub


    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        'If txtUkuran.Text = "" Then txtUkuran.Focus() : Exit Sub
        If TextBoxSize.Text = "" Then
            TextBoxSize.Focus() : Exit Sub
            MsgBox("Nama Ukuran Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
        End If


        If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try

                SQL = "UPDATE size set nama_size = '" & TextBoxSize.Text & "' where kode_size ='" & TextBoxKodeSize.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil diperharui", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If


    End Sub


    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        'If txtUkuran.Text = "" Then txtUkuran.Focus() : Exit Sub
        If TextBoxSize.Text = "" Then MsgBox("Nama Ukuran Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
        TextBoxSize.Focus() : Exit Sub

        If MsgBox("Apakah Anda Yakin Akan Menambah Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                SQL = "INSERT INTO size VALUES ('" & TextBoxKodeSize.Text & "','" & TextBoxSize.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If

    End Sub

    Private Sub DataGridViewUkuran_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewUkuran.DoubleClick
        'Select Case Me.Text()
        '    Case "Data Ukuran"
        TextBoxKodeSize.Text = DataGridViewUkuran.SelectedCells(0).Value
        TextBoxSize.Text = DataGridViewUkuran.SelectedCells(1).Value

        TextBoxSize.Focus()

        ButtonUbah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonSimpan.Enabled = False
        '    Case "Data Ukuran Sepatu"
        ''FormMasterBarang.CmbUkuran.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select
    End Sub

    Private Sub TextBoxSize_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSize.KeyPress

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