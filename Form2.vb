Imports System.Text.RegularExpressions

Public Class CustomerDetails

    Private Const MinAge As Integer = 18

    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiHelpers.CenterInParent(Label10)
        UiHelpers.CenterInParent(Label13)
        ' The designer default (2 Dec 2026) is in the future, so set values before the limits.
        dtpBirthday.Value = Date.Today
        dtpBirthday.MaxDate = Date.Today
        dtpEventDate.Value = Date.Today.AddDays(1)
        dtpEventDate.MinDate = Date.Today.AddDays(1)

        txtAge.ReadOnly = True
        txtInCustomerID.ReadOnly = True   ' generated automatically, not typed in
        txtInCustomerID.TabStop = False
        cmbEvents.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEvents.DataSource = VenueData.Events.ToList()
        cmbEvents.SelectedIndex = -1

        ResetForm()
        HookInputs(pnlCustDetails)
    End Sub

    ' ---------- age ----------
    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        txtAge.Text = ComputeAge(dtpBirthday.Value).ToString()
    End Sub

    Private Shared Function ComputeAge(birthday As Date) As Integer
        Dim a As Integer = Date.Today.Year - birthday.Year
        If birthday.Date > Date.Today.AddYears(-a) Then a -= 1
        Return a
    End Function

    ' ---------- invalidate the saved customer when the inputs are edited ----------
    Private Sub HookInputs(root As Control)
        For Each c As Control In root.Controls
            If TypeOf c Is TextBox AndAlso c IsNot txtAge AndAlso c IsNot txtInCustomerID Then
                AddHandler DirectCast(c, TextBox).TextChanged, AddressOf InputChanged
            ElseIf TypeOf c Is RadioButton Then
                AddHandler DirectCast(c, RadioButton).CheckedChanged, AddressOf InputChanged
            ElseIf TypeOf c Is DateTimePicker Then
                AddHandler DirectCast(c, DateTimePicker).ValueChanged, AddressOf InputChanged
            End If
        Next
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs)
        If pnlEventPlaceDetails.Enabled Then
            pnlEventPlaceDetails.Enabled = False
            pnlCustIDName.Visible = False
            AppState.Customer = Nothing
        End If
    End Sub

    ' ---------- save ----------
    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        Dim id = txtInCustomerID.Text.Trim
        Dim name = txtInCustomerName.Text.Trim
        Dim address = txtInAddress.Text.Trim
        Dim mobile = txtInMobile.Text.Trim
        Dim age = ComputeAge(dtpBirthday.Value)

        If name = "" Then Warn("Please enter the customer name.", txtInCustomerName) : Return
        If age < MinAge Then Warn("The customer must be at least " & MinAge & " years old.", dtpBirthday) : Return
        If Not radMale.Checked AndAlso Not radFemale.Checked Then Warn("Please select a gender.", radFemale) : Return
        If address = "" Then Warn("Please enter the address.", txtInAddress) : Return
        If Not Regex.IsMatch(mobile, "^(09\d{9}|\+639\d{9})$") Then
            Warn("Please enter a valid mobile number (e.g. 09171234567).", txtInMobile) : Return
        End If

        AppState.Customer = New Customer With {
            .CustomerID = id, .Name = name, .Birthday = dtpBirthday.Value.Date, .Age = age,
            .Gender = If(radFemale.Checked, "Female", "Male"), .Address = address, .Mobile = mobile}

        txtOutCustomerID.Text = id
        txtOutCustomerName.Text = name
        pnlCustIDName.Visible = True
        pnlEventPlaceDetails.Enabled = True
        cmbEvents.Focus()
    End Sub

    ' ---------- reset ----------
    Private Sub btnResetCustomer_Click(sender As Object, e As EventArgs) Handles btnResetCustomer.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        txtInCustomerID.Text = AppState.NextCustomerID()
        txtInCustomerName.Clear()
        txtInAddress.Clear()
        txtInMobile.Clear()
        radMale.Checked = False
        radFemale.Checked = False
        dtpBirthday.Value = Date.Today
        txtAge.Text = "0"
        cmbEvents.SelectedIndex = -1
        txtInGuestCount.Clear()
        dtpEventDate.Value = dtpEventDate.MinDate
        txtOutCustomerID.Clear()
        txtOutCustomerName.Clear()
        pnlCustIDName.Visible = False
        pnlEventPlaceDetails.Enabled = False
        AppState.Reset()
        txtInCustomerName.Focus()
    End Sub

    ' ---------- search venue ----------
    Private Sub btnSearchVenue_Click(sender As Object, e As EventArgs) Handles btnSearchVenue.Click
        If AppState.Customer Is Nothing Then
            Warn("Please save the customer details first.", btnSaveCustomer) : Return
        End If
        If cmbEvents.SelectedItem Is Nothing Then Warn("Please choose the type of event.", cmbEvents) : Return

        Dim guests As Integer
        If Not Integer.TryParse(txtInGuestCount.Text.Trim, guests) OrElse guests < 1 OrElse guests > 5000 Then
            Warn("Please enter a valid number of guests (1 - 5000).", txtInGuestCount) : Return
        End If

        EventInfo = DirectCast(cmbEvents.SelectedItem, EventType)
        AppState.Guests = guests
        EventDate = dtpEventDate.Value.Date
        Open(Me, New Form3)
    End Sub

    Private Sub Warn(message As String, focusOn As Control)
        MessageBox.Show(message, "ChiNoms Event place", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        focusOn.Focus()
    End Sub

End Class