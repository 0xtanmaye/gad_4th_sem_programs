Imports System.Xml

Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.BackColor = Color.White
        CheckBox1.ForeColor = Color.Black
        CheckBox2.ForeColor = Color.Black
        CheckBox3.ForeColor = Color.Black
        CheckBox4.ForeColor = Color.Black
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.BackColor = Color.Black
        CheckBox1.ForeColor = Color.White
        CheckBox2.ForeColor = Color.White
        CheckBox3.ForeColor = Color.White
        CheckBox4.ForeColor = Color.White
    End Sub
End Class
