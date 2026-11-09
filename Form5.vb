' The Moonbeam Meadows details page
Public Class Form5

    Private Const PlaceID As String = "MM01"

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picMM.Image = My.Resources.Resources.Moonbeam_Meadows
        UiHelpers.PopulateVenue(Me, VenueData.FindVenue(PlaceID))
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnBookVenue_Click(sender As Object, e As EventArgs) Handles btnBookVenue.Click
        UiHelpers.BookVenue(Me, PlaceID)
    End Sub

End Class