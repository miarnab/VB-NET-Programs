Imports System
Imports System.Net.WebRequestMethods

Module Program
    Class Vehicle
        Dim mileage As Double
        Dim price As Double
        Public Sub New(ByVal m As Double, ByVal p As Double)
            mileage = m
            price = p
        End Sub
        Public Sub display()
            Console.WriteLine("The mileage of the vehicle is: " & mileage)
            Console.WriteLine("The price of the vehicle is: " & price)
        End Sub
    End Class
    Class Car
        Inherits Vehicle
        Dim OwnershipCost As Double
        Dim Warranty As Integer
        Dim SeatingCapacity As Integer
        Dim FuelType As String
        Public Sub New(ByVal m As Double, ByVal p As Double, ByVal oc As Double, ByVal w As Integer, ByVal sc As Integer, ByVal ft As String)
            MyBase.New(m, p)
            OwnershipCost = oc
            Warranty = w
            SeatingCapacity = sc
            FuelType = ft
        End Sub
        Public Sub display()
            MyBase.display()
            Console.WriteLine("The ownership cost of the car: " & OwnershipCost)
            Console.WriteLine("The warranty of the car: " & Warranty)
            Console.WriteLine("The seating capacity of the car: " & SeatingCapacity)
            Console.WriteLine("The fuel type of the car: " & FuelType)
        End Sub
    End Class
    Class Bike
        Inherits Vehicle
        Dim CylinderNumber As Integer
        Dim GearsNumber As Integer
        Dim CoolingType As String
        Dim WheelType As String
        Dim FuelTankSize As Double
        Public Sub New(ByVal m As Double, ByVal p As Double, ByVal cn As Integer, ByVal gn As Integer, ByVal ct As String, ByVal wt As String, ByVal fts As Double)
            MyBase.New(m, p)
            CylinderNumber = cn
            GearsNumber = gn
            CoolingType = ct
            WheelType = wt
            FuelTankSize = fts
        End Sub
        Public Sub display()
            MyBase.display()
            Console.WriteLine("The number of cylinders of the bike is: " & CylinderNumber)
            Console.WriteLine("The number of gears of the bike is: " & GearsNumber)
            Console.WriteLine("The cooling type of the bike is: " & CoolingType)
            Console.WriteLine("The wheel typw of the bike is: " & WheelType)
            Console.WriteLine("The fuel tank size of the bike is: " & FuelTankSize)
        End Sub
    End Class
    Class Audi
        Inherits Car
        Dim ModelType As String
        Public Sub New(ByVal m As Double, ByVal p As Double, ByVal oc As Double, ByVal w As Integer, ByVal sc As Integer, ByVal ft As String, ByVal mt As String)
            MyBase.New(m, p, oc, w, sc, ft)
            ModelType = mt
        End Sub
        Sub display()
            MyBase.display()
            Console.WriteLine("The model type of the Audi is: " & ModelType)
        End Sub
    End Class
    Class Ford
        Inherits Car
        Dim ModelType As String
        Public Sub New(ByVal m As Double, ByVal p As Double, ByVal oc As Double, ByVal w As Integer, ByVal sc As Integer, ByVal ft As String, ByVal mt As String)
            MyBase.New(m, p, oc, w, sc, ft)
            ModelType = mt
        End Sub
        Sub display()
            MyBase.display()
            Console.WriteLine("The model type of the Ford is: " & ModelType)
        End Sub
    End Class
    Class Bajaj
        Inherits Bike
        Dim MakeType As String
        Public Sub New(ByVal m As Double, ByVal p As Double, ByVal cn As Integer, ByVal gn As Integer, ByVal ct As String, ByVal wt As String, ByVal fts As Double, ByVal mt As String)
            MyBase.New(m, p, cn, gn, ct, wt, fts)
            MakeType = mt
        End Sub
        Sub display()
            MyBase.display()
            Console.WriteLine("The make type of the Bajaj is: " & MakeType)
        End Sub
    End Class
    Class TVS
        Inherits Bike
        Dim MakeType As String
        Public Sub New(ByVal m As Double, ByVal p As Double, ByVal cn As Integer, ByVal gn As Integer, ByVal ct As String, ByVal wt As String, ByVal fts As Double, ByVal mt As String)
            MyBase.New(m, p, cn, gn, ct, wt, fts)
            MakeType = mt
        End Sub
        Sub display()
            MyBase.display()
            Console.WriteLine("The make type of the Bajaj is: " & MakeType)
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Enter the mileage of the Car: ")
        Dim m As Double = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Enter the price of the Car: ")
        Dim p As Double = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Enter the ownership cost of the car: ")
        Dim oc As Double = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Enter the warranty of the car: ")
        Dim w As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the seating capacity of the car: ")
        Dim sc As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the fuel type of the car: ")
        Dim ft As String = Console.ReadLine()
        Console.WriteLine("Enter the model type of Audi/Ford: ")
        Dim mdt As String = Console.ReadLine()
        Console.WriteLine("Enter the number of cylinders of the bike: ")
        Dim cn As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the number of gears of the bike: ")
        Dim gn As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the cooling type of the bike: ")
        Dim ct As String = Console.ReadLine()
        Console.WriteLine("Enter the wheel type of the bike is: ")
        Dim wt As String = Console.ReadLine()
        Console.WriteLine("Enter the fuel tank size of the bike: ")
        Dim fts As Double = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("Enter the make type of Bajaj/TVS: ")
        Dim mkt As String = Console.ReadLine()
        Dim ob1 As Audi = New Audi(m, p, oc, w, sc, ft, mdt)
        Dim ob2 As Ford = New Ford(m, p, oc, w, sc, ft, mdt)
        Dim ob3 As Bajaj = New Bajaj(m, p, cn, gn, ct, wt, fts, mkt)
        Dim ob4 As TVS = New TVS(m, p, cn, gn, ct, wt, fts, mkt)
        ob1.display()
        ob2.display()
        ob3.display()
        ob4.display()
    End Sub
End Module
