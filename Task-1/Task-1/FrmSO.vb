Imports System.IO
Public Class frmSO

    Dim filereader As New StreamReader("C:\ShiaoChien\SAddress.txt")

    'Close the form and filereader
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        filereader.Close()
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

    'Read and display the address details
    Private Sub readtext()
        txtFName.Text = filereader.ReadLine
        txtLName.Text = filereader.ReadLine
        txtAddress.Text = filereader.ReadLine
        txtSuburb.Text = filereader.ReadLine
        txtState.Text = filereader.ReadLine
        txtPC.Text = filereader.ReadLine
        txtPhone.Text = filereader.ReadLine
    End Sub

    Private Sub frmSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cleartext()
        Call readtext()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call cleartext()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Call readtext()
    End Sub
End Class