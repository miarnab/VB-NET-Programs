Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter your basic banking details: ")
        Console.WriteLine("Enter the account number: ")
        Dim AccountNumber = Convert.ToInt64(Console.ReadLine())
        Console.WriteLine("Enter the account holder's name: ")
        Dim AccountHoldersName = Console.ReadLine()
        Console.WriteLine("Enter the account type: ")
        Dim AccountType = Console.ReadLine()
        Console.WriteLine("The account number is: " & AccountNumber)
        Console.WriteLine("The account holders name is: " & AccountHoldersName)
        Console.WriteLine("The account type is: " & AccountType)
    End Sub
End Module
