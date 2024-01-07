Public Class form4
    Private Sub bkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bkeluar.Click
        Close()
    End Sub
    Private Sub bproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bproses.Click
        Dim teks As String
        Dim jumlah As Integer
        teks = txtteks.Text
        jumlah = txtjumlah.Text
        For i = 1 To jumlah
            List1.Items.Add(teks)
        Next i
    End Sub
    Private Sub bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclear.Click
        txtteks.Text = ""
        txtjumlah.Text = ""
        List1.Items.Clear()
    End Sub
End Class