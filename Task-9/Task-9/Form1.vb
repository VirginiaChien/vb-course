Imports System.IO
Public Class Form1
    Dim temp As Student
    Dim head As Student
    Dim tail As Student
    Dim strList As String
    Dim strFile As String = "C:\ShiaoChien\StudentRegister.txt"
    Dim tempPTR As Student

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstRegister.Items.Clear()
        btnSave.Enabled = False
        btnAdd.Enabled = False
        btnDelete.Enabled = False
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
            'move to next tempPTR
            tempPTR = tempPTR.StNext
        Loop
        btnSave.Enabled = True
        btnAdd.Enabled = True
        btnLoad.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'tail is nothing = listbox is nothing
        If tail Is Nothing Then
            MsgBox("There is nothing to save.")
        Else
            'create filewriter to save strFile from listbox
            Dim filewriter As New StreamWriter(strFile, False)
            tempPTR = tail
            'start writing file until notiong to write
            Do Until tempPTR Is Nothing
                filewriter.WriteLine(tempPTR.Number)
                filewriter.WriteLine(tempPTR.FirstName)
                filewriter.WriteLine(tempPTR.LastName)
                'move to next tempPTR
                tempPTR = tempPTR.StNext
            Loop
            filewriter.Close()
            MsgBox("List has been save.")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'check if textbox properties not meet up the standards
        If txtLastName.Text = "" Then
            MsgBox("Please insert Last name.")
        ElseIf txtFirstName.Text = "" Then
            MsgBox("Please insert First name.")
        ElseIf txtNumber.Text = "" Then
            MsgBox("Please insert Number.")
        ElseIf Len(txtNumber.Text) < 8 And Not IsNumeric(txtNumber.Text) Then
            MsgBox("Student Number has to be atleast 8 numbers.")
        Else
            'loding the properties from textbox to temp
            Dim temp As New Student
            temp.Number = txtNumber.Text
            temp.FirstName = txtFirstName.Text
            temp.LastName = txtLastName.Text
            'if nothing in the last node
            If head Is Nothing Then
                head = temp
                tail = temp
            Else
                'compare, swap and link tail to temp
                If temp.LastName <= tail.LastName Then
                    tail.StPre = temp
                    temp.StNext = tail
                    tail = temp
                    'compare, swap and link head to temp 
                ElseIf head.LastName <= temp.LastName Then
                    head.StNext = temp
                    temp.StPre = head
                    head = temp
                Else
                    tempPTR = tail.StNext
                    Do Until tempPTR Is Nothing
                        'compare temp.Lastname and tempPTR 
                        If tempPTR.LastName <= temp.LastName Then
                            tempPTR = tempPTR.StNext
                        Else
                            'link new temp and make new relationship with stpre and stnext
                            temp.StNext = tempPTR
                            temp.StPre = tempPTR.StPre
                            tempPTR.StPre = temp
                            temp.StPre.StNext = temp
                            tempPTR = Nothing
                        End If
                    Loop
                End If
            End If
            txtNumber.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            'clear the lstRegister before printing
            lstRegister.Items.Clear()
            tempPTR = tail
            'when tempPTR is nothing 
            Do Until tempPTR Is Nothing
                'start to print out in lstRegister from strList 
                strList = tempPTR.LastName & "," & tempPTR.FirstName & "," & tempPTR.Number
                lstRegister.Items.Add(strList)
                'move to next tempPTR
                tempPTR = tempPTR.StNext
            Loop
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure to delete?", vbYesNo, "Delete") = MsgBoxResult.Yes Then
            Dim strStudent(2) As String
            strStudent = Split(lstRegister.SelectedItem, ",")
            'assign tempPTR to first node
            tempPTR = tail
            Do Until tempPTR Is Nothing
                'make sure the one want to delete
                If tempPTR.Number = strStudent(2) And tempPTR.LastName = strStudent(0) And tempPTR.FirstName = strStudent(1) Then
                    'if tempPTR is the first node 
                    If tempPTR.Number = tail.Number Then
                        'make tempPTR.stnext to new tail 
                        tail = tempPTR.StNext
                        tempPTR = Nothing
                        'check tempPTR if is the last node
                    ElseIf tempPTR.Number = head.Number Then
                        'make tempPTR.StPre to new head
                        head = tempPTR.StPre
                        head.StNext = Nothing
                        tempPTR = Nothing
                    Else
                        'make new link from StNext to StPre and StPre to StNext
                        tempPTR.StNext.StPre = tempPTR.StPre
                        tempPTR.StPre.StNext = tempPTR.StNext
                        tempPTR = Nothing
                    End If
                    Exit Do
                End If
                'assign tempPTR.StNext to new tempPTR
                tempPTR = tempPTR.StNext
            Loop
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = False
        End If
        'clear the lstRegister before printing
        lstRegister.Items.Clear()
        tempPTR = tail
        'when tempPTR is nothing 
        Do Until tempPTR Is Nothing
            'start to print out in lstRegister from strList 
            strList = tempPTR.LastName & "," & tempPTR.FirstName & "," & tempPTR.Number
            lstRegister.Items.Add(strList)
            'move to next tempPTR
            tempPTR = tempPTR.StNext
        Loop
    End Sub

    Private Sub lstRegister_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRegister.SelectedIndexChanged
        btnDelete.Enabled = True
    End Sub
End Class
