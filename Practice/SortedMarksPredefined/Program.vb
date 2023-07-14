Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the number of marks you want to enter: ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim arr() As Integer = New Integer(n) {}
        Dim i As Integer
        Console.WriteLine("Enter the numbers in the array: ")
        For i = 0 To n - 1 Step 1
            arr(i) = Convert.ToInt32(Console.ReadLine())
        Next
        System.Array.Sort(arr)
        Console.WriteLine("The marks in sorted order is: ")
        For Each value As Integer In arr
            Console.WriteLine(value)
        Next
    End Sub
End Module
