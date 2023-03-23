<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(506, 145)
        Button1.Name = "Button1"
        Button1.RightToLeft = RightToLeft.Yes
        Button1.Size = New Size(149, 56)
        Button1.TabIndex = 0
        Button1.Text = "Green"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(121, 235)
        Button2.Name = "Button2"
        Button2.RightToLeft = RightToLeft.Yes
        Button2.Size = New Size(149, 56)
        Button2.TabIndex = 1
        Button2.Text = "Orange"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(308, 235)
        Button3.Name = "Button3"
        Button3.RightToLeft = RightToLeft.Yes
        Button3.Size = New Size(149, 56)
        Button3.TabIndex = 2
        Button3.Text = "Black"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(308, 145)
        Button4.Name = "Button4"
        Button4.RightToLeft = RightToLeft.Yes
        Button4.Size = New Size(149, 56)
        Button4.TabIndex = 3
        Button4.Text = "Red"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(121, 145)
        Button5.Name = "Button5"
        Button5.RightToLeft = RightToLeft.Yes
        Button5.Size = New Size(149, 56)
        Button5.TabIndex = 4
        Button5.Text = "Blue"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(506, 235)
        Button6.Name = "Button6"
        Button6.RightToLeft = RightToLeft.Yes
        Button6.Size = New Size(149, 56)
        Button6.TabIndex = 5
        Button6.Text = "Yellow"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
