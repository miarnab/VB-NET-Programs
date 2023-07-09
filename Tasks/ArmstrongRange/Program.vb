Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the desired range: ")
        Dim m = Convert.ToInt32(Console.ReadLine())
        Dim i, n As Integer
        Dim r As Integer
        Dim sum As Integer
        Dim c As Integer
        For i = 1 To m Step 1
            n = i
            sum = 0
            While n > 0
                r = n Mod 10
                sum = sum + (r * r * r)
                n = n \ 10
            End While
            If i = sum Then
                c += 1
                Console.WriteLine(c & " Armstrong Number is: " & i)
            End If
        Next
    End Sub
End Module
