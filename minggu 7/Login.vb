Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        Dim Koneksi As MySqlConnection
        Koneksi = New MySqlConnection("server=localhost;user id=root;password=;database=db_toko_sepatu")


        Koneksi.Open()

        Dim myadapter As New MySqlDataAdapter

        Dim sqlquery = "SELECT * FROM user where username='" + Trim(TextBoxUsername.Text) + "' And password='" + Trim(TextBoxPassword.Text) + "'"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = Koneksi
        mycommand.CommandText = sqlquery

        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()

        If mydata.HasRows = 0 Then
            MsgBox("Username atau Password Anda Salah! Hubungi Administrator", MsgBoxStyle.Exclamation, "Gagal Login")
            Call Kosong()
        Else
            userlogin = TextBoxUsername.Text
            Call Kosong()
            'Me.Hide()
            Home.ShowDialog()
            'FormLogin.Hide()
        End If
    End Sub

    ' Fungsi untuk mengosongkan input
    Private Sub Kosong()
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        TextBoxUsername.Focus()
    End Sub

    ' Event untuk pindah fokus dengan tombol Enter
    Private Sub TextBoxUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUsername.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBoxPassword.Focus()
        End If
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call ButtonLogin_Click(sender, e)
        End If
    End Sub

End Class
