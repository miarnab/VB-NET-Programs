Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the population of the city: ")
        Dim p = Convert.ToInt64(Console.ReadLine())
        Dim result As Integer
        result = p * 0.57 * (1 - 0.79)
        Console.WriteLine("The iliterate male population of the city is: " & result)
    End Sub
End Module
