Imports System
Imports System.Data.SqlClient

Module Program
    Sub Main(args As String())
        Dim conn As SqlConnection = New SqlConnection
        conn.ConnectionString = "Data Source=LAPTOP-M4RDUESN;Initial Catalog=SRFDatabase;Integrated Security=true"
        Try
            conn.Open()
            Dim query1 As String = "Create Table student(studentid int NOT NULL Primary Key, studentname varchar(100), dept varchar(100), percentage float, year int, collegename varchar(100))"
            Dim cmd1 As SqlCommand = New SqlCommand(query1, conn)
            Console.WriteLine("Enter the number of datas to be inputed: ")
            Dim n As Integer = Convert.ToInt32(Console.ReadLine())
            cmd1.ExecuteNonQuery()
            For i = 0 To n - 1 Step 1
                Console.WriteLine("Enter the Student ID: ")
                Dim studentid As Integer = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine("Enter the Student Name: ")
                Dim studentname As String = Console.ReadLine()
                Console.WriteLine("Enter the Department: ")
                Dim dept As String = Console.ReadLine()
                Console.WriteLine("Enter the Percentage: ")
                Dim percentage As Double = Convert.ToDouble(Console.ReadLine())
                Console.WriteLine("Enter the Year: ")
                Dim year As Integer = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine("Enter the College Name: ")
                Dim collegename As String = Console.ReadLine()
                Dim query2 As String = "Insert Into student Values(" & studentid & ",'" & studentname & "','" & dept & "'," & percentage & "," & year & ",'" & collegename & "')"
                Dim cmd2 As SqlCommand = New SqlCommand(query2, conn)
                cmd2.ExecuteNonQuery()
            Next
            Console.WriteLine("Table Created Successfully")
            Console.WriteLine("Values Inserted Successfully")
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            conn.Close()
        End Try
    End Sub
End Module
