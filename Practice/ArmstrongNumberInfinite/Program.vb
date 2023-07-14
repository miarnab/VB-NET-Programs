Imports System

Module Program
    Sub Main(args As String())
        For i = 0 To 1 Step 0
            Console.WriteLine("Enter the user's query: ")
            Dim query As String = Console.ReadLine()
            If query = "Y" Then
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
            Else
                Exit For
            End If
        Next
    End Sub
End Module
