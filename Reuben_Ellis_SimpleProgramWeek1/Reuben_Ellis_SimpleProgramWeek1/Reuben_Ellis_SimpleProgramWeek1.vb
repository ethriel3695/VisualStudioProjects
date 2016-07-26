Public Class Reuben_Ellis_SimpleProgramWeek1
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnOpenDisplayWindow_Click(sender As Object, e As EventArgs) Handles btnOpenDisplayWindow.Click
        Dim openWindow As DisplayHelloForm
        openWindow = DisplayHelloForm
        'Open the interaction window
        openWindow.Show()

    End Sub
End Class
