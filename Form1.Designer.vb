<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.QuizTextBox = New System.Windows.Forms.TextBox()
        Me.AssignmentTextBox = New System.Windows.Forms.TextBox()
        Me.RecitationTextBox = New System.Windows.Forms.TextBox()
        Me.ExamTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RemarksLabel = New System.Windows.Forms.Label()
        Me.AverageLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quiz:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Assigment:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Recitation:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Exam:"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 411)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(141, 27)
        Me.CalculateButton.TabIndex = 6
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'QuizTextBox
        '
        Me.QuizTextBox.Location = New System.Drawing.Point(131, 69)
        Me.QuizTextBox.Name = "QuizTextBox"
        Me.QuizTextBox.Size = New System.Drawing.Size(176, 20)
        Me.QuizTextBox.TabIndex = 8
        '
        'AssignmentTextBox
        '
        Me.AssignmentTextBox.Location = New System.Drawing.Point(131, 95)
        Me.AssignmentTextBox.Name = "AssignmentTextBox"
        Me.AssignmentTextBox.Size = New System.Drawing.Size(176, 20)
        Me.AssignmentTextBox.TabIndex = 9
        '
        'RecitationTextBox
        '
        Me.RecitationTextBox.Location = New System.Drawing.Point(131, 122)
        Me.RecitationTextBox.Name = "RecitationTextBox"
        Me.RecitationTextBox.Size = New System.Drawing.Size(176, 20)
        Me.RecitationTextBox.TabIndex = 10
        '
        'ExamTextBox
        '
        Me.ExamTextBox.Location = New System.Drawing.Point(131, 148)
        Me.ExamTextBox.Name = "ExamTextBox"
        Me.ExamTextBox.Size = New System.Drawing.Size(176, 20)
        Me.ExamTextBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 27)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Average:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Remarks:"
        '
        'RemarksLabel
        '
        Me.RemarksLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarksLabel.Location = New System.Drawing.Point(127, 276)
        Me.RemarksLabel.Name = "RemarksLabel"
        Me.RemarksLabel.Size = New System.Drawing.Size(68, 17)
        Me.RemarksLabel.TabIndex = 15
        Me.RemarksLabel.Text = "???"
        '
        'AverageLabel
        '
        Me.AverageLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageLabel.Location = New System.Drawing.Point(127, 249)
        Me.AverageLabel.Name = "AverageLabel"
        Me.AverageLabel.Size = New System.Drawing.Size(68, 27)
        Me.AverageLabel.TabIndex = 14
        Me.AverageLabel.Text = "0.00"
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(159, 411)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(148, 27)
        Me.ResetButton.TabIndex = 16
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 450)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.RemarksLabel)
        Me.Controls.Add(Me.AverageLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ExamTextBox)
        Me.Controls.Add(Me.RecitationTextBox)
        Me.Controls.Add(Me.AssignmentTextBox)
        Me.Controls.Add(Me.QuizTextBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents QuizTextBox As TextBox
    Friend WithEvents AssignmentTextBox As TextBox
    Friend WithEvents RecitationTextBox As TextBox
    Friend WithEvents ExamTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RemarksLabel As Label
    Friend WithEvents AverageLabel As Label
    Friend WithEvents ResetButton As Button
End Class
