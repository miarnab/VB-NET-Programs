Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter your Phone Number: ")
        Dim n As Long = Convert.ToInt64(Console.ReadLine())
        Dim p, q As Integer
        While n > 0
            p = n Mod 10
            q = n \ 10
        End While
        Console.WriteLine(p)
        Console.WriteLine(q)
    End Sub
End Module
