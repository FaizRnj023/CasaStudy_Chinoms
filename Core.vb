Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq

' =====================================================================
'  Core.vb  -  models, sample data, pricing formulas, navigation helpers
' =====================================================================

#Region "Models"

Public Class Customer
    Public Property CustomerID As String
    Public Property Name As String
    Public Property Birthday As Date
    Public Property Age As Integer
    Public Property Gender As String
    Public Property Address As String
    Public Property Mobile As String
End Class

Public Class EventType
    Public Property EventID As String
    Public Property Name As String
    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class

Public Class Venue
    Public Property PlaceID As String
    Public Property Name As String
    Public Property VenueType As String
    Public Property Address As String
    Public Property Capacity As Integer
    ''' <summary>Place price per tier. Tiers(0) = up to 50 pax, Tiers(1) = up to 100 pax, ...</summary>
    Public Property Tiers As Decimal()
    Public Property EventTypes As String
    Public Property Features As String
    Public Property ServiceStars As Integer
    Public Property CleanStars As Integer
End Class

Public Class AddOnService
    Public Property Name As String
    Public Property Price As Decimal              ' per 50 pax
    Public Property IsDecoration As Boolean       ' priced by venue capacity instead
    Public Property Instructions As String = ""
    Public Function Clone() As AddOnService
        Return DirectCast(MemberwiseClone(), AddOnService)
    End Function
End Class

Public Class BillLine
    Public Property Category As String
    Public Property Item As String
    Public Property Rate As String
    Public Property Surcharge As Decimal
    Public Property Amount As Decimal
End Class

Public Class Booking
    Public Property BookingID As String
    Public Property TransactionDate As Date
    Public Property Customer As Customer
    Public Property EventInfo As EventType
    Public Property Guests As Integer
    Public Property EventDate As Date
    Public Property Venue As Venue
    Public Property Services As New List(Of AddOnService)
    Public Property Lines As New List(Of BillLine)
    Public Property Total As Decimal
    Public Property Payment As Decimal
    Public Property Change As Decimal
    Public Property Status As String = "Pending"
End Class

#End Region

#Region "Sample data  (EDIT THESE to match your real price list)"

Public Module VenueData

    Public ReadOnly Events As New List(Of EventType) From {
        New EventType With {.EventID = "EV01", .Name = "Wedding"},
        New EventType With {.EventID = "EV02", .Name = "Birthday"},
        New EventType With {.EventID = "EV03", .Name = "Debut"},
        New EventType With {.EventID = "EV04", .Name = "Corporate Event"},
        New EventType With {.EventID = "EV05", .Name = "Christening"},
        New EventType With {.EventID = "EV06", .Name = "Reunion"}
    }

    ' PLACEHOLDER prices/capacities - replace with the figures from your price list.
    Public ReadOnly Venues As New List(Of Venue) From {
        New Venue With {.PlaceID = "LL01", .Name = "The Liquid Lounge", .VenueType = "Indoor Lounge",
                        .Address = "Address of The Liquid Lounge", .Capacity = 100,
                        .Tiers = New Decimal() {15000D, 25000D},
                        .EventTypes = "Birthday, Debut, Corporate Event",
                        .Features = "Sleek lighting, lounge seating, bar area",
                        .ServiceStars = 5, .CleanStars = 4},
        New Venue With {.PlaceID = "MM01", .Name = "Moonbeam Meadows", .VenueType = "Outdoor Garden",
                        .Address = "Address of Moonbeam Meadows", .Capacity = 200,
                        .Tiers = New Decimal() {12000D, 18000D, 25000D, 32000D},
                        .EventTypes = "Wedding, Christening, Reunion",
                        .Features = "Open-air garden, tranquil nature setting",
                        .ServiceStars = 4, .CleanStars = 5},
        New Venue With {.PlaceID = "JH01", .Name = "Jubilee Hall", .VenueType = "Indoor Hall",
                        .Address = "Address of Jubilee Hall", .Capacity = 300,
                        .Tiers = New Decimal() {20000D, 30000D, 40000D, 50000D, 60000D, 70000D},
                        .EventTypes = "Wedding, Debut, Corporate Event",
                        .Features = "Fairy-light canopy, large stage, air-conditioned",
                        .ServiceStars = 5, .CleanStars = 5}
    }

    ' Max 11 services (the add-on table has 12 rows incl. header).
    Public ReadOnly Services As New List(Of AddOnService) From {
        New AddOnService With {.Name = "Catering", .Price = 20000D},
        New AddOnService With {.Name = "Sound System", .Price = 12000D},
        New AddOnService With {.Name = "Photography", .Price = 8000D},
        New AddOnService With {.Name = "Photo Booth", .Price = 6000D},
        New AddOnService With {.Name = "Lights & Effects", .Price = 7000D},
        New AddOnService With {.Name = "Host / Emcee", .Price = 5000D},
        New AddOnService With {.Name = "Decorations", .Price = 0D, .IsDecoration = True}
    }

    Public Function FindVenue(placeId As String) As Venue
        Return Venues.First(Function(v) v.PlaceID = placeId)
    End Function

End Module

#End Region

#Region "Pricing formulas (from the PDF)"

Public Enum PaymentResult
    Invalid
    Insufficient
    Success
End Enum

Public Module Pricing

    Public ReadOnly Peso As String = ChrW(&H20B1)

    Public Function Money(value As Decimal) As String
        Return Peso & " " & value.ToString("N2", CultureInfo.InvariantCulture)
    End Function

    ' U = ceil(G / 50)
    Public Function Units(guests As Integer) As Integer
        Return CInt(Math.Ceiling(guests / 50.0R))
    End Function

    ' Place Price = price of tier ceil(G/50); if beyond the last tier, use the highest tier
    Public Function PlaceTier(v As Venue, guests As Integer) As Integer
        Return Math.Max(1, Math.Min(Units(guests), v.Tiers.Length))
    End Function

    Public Function PlacePrice(v As Venue, guests As Integer) As Decimal
        Return v.Tiers(PlaceTier(v, guests) - 1)
    End Function

    ' Surcharge = max(0, G - C) * 100
    Public Function Surcharge(v As Venue, guests As Integer) As Decimal
        Return Math.Max(0, guests - v.Capacity) * 100D
    End Function

    ' Decorations depend on venue capacity: C <= 150 -> 1,500 else 3,000
    Public Function DecorationFee(v As Venue) As Decimal
        Return If(v.Capacity <= 150, 1500D, 3000D)
    End Function

    Public Sub BuildBill(b As Booking)
        Dim u As Integer = Units(b.Guests)
        Dim place As Decimal = PlacePrice(b.Venue, b.Guests)
        Dim sur As Decimal = Surcharge(b.Venue, b.Guests)

        b.Lines.Clear()
        b.Lines.Add(New BillLine With {
            .Category = "Venue", .Item = b.Venue.Name,
            .Rate = Money(place) & " (tier " & PlaceTier(b.Venue, b.Guests) & ")",
            .Surcharge = sur, .Amount = place + sur})

        For Each s In b.Services
            If s.IsDecoration Then
                Dim fee As Decimal = DecorationFee(b.Venue)
                b.Lines.Add(New BillLine With {
                    .Category = "Add-on", .Item = s.Name,
                    .Rate = Money(fee) & " (flat)", .Surcharge = 0D, .Amount = fee})
            Else
                b.Lines.Add(New BillLine With {
                    .Category = "Add-on", .Item = s.Name,
                    .Rate = Money(s.Price) & " x " & u, .Surcharge = 0D, .Amount = s.Price * u})
            End If
        Next

        b.Total = b.Lines.Sum(Function(l) l.Amount)
    End Sub

    Public Function CheckPayment(text As String, total As Decimal, ByRef payment As Decimal) As PaymentResult
        payment = 0D
        Dim clean As String = If(text, "").Replace(Peso, "").Replace(",", "").Replace(" ", "")
        If clean = "" Then Return PaymentResult.Invalid
        If Not Decimal.TryParse(clean, NumberStyles.Number, CultureInfo.InvariantCulture, payment) Then Return PaymentResult.Invalid
        If payment <= 0 Then Return PaymentResult.Invalid
        If payment < total Then Return PaymentResult.Insufficient
        Return PaymentResult.Success
    End Function

End Module

#End Region

#Region "Shared state between the forms"

Public Module AppState
    Public Customer As Customer
    Public EventInfo As EventType
    Public Guests As Integer
    Public EventDate As Date
    Public Venue As Venue
    Public Services As New List(Of AddOnService)
    Public Booking As Booking
    Public ViewOnly As Boolean                       ' True when opened from the booking list
    Public ReadOnly Bookings As New List(Of Booking)

    Public Sub Reset()
        Customer = Nothing
        EventInfo = Nothing
        Guests = 0
        Venue = Nothing
        Services = New List(Of AddOnService)
        Booking = Nothing
        ViewOnly = False
    End Sub

    Public Function CreateBooking() As Booking
        Dim b As New Booking With {
            .BookingID = "BK-" & Date.Now.ToString("yyyyMMdd") & "-" & (Bookings.Count + 1).ToString("000"),
            .TransactionDate = Date.Now,
            .Customer = Customer,
            .EventInfo = EventInfo,
            .Guests = Guests,
            .EventDate = EventDate,
            .Venue = Venue,
            .Status = "Pending"}
        b.Services.AddRange(Services)
        Pricing.BuildBill(b)
        Return b
    End Function
End Module

#End Region

#Region "Navigation helpers"

Public Module Nav

    ''' <summary>Hide the current form and show the next one (owned by the current form).</summary>
    Public Sub Open(current As Form, [next] As Form)
        FontLoader.Apply([next])
        UiHelpers.StandardizeWindow([next])
        AddHandler [next].FormClosed, AddressOf OnChildClosed
        current.Hide()
        [next].Show(current)
    End Sub

    ''' <summary>Close this form and re-show the one that opened it.</summary>
    Public Sub Back(current As Form)
        Dim o As Form = current.Owner
        If o IsNot Nothing Then o.Show()
        current.Close()
    End Sub

    ''' <summary>Show an already-open form of type T and close every other form except the landing page.</summary>
    Public Sub ReturnTo(Of T As Form)(current As Form)
        Dim target As Form = Application.OpenForms.OfType(Of T)().FirstOrDefault()
        If target Is Nothing Then Return
        target.Show()
        For Each f As Form In Application.OpenForms.Cast(Of Form)().ToList()
            If f IsNot target AndAlso TypeOf f IsNot LandingPage Then f.Close()
        Next
    End Sub

    Public Sub GoHome()
        Dim home As LandingPage = Application.OpenForms.OfType(Of LandingPage)().FirstOrDefault()
        If home Is Nothing Then Return
        home.Show()
        For Each f As Form In Application.OpenForms.Cast(Of Form)().ToList()
            If f IsNot home Then f.Close()
        Next
    End Sub

    ' If the user closes a window with the X button and nothing is visible, go back to the landing page.
    Private Sub OnChildClosed(sender As Object, e As FormClosedEventArgs)
        Dim f As Form = DirectCast(sender, Form)
        Dim anyVisible As Boolean = Application.OpenForms.Cast(Of Form)().Any(Function(x) x IsNot f AndAlso x.Visible)
        If Not anyVisible Then GoHome()
    End Sub

