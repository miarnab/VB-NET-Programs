Imports System

Module Program
    Class Train
        Dim TrainNumber As Integer
        Dim TrainName As String
        Dim TrainFare As Double
        Dim PassengerNumber As Integer
        Dim PassengerName() As String = New String(PassengerNumber) {}
        Dim PassengerAge() As Integer = New Integer(PassengerNumber) {}
        Sub New()
            TrainNumber = 0
            TrainName = ""
            TrainFare = 0.00
            PassengerNumber = 0
            PassengerName = {""}
            PassengerAge = {0}
        End Sub
        Sub getTrainDetails()
            Console.WriteLine("Enter the Train Number: ")
            TrainNumber = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the Train Name: ")
            TrainName = Console.ReadLine()
            Console.WriteLine("Enter the Train Fare: ")
            TrainFare = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter the Passenger Number: ")
            PassengerNumber = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the Passenger Name and Age: ")
            For i = 0 To PassengerNumber - 1
                PassengerName(i) = Console.ReadLine()
                PassengerAge(i) = Convert.ToInt32(Console.ReadLine())
            Next
        End Sub
        Sub printTrainDetails()
            Dim fare As Double = 0.00
            Dim netfare As Double = 0.00
            For i = 0 To PassengerNumber - 1 Step 1
                If PassengerNumber > 1 Then
                    If PassengerAge(i) > 60 Then
                        fare = TrainFare * 0.75
                    ElseIf PassengerAge(i) < 18 Then
                        fare = TrainFare * 0.5
                    Else
                        fare = TrainFare
                    End If
                Else
                    fare = TrainFare
                End If
                netfare = netfare + fare
            Next
            Console.WriteLine("The Train Number is: " & TrainNumber)
            Console.WriteLine("The Train Name is: " & TrainName)
            Console.WriteLine("The Train Fare is: " & TrainFare)
            For i = 0 To PassengerNumber - 1 Step 1
                Console.WriteLine("The Passenger Name is: " & PassengerName(i))
            Next
            Console.WriteLine("The Net Fare for all the Passengers: " & netfare)
        End Sub
    End Class
    Sub Main(args As String())
        Dim ob As Train = New Train()
        ob.getTrainDetails()
        ob.printTrainDetails()
    End Sub
End Module
