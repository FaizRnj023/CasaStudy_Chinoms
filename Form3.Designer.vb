<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        picMMJH = New RoundedPictureBox()
        picMM = New RoundedPictureBox()
        Label7 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        picLL = New RoundedPictureBox()
        btnViewDetailsMMJH = New RoundedButton()
        btnViewDetailsMM = New RoundedButton()
        btnViewDetailsLL = New RoundedButton()
        Label1 = New Label()
        Label17 = New Label()
        btnBack = New RoundedButton()
        Panel1.SuspendLayout()
        CType(picMMJH, ComponentModel.ISupportInitialize).BeginInit()
        CType(picMM, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLL, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(picMMJH)
        Panel1.Controls.Add(picMM)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(picLL)
        Panel1.Controls.Add(btnViewDetailsMMJH)
        Panel1.Controls.Add(btnViewDetailsMM)
        Panel1.Controls.Add(btnViewDetailsLL)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(6, 119)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(960, 488)
        Panel1.TabIndex = 46
        ' 
        ' picMMJH
        ' 
        picMMJH.BackColor = Color.Transparent
        picMMJH.CornerRadius = 30
        picMMJH.Image = My.Resources.Resources.Hall
        picMMJH.ImeMode = ImeMode.NoControl
        picMMJH.Location = New Point(657, 41)
        picMMJH.Margin = New Padding(2)
        picMMJH.Name = "picMMJH"
        picMMJH.Size = New Size(276, 246)
        picMMJH.TabIndex = 87
        picMMJH.TabStop = False
        ' 
        ' picMM
        ' 
        picMM.BackColor = Color.Transparent
        picMM.CornerRadius = 30
        picMM.Image = My.Resources.Resources.Moonbeam_Meadows
        picMM.ImeMode = ImeMode.NoControl
        picMM.Location = New Point(342, 41)
        picMM.Margin = New Padding(2)
        picMM.Name = "picMM"
        picMM.Size = New Size(276, 246)
        picMM.TabIndex = 86
        picMM.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold)
        Label7.ForeColor = Color.MidnightBlue
        Label7.Location = New Point(723, 302)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 15)
        Label7.TabIndex = 85
        Label7.Text = "MILESTONE MONOR'S"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Microsoft Sans Serif", 7F)
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(703, 353)
        Label3.Name = "Label3"
        Label3.Size = New Size(189, 30)
        Label3.TabIndex = 84
        Label3.Text = "Celebrate beneath a breathtaking" & vbCrLf & "canopy of twinkling fairy lights."
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold)
        Label6.ForeColor = Color.MidnightBlue
        Label6.Location = New Point(722, 319)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 24)
        Label6.TabIndex = 83
        Label6.Text = "JUBILEE HALL"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Microsoft Sans Serif", 7F)
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(375, 347)
        Label4.Name = "Label4"
        Label4.Size = New Size(212, 30)
        Label4.TabIndex = 82
        Label4.Text = "Perfect for tranquil outdoor gatherings" & vbCrLf & "surrounded by nature."
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold)
        Label5.ForeColor = Color.MidnightBlue
        Label5.Location = New Point(361, 312)
        Label5.Name = "Label5"
        Label5.Size = New Size(245, 24)
        Label5.TabIndex = 81
        Label5.Text = "MOONBEAM MEADOWS"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Microsoft Sans Serif", 7F)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(63, 347)
        Label2.Name = "Label2"
        Label2.Size = New Size(212, 30)
        Label2.TabIndex = 80
        Label2.Text = "Set the pulse of your evening with" & vbCrLf & "sleek lighting and chic lounge energy."
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLL
        ' 
        picLL.BackColor = Color.Transparent
        picLL.CornerRadius = 30
        picLL.Image = My.Resources.Resources.Liquid_Lounge
        picLL.ImeMode = ImeMode.NoControl
        picLL.Location = New Point(25, 38)
        picLL.Margin = New Padding(2)
        picLL.Name = "picLL"
        picLL.Size = New Size(276, 246)
        picLL.TabIndex = 79
        picLL.TabStop = False
        ' 
        ' btnViewDetailsMMJH
        ' 
        btnViewDetailsMMJH.BackColor = Color.Transparent
        btnViewDetailsMMJH.BorderColor = Color.MidnightBlue
        btnViewDetailsMMJH.BorderThickness = 2
        btnViewDetailsMMJH.CornerRadius = 12
        btnViewDetailsMMJH.FillColor = Color.Transparent
        btnViewDetailsMMJH.FlatAppearance.BorderSize = 0
        btnViewDetailsMMJH.FlatStyle = FlatStyle.Flat
        btnViewDetailsMMJH.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold)
        btnViewDetailsMMJH.ForeColor = Color.MidnightBlue
        btnViewDetailsMMJH.HoverColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btnViewDetailsMMJH.ImeMode = ImeMode.NoControl
        btnViewDetailsMMJH.Location = New Point(721, 403)
        btnViewDetailsMMJH.Margin = New Padding(2)
        btnViewDetailsMMJH.Name = "btnViewDetailsMMJH"
        btnViewDetailsMMJH.PressedColor = Color.FromArgb(CByte(225), CByte(225), CByte(235))
        btnViewDetailsMMJH.Size = New Size(143, 38)
        btnViewDetailsMMJH.TabIndex = 78
        btnViewDetailsMMJH.Text = "View details"
        btnViewDetailsMMJH.UseVisualStyleBackColor = False
        ' 
        ' btnViewDetailsMM
        ' 
        btnViewDetailsMM.BackColor = Color.Transparent
        btnViewDetailsMM.BorderColor = Color.MidnightBlue
        btnViewDetailsMM.BorderThickness = 2
        btnViewDetailsMM.CornerRadius = 12
        btnViewDetailsMM.FillColor = Color.Transparent
        btnViewDetailsMM.FlatAppearance.BorderSize = 0
        btnViewDetailsMM.FlatStyle = FlatStyle.Flat
        btnViewDetailsMM.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold)
        btnViewDetailsMM.ForeColor = Color.MidnightBlue
        btnViewDetailsMM.HoverColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btnViewDetailsMM.ImeMode = ImeMode.NoControl
        btnViewDetailsMM.Location = New Point(404, 397)
        btnViewDetailsMM.Margin = New Padding(2)
        btnViewDetailsMM.Name = "btnViewDetailsMM"
        btnViewDetailsMM.PressedColor = Color.FromArgb(CByte(225), CByte(225), CByte(235))
        btnViewDetailsMM.Size = New Size(143, 38)
        btnViewDetailsMM.TabIndex = 77
        btnViewDetailsMM.Text = "View details"
        btnViewDetailsMM.UseVisualStyleBackColor = False
        ' 
        ' btnViewDetailsLL
        ' 
        btnViewDetailsLL.BackColor = Color.Transparent
        btnViewDetailsLL.BorderColor = Color.MidnightBlue
        btnViewDetailsLL.BorderThickness = 2
        btnViewDetailsLL.CornerRadius = 12
        btnViewDetailsLL.FillColor = Color.Transparent
        btnViewDetailsLL.FlatAppearance.BorderSize = 0
        btnViewDetailsLL.FlatStyle = FlatStyle.Flat
        btnViewDetailsLL.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold)
        btnViewDetailsLL.ForeColor = Color.MidnightBlue
        btnViewDetailsLL.HoverColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btnViewDetailsLL.ImeMode = ImeMode.NoControl
        btnViewDetailsLL.Location = New Point(88, 397)
        btnViewDetailsLL.Margin = New Padding(2)
        btnViewDetailsLL.Name = "btnViewDetailsLL"
        btnViewDetailsLL.PressedColor = Color.FromArgb(CByte(225), CByte(225), CByte(235))
        btnViewDetailsLL.Size = New Size(143, 38)
        btnViewDetailsLL.TabIndex = 76
        btnViewDetailsLL.Text = "View details"
        btnViewDetailsLL.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(57, 312)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 24)
        Label1.TabIndex = 47
        Label1.Text = "THE LIQUID LOUNGE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft Sans Serif", 14F)
        Label17.ForeColor = Color.FromArgb(CByte(250), CByte(247), CByte(240))
        Label17.Location = New Point(241, 56)
        Label17.Name = "Label17"
        Label17.Size = New Size(479, 29)
        Label17.TabIndex = 32
        Label17.Text = "CHOOSE THE VENUE FOR YOUR EVENT"
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
        btnBack.Font = New Font("Microsoft Sans Serif", 8F)
        btnBack.ForeColor = Color.White
        btnBack.HoverColor = Color.FromArgb(CByte(52), CByte(68), CByte(107))
        btnBack.ImeMode = ImeMode.NoControl
        btnBack.Location = New Point(31, 56)
        btnBack.Margin = New Padding(2)
        btnBack.Name = "btnBack"
        btnBack.PressedColor = Color.FromArgb(CByte(20), CByte(28), CByte(48))
        btnBack.Size = New Size(92, 29)
        btnBack.TabIndex = 68
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.BG___Logo_w_Header_room
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(975, 618)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(Label17)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form3"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChiNoms Event place"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picMMJH, ComponentModel.ISupportInitialize).EndInit()
        CType(picMM, ComponentModel.ISupportInitialize).EndInit()
        CType(picLL, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents btnViewM As Button
    Friend WithEvents btnViewDetails_MM As Button
    Friend WithEvents Label1 As Label
    Private WithEvents btnViewDetailsLL As RoundedButton
    Private WithEvents btnViewDetailsMMJH As RoundedButton
    Private WithEvents btnViewDetailsMM As RoundedButton
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents Label2 As Label
    Friend WithEvents picLL As RoundedPictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picMM As RoundedPictureBox
    Friend WithEvents picMMJH As RoundedPictureBox
    Friend WithEvents Label7 As Label
End Class
