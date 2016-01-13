Public Class Form1
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Display()
    End Sub

    Private Sub DriveName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DriveName.SelectedIndexChanged
        Try
            'calling display when a cd drive without cd was selected will throw
            Call Display()
            'show the boxes again if an exception hide them before
            DirName.Show()
            FileName.Show()
            'update the directory box to the new drive root directory
            DirName.Path = DriveName.Drive
            'update the file box to the new root directory
            FileName.Path = DirName.Path
        Catch ex As Exception
            'this exception can happen when CD drive was selected that doens't contain a CD
            'we hide the directory and file boxes to since we can't show anything
            DirName.Hide()
            FileName.Hide()
            MsgBox(ex.Message)
        End Try

    End Sub

    'update the file box to show the files of the opened directory
    '
    'we use the Change event instead of the selectedindexchanged event because for some reason
    'when the selectedindexchanged event is fired the dirname.path isn't yet up-to-date with the
    'selected index. The Change event doesn't have this problem, but it only is fired when a directory
    'is double clicked.
    Private Sub DirName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DirName.Change
        FileName.Path = DirName.Path
        Call Display()
    End Sub

    'when the file selected, parse the name and update the file information
    Private Sub FileName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileName.SelectedIndexChanged
        Dim dotpos As Integer
        dotpos = InStr(FileName.FileName, ".") - 1
        lblFileName.Text = Microsoft.VisualBasic.Left(FileName.FileName, dotpos)
        Dim len As Integer
        len = Microsoft.VisualBasic.Len(FileName.FileName) - 1
        lblFileExt.Text = Microsoft.VisualBasic.Right(FileName.FileName, len - dotpos).ToUpper
        Call DisplayCurrentDir()
    End Sub

    Private Sub Display()
        Try
            Call DisplayDriveName()
            Call DisplayDriveLable()
            Call DisplayDriveType()
            Call DisplayDiskSize()
            Call DisplayDiskFreeSize()
            Call DisplayCurrentDir()
            lblCurDir.Text = DirName.Path
            lblFileName.Text = "Unknown file name"
            lblFileExt.Text = "Unknown file type"
        Catch ex As Exception
            Call DisplayDriveName()
            Call DisplayDriveLable()
            Call DisplayDriveType()
            lblDiskSize.Text = " "
            lblDriveFreeSize.Text = " "
            lblFileName.Text = " "
            lblFileExt.Text = " "
            lblCurDir.Text = ex.Message
        End Try
    End Sub

    'update the drive text also drive name if available
    Private Sub DisplayDriveName()
        lblDriveName.Text = UCase(Microsoft.VisualBasic.Left(DriveName.Drive, 2))
        If DriveName.Drive = "" Then
            lblDriveLabel.Text = "No Drive Label."
        Else
            lblDriveLabel.Text = DriveName.Drive
        End If
    End Sub

    Private Sub DisplayDriveLable()
        lblDriveLabel.Text = DriveName.Drive
    End Sub

    'set i to the drive index and display the drive type
    Private Sub DisplayDriveType()
        If lblDriveName.Text = "C:" Then i = 0
        If lblDriveName.Text = "D:" Then i = 1
        If lblDriveName.Text = "E:" Then i = 2
        If lblDriveName.Text = "F:" Then i = 3
        lblDriveType.Text = My.Computer.FileSystem.Drives.Item(i).DriveType.ToString
    End Sub

    'display the size of current drive
    Private Sub DisplayDiskSize()
        lblDiskSize.Text = FormatNumber((My.Computer.FileSystem.Drives.Item(i).TotalSize.ToString) / 1073741824, 2) & " GB"
    End Sub

    'display the diskfree size of current drive
    Private Sub DisplayDiskFreeSize()
        lblDriveFreeSize.Text = FormatNumber((My.Computer.FileSystem.Drives.Item(i).TotalFreeSpace.ToString) / 1073741824, 2) & " GB"
    End Sub

    'display the current directory path ending with "\"
    Private Sub DisplayCurrentDir()
        If InStr(FileName.Path, "\") = FileName.Path.Length Then
            lblCurDir.Text = FileName.Path
        Else
            lblCurDir.Text = FileName.Path & "\"
        End If
    End Sub

End Class
