Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CornerRadius As Integer = 12

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property FillColor As Color = Color.FromArgb(31, 42, 68)

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderColor As Color = Color.Empty

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderThickness As Integer = 2

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property HoverColor As Color = Color.FromArgb(52, 68, 107)

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property PressedColor As Color = Color.FromArgb(20, 28, 48)

    Private _hovering As Boolean = False
    Private _pressed As Boolean = False

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _hovering = True
        Cursor = Cursors.Hand
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _hovering = False
        _pressed = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        _pressed = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        _pressed = False
        Invalidate()
    End Sub

    Public Sub New()
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        ForeColor = Color.White
        SetStyle(ControlStyles.UserPaint Or
                 ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        MyBase.OnPaintBackground(e)
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim current As Color = FillColor
        If _pressed Then
            current = PressedColor
        ElseIf _hovering Then
            current = HoverColor
        End If

        Dim diameter As Single = Math.Min(CornerRadius * 2.0F, Math.Min(Width, Height))

        ' The fill covers the whole control.
        Using path As GraphicsPath = RoundedPath(New RectangleF(0, 0, Width, Height), diameter)
            Using b As New SolidBrush(current)
                g.FillPath(b, path)
            End Using
        End Using

        ' The border is drawn on a path inset by half its thickness,
        ' so all four sides are exactly BorderThickness pixels wide.
        If BorderColor <> Color.Empty AndAlso BorderThickness > 0 Then
            Dim t As Single = BorderThickness
            Dim inset As New RectangleF(t / 2.0F, t / 2.0F, Width - t, Height - t)
            Using borderPath As GraphicsPath = RoundedPath(inset, Math.Max(0F, diameter - t))
                Using p As New Pen(BorderColor, t)
                    g.DrawPath(p, borderPath)
                End Using
            End Using
        End If

        TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
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