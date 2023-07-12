Imports System

Module Program
    Class BankAccountParameterized
        Dim AccountNumber As Integer
        Dim AccountType As String
        Dim AccountBalance As Double
        Sub New()
            AccountNumber = 0
            AccountType = ""
            AccountBalance = 0.00
        End Sub
        Sub New(ByVal an As Integer, ByVal at As String, ByVal ab As Double)
            AccountNumber = an
            AccountType = at
            AccountBalance = ab
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
        Console.WriteLine("Enter the Account Number: ")
        Dim an As Integer = Convert.ToInt64(Console.ReadLine())
        Console.WriteLine("Enter the Account Type: ")
        Dim at As String = Console.ReadLine()
        Console.WriteLine("Enter the Account Balance: ")
        Dim ab = Convert.ToDouble(Console.ReadLine())
        Dim ob As BankAccountParameterized = New BankAccountParameterized(an, at, ab)
        ob.checkAccountBalance()
        ob.display()
    End Sub
End Module
