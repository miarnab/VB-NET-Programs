Imports System
Imports System.IO

Module Program
    Sub Main(args As String())

        Dim filePath1 As String = "C:\{Path To Your File\student.txt"
        Dim filePath2 As String = "C:\{Path To Your File}\studentsports.txt"
        Dim filepath3 As String = "C:\{Path To Your File}\differencefile.txt"

        Dim file1Lines() As String = File.ReadAllLines(filePath1)


        Dim file2Lines() As String = File.ReadAllLines(filePath2)


        Dim lineIndex As Integer = 0
        Dim differencesFound As Boolean = False

        Using writer As New StreamWriter(filepath3, True)
            While lineIndex < file1Lines.Length AndAlso lineIndex < file2Lines.Length
                If file1Lines(lineIndex) <> file2Lines(lineIndex) Then
                    writer.WriteLine("Difference found at line {0}:", lineIndex + 1)
                    writer.WriteLine("File1: {0}", file1Lines(lineIndex))
                    writer.WriteLine("File2: {0}", file2Lines(lineIndex))
                    writer.WriteLine()
                    differencesFound = True
                End If

                lineIndex += 1
            End While


            If lineIndex < file1Lines.Length Then
                writer.WriteLine("Additional lines found in File1:")
                For i As Integer = lineIndex To file1Lines.Length - 1
                    writer.WriteLine(file1Lines(i))
                Next
                writer.WriteLine()
                differencesFound = True
            ElseIf lineIndex < file2Lines.Length Then
                writer.WriteLine("Additional lines found in File2:")
                For i As Integer = lineIndex To file2Lines.Length - 1
                    writer.WriteLine(file2Lines(i))
                Next
                writer.WriteLine()
                differencesFound = True
            End If


            If Not differencesFound Then
                writer.WriteLine("No differences found.")
            End If
        End Using

    End Sub
End Module
