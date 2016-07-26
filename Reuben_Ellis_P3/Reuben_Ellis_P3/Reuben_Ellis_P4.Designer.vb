<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reuben_Ellis_P4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtHoursPerDay = New System.Windows.Forms.TextBox()
        Me.txtApplianceKWH = New System.Windows.Forms.TextBox()
        Me.txtCostPerKWH = New System.Windows.Forms.TextBox()
        Me.cboAppliance = New System.Windows.Forms.ComboBox()
        Me.lblHoursPerDay = New System.Windows.Forms.Label()
        Me.lblApplianceKWH = New System.Windows.Forms.Label()
        Me.lblCostPerKWH = New System.Windows.Forms.Label()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCostPerGallon = New System.Windows.Forms.TextBox()
        Me.lblWaterPerHour = New System.Windows.Forms.Label()
        Me.txtWaterPerHour = New System.Windows.Forms.TextBox()
        Me.lblCostPerGallon = New System.Windows.Forms.Label()
        Me.lblWaterHeader = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalDailyCost = New System.Windows.Forms.TextBox()
        Me.txtSelectedAppliance = New System.Windows.Forms.TextBox()
        Me.lblSelectedAppliance = New System.Windows.Forms.Label()
        Me.lblTotalDailyCost = New System.Windows.Forms.Label()
        Me.txtAddToList = New System.Windows.Forms.Button()
        Me.ListViewAppliances = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.btnViewkWh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ctrlSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(378, 292)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 27)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtHoursPerDay
        '
        Me.txtHoursPerDay.Location = New System.Drawing.Point(218, 181)
        Me.txtHoursPerDay.Name = "txtHoursPerDay"
        Me.txtHoursPerDay.Size = New System.Drawing.Size(111, 22)
        Me.txtHoursPerDay.TabIndex = 3
        Me.txtHoursPerDay.Text = "0"
        Me.txtHoursPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtApplianceKWH
        '
        Me.txtApplianceKWH.Location = New System.Drawing.Point(218, 141)
        Me.txtApplianceKWH.Name = "txtApplianceKWH"
        Me.txtApplianceKWH.Size = New System.Drawing.Size(111, 22)
        Me.txtApplianceKWH.TabIndex = 2
        Me.txtApplianceKWH.Text = "0"
        Me.txtApplianceKWH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostPerKWH
        '
        Me.txtCostPerKWH.Location = New System.Drawing.Point(218, 99)
        Me.txtCostPerKWH.Name = "txtCostPerKWH"
        Me.txtCostPerKWH.Size = New System.Drawing.Size(111, 22)
        Me.txtCostPerKWH.TabIndex = 1
        Me.txtCostPerKWH.Text = "0"
        Me.txtCostPerKWH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboAppliance
        '
        Me.cboAppliance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboAppliance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppliance.FormattingEnabled = True
        Me.cboAppliance.Location = New System.Drawing.Point(158, 61)
        Me.cboAppliance.Name = "cboAppliance"
        Me.cboAppliance.Size = New System.Drawing.Size(171, 24)
        Me.cboAppliance.Sorted = True
        Me.cboAppliance.TabIndex = 0
        '
        'lblHoursPerDay
        '
        Me.lblHoursPerDay.AutoSize = True
        Me.lblHoursPerDay.Location = New System.Drawing.Point(7, 155)
        Me.lblHoursPerDay.Name = "lblHoursPerDay"
        Me.lblHoursPerDay.Size = New System.Drawing.Size(98, 17)
        Me.lblHoursPerDay.TabIndex = 12
        Me.lblHoursPerDay.Text = "Hours per day"
        '
        'lblApplianceKWH
        '
        Me.lblApplianceKWH.AutoSize = True
        Me.lblApplianceKWH.Location = New System.Drawing.Point(7, 115)
        Me.lblApplianceKWH.Name = "lblApplianceKWH"
        Me.lblApplianceKWH.Size = New System.Drawing.Size(106, 17)
        Me.lblApplianceKWH.TabIndex = 10
        Me.lblApplianceKWH.Text = "Appliance k/Wh"
        '
        'lblCostPerKWH
        '
        Me.lblCostPerKWH.AutoSize = True
        Me.lblCostPerKWH.Location = New System.Drawing.Point(7, 73)
        Me.lblCostPerKWH.Name = "lblCostPerKWH"
        Me.lblCostPerKWH.Size = New System.Drawing.Size(97, 17)
        Me.lblCostPerKWH.TabIndex = 8
        Me.lblCostPerKWH.Text = "Cost per k/Wh"
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(7, 35)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(113, 17)
        Me.lblAppliance.TabIndex = 6
        Me.lblAppliance.Text = "Select Appliance"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.txtCostPerGallon)
        Me.GroupBox1.Controls.Add(Me.lblWaterPerHour)
        Me.GroupBox1.Controls.Add(Me.txtWaterPerHour)
        Me.GroupBox1.Controls.Add(Me.lblCostPerGallon)
        Me.GroupBox1.Controls.Add(Me.lblWaterHeader)
        Me.GroupBox1.Controls.Add(Me.lblCostPerKWH)
        Me.GroupBox1.Controls.Add(Me.lblApplianceKWH)
        Me.GroupBox1.Controls.Add(Me.lblHoursPerDay)
        Me.GroupBox1.Controls.Add(Me.lblAppliance)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 293)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'txtCostPerGallon
        '
        Me.txtCostPerGallon.Location = New System.Drawing.Point(195, 258)
        Me.txtCostPerGallon.Name = "txtCostPerGallon"
        Me.txtCostPerGallon.Size = New System.Drawing.Size(111, 22)
        Me.txtCostPerGallon.TabIndex = 1
        Me.txtCostPerGallon.Text = "0"
        Me.txtCostPerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWaterPerHour
        '
        Me.lblWaterPerHour.AutoSize = True
        Me.lblWaterPerHour.Location = New System.Drawing.Point(7, 226)
        Me.lblWaterPerHour.Name = "lblWaterPerHour"
        Me.lblWaterPerHour.Size = New System.Drawing.Size(107, 17)
        Me.lblWaterPerHour.TabIndex = 2
        Me.lblWaterPerHour.Text = "Water Per Hour"
        '
        'txtWaterPerHour
        '
        Me.txtWaterPerHour.Location = New System.Drawing.Point(195, 223)
        Me.txtWaterPerHour.Name = "txtWaterPerHour"
        Me.txtWaterPerHour.Size = New System.Drawing.Size(111, 22)
        Me.txtWaterPerHour.TabIndex = 0
        Me.txtWaterPerHour.Text = "0"
        Me.txtWaterPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostPerGallon
        '
        Me.lblCostPerGallon.AutoSize = True
        Me.lblCostPerGallon.Location = New System.Drawing.Point(7, 261)
        Me.lblCostPerGallon.Name = "lblCostPerGallon"
        Me.lblCostPerGallon.Size = New System.Drawing.Size(150, 17)
        Me.lblCostPerGallon.TabIndex = 3
        Me.lblCostPerGallon.Text = "Cost Per 1000 Gallons"
        '
        'lblWaterHeader
        '
        Me.lblWaterHeader.AutoSize = True
        Me.lblWaterHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaterHeader.Location = New System.Drawing.Point(6, 192)
        Me.lblWaterHeader.Name = "lblWaterHeader"
        Me.lblWaterHeader.Size = New System.Drawing.Size(176, 17)
        Me.lblWaterHeader.TabIndex = 13
        Me.lblWaterHeader.Text = "Appliances with Water Use"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.txtTotalDailyCost)
        Me.GroupBox2.Controls.Add(Me.txtSelectedAppliance)
        Me.GroupBox2.Controls.Add(Me.lblSelectedAppliance)
        Me.GroupBox2.Controls.Add(Me.lblTotalDailyCost)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 347)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 138)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary of Selection"
        '
        'txtTotalDailyCost
        '
        Me.txtTotalDailyCost.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTotalDailyCost.Location = New System.Drawing.Point(160, 84)
        Me.txtTotalDailyCost.Name = "txtTotalDailyCost"
        Me.txtTotalDailyCost.Size = New System.Drawing.Size(146, 22)
        Me.txtTotalDailyCost.TabIndex = 12
        Me.txtTotalDailyCost.TabStop = False
        '
        'txtSelectedAppliance
        '
        Me.txtSelectedAppliance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSelectedAppliance.Location = New System.Drawing.Point(160, 45)
        Me.txtSelectedAppliance.Name = "txtSelectedAppliance"
        Me.txtSelectedAppliance.Size = New System.Drawing.Size(146, 22)
        Me.txtSelectedAppliance.TabIndex = 11
        Me.txtSelectedAppliance.TabStop = False
        '
        'lblSelectedAppliance
        '
        Me.lblSelectedAppliance.AutoSize = True
        Me.lblSelectedAppliance.Location = New System.Drawing.Point(7, 48)
        Me.lblSelectedAppliance.Name = "lblSelectedAppliance"
        Me.lblSelectedAppliance.Size = New System.Drawing.Size(129, 17)
        Me.lblSelectedAppliance.TabIndex = 8
        Me.lblSelectedAppliance.Text = "Selected Appliance"
        '
        'lblTotalDailyCost
        '
        Me.lblTotalDailyCost.AutoSize = True
        Me.lblTotalDailyCost.Location = New System.Drawing.Point(7, 87)
        Me.lblTotalDailyCost.Name = "lblTotalDailyCost"
        Me.lblTotalDailyCost.Size = New System.Drawing.Size(107, 17)
        Me.lblTotalDailyCost.TabIndex = 10
        Me.lblTotalDailyCost.Text = "Total Daily Cost"
        '
        'txtAddToList
        '
        Me.txtAddToList.Location = New System.Drawing.Point(378, 180)
        Me.txtAddToList.Name = "txtAddToList"
        Me.txtAddToList.Size = New System.Drawing.Size(106, 25)
        Me.txtAddToList.TabIndex = 5
        Me.txtAddToList.Text = "Add to List"
        Me.txtAddToList.UseVisualStyleBackColor = True
        '
        'ListViewAppliances
        '
        Me.ListViewAppliances.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewAppliances.Location = New System.Drawing.Point(511, 42)
        Me.ListViewAppliances.Name = "ListViewAppliances"
        Me.ListViewAppliances.ShowItemToolTips = True
        Me.ListViewAppliances.Size = New System.Drawing.Size(459, 443)
        Me.ListViewAppliances.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewAppliances.TabIndex = 27
        Me.ListViewAppliances.TabStop = False
        Me.ListViewAppliances.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Appliance Name"
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "-"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 30
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Hours Per Day"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "-"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 30
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cost Per Day"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 80
        '
        'btnSaveList
        '
        Me.btnSaveList.Location = New System.Drawing.Point(378, 211)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(106, 25)
        Me.btnSaveList.TabIndex = 6
        Me.btnSaveList.Text = "Save List"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'btnViewkWh
        '
        Me.btnViewkWh.Location = New System.Drawing.Point(378, 325)
        Me.btnViewkWh.Name = "btnViewkWh"
        Me.btnViewkWh.Size = New System.Drawing.Size(106, 27)
        Me.btnViewkWh.TabIndex = 8
        Me.btnViewkWh.Text = "View kWh"
        Me.btnViewkWh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 495)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "*Drag and Drop a text file anywhere on the form to update kWh values."
        '
        'ctrlSaveFileDialog
        '
        '
        'Reuben_Ellis_P4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 521)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewkWh)
        Me.Controls.Add(Me.btnSaveList)
        Me.Controls.Add(Me.ListViewAppliances)
        Me.Controls.Add(Me.txtAddToList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtHoursPerDay)
        Me.Controls.Add(Me.txtApplianceKWH)
        Me.Controls.Add(Me.txtCostPerKWH)
        Me.Controls.Add(Me.cboAppliance)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Reuben_Ellis_P4"
        Me.Text = "Utility Appliance Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents txtHoursPerDay As TextBox
    Friend WithEvents txtApplianceKWH As TextBox
    Friend WithEvents txtCostPerKWH As TextBox
    Friend WithEvents cboAppliance As ComboBox
    Friend WithEvents lblHoursPerDay As Label
    Friend WithEvents lblApplianceKWH As Label
    Friend WithEvents lblCostPerKWH As Label
    Friend WithEvents lblAppliance As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotalDailyCost As TextBox
    Friend WithEvents txtSelectedAppliance As TextBox
    Friend WithEvents lblSelectedAppliance As Label
    Friend WithEvents lblTotalDailyCost As Label
    Friend WithEvents txtAddToList As Button
    Friend WithEvents txtCostPerGallon As TextBox
    Friend WithEvents lblWaterPerHour As Label
    Friend WithEvents txtWaterPerHour As TextBox
    Friend WithEvents lblCostPerGallon As Label
    Friend WithEvents lblWaterHeader As Label
    Friend WithEvents ListViewAppliances As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnSaveList As Button
    Friend WithEvents btnViewkWh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ctrlSaveFileDialog As SaveFileDialog
End Class
