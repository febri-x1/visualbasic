Public Class Form12

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles BtnAddtoList.Click
        If Trim(TextBox1.Text) <> "" Then
            ListBox1.Items.Add(TextBox1.Text)
        End If
    End Sub
    Private Sub BtnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles BtnMove.Click
        If ListBox1.SelectedIndex >= 0 Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub
    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If ListBox1.SelectedIndex >= 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MsgBox("Silakan pilih terlebih dulu")
        End If
    End Sub
    Private Sub BtnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMoveAll.Click
        For i = 0 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items(0))
            ListBox1.Items.RemoveAt(0)
        Next
    End Sub
    Private Sub BtnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles BtnUp.Click
        Dim currentIndex As Integer
        Dim tempValue As String
        currentIndex = ListBox1.SelectedIndex
        If ListBox1.SelectedIndex >= 0 Then
            If currentIndex >= 1 Then
                tempValue = ListBox1.Items(currentIndex)
                ListBox1.Items(currentIndex) = ListBox1.Items(currentIndex - 1)
                ListBox1.Items(currentIndex - 1) = tempValue
                ListBox1.SelectedIndex = currentIndex - 1
            End If
        Else
            MsgBox("Silakan pilih terlebih dulu")
        End If
    End Sub
    Private Sub BtnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles BtnDown.Click
        Dim currentIndex As Integer
        Dim tempValue As String
        currentIndex = ListBox1.SelectedIndex
        If ListBox1.SelectedIndex >= 0 Then
            If currentIndex < ListBox1.Items.Count - 1 Then
                tempValue = ListBox1.Items(currentIndex)
                ListBox1.Items(currentIndex) = ListBox1.Items(currentIndex + 1)
                ListBox1.Items(currentIndex + 1) = tempValue
                ListBox1.SelectedIndex = currentIndex + 1
            End If
        Else
            MsgBox("Silakan pilih terlebih dulu")
        End If
    End Sub
    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Close()

    End Sub
End Class