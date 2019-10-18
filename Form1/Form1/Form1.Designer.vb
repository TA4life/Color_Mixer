<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RedValue = New System.Windows.Forms.TextBox()
        Me.GreenValue = New System.Windows.Forms.TextBox()
        Me.BlueValue = New System.Windows.Forms.TextBox()
        Me.Red = New System.Windows.Forms.Label()
        Me.Green = New System.Windows.Forms.Label()
        Me.Blue = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RedValue
        '
        Me.RedValue.Enabled = False
        Me.RedValue.Location = New System.Drawing.Point(686, 33)
        Me.RedValue.Name = "RedValue"
        Me.RedValue.Size = New System.Drawing.Size(100, 20)
        Me.RedValue.TabIndex = 1
        '
        'GreenValue
        '
        Me.GreenValue.Enabled = False
        Me.GreenValue.Location = New System.Drawing.Point(686, 62)
        Me.GreenValue.Name = "GreenValue"
        Me.GreenValue.Size = New System.Drawing.Size(100, 20)
        Me.GreenValue.TabIndex = 2
        '
        'BlueValue
        '
        Me.BlueValue.Enabled = False
        Me.BlueValue.Location = New System.Drawing.Point(686, 91)
        Me.BlueValue.Name = "BlueValue"
        Me.BlueValue.Size = New System.Drawing.Size(100, 20)
        Me.BlueValue.TabIndex = 3
        '
        'Red
        '
        Me.Red.AutoSize = True
        Me.Red.ForeColor = System.Drawing.SystemColors.Control
        Me.Red.Location = New System.Drawing.Point(19, 33)
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(27, 13)
        Me.Red.TabIndex = 4
        Me.Red.Text = "Red"
        '
        'Green
        '
        Me.Green.AutoSize = True
        Me.Green.ForeColor = System.Drawing.SystemColors.Control
        Me.Green.Location = New System.Drawing.Point(19, 62)
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(36, 13)
        Me.Green.TabIndex = 5
        Me.Green.Text = "Green"
        '
        'Blue
        '
        Me.Blue.AutoSize = True
        Me.Blue.ForeColor = System.Drawing.SystemColors.Control
        Me.Blue.Location = New System.Drawing.Point(19, 91)
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(28, 13)
        Me.Blue.TabIndex = 6
        Me.Blue.Text = "Blue"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.HScrollBar3)
        Me.Panel1.Controls.Add(Me.Blue)
        Me.Panel1.Controls.Add(Me.HScrollBar2)
        Me.Panel1.Controls.Add(Me.Green)
        Me.Panel1.Controls.Add(Me.HScrollBar1)
        Me.Panel1.Controls.Add(Me.Red)
        Me.Panel1.Controls.Add(Me.RedValue)
        Me.Panel1.Controls.Add(Me.BlueValue)
        Me.Panel1.Controls.Add(Me.GreenValue)
        Me.Panel1.Location = New System.Drawing.Point(78, 705)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 143)
        Me.Panel1.TabIndex = 7
        '
        'HScrollBar3
        '
        Me.HScrollBar3.LargeChange = 1
        Me.HScrollBar3.Location = New System.Drawing.Point(68, 88)
        Me.HScrollBar3.Maximum = 255
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(594, 23)
        Me.HScrollBar3.TabIndex = 2
        '
        'HScrollBar2
        '
        Me.HScrollBar2.LargeChange = 1
        Me.HScrollBar2.Location = New System.Drawing.Point(68, 59)
        Me.HScrollBar2.Maximum = 255
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(594, 23)
        Me.HScrollBar2.TabIndex = 1
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Location = New System.Drawing.Point(68, 30)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(594, 23)
        Me.HScrollBar1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 884)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RedValue As TextBox
    Friend WithEvents GreenValue As TextBox
    Friend WithEvents BlueValue As TextBox
    Friend WithEvents Red As Label
    Friend WithEvents Green As Label
    Friend WithEvents Blue As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HScrollBar3 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
End Class
