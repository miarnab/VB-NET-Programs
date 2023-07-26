Imports System
Imports System.Text.RegularExpressions

Module Program


    Function checkNull(str As String)
        If Len(str) = 0 Then
            Throw (New NullException("Input Should not be Null"))
        End If
    End Function

    Class NullException
        Inherits Exception
        Sub New(msg As String)
            MyBase.New(msg)
        End Sub
    End Class


    Function getNo()
        Dim id As Int64
        Console.Write("Enter No of Employees: ")
        Try
            id = Convert.ToInt32(Console.ReadLine())
            checkNull(Convert.ToString(id))
        Catch ex As FormatException
            Console.WriteLine("Input should be Integer Only")
            getNo()
        Catch ex As NullException
            Console.WriteLine("Input should not be Empty")
            getNo()
        End Try
        Return id
    End Function


    Function getId()
        Dim id As Int64
        Console.Write("Enter Employee ID: ")
        Try
            id = Convert.ToInt64(Console.ReadLine())
            checkNull(Convert.ToString(id))
            If id <= 0 Then
                Console.WriteLine("Id Should not be a negative or Zero")
                getId()
            End If
        Catch ex As FormatException
            Console.WriteLine("Id should only consits of Integer 0-9")
            getId()
        Catch ex As NullException
            Console.WriteLine("Id should not be Empty")
            getId()
        End Try


        Return id
    End Function


    Function getName()
        Dim name As String
        Console.Write("Enter Employee Name: ")
        Try
            name = Console.ReadLine()
            checkNull(name)
            Dim pattern As String = "^[a-zA-Z ]+$"
            If Not Regex.Match(name, pattern).Success Then
                Console.WriteLine("Name Should Only contains Alphabets")
                getName()
            End If
        Catch ex As NullException
            Console.WriteLine("Name should not be Empty")
            getName()
        End Try
        'Dim pattern As String = "^[A-Za-z ]$"
        'If Not Regex.Match(name, pattern).Success Then
        '    Console.WriteLine("Name Should Only contains Alphabets")
        '    getName()
        'End If
        Return name
    End Function

    Function getexp()
        Dim exp As Int64
        Console.Write("Enter Employee Experience: ")
        Try
            exp = Convert.ToInt64(Console.ReadLine())
            checkNull(Convert.ToString(exp))
            If exp < 0 Then
                Console.WriteLine("Experience should not be Negative")
                getexp()
            End If
        Catch ex As FormatException
            Console.WriteLine("Experience should only consits of Integer 0-9")
            getexp()
        Catch ex As NullException
            Console.WriteLine("Experience should not be Empty")
            getexp()
        End Try


        Return exp
    End Function


    Function getsalary()
        Dim sal As Int64
        Console.Write("Enter Employee salary: ")
        Try
            sal = Convert.ToDouble(Console.ReadLine())
            checkNull(Convert.ToString(sal))
            If sal <= 0 Then
                Console.WriteLine("Salary Must be grater Than 0")
                getsalary()
            End If
        Catch ex As FormatException
            Console.WriteLine("salary should only consits of Integer 0-9")
            getsalary()
        Catch ex As NullException
            Console.WriteLine("salary should not be Empty")
            getsalary()
        End Try

        Return sal
    End Function
    Class Employeedetails
        Private EmployeeID As Int64
        Private EmployeeName As String
        Private EmployeeSalary As Double
        Private EmployeeExperience As Int64
        Public Property empid As Int64
            Get
                Return EmployeeID
            End Get
            Set(value As Int64)
                EmployeeID = value
            End Set
        End Property
        Public Property empname As String
            Get
                Return EmployeeName
            End Get
            Set(value As String)
                EmployeeName = value
            End Set
        End Property
        Public Property empsalary As Double
            Get
                Return EmployeeSalary
            End Get
            Set(value As Double)
                EmployeeSalary = value
            End Set
        End Property

        Public Property empExp As Int64
            Get
                Return EmployeeExperience
            End Get
            Set(value As Int64)
                EmployeeExperience = value
            End Set
        End Property
    End Class

    Sub Main(args As String())
        Dim EmployeeList As List(Of Employeedetails) = New List(Of Employeedetails)
        Dim EmpNo = getNo()
        Dim empObj() As Employeedetails = New Employeedetails(EmpNo) {}
        For i = 0 To EmpNo - 1
            empObj(i) = New Employeedetails()
            empObj(i).empid = getId()
            empObj(i).empname = getName()
            empObj(i).empsalary = getsalary()
            empObj(i).empExp = getexp()
            EmployeeList.Add(empObj(i))
        Next


        For Each e As Employeedetails In EmployeeList
            If (e.empExp > 8) And (e.empsalary < 200000 And e.empsalary > 100000) Then
                Console.WriteLine("Employee Id: {0} , Employee Name: {1} , Employee Salary: {2} , Employee Experience: {3}", e.empid, e.empname, e.empsalary, e.empExp)
            End If
        Next
    End Sub
End Module
