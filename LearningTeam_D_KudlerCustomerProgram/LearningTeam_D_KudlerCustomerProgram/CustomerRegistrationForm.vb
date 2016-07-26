Imports System.Data.SqlClient
Public Class CustomerRegistrationForm
    Public openCheckoutProccessForm As Checkout_Process_Customer_Authentication
    Public customerID As Int32
    Public firstName As String
    Public lastName As String
    Public phoneNumber As String
    Public con As New SqlConnection
    Public cmd As New SqlCommand

    Private Sub CustomerRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fills the form with database information
        Me.CustomerTableAdapter.Fill(Me.Database1DataSet.Customer)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Sets a variable to the checkout customer form object
        openCheckoutProccessForm = Checkout_Process_Customer_Authentication

        Try
            'Sets connection string of the database
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\ethri\documents\visual studio 2015\Projects\LearningTeam_D_KudlerCustomerProgram\LearningTeam_D_KudlerCustomerProgram\Database1.mdf';Integrated Security=True;Connect Timeout=30"
            'Opens the connection string of the database
            con.Open()
            'Sets the sql command to the connection
            cmd.Connection = con
            'Initializes variables with the values from the 3 text boxes
            firstName = CustomerFirstNameTextBox.Text
            lastName = CustomerLastNameTextBox.Text
            phoneNumber = PhoneNumberTextBox.Text
            'Creates a SQL statement to insert records into the database
            Using mycommand As SqlCommand = con.CreateCommand
                mycommand.CommandText = "Insert Into Customer(CustomerFirstName, CustomerLastName, PhoneNumber)
                    VALUES (@firstName, @lastName, @phoneNumber)"

                mycommand.Parameters.AddWithValue("@firstName", firstName)
                mycommand.Parameters.AddWithValue("@lastName", lastName)
                mycommand.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                mycommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("error while inserting records")
        Finally
            'Always close a connection string after opening
            con.Close()
            'Opens the customer authentication form and closes the customer registration form
            openCheckoutProccessForm.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CustomerBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerBindingSource.CurrentChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Opens the customer authentication form, cancels edits, and closes the customer registration form
        openCheckoutProccessForm = Checkout_Process_Customer_Authentication
        Me.CustomerBindingSource.CancelEdit()
        openCheckoutProccessForm.Show()
        Me.Close()
    End Sub
End Class