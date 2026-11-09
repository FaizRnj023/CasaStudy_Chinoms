' Jubilee Hall details page
Public Class Form6

    Private Const PlaceID As String = "JH01"

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picMMJH.Image = My.Resources.Resources.Hall
        UiHelpers.PopulateVenue(Me, VenueData.FindVenue(PlaceID))
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnBookVenue_Click(sender As Object, e As EventArgs) Handles btnBookVenue.Click
        UiHelpers.BookVenue(Me, PlaceID)
    End Sub

End Class