Public Class Form1
    Dim n1, n2, addition, subtraction, division, multiplication As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n1 = InputBox("Enter the First Number:")
        n2 = InputBox("Enter the Second Number:")
        addition = Val(n1) + Val(n2)
        MsgBox("Addition = " & addition)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n1 = InputBox("Enter the First Number:")
        n2 = InputBox("Enter the Second Number:")
        subtraction = Val(n1) - Val(n2)
        MsgBox("Subtraction = " & subtraction)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        n1 = InputBox("Enter the First Number:")
        n2 = InputBox("Enter the Second Number:")
        multiplication = Val(n1) * Val(n2)
        MsgBox("Multiplication = " & multiplication)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        n1 = InputBox("Enter the First Number:")
        n2 = InputBox("Enter the Second Number:")
        division = Val(n1) / Val(n2)
        MsgBox("Division = " & division)
    End Sub

End Class
