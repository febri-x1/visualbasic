Public Class Form5
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM", HorizontalAlignment.Right)
        ListView1.Columns.Add("NAMA", 115, HorizontalAlignment.Center)
        ListView1.Columns.Add("JURUSAN", 110, HorizontalAlignment.Left)
        txtnim.Text = 1
        txtnama.Focus()
    End Sub
    Private Sub btambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btambah.Click
        Dim Arr(2) As String
        Arr(0) = txtnim.Text
        Arr(1) = txtnama.Text
        Arr(2) = txtjurusan.Text()
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        txtnim.Text = txtnim.Text + 1
        txtnama.Text = ""
        txtjurusan.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bkeluar.Click
        Close()

    End Sub
End Class