﻿Public Class Form11

    Dim data() As Integer = {95, 70, 75, 88, 90, 74, 83}
    Function BubbleSort(ByRef data As Integer())
        For i = 1 To (data.Length - 1)
            For j = 0 To ((data.Length - 1) - i)
                If data(j) > data(j + 1) Then
                    data(j) = data(j) Xor data(j + 1)
                    data(j + 1) = data(j + 1) Xor data(j)
                    data(j) = data(j) Xor data(j + 1)
                End If
            Next
        Next
        Return data
    End Function
    Private Sub FormSort2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Console.WriteLine("Data sebelum diurutkan")
        For i = 0 To (data.Length - 1)
            Console.WriteLine(data(i))
        Next
        Console.WriteLine("=======================")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dataUrut = BubbleSort(data)
        Console.WriteLine("Data setelah diurutkan")
        For i = 0 To (dataUrut.Length - 1)
            Console.WriteLine(dataUrut(i))
        Next
    End Sub

    Function SelectionSort1(ByRef data As Integer())
        Dim min As Integer
        For i As Integer = 0 To data.Length - 2
            min = i
            For j As Integer = i + 1 To data.Length - 1
                If data(j) < data(min) Then
                    min = j
                End If
            Next
            Dim temp As Integer = data(min)
            data(min) = data(i)
            data(i) = temp
        Next
        Return data
    End Function

    Private Sub SelectionSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectionSort.Click
        Dim dataUrut = BubbleSort(data)
        Console.WriteLine("Data setelah diurutkan")
        For i = 0 To (dataUrut.Length - 1)
            Console.WriteLine(dataUrut(i))
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class
