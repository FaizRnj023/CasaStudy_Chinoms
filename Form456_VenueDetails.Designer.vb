<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form456_VenueDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form456_VenueDetails))
        Panel1 = New Panel()
        picLL = New RoundedPictureBox()
        btnBookVenue = New RoundedButton()
        Label19 = New Label()
        Panel2 = New Panel()
        txtMaxCapacity = New TextBox()
        txtAddress = New TextBox()
        txtType = New TextBox()
        txtPlaceID = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        lblPricePerPday = New Label()
        Label2 = New Label()
        lblTypesOfEvents = New Label()
        lblFeatures = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        lblStarsSpaceAndClean = New Label()
        lblStarsService = New Label()
        Label14 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        lblVenue = New Label()
        btnBack = New RoundedButton()
        Panel1.SuspendLayout()
        CType(picLL, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(picLL)
        Panel1.Controls.Add(btnBookVenue)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(lblStarsSpaceAndClean)
        Panel1.Controls.Add(lblStarsService)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label13)
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Name = "Panel1"
        ' 
        ' picLL
        ' 
        picLL.BackColor = Color.Transparent
        picLL.CornerRadius = 24
        picLL.Image = My.Resources.Resources.Liquid_Lounge
        resources.ApplyResources(picLL, "picLL")
        picLL.Name = "picLL"
        picLL.TabStop = False
        ' 
        ' btnBookVenue
        ' 
        btnBookVenue.BackColor = Color.Transparent
        btnBookVenue.BorderColor = Color.Empty
        btnBookVenue.BorderThickness = 2
        btnBookVenue.CornerRadius = 12
        btnBookVenue.FillColor = Color.MidnightBlue
        btnBookVenue.FlatAppearance.BorderSize = 0
        resources.ApplyResources(btnBookVenue, "btnBookVenue")
        btnBookVenue.ForeColor = Color.White
        btnBookVenue.HoverColor = Color.FromArgb(CByte(45), CByte(45), CByte(140))
        btnBookVenue.Name = "btnBookVenue"
        btnBookVenue.PressedColor = Color.FromArgb(CByte(15), CByte(15), CByte(80))
        btnBookVenue.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        resources.ApplyResources(Label19, "Label19")
        Label19.ForeColor = Color.Goldenrod
        Label19.Name = "Label19"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(txtMaxCapacity)
        Panel2.Controls.Add(txtAddress)
        Panel2.Controls.Add(txtType)
        Panel2.Controls.Add(txtPlaceID)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(lblPricePerPday)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lblTypesOfEvents)
        Panel2.Controls.Add(lblFeatures)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label4)
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' txtMaxCapacity
        ' 
        resources.ApplyResources(txtMaxCapacity, "txtMaxCapacity")
        txtMaxCapacity.Name = "txtMaxCapacity"
        ' 
        ' txtAddress
        ' 
        resources.ApplyResources(txtAddress, "txtAddress")
        txtAddress.Name = "txtAddress"
        ' 
        ' txtType
        ' 
        resources.ApplyResources(txtType, "txtType")
        txtType.Name = "txtType"
        ' 
        ' txtPlaceID
        ' 
        resources.ApplyResources(txtPlaceID, "txtPlaceID")
        txtPlaceID.Name = "txtPlaceID"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.ForeColor = Color.MidnightBlue
        Label3.Name = "Label3"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = Color.Black
        Label1.Name = "Label1"
        ' 
        ' Label6
        ' 
        resources.ApplyResources(Label6, "Label6")
        Label6.ForeColor = Color.Black
        Label6.Name = "Label6"
        ' 
        ' Label8
        ' 
        resources.ApplyResources(Label8, "Label8")
        Label8.ForeColor = Color.Black
        Label8.Name = "Label8"
        ' 
        ' lblPricePerPday
        ' 
        resources.ApplyResources(lblPricePerPday, "lblPricePerPday")
        lblPricePerPday.ForeColor = Color.Black
        lblPricePerPday.Name = "lblPricePerPday"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.ForeColor = Color.Black
        Label2.Name = "Label2"
        ' 
        ' lblTypesOfEvents
        ' 
        resources.ApplyResources(lblTypesOfEvents, "lblTypesOfEvents")
        lblTypesOfEvents.ForeColor = Color.Black
        lblTypesOfEvents.Name = "lblTypesOfEvents"
        ' 
        ' lblFeatures
        ' 
        resources.ApplyResources(lblFeatures, "lblFeatures")
        lblFeatures.ForeColor = Color.Black
        lblFeatures.Name = "lblFeatures"
        ' 
        ' Label9
        ' 
        resources.ApplyResources(Label9, "Label9")
        Label9.ForeColor = Color.MidnightBlue
        Label9.Name = "Label9"
        ' 
        ' Label7
        ' 
        resources.ApplyResources(Label7, "Label7")
        Label7.ForeColor = Color.MidnightBlue
        Label7.Name = "Label7"
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.ForeColor = Color.MidnightBlue
        Label4.Name = "Label4"
        ' 
        ' lblStarsSpaceAndClean
        ' 
        resources.ApplyResources(lblStarsSpaceAndClean, "lblStarsSpaceAndClean")
        lblStarsSpaceAndClean.ForeColor = Color.Goldenrod
        lblStarsSpaceAndClean.Name = "lblStarsSpaceAndClean"
        ' 
        ' lblStarsService
        ' 
        resources.ApplyResources(lblStarsService, "lblStarsService")
        lblStarsService.ForeColor = Color.Goldenrod
        lblStarsService.Name = "lblStarsService"
        ' 
        ' Label14
        ' 
        resources.ApplyResources(Label14, "Label14")
        Label14.ForeColor = Color.Black
        Label14.Name = "Label14"
        ' 
        ' Label12
        ' 
        resources.ApplyResources(Label12, "Label12")
        Label12.ForeColor = Color.Black
        Label12.Name = "Label12"
        ' 
        ' Label13
        ' 
        resources.ApplyResources(Label13, "Label13")
        Label13.ForeColor = Color.Black
        Label13.Name = "Label13"
        ' 
        ' lblVenue
        ' 
        resources.ApplyResources(lblVenue, "lblVenue")
        lblVenue.BackColor = Color.Transparent
        lblVenue.ForeColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        lblVenue.Name = "lblVenue"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(28), CByte(42), CByte(65))
        btnBack.BorderColor = Color.White
        btnBack.BorderThickness = 2
        btnBack.CornerRadius = 12
        btnBack.FillColor = Color.FromArgb(CByte(28), CByte(42), CByte(65))
        btnBack.FlatAppearance.BorderSize = 0
        resources.ApplyResources(btnBack, "btnBack")
        btnBack.ForeColor = Color.White
        btnBack.HoverColor = Color.FromArgb(CByte(52), CByte(68), CByte(107))
        btnBack.Name = "btnBack"
        btnBack.PressedColor = Color.FromArgb(CByte(20), CByte(28), CByte(48))
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Form4_VenuDetails
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Dpi
        BackgroundImage = My.Resources.Resources.BG___Logo_w_Header_room
        Controls.Add(btnBack)
        Controls.Add(lblVenue)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "Form456_VenueDetails"
        ShowIcon = False
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picLL, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTypesOfEvents As Label
    Friend WithEvents lblFeatures As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaxCapacity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPricePerPday As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStarsService As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents lblStarsSpaceAndClean As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents btnBookVenue As RoundedButton
    Friend WithEvents picLL As RoundedPictureBox
    Friend WithEvents txtPlaceID As TextBox
End Class
