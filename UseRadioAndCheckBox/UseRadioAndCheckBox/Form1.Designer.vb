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
        CheckBox1 = New CheckBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(320, 100)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(105, 25)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.Location = New Point(12, 10)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(107, 25)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "Light Mode"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.Location = New Point(12, 41)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(105, 25)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "Dark Mode"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(320, 131)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(105, 25)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "CheckBox2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox3.Location = New Point(320, 162)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(105, 25)
        CheckBox3.TabIndex = 4
        CheckBox3.Text = "CheckBox3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox4.Location = New Point(320, 193)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(105, 25)
        CheckBox4.TabIndex = 5
        CheckBox4.Text = "CheckBox4"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(CheckBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
End Class
