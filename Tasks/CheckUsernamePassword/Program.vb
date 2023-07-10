Imports System

Module Program
    Sub Main(args As String())
        Dim username As String = "user1234"
        Dim password As String = "pass1234"
        Dim i As Integer
        For i = 0 To 1 Step 0
            Console.WriteLine("Enter the username: ")
            Dim user = Console.ReadLine()
            Console.WriteLine("Enter the password: ")
            Dim pass = Console.ReadLine()
            If username = user And password = pass Then
                Console.WriteLine("Username and Password are correct.")
                Exit For
            End If
        Next
    End Sub
End Module
