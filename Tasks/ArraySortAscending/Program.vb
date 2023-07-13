Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the number of elements in the array: ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim arr() As Integer = New Integer(n) {}
        Dim i, j, temp As Integer
        Console.WriteLine("Enter the elements in the array: ")
        For i = 0 To n - 1 Step 1
            arr(i) = Convert.ToInt32(Console.ReadLine())
        Next
        For i = 0 To n - 1 Step 1

            For j = 0 To (n - i - 1) - 1 Step 1
                If arr(j) > arr(j + 1) Then
                    temp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                End If
            Next
        Next
        Console.WriteLine("The sorted array is: ")
        For i = 0 To n - 1 Step 1
            Console.WriteLine(arr(i))
        Next
    End Sub
End Module
