Imports MySql.Data.MySqlClient

Public Class RegistrationForm
    Private Sub cbtn_submit_Click(sender As Object, e As EventArgs) Handles cbtn_submit.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtbox_first_name.Text) Then
            MessageBox.Show("First name cannot be empty.")
            txtbox_first_name.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbox_last_name.Text) Then
            MessageBox.Show("Last name cannot be empty.")
            txtbox_last_name.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbox_email.Text) Then
            MessageBox.Show("Email cannot be empty.")
            txtbox_email.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbox_phone_number.Text) OrElse txtbox_phone_number.Text.Replace(" ", "").Length <> 11 OrElse Not txtbox_phone_number.Text.StartsWith("09") Then
            MessageBox.Show("Phone number must be exactly 11 digits and start with '09'.")
            txtbox_phone_number.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbox_address.Text) Then
            MessageBox.Show("Address cannot be empty.")
            txtbox_address.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbox_username.Text) OrElse txtbox_username.Text.Length <= 4 Then
            MessageBox.Show("Username must be more than 4 characters.")
            txtbox_username.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbox_password.Text) OrElse txtbox_password.Text.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.")
            txtbox_password.Focus()
            Return
        End If

        ' Check if username is already taken
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim query = "SELECT COUNT(*) FROM users WHERE username = @username"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtbox_username.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Username taken. Please choose a different username.")
                    txtbox_username.Focus()
                    Return
                End If
            End Using
        End Using

        ' Insert new user
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                query = "INSERT INTO users (first_name, last_name, username, password, phone_number, email, address) 
                     VALUES (@fName, @lName, @username, @password, @phoneNumber, @Email, @Address)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fName", txtbox_first_name.Text)
                    cmd.Parameters.AddWithValue("@lName", txtbox_last_name.Text)
                    cmd.Parameters.AddWithValue("@username", txtbox_username.Text)
                    cmd.Parameters.AddWithValue("@password", txtbox_password.Text)
                    cmd.Parameters.AddWithValue("@phoneNumber", txtbox_phone_number.Text.Replace(" ", ""))
                    cmd.Parameters.AddWithValue("@Email", txtbox_email.Text)
                    cmd.Parameters.AddWithValue("@Address", txtbox_address.Text)

                    Dim result = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Registration successful!")
                        Hide()
                        LoginForm.Show()
                    Else
                        MessageBox.Show("Registration failed. Please try again.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub txtbox_phone_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_phone_number.KeyPress
        ' Allow only digits and control keys
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbox_phone_number_TextChanged(sender As Object, e As EventArgs) Handles txtbox_phone_number.TextChanged
        Dim text As String = txtbox_phone_number.Text.Replace(" ", "")
        If text.Length > 11 Then
            text = text.Substring(0, 11)
        End If

        Dim formattedText As String = ""
        If text.Length > 0 Then
            formattedText = text.Substring(0, Math.Min(4, text.Length))
        End If
        If text.Length > 4 Then
            formattedText &= " " & text.Substring(4, Math.Min(3, text.Length - 4))
        End If
        If text.Length > 7 Then
            formattedText &= " " & text.Substring(7, Math.Min(4, text.Length - 7))
        End If

        txtbox_phone_number.Text = formattedText
        txtbox_phone_number.SelectionStart = txtbox_phone_number.Text.Length
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub btn_visibility_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_visibility.MouseDown
        TogglePasswordVisibility(txtbox_password, btn_visibility, True)
    End Sub

    Private Sub btn_visibility_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_visibility.MouseUp
        TogglePasswordVisibility(txtbox_password, btn_visibility, False)
    End Sub

    Private Sub TogglePasswordVisibility(textBox As TextBox, button As Button, isVisible As Boolean)
        If isVisible Then
            textBox.PasswordChar = ControlChars.NullChar
            button.Image = My.Resources.Wvisibility_on
        Else
            textBox.PasswordChar = "●"c
            button.Image = My.Resources.Wvisibility_off
        End If
    End Sub

    ' Allow Enter key to submit the form
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub RegistrationForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cbtn_submit_Click(sender, e)
        End If
    End Sub

    Private Sub RegistrationForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
    End Sub
End Class