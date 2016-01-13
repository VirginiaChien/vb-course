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
        Me.btnSO = New System.Windows.Forms.Button()
        Me.btnSI = New System.Windows.Forms.Button()
        Me.btnRO = New System.Windows.Forms.Button()
        Me.btnRI = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSO
        '
        Me.btnSO.Location = New System.Drawing.Point(93, 44)
        Me.btnSO.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSO.Name = "btnSO"
        Me.btnSO.Size = New System.Drawing.Size(438, 59)
        Me.btnSO.TabIndex = 0
        Me.btnSO.Text = "Sequential Output"
        Me.btnSO.UseVisualStyleBackColor = True
        '
        'btnSI
        '
        Me.btnSI.Location = New System.Drawing.Point(93, 133)
        Me.btnSI.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSI.Name = "btnSI"
        Me.btnSI.Size = New System.Drawing.Size(438, 59)
        Me.btnSI.TabIndex = 1
        Me.btnSI.Text = "Sequential Input"
        Me.btnSI.UseVisualStyleBackColor = True
        '
        'btnRO
        '
        Me.btnRO.Location = New System.Drawing.Point(93, 220)
        Me.btnRO.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnRO.Name = "btnRO"
        Me.btnRO.Size = New System.Drawing.Size(438, 59)
        Me.btnRO.TabIndex = 2
        Me.btnRO.Text = "Random Output"
        Me.btnRO.UseVisualStyleBackColor = True
        '
        'btnRI
        '
        Me.btnRI.Location = New System.Drawing.Point(93, 308)
        Me.btnRI.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnRI.Name = "btnRI"
        Me.btnRI.Size = New System.Drawing.Size(438, 59)
        Me.btnRI.TabIndex = 3
        Me.btnRI.Text = "Random Input"
        Me.btnRI.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(93, 402)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(438, 59)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 484)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRI)
        Me.Controls.Add(Me.btnRO)
        Me.Controls.Add(Me.btnSI)
        Me.Controls.Add(Me.btnSO)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSO As System.Windows.Forms.Button
    Friend WithEvents btnSI As System.Windows.Forms.Button
    Friend WithEvents btnRO As System.Windows.Forms.Button
    Friend WithEvents btnRI As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
