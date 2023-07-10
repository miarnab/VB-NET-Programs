Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the string: ")
        Dim s As String = Console.ReadLine()
        Dim l As Integer = s.Length
        Dim s1 As String = ""
        Dim s2 As String = ""
        For i = 0 To l - 1 Step 1
            Dim c As Char = s(i)
            If c >= "0" And c <= "9" Then
                s1 = s1 + c
            ElseIf

            End If
        Next
    End Sub
End Module
