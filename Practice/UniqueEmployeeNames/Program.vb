Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the number of employees: ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim arr() As String = New String(n) {}
        Dim arr1() As String = New String(n) {}
        Dim i As Integer
        Dim flag = 0
        Console.WriteLine("Enter the employee names in the array: ")
        For i = 0 To n - 1 Step 1
            arr(i) = Console.ReadLine()
        Next
        For i = 0 To n - 1 Step 1
            flag = 0
            For j = i + 1 To n - 1 Step 1
                If i <> j Then
                    If arr(i) = arr(j) Then
                        'arr(i) = arr(i + 1)
                        'i -= 1
                        flag = 1
                    End If

                End If

            Next
            If flag = 0 Then
                arr1(i) = arr(i)
            End If
        Next
        For i = 0 To n - 1 Step 1
            Console.WriteLine(arr1(i))
        Next
    End Sub
End Module
