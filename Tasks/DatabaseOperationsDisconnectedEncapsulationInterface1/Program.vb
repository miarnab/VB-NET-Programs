Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Interface College
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
    Public Sub DatabaseTableInsertion() Implements College.DatabaseTableInsertion
        Try
            Dim conn As SqlConnection = New SqlConnection
            conn.ConnectionString = "Data Source=LAPTOP-M4RDUESN;Initial Catalog=SRFDatabase;Integrated Security=true"
            Dim cmd As New SqlCommand
            Dim adapter As New SqlDataAdapter
            Dim ds As New DataSet
            cmd.Connection = conn
            cmd.CommandText = "Select * From student"
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(ds)
            Dim sqlcmd As SqlCommandBuilder = New SqlCommandBuilder(adapter)
            Dim dr As DataRow = ds.Tables(0).NewRow
            dr(0) = studid
            dr(1) = studname
            dr(2) = dept
            dr(3) = percent
            dr(4) = y
            dr(5) = cname
            ds.Tables(0).Rows.Add(dr)
            adapter.Update(ds, ds.Tables(0).ToString)
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            Console.WriteLine("Values Inserted Successfully")
        End Try

    End Sub
End Class
Module Program
    Sub Main(args As String())
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
            Dim ob As Student = New Student(studentid, studentname, department, percentage, year, collegename)
            ob.DatabaseTableInsertion()
        Next
    End Sub
End Module
