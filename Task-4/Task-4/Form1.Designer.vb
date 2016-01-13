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
        Me.DriveName = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDriveName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDriveLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDriveType = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDiskSize = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDriveFreeSize = New System.Windows.Forms.Label()
        Me.DirName = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCurDir = New System.Windows.Forms.Label()
        Me.FileName = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblFileExt = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DriveName
        '
        Me.DriveName.FormattingEnabled = True
        Me.DriveName.Location = New System.Drawing.Point(108, 28)
        Me.DriveName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.DriveName.Name = "DriveName"
        Me.DriveName.Size = New System.Drawing.Size(258, 37)
        Me.DriveName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Drive Name"
        '
        'lblDriveName
        '
        Me.lblDriveName.AutoSize = True
        Me.lblDriveName.Location = New System.Drawing.Point(176, 92)
        Me.lblDriveName.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDriveName.Name = "lblDriveName"
        Me.lblDriveName.Size = New System.Drawing.Size(72, 24)
        Me.lblDriveName.TabIndex = 2
        Me.lblDriveName.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(366, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Drive Label"
        '
        'lblDriveLabel
        '
        Me.lblDriveLabel.AutoSize = True
        Me.lblDriveLabel.Location = New System.Drawing.Point(511, 92)
        Me.lblDriveLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDriveLabel.Name = "lblDriveLabel"
        Me.lblDriveLabel.Size = New System.Drawing.Size(72, 24)
        Me.lblDriveLabel.TabIndex = 4
        Me.lblDriveLabel.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Drive Type"
        '
        'lblDriveType
        '
        Me.lblDriveType.AutoSize = True
        Me.lblDriveType.Location = New System.Drawing.Point(176, 138)
        Me.lblDriveType.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDriveType.Name = "lblDriveType"
        Me.lblDriveType.Size = New System.Drawing.Size(72, 24)
        Me.lblDriveType.TabIndex = 6
        Me.lblDriveType.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Drive Size"
        '
        'lblDiskSize
        '
        Me.lblDiskSize.AutoSize = True
        Me.lblDiskSize.Location = New System.Drawing.Point(511, 138)
        Me.lblDiskSize.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDiskSize.Name = "lblDiskSize"
        Me.lblDiskSize.Size = New System.Drawing.Size(72, 24)
        Me.lblDiskSize.TabIndex = 8
        Me.lblDiskSize.Text = "Label2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(700, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Drive Free Size"
        '
        'lblDriveFreeSize
        '
        Me.lblDriveFreeSize.AutoSize = True
        Me.lblDriveFreeSize.Location = New System.Drawing.Point(914, 138)
        Me.lblDriveFreeSize.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblDriveFreeSize.Name = "lblDriveFreeSize"
        Me.lblDriveFreeSize.Size = New System.Drawing.Size(72, 24)
        Me.lblDriveFreeSize.TabIndex = 10
        Me.lblDriveFreeSize.Text = "Label2"
        '
        'DirName
        '
        Me.DirName.FormattingEnabled = True
        Me.DirName.IntegralHeight = False
        Me.DirName.Location = New System.Drawing.Point(33, 484)
        Me.DirName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.DirName.Name = "DirName"
        Me.DirName.Size = New System.Drawing.Size(468, 194)
        Me.DirName.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Current Direction"
        '
        'lblCurDir
        '
        Me.lblCurDir.AutoSize = True
        Me.lblCurDir.Location = New System.Drawing.Point(26, 240)
        Me.lblCurDir.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblCurDir.Name = "lblCurDir"
        Me.lblCurDir.Size = New System.Drawing.Size(72, 24)
        Me.lblCurDir.TabIndex = 13
        Me.lblCurDir.Text = "Label2"
        '
        'FileName
        '
        Me.FileName.FormattingEnabled = True
        Me.FileName.Location = New System.Drawing.Point(542, 482)
        Me.FileName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.FileName.Name = "FileName"
        Me.FileName.Pattern = "*.*"
        Me.FileName.Size = New System.Drawing.Size(472, 196)
        Me.FileName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 290)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "File Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 390)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "File Extention"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(26, 340)
        Me.lblFileName.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(188, 24)
        Me.lblFileName.TabIndex = 17
        Me.lblFileName.Text = "Unknown file name"
        '
        'lblFileExt
        '
        Me.lblFileExt.AutoSize = True
        Me.lblFileExt.Location = New System.Drawing.Point(26, 439)
        Me.lblFileExt.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblFileExt.Name = "lblFileExt"
        Me.lblFileExt.Size = New System.Drawing.Size(177, 24)
        Me.lblFileExt.TabIndex = 18
        Me.lblFileExt.Text = "Unknown file type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 42)
        Me.Label9.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 24)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Drive"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 716)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblFileExt)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FileName)
        Me.Controls.Add(Me.lblCurDir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DirName)
        Me.Controls.Add(Me.lblDriveFreeSize)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDiskSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDriveType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDriveLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDriveName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DriveName)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DriveName As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDriveName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDriveLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDriveType As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDiskSize As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDriveFreeSize As System.Windows.Forms.Label
    Friend WithEvents DirName As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCurDir As System.Windows.Forms.Label
    Friend WithEvents FileName As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents lblFileExt As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
