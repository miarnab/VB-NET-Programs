Imports System

Module Program
    Class Employee
        Dim EmployeeID As Integer
        Dim Name As String
        Dim Designation As String
        Dim OfficeLocation As String
        Dim City As String
        Sub New()
            EmployeeID = 0
            Name = ""
            Designation = ""
            OfficeLocation = ""
            City = ""
        End Sub
        Sub getEmployeeInfo()
            Console.WriteLine("Enter the Employee ID: ")
            EmployeeID = Convert.ToInt64(Console.ReadLine())
            Console.WriteLine("Enter the Employee's Name: ")
            Name = Console.ReadLine()
            Console.WriteLine("Enter the Employee's Designation: ")
            Designation = Console.ReadLine()
            Console.WriteLine("Enter the Office Location: ")
            OfficeLocation = Console.ReadLine()
            Console.WriteLine("Enter the Office City: ")
            City = Console.ReadLine()
        End Sub
        Sub showEmployeeInfo()
            Console.WriteLine("The Employee ID is: " & EmployeeID)
            Console.WriteLine("The Employee's Name is: " & Name)
            Console.WriteLine("The Employee's Designation is: " & Designation)
            Console.WriteLine("The Office Location is: " & OfficeLocation)
            Console.WriteLine("The Office City is: " & City)
        End Sub
    End Class
    Sub Main(args As String())
        Dim ob As Employee = New Employee()
        ob.getEmployeeInfo()
        ob.showEmployeeInfo()
    End Sub
End Module
