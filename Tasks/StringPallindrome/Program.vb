Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the string/word/sentence: ")
        Dim s As String = Console.ReadLine()
        Dim s1 As String = ""
        Dim l As Integer = s.Length
        Dim i As Integer
        For i = l - 1 To 0 Step -1
            Dim c As Char = s(i)
            s1 = s1 + c
        Next
        If s = s1 Then
            Console.WriteLine("The string is Pallindrome")
        Else
            Console.WriteLine("The string is not Pallindrome")
        End If
    End Sub
End Module