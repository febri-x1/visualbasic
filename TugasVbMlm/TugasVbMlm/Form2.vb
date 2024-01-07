Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        'Input Harga dan Jumlah
        harga = txtharga.Text
        jumlah = txtjumlah.Text
        'Perhitungan Total Harga
        total = harga * jumlah
        'Penentuan diskon
        diskon = 0.05 * total
        'Perhitungan total Bayar
        bayar = total - diskon
        'Set keluaran total Harga, diskon,total bayar, dan bonus
        txttotal.Text = total
        txtdiskon.Text = diskon
        txtbayar.Text = bayar
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles Keluar.Click
        Close()
    End Sub
    Private Sub Ulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles Ulang.Click
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""
        txtdiskon.Text = ""
        txtbayar.Text = ""
        txtnama.Focus()
    End Sub
End Class