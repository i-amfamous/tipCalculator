Public Class Form1
    Private Sub btnTipServer_Click(sender As Object, e As EventArgs) Handles btnTipServer.Click
        Dim discount As Double
        discount = 0.5
        Dim tipAmount As Double
        tipAmount = tipBox.Text

        If tipAmount >= 150 Then
            Dim results As Double
            results = tipAmount * discount
            lblMessage.Text = "Your tip amount passed the discount so you had a discount of " & discount & " " & " amount paid is" & results

        ElseIf tipAmount <= 149 Then
            lblMessage.Text = "Your tip amount did not pass the discount so you paid " & tipAmount
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
