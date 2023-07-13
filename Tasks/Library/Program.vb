Imports System

Module Program
    Class Library
        Dim BookCode() As Integer = New Integer() {}
        Dim BookName() As String = New String() {}
        Dim Author() As String = New String() {}
        Dim DateofPurchase As String
        Dim StockinHand As Integer
        Dim CardHoldersName As String
        Sub New()
            BookCode = {0}
            BookName = {""}
            Author = {""}
            DateofPurchase = ""
            StockinHand = 0
            CardHoldersName = ""
        End Sub
        Sub getBookInfo()

            Dim i As Integer
            For i = 0 To 1 Step 0
                Console.WriteLine("Do you want to enter Book Details? ")
                Dim query As String = Console.ReadLine()
                If query = "Y" Then
                    Console.WriteLine("Enter the Book Code: ")
                    BookCode(i) = Convert.ToInt64(Console.ReadLine())
                    Console.WriteLine("Enter the Book Name: ")
                    BookName(i) = Console.ReadLine()
                    Console.WriteLine("Enter the Author Name: ")
                    Author(i) = Console.ReadLine()
                Else
                    Exit For
                End If
            Next
            Console.WriteLine("Enter the Date of Purchase: ")
            DateofPurchase = Convert.ToDateTime(Console.ReadLine())
            Console.WriteLine("Enter the Stock in Hand: ")
            StockinHand = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the Card Holder's Name: ")
            CardHoldersName = Console.ReadLine()
        End Sub
        Sub printBookInfo()
            For i = 0 To BookCode.Length - 1 And BookName.Length - 1 And Author.Length - 1 Step 1
                Console.WriteLine("Book Code: {0} , Book Name: {1} , Author: {2}", BookCode(i), BookName(i), Author(i))
            Next
        End Sub
    End Class
    Sub Main(args As String())
        Dim ob As Library = New Library()
        ob.getBookInfo()
        ob.printBookInfo()
    End Sub
End Module
