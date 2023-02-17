Imports System

Module Program
    Sub Main(args As String())
        Dim num1, num2, num3 As Integer
        Console.WriteLine("Enter First Number:")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter Second Number:")
        num2 = Console.ReadLine()
        Console.WriteLine("Enter Third Number:")
        num3 = Console.ReadLine()
        If num1 > num2 Then
            If num1 > num3 Then
                Console.WriteLine("First Number is the greatest")
            Else
                Console.WriteLine("Third Number is the greatest")
            End If
        Else
            If num2 > num3 Then
                Console.WriteLine("Second Number is the greatest")
            Else
                Console.WriteLine("Third Number is the greatest")
            End If
        End If
    End Sub
End Module
