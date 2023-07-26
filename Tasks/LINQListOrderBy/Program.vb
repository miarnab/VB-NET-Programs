Imports System
Imports System.Linq
Module Program
    Sub Main(args As String())
        Dim employee As New List(Of Tuple(Of Integer, String))
        employee.Add(New Tuple(Of Integer, String)(1001, "Arnab"))
        employee.Add(New Tuple(Of Integer, String)(1002, "Prasanth"))
        employee.Add(New Tuple(Of Integer, String)(1003, "Deepak"))
        employee.Add(New Tuple(Of Integer, String)(1004, "Sathish"))
        employee.Add(New Tuple(Of Integer, String)(1005, "Parthivan"))
        Dim result = From emp In employee
                     Order By emp.Item1 Descending
        For Each item In result
            Console.WriteLine(item.Item1 & "  " + item.Item2)
        Next
    End Sub
End Module
