Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Grade As Integer
        Dim message As String

        Grade = TextBox1.Text

        Select Case Grade
            Case 0 To 19
                message = "Your Grade Is between 0 - 19 and your pointer is 0.00 "
            Case 20 To 29
                message = "Your Grade Is between 20 - 29 and your pointer is 0.33"
            Case 30 To 39
                message = "Your Grade Is between 30 - 39 and your pointer is 0.67"
            Case 40 To 43
                message = "Your Grade Is between 40 - 43 and your pointer is 1.00"
            Case 44 To 46
                message = "Your Grade Is between 44 - 46 and your pointer is 1.33"
            Case 47 To 49
                message = "Your Grade Is between 47 - 49 and your pointer is 1.67"
            Case 50 To 54
                message = "Your Grade Is between 50 - 54 and your pointer is 2.00"
            Case 55 To 59
                message = "Your Grade Is between 55 - 59 and your pointer is 2.33"
            Case 60 To 64
                message = "Your Grade Is between 60 - 64 and your pointer is 2.67"
            Case 65 To 69
                message = "Your Grade Is between 65 - 69 and your pointer is 3.00"
            Case 70 To 74
                message = "Your Grade Is between 70 - 74 and your pointer is 3.33"
            Case 75 To 79
                message = "Your Grade Is between 75 - 79 and your pointer is 3.67"
            Case 80 To 89
                message = "Your Grade Is between 80 - 89 and your pointer is 4.00"
            Case 90 To 100
                message = "Your Grade Is between 90 - 100 and your pointer is 4.00"
            Case Else
                message = "Please Enter The Correct Input!"
        End Select
        MessageBox.Show(message, "Case Statement", MessageBoxButtons.OK)
    End Sub
End Class
