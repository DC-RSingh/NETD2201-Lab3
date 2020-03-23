Public Class frmAvgUnitsShippedByEmployee
    ' Form level variable for Day counter
    Dim counterDay As Integer = 1
    ' Form level 2D array for the employee data
    Dim employeeData(2, 6) As Integer
    ' Form level variable for current employee being updated
    Dim currentEmployee As Integer = 0
    ' Form level list for each employee's list of values
    Dim valueTextBoxes As New List(Of RichTextBox)
    ' Form level list for each employee's average
    Dim averageTextBoxes As New List(Of RichTextBox)
    ' Fonts
    Dim boldFont As New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    Dim regularFont As New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)

    Private Sub FrmAvgUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valueTextBoxes.Add(rtbEmployeeValues1)
        valueTextBoxes.Add(rtbEmployeeValues2)
        valueTextBoxes.Add(rtbEmployeeValues3)
        averageTextBoxes.Add(rtbEmployeeAverage1)
        averageTextBoxes.Add(rtbEmployeeAverage2)
        averageTextBoxes.Add(rtbEmployeeAverage3)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim flag As Boolean = True
        Dim value As Integer

        ' Catches exception on int32 conversion, changes flag variable and displays error message
        Try
            value = Convert.ToInt32(tbUnitsEntered.Text.Trim)
        Catch ex As Exception
            MsgBox("ERROR: Value entered was not a whole number.")
            flag = False
            tbUnitsEntered.SelectAll()
        End Try

        Dim boolrangeCheck As Boolean = value >= 0 And value <= 1000
        If flag AndAlso Not boolrangeCheck Then
            MsgBox("ERROR: Enter a value in the range 0 to 1000 inclusive.")
            flag = False
        End If

        ' Logic to add integers to array, increment Day counter and update entered values textbox
        If flag AndAlso counterDay <= 7 Then
            valueTextBoxes(currentEmployee).AppendText(value & vbCrLf)
            employeeData(currentEmployee, counterDay - 1) = value
            counterDay += 1
            lblDay.Text = "Day " & counterDay.ToString
        End If

        tbUnitsEntered.SelectAll()

        ' Logic to calculate average and update current employee
        If counterDay > 7 Then
            lblDay.Text = "Day 1"
            averageTextBoxes(currentEmployee).Text = "Average: " _
                & GetEmployeeAverage(employeeData, currentEmployee).ToString("N2") ' convert to decimal

            tbUnitsEntered.Text = String.Empty
            If currentEmployee = 2 Then
                btnAccept.Enabled = False
                tbUnitsEntered.Enabled = False
                rtbAverage.Text = "Average per day: " & GetAveragePerDay().ToString("N2")
            End If

            counterDay = 1
            If currentEmployee < 2 Then
                currentEmployee += 1
            End If

            ' Bolds Employee Label depending on which one is being changed
            If currentEmployee = 1 Then
                lblEmployee1.Font = regularFont
                lblEmployee2.Font = boldFont
                lblEmployee3.Font = regularFont
            ElseIf currentEmployee = 2 Then
                lblEmployee1.Font = regularFont
                lblEmployee2.Font = regularFont
                lblEmployee3.Font = boldFont
            End If
        End If
    End Sub

    ' Resets Form level variables and input controls
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For i As Integer = 0 To valueTextBoxes.Count - 1
            valueTextBoxes(i).Text = String.Empty
            averageTextBoxes(i).Text = String.Empty
        Next
        rtbAverage.Text = String.Empty
        lblEmployee1.Font = boldFont
        lblEmployee2.Font = regularFont
        lblEmployee3.Font = regularFont
        tbUnitsEntered.Text = String.Empty
        lblDay.Text = "Day 1"
        counterDay = 1
        currentEmployee = 0
        btnAccept.Enabled = True
        tbUnitsEntered.Enabled = True
        employeeData.Initialize()
    End Sub

    Private Function GetEmployeeAverage(ByRef dataArray As Integer(,), ByVal employeeIndex As Integer) As Double
        Dim sum As Integer = 0

        For i As Integer = 0 To 6
            sum += dataArray(employeeIndex, i)
        Next

        Return Convert.ToDouble(sum / 7)
    End Function


    Private Function GetAveragePerDay() As Double
        Dim sum As Double = 0.0

        For i As Integer = 0 To 2
            sum += GetEmployeeAverage(employeeData, i)
        Next

        Return sum / 3
    End Function

End Class
