Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplayForm_Click(sender As Object, e As EventArgs) Handles btnDisplayForm.Click
        'Create an instance of MessageForm.
        Dim frmMessage As New MessageForm

        'Display the form in modal style.
        frmMessage.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
