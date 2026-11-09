' Official receipt
Imports System.Net.NetworkInformation
Imports Windows.Win32.Graphics

Public Class Form10

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim b As Booking = AppState.Booking

        txtBookingID.Text = b.BookingID
        txtTransactionDate.Text = b.TransactionDate.ToString("MMMM d, yyyy  h:mm tt")
        txtCustID.Text = b.Customer.CustomerID
        txtCustName.Text = b.Customer.Name
        txtEventID.Text = b.Guests.ToString()                  ' sits next to the "Total Guests:" label
        txtEventDate.Text = b.EventDate.ToString("MMMM d, yyyy")

        UiHelpers.FillBreakdown(tlpBreakdown, b.Lines)
        txtTotal.Text = Pricing.Money(b.Total)
        txtCash.Text = Pricing.Money(b.Payment)
        txtChange.Text = Pricing.Money(b.Change)

        UiHelpers.LockTextBoxes(Me)
    End Sub

    ' btnBack is the "Done" button on this page.
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If AppState.ViewOnly Then
            Nav.Back(Me)
        Else
            AppState.Reset()
            Nav.GoHome()
        End If
    End Sub

End Class