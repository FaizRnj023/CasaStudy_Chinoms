<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerDetails))
        pnlCustDetails = New Panel()
        dtpBirthday = New DateTimePicker()
        radMale = New RadioButton()
        radFemale = New RadioButton()
        Label10 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtInMobile = New TextBox()
        txtInAddress = New TextBox()
        txtAge = New TextBox()
        txtInCustomerName = New TextBox()
        txtInCustomerID = New TextBox()
        pnlEventPlaceDetails = New Panel()
        dtpEventDate = New DateTimePicker()
        pnlCustIDName = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        txtOutCustomerID = New TextBox()
        txtOutCustomerName = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        cmbEvents = New ComboBox()
        txtInGuestCount = New TextBox()
        pnlCustDetails.SuspendLayout()
        pnlEventPlaceDetails.SuspendLayout()
        pnlCustIDName.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCustDetails
        ' 
        pnlCustDetails.BackColor = Color.Transparent
        pnlCustDetails.Controls.Add(dtpBirthday)
        pnlCustDetails.Controls.Add(radMale)
        pnlCustDetails.Controls.Add(radFemale)
        pnlCustDetails.Controls.Add(Label10)
        pnlCustDetails.Controls.Add(Label7)
        pnlCustDetails.Controls.Add(Label6)
        pnlCustDetails.Controls.Add(Label5)
        pnlCustDetails.Controls.Add(Label4)
        pnlCustDetails.Controls.Add(Label3)
        pnlCustDetails.Controls.Add(Label2)
        pnlCustDetails.Controls.Add(Label1)
        pnlCustDetails.Controls.Add(txtInMobile)
        pnlCustDetails.Controls.Add(txtInAddress)
        pnlCustDetails.Controls.Add(txtAge)
        pnlCustDetails.Controls.Add(txtInCustomerName)
        pnlCustDetails.Controls.Add(txtInCustomerID)
        pnlCustDetails.Font = New Font("Segoe UI", 7.8F)
        pnlCustDetails.Location = New Point(11, 119)
        pnlCustDetails.Margin = New Padding(5)
        pnlCustDetails.Name = "pnlCustDetails"
        pnlCustDetails.Size = New Size(771, 854)
        pnlCustDetails.TabIndex = 0
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.CalendarFont = New Font("Microsoft Sans Serif", 8F)
        dtpBirthday.Font = New Font("Microsoft Sans Serif", 8F)
        dtpBirthday.Location = New Point(44, 315)
        dtpBirthday.Margin = New Padding(0)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(460, 32)
        dtpBirthday.TabIndex = 0
        dtpBirthday.Value = New Date(2026, 12, 2, 0, 0, 0, 0)
        ' 
        ' radMale
        ' 
        radMale.AutoSize = True
        radMale.BackColor = Color.Transparent
        radMale.Font = New Font("Microsoft Sans Serif", 8F)
        radMale.Location = New Point(193, 412)
        radMale.Margin = New Padding(5)
        radMale.Name = "radMale"
        radMale.Size = New Size(90, 30)
        radMale.TabIndex = 19
        radMale.Text = "Male"
        radMale.UseVisualStyleBackColor = False
        ' 
        ' radFemale
        ' 
        radFemale.AutoSize = True
        radFemale.BackColor = Color.Transparent
        radFemale.Font = New Font("Microsoft Sans Serif", 8F)
        radFemale.Location = New Point(44, 412)
        radFemale.Margin = New Padding(5)
        radFemale.Name = "radFemale"
        radFemale.Size = New Size(116, 30)
        radFemale.TabIndex = 18
        radFemale.Text = "Female"
        radFemale.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Label10.Location = New Point(245, 26)
        Label10.Margin = New Padding(5, 0, 5, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(239, 31)
        Label10.TabIndex = 17
        Label10.Text = "Customer Details"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 8F)
        Label7.Location = New Point(44, 570)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 26)
        Label7.TabIndex = 16
        Label7.Text = "Mobile No.:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 8F)
        Label6.Location = New Point(44, 471)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 26)
        Label6.TabIndex = 15
        Label6.Text = "Address:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8F)
        Label5.Location = New Point(44, 374)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 26)
        Label5.TabIndex = 14
        Label5.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 8F)
        Label4.Location = New Point(520, 279)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 26)
        Label4.TabIndex = 13
        Label4.Text = "Age:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 8F)
        Label3.Location = New Point(44, 283)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 26)
        Label3.TabIndex = 12
        Label3.Text = "Birthday:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 8F)
        Label2.Location = New Point(44, 183)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 26)
        Label2.TabIndex = 11
        Label2.Text = "Customer Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 8F)
        Label1.Location = New Point(44, 88)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 26)
        Label1.TabIndex = 10
        Label1.Text = "Customer ID:"
        ' 
        ' txtInMobile
        ' 
        txtInMobile.Font = New Font("Microsoft Sans Serif", 8F)
        txtInMobile.Location = New Point(44, 602)
        txtInMobile.Margin = New Padding(5)
        txtInMobile.Name = "txtInMobile"
        txtInMobile.Size = New Size(682, 32)
        txtInMobile.TabIndex = 7
        ' 
        ' txtInAddress
        ' 
        txtInAddress.Font = New Font("Microsoft Sans Serif", 8F)
        txtInAddress.Location = New Point(44, 504)
        txtInAddress.Margin = New Padding(5)
        txtInAddress.Name = "txtInAddress"
        txtInAddress.Size = New Size(682, 32)
        txtInAddress.TabIndex = 6
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Microsoft Sans Serif", 8F)
        txtAge.Location = New Point(520, 315)
        txtAge.Margin = New Padding(5)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(206, 32)
        txtAge.TabIndex = 3
        ' 
        ' txtInCustomerName
        ' 
        txtInCustomerName.Font = New Font("Microsoft Sans Serif", 8F)
        txtInCustomerName.Location = New Point(44, 216)
        txtInCustomerName.Margin = New Padding(5)
        txtInCustomerName.Name = "txtInCustomerName"
        txtInCustomerName.Size = New Size(682, 32)
        txtInCustomerName.TabIndex = 1
        ' 
        ' txtInCustomerID
        ' 
        txtInCustomerID.Font = New Font("Microsoft Sans Serif", 8F)
        txtInCustomerID.Location = New Point(44, 121)
        txtInCustomerID.Margin = New Padding(5)
        txtInCustomerID.Name = "txtInCustomerID"
        txtInCustomerID.Size = New Size(682, 32)
        txtInCustomerID.TabIndex = 0
        ' 
        ' pnlEventPlaceDetails
        ' 
        pnlEventPlaceDetails.BackColor = Color.Transparent
        pnlEventPlaceDetails.Controls.Add(dtpEventDate)
        pnlEventPlaceDetails.Controls.Add(pnlCustIDName)
        pnlEventPlaceDetails.Controls.Add(Label15)
        pnlEventPlaceDetails.Controls.Add(Label14)
        pnlEventPlaceDetails.Controls.Add(Label12)
        pnlEventPlaceDetails.Controls.Add(Label13)
        pnlEventPlaceDetails.Controls.Add(cmbEvents)
        pnlEventPlaceDetails.Controls.Add(txtInGuestCount)
        pnlEventPlaceDetails.Location = New Point(802, 119)
        pnlEventPlaceDetails.Margin = New Padding(5)
        pnlEventPlaceDetails.Name = "pnlEventPlaceDetails"
        pnlEventPlaceDetails.Size = New Size(771, 854)
        pnlEventPlaceDetails.TabIndex = 1
        ' 
        ' dtpEventDate
        ' 
        dtpEventDate.CalendarFont = New Font("Microsoft Sans Serif", 8F)
        dtpEventDate.Font = New Font("Microsoft Sans Serif", 8F)
        dtpEventDate.Location = New Point(44, 501)
        dtpEventDate.Margin = New Padding(0)
        dtpEventDate.Name = "dtpEventDate"
        dtpEventDate.Size = New Size(682, 32)
        dtpEventDate.TabIndex = 24
        dtpEventDate.Value = New Date(2026, 12, 2, 0, 0, 0, 0)
        ' 
        ' pnlCustIDName
        ' 
        pnlCustIDName.BackColor = Color.FromArgb(CByte(239), CByte(227), CByte(203))
        pnlCustIDName.Controls.Add(Label9)
        pnlCustIDName.Controls.Add(Label8)
        pnlCustIDName.Controls.Add(txtOutCustomerID)
        pnlCustIDName.Controls.Add(txtOutCustomerName)
        pnlCustIDName.Location = New Point(44, 88)
        pnlCustIDName.Name = "pnlCustIDName"
        pnlCustIDName.Size = New Size(682, 173)
        pnlCustIDName.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 8F)
        Label9.Location = New Point(29, 102)
        Label9.Margin = New Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(178, 26)
        Label9.TabIndex = 21
        Label9.Text = "Customer Name:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 8F)
        Label8.Location = New Point(29, 40)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(181, 26)
        Label8.TabIndex = 20
        Label8.Text = "Customer ID No.:"
        ' 
        ' txtOutCustomerID
        ' 
        txtOutCustomerID.BackColor = Color.FromArgb(CByte(239), CByte(227), CByte(203))
        txtOutCustomerID.BorderStyle = BorderStyle.None
        txtOutCustomerID.Font = New Font("Microsoft Sans Serif", 8F)
        txtOutCustomerID.Location = New Point(236, 40)
        txtOutCustomerID.Margin = New Padding(5)
        txtOutCustomerID.Name = "txtOutCustomerID"
        txtOutCustomerID.Size = New Size(403, 25)
        txtOutCustomerID.TabIndex = 22
        ' 
        ' txtOutCustomerName
        ' 
        txtOutCustomerName.BackColor = Color.FromArgb(CByte(239), CByte(227), CByte(203))
        txtOutCustomerName.BorderStyle = BorderStyle.None
        txtOutCustomerName.Font = New Font("Microsoft Sans Serif", 8F)
        txtOutCustomerName.Location = New Point(236, 102)
        txtOutCustomerName.Margin = New Padding(5)
        txtOutCustomerName.Name = "txtOutCustomerName"
        txtOutCustomerName.Size = New Size(403, 25)
        txtOutCustomerName.TabIndex = 23
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 7.8F)
        Label15.Location = New Point(44, 468)
        Label15.Margin = New Padding(5, 0, 5, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(119, 30)
        Label15.TabIndex = 25
        Label15.Text = "Event Date:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 7.8F)
        Label14.Location = New Point(44, 383)
        Label14.Margin = New Padding(5, 0, 5, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(187, 30)
        Label14.TabIndex = 24
        Label14.Text = "Number of Guests:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 7.8F)
        Label12.Location = New Point(44, 298)
        Label12.Margin = New Padding(5, 0, 5, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 30)
        Label12.TabIndex = 22
        Label12.Text = "Event:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Label13.Location = New Point(225, 26)
        Label13.Margin = New Padding(5, 0, 5, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(275, 31)
        Label13.TabIndex = 18
        Label13.Text = "Find an Event Place"
        ' 
        ' cmbEvents
        ' 
        cmbEvents.Font = New Font("Microsoft Sans Serif", 8F)
        cmbEvents.FormattingEnabled = True
        cmbEvents.Location = New Point(44, 330)
        cmbEvents.Margin = New Padding(5)
        cmbEvents.Name = "cmbEvents"
        cmbEvents.Size = New Size(682, 33)
        cmbEvents.TabIndex = 13
        ' 
        ' txtInGuestCount
        ' 
        txtInGuestCount.Font = New Font("Microsoft Sans Serif", 8F)
        txtInGuestCount.Location = New Point(44, 415)
        txtInGuestCount.Margin = New Padding(5)
        txtInGuestCount.Name = "txtInGuestCount"
        txtInGuestCount.Size = New Size(682, 32)
        txtInGuestCount.TabIndex = 12
        ' 
        ' CustomerDetails
        ' 
        AutoScaleDimensions = New SizeF(192F, 192F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.BG___Form2
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1584, 989)
        Controls.Add(pnlEventPlaceDetails)
        Controls.Add(pnlCustDetails)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        MaximizeBox = False
        Name = "CustomerDetails"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChiNoms Event place"
        pnlCustDetails.ResumeLayout(False)
        pnlCustDetails.PerformLayout()
        pnlEventPlaceDetails.ResumeLayout(False)
        pnlEventPlaceDetails.PerformLayout()
        pnlCustIDName.ResumeLayout(False)
        pnlCustIDName.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCustDetails As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtInCustomerName As TextBox
    Friend WithEvents txtInCustomerID As TextBox
    Friend WithEvents pnlEventPlaceDetails As Panel
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtInMobile As TextBox
    Friend WithEvents txtInAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEvents As ComboBox
    Friend WithEvents txtInGuestCount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOutCustomerName As TextBox
    Friend WithEvents txtOutCustomerID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pnlCustIDName As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents dtpEventDate As DateTimePicker
    Friend WithEvents ratingTrackBar As TrackBar
    Friend WithEvents btnSearchVenue As RoundedButton
    Private WithEvents btnResetCustomer As RoundedButton
    Friend WithEvents btnSaveCustomer As RoundedButton
End Class
