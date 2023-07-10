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
            Dim balance, i As Integer
            For i = 0 To 1 Step 0
                Console.WriteLine("Do you want to do a transaction? ")
                Dim query As String = Console.ReadLine()
                If query = "Y" Then
                    Console.WriteLine("1. Deposit")
                    Console.WriteLine("2. Withdrawl")
                    Console.WriteLine("Enter the user's choice: ")
                    Dim choice As Integer = Convert.ToInt32(Console.ReadLine())
                    Select Case choice
                        Case 1
                            Console.WriteLine("Enter the amount to deposit: ")
                            Dim deposit As Integer = Convert.ToInt64(Console.ReadLine())
                            balance = balance + deposit
                        Case 2
                            Console.WriteLine("Enter the amount to withdraw: ")
                            Dim withdraw As Integer = Convert.ToInt64(Console.ReadLine())
                            balance = balance - withdraw
                        Case Else
                            Console.WriteLine("Not a valid choice")
                    End Select
                Else
                    Exit For
                End If
            Next
            Console.WriteLine("The account balance is: " & balance)
        End Sub
    End Class
    Sub Main(args As String())
        Dim ob As Bank = New Bank()
        ob.getAccountDetails()
        ob.printAccountDetails()
        ob.dotransaction()
    End Sub
End Module
