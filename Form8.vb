' Booking summary
Imports System.Net.NetworkInformation

Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim b As Booking = AppState.Booking

        txtBookingID.Text = b.BookingID
        txtTransactionDate.Text = b.TransactionDate.ToString("MMMM d, yyyy  h:mm tt")

        ' Customer details
        txtCustID.Text = b.Customer.CustomerID
        txtCustName.Text = b.Customer.Name
        txtMobileNo.Text = b.Customer.Mobile
        txtEventID.Text = b.EventInfo.EventID & "  (" & b.EventInfo.Name & ")"
        txtEventDate.Text = b.EventDate.ToString("MMMM d, yyyy")
        txtNumOfGuests.Text = b.Guests.ToString()

        ' Event place details
        txtPlaceID.Text = b.Venue.PlaceID
        txtVenueName.Text = b.Venue.Name
        txtType.Text = b.Venue.VenueType
        txtEPDate.Text = b.EventDate.ToString("MMMM d, yyyy")

        ' Availed add-on services
        lblAvailedAOS.MaximumSize = New Size(grpAAOS.Width - 40, 0)
        lblAvailedAOS.AutoSize = True
        If b.Services.Count = 0 Then
            lblAvailedAOS.Text = "-"
        Else
            lblAvailedAOS.Text = String.Join("     |     ", b.Services.Select(Function(s)
                                                                                  Return If(s.Instructions = "", s.Name, s.Name & " (" & s.Instructions & ")")
                                                                              End Function))
        End If

        UiHelpers.LockTextBoxes(Me)

        If AppState.ViewOnly Then
            btnEditDetails.Visible = False
            If b.Status = "Paid" Then btnProceedToBilling.Text = "View receipt"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnEditDetails_Click(sender As Object, e As EventArgs) Handles btnEditDetails.Click
        ' Go back to the customer / event form (it is still open, just hidden).
        Nav.ReturnTo(Of CustomerDetails)(Me)
    End Sub

    Private Sub btnProceedToBilling_Click(sender As Object, e As EventArgs) Handles btnProceedToBilling.Click
        Dim b As Booking = AppState.Booking

        If AppState.ViewOnly AndAlso b.Status = "Paid" Then
            Nav.Open(Me, New Form10())
            Return
        End If

        If Not AppState.Bookings.Contains(b) Then AppState.Bookings.Add(b)
        Nav.Open(Me, New Form9())
    End Sub

End Class