<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        tlpAddOnServices = New TableLayoutPanel()
        Label3 = New Label()
        Label2 = New Label()
        lbl = New Label()
        btnConfirm = New RoundedButton()
        Label17 = New Label()
        btnBack = New RoundedButton()
        Panel1.SuspendLayout()
        tlpAddOnServices.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(tlpAddOnServices)
        Panel1.Controls.Add(btnConfirm)
        Panel1.Location = New Point(10, 190)
        Panel1.Margin = New Padding(5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1560, 780)
        Panel1.TabIndex = 49
        ' 
        ' tlpAddOnServices
        ' 
        tlpAddOnServices.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tlpAddOnServices.ColumnCount = 3
        tlpAddOnServices.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        tlpAddOnServices.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33334F))
        tlpAddOnServices.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        tlpAddOnServices.Controls.Add(Label3, 2, 0)
        tlpAddOnServices.Controls.Add(Label2, 1, 0)
        tlpAddOnServices.Controls.Add(lbl, 0, 0)
        tlpAddOnServices.Font = New Font("Inter Display Medium", 8F)
        tlpAddOnServices.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        tlpAddOnServices.Location = New Point(37, 19)
        tlpAddOnServices.Name = "tlpAddOnServices"
        tlpAddOnServices.Padding = New Padding(3)
        tlpAddOnServices.RowCount = 12
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333334F))
        tlpAddOnServices.Size = New Size(1488, 645)
        tlpAddOnServices.TabIndex = 67
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Inter Display ExtraBold", 8F)
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(995, 4)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 26)
        Label3.TabIndex = 50
        Label3.Text = "PRICE per 50 pax"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Inter Display ExtraBold", 8F)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(502, 4)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 26)
        Label2.TabIndex = 49
        Label2.Text = "INSTRUCTIONS"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.FlatStyle = FlatStyle.Flat
        lbl.Font = New Font("Inter Display ExtraBold", 8F)
        lbl.ForeColor = Color.MidnightBlue
        lbl.Location = New Point(9, 4)
        lbl.Margin = New Padding(5, 0, 5, 0)
        lbl.Name = "lbl"
        lbl.Size = New Size(107, 26)
        lbl.TabIndex = 48
        lbl.Text = "SERVICE"
        lbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.Transparent
        btnConfirm.BorderColor = Color.Empty
        btnConfirm.BorderThickness = 2
        btnConfirm.CornerRadius = 12
        btnConfirm.FillColor = Color.MidnightBlue
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Inter Display", 8F, FontStyle.Bold)
        btnConfirm.ForeColor = Color.White
        btnConfirm.HoverColor = Color.FromArgb(CByte(45), CByte(45), CByte(140))
        btnConfirm.ImeMode = ImeMode.NoControl
        btnConfirm.Location = New Point(609, 693)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.PressedColor = Color.FromArgb(CByte(15), CByte(15), CByte(80))
        btnConfirm.Size = New Size(349, 61)
        btnConfirm.TabIndex = 66
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Cinzel Black", 14F)
        Label17.ForeColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        Label17.Location = New Point(486, 90)
        Label17.Margin = New Padding(5, 0, 5, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(605, 51)
        Label17.TabIndex = 47
        Label17.Text = "ADD-ON SERVICE PACKAGES"
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
        btnBack.TabIndex = 67
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(192F, 192F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackgroundImage = My.Resources.Resources.BG___Logo_w_Header_room
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1584, 989)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(Label17)
        ForeColor = SystemColors.ControlText
        Margin = New Padding(5)
        Name = "Form7"
        ShowIcon = False
        Text = "ChiNoms Event place"
        Panel1.ResumeLayout(False)
        tlpAddOnServices.ResumeLayout(False)
        tlpAddOnServices.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents btnConfirm As RoundedButton
    Friend WithEvents tlpAddOnServices As TableLayoutPanel
    Friend WithEvents lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
