' Billing details
Public Class Form9

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim b As Booking = AppState.Booking

        txtBookingID.Text = b.BookingID
        txtTransactionDate.Text = b.TransactionDate.ToString("MMMM d, yyyy  h:mm tt")
        txtCustID.Text = b.Customer.CustomerID
        txtCustName.Text = b.Customer.Name
        txtEventID.Text = b.Guests.ToString()                  ' sits next to the "Total Guests:" label
        txtEventDate.Text = b.EventDate.ToString("MMMM d, yyyy")

        UiHelpers.FillBreakdown(tlpBreakdown, b.Lines)
        txtTotal.Text = Pricing.Money(b.Total)

        UiHelpers.LockTextBoxes(Me)
        txtCash.ReadOnly = False
        txtCash.Text = Pricing.Peso & " "
    End Sub

    Private Sub txtCash_Enter(sender As Object, e As EventArgs) Handles txtCash.Enter
        txtCash.SelectionStart = txtCash.TextLength
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnProceedToBilling_Click(sender As Object, e As EventArgs) Handles btnProceedToBilling.Click   ' "Pay"
        Dim b As Booking = AppState.Booking
        Dim payment As Decimal

        If b.Status = "Paid" Then
            MessageBox.Show("This booking has already been paid.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Select Case Pricing.CheckPayment(txtCash.Text, b.Total, payment)
            Case PaymentResult.Invalid
                MessageBox.Show("Invalid value entered", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCash.Focus()

            Case PaymentResult.Insufficient
                MessageBox.Show("Insufficient payment", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCash.Focus()

            Case PaymentResult.Success
                b.Payment = payment
                b.Change = payment - b.Total
                b.Status = "Paid"
                If Not AppState.Bookings.Contains(b) Then AppState.Bookings.Add(b)
                MessageBox.Show("Successful payment" & vbCrLf & "Change: " & Pricing.Money(b.Change),
                                "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Nav.Open(Me, New Form10())
        End Select
    End Sub

End Class