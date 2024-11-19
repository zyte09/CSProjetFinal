Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.DirectoryServices.ActiveDirectory

Public Class CircularButton
    Inherits Button

    Private _borderSize As Integer = 0
    Private _borderRadius As Integer = 40
    Private _borderColor As Color = Color.PaleVioletRed

    ' Properties
    <Category("Button Apperance")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Button Apperance")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Button Apperance")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Button Apperance")>
    Public Property BackgroundColor As Color
        Get
            Return Me.BackColor
        End Get
        Set(value As Color)
            Me.BackColor = value
        End Set
    End Property

    <Category("Button Apperance")>
    Public Property TextColor As Color
        Get
            Return Me.ForeColor
        End Get
        Set(value As Color)
            Me.ForeColor = value
        End Set
    End Property

    ' Constructor
    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.Size = New Size(150, 40)
        Me.BackColor = Color.MediumSlateBlue
        Me.ForeColor = Color.White
        AddHandler Me.Resize, AddressOf Button_Resize
    End Sub

    ' Methods
    Private Function GetFigurePath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter As Single = radius * 2.0

        If radius > 0 Then
            radius = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2)
            diameter = radius * 2
        End If

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        Dim rectSurface As Rectangle = Me.ClientRectangle
        Dim rectBorder As Rectangle = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize)
        Dim smoothSize As Integer = 2
        If _borderSize > 0 Then smoothSize = _borderSize

        If _borderRadius > 2 Then ' Rounded button
            Using pathSurface As GraphicsPath = GetFigurePath(rectSurface, _borderRadius)
                Using pathBorder As GraphicsPath = GetFigurePath(rectBorder, _borderRadius - _borderSize)
                    Using penBorder As New Pen(_borderColor, _borderSize)
                        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                        ' Button surface
                        Me.Region = New Region(pathSurface)

                        ' Button border
                        If _borderSize >= 1 Then
                            pevent.Graphics.DrawPath(penBorder, pathBorder)
                        End If
                    End Using
                End Using
            End Using
        Else ' Normal button
            pevent.Graphics.SmoothingMode = SmoothingMode.None
            ' Button surface
            Me.Region = New Region(rectSurface)
            ' Button border
            If _borderSize >= 1 Then
                Using penBorder As New Pen(_borderColor, _borderSize)
                    penBorder.Alignment = PenAlignment.Inset
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, Me.Width - 1, Me.Height - 1)
                End Using
            End If
        End If
    End Sub


    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        AddHandler Me.Parent.BackColorChanged, AddressOf Container_BackColorChanged
    End Sub

    Private Sub Container_BackColorChanged(sender As Object, e As EventArgs)
        Me.Invalidate()
    End Sub

    Private Sub Button_Resize(sender As Object, e As EventArgs)
        If _borderRadius > Me.Height Then _borderRadius = Me.Height
    End Sub
End Class