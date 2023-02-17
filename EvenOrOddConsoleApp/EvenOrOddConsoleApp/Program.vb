Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer
        Console.WriteLine("Enter a Number:")
        num = Console.ReadLine()
        If num Mod 2 = 0 Then
            Console.WriteLine("The number is even")
        Else
            Console.WriteLine("The number is odd")
        End If
    End Sub
End Module