' Details page for any venue. Open it with the venue's PlaceID: New VenueDetails("LL01")
Public Class Form456_VenueDetails

    Private ReadOnly _placeId As String

    ' Needed so the Visual Studio designer can open this form.
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(placeId As String)
        Me.New()
        _placeId = placeId
    End Sub

    Private Sub VenueDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(_placeId) Then Return
        Dim v As Venue = VenueData.FindVenue(_placeId)

        ' Show this venue's photo (the designer shows the Liquid Lounge one).
        Dim photo As Image = TryCast(My.Resources.Resources.ResourceManager.GetObject(v.PhotoResource), Image)
        If photo IsNot Nothing Then picLL.Image = photo

        UiHelpers.PopulateVenue(Me, v)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnBookVenue_Click(sender As Object, e As EventArgs) Handles btnBookVenue.Click
        UiHelpers.BookVenue(Me, _placeId)
    End Sub

End Class