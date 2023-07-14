Imports System

Module Program
    Sub Main(args As String())

        Dim i As Integer
        Dim cp, cn, cz As Integer
        For i = 0 To 1 Step 0
            Console.WriteLine("Enter the user's query: ")
            Dim query As String = Console.ReadLine()
            If query = "Y" Then
                Console.WriteLine("Enter the number: ")
                Dim n As Integer = Convert.ToInt32(Console.ReadLine())
                If n > 0 Then
                    cp += 1
                ElseIf n = 0 Then
                    cz += 1
                Else
                    cn += 1
                End If
            Else
                Exit For
            End If

        Next
        Console.WriteLine("Count of Positive Numbers: " & cp)
        Console.WriteLine("Count of Negative Numbers: " & cn)
        Console.WriteLine("Count of Zeros: " & cz)
    End Sub
End Module
