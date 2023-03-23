Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn As New Button
        btn.Text = "New Button"
        btn.Location = New Point(20, 150)
        Me.Controls.Add(btn)
    End Sub
End Class
