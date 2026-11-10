' Booking list (opened from "View booking details").
Public Class Form11

    Private grid As DataGridView

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiHelpers.CenterInParent(Label18)
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

    Private Sub LoadBookings()
        grid.Rows.Clear()
        For Each b As Booking In AppState.Bookings
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
            StyleButton(r.Cells("ViewDetails"), True)
            StyleButton(r.Cells("TransactionDetails"), b.Status = "Paid")
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
        Dim existing As DataGridViewColumn = Nothing
        If grid.Columns.Contains(name) Then
            existing = grid.Columns(name)
            If TypeOf existing Is DataGridViewButtonColumn Then Return
        End If

        Dim btn As New DataGridViewButtonColumn With {
        .Name = name,
        .HeaderText = header,
        .FlatStyle = FlatStyle.Flat}
        btn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If existing IsNot Nothing Then
            Dim idx As Integer = existing.Index
            grid.Columns.RemoveAt(idx)
            grid.Columns.Insert(idx, btn)
        Else
            grid.Columns.Add(btn)
        End If
    End Sub

    Private Shared Sub StyleButton(cell As DataGridViewCell, active As Boolean)
        Dim back As Color = If(active, Color.MidnightBlue, Color.Gainsboro)
        Dim fore As Color = If(active, Color.White, Color.Gray)
        cell.Style.BackColor = back
        cell.Style.ForeColor = fore
        cell.Style.SelectionBackColor = back
        cell.Style.SelectionForeColor = fore
    End Sub

End Class