Public Class Form1

    Private Sub btntampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntampilkan.Click
        MessageBox.Show(TextBox1.Text & vbCrLf & TextBox2.Text & vbCrLf & ComboBox1.Text & vbCrLf & ComboBox2.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKeluar.Click
        Close()
    End Sub
End Class