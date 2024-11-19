Public Class Mainform
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class