End Module

#End Region

#Region "UI helpers"

Public Module UiHelpers

    ''' <summary>Same window behaviour on every page: fixed size, no maximize, centred on screen.</summary>
    Public Sub StandardizeWindow(f As Form)
        f.FormBorderStyle = FormBorderStyle.FixedSingle
        f.MaximizeBox = False
        f.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub SetText(f As Control, name As String, text As String)
        Dim found() As Control = f.Controls.Find(name, True)
        If found.Length > 0 Then found(0).Text = text
    End Sub

    Public Sub LockTextBoxes(root As Control)
        For Each c As Control In root.Controls
            Dim tb As TextBox = TryCast(c, TextBox)
            If tb IsNot Nothing Then
                tb.ReadOnly = True
            Else
                LockTextBoxes(c)
            End If
        Next
    End Sub

    Public Function Stars(n As Integer) As String
        n = Math.Max(0, Math.Min(5, n))
        Return New String(ChrW(&H2605), n) & New String(ChrW(&H2606), 5 - n)
    End Function

    ''' <summary>Fills the 5-column breakdown table (Category | Item | Price rate | Surcharge | Amount).</summary>
    Public Sub FillBreakdown(tlp As TableLayoutPanel, lines As List(Of BillLine))
        tlp.SuspendLayout()

        For i As Integer = tlp.Controls.Count - 1 To 0 Step -1
            Dim c As Control = tlp.Controls(i)
            If tlp.GetRow(c) > 0 Then
                tlp.Controls.Remove(c)
                c.Dispose()
            End If
        Next

        tlp.RowStyles.Clear()
        tlp.RowCount = lines.Count + 1
        For r As Integer = 0 To lines.Count
            tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0F))
        Next
        tlp.AutoScroll = True

        For r As Integer = 0 To lines.Count - 1
            Dim l As BillLine = lines(r)
            AddCell(tlp, l.Category, 0, r + 1)
            AddCell(tlp, l.Item, 1, r + 1)
            AddCell(tlp, l.Rate, 2, r + 1)
            AddCell(tlp, If(l.Surcharge > 0, Money(l.Surcharge), "-"), 3, r + 1)
            AddCell(tlp, Money(l.Amount), 4, r + 1)
        Next

        tlp.ResumeLayout(True)
    End Sub

    Private Sub AddCell(tlp As TableLayoutPanel, text As String, col As Integer, row As Integer)
        Dim lbl As New Label With {
            .AutoSize = True,
            .UseMnemonic = False,
            .Text = text,
            .Font = FontLoader.MakeFont("Inter Display Medium", 8.0F),
            .Anchor = AnchorStyles.Left,
            .Margin = New Padding(5)}
        tlp.Controls.Add(lbl, col, row)
    End Sub

    ''' <summary>Lays the Price / Features / Types row out as three equal columns; values wrap inside their column.</summary>
    Private Sub LayoutVenueColumns(f As Form)
        Dim pnl As Control = f.Controls.Find("Panel2", True).FirstOrDefault()
        If pnl Is Nothing Then Return

        Dim heads As String() = {"Label4", "Label7", "Label9"}
        Dim values As String() = {"lblPricePerPday", "lblFeatures", "lblTypesOfEvents"}

        Dim firstHead As Control = pnl.Controls.Find(heads(0), False).FirstOrDefault()
        If firstHead Is Nothing Then Return

        Dim margin As Integer = firstHead.Left
        Dim colW As Integer = (pnl.ClientSize.Width - 4 * margin) \ 3

        For i As Integer = 0 To 2
            Dim x As Integer = margin + i * (colW + margin)
            Dim h As Control = pnl.Controls.Find(heads(i), False).FirstOrDefault()
            Dim v As Label = TryCast(pnl.Controls.Find(values(i), False).FirstOrDefault(), Label)
            If h IsNot Nothing Then h.Left = x
            If v IsNot Nothing Then
                v.Left = x
                v.AutoSize = True
                v.MaximumSize = New Size(colW, 0)
            End If
        Next
    End Sub

    ''' <summary>Fills the venue-details pages (Form4/5/6 share the same control names).</summary>
    Public Sub PopulateVenue(f As Form, v As Venue)
        SetText(f, "lblVenue", v.Name.ToUpper())
        SetText(f, "txtPlaceID", v.PlaceID)
        SetText(f, "txtType", v.VenueType)
        SetText(f, "txtAddress", v.Address)
        SetText(f, "txtMaxCapacity", v.Capacity.ToString() & " pax")
        SetText(f, "lblPricePerPday", Money(v.Tiers.Min()) & " - " & Money(v.Tiers.Max()) & vbCrLf & "(per 50-pax tier)")
        SetText(f, "lblTypesOfEvents", v.EventTypes)
        SetText(f, "lblFeatures", v.Features)
        SetText(f, "lblStarsService", Stars(v.ServiceStars))
        SetText(f, "lblStarsSpaceAndClean", Stars(v.CleanStars))
        SetText(f, "Label4", "PRICE RANGE")
        LayoutVenueColumns(f)
        LockTextBoxes(f)
    End Sub

    Public Sub BookVenue(f As Form, placeId As String)
        Dim v As Venue = VenueData.FindVenue(placeId)
        Dim sur As Decimal = Pricing.Surcharge(v, AppState.Guests)
        If sur > 0 Then
            Dim msg As String = "Your " & AppState.Guests & " guests exceed this venue's capacity of " & v.Capacity &
                                ". A surcharge of " & Pricing.Money(sur) & " will apply. Continue?"
            If MessageBox.Show(msg, "Over capacity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        End If
        AppState.Venue = v
        Nav.Open(f, New Form7())
    End Sub

End Module

#End Region
