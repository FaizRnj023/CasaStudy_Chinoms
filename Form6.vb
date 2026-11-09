' Jubilee Hall details page
Public Class Form6

    Private Const PlaceID As String = "JH01"

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiHelpers.PopulateVenue(Me, VenueData.FindVenue(PlaceID))
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