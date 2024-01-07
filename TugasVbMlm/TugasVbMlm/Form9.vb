Public Class Form9
    Function factorial(ByVal n As Integer) As Integer
        If n = 0 Then
            factorial = 1
        Else
            factorial = n * factorial(n - 1)
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Integer.Parse(TextBox1.Text)
        Label2.Text = factorial(n).ToString()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class