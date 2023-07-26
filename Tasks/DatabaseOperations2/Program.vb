Imports System
Imports System.Data.SqlClient
Module Program
    Sub Main(args As String())
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
End Module
