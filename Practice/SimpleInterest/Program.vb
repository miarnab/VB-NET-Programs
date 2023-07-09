Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the Principle: ")
        Dim p = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Enter the time period: ")
        Dim t = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Enter the rate of interest: ")
        Dim r = Convert.ToDouble(Console.ReadLine())
        Dim si As Double
        si = (p * r * t) / 100
        Console.WriteLine("The Simple Interest is: " & si)
    End Sub
End Module
