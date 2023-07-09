Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the number: ")
        Dim n = Convert.ToInt32(Console.ReadLine())
        Dim f As Integer
        f = 1
        Dim i As Integer
        For i = 1 To n Step 1
            f = f * i
        Next
        Console.WriteLine("The factorial of the given number is: " & f)
    End Sub
End Module
