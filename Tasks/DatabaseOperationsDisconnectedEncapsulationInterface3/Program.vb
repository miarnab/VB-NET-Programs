Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Interface College
    Sub DatabaseTableDelete()
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
    Public Sub New(ByVal studid As Integer)
        Me.StudentID = studid
    End Sub
    Public Sub DatabaseTableDelete() Implements College.DatabaseTableDelete
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
            Dim dt As DataTable = New DataTable
            dt = ds.Tables("student")
            dt.Rows.RemoveAt(StudentID)

            'Dim table As DataTable = ds.Tables("student")
            'Dim rowToDelete As DataRow = table.Select($"{studid}").FirstOrDefault
            'Dim sqlcmd As SqlCommandBuilder = New SqlCommandBuilder(adapter)
            'Dim dr As DataRow = ds.
            'dr(0) = studid
            'dr(1) = studname
            'dr(2) = dept
            'dr(3) = percent
            'dr(4) = y
            'dr(5) = cname
            'ds.Tables(0).Rows.Remove(rowToDelete)
            'adapter.Update(ds, ds.Tables(0).ToString)
            'table.Rows.Remove(rowToDelete)
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            Console.WriteLine("Values Inserted Successfully")
        End Try
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the student id to delete: ")
        Dim studid As Integer = Convert.ToInt32(Console.ReadLine())
        Dim ob As Student = New Student(studid)
        ob.DatabaseTableDelete()
    End Sub
End Module
