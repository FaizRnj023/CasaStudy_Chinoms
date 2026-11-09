<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LandingPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LandingPage))
        btnViewBooking = New RoundedButton()
        btnBookEventPlace = New RoundedButton()
        SuspendLayout()
        ' 
        ' btnViewBooking
        ' 
        btnViewBooking.BackColor = Color.FromArgb(CByte(251), CByte(247), CByte(240))
        btnViewBooking.BorderColor = Color.MidnightBlue
        btnViewBooking.BorderThickness = 2
        btnViewBooking.CornerRadius = 12
        btnViewBooking.FillColor = Color.FromArgb(CByte(251), CByte(247), CByte(240))
        btnViewBooking.FlatAppearance.BorderSize = 0
        btnViewBooking.FlatStyle = FlatStyle.Flat
        btnViewBooking.Font = New Font("Inter Display", 8.0F, FontStyle.Bold)
        btnViewBooking.ForeColor = Color.MidnightBlue
        btnViewBooking.HoverColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btnViewBooking.ImeMode = ImeMode.NoControl
        btnViewBooking.Location = New Point(419, 723)
        btnViewBooking.Name = "btnViewBooking"
        btnViewBooking.PressedColor = Color.FromArgb(CByte(225), CByte(225), CByte(235))
        btnViewBooking.Size = New Size(338, 74)
        btnViewBooking.TabIndex = 75
        btnViewBooking.Text = "View booking details"
        btnViewBooking.UseVisualStyleBackColor = False
        ' 
        ' btnBookEventPlace
        ' 
        btnBookEventPlace.BackColor = Color.Transparent
        btnBookEventPlace.BorderColor = Color.Empty
        btnBookEventPlace.BorderThickness = 2
        btnBookEventPlace.CornerRadius = 12
        btnBookEventPlace.FillColor = Color.MidnightBlue
        btnBookEventPlace.FlatAppearance.BorderSize = 0
        btnBookEventPlace.FlatStyle = FlatStyle.Flat
        btnBookEventPlace.Font = New Font("Inter Display", 8.0F, FontStyle.Bold)
        btnBookEventPlace.ForeColor = Color.White
        btnBookEventPlace.HoverColor = Color.FromArgb(CByte(45), CByte(45), CByte(140))
        btnBookEventPlace.ImeMode = ImeMode.NoControl
        btnBookEventPlace.Location = New Point(830, 723)
        btnBookEventPlace.Name = "btnBookEventPlace"
        btnBookEventPlace.PressedColor = Color.FromArgb(CByte(15), CByte(15), CByte(80))
        btnBookEventPlace.Size = New Size(338, 74)
        btnBookEventPlace.TabIndex = 74
        btnBookEventPlace.Text = "Book an event place"
        btnBookEventPlace.UseVisualStyleBackColor = False
        ' 
        ' LandingPage
        ' 
        AutoScaleDimensions = New SizeF(192F, 192F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.BG___Splash
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1584, 989)
        Controls.Add(btnViewBooking)
        Controls.Add(btnBookEventPlace)
        DoubleBuffered = True
        ForeColor = Color.DarkCyan
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 5, 5, 5)
        Name = "LandingPage"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChiNoms Event place"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnBook As Button
    Friend WithEvents btnViewBooking As RoundedButton
    Friend WithEvents btnBookEventPlace As RoundedButton

End Class
