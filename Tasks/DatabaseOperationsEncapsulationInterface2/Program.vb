Imports System
Imports System.Data.SqlClient

Public Interface College
    Sub DatabaseTableRead()
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
    Public Sub DatabaseTableRead() Implements College.DatabaseTableRead
        Dim query As String = "Select * From student"
        Dim conn As SqlConnection = New SqlConnection
        conn.ConnectionString = "Data Source=LAPTOP-M4RDUESN;Initial Catalog=SRFDatabase;Integrated Security=true"
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Console.WriteLine("Student ID: {0}, Student Name: {1}, Department: {2}, Percentage: {3}, Year: {4}, College name: {5}", reader("studentid"), reader("studentname"), reader("dept"), reader("percentage"), reader("year"), reader("collegename"))
            End While
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
Module Program
    Sub Main(args As String())
        Dim ob As Student = New Student()
        ob.DatabaseTableRead()
    End Sub
End Module
