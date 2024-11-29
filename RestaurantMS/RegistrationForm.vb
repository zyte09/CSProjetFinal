Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class RegistrationForm
    Private Sub cbtn_submit_Click(sender As Object, e As EventArgs) Handles cbtn_submit.Click
        Dim connectionString = "server=sql12.freesqldatabase.com;userid=sql12747542;password='g8UBST1eU4';database=sql12747542"
        Dim conn As New MySqlConnection(connectionString)
        Dim login As New LoginForm
        Try
            conn.Open()
            Dim query = "INSERT INTO users (first_name, last_name, username, password, phone_number, email, account_type) VALUES (@fName, @lName, @username, @password, @phoneNumber, @email, @accountType)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@fName", txtbox_first_name.Text)
            cmd.Parameters.AddWithValue("@lName", txtbox_last_name.Text)
            cmd.Parameters.AddWithValue("@username", txtbox_username.Text)
            cmd.Parameters.AddWithValue("@password", txtbox_password.Text)
            cmd.Parameters.AddWithValue("@phoneNumber", txtbox_phone_number.Text)
            cmd.Parameters.AddWithValue("@email", txtbox_email.Text)
            cmd.Parameters.AddWithValue("@accountType", "user")

            Dim result = cmd.ExecuteNonQuery

            If result > 0 Then
                MessageBox.Show("Data inserted successfully!")
            Else
                MessageBox.Show("No data inserted.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
            Hide()
            login.Show()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
        LoginForm.Show()
    End Sub
End Class