<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Panel3 = New Panel()
        groupBreakdown = New GroupBox()
        Label32 = New Label()
        tlpBreakdown = New TableLayoutPanel()
        Label31 = New Label()
        Label28 = New Label()
        Label26 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        txtCash = New TextBox()
        Label19 = New Label()
        txtTotal = New TextBox()
        Label20 = New Label()
        txtChange = New TextBox()
        txtBookingID = New TextBox()
        groupCustDetails = New GroupBox()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label27 = New Label()
        txtCustID = New TextBox()
        txtCustName = New TextBox()
        txtEventDate = New TextBox()
        txtEventID = New TextBox()
        txtTransactionDate = New TextBox()
        txtTransacDate = New Label()
        Label30 = New Label()
        btnBack = New RoundedButton()
        Label29 = New Label()
        Panel3.SuspendLayout()
        groupBreakdown.SuspendLayout()
        tlpBreakdown.SuspendLayout()
        groupCustDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(groupBreakdown)
        Panel3.Controls.Add(txtBookingID)
        Panel3.Controls.Add(groupCustDetails)
        Panel3.Controls.Add(txtTransactionDate)
        Panel3.Controls.Add(txtTransacDate)
        Panel3.Controls.Add(Label30)
        Panel3.Location = New Point(10, 190)
        Panel3.Margin = New Padding(5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1560, 785)
        Panel3.TabIndex = 73
        ' 
        ' groupBreakdown
        ' 
        groupBreakdown.BackColor = Color.Transparent
        groupBreakdown.Controls.Add(Label32)
        groupBreakdown.Controls.Add(tlpBreakdown)
        groupBreakdown.Controls.Add(txtCash)
        groupBreakdown.Controls.Add(Label19)
        groupBreakdown.Controls.Add(txtTotal)
        groupBreakdown.Controls.Add(Label20)
        groupBreakdown.Controls.Add(txtChange)
        groupBreakdown.FlatStyle = FlatStyle.Flat
        groupBreakdown.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        groupBreakdown.Location = New Point(22, 281)
        groupBreakdown.Name = "groupBreakdown"
        groupBreakdown.Size = New Size(1518, 477)
        groupBreakdown.TabIndex = 77
        groupBreakdown.TabStop = False
        groupBreakdown.Text = "Breakdown of Fees"
        ' 
        ' Label32
        ' 
        Label32.Font = New Font("Inter Display Medium", 8F)
        Label32.Location = New Point(1140, 403)
        Label32.Margin = New Padding(5, 0, 5, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(121, 30)
        Label32.TabIndex = 79
        Label32.Text = "Change:"
        Label32.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tlpBreakdown
        ' 
        tlpBreakdown.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tlpBreakdown.ColumnCount = 5
        tlpBreakdown.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpBreakdown.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpBreakdown.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpBreakdown.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpBreakdown.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpBreakdown.Controls.Add(Label31, 4, 0)
        tlpBreakdown.Controls.Add(Label28, 3, 0)
        tlpBreakdown.Controls.Add(Label26, 2, 0)
        tlpBreakdown.Controls.Add(Label22, 1, 0)
        tlpBreakdown.Controls.Add(Label21, 0, 0)
        tlpBreakdown.Location = New Point(23, 43)
        tlpBreakdown.Name = "tlpBreakdown"
        tlpBreakdown.RowCount = 3
        tlpBreakdown.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        tlpBreakdown.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        tlpBreakdown.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        tlpBreakdown.Size = New Size(1468, 208)
        tlpBreakdown.TabIndex = 0
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        Label31.Location = New Point(1178, 6)
        Label31.Margin = New Padding(5)
        Label31.Name = "Label31"
        Label31.Size = New Size(94, 26)
        Label31.TabIndex = 13
        Label31.Text = "Amount"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        Label28.Location = New Point(885, 6)
        Label28.Margin = New Padding(5)
        Label28.Name = "Label28"
        Label28.Size = New Size(140, 26)
        Label28.TabIndex = 12
        Label28.Text = "Surcharge"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        Label26.Location = New Point(592, 6)
        Label26.Margin = New Padding(5)
        Label26.Name = "Label26"
        Label26.Size = New Size(132, 26)
        Label26.TabIndex = 11
        Label26.Text = "Price Rate"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        Label22.Location = New Point(299, 6)
        Label22.Margin = New Padding(5)
        Label22.Name = "Label22"
        Label22.Size = New Size(57, 26)
        Label22.TabIndex = 10
        Label22.Text = "Item"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        Label21.Location = New Point(6, 6)
        Label21.Margin = New Padding(5)
        Label21.Name = "Label21"
        Label21.Size = New Size(106, 26)
        Label21.TabIndex = 9
        Label21.Text = "Category"
        ' 
        ' txtCash
        ' 
        txtCash.BorderStyle = BorderStyle.None
        txtCash.Font = New Font("Inter Display Medium", 8F)
        txtCash.Location = New Point(1286, 354)
        txtCash.Margin = New Padding(5)
        txtCash.Name = "txtCash"
        txtCash.Size = New Size(204, 26)
        txtCash.TabIndex = 78
        txtCash.Text = "₱ "
        ' 
        ' Label19
        ' 
        Label19.Font = New Font("Inter Display", 10F, FontStyle.Bold)
        Label19.Location = New Point(1141, 298)
        Label19.Margin = New Padding(5, 0, 5, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(120, 30)
        Label19.TabIndex = 9
        Label19.Text = "Total:"
        Label19.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtTotal
        ' 
        txtTotal.BorderStyle = BorderStyle.None
        txtTotal.Font = New Font("Inter Display", 10F, FontStyle.Bold)
        txtTotal.Location = New Point(1286, 297)
        txtTotal.Margin = New Padding(5)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(204, 33)
        txtTotal.TabIndex = 26
        txtTotal.Text = "₱ "
        ' 
        ' Label20
        ' 
        Label20.Font = New Font("Inter Display Medium", 8F)
        Label20.Location = New Point(1141, 351)
        Label20.Margin = New Padding(5, 0, 5, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(120, 30)
        Label20.TabIndex = 27
        Label20.Text = "Cash:"
        Label20.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtChange
        ' 
        txtChange.BorderStyle = BorderStyle.None
        txtChange.Font = New Font("Inter Display Medium", 8F)
        txtChange.Location = New Point(1286, 406)
        txtChange.Margin = New Padding(5)
        txtChange.Name = "txtChange"
        txtChange.Size = New Size(204, 26)
        txtChange.TabIndex = 28
        txtChange.Text = "₱ "
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
        ' groupCustDetails
        ' 
        groupCustDetails.BackColor = Color.Transparent
        groupCustDetails.Controls.Add(Label23)
        groupCustDetails.Controls.Add(Label24)
        groupCustDetails.Controls.Add(Label25)
        groupCustDetails.Controls.Add(Label27)
        groupCustDetails.Controls.Add(txtCustID)
        groupCustDetails.Controls.Add(txtCustName)
        groupCustDetails.Controls.Add(txtEventDate)
        groupCustDetails.Controls.Add(txtEventID)
        groupCustDetails.FlatStyle = FlatStyle.Flat
        groupCustDetails.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        groupCustDetails.Location = New Point(22, 89)
        groupCustDetails.Name = "groupCustDetails"
        groupCustDetails.Size = New Size(1518, 146)
        groupCustDetails.TabIndex = 76
        groupCustDetails.TabStop = False
        groupCustDetails.Text = "Customer Details"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Inter Display Medium", 8F)
        Label23.Location = New Point(802, 48)
        Label23.Margin = New Padding(5, 0, 5, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(138, 26)
        Label23.TabIndex = 14
        Label23.Text = "Total Guests:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Inter Display Medium", 8F)
        Label24.Location = New Point(18, 48)
        Label24.Margin = New Padding(5, 0, 5, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(138, 26)
        Label24.TabIndex = 7
        Label24.Text = "Customer ID:"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Inter Display Medium", 8F)
        Label25.Location = New Point(16, 101)
        Label25.Margin = New Padding(5, 0, 5, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(177, 26)
        Label25.TabIndex = 8
        Label25.Text = "Customer Name:"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Inter Display Medium", 8F)
        Label27.Location = New Point(802, 101)
        Label27.Margin = New Padding(5, 0, 5, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(124, 26)
        Label27.TabIndex = 15
        Label27.Text = "Event Date:"
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
        ' txtEventDate
        ' 
        txtEventDate.Font = New Font("Inter Display Medium", 8F)
        txtEventDate.Location = New Point(982, 96)
        txtEventDate.Margin = New Padding(5)
        txtEventDate.Name = "txtEventDate"
        txtEventDate.Size = New Size(509, 33)
        txtEventDate.TabIndex = 25
        ' 
        ' txtEventID
        ' 
        txtEventID.Font = New Font("Inter Display Medium", 8F)
        txtEventID.Location = New Point(982, 42)
        txtEventID.Margin = New Padding(5)
        txtEventID.Name = "txtEventID"
        txtEventID.Size = New Size(509, 33)
        txtEventID.TabIndex = 24
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
        ' txtTransacDate
        ' 
        txtTransacDate.AutoSize = True
        txtTransacDate.Font = New Font("Inter Display Medium", 8F)
        txtTransacDate.Location = New Point(824, 16)
        txtTransacDate.Margin = New Padding(5, 0, 5, 0)
        txtTransacDate.Name = "txtTransacDate"
        txtTransacDate.Size = New Size(182, 26)
        txtTransacDate.TabIndex = 5
        txtTransacDate.Text = "Transaction Date:"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Inter Display Medium", 8F)
        Label30.Location = New Point(42, 20)
        Label30.Margin = New Padding(5, 0, 5, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(121, 26)
        Label30.TabIndex = 4
        Label30.Text = "Booking ID:"
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
        btnBack.Location = New Point(1385, 90)
        btnBack.Name = "btnBack"
        btnBack.PressedColor = Color.FromArgb(CByte(20), CByte(28), CByte(48))
        btnBack.Size = New Size(150, 47)
        btnBack.TabIndex = 74
        btnBack.Text = "Done"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.BackColor = Color.Transparent
        Label29.Font = New Font("Cinzel Black", 14F)
        Label29.ForeColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        Label29.Location = New Point(688, 90)
        Label29.Margin = New Padding(5, 0, 5, 0)
        Label29.Name = "Label29"
        Label29.Size = New Size(203, 51)
        Label29.TabIndex = 75
        Label29.Text = "RECEIPT"
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(192.0F, 192.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackgroundImage = My.Resources.Resources.BG___Logo_w_Header_room
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1584, 989)
        Controls.Add(Label29)
        Controls.Add(btnBack)
        Controls.Add(Panel3)
        Margin = New Padding(5)
        Name = "Form10"
        ShowIcon = False
        Text = "ChiNoms Event place"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        groupBreakdown.ResumeLayout(False)
        groupBreakdown.PerformLayout()
        tlpBreakdown.ResumeLayout(False)
        tlpBreakdown.PerformLayout()
        groupCustDetails.ResumeLayout(False)
        groupCustDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents groupBreakdown As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tlpBreakdown As TableLayoutPanel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents groupCustDetails As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtEventDate As TextBox
    Friend WithEvents txtEventID As TextBox
    Friend WithEvents txtTransactionDate As TextBox
    Friend WithEvents txtTransacDate As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents Label29 As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label32 As Label
End Class
