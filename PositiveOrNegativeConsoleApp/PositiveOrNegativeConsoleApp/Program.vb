Imports System
Imports System.Globalization

Module Program
    Sub Main(args As String())
        Dim num As Integer
        Console.WriteLine("Enter a Number:")
        num = Console.ReadLine()
        If num < 0 Then
            Console.WriteLine("The number is negative")
        Else
            Console.WriteLine("The number is positive")
        End If
    End Sub
End Module
