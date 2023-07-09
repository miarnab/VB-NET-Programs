Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter a four digit number: ")
        Dim n = Convert.ToInt32(Console.ReadLine())
        Dim r, sum As Integer
        r = 0
        sum = 0
        While n > 0 Or sum > 9
            If n = 0 Then
                n = sum
                sum = 0
            End If
            r = n Mod 10
            sum = sum + r
            n = n \ 10
        End While
        Console.WriteLine(sum)
    End Sub
End Module
