Public Class Checkout_Process_Customer_Authentication
    Public phoneNumber As String
    Public okCancelResults As String

    Private Sub Checkout_Process_Customer_Authentication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtRegisterAnAccount_Click(sender As Object, e As EventArgs) Handles txtRegisterAnAccount.Click
        Dim openCustomerRegistrationForm As CustomerRegistrationForm
        openCustomerRegistrationForm = CustomerRegistrationForm
        openCustomerRegistrationForm.Show()
        Me.Close()

    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click

        okCancelResults = MsgBox("Customer Transaction will be cancelled.  Do you want to continue?", vbOKCancel)
        If (okCancelResults = DialogResult.OK) Then
            Me.Close()
        Else
            MsgBox("Please enter customer phone number to proceed")
        End If
    End Sub
End Class