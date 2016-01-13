Public Class Form1
    'starting point of the list
    Dim head As Node
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        createList()
        lblBefore.Text = Printlist(head)
    End Sub

    Private Sub createList()
        'key for the Node
        Dim curr As Node
        Dim i As Integer
        'creating the new list
        head = New Node
        head.key = 0
        'current Node
        curr = head
        'reading the new link Node in for loop
        For i = 1 To 20
            curr.pnext = New Node
            curr = curr.pnext
            curr.key = i
        Next
        curr.pnext = New Node
        curr = curr.pnext
        curr.key = 0
        curr.pnext = curr
    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        'if the list has not been created show an error
        If head Is Nothing Then
            MsgBox("Please Click Create the list!")
            Return
        End If
        Dim curr As Node
        Dim prev As Node
        Dim next1 As Node
        curr = head.pnext 'begin with the second node so we can make the first node (head) the tail
        head.pnext = head 'set the pnext of the head node to itself to make it the new tail
        prev = head       'we begin with the second node, which makes head the prev node
        While Not curr.pnext Is curr 'while the curr node is not the last node
            next1 = curr.pnext 'remember curr.pnext so we can set curr to it later
            curr.pnext = prev  'reorder the node by setting its pnext to the prev node
            prev = curr        'set the prev node to the curr node
            curr = next1       'set curr to the remembered curr.pnext
        End While
        curr.pnext = prev 'The loop didn't execute for the last node, so we have to set its pnext outside the loop
        head = curr 'the last node (curr) becomes the new head
        lblAfter.Text = Printlist(head)
    End Sub

    Function Printlist(ByRef head As Node) As String
        Dim strout As String
        Dim curr As Node
        Dim j As Integer
        'skipping the head
        curr = head.pnext
        strout = ""
        j = 1
        While Not curr.pnext Is curr
            If j = 1 Then
                strout = CStr(curr.key)
            Else
                strout = strout & "," & CStr(curr.key)
            End If
            j = j + 1
            curr = curr.pnext
        End While
        Return strout
    End Function

End Class
