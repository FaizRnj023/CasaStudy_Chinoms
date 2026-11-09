Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundedTextBox
    Inherits UserControl

    Private WithEvents inner As New TextBox()
    Private _radius As Integer = 10
    Private _fill As Color = Color.White
    Private _border As Color = Color.Silver
    Private _focusBorder As Color = Color.FromArgb(31, 42, 68)
    Private _focused As Boolean = False

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
        inner.BorderStyle = BorderStyle.None
        inner.BackColor = _fill
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        Controls.Add(inner)
        Size = New Size(220, 36)
        LayoutInner()
    End Sub

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CornerRadius As Integer
        Get
            Return _radius
        End Get
        Set(value As Integer)
            _radius = value
            LayoutInner()
            Invalidate()
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property FillColor As Color
        Get
            Return _fill
        End Get
        Set(value As Color)
            _fill = value
            inner.BackColor = value
            Invalidate()
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderColor As Color
        Get
            Return _border
        End Get
        Set(value As Color)
            _border = value
            Invalidate()
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property FocusBorderColor As Color
        Get
            Return _focusBorder
        End Get
        Set(value As Color)
            _focusBorder = value
            Invalidate()
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property PlaceholderText As String
        Get
            Return inner.PlaceholderText
        End Get
        Set(value As String)
            inner.PlaceholderText = value
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property Text As String
        Get
            Return inner.Text
        End Get
        Set(value As String)
            inner.Text = value
        End Set
    End Property

    Private Sub LayoutInner()
        Dim pad As Integer = Math.Max(8, _radius)
        inner.Left = pad
        inner.Width = Math.Max(10, Width - pad * 2)
        inner.Top = (Height - inner.Height) \ 2
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        LayoutInner()
    End Sub

    Protected Overrides Sub OnFontChanged(e As EventArgs)
        MyBase.OnFontChanged(e)
        inner.Font = Font
        LayoutInner()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        inner.Focus()
    End Sub

    Private Sub inner_Enter(sender As Object, e As EventArgs) Handles inner.Enter
        _focused = True
        Invalidate()
    End Sub

    Private Sub inner_Leave(sender As Object, e As EventArgs) Handles inner.Leave
        _focused = False
        Invalidate()
    End Sub

    Private Sub inner_TextChanged(sender As Object, e As EventArgs) Handles inner.TextChanged
        OnTextChanged(e)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        MyBase.OnPaintBackground(e)
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim d As Integer = Math.Min(_radius * 2, Math.Min(Width, Height) - 1)
        Dim r As New Rectangle(0, 0, Width - 1, Height - 1)

        Using path As New GraphicsPath()
            path.AddArc(r.X, r.Y, d, d, 180, 90)
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
            path.CloseFigure()

            Using b As New SolidBrush(_fill)
                g.FillPath(b, path)
            End Using
            Using p As New Pen(If(_focused, _focusBorder, _border), 1)
                g.DrawPath(p, path)
            End Using
        End Using
    End Sub
End Class