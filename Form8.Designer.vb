<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        grpAAOS = New GroupBox()
        lblAvailedAOS = New Label()
        grpEPDetails = New GroupBox()
        Label3 = New Label()
        Label7 = New Label()
        Label17 = New Label()
        Label20 = New Label()
        txtPlaceID = New TextBox()
        txtVenueName = New TextBox()
        txtEPDate = New TextBox()
        txtType = New TextBox()
        txtBookingID = New TextBox()
        grpCustDetails = New GroupBox()
        Label13 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        txtCustID = New TextBox()
        txtCustName = New TextBox()
        txtNumOfGuests = New TextBox()
        txtMobileNo = New TextBox()
        txtEventDate = New TextBox()
        txtEventID = New TextBox()
        btnEditDetails = New RoundedButton()
        btnProceedToBilling = New RoundedButton()
        txtTransactionDate = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnBack = New RoundedButton()
        Label18 = New Label()
        Panel1.SuspendLayout()
        grpAAOS.SuspendLayout()
        grpEPDetails.SuspendLayout()
        grpCustDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(grpAAOS)
        Panel1.Controls.Add(grpEPDetails)
        Panel1.Controls.Add(txtBookingID)
        Panel1.Controls.Add(grpCustDetails)
        Panel1.Controls.Add(btnEditDetails)
        Panel1.Controls.Add(btnProceedToBilling)
        Panel1.Controls.Add(txtTransactionDate)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(10, 190)
        Panel1.Margin = New Padding(5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1560, 785)
        Panel1.TabIndex = 8
        ' 
        ' grpAAOS
        ' 
        grpAAOS.BackColor = Color.Transparent
        grpAAOS.Controls.Add(lblAvailedAOS)
        grpAAOS.FlatStyle = FlatStyle.Flat
        grpAAOS.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        grpAAOS.Location = New Point(22, 503)
        grpAAOS.Name = "grpAAOS"
        grpAAOS.Size = New Size(1518, 162)
        grpAAOS.TabIndex = 78
        grpAAOS.TabStop = False
        grpAAOS.Text = "Availed Add-On Services"
        ' 
        ' lblAvailedAOS
        ' 
        lblAvailedAOS.AutoSize = True
        lblAvailedAOS.Location = New Point(16, 42)
        lblAvailedAOS.Margin = New Padding(5, 0, 5, 0)
        lblAvailedAOS.Name = "lblAvailedAOS"
        lblAvailedAOS.Size = New Size(22, 26)
        lblAvailedAOS.TabIndex = 31
        lblAvailedAOS.Text = "-"
        ' 
        ' grpEPDetails
        ' 
        grpEPDetails.BackColor = Color.Transparent
        grpEPDetails.Controls.Add(Label3)
        grpEPDetails.Controls.Add(Label7)
        grpEPDetails.Controls.Add(Label17)
        grpEPDetails.Controls.Add(Label20)
        grpEPDetails.Controls.Add(txtPlaceID)
        grpEPDetails.Controls.Add(txtVenueName)
        grpEPDetails.Controls.Add(txtEPDate)
        grpEPDetails.Controls.Add(txtType)
        grpEPDetails.FlatStyle = FlatStyle.Flat
        grpEPDetails.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        grpEPDetails.Location = New Point(22, 313)
        grpEPDetails.Name = "grpEPDetails"
        grpEPDetails.Size = New Size(1518, 162)
        grpEPDetails.TabIndex = 77
        grpEPDetails.TabStop = False
        grpEPDetails.Text = "Event Place Details"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Inter Display Medium", 8F)
        Label3.Location = New Point(802, 48)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 26)
        Label3.TabIndex = 14
        Label3.Text = "Type:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Inter Display Medium", 8F)
        Label7.Location = New Point(18, 48)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 26)
        Label7.TabIndex = 7
        Label7.Text = "Place ID:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Inter Display Medium", 8F)
        Label17.Location = New Point(16, 101)
        Label17.Margin = New Padding(5, 0, 5, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(142, 26)
        Label17.TabIndex = 8
        Label17.Text = "Venue Name:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Inter Display Medium", 8F)
        Label20.Location = New Point(802, 101)
        Label20.Margin = New Padding(5, 0, 5, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(63, 26)
        Label20.TabIndex = 15
        Label20.Text = "Date:"
        ' 
        ' txtPlaceID
        ' 
        txtPlaceID.Font = New Font("Inter Display Medium", 8F)
        txtPlaceID.Location = New Point(219, 42)
        txtPlaceID.Margin = New Padding(5)
        txtPlaceID.Name = "txtPlaceID"
        txtPlaceID.Size = New Size(477, 33)
        txtPlaceID.TabIndex = 19
        ' 
        ' txtVenueName
        ' 
        txtVenueName.Font = New Font("Inter Display Medium", 8F)
        txtVenueName.Location = New Point(219, 94)
        txtVenueName.Margin = New Padding(5)
        txtVenueName.Name = "txtVenueName"
        txtVenueName.Size = New Size(477, 33)
        txtVenueName.TabIndex = 20
        ' 
        ' txtEPDate
        ' 
        txtEPDate.Font = New Font("Inter Display Medium", 8F)
        txtEPDate.Location = New Point(922, 96)
        txtEPDate.Margin = New Padding(5)
        txtEPDate.Name = "txtEPDate"
        txtEPDate.Size = New Size(569, 33)
        txtEPDate.TabIndex = 25
        ' 
        ' txtType
        ' 
        txtType.Font = New Font("Inter Display Medium", 8F)
        txtType.Location = New Point(922, 42)
        txtType.Margin = New Padding(5)
        txtType.Name = "txtType"
        txtType.Size = New Size(569, 33)
        txtType.TabIndex = 24
        ' 
        ' txtBookingID
        ' 
        txtBookingID.Font = New Font("Inter Display Medium", 8F)
        txtBookingID.Location = New Point(188, 13)
        txtBookingID.Margin = New Padding(5)
        txtBookingID.Name = "txtBookingID"
        txtBookingID.Size = New Size(528, 33)
        txtBookingID.TabIndex = 77
        ' 
        ' grpCustDetails
        ' 
        grpCustDetails.BackColor = Color.Transparent
        grpCustDetails.Controls.Add(Label13)
        grpCustDetails.Controls.Add(Label4)
        grpCustDetails.Controls.Add(Label5)
        grpCustDetails.Controls.Add(Label6)
        grpCustDetails.Controls.Add(Label12)
        grpCustDetails.Controls.Add(Label11)
        grpCustDetails.Controls.Add(txtCustID)
        grpCustDetails.Controls.Add(txtCustName)
        grpCustDetails.Controls.Add(txtNumOfGuests)
        grpCustDetails.Controls.Add(txtMobileNo)
        grpCustDetails.Controls.Add(txtEventDate)
        grpCustDetails.Controls.Add(txtEventID)
        grpCustDetails.FlatStyle = FlatStyle.Flat
        grpCustDetails.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        grpCustDetails.Location = New Point(22, 79)
        grpCustDetails.Name = "grpCustDetails"
        grpCustDetails.Size = New Size(1518, 210)
        grpCustDetails.TabIndex = 76
        grpCustDetails.TabStop = False
        grpCustDetails.Text = "Customer Details"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Inter Display Medium", 8F)
        Label13.Location = New Point(802, 48)
        Label13.Margin = New Padding(5, 0, 5, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 26)
        Label13.TabIndex = 14
        Label13.Text = "Event ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Inter Display Medium", 8F)
        Label4.Location = New Point(18, 48)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 26)
        Label4.TabIndex = 7
        Label4.Text = "Customer ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Inter Display Medium", 8F)
        Label5.Location = New Point(16, 101)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 26)
        Label5.TabIndex = 8
        Label5.Text = "Customer Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Inter Display Medium", 8F)
        Label6.Location = New Point(18, 155)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 26)
        Label6.TabIndex = 9
        Label6.Text = "Mobile No."
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Inter Display Medium", 8F)
        Label12.Location = New Point(802, 101)
        Label12.Margin = New Padding(5, 0, 5, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 26)
        Label12.TabIndex = 15
        Label12.Text = "Event Date:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Inter Display Medium", 8F)
        Label11.Location = New Point(802, 150)
        Label11.Margin = New Padding(5, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(194, 26)
        Label11.TabIndex = 16
        Label11.Text = "Number of Guests:"
        ' 
        ' txtCustID
        ' 
        txtCustID.Font = New Font("Inter Display Medium", 8F)
        txtCustID.Location = New Point(219, 42)
        txtCustID.Margin = New Padding(5)
        txtCustID.Name = "txtCustID"
        txtCustID.Size = New Size(477, 33)
        txtCustID.TabIndex = 19
        ' 
        ' txtCustName
        ' 
        txtCustName.Font = New Font("Inter Display Medium", 8F)
        txtCustName.Location = New Point(219, 94)
        txtCustName.Margin = New Padding(5)
        txtCustName.Name = "txtCustName"
        txtCustName.Size = New Size(477, 33)
        txtCustName.TabIndex = 20
        ' 
        ' txtNumOfGuests
        ' 
        txtNumOfGuests.Font = New Font("Inter Display Medium", 8F)
        txtNumOfGuests.Location = New Point(1014, 147)
        txtNumOfGuests.Margin = New Padding(5)
        txtNumOfGuests.Name = "txtNumOfGuests"
        txtNumOfGuests.Size = New Size(477, 33)
        txtNumOfGuests.TabIndex = 26
        ' 
        ' txtMobileNo
        ' 
        txtMobileNo.Font = New Font("Inter Display Medium", 8F)
        txtMobileNo.Location = New Point(219, 147)
        txtMobileNo.Margin = New Padding(5)
        txtMobileNo.Name = "txtMobileNo"
        txtMobileNo.Size = New Size(477, 33)
        txtMobileNo.TabIndex = 21
        ' 
        ' txtEventDate
        ' 
        txtEventDate.Font = New Font("Inter Display Medium", 8F)
        txtEventDate.Location = New Point(1014, 96)
        txtEventDate.Margin = New Padding(5)
        txtEventDate.Name = "txtEventDate"
        txtEventDate.Size = New Size(477, 33)
        txtEventDate.TabIndex = 25
        ' 
        ' txtEventID
        ' 
        txtEventID.Font = New Font("Inter Display Medium", 8F)
        txtEventID.Location = New Point(1014, 42)
        txtEventID.Margin = New Padding(5)
        txtEventID.Name = "txtEventID"
        txtEventID.Size = New Size(477, 33)
        txtEventID.TabIndex = 24
        ' 
        ' btnEditDetails
        ' 
        btnEditDetails.BackColor = Color.Transparent
        btnEditDetails.BorderColor = Color.MidnightBlue
        btnEditDetails.BorderThickness = 2
        btnEditDetails.CornerRadius = 12
        btnEditDetails.FillColor = Color.Transparent
        btnEditDetails.FlatAppearance.BorderSize = 0
        btnEditDetails.FlatStyle = FlatStyle.Flat
        btnEditDetails.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        btnEditDetails.ForeColor = Color.MidnightBlue
        btnEditDetails.HoverColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btnEditDetails.ImeMode = ImeMode.NoControl
        btnEditDetails.Location = New Point(1032, 693)
        btnEditDetails.Name = "btnEditDetails"
        btnEditDetails.PressedColor = Color.FromArgb(CByte(225), CByte(225), CByte(235))
        btnEditDetails.Size = New Size(233, 61)
        btnEditDetails.TabIndex = 75
        btnEditDetails.Text = "Edit details"
        btnEditDetails.UseVisualStyleBackColor = False
        ' 
        ' btnProceedToBilling
        ' 
        btnProceedToBilling.BackColor = Color.Transparent
        btnProceedToBilling.BorderColor = Color.Empty
        btnProceedToBilling.BorderThickness = 2
        btnProceedToBilling.CornerRadius = 12
        btnProceedToBilling.FillColor = Color.MidnightBlue
        btnProceedToBilling.FlatAppearance.BorderSize = 0
        btnProceedToBilling.FlatStyle = FlatStyle.Flat
        btnProceedToBilling.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        btnProceedToBilling.ForeColor = Color.White
        btnProceedToBilling.HoverColor = Color.FromArgb(CByte(45), CByte(45), CByte(140))
        btnProceedToBilling.ImeMode = ImeMode.NoControl
        btnProceedToBilling.Location = New Point(1278, 693)
        btnProceedToBilling.Name = "btnProceedToBilling"
        btnProceedToBilling.PressedColor = Color.FromArgb(CByte(15), CByte(15), CByte(80))
        btnProceedToBilling.Size = New Size(233, 61)
        btnProceedToBilling.TabIndex = 74
        btnProceedToBilling.Text = "Proceed to billing"
        btnProceedToBilling.UseVisualStyleBackColor = False
        ' 
        ' txtTransactionDate
        ' 
        txtTransactionDate.Font = New Font("Inter Display Medium", 8F)
        txtTransactionDate.Location = New Point(1036, 13)
        txtTransactionDate.Margin = New Padding(5)
        txtTransactionDate.Name = "txtTransactionDate"
        txtTransactionDate.Size = New Size(477, 33)
        txtTransactionDate.TabIndex = 30
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Inter Display Medium", 8F)
        Label2.Location = New Point(824, 16)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 26)
        Label2.TabIndex = 5
        Label2.Text = "Transaction Date:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter Display Medium", 8F)
        Label1.Location = New Point(42, 20)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 26)
        Label1.TabIndex = 4
        Label1.Text = "Booking ID:"
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
        btnBack.Font = New Font("Inter Display Medium", 8F)
        btnBack.ForeColor = Color.White
        btnBack.HoverColor = Color.FromArgb(CByte(52), CByte(68), CByte(107))
        btnBack.ImeMode = ImeMode.NoControl
        btnBack.Location = New Point(50, 90)
        btnBack.Name = "btnBack"
        btnBack.PressedColor = Color.FromArgb(CByte(20), CByte(28), CByte(48))
        btnBack.Size = New Size(150, 47)
        btnBack.TabIndex = 69
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Cinzel Black", 14F)
        Label18.ForeColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        Label18.Location = New Point(566, 90)
        Label18.Margin = New Padding(5, 0, 5, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(451, 51)
        Label18.TabIndex = 68
        Label18.Text = "BOOKING SUMMARY"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(192.0F, 192.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackgroundImage = My.Resources.Resources.BG___Logo_w_Header_room
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1584, 989)
        Controls.Add(btnBack)
        Controls.Add(Label18)
        Controls.Add(Panel1)
        Margin = New Padding(5)
        Name = "Form8"
        ShowIcon = False
        Text = "ChiNoms Event place"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grpAAOS.ResumeLayout(False)
        grpAAOS.PerformLayout()
        grpEPDetails.ResumeLayout(False)
        grpEPDetails.PerformLayout()
        grpCustDetails.ResumeLayout(False)
        grpCustDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAvailedAOS As Label
    Friend WithEvents txtTransactionDate As TextBox
    Friend WithEvents txtNumOfGuests As TextBox
    Friend WithEvents txtEventDate As TextBox
    Friend WithEvents txtEventID As TextBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents Label18 As Label
    Private WithEvents btnEditDetails As RoundedButton
    Friend WithEvents btnProceedToBilling As RoundedButton
    Friend WithEvents grpCustDetails As GroupBox
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents grpEPDetails As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtPlaceID As TextBox
    Friend WithEvents txtVenueName As TextBox
    Friend WithEvents txtEPDate As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents grpAAOS As GroupBox
End Class
