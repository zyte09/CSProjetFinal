Imports MySql.Data.MySqlClient

Public Class RegistrationForm
    Private Sub cbtn_submit_Click(sender As Object, e As EventArgs) Handles cbtn_submit.Click
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim conn As New MySqlConnection(connectionString)
        Dim login As New LoginForm

        Try
            conn.Open()
            Dim query = "INSERT INTO users (first_name, last_name, username, password, phone_number, email, address) 
                         VALUES (@fName, @lName, @username, @password, @phoneNumber, @Email, @Address)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@fName", txtbox_first_name.Text)
            cmd.Parameters.AddWithValue("@lName", txtbox_last_name.Text)
            cmd.Parameters.AddWithValue("@username", txtbox_username.Text)
            cmd.Parameters.AddWithValue("@password", txtbox_password.Text)
            cmd.Parameters.AddWithValue("@phoneNumber", txtbox_phone_number.Text)
            cmd.Parameters.AddWithValue("@Email", txtbox_email.Text)
            cmd.Parameters.AddWithValue("@Address", txtbox_address.Text)

            Dim result = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Registration successful!")
                Hide()
                login.Show()
            Else
                MessageBox.Show("Registration failed. Please try again.")
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