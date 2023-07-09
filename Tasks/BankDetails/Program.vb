Imports System

Module Program
    Class Bank
        Dim AccountNo As Integer
        Dim Name As String
        Dim OpeningDate As String
        Dim AmountDeposited As Double
        Dim AccountType As String
        Sub New()
            AccountNo = 0
            Name = ""
            OpeningDate = ""
            AmountDeposited = 0.00
            AccountType = ""
        End Sub
        Sub getAccountDetails()
            Console.WriteLine("Enter the Account Number: ")
            AccountNo = Convert.ToInt64(Console.ReadLine())
            Console.WriteLine("Enter the Account Holder's Name: ")
            Name = Console.ReadLine()
            Console.WriteLine("Enter the Account Opening Date: ")
            OpeningDate = Convert.ToDateTime(Console.ReadLine())
            Console.WriteLine("Enter the Account Type: ")
            AccountType = Console.ReadLine()
        End Sub
        Sub printAccountDetails()
            Console.WriteLine("The Account Number is: " & AccountNo)
            Console.WriteLine("The Account Holder's Name is:  " & Name)
            Console.WriteLine("The Account Opening Date is: " & OpeningDate)
            Console.WriteLine("The Account Type is: " & AccountType)
        End Sub
        Sub dotransaction()
            Dim balance As Integer
            Dim query As String
            For i = 0 To 1 Step 0
                Console.WriteLine("Do you want to deposit in your account? ")
                query = Console.ReadLine()
                If query = "Y" Then
                    Console.WriteLine("Enter the Amount to be Deposited: ")
                    AmountDeposited = Convert.ToDouble(Console.ReadLine())
                    balance = balance + AmountDeposited
                Else
                    Exit For
                End If
            Next
            Console.WriteLine("The net balance in your account is: " & balance)
        End Sub
    End Class
    Sub Main(args As String())
        Dim ob As Bank = New Bank()
        ob.getAccountDetails()
        ob.printAccountDetails()
        ob.dotransaction()
    End Sub
End Module
