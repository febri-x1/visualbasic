Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim arr(4, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "NAMA"
        arr(1, 0) = "JENIS KELAMIN"
        arr(1, 1) = "PRODI"
        arr(2, 0) = "LAKI-LAKI"
        arr(2, 1) = "PEREMPUAN"
        arr(3, 0) = "Sistem Informasi"
        arr(3, 1) = "Teknologi Informasi"
        arr(4, 0) = "Rekayasa Perangkat Lunak"
        arr(4, 1) = "Sistem Informasi Akutansi"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next kolom
        Next baris
        For baris = 2 To 2
            For kolom = 0 To 1
                cbJKelamin.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
        For baris = 3 To 3
            For kolom = 0 To 1
                cbjurusan.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
        For baris = 4 To 4
            For kolom = 0 To 1
                cbjurusan.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
    End Sub
    Private Sub bproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bproses.Click
        Dim arr(4) As String
        arr(0) = txtnim.Text
        arr(1) = txtnama.Text
        arr(2) = cbJKelamin.Text
        arr(3) = cbjurusan.Text()
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        listitem.SubItems.Add(arr(2))
        listitem.SubItems.Add(arr(3))
        txtnim.Text = txtnim.Text + 1
        txtnama.Text = ""
        cbJKelamin.Text = ""
        cbjurusan.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class