Imports System.Data.SqlClient
Public Class Checkout_Process_Customer_Authentication
    Public phoneNumber As String
    Public okCancelResults As String
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public openCustomerRegistrationForm As CustomerRegistrationForm


    Private Sub Checkout_Process_Customer_Authentication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fills the form with database information and clears the textbox for user entry
        Me.CustomerTableAdapter.Fill(Me.Database1DataSet.Customer)
        Me.PhoneNumberTextBox.Clear()

    End Sub

    Private Sub txtRegisterAnAccount_Click(sender As Object, e As EventArgs) Handles txtRegisterAnAccount.Click
        'Opens the customer registration form
        openCustomerRegistrationForm = CustomerRegistrationForm
        openCustomerRegistrationForm.Show()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        'Checks with the user to make sure they want to cancel the customer authentication process
        okCancelResults = MsgBox("Customer Transaction will be cancelled.  Do you want to continue?", vbOKCancel)
        If (okCancelResults = DialogResult.OK) Then
            Me.Close()
        Else
            MsgBox("Please enter customer phone number to proceed")
        End If
    End Sub

    Private Sub txtNext_Click(sender As Object, e As EventArgs) Handles txtNext.Click
        'Provides a validation message when user enters a phone number and presses the Finish button
        MsgBox("User Validated! Proceed with Checkout!")
        Me.Close()
    End Sub
End Class