Imports System.Drawing.Drawing2D
Module UIHelper
        Public Sub RoundCorners(ctrl As Control, radius As Integer)
            Dim d As Integer = radius * 2
            Dim path As New GraphicsPath()
            path.AddArc(0, 0, d, d, 180, 90)
            path.AddArc(ctrl.Width - d, 0, d, d, 270, 90)
            path.AddArc(ctrl.Width - d, ctrl.Height - d, d, d, 0, 90)
            path.AddArc(0, ctrl.Height - d, d, d, 90, 90)
            path.CloseFigure()
            ctrl.Region = New Region(path)
        End Sub
    End Module
