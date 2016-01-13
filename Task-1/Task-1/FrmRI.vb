Imports System.IO
Public Class FrmRI

    'Close the same form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Clear form
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

    'Write the address details into the random access file
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnwrite.Click
        Dim fs As New FileStream("c:\ShiaoChien\RAddress.txt", FileMode.Append, FileAccess.Write)
        Dim bwriter As New BinaryWriter(fs)
        'Make 100 charactors partitions
        fs.Position = txtID.Text * 100
        bwriter.Write(txtID.Text)
        bwriter.Write(txtFName.Text)
        bwriter.Write(txtLName.Text)
        bwriter.Write(txtAddress.Text)
        bwriter.Write(txtSuburb.Text)
        bwriter.Write(txtState.Text)
        bwriter.Write(txtPC.Text)
        bwriter.Write(txtPhone.Text)
        bwriter.Close()
        fs.Close()
        Call cleartext()
        MsgBox("Data has been saved.")
    End Sub

End Class