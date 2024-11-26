Imports MySql.Data.MySqlClient

Public Class RegistrationForm
    Private Sub cbtn_submit_Click(sender As Object, e As EventArgs) Handles cbtn_submit.Click
        Dim connectionString As String = "Server=localhost;Database=TestDB;Uid=root;Pwd=password;"
        Dim conn As New MySqlConnection(connectionString)
        Dim query As String = "INSERT INTO Users (first_name, last_name, username, password, phone_number, email, account_type) VALUES (@fName, @lName, @username, @password, @phoneNumber, @email, @accountType)"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@fName", txtbox_first_name.Text)
        cmd.Parameters.AddWithValue("@lName", txtbox_last_name.Text)
        cmd.Parameters.AddWithValue("@username", txtbox_username.Text)

    End Sub
End Class