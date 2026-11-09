Imports System.Net.NetworkInformation
Imports Windows.Win32.Graphics

Public Class Form7

    Private ReadOnly rows As New List(Of Tuple(Of CheckBox, TextBox))

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim v As Venue = AppState.Venue
        Dim row As Integer = 1                                   ' row 0 is the header

        tlpAddOnServices.SuspendLayout()
        For Each s As AddOnService In VenueData.Services
            If row >= tlpAddOnServices.RowCount Then Exit For    ' table has 11 service rows

            Dim chk As New CheckBox With {
                .Text = s.Name, .Tag = s, .AutoSize = True, .UseMnemonic = False,
                .Anchor = AnchorStyles.Left, .Margin = New Padding(8, 3, 3, 3)}

            Dim txt As New TextBox With {
                .Enabled = False, .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
                .Margin = New Padding(5, 3, 15, 3)}

            Dim priceText As String
            If s.IsDecoration Then
                priceText = Pricing.Money(Pricing.DecorationFee(v)) & "  (flat, based on venue capacity)"
            Else
                priceText = Pricing.Money(s.Price) & "  per 50 pax"
            End If
            Dim lbl As New Label With {
                .Text = priceText, .AutoSize = True, .Anchor = AnchorStyles.Left,
                .Font = FontLoader.MakeFont("Inter Display Medium", 8.0F)}

            AddHandler chk.CheckedChanged, Sub(o, ev)
                                               txt.Enabled = chk.Checked
                                               If Not chk.Checked Then txt.Clear()
                                           End Sub

            tlpAddOnServices.Controls.Add(chk, 0, row)
            tlpAddOnServices.Controls.Add(txt, 1, row)
            tlpAddOnServices.Controls.Add(lbl, 2, row)
            rows.Add(Tuple.Create(chk, txt))
            row += 1
        Next
        tlpAddOnServices.ResumeLayout(True)

        ' Restore earlier choices if the user came back to this page.
        For Each r In rows
            Dim svc As AddOnService = DirectCast(r.Item1.Tag, AddOnService)
            Dim prev As AddOnService = AppState.Services.FirstOrDefault(Function(x) x.Name = svc.Name)
            If prev IsNot Nothing Then
                r.Item1.Checked = True
                r.Item2.Text = prev.Instructions
            End If
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        AppState.Services = New List(Of AddOnService)
        For Each r In rows
            If r.Item1.Checked Then
                Dim copy As AddOnService = DirectCast(r.Item1.Tag, AddOnService).Clone()
                copy.Instructions = r.Item2.Text.Trim()
                AppState.Services.Add(copy)
            End If
        Next

        AppState.Booking = AppState.CreateBooking()
        Nav.Open(Me, New Form8())
    End Sub

End Class