' The Liquid Lounge details page
Public Class Form4

    Private Const PlaceID As String = "LL01"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLL.Image = My.Resources.Resources.Liquid_Lounge
        UiHelpers.PopulateVenue(Me, VenueData.FindVenue(PlaceID))
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnBookVenue_Click(sender As Object, e As EventArgs) Handles btnBookVenue.Click
        UiHelpers.BookVenue(Me, PlaceID)
    End Sub

End Class