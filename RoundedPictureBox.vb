Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundedPictureBox
    Inherits PictureBox

    Private _radius As Integer = 18

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CornerRadius As Integer
        Get
            Return _radius
        End Get
        Set(value As Integer)
            _radius = value
            UpdateRegion()
            Invalidate()
        End Set
    End Property

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        UpdateRegion()
    End Sub

    Private Sub UpdateRegion()
        If Width < 2 OrElse Height < 2 Then Return
        Dim d As Integer = Math.Min(_radius * 2, Math.Min(Width, Height))
        Dim r As New Rectangle(0, 0, Width, Height)

        Using path As New GraphicsPath()
            path.AddArc(r.X, r.Y, d, d, 180, 90)
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
            path.CloseFigure()

            ' Physically clips the control's window region to remove the square corners
            Me.Region = New Region(path)
        End Using
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.InterpolationMode = InterpolationMode.HighQualityBicubic

        If Image Is Nothing OrElse Width < 2 OrElse Height < 2 Then Return

        ' Draw the scaled image maintaining aspect ratio (Zoom mode)
        Dim imgWidth As Single = Image.Width
        Dim imgHeight As Single = Image.Height
        Dim ratio As Single = Math.Max(Width / imgWidth, Height / imgHeight)
        Dim w As Integer = CInt(imgWidth * ratio)
        Dim h As Integer = CInt(imgHeight * ratio)
        Dim x As Integer = (Width - w) \ 2
        Dim y As Integer = (Height - h) \ 2

        g.DrawImage(Image, x, y, w, h)
    End Sub
End Class