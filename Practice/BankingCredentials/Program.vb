Imports System

Module Program
    Sub Main(args As String())
        Dim username As String = "user@1234"
        Dim password As String = "pass@1234"
        Console.WriteLine("Enter your name: ")
        Dim Name = Console.ReadLine()

        Console.WriteLine("Enter the username: ")
        Dim user = Console.ReadLine()
        Console.WriteLine("Enter the password: ")
        Dim pass = Console.ReadLine()
        If username = user And password = pass Then
            Console.WriteLine("Welcome! " & Name)

        Else
            Console.WriteLine("Please enter valid details!")
        End If
    End Sub
End Module
