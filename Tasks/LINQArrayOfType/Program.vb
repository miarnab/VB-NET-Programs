Imports System
Imports System.Linq
Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the number of elements: ")
        Dim n As Integer = Console.ReadLine()
        Dim array() As String = New String(n) {}
        Console.WriteLine("Enter the elements: ")
        For i = 0 To n - 1 Step 1
            array(i) = Console.ReadLine()
        Next
        Dim result = array.OfType(Of Integer)
        Console.WriteLine("Required Output: {0}", result)
    End Sub
End Module
