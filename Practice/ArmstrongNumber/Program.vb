Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the number: ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim r, sum, n1 As Integer
        r = 0
        sum = 0
        n1 = n
        While n1 > 0
            r = n1 Mod 10
            sum = sum + (r * r * r)
            n1 = n1 \ 10
        End While
        If sum = n Then
            Console.WriteLine("Armstrong Number")
        Else
            Console.WriteLine("Not an Armstrong Number")
        End If
    End Sub
End Module
