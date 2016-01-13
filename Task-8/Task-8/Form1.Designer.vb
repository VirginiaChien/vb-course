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
        Me.lstUnsorted = New System.Windows.Forms.ListBox()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.lstShell = New System.Windows.Forms.ListBox()
        Me.btnShell = New System.Windows.Forms.Button()
        Me.lstMerge = New System.Windows.Forms.ListBox()
        Me.btnMerge = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstUnsorted
        '
        Me.lstUnsorted.FormattingEnabled = True
        Me.lstUnsorted.Location = New System.Drawing.Point(12, 71)
        Me.lstUnsorted.Name = "lstUnsorted"
        Me.lstUnsorted.Size = New System.Drawing.Size(91, 173)
        Me.lstUnsorted.TabIndex = 0
        '
        'btnFill
        '
        Me.btnFill.Location = New System.Drawing.Point(13, 24)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(90, 26)
        Me.btnFill.TabIndex = 1
        Me.btnFill.Text = "FILL"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'lstShell
        '
        Me.lstShell.FormattingEnabled = True
        Me.lstShell.Location = New System.Drawing.Point(123, 71)
        Me.lstShell.Name = "lstShell"
        Me.lstShell.Size = New System.Drawing.Size(91, 173)
        Me.lstShell.TabIndex = 2
        '
        'btnShell
        '
        Me.btnShell.Location = New System.Drawing.Point(123, 24)
        Me.btnShell.Name = "btnShell"
        Me.btnShell.Size = New System.Drawing.Size(90, 26)
        Me.btnShell.TabIndex = 3
        Me.btnShell.Text = "SHELL"
        Me.btnShell.UseVisualStyleBackColor = True
        '
        'lstMerge
        '
        Me.lstMerge.FormattingEnabled = True
        Me.lstMerge.Location = New System.Drawing.Point(234, 71)
        Me.lstMerge.Name = "lstMerge"
        Me.lstMerge.Size = New System.Drawing.Size(91, 173)
        Me.lstMerge.TabIndex = 4
        '
        'btnMerge
        '
        Me.btnMerge.Location = New System.Drawing.Point(234, 24)
        Me.btnMerge.Name = "btnMerge"
        Me.btnMerge.Size = New System.Drawing.Size(90, 26)
        Me.btnMerge.TabIndex = 5
        Me.btnMerge.Text = "MERGE"
        Me.btnMerge.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 259)
        Me.Controls.Add(Me.btnMerge)
        Me.Controls.Add(Me.lstMerge)
        Me.Controls.Add(Me.btnShell)
        Me.Controls.Add(Me.lstShell)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Me.lstUnsorted)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstUnsorted As System.Windows.Forms.ListBox
    Friend WithEvents btnFill As System.Windows.Forms.Button
    Friend WithEvents lstShell As System.Windows.Forms.ListBox
    Friend WithEvents btnShell As System.Windows.Forms.Button
    Friend WithEvents lstMerge As System.Windows.Forms.ListBox
    Friend WithEvents btnMerge As System.Windows.Forms.Button

End Class
