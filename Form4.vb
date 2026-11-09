' The Liquid Lounge details page
Public Class Form4

    Private Const PlaceID As String = "LL01"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiHelpers.PopulateVenue(Me, VenueData.FindVenue(PlaceID))
        ' btnBack is declared without WithEvents in the designer, so hook it manually.
        AddHandler btnBack.Click, AddressOf GoBack
    End Sub

    Private Sub GoBack(sender As Object, e As EventArgs)
        Nav.Back(Me)
    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnBookVenue_Click(sender As Object, e As EventArgs) Handles btnBookVenue.Click
        UiHelpers.BookVenue(Me, PlaceID)
    End Sub

End Class