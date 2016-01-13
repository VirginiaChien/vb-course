Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnDesktop.Click
        'Declare variable prop as string & variable runprop as long.
        Dim prop As String
        Dim runprop As Long
        'Run properties of desk.cpl
        'Also try run timedate.cpl powercfg.cpl at home computer
        prop = "rundll32.exe Shell32.dll, Control_RunDLL desk.cpl"
        runprop = Shell(prop, AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnComputer_Click(sender As Object, e As EventArgs) Handles btnComputer.Click
        'Use msg box to display computer name , operation system & username
        MsgBox("Computer Name=" & Environment.MachineName.ToString & vbCrLf & _
               "Operation System=" & Environment.OSVersion.ToString & vbCrLf & _
               "UserName=" & Environment.UserName.ToString)
    End Sub

    Private Sub btnScreen_Click(sender As Object, e As EventArgs) Handles btnScreen.Click
        'Use msgbox to display screen resolution & colour bits
        MsgBox("Screen Resolution" & Screen.PrimaryScreen.Bounds.Size.ToString & vbCrLf & _
               "Colour bits=" & Screen.PrimaryScreen.BitsPerPixel.ToString)
    End Sub

    Private Sub btnApplication_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the application
        Application.Exit()
    End Sub
End Class
