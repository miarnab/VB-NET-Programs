Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the range for fibonacci series: ")
        Dim r = Convert.ToInt32(Console.ReadLine())
        Dim a, b, c As Integer
        a = 0
        b = 1
        Dim i As Integer
        Console.WriteLine("The fibonacci series is: ")
        Console.Write(a & " " & b)
        For i = 0 To r Step 1
            c = a + b
            a = b
            b = c
            Console.Write(" " & c)
        Next
    End Sub
End Module
