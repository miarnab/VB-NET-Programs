Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the two angles of the triangle: ")
        Dim a = Convert.ToDouble(Console.ReadLine())
        Dim b = Convert.ToDouble(Console.ReadLine())
        Dim c As Double
        c = 180 - (a + b)
        Console.WriteLine("The third angle of the triangle is: " & c)
    End Sub
End Module
