Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cbtn_login_Click(sender, e)
        End If
    End Sub

    Private Sub cbtn_login_Click(sender As Object, e As EventArgs) Handles cbtn_login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT user_id FROM users WHERE username = @username AND password = @password"
            COMMAND = New MySqlCommand(Query, conn)
            COMMAND.Parameters.AddWithValue("@username", txtbox_username.Text)
            COMMAND.Parameters.AddWithValue("@password", txtbox_password.Text)
            READER = COMMAND.ExecuteReader
            If READER.Read() Then
                Dim userID As Integer = READER("user_id")
                MessageBox.Show("Login successful!")
                Dim mainForm As New Mainform()
                mainForm.UserID = userID
                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username and password are incorrect!")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub cbtn_signup_Click(sender As Object, e As EventArgs) Handles cbtn_signup.Click
        Dim registrationForm As New RegistrationForm
        Me.Hide()
        registrationForm.Show()
    End Sub
End Class