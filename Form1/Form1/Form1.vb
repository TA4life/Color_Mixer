Imports System.Drawing.Drawing2D
Public Class Form1

    Dim Red_Value As Integer = 255
    Dim Green_Value As Integer = 255
    Dim Blue_Value As Integer = 255

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.DoubleBuffered = True

        Me.RedValue.Text = 255
        Me.GreenValue.Text = 255
        Me.BlueValue.Text = 255

        Me.BackColor = Color.Black

        Me.HScrollBar1.Value = 255
        Me.HScrollBar2.Value = 255
        Me.HScrollBar3.Value = 255
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Red_Value = Me.RedValue.Text
        Green_Value = Me.GreenValue.Text
        Blue_Value = Me.BlueValue.Text

        Dim gp1 As New GraphicsPath
        Dim gp2 As New GraphicsPath
        Dim gp3 As New GraphicsPath

        gp1.AddEllipse(200, 250, 400, 400)
        gp2.AddEllipse(400, 250, 400, 400)
        gp3.AddEllipse(300, 50, 400, 400)

        Dim redbrush As New SolidBrush(Color.FromArgb(Red_Value, 0, 0))
        Dim greenbrush As New SolidBrush(Color.FromArgb(0, Green_Value, 0))
        Dim bluebrush As New SolidBrush(Color.FromArgb(0, 0, Blue_Value))

        e.Graphics.FillPath(redbrush, gp1)
        e.Graphics.FillPath(greenbrush, gp2)
        e.Graphics.FillPath(bluebrush, gp3)

        Dim RedGreenRegion As New Region(gp1)
        RedGreenRegion.Intersect(gp2)
        e.Graphics.FillRegion(New SolidBrush(Color.FromArgb(Red_Value, Green_Value, 0)), RedGreenRegion)

        Dim RedBlueRegion As New Region(gp1)
        RedBlueRegion.Intersect(gp3)
        e.Graphics.FillRegion(New SolidBrush(Color.FromArgb(Red_Value, 0, Blue_Value)), RedBlueRegion)

        Dim GreenBlueRegion As New Region(gp2)
        GreenBlueRegion.Intersect(gp3)
        e.Graphics.FillRegion(New SolidBrush(Color.FromArgb(0, Green_Value, Blue_Value)), GreenBlueRegion)

        Dim RedGreenBlueRegion As New Region(gp1)
        RedGreenBlueRegion.Intersect(gp2)
        RedGreenBlueRegion.Intersect(gp3)
        e.Graphics.FillRegion(New SolidBrush(Color.FromArgb(Red_Value, Green_Value, Blue_Value)), RedGreenBlueRegion)

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Me.RedValue.Text = Me.HScrollBar1.Value
        Me.Invalidate()
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Me.GreenValue.Text = Me.HScrollBar2.Value
        Me.Invalidate()
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        Me.BlueValue.Text = Me.HScrollBar3.Value
        Me.Invalidate()
    End Sub
End Class
