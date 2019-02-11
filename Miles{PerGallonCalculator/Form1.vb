Public Class MilesPerGallonCalculator

    Private Sub CalculateMPG(sender As Object, e As EventArgs) Handles Calculate.Click

        Dim gallonOriginal As Decimal = 0
        Dim milesOriginal As Decimal = 0
        Dim mpgAmmount As Decimal = 0

        gallonOriginal = CDec(Gallon.Text)
        milesOriginal = CDec(Miles.Text)
        mpgAmmount = CDec(milesOriginal / gallonOriginal)
        MPG.Text = mpgAmmount.ToString
    End Sub
    Private Sub clearAllFields(sender As Object, e As EventArgs) Handles Clear.Click
        Gallon.Text = String.Empty
        Miles.Text = String.Empty
        MPG.Text = String.Empty
    End Sub

    Private Sub Close1_Click(sender As Object, e As EventArgs) Handles Close1.Click
        Me.Close()

    End Sub
End Class

Private Sub Enter_Gallon(sender As Object, e As EventArgs) Handles Gallon.TextChanged

    End Sub

    Private Sub EnterMiles(sender As Object, e As EventArgs) Handles Miles.TextChanged

    End Sub

    Private Sub ShowMPG(sender As Object, e As EventArgs) Handles MPG.Click

    End Sub




