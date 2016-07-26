Imports System.Data.SqlClient
Public Class CustomerRegistrationForm
    Public openCheckoutProccessForm As Checkout_Process_Customer_Authentication
    Public firstName As String
    Public lastName As String
    Public phoneNumber As String
    Public customerAdapter As SqlDataAdapter
    Public sqlString As New SqlCommandBuilder(customerAdapter)
    Public customerRow As DataRow
    'Private connectionString As String = LearningTeam_D_KudlerCustomerProgram.Utility.GetConnectionString()
    'Public sqlConn As New SqlConnection(connectionString)

    Private Sub CustomerRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Database1DataSet.Customer)
        'CustomerFirstNameTextBox.Clear()
        'CustomerLastNameTextBox.Clear()
        'PhoneNumberTextBox.Clear()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'openCheckoutProccessForm = Checkout_Process_Customer_Authentication

        'Try
        '    customerRow = Database1DataSet.Customer.NewRow()
        '    firstName = CustomerFirstNameTextBox.Text
        '    lastName = CustomerLastNameTextBox.Text
        '    phoneNumber = PhoneNumberTextBox.Text

        '    customerRow(1) = firstName
        '    customerRow(2) = lastName
        '    customerRow(3) = phoneNumber

        '    Database1DataSet.Customer.Rows.Add(customerRow)
        '    Me.CustomerTableAdapter.Insert(firstName, lastName, phoneNumber)


        '    'Me.CustomerBindingSource.EndEdit()
        '    'sqlString.DataAdapter.Update(Me.Database1DataSet.Customer)

        '    'openCheckoutProccessForm.Show()
        '    Me.Close()
        'Catch ex As Exception
        '    MessageBox.Show(Me, "Error: " & ex.Message, "Save",
        '        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        CustomerTableAdapter.Fill(Me.Database1DataSet.Customer)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        firstName = CustomerFirstNameTextBox.Text
        lastName = CustomerLastNameTextBox.Text
        phoneNumber = PhoneNumberTextBox.Text
        Me.CustomerTableAdapter.Insert(firstName, lastName, phoneNumber)
        Me.CustomerTableAdapter.Update(Database1DataSet.Customer)
        Me.Close()
    End Sub

    Private Sub btnCancels_Click(sender As Object, e As EventArgs) Handles btnCancels.Click
        openCheckoutProccessForm = Checkout_Process_Customer_Authentication
        Me.CustomerBindingSource.CancelEdit()
        openCheckoutProccessForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerBindingSource.CurrentChanged

    End Sub
End Class