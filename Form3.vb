Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiHelpers.CenterInParent(Label17)
        UiHelpers.CenterOver(Label1, picLL)
        UiHelpers.CenterOver(Label5, picMM)
        UiHelpers.CenterOver(Label6, picMMJH)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Nav.Back(Me)
    End Sub

    Private Sub btnViewDetailsLL_Click(sender As Object, e As EventArgs) Handles btnViewDetailsLL.Click
        Nav.Open(Me, New Form456_VenueDetails("LL01"))
    End Sub

    Private Sub btnViewDetailsMM_Click(sender As Object, e As EventArgs) Handles btnViewDetailsMM.Click
        Nav.Open(Me, New Form456_VenueDetails("MM01"))
    End Sub

    Private Sub btnViewDetailsMMJH_Click(sender As Object, e As EventArgs) Handles btnViewDetailsMMJH.Click
        Nav.Open(Me, New Form456_VenueDetails("JH01"))
    End Sub

End Class