Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the temperature in Celcius: ")
        Dim celcius = Convert.ToDouble(Console.ReadLine())
        Dim fahrenheit As Double
        fahrenheit = ((9 / 5) * celcius) + 32
        Console.WriteLine("The temperature in Fahrenheit is: " & fahrenheit)
    End Sub
End Module
