Imports System
Imports System.IO
Module Program
    Sub Main(args As String())
        Dim filepath As String = "C:\{Path To Your File}\studentsports.txt"
        For i = 0 To 1 Step 1
            Console.WriteLine("Enter the Student's ID: ")
            Dim studentid As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the Student's Department: ")
            Dim studentdept As String = Console.ReadLine()
            Console.WriteLine("Enter the Student's sport: ")
            Dim studentsport As String = Console.ReadLine()
            Console.WriteLine("Enter the Student's Year: ")
            Dim studentyear As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the College Name: ")
            Dim collegename As String = Console.ReadLine()
            Using writer As New StreamWriter(filepath, True)
                writer.WriteLine("Student ID: {0}", studentid)
                writer.WriteLine("Student Department: {0}", studentdept)
                writer.WriteLine("Student Sport: {0}", studentsport)
                writer.WriteLine("Student Year: {0}", studentyear)
                writer.WriteLine("College Name: {0}", collegename)
            End Using
        Next
        Console.WriteLine("User input has been stored in the file")
        If File.Exists(filepath) Then
            Using reader As New StreamReader(filepath)
                Dim line As String
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    Console.WriteLine(line)
                End While
            End Using
        Else
            Console.WriteLine("File Not Found")
        End If
    End Sub
End Module
