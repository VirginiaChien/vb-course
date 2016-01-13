Public Class Form1
    'creating array
    Dim max As Integer = 10
    Dim numArray(max) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnShell.Enabled = False
        btnMerge.Enabled = False
    End Sub

    'set all values in numArray to a random value and show them in listUnsorted
    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        'clear listbox when click button
        lstUnsorted.Items.Clear()
        'generate random number between 1 to 100
        Dim rand As New Random
        For i = 0 To max
            numArray(i) = rand.Next(1, 100)
            lstUnsorted.Items.Add(numArray(i))
        Next
        btnShell.Enabled = True
        btnMerge.Enabled = True
    End Sub

    'perform a shellsort on the numArray and display the sorted array in lstShell
    Private Sub btnShell_Click(sender As Object, e As EventArgs) Handles btnShell.Click
        'clear listbox when click button
        lstShell.Items.Clear()
        shellsort(numArray)
        For i = 0 To max
            lstShell.Items.Add(numArray(i))
        Next
    End Sub

    'perform a mergesort on the numArray and display the sorted array in lstMerge
    Private Sub btnMerge_Click(sender As Object, e As EventArgs) Handles btnMerge.Click
        'clear listbox when click button
        lstMerge.Items.Clear()
        Mergesort(numArray, LBound(numArray), UBound(numArray))
        For i = 0 To max
            lstMerge.Items.Add(numArray(i))
        Next
    End Sub

    Private Sub shellsort(numArray As Integer())
        Dim lngHold, lngGap As Long
        Dim i, iMin, iMax As Integer
        Dim varSwap As Object
        'find the lower number inside array
        iMin = LBound(numArray)
        'to find the upper number inside array
        iMax = UBound(numArray)
        'start with an initial gap of a power of 3 above iMax
        lngGap = iMin
        Do
            lngGap = 3 * lngGap + 1
        Loop Until lngGap > iMax
        Do
            'lower the gap by removing a power of 3 before each iteration
            lngGap = lngGap \ 3
            'for every value after the current gap perform an insertion sort
            'with the current gap as the negative step length
            For i = lngGap + iMin To iMax
                'value to find insert location for
                varSwap = numArray(i)
                lngHold = i
                'while the value at the next negative step is greater than the value we want to find
                'the insert location for
                Do While numArray(lngHold - lngGap) > varSwap
                    'set the value at the current negative step (or the insert value if the first step)
                    'to the value at the next negative step
                    numArray(lngHold) = numArray(lngHold - lngGap)
                    'perform a negative step of gap length
                    lngHold = lngHold - lngGap
                    'exit the loop if the next negative step would be less than iMin
                    If lngHold < iMin + lngGap Then Exit Do
                Loop
                'we found the insert location for the value, so set it
                numArray(lngHold) = varSwap
            Next
        Loop Until lngGap = 1
    End Sub

    Private Sub Mergesort(numArray As Integer(), low As Integer, high As Integer)
        If low >= high Then Return
        'the length of the array to sort
        Dim length As Integer = high - low + 1
        'get the middle point
        Dim middle As Integer = Math.Floor((high + low) / 2)
        'divide the array into 2 seperate arrays before middle and after middle and sort them recursively
        Mergesort(numArray, low, middle)
        Mergesort(numArray, middle + 1, high)
        'copy the array (now two sorted arrays)
        Dim temp(numArray.Length - 1) As Integer
        For i = 0 To length - 1
            temp(i) = numArray(low + i)
        Next
        'starting offset of first sorted array in temp
        Dim m1 As Integer = 0
        'starting offset of second sorted array in temp
        Dim m2 As Integer = middle - low + 1
        'for each offset to be sorted in temp/numArray
        For i = 0 To length - 1
            'if m2 is smaller equal the last offset in the second sorted array
            If m2 <= high - low Then
                'if m1 is smaller equal the last offset in the first sorted array
                If m1 <= middle - low Then
                    'if the value in the first sorted array is greater than in the second sorted array
                    If temp(m1) > temp(m2) Then
                        'set the current offset in numArray to the lower value of both
                        numArray(i + low) = temp(m2)
                        'increment m2 since we now have stored it successfully in numArray
                        'and leave m1 as is since we still have to sort it
                        m2 = m2 + 1
                    Else
                        'like above but for the temp(m1) <= temp(m2) case
                        numArray(i + low) = temp(m1)
                        m1 = m1 + 1
                    End If
                Else
                    'We've exhausted all values in the first sorted array, so we
                    'can only continue with the values in the second sorted array
                    numArray(i + low) = temp(m2)
                    m2 = m2 + 1
                End If
            Else
                'Like above but we've exhausted all values in the second sorted array
                numArray(i + low) = temp(m1)
                m1 = m1 + 1
            End If
        Next
    End Sub
End Class
