Imports System

Module Program
    Sub Main(args As String())
        Dim num, i, flag As Integer
        num = 2
        Console.WriteLine("Prime Numbers are:")
        While (num <= 100)
            flag = 0
            i = 1
            While (i <= num / 2)
                If (num Mod i = 0) Then
                    flag = flag + 1
                End If
                i = i + 1
            End While
            If (flag = 1) Then
                Console.WriteLine(num)
            End If
            num = num + 1
        End While
    End Sub
End Module
