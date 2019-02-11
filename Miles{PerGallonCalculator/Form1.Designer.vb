<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Close1 = New System.Windows.Forms.Button()
        Me.Gallon = New System.Windows.Forms.TextBox()
        Me.Miles = New System.Windows.Forms.TextBox()
        Me.MPG = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallon of gas the car can hold"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of miles it can be driven on a full tank"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Miles per gallon"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(55, 228)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(71, 37)
        Me.Calculate.TabIndex = 3
        Me.Calculate.Text = "Calculate MPG"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(194, 228)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(71, 37)
        Me.Clear.TabIndex = 4
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Close1
        '
        Me.Close1.Location = New System.Drawing.Point(347, 228)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(71, 37)
        Me.Close1.TabIndex = 5
        Me.Close1.Text = "Exit"
        Me.Close1.UseVisualStyleBackColor = True
        '
        'Gallon
        '
        Me.Gallon.Location = New System.Drawing.Point(288, 56)
        Me.Gallon.Name = "Gallon"
        Me.Gallon.Size = New System.Drawing.Size(105, 20)
        Me.Gallon.TabIndex = 6
        '
        'Miles
        '
        Me.Miles.Location = New System.Drawing.Point(288, 103)
        Me.Miles.Name = "Miles"
        Me.Miles.Size = New System.Drawing.Size(105, 20)
        Me.Miles.TabIndex = 7
        '
        'MPG
        '
        Me.MPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MPG.Enabled = False
        Me.MPG.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MPG.Location = New System.Drawing.Point(288, 150)
        Me.MPG.Name = "MPG"
        Me.MPG.Size = New System.Drawing.Size(105, 27)
        Me.MPG.TabIndex = 10
        Me.MPG.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 341)
        Me.Controls.Add(Me.MPG)
        Me.Controls.Add(Me.Miles)
        Me.Controls.Add(Me.Gallon)
        Me.Controls.Add(Me.Close1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Close1 As Button
    Friend WithEvents Gallon As TextBox
    Friend WithEvents Miles As TextBox
    Friend WithEvents MPG As Label
End Class
