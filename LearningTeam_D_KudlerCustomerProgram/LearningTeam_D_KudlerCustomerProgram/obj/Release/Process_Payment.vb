Public Class Process_Payment
    Public creditCardNumber As String
    Public expirationDate As Date
    Public CVV As Short
    Public orderAmount As Double
    Public totalCashReceived As Double
    Public changeDue As Double
    Private Sub Process_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.Database1DataSet.Payments)

    End Sub
End Class