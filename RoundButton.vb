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

        Dim d As Integer = Math.Min(CornerRadius * 2, Math.Min(Width, Height) - 1)
        Dim rect As New Rectangle(0, 0, Width - 1, Height - 1)

        Using path As New GraphicsPath()
            path.AddArc(rect.X, rect.Y, d, d, 180, 90)
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
            path.CloseFigure()

            Dim current As Color = FillColor
            If _pressed Then
                current = PressedColor
            ElseIf _hovering Then
                current = HoverColor
            End If

            Using b As New SolidBrush(current)
                g.FillPath(b, path)
            End Using

            If BorderColor <> Color.Empty Then
                Using p As New Pen(BorderColor, BorderThickness)
                    g.DrawPath(p, path)
                End Using
            End If
        End Using

        TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub
End Class