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
        Me.btnDesktop = New System.Windows.Forms.Button()
        Me.btnComputer = New System.Windows.Forms.Button()
        Me.btnScreen = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDesktop
        '
        Me.btnDesktop.Location = New System.Drawing.Point(58, 41)
        Me.btnDesktop.Name = "btnDesktop"
        Me.btnDesktop.Size = New System.Drawing.Size(170, 40)
        Me.btnDesktop.TabIndex = 0
        Me.btnDesktop.Text = "Desktop Properties"
        Me.btnDesktop.UseVisualStyleBackColor = True
        '
        'btnComputer
        '
        Me.btnComputer.Location = New System.Drawing.Point(58, 87)
        Me.btnComputer.Name = "btnComputer"
        Me.btnComputer.Size = New System.Drawing.Size(169, 40)
        Me.btnComputer.TabIndex = 1
        Me.btnComputer.Text = "Computer Name"
        Me.btnComputer.UseVisualStyleBackColor = True
        '
        'btnScreen
        '
        Me.btnScreen.Location = New System.Drawing.Point(59, 133)
        Me.btnScreen.Name = "btnScreen"
        Me.btnScreen.Size = New System.Drawing.Size(169, 40)
        Me.btnScreen.TabIndex = 2
        Me.btnScreen.Text = "Screen Resolution"
        Me.btnScreen.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(58, 179)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(169, 40)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnScreen)
        Me.Controls.Add(Me.btnComputer)
        Me.Controls.Add(Me.btnDesktop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDesktop As System.Windows.Forms.Button
    Friend WithEvents btnComputer As System.Windows.Forms.Button
    Friend WithEvents btnScreen As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
