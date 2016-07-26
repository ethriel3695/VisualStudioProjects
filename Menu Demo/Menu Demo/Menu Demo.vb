Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub mnuColorRed_Click(sender As Object, e As EventArgs) Handles mnuColorRed.Click
        'Set the label's foreground color to Red
        lblMessage.ForeColor = Color.Red
    End Sub

    Private Sub mnuColorGreen_Click(sender As Object, e As EventArgs) Handles mnuColorGreen.Click
        'Set the label's foreground color to Green
        lblMessage.ForeColor = Color.Green
    End Sub

    Private Sub mnuColorBlue_Click(sender As Object, e As EventArgs) Handles mnuColorBlue.Click
        'Set the label's foreground color to Blue
        lblMessage.ForeColor = Color.Blue
    End Sub

    Private Sub mnuColorBlack_Click(sender As Object, e As EventArgs) Handles mnuColorBlack.Click
        'Set the label's foreground color to Black
        lblMessage.ForeColor = Color.Black
    End Sub

    Private Sub mnuColorVisible_Click(sender As Object, e As EventArgs) Handles mnuColorVisible.Click
        'Make the label visible or invisible
        If mnuColorVisible.Checked = True Then
            lblMessage.Visible = True
        Else
            lblMessage.Visible = False
        End If
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'Display a simple About box
        MessageBox.Show("A Simple Menu System Demo")
    End Sub
End Class
