Imports System
Imports System.IO
Imports System.Threading
Imports System.Transactions

Module Program
    Sub Main(args As String())
        For i = 0 To 9 Step 1
            Console.WriteLine("Enter the Student ID: ")
            Dim studentid As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the Student Name: ")
            Dim studentname As String = Console.ReadLine()
            Console.WriteLine("Enter the Student Department: ")
            Dim studentdept As String = Console.ReadLine()
            Console.WriteLine("Enter the Student Percentage: ")
            Dim studentpercent As Double = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter the Student Year: ")
            Dim studentyear As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the College Name: ")
            Dim collegename As String = Console.ReadLine()
            Dim filepath As String = "C:\{Path To Your File}\student.txt"
            Using writer As New StreamWriter(filepath, True)
                writer.WriteLine("Student ID: {0}", studentid)
                writer.WriteLine("Student Name: {0}", studentname)
                writer.WriteLine("Student Department: {0}", studentdept)
                writer.WriteLine("Student Percentage: {0}", studentpercent)
                writer.WriteLine("Student Year: {0}", studentyear)
            End Using
        Next
        Console.WriteLine("User input has been stored in the file")
    End Sub
End Module
