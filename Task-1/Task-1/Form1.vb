'Main form with 5 buttons to subforms
Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSO_Click(sender As Object, e As EventArgs) Handles btnSO.Click
        Dim x As New frmSO
        x.Show()
    End Sub

    Private Sub btnSI_Click(sender As Object, e As EventArgs) Handles btnSI.Click
        Dim x1 As New FrmSI
        x1.Show()
    End Sub

    Private Sub btnRI_Click(sender As Object, e As EventArgs) Handles btnRI.Click
        Dim y1 As New FrmRI
        y1.Show()
    End Sub

    Private Sub btnRO_Click(sender As Object, e As EventArgs) Handles btnRO.Click
        Dim y As New FrmRO
        y.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
