Public Class frmReservations
    Const _cdecCostPerNight As Decimal = 79D
    Private Sub frmReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPrice.Text = "Only " + _cdecCostPerNight.ToString("C2") + " per night"
        txtNumNights.Clear()
        txtNumNights.Focus()
        lblTotalCost.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumNights.Clear()
        txtNumNights.Focus()
        lblTotalCost.Text = ""
    End Sub

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Dim strNumNights As String = txtNumNights.Text
        Dim intNumNights As Integer = Convert.ToInt32(strNumNights)
        Dim decTotalCost As Decimal = intNumNights * _cdecCostPerNight
        lblTotalCost.Text = decTotalCost.ToString("C2")
    End Sub
End Class
