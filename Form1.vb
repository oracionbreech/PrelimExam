Public Class Form1

    Dim QuizEntry As Integer
    Dim AssignmentEntry As Integer
    Dim RecitationEntry As Integer
    Dim ExamEntry As Integer

    Private Sub CalculateButton_MouseClick(sender As Object, e As MouseEventArgs) Handles CalculateButton.MouseClick



        Dim QuizEntryOK As Boolean = Integer.TryParse(QuizTextBox.Text, QuizEntry)
        Dim AssignmentEntryOK As Boolean = Integer.TryParse(AssignmentTextBox.Text, AssignmentEntry)
        Dim RecitationEntryOK As Boolean = Integer.TryParse(RecitationTextBox.Text, RecitationEntry)
        Dim ExamEntryOK As Boolean = Integer.TryParse(ExamTextBox.Text, ExamEntry)


        If QuizEntryOK = False Then
            QuizTextBox.BackColor = Color.Red
            QuizTextBox.ForeColor = Color.White
        Else
            QuizTextBox.BackColor = Color.White
            QuizTextBox.ForeColor = Color.Black
        End If

        If AssignmentEntryOK = False Then
            AssignmentTextBox.BackColor = Color.Red
            AssignmentTextBox.ForeColor = Color.White
        Else
            AssignmentTextBox.BackColor = Color.White
            AssignmentTextBox.ForeColor = Color.Black
        End If

        If RecitationEntryOK = False Then
            RecitationTextBox.BackColor = Color.Red
            RecitationTextBox.ForeColor = Color.White
        Else
            RecitationTextBox.BackColor = Color.White
            RecitationTextBox.ForeColor = Color.Black
        End If

        If ExamEntryOK = False Then
            ExamTextBox.BackColor = Color.Red
            ExamTextBox.ForeColor = Color.White
        Else
            ExamTextBox.BackColor = Color.White
            ExamTextBox.ForeColor = Color.Black
        End If

        If QuizEntryOK = False Or AssignmentEntryOK = False Or RecitationEntryOK = False Or ExamEntryOK = False Then


            MessageBox.Show("Please Fix the Error's in Red. Only numbers are allowed")

        Else
            Dim Quiz As Double = ConvertToTwenty(QuizEntry, 20.0)
            Dim Assignment As Double = ConvertToTwenty(AssignmentEntry, 20.0)
            Dim Recitation As Double = ConvertToTwenty(RecitationEntry, 20.0)
            Dim Exam As Double = ConvertToTwenty(ExamEntry, 40.0)


            Dim Average As Double = Quiz + Assignment + Recitation + Exam

            AverageLabel.Text = Average.ToString

            If Average < 74.99 Then
                RemarksLabel.Text = "FAILED"
                RemarksLabel.BackColor = Color.Red
            Else
                RemarksLabel.Text = "PASSED"
                RemarksLabel.BackColor = Color.Blue
            End If



        End If

    End Sub



    Function ConvertToTwenty(grade, gradefactor) As Double
        Dim percentage As Double

        percentage = ((grade / 50.0) * 50.0 + 50.0) * (gradefactor / 100.0)

        Return percentage
    End Function

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        QuizTextBox.Text = String.Empty
        AssignmentTextBox.Text = String.Empty
        RecitationTextBox.Text = String.Empty
        ExamTextBox.Text = String.Empty
    End Sub
End Class
