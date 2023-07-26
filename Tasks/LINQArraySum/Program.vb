Imports System
Imports System.Linq
Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the number of elements: ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim percent() As Integer = New Integer(n) {}
        Console.WriteLine("Enter the elements: ")
        For i = 0 To n - 1 Step 1
            percent(i) = Convert.ToInt32(Console.ReadLine())
        Next
        Dim result = percent.Sum()
        Console.WriteLine("Required Output: {0}", result)
    End Sub
End Module
