Imports System

Module Program
    Public MustInherit Class Student
        Public MustOverride Sub TakeExam()
    End Class
    Public Class PHDStudent
        Inherits Student
        Public Overrides Sub TakeExam()
            Console.WriteLine("PHD student gives exam by giving final presentation")
        End Sub
    End Class
    Public Class GRADStudent
        Inherits Student
        Public Overrides Sub TakeExam()
            Console.WriteLine("GRAD student gives exam by giving written test")
        End Sub
    End Class
    Sub Main(args As String())
        Dim phd As New PHDStudent()
        Dim grad As New GRADStudent()
        phd.TakeExam()
        grad.TakeExam()
    End Sub
End Module
