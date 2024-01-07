Public Class Form7

    Sub Bersih()
        TxtKodeBrg.Text = ""
        TxtNamaBrg.Text = ""
        TxtSatuan.Text = ""
        TxtHrgSatuan.Text = ""
        TxtJumlah.Text = ""
        TxtTotalHarga.Text = ""
        TxtKodeBrg.Focus()
        TxtTotalHarga.Enabled = False
    End Sub
    Private Function Hitung()
        Dim Harga, Jumlah, Total As Integer
        Harga = TxtHrgSatuan.Text
        Jumlah = TxtJumlah.Text
        Total = Harga * Jumlah
        TxtTotalHarga.Text = Total
        Return Total
    End Function

    Sub cekDataKosong()
        If TxtKodeBrg.Text = "" Then
            MessageBox.Show("Kode Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtKodeBrg.Focus()
        ElseIf TxtNamaBrg.Text = "" Then
            MessageBox.Show("Nama Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNamaBrg.Focus()
        ElseIf TxtSatuan.Text = "" Then
            MessageBox.Show("Satuan Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSatuan.Focus()
        ElseIf TxtHrgSatuan.Text = "" Then
            MessageBox.Show("Harga Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtHrgSatuan.Focus()
        ElseIf TxtJumlah.Text = "" Then
            MessageBox.Show("Jumlah Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtJumlah.Focus()
        Else
            Call Hitung()

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bersih()

    End Sub

    Private Sub BtnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Call Bersih()

    End Sub
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bersih()

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Call Bersih()

    End Sub

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Call cekDataKosong()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Close()

    End Sub
End Class