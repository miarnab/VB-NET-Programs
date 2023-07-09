Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the radius of the circle: ")
        Dim r = Convert.ToDouble(Console.ReadLine())
        Dim area As Double
        Dim circumference As Double
        area = 3.14 * r * r
        circumference = 2 * 3.14 * r
        Console.WriteLine("The area of the circle is: " & area)
        Console.WriteLine("The circumference of the circle is: " & circumference)
    End Sub
End Module
