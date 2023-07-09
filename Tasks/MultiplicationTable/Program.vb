Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the number: ")
        Dim n = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the range: ")
        Dim r = Convert.ToInt32(Console.ReadLine())
        Dim p As Integer
        For i = 1 To r Step 1
            p = n * i
            Console.WriteLine(n & " x " & i & " = " & p)
        Next
    End Sub
End Module
