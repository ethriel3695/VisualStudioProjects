Imports System.IO
Public Class Reuben_Ellis_P4
    'Global variable used for all methods
    'Global data type Double variables
    Public costPerKWH As Double
    Public costPerGallon As Double
    Public numberOfWatts As Double
    Public waterPerHour As Double
    Public hoursPerDay As Double
    Public totalCost As Double

    Public defaultkWh(8) As Double
    Public utilityAppliances(8) As String

    'Global data type Integer variable
    Public columnCount As Integer

    'Global data type String variables
    Public selectedAppliance As String
    Public listAppliances(4) As String
    Public savedInfo As String
    Public Property InitialDirectory As String

    'Global data type List of strings variable
    Public listColumns As New List(Of String)

    'Global data type ListViewItem variable
    Public fullListItem As ListViewItem
    Public comboBoxValues As New Dictionary(Of String, String)()


    Private Sub Reuben_Ellis_P4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Allows for a file to be ingested by the application
        Me.AllowDrop = True

        utilityAppliances = {"A/C Window Unit", "Dishwasher", "Dryer", "Electric Fireplace",
            "Humidifier", "None", "Toaster", "Washer"}
        defaultkWh = {0.5, 1.5, 2, 1.5, 0.17, 0, 1.2, 0.5}

        cboAppliance.MaxDropDownItems = utilityAppliances.Length
        For Each appliance As String In utilityAppliances
            If Not (appliance Is Nothing) Then
                cboAppliance.Items.Add(appliance)
            End If
        Next

        'These lables and textboxes are not visible when the page loads
        lblWaterHeader.Visible = False
        lblWaterPerHour.Visible = False
        lblCostPerGallon.Visible = False
        txtWaterPerHour.Visible = False
        txtCostPerGallon.Visible = False

        'Populates the column headings in the listview
        ListViewAppliances.View = View.Details
    End Sub

    Private Sub Reuben_Ellis_P4_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Try
            'Gets the Data from the dropped file
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            'Creates a list to store the values within the text file
            Dim newkWhList As New List(Of Double)

            For Each path In files
                'Reads each value within the text file
                Dim testFile As New IO.StreamReader(path)
                'A while loop which gets all values within the text file until no more values exist
                While Not testFile.EndOfStream
                    'Adds each value read to the list
                    newkWhList.Add(testFile.ReadLine())
                End While
            Next
            For index As Integer = 0 To newkWhList.Count - 1
                'Replaces the default kWh value with the test file value
                defaultkWh(index) = newkWhList(index)
            Next index
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Reuben_Ellis_P4_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub cboAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAppliance.SelectedIndexChanged
        Try
            checkNumeric()

            'Sets the value of the combo box to a variable
            selectedAppliance = cboAppliance.Text.ToString

            'Places the value of the combo box into the selected appliance textbox
            txtSelectedAppliance.Text = selectedAppliance

            If cboAppliance.SelectedIndex > -1 Then
                Dim index As Integer = cboAppliance.SelectedIndex
                txtApplianceKWH.Text = CStr(defaultkWh(index))
            End If

            'If-Else statement to determine if the appliance uses water
            If cboAppliance.Text = "Humidifier" Or cboAppliance.Text = "Washer" Or
                cboAppliance.Text = "Dishwasher" Then

                'Sets the labels to visible if the appliance uses water
                lblWaterHeader.Visible = True
                lblWaterPerHour.Visible = True
                lblCostPerGallon.Visible = True
                txtWaterPerHour.Visible = True
                txtCostPerGallon.Visible = True

            Else

                'Sets the labels as not visible if the appliance does not use water
                lblWaterHeader.Visible = False
                lblWaterPerHour.Visible = False
                lblCostPerGallon.Visible = False
                txtWaterPerHour.Visible = False
                txtCostPerGallon.Visible = False

                'Checks to see if the textbox fields on the page are numeric
                If IsNumeric(txtCostPerKWH.Text) And IsNumeric(txtApplianceKWH.Text) And
                    IsNumeric(txtCostPerGallon.Text) And IsNumeric(txtWaterPerHour.Text) And
                    IsNumeric(txtHoursPerDay.Text) Then

                    'Calls a method to check numeric values of textboxes
                    check24()

                Else
                    checkNumeric()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCostPerKWH_TextChanged(sender As Object, e As EventArgs) Handles txtCostPerKWH.TextChanged
        Try
            'if-else statement which ensures the application functions only if a combo box field is selected
            If cboAppliance.Text = "Toaster" Or cboAppliance.Text = "Dryer" Or
                cboAppliance.Text = "A/C Window Unit" Or cboAppliance.Text = "Electric Fireplace" Or
                cboAppliance.Text = "Humidifier" Or cboAppliance.Text = "Washer" Or
                cboAppliance.Text = "Dishwasher" Then

                'if-else statement that makes sure the program only calculates numeric numbers
                If IsNumeric(txtCostPerKWH.Text) And IsNumeric(txtApplianceKWH.Text) And
                    IsNumeric(txtCostPerGallon.Text) And IsNumeric(txtWaterPerHour.Text) And
                    IsNumeric(txtHoursPerDay.Text) Then
                    costPerKWH = Double.Parse(txtCostPerKWH.Text)
                    check24()
                Else
                    checkNumeric()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtApplianceKWH_TextChanged(sender As Object, e As EventArgs) Handles txtApplianceKWH.TextChanged
        Try
            'if-else statement which ensures the application functions only if a combo box field is selected
            If cboAppliance.Text = "Toaster" Or cboAppliance.Text = "Dryer" Or
                cboAppliance.Text = "A/C Window Unit" Or cboAppliance.Text = "Electric Fireplace" Or
                cboAppliance.Text = "Humidifier" Or cboAppliance.Text = "Washer" Or
                cboAppliance.Text = "Dishwasher" Then

                'if-else statement that makes sure the program only calculates numeric numbers
                If IsNumeric(txtCostPerKWH.Text) And IsNumeric(txtApplianceKWH.Text) And
                    IsNumeric(txtCostPerGallon.Text) And IsNumeric(txtWaterPerHour.Text) And
                    IsNumeric(txtHoursPerDay.Text) Then
                    numberOfWatts = Double.Parse(txtApplianceKWH.Text)
                    check24()
                Else
                    checkNumeric()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtHoursPerDay_TextChanged(sender As Object, e As EventArgs) Handles txtHoursPerDay.TextChanged
        Try
            'if-else statement which ensures the application functions only if a combo box field is selected
            If cboAppliance.Text = "Toaster" Or cboAppliance.Text = "Dryer" Or
                cboAppliance.Text = "A/C Window Unit" Or cboAppliance.Text = "Electric Fireplace" Or
                cboAppliance.Text = "Humidifier" Or cboAppliance.Text = "Washer" Or
                cboAppliance.Text = "Dishwasher" Then

                'if-else statement that makes sure the program only calculates numeric numbers
                If IsNumeric(txtCostPerKWH.Text) And IsNumeric(txtApplianceKWH.Text) And
                    IsNumeric(txtCostPerGallon.Text) And IsNumeric(txtWaterPerHour.Text) And
                    IsNumeric(txtHoursPerDay.Text) Then
                    hoursPerDay = Double.Parse(txtHoursPerDay.Text)
                    check24()
                Else
                    checkNumeric()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtWaterPerHour_TextChanged(sender As Object, e As EventArgs) Handles txtWaterPerHour.TextChanged
        Try
            'if-else statement which ensures the application functions only if a combo box field is selected
            If cboAppliance.Text = "Washer" Or cboAppliance.Text = "Dishwasher" Or
            cboAppliance.Text = "Humidifier" Then

                'if-else statement that makes sure the program only calculates numeric numbers
                If IsNumeric(txtCostPerKWH.Text) And IsNumeric(txtApplianceKWH.Text) And
                    IsNumeric(txtCostPerGallon.Text) And IsNumeric(txtWaterPerHour.Text) And
                    IsNumeric(txtHoursPerDay.Text) Then
                    waterPerHour = Double.Parse(txtWaterPerHour.Text)
                    check24()
                Else
                    checkNumeric()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtCostPerGallon_TextChanged(sender As Object, e As EventArgs) Handles txtCostPerGallon.TextChanged
        Try
            'if-else statement which ensures the application functions only if a combo box field is selected
            If cboAppliance.Text = "Washer" Or cboAppliance.Text = "Dishwasher" Or
            cboAppliance.Text = "Humidifier" Then

                'if-else statement that makes sure the program only calculates numeric numbers
                If IsNumeric(txtCostPerKWH.Text) And IsNumeric(txtApplianceKWH.Text) And
                    IsNumeric(txtCostPerGallon.Text) And IsNumeric(txtWaterPerHour.Text) And
                    IsNumeric(txtHoursPerDay.Text) Then
                    costPerGallon = Double.Parse(txtCostPerGallon.Text)
                    check24()
                Else
                    checkNumeric()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnViewkWh_Click(sender As Object, e As EventArgs) Handles btnViewkWh.Click

        Dim utilityList As String = String.Empty

        For index As Integer = 0 To utilityAppliances.Length - 1
            utilityList &= utilityAppliances(index) & " = " & defaultkWh(index) & Environment.NewLine
        Next

        MsgBox(utilityList)
    End Sub

    Private Sub txtAddToList_Click(sender As Object, e As EventArgs) Handles txtAddToList.Click
        'If-Else statement to check if user has finished filling out the form before trying to add an item
        If Not selectedAppliance = "" And Not selectedAppliance = "None" And
            hoursPerDay > 0 And totalCost > 0 Then

            ListViewAppliances.ShowItemToolTips = True
            'Assign values to the listview columns
            listAppliances(0) = txtSelectedAppliance.Text
            listAppliances(1) = "-"
            listAppliances(2) = txtHoursPerDay.Text
            listAppliances(3) = "-"
            listAppliances(4) = txtTotalDailyCost.Text

            'Creates a list of the above values
            fullListItem = New ListViewItem(listAppliances)
            ListViewAppliances.Items.Add(fullListItem)
        Else
            MsgBox("Please finish entering information for the Appliance!")
        End If
    End Sub

    Private Sub check24()
        Try
            'NOTE: Industry standards for k/Wh cost and usage obtained from 
            'http://www.siliconvalleypower.com/for-residents/save-energy/appliance-energy-use-chart

            'NOTE: Industry standards for water use and cost per gallon obtained from
            'https://www3.epa.gov/watersense/our_water/understanding_your_bill.html
            'http://www.alternet.org/story/141751/how_much_water_do_you_use_here's_some_quick_numbers

            'if-else statement checking to make sure numeric values are within accepted range
            If hoursPerDay >= 0 And hoursPerDay <= 24 Then
                If costPerKWH < 0 Or costPerKWH > 1.5 Then
                    MsgBox("Cost must be within a valid industry range. Please enter a number 
                        greater than $0.00 and less than $1.50 per k/Wh")
                ElseIf numberOfWatts < 0 Or numberOfWatts > 25 Then
                    MsgBox("kilowatts usage must be within a valid industry range. Please enter a number 
                        greater than 0 and less than 25 k/Wh")
                ElseIf waterPerHour < 0 Or waterPerHour > 100 Then
                    MsgBox("Water usage must be within a valid industry range. Please enter a number 
                        greater than 0 and less than 100 gallons per hour")
                ElseIf costPerGallon < 0 Or costPerGallon > 0.1 Then
                    MsgBox("Cost per gallon of water must be within a valid industry range. 
                        Please enter a number greater than $0.00 and less than $0.10 k/Wh")
                Else
                    performCalcNMsg()
                End If
            Else
                MsgBox("Hour used per day must be 0 - 24.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub performCalcNMsg()
        Try
            'If-elseIf statement ensuring calculations are complete only when all three fields are filled in
            If cboAppliance.Text = "Toaster" Or cboAppliance.Text = "Dryer" Or
                cboAppliance.Text = "A/C Window Unit" Or
                cboAppliance.Text = "Electric Fireplace" Then
                If costPerKWH > 0 And numberOfWatts > 0 And hoursPerDay > 0 Then

                    totalCost = costPerKWH * numberOfWatts * hoursPerDay
                    txtTotalDailyCost.Text = String.Format("{0:C}", totalCost)
                Else
                    totalCost = 0
                    txtTotalDailyCost.Text = String.Format("{0:C}", totalCost)
                End If
            ElseIf cboAppliance.Text = "Washer" Or cboAppliance.Text = "Dishwasher" Or
            cboAppliance.Text = "Humidifier" Then
                If costPerKWH > 0 And numberOfWatts > 0 And
                    hoursPerDay > 0 And waterPerHour > 0 And costPerGallon > 0 Then

                    totalCost = costPerKWH * numberOfWatts * hoursPerDay * waterPerHour * costPerGallon
                    txtTotalDailyCost.Text = String.Format("{0:C}", totalCost)
                Else
                    totalCost = 0
                    txtTotalDailyCost.Text = String.Format("{0:C}", totalCost)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkNumeric()
        Try
            'if-else statement which checks to make sure each textbox contains numbers
            If Not IsNumeric(txtCostPerKWH.Text) And
                Not txtCostPerKWH.Text = "." Then
                MsgBox("Cost per kWh must be numeric.")
            Else
            End If

            If Not IsNumeric(txtApplianceKWH.Text) And
                Not txtApplianceKWH.Text = "." Then
                MsgBox("Kilowatts must be numeric.")
            Else
            End If

            If Not IsNumeric(txtHoursPerDay.Text) And
                Not txtHoursPerDay.Text = "." Then
                MsgBox("Hours used per day must be numeric.")
            Else
            End If

            If Not IsNumeric(txtWaterPerHour.Text) And
                Not txtWaterPerHour.Text = "." Then
                MsgBox("Water used per hour must be numeric.")
            Else
            End If

            If Not IsNumeric(txtCostPerGallon.Text) And
                Not txtCostPerGallon.Text = "." Then
                MsgBox("Cost per gallon must be numeric.")
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clear all textbox, combobox and variable values
        cboAppliance.SelectedItem = "None"

        txtApplianceKWH.Clear()
        txtCostPerKWH.Clear()
        txtHoursPerDay.Clear()
        ListViewAppliances.Items.Clear()
        txtTotalDailyCost.Clear()
        txtSelectedAppliance.Clear()
        txtWaterPerHour.Clear()
        txtCostPerGallon.Clear()

        costPerKWH = 0
        numberOfWatts = 0
        hoursPerDay = 0
        totalCost = 0
        waterPerHour = 0
        costPerGallon = 0

        txtApplianceKWH.Text = 0
        txtCostPerKWH.Text = 0
        txtHoursPerDay.Text = 0
        txtWaterPerHour.Text = 0
        txtCostPerGallon.Text = 0
        defaultkWh = {0.5, 1.5, 2, 1.5, 0.17, 0, 1.2, 0.5}

    End Sub

    Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        'If-else statement checking if the List has any items before allowing user to save a file
        If Not ListViewAppliances.Items.Count = 0 Then

            'Set the default save path to the Desktop of any user
            ctrlSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            'Set the default file name of the text file
            ctrlSaveFileDialog.FileName = "Ellis_Reuben.txt"

            'Set the default file type to either txt or all file types
            ctrlSaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            ctrlSaveFileDialog.FilterIndex = 2

            'Provides a title message for the user on the save dialog window
            ctrlSaveFileDialog.Title = "Please Select a Location to Save the File"

            'If a user changes the save location, the save location will be the same
            'next time the save dialog window opens
            ctrlSaveFileDialog.RestoreDirectory = True

            'Opens the Save Dialog window
            ctrlSaveFileDialog.ShowDialog()
        Else
            MsgBox("Please add utility items to the list. The list is empty!")
        End If
    End Sub

    Private Sub ctrlSaveFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctrlSaveFileDialog.FileOk

        'Initializes the value of the file name
        savedInfo = ctrlSaveFileDialog.FileName

        'Declares and Initializes the StreamWriter variable
        Dim savedInfoWriter As New IO.StreamWriter(savedInfo)

        'Initializes values for the column count of the list
        columnCount = ListViewAppliances.Columns.Count - 1

        'Adds the column names to a list variable
        For i As Integer = 0 To columnCount
            listColumns.Add(ListViewAppliances.Columns(i).Text)
        Next

        'Goes through the list of columns and puts them in the text file with a specific format
        For Each columnname In listColumns
            'TODO: format column header
            savedInfoWriter.Write(String.Format("{0,-25}", columnname))

        Next

        'Goes through the list of items in the ListView and puts them in the text file
        'with a specific format
        For Each item As ListViewItem In ListViewAppliances.Items
            savedInfoWriter.Write(String.Format("{0,-27}{1,-30}{2,-20}{3,-28}{4,-26}",
                vbCrLf & item.SubItems(0).Text, item.SubItems(1).Text,
                item.SubItems(2).Text, item.SubItems(3).Text, item.SubItems(4).Text))
        Next

        'Closes the StreamWriter connection so the file can be written to again if necessary
        savedInfoWriter.Close()
    End Sub

End Class
