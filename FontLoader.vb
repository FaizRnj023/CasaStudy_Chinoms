Imports System.Drawing.Text
Imports System.IO

Public Module FontLoader

    Private Declare Unicode Function AddFontResourceEx Lib "gdi32.dll" Alias "AddFontResourceExW" (
        name As String, fl As UInteger, res As IntPtr) As Integer

    Private Const FR_PRIVATE As UInteger = &H10UI

    ' Must stay alive for the whole run. Never dispose it.
    Private ReadOnly pfc As New PrivateFontCollection()

    Private ReadOnly Needed As String() = {"Inter Display", "Inter Display Medium", "Inter Display SemiBold",
                                           "Inter Display ExtraBold", "Cinzel", "Cinzel Black"}

    Public Sub Load()
        Dim dir As String = Path.Combine(AppContext.BaseDirectory, "Fonts")
        If Not Directory.Exists(dir) Then
            Debug.WriteLine("FontLoader: folder not found: " & dir)
            Return
        End If

        For Each f As String In Directory.EnumerateFiles(dir)
            Select Case Path.GetExtension(f).ToLowerInvariant()
                Case ".ttf", ".otf", ".ttc"
                    If AddFontResourceEx(f, FR_PRIVATE, IntPtr.Zero) = 0 Then
                        Debug.WriteLine("FontLoader: GDI could not register " & f)
                    End If
                    Try
                        pfc.AddFontFile(f)                          ' for GDI+ (creating Font objects)
                    Catch ex As Exception
                        Debug.WriteLine("FontLoader: GDI+ could not load " & f & " - " & ex.Message)
                    End Try
            End Select
        Next
    End Sub

    Public Function FindFamily(name As String) As FontFamily
        For Each fam As FontFamily In pfc.Families
            If String.Equals(fam.Name, name, StringComparison.OrdinalIgnoreCase) Then Return fam
        Next
        Return Nothing
    End Function

    ''' <summary>Like New Font(name, size, style) but uses the bundled file when it has that name.</summary>
    Public Function MakeFont(name As String, size As Single,
                             Optional style As FontStyle = FontStyle.Regular,
                             Optional unit As GraphicsUnit = GraphicsUnit.Point) As Font
        Dim fam As FontFamily = FindFamily(name)
        If fam IsNot Nothing Then
            Dim useStyle As FontStyle = style
            If Not fam.IsStyleAvailable(useStyle) Then
                useStyle = If(fam.IsStyleAvailable(FontStyle.Regular), FontStyle.Regular, FontStyle.Bold)
            End If
            Return New Font(fam, size, useStyle, unit)
        End If
        Return New Font(name, size, style, unit)
    End Function

    ''' <summary>Replaces fonts that fell back (named font not installed) with the bundled one.</summary>
    Public Sub Apply(root As Control)
        Dim nf As Font = Replacement(root.Font)
        If nf IsNot Nothing Then root.Font = nf

        Dim dtp As DateTimePicker = TryCast(root, DateTimePicker)
        If dtp IsNot Nothing Then
            Dim cf As Font = Replacement(dtp.CalendarFont)
            If cf IsNot Nothing Then dtp.CalendarFont = cf
        End If

        For Each c As Control In root.Controls
            Apply(c)
        Next
    End Sub

    Private Function Replacement(f As Font) As Font
        Dim wanted As String = f.OriginalFontName
        If String.IsNullOrEmpty(wanted) OrElse String.Equals(wanted, f.Name, StringComparison.OrdinalIgnoreCase) Then Return Nothing
        If FindFamily(wanted) Is Nothing Then Return Nothing
        Return MakeFont(wanted, f.Size, f.Style, f.Unit)
    End Function
End Module