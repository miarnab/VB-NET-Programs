Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the three sides of the triangle: ")
        Dim a = Convert.ToDouble(Console.ReadLine())
        Dim b = Convert.ToDouble(Console.ReadLine())
        Dim c = Convert.ToDouble(Console.ReadLine())
        Dim s As Double
        s = (a + b + c) / 2
        Dim area As Double
        area = Math.Sqrt(s * (s - a) * (s - b) * (s - c))
        Console.WriteLine("The area of the triangle is: " & area)
    End Sub
End Module
