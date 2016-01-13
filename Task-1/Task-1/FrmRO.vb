Imports System.IO
Public Class FrmRO
    'Close the same form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Clear the form
    Private Sub cleartext()
        txtID.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtAddress.Clear()
        txtSuburb.Clear()
        txtState.Clear()
        txtPC.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call cleartext()
    End Sub

    'Find and display address details from the specific id
    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        Dim fs As New FileStream("c:\ShiaoChien\RAddress.txt", FileMode.Open, FileAccess.Read)
        Dim bReader As New BinaryReader(fs)
        Try
            fs.Seek(txtID.Text * 100, 0)
            Dim id As String
            id = bReader.ReadString
            txtFName.Text = bReader.ReadString
            txtLName.Text = bReader.ReadString
            txtAddress.Text = bReader.ReadString
            txtSuburb.Text = bReader.ReadString
            txtState.Text = bReader.ReadString
            txtPC.Text = bReader.ReadString
            txtPhone.Text = bReader.ReadString
            bReader.Close()
            fs.Close()
        Catch
            MsgBox("ID does not exist!")
        End Try
    End Sub

End Class