﻿Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub cbtn_login_Click(sender As Object, e As EventArgs) Handles cbtn_login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=sql12.freesqldatabase.com;userid=sql12747542;password='g8UBST1eU4';database=sql12747542"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM users WHERE username = '" & txtbox_username.Text & "' AND password = '" & txtbox_password.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Login successful!")
                Mainform.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate!")
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
