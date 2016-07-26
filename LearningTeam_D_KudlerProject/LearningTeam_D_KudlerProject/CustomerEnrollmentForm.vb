Imports System.Data
Imports System.Data.SqlClient
Public Class CustomerEnrollmentForm
    Public firstName As String
    Public lastName As String
    Public phoneNumber As String
    Public con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Try
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='c:\users\ethri\documents\visual studio 2015\Projects\LearningTeam_D_KudlerProject\LearningTeam_D_KudlerProject\Database1.mdf';Integrated Security=True;Connect Timeout=30"
            con.Open()
            cmd.Connection = con
            firstName = CustomerFirstNameTextBox.Text
            lastName = CustomerLastNameTextBox.Text
            phoneNumber = PhoneNumberTextBox.Text
            Using mycommand As SqlCommand = con.CreateCommand
                mycommand.CommandText = "Insert Into Customer(CustomerFirstName, CustomerLastName, PhoneNumber)
                    VALUES (@firstName, @lastName, @phoneNumber)"

                mycommand.Parameters.AddWithValue("@firstName", firstName)
                mycommand.Parameters.AddWithValue("@lastName", lastName)
                mycommand.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                mycommand.ExecuteNonQuery()
                'Me.Validate()

                'Me.CustomerBindingSource.EndEdit()
                'Me.CustomerTableAdapter.Insert(firstName, lastName, phoneNumber)
            End Using
        Catch ex As Exception
            MessageBox.Show("error while inserting records")
        Finally

            con.Close()

            Me.Close()
        End Try

    End Sub

    Private Sub CustomerEnrollmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Database1DataSet.Customer)

    End Sub
End Class
