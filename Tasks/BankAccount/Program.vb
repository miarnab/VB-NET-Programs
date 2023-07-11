Imports System

Module Program
    Class BankAccount
        Dim AccountNumber As Integer
        Dim AccountType As String
        Dim AccountBalance As Double
        Sub New()
            AccountNumber = 0
            AccountType = ""
            AccountBalance = 0.00
        End Sub
        Sub getBankDetails()
            Console.WriteLine("Enter the Account Number: ")
            AccountNumber = Convert.ToInt64(Console.ReadLine())
            Console.WriteLine("Enter the Account Type: ")
            AccountType = Console.ReadLine()
            Console.WriteLine("Enter the Account Balance: ")
            AccountBalance = Convert.ToDouble(Console.ReadLine())
        End Sub
        Sub checkAccountBalance()
            If AccountBalance > 200000 Then
                Console.WriteLine("Eligible for silver credit card")
            ElseIf AccountBalance > 500000 Then
                Console.WriteLine("Eligible for golden credit card")
            ElseIf AccountBalance > 800000 Then
                Console.WriteLine("Eligible for platinum credit card")
            End If
        End Sub
        Sub display()
            Console.WriteLine("The Account Number is: " & AccountNumber)
            Console.WriteLine("The Account Type is: " & AccountType)
            Console.WriteLine("The Account Balance is: " & AccountBalance)
        End Sub
    End Class
    Sub Main(args As String())
        Dim ob As BankAccount = New BankAccount()
        ob.getBankDetails()
        ob.checkAccountBalance()
        ob.display()
    End Sub
End Module
