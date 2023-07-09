Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the first number: ")
        Dim a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the second number: ")
        Dim b = Convert.ToInt32(Console.ReadLine())
        Dim sum = a + b
        Console.WriteLine("The sum of the two numbers is: " & sum)
    End Sub
End Module
