' Booking list (opened from "View booking details").
' I only had Form11.resx, not Form11.Designer.vb, so this finds the grid and back button by type/name
' and creates any column or control that is missing.
Public Class Form11

    Private grid As DataGridView
    Private txtSearch As TextBox
    Private cboStatus As ComboBox
    Private cboYear As ComboBox
    Private loading As Boolean

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grid = FindGrid(Me)
        If grid Is Nothing Then
            grid = New DataGridView With {.Location = New Point(50, 190), .Size = New Size(Me.ClientSize.Width - 100, 740)}
            Me.Controls.Add(grid)
        End If

        grid.ReadOnly = True
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.RowHeadersVisible = False
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        EnsureTextColumn("BookingID", "Booking ID")
        EnsureTextColumn("CustomerID", "Customer ID")
        EnsureTextColumn("PlaceID", "Place ID")
        EnsureTextColumn("EventDate", "Event Date")
        EnsureButtonColumn("ViewDetails", "Booking Details")
        EnsureButtonColumn("TransactionDetails", "Transaction Details")
        EnsureTextColumn("Status", "Status")

        AddHandler grid.CellContentClick, AddressOf Grid_CellContentClick

        ' Search box + filters (controls come from the designer; looked up by name)
        txtSearch = TryCast(Me.Controls.Find("txtSearchRecords", True).FirstOrDefault(), TextBox)
        cboStatus = TryCast(Me.Controls.Find("cboFilterStatus", True).FirstOrDefault(), ComboBox)
        cboYear = TryCast(Me.Controls.Find("cboFilterYear", True).FirstOrDefault(), ComboBox)

        loading = True
        If cboStatus IsNot Nothing Then
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
            cboStatus.Items.Clear()
            cboStatus.Items.AddRange(New Object() {"All", "Pending", "Paid"})
            cboStatus.SelectedIndex = 0
            AddHandler cboStatus.SelectedIndexChanged, AddressOf FilterChanged
        End If
        If cboYear IsNot Nothing Then
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList
            AddHandler cboYear.SelectedIndexChanged, AddressOf FilterChanged
        End If
        If txtSearch IsNot Nothing Then AddHandler txtSearch.TextChanged, AddressOf FilterChanged
        loading = False

        Dim back As Control = Me.Controls.Find("btnBack", True).FirstOrDefault()
        If back Is Nothing Then
            back = New Button With {.Name = "btnBack", .Text = "Back", .Location = New Point(50, 90), .Size = New Size(150, 47)}
            Me.Controls.Add(back)
        End If
        AddHandler back.Click, Sub(o, ev) Nav.Back(Me)

        AddHandler Me.VisibleChanged, Sub(o, ev)
                                          If Me.Visible Then LoadBookings()
                                      End Sub
        LoadBookings()
    End Sub

    Private Sub FilterChanged(sender As Object, e As EventArgs)
        If Not loading Then LoadBookings()
    End Sub

    ' Year list = "All" + every event-date year in the list; keeps the current choice if still present.
    Private Sub RefreshYears()
        If cboYear Is Nothing Then Return
        Dim keep As String = If(cboYear.SelectedItem Is Nothing, "All", cboYear.SelectedItem.ToString())
        loading = True
        cboYear.Items.Clear()
        cboYear.Items.Add("All")
        For Each y As Integer In AppState.Bookings.Select(Function(x) x.EventDate.Year).Distinct().OrderBy(Function(x) x)
            cboYear.Items.Add(y.ToString())
        Next
        Dim idx As Integer = cboYear.Items.IndexOf(keep)
        cboYear.SelectedIndex = If(idx >= 0, idx, 0)
        loading = False
    End Sub

    Private Function PassesFilters(b As Booking) As Boolean
        If cboStatus IsNot Nothing AndAlso cboStatus.SelectedIndex > 0 Then
            If b.Status <> cboStatus.SelectedItem.ToString() Then Return False
        End If

        If cboYear IsNot Nothing AndAlso cboYear.SelectedIndex > 0 Then
            If b.EventDate.Year.ToString() <> cboYear.SelectedItem.ToString() Then Return False
        End If

        Dim term As String = If(txtSearch Is Nothing, "", txtSearch.Text.Trim())
        If term = "" Then Return True

        Dim fields() As String = {
            b.BookingID, b.Customer.CustomerID, b.Customer.Name,
            b.Venue.PlaceID, b.Venue.Name,
            b.EventDate.ToString("MMM d, yyyy"), b.EventDate.ToString("MMMM d, yyyy"),
            b.Status}
        Return fields.Any(Function(f) f IsNot Nothing AndAlso f.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
    End Function

    Private Sub LoadBookings()
        RefreshYears()
        grid.Rows.Clear()
        For Each b As Booking In AppState.Bookings
            If Not PassesFilters(b) Then Continue For
            Dim i As Integer = grid.Rows.Add()
            Dim r As DataGridViewRow = grid.Rows(i)
            r.Tag = b
            r.Cells("BookingID").Value = b.BookingID
            r.Cells("CustomerID").Value = b.Customer.CustomerID
            r.Cells("PlaceID").Value = b.Venue.PlaceID
            r.Cells("EventDate").Value = b.EventDate.ToString("MMM d, yyyy")
            r.Cells("ViewDetails").Value = "View details"
            r.Cells("TransactionDetails").Value = If(b.Status = "Paid", "View receipt", "Not yet paid")
            r.Cells("Status").Value = b.Status
        Next
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return
        Dim b As Booking = TryCast(grid.Rows(e.RowIndex).Tag, Booking)
        If b Is Nothing Then Return

        Select Case grid.Columns(e.ColumnIndex).Name
            Case "ViewDetails"
                AppState.Booking = b
                AppState.ViewOnly = True
                Nav.Open(Me, New Form8())

            Case "TransactionDetails"
                If b.Status <> "Paid" Then
                    MessageBox.Show("This booking has not been paid yet.", "ChiNoms Event place",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
                AppState.Booking = b
                AppState.ViewOnly = True
                Nav.Open(Me, New Form10())
        End Select
    End Sub

    Private Sub Form11_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AppState.ViewOnly = False
    End Sub

    ' ---------- helpers ----------
    Private Shared Function FindGrid(root As Control) As DataGridView
        For Each c As Control In root.Controls
            Dim g As DataGridView = TryCast(c, DataGridView)
            If g IsNot Nothing Then Return g
            g = FindGrid(c)
            If g IsNot Nothing Then Return g
        Next
        Return Nothing
    End Function

    Private Sub EnsureTextColumn(name As String, header As String)
        If Not grid.Columns.Contains(name) Then
            grid.Columns.Add(name, header)
        End If
    End Sub

    Private Sub EnsureButtonColumn(name As String, header As String)
        If Not grid.Columns.Contains(name) Then
            grid.Columns.Add(New DataGridViewButtonColumn With {.Name = name, .HeaderText = header})
        End If
    End Sub

End Class