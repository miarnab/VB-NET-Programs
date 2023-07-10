Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the email id: ")
        Dim s As String = Console.ReadLine()
        Dim l As Integer = s.Length
        Dim i As Integer
        Dim countalpha, countdigit, countspl As Integer
        For i = 0 To l - 1 Step 1
            Dim c As Char = s(i)
            If (c >= "A" And c <= "Z") Or (c >= "a" And c <= "z") Then
                countalpha += 1
            ElseIf c >= "0" And c <= "9" Then
                countdigit += 1
            Else
                countspl += 1
            End If
        Next
        Console.WriteLine("The total number of alphabets are: " & countalpha)
        Console.WriteLine("The total number of digits are: " & countdigit)
        Console.WriteLine("The total number of special characters: " & countspl)
    End Sub
End Module
