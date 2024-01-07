Public Class Form3
    Private Sub Ulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""
        txtdiscon.Text = ""
        txtbayar.Text = ""
        txtbonus.Text = ""
        txtnama.Focus()
    End Sub
    Private Sub Hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hitung.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus As String
        'Deklarasi Input Harga dan Jumlah
        harga = txtharga.Text
        jumlah = txtjumlah.Text
        'Perhitungan Total Harga
        total = harga * jumlah
        'Penentuan Discon dan Bonus
        If total >= 500000 Then
            diskon = 0.2 * total
            bonus = "Tas Ransel"
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Payung"
        ElseIf total >= 100000 Then
            diskon = 0.1 * total
            bonus = "Kaos polo"
        ElseIf total >= 50000 Then
            diskon = 0.05 * total
            bonus = "Pena"
        Else
            diskon = 0
            bonus = "Tidak Ada"
        End If
        'Perhitungan total Bayar


        bayar = total - diskon
        'Deklarasi keluaran total Harga, diskon,total bayar, dan bonus
        txttotal.Text = total
        txtdiscon.Text = diskon
        txtbayar.Text = bayar
        txtbonus.Text = bonus
    End Sub
    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        Close()

    End Sub
End Class