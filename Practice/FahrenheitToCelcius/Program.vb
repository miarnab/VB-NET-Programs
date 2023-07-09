Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the temperature in Fahrenheit: ")
        Dim fahrenheit = Convert.ToDouble(Console.ReadLine())
        Dim celcius As Double
        celcius = (5 * (fahrenheit - 32)) / 9
        Console.WriteLine("The temperature in Celcius is: " & celcius)
    End Sub
End Module
