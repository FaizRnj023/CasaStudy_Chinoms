<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnBack = New RoundedButton()
        Label18 = New Label()
        Label4 = New Label()
        cboFilterStatus = New ComboBox()
        cboFilterYear = New ComboBox()
        dgvBookingRecords = New DataGridView()
        BookingID = New DataGridViewTextBoxColumn()
        CustomerID = New DataGridViewTextBoxColumn()
        PlaceID = New DataGridViewTextBoxColumn()
        EventDate = New DataGridViewTextBoxColumn()
        ViewDetails = New DataGridViewTextBoxColumn()
        TransactionDetails = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        txtSearchRecords = New TextBox()
        CType(dgvBookingRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(28), CByte(42), CByte(65))
        btnBack.BorderColor = Color.White
        btnBack.BorderThickness = 2
        btnBack.CornerRadius = 12
        btnBack.FillColor = Color.FromArgb(CByte(28), CByte(42), CByte(65))
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Inter Display Medium", 8.0F)
        btnBack.ForeColor = Color.White
        btnBack.HoverColor = Color.FromArgb(CByte(52), CByte(68), CByte(107))
        btnBack.Location = New Point(50, 90)
        btnBack.Name = "btnBack"
        btnBack.PressedColor = Color.FromArgb(CByte(20), CByte(28), CByte(48))
        btnBack.Size = New Size(150, 47)
        btnBack.TabIndex = 73
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Cinzel Black", 14.0F)
        Label18.ForeColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        Label18.Location = New Point(570, 93)
        Label18.Margin = New Padding(5, 0, 5, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(394, 44)
        Label18.TabIndex = 72
        Label18.Text = "BOOKING RECORDS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Inter Display Medium", 8.0F)
        Label4.Location = New Point(1070, 222)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 26)
        Label4.TabIndex = 75
        Label4.Text = "Filter by:"
        ' 
        ' cboFilterStatus
        ' 
        cboFilterStatus.Font = New Font("Inter Display Medium", 8.0F)
        cboFilterStatus.FormattingEnabled = True
        cboFilterStatus.Location = New Point(1181, 219)
        cboFilterStatus.Name = "cboFilterStatus"
        cboFilterStatus.Size = New Size(172, 33)
        cboFilterStatus.TabIndex = 76
        ' 
        ' cboFilterYear
        ' 
        cboFilterYear.Font = New Font("Inter Display Medium", 8.0F)
        cboFilterYear.FormattingEnabled = True
        cboFilterYear.Location = New Point(1371, 219)
        cboFilterYear.Name = "cboFilterYear"
        cboFilterYear.Size = New Size(134, 33)
        cboFilterYear.TabIndex = 77
        ' 
        ' dgvBookingRecords
        ' 
        dgvBookingRecords.BackgroundColor = SystemColors.Control
        dgvBookingRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBookingRecords.Columns.AddRange(New DataGridViewColumn() {BookingID, CustomerID, PlaceID, EventDate, ViewDetails, TransactionDetails, Status})
        dgvBookingRecords.Location = New Point(32, 302)
        dgvBookingRecords.Name = "dgvBookingRecords"
        dgvBookingRecords.RowHeadersWidth = 82
        dgvBookingRecords.Size = New Size(1491, 650)
        dgvBookingRecords.TabIndex = 78
        ' 
        ' BookingID
        ' 
        BookingID.HeaderText = "Booking ID"
        BookingID.MinimumWidth = 10
        BookingID.Name = "BookingID"
        BookingID.Width = 200
        ' 
        ' CustomerID
        ' 
        CustomerID.HeaderText = "Customer ID"
        CustomerID.MinimumWidth = 10
        CustomerID.Name = "CustomerID"
        CustomerID.Width = 200
        ' 
        ' PlaceID
        ' 
        PlaceID.HeaderText = "Place ID"
        PlaceID.MinimumWidth = 10
        PlaceID.Name = "PlaceID"
        PlaceID.Width = 200
        ' 
        ' EventDate
        ' 
        EventDate.HeaderText = "Event Date"
        EventDate.MinimumWidth = 10
        EventDate.Name = "EventDate"
        EventDate.Width = 200
        ' 
        ' ViewDetails
        ' 
        ViewDetails.HeaderText = "View Details"
        ViewDetails.MinimumWidth = 10
        ViewDetails.Name = "ViewDetails"
        ViewDetails.Width = 200
        ' 
        ' TransactionDetails
        ' 
        TransactionDetails.HeaderText = "Transaction Details"
        TransactionDetails.MinimumWidth = 10
        TransactionDetails.Name = "TransactionDetails"
        TransactionDetails.Width = 200
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 10
        Status.Name = "Status"
        Status.Width = 200
        ' 
        ' txtSearchRecords
        ' 
        txtSearchRecords.Font = New Font("Inter Display Medium", 8.0F)
        txtSearchRecords.Location = New Point(50, 219)
        txtSearchRecords.Name = "txtSearchRecords"
        txtSearchRecords.PlaceholderText = "Search Booking or Customer ID"
        txtSearchRecords.Size = New Size(438, 32)
        txtSearchRecords.TabIndex = 79
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(192.0F, 192.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackgroundImage = My.Resources.Resources.BG___Logo_w_Header_room
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1584, 989)
        Controls.Add(btnBack)
        Controls.Add(txtSearchRecords)
        Controls.Add(dgvBookingRecords)
        Controls.Add(cboFilterYear)
        Controls.Add(cboFilterStatus)
        Controls.Add(Label4)
        Controls.Add(Label18)
        Margin = New Padding(5, 5, 5, 5)
        Name = "Form11"
        ShowIcon = False
        Text = "ChiNoms Event place"
        CType(dgvBookingRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents Label18 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboFilterStatus As ComboBox
    Friend WithEvents cboFilterYear As ComboBox
    Friend WithEvents dgvBookingRecords As DataGridView
    Friend WithEvents BookingID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents PlaceID As DataGridViewTextBoxColumn
    Friend WithEvents EventDate As DataGridViewTextBoxColumn
    Friend WithEvents ViewDetails As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDetails As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents txtSearchRecords As TextBox
End Class
