Imports System.IO
Public Class Form1
    Dim temp As Student
    Dim head As Student
    Dim tail As Student
    Dim tempPTR As Student
    Dim strList As String
    Dim strFile As String = "C:\ShiaoChien\StudentRegister.txt"
    Dim changed As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstRegister.Items.Clear()
        btnSave.Enabled = False
        btnAdd.Enabled = False
        btnRemove.Enabled = False
        txtNumber.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        temp = Nothing
        head = Nothing
        tail = Nothing
        'create filereader to load strFile
        Dim fileReader As New StreamReader(strFile)
        Do
            temp = New Student
            'filereader will read by following line
            temp.Number = fileReader.ReadLine
            temp.FirstName = fileReader.ReadLine
            temp.LastName = fileReader.ReadLine
            If head Is Nothing Then
                head = temp
                tail = temp
            Else
                head.StNext = temp
                temp.StPre = head
                'make current new head
                head = temp
            End If
            'until don't have anythin to read after
        Loop Until (fileReader.EndOfStream = True)
        'close filereader after load
        fileReader.Close()
        'clear the lstRegister before printing
        lstRegister.Items.Clear()
        tempPTR = tail
        'when tempPTR is nothing 
        Do Until tempPTR Is Nothing
            'start to print out in lstRegister from strList 
            strList = tempPTR.LastName & "," & tempPTR.FirstName & "," & tempPTR.Number
            lstRegister.Items.Add(strList)
            tempPTR = tempPTR.StNext
        Loop
        btnSave.Enabled = True
        btnAdd.Enabled = True
        btnRemove.Enabled = True
        txtNumber.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not changed Then
            MsgBox("There is nothing to save.")
        Else
            'create filewriter to save to
            Dim filewriter As New StreamWriter(strFile, False)
            'write all items in the doubly linked list to the file starting with the tail
            tempPTR = tail
            Do Until tempPTR Is Nothing
                filewriter.WriteLine(tempPTR.Number)
                filewriter.WriteLine(tempPTR.FirstName)
                filewriter.WriteLine(tempPTR.LastName)
                tempPTR = tempPTR.StNext
            Loop
            'After writing the linked list to the file we set the changed flag to false
            'so that we only save again if the linked list has indeed changed
            changed = False
            filewriter.Close()
            MsgBox("List has been save.")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'check the textbox if was empty or add the new detail
        If txtNumber.Text = "" Or txtFirstName.Text = "" Or txtFirstName.Text = "" Then
            MsgBox("Please insert the detail!")
        Else
            tempPTR = New Student
            'print out the detail from textbox to lstRegister from strlist
            strList = txtLastName.Text & "," & txtFirstName.Text & "," & txtNumber.Text
            tempPTR.Number = txtNumber.Text
            tempPTR.FirstName = txtFirstName.Text
            tempPTR.LastName = txtLastName.Text
            lstRegister.Items.Add(strList)
            txtNumber.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            'set the head of the doubly linked list to the new student and link it with the hold head
            tempPTR.StPre = head
            head.StNext = tempPTR
            head = tempPTR
            'Adding something to the list changes it
            changed = True
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstRegister.SelectedItem Is Nothing Then
            MsgBox("Didn't selected detail to remove.")
        Else
            'find item to delete starting with tail
            tempPTR = tail
            Dim i As Integer = 0
            Do Until tempPTR Is Nothing Or i = lstRegister.SelectedIndex
                tempPTR = tempPTR.StNext
                i += 1
            Loop
            'unlink the deleted item from the doubly linked list by linking the
            'item before deleted item to the item after the deleted item 
            Dim before As Student
            Dim after As Student
            before = tempPTR.StPre
            after = tempPTR.StNext
            'check if the deleted item is the begining of item, will make tail to next item
            If before Is Nothing Then
                tail = tail.StNext
                tail.StPre = Nothing
                'check if the deleted item is the end of the item, will make head to previous item
            ElseIf after Is Nothing Then
                head = head.StPre
                head.StNext = Nothing
                'if the item deleted is in the middle, will link the previous and next item
            Else
                before.StNext = after
                after.StPre = before
            End If
            lstRegister.Items.Remove(lstRegister.SelectedItem)
            'Removing something from the list changes it
            changed = True
        End If
    End Sub

End Class
