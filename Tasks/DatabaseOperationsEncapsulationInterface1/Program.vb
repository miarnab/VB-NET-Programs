Imports System
Imports System.Data.SqlClient

Public Interface College
    Sub DatabaseTableCreation()
    Sub DatabaseTableInsertion()
End Interface
Public Class Student
    Implements College
    Private studid As Integer
    Private studname As String
    Private dept As String
    Private percent As Double
    Private y As Integer
    Private cname As String
    Public Property StudentID As Integer
        Get
            Return studid
        End Get
        Set(value As Integer)
            studid = value
        End Set
    End Property
    Public Property StudentName As String
        Get
            Return studname
        End Get
        Set(value As String)
            studname = value
        End Set
    End Property
    Public Property Department As String
        Get
            Return dept
        End Get
        Set(value As String)
            dept = value
        End Set
    End Property
    Public Property Percentage As Double
        Get
            Return percent
        End Get
        Set(value As Double)
            percent = value
        End Set
    End Property
    Public Property Year As Integer
        Get
            Return y
        End Get
        Set(value As Integer)
            y = value
        End Set
    End Property
    Public Property CollegeName As String
        Get
            Return cname
        End Get
        Set(value As String)
            cname = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal studid As Integer, ByVal studname As String, ByVal dept As String, ByVal percent As Double, ByVal y As Integer, ByVal cname As String)
        Me.StudentID = studid
        Me.StudentName = studname
        Me.Department = dept
        Me.Percentage = percent
        Me.Year = y
        Me.CollegeName = cname
    End Sub
    Public Sub DatabaseTableCreation() Implements College.DatabaseTableCreation
        Dim conn As SqlConnection = New SqlConnection
        conn.ConnectionString = "Data Source=LAPTOP-M4RDUESN;Initial Catalog=SRFDatabase;Integrated Security=true"
        Try
            conn.Open()
            Dim query1 As String = "Create Table student(studentid int NOT NULL Primary Key, studentname varchar(100), dept varchar(100), percentage float, year int, collegename varchar(100))"
            Dim cmd1 As SqlCommand = New SqlCommand(query1, conn)
            cmd1.ExecuteNonQuery()

            Console.WriteLine("Table Created Successfully")

        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub DatabaseTableInsertion() Implements College.DatabaseTableInsertion
        Dim conn As SqlConnection = New SqlConnection
        conn.ConnectionString = "Data Source=LAPTOP-M4RDUESN;Initial Catalog=SRFDatabase;Integrated Security=true"
        Try
            conn.Open()
            Dim query2 As String = "Insert Into student Values(" & studid & ",'" & studname & "','" & dept & "'," & percent & "," & y & ",'" & cname & "')"
            Dim cmd2 As SqlCommand = New SqlCommand(query2, conn)
            cmd2.ExecuteNonQuery()
            Console.WriteLine("Values Inserted Successfully")
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
Module Program
    Sub Main(args As String())
        Dim ob2 As Student = New Student()
        ob2.DatabaseTableCreation()
        Console.WriteLine("Enter the number of values: ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim studentid As Integer
        Dim studentname As String
        Dim department As String
        Dim percentage As String
        Dim year As String
        Dim collegename As String
        For i = 0 To n - 1 Step 1
            Console.WriteLine("Enter the Student ID: ")
            studentid = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the Student Name: ")
            studentname = Console.ReadLine()
            Console.WriteLine("Enter the Department: ")
            department = Console.ReadLine()
            Console.WriteLine("Enter the Percentage: ")
            percentage = Convert.ToDouble(Console.ReadLine())
            Console.WriteLine("Enter the Year: ")
            year = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Enter the College Name: ")
            collegename = Console.ReadLine()
            Dim ob1 As Student = New Student(studentid, studentname, department, percentage, year, collegename)

            ob1.DatabaseTableInsertion()
        Next

    End Sub
End Module
