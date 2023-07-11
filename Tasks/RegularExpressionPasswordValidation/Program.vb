Imports System
Imports System.Text.RegularExpressions

Module Program
    Function PasswordCheck(pass As String)
        Dim pattern As String = "^.*(?=.{8,15})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$"
        If Regex.Match(pass, pattern).Success Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub Main(args As String())
        Console.WriteLine("Enter the password: ")
        Dim password As String = Console.ReadLine()
        If PasswordCheck(password) = True Then
            Console.WriteLine("Password is valid")
        Else
            Console.WriteLine("Password is invalid")

        End If
    End Sub
End Module
