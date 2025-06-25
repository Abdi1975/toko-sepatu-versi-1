Module Module1
    Public userlogin As String
    Public waktu As DateTime



End Module


Public Module Functions
    Public Sub singleqoute()
        Dim ctrl As Control
        Dim txt As TextBox

        For Each ctrl In Sepatu_shop.FormMasterMerk.Controls()
            If TypeOf ctrl Is TextBox Then
                txt = CType(ctrl, TextBox)
                txt.Text = txt.Text.Replace("'", "''")
            End If
        Next
        For Each ctrl In Home.Controls
            If TypeOf ctrl Is TextBox Then
                txt = CType(ctrl, TextBox)
                txt.Text = Replace(txt.Text, "'", "''")
            End If
        Next
        For Each ctrl In FormMasterBarang.Controls
            If TypeOf ctrl Is TextBox Then
                txt = CType(ctrl, TextBox)
                txt.Text = Replace(txt.Text, "'", "''")
            End If
        Next

    End Sub

End Module