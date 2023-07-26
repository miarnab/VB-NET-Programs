Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Console.WriteLine("1. Create Bill")
        Console.WriteLine("2. View Bill")
        Console.WriteLine("Enter the user's choice: ")
        Dim choice As Integer = Convert.ToInt32(Console.ReadLine())
        Select Case choice
            Case 1
                Dim d As Date = Date.Now
                Dim year As Integer = d.Year
                Dim month As Integer = d.Month
                Dim day As Integer = d.Day
                Dim parent As String = "C:\{Path To Your Folder}\HospitalBilling"
                Dim directoryPath As String = Path.Combine(parent, year, month, day)


            Case 2


        End Select


    End Sub
End Module
