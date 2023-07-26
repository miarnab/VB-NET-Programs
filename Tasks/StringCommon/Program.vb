Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the first string: ")
        Dim a As String = Console.ReadLine().ToLower

        Console.WriteLine("Enter the second string: ")
        Dim b As String = Console.ReadLine().ToLower

        Dim s1 As String = ""
        Dim s2 As String = ""
        Dim k As Integer = a.Length
        Dim l As Integer = b.Length
        For i = 0 To k - 1 Step 1
            For j = 0 To l - 1 Step 1
                If a(i) = b(j) Then
                    s1 = a.Replace(a(i), "")
                    s2 = b.Replace(b(j), "")
                End If
            Next
        Next
        Dim m As Integer = s1.Length
        Dim n As Integer = s2.Length
        Console.WriteLine("Number of letters in first string: " & m)
        Console.WriteLine("Number of letters in second string: " & n)
    End Sub
End Module
