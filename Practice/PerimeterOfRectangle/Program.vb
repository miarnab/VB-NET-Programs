Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the height/length of the rectangle: ")
        Dim length = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Enter the breadth/width of the rectangle: ")
        Dim breadth = Convert.ToDouble(Console.ReadLine())
        Dim perimeter As Double
        perimeter = 2 * (length + breadth)
        Console.WriteLine("The perimeter of the rectangle is: " & perimeter)
    End Sub
End Module
