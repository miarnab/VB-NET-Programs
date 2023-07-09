Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the time in Hours:Minutes:Seconds")
        Dim hours = Convert.ToInt32(Console.ReadLine())
        Dim minutes = Convert.ToInt32(Console.ReadLine())
        Dim seconds = Convert.ToInt32(Console.ReadLine())
        Dim TimeInSeconds As Integer
        TimeInSeconds = hours * 60 * 60 + minutes * 60 + seconds
        Console.WriteLine("The time in seconds is: " & TimeInSeconds)
    End Sub
End Module
