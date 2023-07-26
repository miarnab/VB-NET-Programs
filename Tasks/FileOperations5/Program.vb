Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim filePath1 As String = "C:\{Path To Your File}\studentsports.txt"
        Dim filePath2 As String = "C:\{Path To Your File}\removedstudentsports.txt"

        Console.WriteLine("Enter the ID to remove: ")
        Dim idToRemove As String = Console.ReadLine()


        Dim lines() As String = File.ReadAllLines(filePath1)


        Dim updatedLines As New List(Of String)()


        For Each line As String In lines

            If line.StartsWith(idToRemove) Then

                Continue For
            End If


            updatedLines.Add(line)
        Next


        File.WriteAllLines(filePath2, updatedLines)

        Console.WriteLine("Data removed from the file.")
    End Sub
End Module
