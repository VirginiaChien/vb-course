Public Class Form1
    Dim str As String

    'add the initial node to the treeview from the text inside the add text field, clear the add text field
    'and disable the start button
    'if the add text field is empty show a message
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        str = txtAdd.Text
        If str = "" Then
            MsgBox("Please insert some words.")
        Else
            tvCountry.Nodes.Add(str)
            txtAdd.Clear()
            btnStart.Enabled = False
        End If
    End Sub

    'when click inside the treeview and enable the add and remove buttons
    Private Sub tvCountry_MouseClick(sender As Object, e As MouseEventArgs) Handles tvCountry.MouseClick
        btnAdd.Enabled = True
        btnRemove.Enabled = True
    End Sub

    'when click remove button will remove the selected node and disable the add and remove buttons
    'and if is the last node will enable the start button 
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        tvCountry.SelectedNode.Remove()
        btnAdd.Enabled = False
        btnRemove.Enabled = False
        If tvCountry.Nodes.Count = 0 Then btnStart.Enabled = True
    End Sub

    'when click add button will add the new node with the addtext under the current node and clear the textbox 
    'if the addtext is empty show a message
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        str = txtAdd.Text
        If str = "" Then
            MsgBox("Please insert some words.")
        Else
            tvCountry.SelectedNode.Nodes.Add(str)
            txtAdd.Clear()
        End If
    End Sub
End Class
