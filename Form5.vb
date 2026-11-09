' Moonbeam Meadows details page
Public Class Form5

    Private Const PlaceID As String = "MM01"

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The designer assigns the Liquid_Lounge picture here by mistake.
        picMM.Image = My.Resources.Resources.Moonbeam_Meadows
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