Imports System.Net.NetworkInformation

Public Class LandingPage

    Public Sub New()
        InitializeComponent()
        UiHelpers.StandardizeWindow(Me)
    End Sub

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FontLoader.Apply(Me)
    End Sub

    Private Sub btnBookEventPlace_Click(sender As Object, e As EventArgs) Handles btnBookEventPlace.Click
        AppState.Reset()
        Nav.Open(Me, New CustomerDetails())
    End Sub

    Private Sub btnViewBooking_Click(sender As Object, e As EventArgs) Handles btnViewBooking.Click
        Nav.Open(Me, New Form11())
    End Sub

End Class