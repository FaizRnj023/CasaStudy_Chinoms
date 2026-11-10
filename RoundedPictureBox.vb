Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class RoundedPictureBox
    Inherits PictureBox

    Private _radius As Integer = 18
    Private _focusX As Single = 0.5F
    Private _focusY As Single = 0.5F

    ' The photo, already scaled and cropped to the control's size.
    Private _cache As Bitmap
    Private _cacheSource As Image

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CornerRadius As Integer
        Get
            Return _radius
        End Get
        Set(value As Integer)
            _radius = Math.Max(0, value)
            Invalidate()
        End Set
    End Property

    ''' <summary>When the photo has to be cropped to fill the frame, which part is kept:
    ''' 0 = left edge, 0.5 = centre, 1 = right edge.</summary>
    <Browsable(True), DefaultValue(0.5F), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property FocusX As Single
        Get
            Return _focusX
        End Get
        Set(value As Single)
            _focusX = Math.Min(1.0F, Math.Max(0.0F, value))
            DropCache()
            Invalidate()
        End Set
    End Property

    ''' <summary>Same as FocusX for the vertical direction: 0 = top, 0.5 = centre, 1 = bottom.</summary>
    <Browsable(True), DefaultValue(0.5F), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property FocusY As Single
        Get
            Return _focusY
        End Get
        Set(value As Single)
            _focusY = Math.Min(1.0F, Math.Max(0.0F, value))
            DropCache()
            Invalidate()
        End Set
    End Property

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or
                 ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        DropCache()
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then DropCache()
        MyBase.Dispose(disposing)
    End Sub

    Private Sub DropCache()
        If _cache IsNot Nothing Then _cache.Dispose()
        _cache = Nothing
        _cacheSource = Nothing
    End Sub

    ' Scales the photo to fill the control (cropping the overflow) once, instead of on every paint.
    Private Sub BuildCache()
        DropCache()
        If Image Is Nothing OrElse Width < 2 OrElse Height < 2 Then Return

        Dim iw As Single = Image.Width
        Dim ih As Single = Image.Height
        Dim scale As Single = Math.Max(Width / iw, Height / ih)
        Dim srcW As Single = Width / scale
        Dim srcH As Single = Height / scale
        Dim srcX As Single = (iw - srcW) * _focusX
        Dim srcY As Single = (ih - srcH) * _focusY

        _cache = New Bitmap(Width, Height, PixelFormat.Format32bppPArgb)
        Using gc As Graphics = Graphics.FromImage(_cache)
            gc.InterpolationMode = InterpolationMode.HighQualityBicubic
            gc.PixelOffsetMode = PixelOffsetMode.HighQuality
            gc.CompositingQuality = CompositingQuality.HighQuality
            Using ia As New ImageAttributes()
                ia.SetWrapMode(WrapMode.TileFlipXY)
                gc.DrawImage(Image, New Rectangle(0, 0, Width, Height), srcX, srcY, srcW, srcH, GraphicsUnit.Pixel, ia)
            End Using
        End Using
        _cacheSource = Image
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)                       ' shows the page behind the rounded corners
        If Image Is Nothing OrElse Width < 2 OrElse Height < 2 Then Return

        If _cache Is Nothing OrElse Not ReferenceEquals(_cacheSource, Image) Then BuildCache()
        If _cache Is Nothing Then Return

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim d As Single = Math.Min(_radius * 2.0F, Math.Min(Width, Height))
        Using path As GraphicsPath = RoundedPath(New RectangleF(0, 0, Width, Height), d)
            Using br As New TextureBrush(_cache, WrapMode.Clamp)
                g.FillPath(br, path)
            End Using
        End Using
    End Sub

    Private Shared Function RoundedPath(r As RectangleF, d As Single) As GraphicsPath
        Dim p As New GraphicsPath()
        If d <= 0.5F Then
            p.AddRectangle(r)
        Else
            p.AddArc(r.X, r.Y, d, d, 180, 90)
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90)
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
            p.CloseFigure()
        End If
        Return p
    End Function
End Class