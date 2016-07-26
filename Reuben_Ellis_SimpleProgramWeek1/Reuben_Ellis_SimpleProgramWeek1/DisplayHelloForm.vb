Imports System.ComponentModel
Imports System.Globalization
Imports System.Text
Imports System.Threading

Public Class DisplayHelloForm

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnClickHere_Click(sender As Object, e As EventArgs) Handles btnClickHere.Click
        'Declare variable to randomally change text color
        Dim randomGenerator As New Random

        'Changes the lable color randomally on each click
        lblHello.ForeColor = Color.FromArgb(255, randomGenerator.Next(0, 255), randomGenerator.Next(0, 255), randomGenerator.Next(0, 255))
        If (lblHello.Text = "Hello!") Then
            lblHello.Text = "Hola!"
            lblHello.Top = 35
        ElseIf (lblHello.Text = "Hola!") Then
            lblHello.Text = "Ciao!"
            lblHello.Top = 90
            lblHello.Left = 12
        ElseIf (lblHello.Text = "Ciao!") Then
            lblHello.Text = "Salve!"
            lblHello.Top = 90
            lblHello.Left = 235
        ElseIf (lblHello.Text = "Salve!") Then
            lblHello.Text = "Hello!"
            lblHello.Top = 145
            lblHello.Left = 125
        End If
    End Sub
End Class