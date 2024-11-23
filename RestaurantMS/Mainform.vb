Public Class Mainform
    Private Sub btn_logout_Click_1(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCurrentDate()
    End Sub

    Private Sub UpdateCurrentDate()
        current_datelabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
    End Sub
End Class