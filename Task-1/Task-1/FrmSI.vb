Imports System.IO
Public Class FrmSI

    Dim filewriter As New StreamWriter("C:\ShiaoChien\SAddress.txt", True)

    'Close the same form and close the filewriter
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        filewriter.Close()
        Me.Close()
    End Sub

    'Clear the form
    Private Sub cleartext()
        txtFName.Clear()
        txtLName.Clear()
        txtAddress.Clear()
        txtSuburb.Clear()
        txtState.Clear()
        txtPC.Clear()
        txtPhone.Clear()
    End Sub

    'Append the address details to the end of the file 
    Private Sub writetext()
        filewriter.WriteLine(txtFName.Text)
        filewriter.WriteLine(txtLName.Text)
        filewriter.WriteLine(txtAddress.Text)
        filewriter.WriteLine(txtSuburb.Text)
        filewriter.WriteLine(txtState.Text)
        filewriter.WriteLine(txtPC.Text)
        filewriter.WriteLine(txtPhone.Text)
    End Sub

    Private Sub FrmSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cleartext()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnwrite.Click
        Call writetext()
        Call cleartext()
        MsgBox("Data has been saved.")
    End Sub

    'Clear the form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call cleartext()
    End Sub
End Class