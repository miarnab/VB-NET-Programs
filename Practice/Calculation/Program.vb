Imports System

Module Program
    Sub Main(args As String())
        For i = 0 To 1 Step 0
            Console.WriteLine("Do you want to perform another calculation? ")
            Dim query As String = Console.ReadLine()
            If query = "Y" Then
                Console.WriteLine("1. Addition")
                Console.WriteLine("2. Subtraction")
                Console.WriteLine("3. Multiplication")
                Console.WriteLine("4. Division")
                Console.WriteLine("Enter the user's choice: ")
                Dim ch As Integer = Convert.ToInt32(Console.ReadLine())
                Select Case ch
                    Case 1
                        Console.WriteLine("Enter the two numbers for addition: ")
                        Dim a As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim b As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim sum As Integer = 0
                        sum = a + b
                        Console.WriteLine("Addition of the two numbers is: " & sum)
                    Case 2
                        Console.WriteLine("Enter the two numbers for subtraction: ")
                        Dim a As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim b As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim diff As Integer = 0
                        If a > b Then
                            diff = a - b
                        Else
                            diff = b - a
                        End If
                        Console.WriteLine("Subtraction of the two numbers is: " & diff)
                    Case 3
                        Console.WriteLine("Enter the two numbers for multiplication: ")
                        Dim a As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim b As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim prod As Integer = 1
                        prod = a * b
                        Console.WriteLine("Multiplication of the two numbers is: " & prod)
                    Case 4
                        Console.WriteLine("Enter the two numbers for division: ")
                        Dim a As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim b As Integer = Convert.ToInt32(Console.ReadLine())
                        Dim q As Integer = 1
                        Dim r As Integer = 1
                        If a > b Then
                            q = a \ b
                            r = a Mod b
                        Else
                            q = b \ a
                            r = b Mod a
                        End If
                        Console.WriteLine("Quotient of the two numbers is: " & q)
                        Console.WriteLine("Remainder of the two numbers is: " & r)
                    Case Else
                        Console.WriteLine("Enter a valid choice!")
                End Select
            Else
                Exit For
            End If
        Next

    End Sub
End Module
