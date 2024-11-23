Public Class Mainform
    Private SelectedButton As Button = Nothing

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCurrentDate()
        HighlightButton(btn_home)

        orderno_panel.Visible = True
        guesttable_panel.Visible = True
        receiptmenu_panel.Visible = True
        receipt_panel.Visible = True
        receipt_panel.Location = New Point(1046, 97)


        Debug.WriteLine($"Receipt Panel: {receipt_panel.Bounds}")
        Debug.WriteLine($"Order No Panel: {orderno_panel.Bounds}")
        Debug.WriteLine($"Guest Table Panel: {guesttable_panel.Bounds}")
        Debug.WriteLine($"Receipt Menu Panel: {receiptmenu_panel.Bounds}")
        Debug.WriteLine($"Cancel Order Button Location: {btn_cancelorder.Location}")
        Debug.WriteLine($"Send Order Button Location: {btn_sendorder.Location}")
        Debug.WriteLine($"Cancel Order Size: {btn_cancelorder.Size}")
        Debug.WriteLine($"Send Order Size: {btn_sendorder.Size}")
    End Sub


    Private Sub UpdateCurrentDate()
        current_datelabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
    End Sub

    Private Sub HighlightButton(button As Button)
        If SelectedButton IsNot Nothing Then
            ResetButtonAppearance(SelectedButton)
        End If

        ' Highlight the selected button
        button.BackColor = Color.FromArgb(118, 171, 174)
        button.ForeColor = Color.FromArgb(238, 238, 238)

        ' Update the selected button
        SelectedButton = button
    End Sub

    Private Sub ResetButtonAppearance(button As Button)
        button.BackColor = Color.Transparent
        button.ForeColor = Color.FromArgb(238, 238, 238)
    End Sub
    Private Sub btn_logout_Click_1(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        HighlightButton(btn_home)
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        HighlightButton(btn_menu)
    End Sub

    Private Sub btn_payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        HighlightButton(btn_payment)
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        HighlightButton(btn_orders)
    End Sub

    Private Sub btn_settings_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        HighlightButton(btn_settings)
    End Sub
End Class