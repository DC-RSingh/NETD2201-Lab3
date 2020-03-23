<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvgUnitsShippedByEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.tbUnitsEntered = New System.Windows.Forms.TextBox()
        Me.rtbEmployeeValues1 = New System.Windows.Forms.RichTextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.rtbEmployeeAverage1 = New System.Windows.Forms.RichTextBox()
        Me.tooltipEnter = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipExit = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipReset = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipValues = New System.Windows.Forms.ToolTip(Me.components)
        Me.rtbEmployeeValues2 = New System.Windows.Forms.RichTextBox()
        Me.rtbEmployeeValues3 = New System.Windows.Forms.RichTextBox()
        Me.tooltipResult = New System.Windows.Forms.ToolTip(Me.components)
        Me.rtbEmployeeAverage2 = New System.Windows.Forms.RichTextBox()
        Me.rtbEmployeeAverage3 = New System.Windows.Forms.RichTextBox()
        Me.rtbAverage = New System.Windows.Forms.RichTextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.tooltipList = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipAverage = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(269, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.tooltipExit.SetToolTip(Me.btnExit, "Adds entered units to units shipped list")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(27, 298)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAccept.Size = New System.Drawing.Size(104, 23)
        Me.btnAccept.TabIndex = 12
        Me.btnAccept.Text = "E&nter"
        Me.tooltipEnter.SetToolTip(Me.btnAccept, "Exits the Application")
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(146, 298)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.tooltipReset.SetToolTip(Me.btnReset, "Resets the Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(23, 34)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbUnitsEntered
        '
        Me.tbUnitsEntered.Location = New System.Drawing.Point(63, 31)
        Me.tbUnitsEntered.Name = "tbUnitsEntered"
        Me.tbUnitsEntered.Size = New System.Drawing.Size(50, 20)
        Me.tbUnitsEntered.TabIndex = 1
        Me.tooltipValues.SetToolTip(Me.tbUnitsEntered, "Enter the units to be added ")
        '
        'rtbEmployeeValues1
        '
        Me.rtbEmployeeValues1.DetectUrls = False
        Me.rtbEmployeeValues1.Location = New System.Drawing.Point(26, 86)
        Me.rtbEmployeeValues1.Name = "rtbEmployeeValues1"
        Me.rtbEmployeeValues1.ReadOnly = True
        Me.rtbEmployeeValues1.Size = New System.Drawing.Size(106, 117)
        Me.rtbEmployeeValues1.TabIndex = 3
        Me.rtbEmployeeValues1.Text = ""
        Me.tooltipValues.SetToolTip(Me.rtbEmployeeValues1, "Units shipped for corresponding employee")
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(19, 9)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(38, 13)
        Me.lblDay.TabIndex = 7
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbEmployeeAverage1
        '
        Me.rtbEmployeeAverage1.Location = New System.Drawing.Point(26, 209)
        Me.rtbEmployeeAverage1.Name = "rtbEmployeeAverage1"
        Me.rtbEmployeeAverage1.ReadOnly = True
        Me.rtbEmployeeAverage1.Size = New System.Drawing.Size(106, 34)
        Me.rtbEmployeeAverage1.TabIndex = 4
        Me.rtbEmployeeAverage1.Text = ""
        Me.tooltipResult.SetToolTip(Me.rtbEmployeeAverage1, "Displays the Average Units Shipped for its corresponding employee")
        '
        'tooltipEnter
        '
        Me.tooltipEnter.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipEnter.ToolTipTitle = "Enter Button"
        '
        'tooltipExit
        '
        Me.tooltipExit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipExit.ToolTipTitle = "Exit Button"
        '
        'tooltipReset
        '
        Me.tooltipReset.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipReset.ToolTipTitle = "Reset Button"
        '
        'tooltipValues
        '
        Me.tooltipValues.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipValues.ToolTipTitle = "Units Textbox"
        '
        'rtbEmployeeValues2
        '
        Me.rtbEmployeeValues2.DetectUrls = False
        Me.rtbEmployeeValues2.Location = New System.Drawing.Point(146, 86)
        Me.rtbEmployeeValues2.Name = "rtbEmployeeValues2"
        Me.rtbEmployeeValues2.ReadOnly = True
        Me.rtbEmployeeValues2.Size = New System.Drawing.Size(106, 117)
        Me.rtbEmployeeValues2.TabIndex = 6
        Me.rtbEmployeeValues2.Text = ""
        Me.tooltipValues.SetToolTip(Me.rtbEmployeeValues2, "Units shipped for corresponding employee")
        '
        'rtbEmployeeValues3
        '
        Me.rtbEmployeeValues3.DetectUrls = False
        Me.rtbEmployeeValues3.Location = New System.Drawing.Point(267, 86)
        Me.rtbEmployeeValues3.Name = "rtbEmployeeValues3"
        Me.rtbEmployeeValues3.ReadOnly = True
        Me.rtbEmployeeValues3.Size = New System.Drawing.Size(106, 117)
        Me.rtbEmployeeValues3.TabIndex = 9
        Me.rtbEmployeeValues3.Text = ""
        Me.tooltipValues.SetToolTip(Me.rtbEmployeeValues3, "Units shipped for corresponding employee")
        '
        'tooltipResult
        '
        Me.tooltipResult.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipResult.ToolTipTitle = "Result Textbox"
        '
        'rtbEmployeeAverage2
        '
        Me.rtbEmployeeAverage2.Location = New System.Drawing.Point(146, 209)
        Me.rtbEmployeeAverage2.Name = "rtbEmployeeAverage2"
        Me.rtbEmployeeAverage2.ReadOnly = True
        Me.rtbEmployeeAverage2.Size = New System.Drawing.Size(106, 34)
        Me.rtbEmployeeAverage2.TabIndex = 7
        Me.rtbEmployeeAverage2.Text = ""
        Me.tooltipResult.SetToolTip(Me.rtbEmployeeAverage2, "Displays the Average Units Shipped for its corresponding employee")
        '
        'rtbEmployeeAverage3
        '
        Me.rtbEmployeeAverage3.Location = New System.Drawing.Point(267, 209)
        Me.rtbEmployeeAverage3.Name = "rtbEmployeeAverage3"
        Me.rtbEmployeeAverage3.ReadOnly = True
        Me.rtbEmployeeAverage3.Size = New System.Drawing.Size(106, 34)
        Me.rtbEmployeeAverage3.TabIndex = 10
        Me.rtbEmployeeAverage3.Text = ""
        Me.tooltipResult.SetToolTip(Me.rtbEmployeeAverage3, "Displays the Average Units Shipped for its corresponding employee")
        '
        'rtbAverage
        '
        Me.rtbAverage.Location = New System.Drawing.Point(27, 251)
        Me.rtbAverage.Name = "rtbAverage"
        Me.rtbAverage.ReadOnly = True
        Me.rtbAverage.Size = New System.Drawing.Size(343, 29)
        Me.rtbAverage.TabIndex = 11
        Me.rtbAverage.Text = ""
        Me.tooltipAverage.SetToolTip(Me.rtbAverage, "Average units shipped per day")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.Location = New System.Drawing.Point(51, 67)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(72, 13)
        Me.lblEmployee1.TabIndex = 2
        Me.lblEmployee1.Text = "Employee &1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(167, 67)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee2.TabIndex = 5
        Me.lblEmployee2.Text = "Employee &2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(292, 67)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee3.TabIndex = 8
        Me.lblEmployee3.Text = "Employee &3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tooltipList
        '
        Me.tooltipList.ToolTipTitle = "Value List"
        '
        'tooltipAverage
        '
        Me.tooltipAverage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipAverage.ToolTipTitle = "Average Per Day"
        '
        'frmAvgUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnAccept
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(390, 328)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.rtbAverage)
        Me.Controls.Add(Me.rtbEmployeeAverage3)
        Me.Controls.Add(Me.rtbEmployeeValues3)
        Me.Controls.Add(Me.rtbEmployeeAverage2)
        Me.Controls.Add(Me.rtbEmployeeValues2)
        Me.Controls.Add(Me.rtbEmployeeAverage1)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.rtbEmployeeValues1)
        Me.Controls.Add(Me.tbUnitsEntered)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAvgUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblUnits As Label
    Friend WithEvents tbUnitsEntered As TextBox
    Friend WithEvents rtbEmployeeValues1 As RichTextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents rtbEmployeeAverage1 As RichTextBox
    Friend WithEvents tooltipEnter As ToolTip
    Friend WithEvents tooltipExit As ToolTip
    Friend WithEvents tooltipReset As ToolTip
    Friend WithEvents tooltipValues As ToolTip
    Friend WithEvents tooltipResult As ToolTip
    Friend WithEvents rtbEmployeeAverage2 As RichTextBox
    Friend WithEvents rtbEmployeeValues2 As RichTextBox
    Friend WithEvents rtbEmployeeAverage3 As RichTextBox
    Friend WithEvents rtbEmployeeValues3 As RichTextBox
    Friend WithEvents rtbAverage As RichTextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents tooltipAverage As ToolTip
    Friend WithEvents tooltipList As ToolTip
End Class
