﻿Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class Mainform
    Public Property UserID As Integer
    Private SelectedButton As Button = Nothing
    Private isExiting As Boolean = False
    Private connectionString As String = "Server=127.0.0.1;userid=root;password='';Database=RestaurantMSDB"
    Private Const Tip0Amount As Decimal = CDec(0)
    Private Const Tip1Amount As Decimal = CDec(20)
    Private Const Tip2Amount As Decimal = CDec(30)
    Private Const Tip3Amount As Decimal = CDec(40)
    Private Const Tip4Amount As Decimal = CDec(50)

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCurrentDate()
        HighlightButton(btn_home)
        ShowPanel(home_panel)

        orderno_panel.Visible = True
        guesttable_panel.Visible = True
        receiptmenu_panel.Visible = True
        receipt_panel.Visible = False
        receipt_panel.Location = New Point(1046, 97)

        'Disble button at start
        btn_cancelorder.Enabled = False
        btn_sendorder.Enabled = False

        ' Set default tip amount
        HighlightTipButton(btn_tip1, Tip1Amount)
        HighlightPaymentButton(btn_cash)
        LoadOrderHistory()
        LoadUserData(UserID)

        searchresults_panel.Visible = False

        GreetUser()
        LoadRecentOrder()
        LoadMonthlyExpenses()
        LoadDailyExpenses()
    End Sub

    Private Sub Mainform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isExiting Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                e.Cancel = True
            Else
                isExiting = True
                Application.Exit()
            End If
        End If
    End Sub

    'Buttons'
    Private Sub btn_logout_Click_1(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        HighlightButton(btn_home)
        ShowPanel(home_panel)
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        ShowPanel(foodmenu_panel)
        ShowPanel(startermenu_panel)
    End Sub

    Private Sub btn_payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        HighlightButton(btn_payment)
        ShowPanel(payment_panel)
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        HighlightButton(btn_history)
        ShowPanel(history_panel)
        LoadOrderHistory()
    End Sub

    Private Sub btn_settings_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        HighlightButton(btn_settings)
        ShowPanel(settings_panel)
    End Sub

    Private Sub btn_starter_Click(sender As Object, e As EventArgs) Handles btn_starter.Click
        searchresults_panel.Visible = False
        HighlightMenuButton(btn_starter)
        ShowPanel(startermenu_panel)
        LoadFoodItems("Starter", startermenu_panel)
    End Sub

    Private Sub btn_maincourse_Click(sender As Object, e As EventArgs) Handles btn_maincourse.Click
        searchresults_panel.Visible = False
        HighlightMenuButton(btn_maincourse)
        ShowPanel(maincoursemenu_panel)
        LoadFoodItems("Main Course", maincoursemenu_panel)
    End Sub

    Private Sub btn_drinks_Click(sender As Object, e As EventArgs) Handles btn_drinks.Click
        searchresults_panel.Visible = False
        HighlightMenuButton(btn_drinks)
        ShowPanel(drinksmenu_panel)
        LoadFoodItems("Drinks", drinksmenu_panel)
    End Sub

    Private Sub btn_desserts_Click(sender As Object, e As EventArgs) Handles btn_desserts.Click
        searchresults_panel.Visible = False
        HighlightMenuButton(btn_desserts)
        ShowPanel(dessertsmenu_panel)
        LoadFoodItems("Desserts", dessertsmenu_panel)
    End Sub

    Private Sub btn_sendorder_Click(sender As Object, e As EventArgs) Handles btn_sendorder.Click
        Dim result = MessageBox.Show("Do you want to proceed to payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            HighlightButton(btn_payment)
            ShowPanel(payment_panel)

            ' Clear existing payment items
            paymentItem_panel.Controls.Clear()

            ' Add items to payment panel
            For Each receiptItem In receiptmenu_panel.Controls.OfType(Of ReceiptItemControl)
                Dim paymentItemControl As New PaymentItemControl
                paymentItemControl.ItemName = receiptItem.ItemName
                paymentItemControl.Category = GetItemCategory(receiptItem.ItemName)
                paymentItemControl.Price = GetItemPrice(receiptItem.ItemName)
                paymentItemControl.Quantity = receiptItem.Quantity
                paymentItemControl.Subtotal = paymentItemControl.Price * paymentItemControl.Quantity
                AddHandler paymentItemControl.ItemDeleted, AddressOf OnPaymentItemDeleted
                paymentItem_panel.Controls.Add(paymentItemControl)
            Next

            ' Update the order number label in the payment panel
            Dim nextOrderNumber As Integer = GetNextOrderNumber()
            orderNo_label.Text = "Order Number: " & nextOrderNumber.ToString()
            pOrderno_label.Text = "Order Number: " & nextOrderNumber.ToString()
        End If
    End Sub

    Private Sub btn_cancelorder_Click(sender As Object, e As EventArgs) Handles btn_cancelorder.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to cancel the order?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Clear items in receiptmenu_panel
            receiptmenu_panel.Controls.Clear()

            ' Update total
            UpdateTotalPrice()

            'Disable buttons after cancel
            btn_cancelorder.Enabled = False
            btn_sendorder.Enabled = False
        End If
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        Dim cashInput As Decimal
        If Decimal.TryParse(cashinput_text.Text, cashInput) Then
            Dim totalAmount As Decimal = CalcuTotalPrice() + (CalcuTotalPrice() * 0.1) + Decimal.Parse(prTipsno_label.Text.Replace("Php ", ""), Globalization.NumberStyles.Currency)
            If cashInput >= totalAmount Then
                Dim change As Decimal = cashInput - totalAmount
                If SaveOrderToDatabase() Then
                    MessageBox.Show($"Order has been successfully saved to the order history. Your change is Php {change:F2}.", "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear the receipt panel after saving the order
                    receiptmenu_panel.Controls.Clear()
                    UpdateTotalPrice()
                    btn_cancelorder.Enabled = False
                    btn_sendorder.Enabled = False
                    ' Hide receipt panel and show order history panel
                    receipt_panel.Visible = False
                    ShowPanel(history_panel)
                    LoadOrderHistory()
                Else
                    MessageBox.Show("Failed to save the order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Insufficient cash input. Please enter an amount greater than or equal to the total amount.", "Insufficient Cash", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Invalid cash input. Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_cash_Click(sender As Object, e As EventArgs) Handles btn_cash.Click
        HighlightPaymentButton(btn_cash)
    End Sub

    Private Sub btn_creditcard_Click(sender As Object, e As EventArgs) Handles btn_creditcard.Click
        HighlightPaymentButton(btn_creditcard)
    End Sub

    Private Sub btn_gcash_Click(sender As Object, e As EventArgs) Handles btn_gcash.Click
        HighlightPaymentButton(btn_gcash)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        ShowPanel(profileedit_panel)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        ShowPanel(profile_panel)
    End Sub

    Private Sub btn_pass_Click(sender As Object, e As EventArgs) Handles btn_pass.Click
        ShowPanel(pass_panel)
    End Sub

    Private Sub btn_goback_Click(sender As Object, e As EventArgs) Handles btn_goback.Click
        ShowPanel(profileedit_panel)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(firstName_text.Text) Then
            MessageBox.Show("First name cannot be empty.")
            firstName_text.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(lastName_text.Text) Then
            MessageBox.Show("Last name cannot be empty.")
            lastName_text.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(email_text.Text) Then
            MessageBox.Show("Email cannot be empty.")
            email_text.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(phone_text.Text) Then
            MessageBox.Show("Phone number cannot be empty.")
            phone_text.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(address_text.Text) Then
            MessageBox.Show("Address cannot be empty.")
            address_text.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(username_text.Text) OrElse username_text.Text.Length <= 4 Then
            MessageBox.Show("Username must be more than 4 characters.")
            username_text.Focus()
            Return
        End If

        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim query = "UPDATE users SET first_name = @firstName, last_name = @lastName, email = @Email, phone_number = @phoneNumber, address = @Address, username = @Username WHERE user_id = @userID"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@firstName", firstName_text.Text.Trim())
                    cmd.Parameters.AddWithValue("@lastName", lastName_text.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", email_text.Text.Trim())
                    cmd.Parameters.AddWithValue("@phoneNumber", phone_text.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", address_text.Text.Trim())
                    cmd.Parameters.AddWithValue("@Username", username_text.Text.Trim())
                    cmd.Parameters.AddWithValue("@userID", UserID)

                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Profile updated successfully!")
                        LoadUserData(UserID)
                        ShowPanel(profile_panel)
                    Else
                        MessageBox.Show("Failed to update profile. Please try again.")
                    End If
                End Using
            Catch ex As MySqlException When ex.Number = 1062
                MessageBox.Show("Username taken. Please choose a different username.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        ShowPanel(profile_panel)
    End Sub

    Private Sub btn_changepass_Click(sender As Object, e As EventArgs) Handles btn_changepass.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(currentpass_text.Text) Then
            MessageBox.Show("Current password cannot be empty.")
            currentpass_text.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(newpass_text.Text) Then
            MessageBox.Show("New password cannot be empty.")
            newpass_text.Focus()
            Return
        End If

        If newpass_text.Text.Length < 8 Then
            MessageBox.Show("New password must be at least 8 characters long.")
            newpass_text.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(retype_text.Text) Then
            MessageBox.Show("Retype password cannot be empty.")
            retype_text.Focus()
            Return
        End If

        If newpass_text.Text <> retype_text.Text Then
            MessageBox.Show("New password and retype password do not match.")
            retype_text.Focus()
            Return
        End If

        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim query = "SELECT password FROM users WHERE user_id = @userID"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", UserID)
                    Dim currentPassword As String = cmd.ExecuteScalar().ToString()

                    If currentPassword <> currentpass_text.Text Then
                        MessageBox.Show("Current password is incorrect.")
                        currentpass_text.Focus()
                        Return
                    End If
                End Using

                ' Update the pass
                query = "UPDATE users SET password = @newPassword WHERE user_id = @userID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@newPassword", newpass_text.Text)
                    cmd.Parameters.AddWithValue("@userID", UserID)

                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Password updated successfully!")
                        ShowPanel(profileedit_panel)
                    Else
                        MessageBox.Show("Failed to update password. Please try again.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        PerformSearch()
    End Sub

    Private Sub btn_tip0_Click(sender As Object, e As EventArgs) Handles btn_tip0.Click
        HighlightTipButton(btn_tip0, Tip0Amount)
    End Sub

    Private Sub btn_tip1_Click(sender As Object, e As EventArgs) Handles btn_tip1.Click
        HighlightTipButton(btn_tip1, Tip1Amount)
    End Sub
    Private Sub btn_tip2_Click(sender As Object, e As EventArgs) Handles btn_tip2.Click
        HighlightTipButton(btn_tip2, Tip2Amount)
    End Sub
    Private Sub btn_tip3_Click(sender As Object, e As EventArgs) Handles btn_tip3.Click
        HighlightTipButton(btn_tip3, Tip3Amount)
    End Sub
    Private Sub btn_tip4_Click(sender As Object, e As EventArgs) Handles btn_tip4.Click
        HighlightTipButton(btn_tip4, Tip4Amount)
    End Sub

    Private Sub btn_visibility_current_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_visibility_current.MouseDown
        TogglePasswordVisibility(currentpass_text, btn_visibility_current, True)
    End Sub

    Private Sub btn_visibility_current_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_visibility_current.MouseUp
        TogglePasswordVisibility(currentpass_text, btn_visibility_current, False)
    End Sub

    Private Sub btn_visibility_new_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_visibility_new.MouseDown
        TogglePasswordVisibility(newpass_text, btn_visibility_new, True)
    End Sub

    Private Sub btn_visibility_new_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_visibility_new.MouseUp
        TogglePasswordVisibility(newpass_text, btn_visibility_new, False)
    End Sub

    Private Sub btn_visibility_retype_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_visibility_retype.MouseDown
        TogglePasswordVisibility(retype_text, btn_visibility_retype, True)
    End Sub

    Private Sub btn_visibility_retype_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_visibility_retype.MouseUp
        TogglePasswordVisibility(retype_text, btn_visibility_retype, False)
    End Sub

    'Ui Update'
    Private Sub UpdateCurrentDate()
        current_datelabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy | h:mm tt")
        time_label.Text = DateTime.Now.ToString("h:mm tt")
    End Sub

    Private Sub GreetUser()
        Dim firstName As String = GetFirstName(fullname_label.Text)
        Dim currentTime As DateTime = DateTime.Now
        Dim greeting As String

        If currentTime.Hour < 12 Then
            greeting = "Good Morning"
        ElseIf currentTime.Hour < 18 Then
            greeting = "Good Afternoon"
        Else
            greeting = "Good Evening"
        End If

        greet_label.Text = $"{greeting}, {firstName}!"
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

    Private Sub ShowPanel(panel As Panel)
        nav_panel.Visible = True

        ' Hide all panels first
        home_panel.Visible = False
        foodmenu_panel.Visible = False
        startermenu_panel.Visible = False
        maincoursemenu_panel.Visible = False
        drinksmenu_panel.Visible = False
        dessertsmenu_panel.Visible = False
        payment_panel.Visible = False
        history_panel.Visible = False
        settings_panel.Visible = False
        paymentreceipt_panel.Visible = False
        profile_panel.Visible = False
        profileedit_panel.Visible = False
        pass_panel.Visible = False
        searchresults_panel.Visible = False

        ' Hide receipt-related panels by default
        receipt_panel.Visible = False
        orderno_panel.Visible = False
        guesttable_panel.Visible = False
        receiptmenu_panel.Visible = False

        ' Show specific panel
        Select Case panel.Name
            Case "home_panel"
                home_panel.Visible = True
                HighlightButton(btn_home)

            Case "foodmenu_panel"
                foodmenu_panel.Visible = True
                HighlightButton(btn_menu)
                receipt_panel.Visible = True
                orderno_panel.Visible = True
                guesttable_panel.Visible = True
                receiptmenu_panel.Visible = True
                guesttable_panel.Location = New Point(27, 68)
                receiptmenu_panel.Location = New Point(27, 114)
                receipttotal_panel.Location = New Point(27, 387)
                HighlightMenuButton(btn_starter)
                LoadFoodItems("Starter", startermenu_panel)

            Case "startermenu_panel"
                foodmenu_panel.Visible = True
                startermenu_panel.Visible = True
                HighlightMenuButton(btn_starter)
                receipt_panel.Visible = True
                orderno_panel.Visible = True
                guesttable_panel.Visible = True
                receiptmenu_panel.Visible = True

            Case "maincoursemenu_panel"
                foodmenu_panel.Visible = True
                maincoursemenu_panel.Visible = True
                HighlightMenuButton(btn_maincourse)
                receipt_panel.Visible = True
                orderno_panel.Visible = True
                guesttable_panel.Visible = True
                receiptmenu_panel.Visible = True

            Case "drinksmenu_panel"
                foodmenu_panel.Visible = True
                drinksmenu_panel.Visible = True
                HighlightMenuButton(btn_drinks)
                receipt_panel.Visible = True
                orderno_panel.Visible = True
                guesttable_panel.Visible = True
                receiptmenu_panel.Visible = True

            Case "dessertsmenu_panel"
                foodmenu_panel.Visible = True
                dessertsmenu_panel.Visible = True
                HighlightMenuButton(btn_desserts)
                receipt_panel.Visible = True
                orderno_panel.Visible = True
                guesttable_panel.Visible = True
                receiptmenu_panel.Visible = True

            Case "payment_panel"
                payment_panel.Visible = True
                paymentreceipt_panel.Visible = True
                HighlightButton(btn_payment)

            Case "history_panel"
                history_panel.Visible = True
                HighlightButton(btn_history)

            Case "settings_panel"
                settings_panel.Visible = True
                profile_panel.Visible = True
                HighlightButton(btn_settings)

            Case "profile_panel"
                settings_panel.Visible = True
                profile_panel.Visible = True

            Case "profileedit_panel"
                settings_panel.Visible = True
                profileedit_panel.Visible = True
                LoadUserDataIntoTextBoxes(UserID)

            Case "pass_panel"
                settings_panel.Visible = True
                pass_panel.Visible = True

            Case Else
                Debug.WriteLine($"Unexpected panel name: {panel.Name}")
        End Select

        Debug.WriteLine($"Showing panel: {panel.Name}")
        Debug.WriteLine($"{panel.Name} visibility: {panel.Visible}")
        Debug.WriteLine($"Panel passed: {panel.Name}")
    End Sub

    Private Sub HighlightMenuButton(button As Button)
        ' Reset all menu buttons
        btn_starter.BackColor = Color.DarkGray
        btn_maincourse.BackColor = Color.DarkGray
        btn_drinks.BackColor = Color.DarkGray
        btn_desserts.BackColor = Color.DarkGray

        btn_starter.ForeColor = Color.FromArgb(238, 238, 238)
        btn_maincourse.ForeColor = Color.FromArgb(238, 238, 238)
        btn_drinks.ForeColor = Color.FromArgb(238, 238, 238)
        btn_desserts.ForeColor = Color.FromArgb(238, 238, 238)

        ' Highlight the selected button
        button.BackColor = Color.FromArgb(34, 40, 49)
        button.ForeColor = Color.FromArgb(238, 238, 238)
    End Sub

    Private Sub OnFoodItemClicked(sender As Object, e As EventArgs)
        Dim foodItemControl As FoodItemControl = CType(sender, FoodItemControl)
        ' Check if the item already exists in the receiptmenu_panel
        Dim existingItem As ReceiptItemControl = Nothing
        For Each control As Control In receiptmenu_panel.Controls
            If TypeOf control Is ReceiptItemControl Then
                Dim receiptItem As ReceiptItemControl = CType(control, ReceiptItemControl)
                If receiptItem.ItemName = foodItemControl.FoodName Then
                    existingItem = receiptItem
                    Exit For
                End If
            End If
        Next

        If existingItem IsNot Nothing Then
            ' Item exists, increment quantity
            Dim itemPrice As Decimal = GetItemPrice(foodItemControl.FoodName)
            existingItem.Price = itemPrice * existingItem.Quantity
        Else
            ' Add new item with quantity 1
            Dim itemPrice As Decimal = GetItemPrice(foodItemControl.FoodName)
            Dim receiptItemControl As New ReceiptItemControl()
            receiptItemControl.ItemName = foodItemControl.FoodName
            receiptItemControl.Quantity = 1
            receiptItemControl.Price = itemPrice
            receiptItemControl.FoodImage = foodItemControl.FoodImage

            AddHandler receiptItemControl.ItemIncremented, AddressOf OnItemIncremented
            AddHandler receiptItemControl.ItemDecremented, AddressOf OnItemDecremented
            AddHandler receiptItemControl.ItemCancelled, AddressOf OnItemCancelled

            receiptmenu_panel.Controls.Add(receiptItemControl)

            ' Enable button when an order added
            btn_cancelorder.Enabled = True
            btn_sendorder.Enabled = True

            ' Update the order number label in the receipt panel
            If receiptmenu_panel.Controls.Count = 1 Then
                Dim nextOrderNumber As Integer = GetNextOrderNumber()
                orderNumber_label.Text = "Order Number: " & nextOrderNumber.ToString()
            End If
        End If

        'Update total
        UpdateTotalPrice()
    End Sub

    Private Sub OnItemIncremented(sender As Object, e As EventArgs)
        Dim receiptItemControl As ReceiptItemControl = CType(sender, ReceiptItemControl)
        Dim itemPrice As Decimal = GetItemPrice(receiptItemControl.ItemName)
        receiptItemControl.Price = itemPrice * receiptItemControl.Quantity

        'Update total
        UpdateTotalPrice()
    End Sub

    Private Sub OnItemDecremented(sender As Object, e As EventArgs)
        Dim receiptItemControl As ReceiptItemControl = CType(sender, ReceiptItemControl)
        Dim itemPrice As Decimal = GetItemPrice(receiptItemControl.ItemName)
        receiptItemControl.Price = itemPrice * receiptItemControl.Quantity

        'Update total
        UpdateTotalPrice()
    End Sub

    Private Sub OnItemCancelled(sender As Object, e As EventArgs)
        Dim receiptItemControl As ReceiptItemControl = CType(sender, ReceiptItemControl)
        receiptmenu_panel.Controls.Remove(receiptItemControl)

        'Update total
        UpdateTotalPrice()
    End Sub

    Private Sub UpdateTotalPrice()
        Dim totalPrice As Decimal = CalcuTotalPrice()
        totalno_label.Text = $"Php{totalPrice:F2}"
        Debug.WriteLine($"Total Price: Php{totalPrice:F2}")
        UpdateLabels(totalPrice)
    End Sub

    Private Sub UpdateLabels(totalPrice As Decimal)
        ' Update the subtotal label
        subtotalno_label.Text = "Php " & totalPrice.ToString("N2")
        prSubtotalno_label.Text = subtotalno_label.Text ' Update prSubtotalno_label

        ' Calcu service charge 10% of subtotal
        Dim serviceCharge As Decimal = totalPrice * 0.1

        ' Update the service charge labels
        servicechargeno_label.Text = "Php " & serviceCharge.ToString("N2")
        prServiceno_label.Text = servicechargeno_label.Text ' Update prServiceno_label

        ' Calcu and update total label (subtotal + service charge)
        Dim total As Decimal = totalPrice + serviceCharge
        totalno_label.Text = "Php " & total.ToString("N2")

        ' Update paytotal_label total amount (subtotal + service charge)
        paytotal_label.Text = "Php " & total.ToString("N2")

        ' Get tip amount from prTipsno_label
        Dim tipAmount As Decimal = Decimal.Parse(prTipsno_label.Text.Replace("Php ", ""), Globalization.NumberStyles.Currency)

        ' Calcu and update total label for payment (subtotal + service charge + tip)
        Dim paymentTotal As Decimal = total + tipAmount

        ' Update prTotalno_label total amount
        prTotalno_label.Text = "Php " & paymentTotal.ToString("N2")
    End Sub

    Private Sub HighlightTipButton(button As Button, tipAmount As Decimal)
        ' Reset all tip buttons
        Dim tipButtons() As Button = {btn_tip0, btn_tip1, btn_tip2, btn_tip3, btn_tip4}
        For Each tipButton In tipButtons
            tipButton.BackColor = Color.LightGray
            tipButton.ForeColor = Color.FromArgb(0, 0, 0) ' Default text color
        Next

        ' Highlight the selected button
        button.BackColor = Color.FromArgb(34, 40, 49) ' Highlight color
        button.ForeColor = Color.FromArgb(238, 238, 238) ' Highlight text color

        ' Update the prTipsno_label with the selected tip amount
        prTipsno_label.Text = "Php " & tipAmount.ToString("N2")

        ' Update total
        UpdateTotalPrice()
    End Sub

    Private Sub HighlightPaymentButton(button As Button)
        ' Reset all payment buttons
        Dim paymentButtons() As Button = {btn_cash, btn_creditcard, btn_gcash}
        For Each paymentButton In paymentButtons
            paymentButton.BackColor = Color.LightGray
            paymentButton.ForeColor = Color.FromArgb(0, 0, 0) ' Default text color
        Next

        ' Highlight the selected button
        button.BackColor = Color.FromArgb(34, 40, 49) ' Highlight color
        button.ForeColor = Color.FromArgb(238, 238, 238) ' Highlight text color
    End Sub

    Private Sub HighlightMultipleMenuButtons(buttons As List(Of Button))
        ' Reset all menu buttons
        Dim menuButtons() As Button = {btn_starter, btn_maincourse, btn_drinks, btn_desserts}
        For Each menuButton In menuButtons
            menuButton.BackColor = Color.DarkGray
            menuButton.ForeColor = Color.FromArgb(238, 238, 238)
        Next

        ' Highlight the specified buttons
        For Each button In buttons
            button.BackColor = Color.FromArgb(34, 40, 49)
            button.ForeColor = Color.FromArgb(238, 238, 238)
        Next
    End Sub

    Private Sub TogglePasswordVisibility(textBox As TextBox, button As Button, isVisible As Boolean)
        If isVisible Then
            textBox.PasswordChar = ControlChars.NullChar
            button.Image = My.Resources.visibility_on
        Else
            textBox.PasswordChar = "●"c
            button.Image = My.Resources.visibility_off
        End If
    End Sub

    Private Sub OnOrderHistoryClicked(orderNumber As Integer)
        orderNo_label.Text = "Order Number: " & orderNumber.ToString()
        pOrderno_label.Text = "Order Number: " & orderNumber.ToString()
        LoadOrderDetails(orderNumber)
    End Sub

    'Load Data'
    Private Sub LoadOrderHistory()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT order_number, order_date, items, total_amount FROM order_history WHERE user_id = @userID ORDER BY order_date DESC"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", UserID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        orderhistory_panel.Controls.Clear()
                        Dim yOffset As Integer = 10

                        While reader.Read()
                            Dim orderNumber As Integer = reader("order_number")
                            Dim orderHistoryControl As New OrderHistoryControl()

                            orderHistoryControl.Location = New Point(10, yOffset)
                            orderHistoryControl.Width = orderhistory_panel.ClientSize.Width - 20 'Width to fit within the panel
                            orderHistoryControl.LoadOrderDetails(orderNumber)

                            AddHandler orderHistoryControl.OrderHistoryClicked, Sub(number) OnOrderHistoryClicked(number)
                            orderhistory_panel.Controls.Add(orderHistoryControl)

                            yOffset += orderHistoryControl.Height + 10
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading order history: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadRecentOrder()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT order_number, order_date, items, total_amount FROM order_history WHERE user_id = @userID ORDER BY order_date DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", UserID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim orderNumber As Integer = reader("order_number")
                            Dim orderHistoryControl As New OrderHistoryControl()

                            orderHistoryControl.Location = New Point(10, 10)
                            orderHistoryControl.Width = recentOrder_panel.ClientSize.Width - 20
                            orderHistoryControl.LoadOrderDetails(orderNumber)

                            AddHandler orderHistoryControl.OrderHistoryClicked, Sub(number) OnOrderHistoryClicked(number)
                            recentOrder_panel.Controls.Clear()
                            recentOrder_panel.Controls.Add(orderHistoryControl)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading recent order: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadMonthlyExpenses()
        Dim totalMonthlyExpenses As Decimal = 0
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT SUM(total_amount) FROM order_history WHERE user_id = @userID AND MONTH(order_date) = MONTH(CURRENT_DATE()) AND YEAR(order_date) = YEAR(CURRENT_DATE())"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", UserID)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        totalMonthlyExpenses = Convert.ToDecimal(result)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading monthly expenses: " & ex.Message)
            End Try
        End Using

        monthlytotal_label.Text = $"Monthly Expenses: Php {totalMonthlyExpenses:F2}"
    End Sub

    Private Sub LoadDailyExpenses()
        Dim totalDailyExpenses As Decimal = 0
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT SUM(total_amount) FROM order_history WHERE user_id = @userID AND DATE(order_date) = CURRENT_DATE()"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", UserID)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        totalDailyExpenses = Convert.ToDecimal(result)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading daily expenses: " & ex.Message)
            End Try
        End Using

        dailytotal_label.Text = $"Daily Expenses: Php {totalDailyExpenses:F2}"
    End Sub

    Private Sub LoadUserData(userID As Integer)
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim query = "SELECT username, first_name, last_name, address, email, phone_number FROM users WHERE user_id = @userID"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    username_label.Text = If(reader("username") IsNot DBNull.Value, reader("username").ToString(), "Username")
                    fullname_label.Text = If(reader("first_name") IsNot DBNull.Value AndAlso reader("last_name") IsNot DBNull.Value, $"{reader("first_name")} {reader("last_name")}", "Full Name")
                    address_label.Text = If(reader("address") IsNot DBNull.Value, reader("address").ToString(), "Address")
                    email_label.Text = If(reader("email") IsNot DBNull.Value, reader("email").ToString(), "Email Address")
                    phone_label.Text = If(reader("phone_number") IsNot DBNull.Value, FormatPhoneNumber(reader("phone_number").ToString()), "Phone Number")
                Else
                    ' Set default values if no data is found
                    username_label.Text = "Username"
                    fullname_label.Text = "Full Name"
                    address_label.Text = "Address"
                    email_label.Text = "Email Address"
                    phone_label.Text = "Phone Number"
                End If
            End Using
        End Using
    End Sub

    Private Sub LoadUserDataIntoTextBoxes(userID As Integer)
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim query = "SELECT username, first_name, last_name, address, email, phone_number FROM users WHERE user_id = @userID"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    username_text.Text = If(reader("username") IsNot DBNull.Value, reader("username").ToString(), "")
                    firstName_text.Text = If(reader("first_name") IsNot DBNull.Value, reader("first_name").ToString(), "")
                    lastName_text.Text = If(reader("last_name") IsNot DBNull.Value, reader("last_name").ToString(), "")
                    address_text.Text = If(reader("address") IsNot DBNull.Value, reader("address").ToString(), "")
                    email_text.Text = If(reader("email") IsNot DBNull.Value, reader("email").ToString(), "")
                    phone_text.Text = If(reader("phone_number") IsNot DBNull.Value, FormatPhoneNumber(reader("phone_number").ToString()), "")
                End If
            End Using
        End Using
    End Sub

    Private Sub LoadFoodItems(category As String, panel As FlowLayoutPanel)
        Dim foodItems As DataTable = GetFoodItems(category)
        panel.Controls.Clear()
        For Each row As DataRow In foodItems.Rows
            Dim foodItemControl As New FoodItemControl()
            foodItemControl.FoodName = row("name").ToString()
            If Not IsDBNull(row("image")) Then
                foodItemControl.FoodImage = ByteArrayToImage(CType(row("image"), Byte()))
            End If
            AddHandler foodItemControl.FoodItemClicked, AddressOf OnFoodItemClicked
            panel.Controls.Add(foodItemControl)
        Next
    End Sub

    Private Sub LoadOrderDetails(orderNumber As Integer)
        Debug.WriteLine($"LoadOrderDetails called with orderNumber: {orderNumber}")
        If orderNumber_label IsNot Nothing Then
            orderNumber_label.Text = "Order Number: " & orderNumber.ToString()
            Debug.WriteLine($"orderNumber_label updated to: {orderNumber_label.Text}")
        Else
            MessageBox.Show("orderNumber_label is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()
            Dim query = "SELECT items FROM order_history WHERE user_id = @userID AND order_number = @orderNumber"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userID", Me.UserID)
            cmd.Parameters.AddWithValue("@orderNumber", orderNumber)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim items As String = reader("items").ToString()
                Dim itemList As String() = items.Split(","c)
                orderdetail_panel.Controls.Clear()

                For Each item As String In itemList
                    Try
                        Dim itemParts As String() = item.Split(":"c)
                        If itemParts.Length = 2 Then
                            Dim orderDetailControl As New OrderDetailControl()
                            orderDetailControl.FoodName = itemParts(0).Trim()
                            orderDetailControl.Quantity = itemParts(1).Trim()
                            orderDetailControl.Category = GetItemCategory(itemParts(0).Trim())
                            orderdetail_panel.Controls.Add(orderDetailControl)
                        Else
                            ' Log malformed item for debugging
                            Debug.WriteLine($"Malformed item format: {item}")
                        End If
                    Catch ex As Exception
                        Debug.WriteLine($"Error processing item {item}: {ex.Message}")
                    End Try
                Next
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading order details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PerformSearch()
        Dim searchQuery As String = search_text.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            SearchItems(searchQuery)
        Else
            MessageBox.Show("Please enter a search query.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SearchItems(query As String)
        searchresults_panel.Controls.Clear()
        System.Diagnostics.Debug.WriteLine($"Search query: {query}")
        query = query.ToLower().Trim()

        ' Check for specific keywords and navigate to the corresponding panels
        If query.Contains("home") Then
            HighlightButton(btn_home)
            ShowPanel(home_panel)
            Return
        ElseIf query.Contains("menu") Or query.Contains("food") Then
            HighlightButton(btn_menu)
            ShowPanel(foodmenu_panel)
            Return
        ElseIf query.Contains("pay") Or query.Contains("payment") Then
            HighlightButton(btn_payment)
            ShowPanel(payment_panel)
            Return
        ElseIf query.Contains("history") Or query.Contains("order") Or query.Contains("order history") Then
            HighlightButton(btn_history)
            ShowPanel(history_panel)
            LoadOrderHistory()
            Return
        ElseIf query.Contains("settings") Or query.Contains("setting") Or query.Contains("profile") Then
            HighlightButton(btn_settings)
            ShowPanel(settings_panel)
            Return
        ElseIf query.Contains("password") Or query.Contains("pass") Then
            HighlightButton(btn_settings)
            ShowPanel(pass_panel)
            Return
        End If

        ' Perform a search in menu items
        Dim menuItems As DataTable = SearchMenuItems(query)

        If menuItems.Rows.Count > 0 Then
            ' Show the main food menu panel first
            HighlightButton(btn_menu)
            ShowPanel(foodmenu_panel)

            ' Create a HashSet to store unique categories
            Dim categories As New HashSet(Of String)

            ' Collect all unique categories from search results
            For Each row As DataRow In menuItems.Rows
                categories.Add(row("category").ToString().ToLower())
            Next

            ' Create list of buttons to highlight
            Dim menuButtons As New List(Of Button)
            For Each category As String In categories
                Dim categoryButton As Button = GetMenuButton(category)
                If categoryButton IsNot Nothing Then
                    menuButtons.Add(categoryButton)
                End If
            Next

            ' Highlight all relevant category buttons
            HighlightMultipleMenuButtons(menuButtons)

            ' Show all relevant category panels
            For Each category As String In categories
                Dim targetPanel As FlowLayoutPanel = GetTargetPanel(category)
                If targetPanel IsNot Nothing Then
                    targetPanel.Visible = True
                    DisplaySearchResults(menuItems, targetPanel, category)
                End If
            Next

            ' Display overall search results
            searchresults_panel.Controls.Clear()
            For Each row As DataRow In menuItems.Rows
                Dim foodItemControl As New FoodItemControl()
                foodItemControl.FoodName = row("name").ToString()
                If Not IsDBNull(row("image")) Then
                    foodItemControl.FoodImage = ByteArrayToImage(CType(row("image"), Byte()))
                End If
                AddHandler foodItemControl.FoodItemClicked, AddressOf OnFoodItemClicked
                searchresults_panel.Controls.Add(foodItemControl)
            Next

            searchresults_panel.Visible = True
            Return
        End If

        ' Search in order history if no menu items found
        Dim orderHistory As DataTable = SearchOrderHistory(query)
        If orderHistory.Rows.Count > 0 Then
            ShowPanel(history_panel)
            DisplayOrderHistoryResults(orderHistory)
            Return
        End If

        MessageBox.Show("No results found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        searchresults_panel.Visible = False
    End Sub

    Private Sub DisplaySearchResults(dt As DataTable, panel As FlowLayoutPanel, category As String)
        ' Clear only the specific panel passed
        panel.Controls.Clear()

        ' Iterate through ALL rows in the DataTable
        For Each row As DataRow In dt.Rows
            ' Check if the current row's category matches the panel's category
            If row("category").ToString().ToLower() = category.ToLower() Then
                Dim foodItemControl As New FoodItemControl()
                foodItemControl.FoodName = row("name").ToString()
                If Not IsDBNull(row("image")) Then
                    foodItemControl.FoodImage = ByteArrayToImage(CType(row("image"), Byte()))
                End If
                AddHandler foodItemControl.FoodItemClicked, AddressOf OnFoodItemClicked
                panel.Controls.Add(foodItemControl)
            End If
        Next
    End Sub

    Private Sub DisplayOrderHistoryResults(dt As DataTable)
        orderhistory_panel.Controls.Clear()
        For Each row As DataRow In dt.Rows
            Dim orderHistoryControl As New OrderHistoryControl()
            orderHistoryControl.OrderNumber = Convert.ToInt32(row("order_number"))
            orderHistoryControl.Controls("time_label").Text = Convert.ToDateTime(row("order_date")).ToString("MM/dd/yyyy hh:mm tt")
            orderHistoryControl.Controls("noItems_label").Text = "Number of items: " & row("items").ToString().Split(","c).Length.ToString()
            orderHistoryControl.Controls("total_label").Text = "Php " & Convert.ToDecimal(row("total_amount")).ToString("N2")
            AddHandler orderHistoryControl.OrderHistoryClicked, AddressOf OnOrderHistoryClicked
            orderhistory_panel.Controls.Add(orderHistoryControl)
        Next
    End Sub

    'Helper Methods
    Private Function GetFirstName(fullName As String) As String
        Dim names As String() = fullName.Split(" "c)
        If names.Length > 0 Then
            Return names(0)
        End If
        Return fullName
    End Function

    Private Function GetItemPrice(itemName As String) As Decimal
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim query As String = "Select price FROM menu_items WHERE name = @name"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", itemName)
                    conn.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving price: " & ex.Message)
        End Try
        Return 0 ' Default price if not found
    End Function
    Private Function GetFoodItems(category As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM menu_items WHERE category = @Category"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Category", category)
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Function CalcuTotalPrice() As Decimal
        Dim total As Decimal = 0
        For Each receiptItem As ReceiptItemControl In receiptmenu_panel.Controls.OfType(Of ReceiptItemControl)()
            total += receiptItem.Price
        Next
        Return total
    End Function

    Private Function GetNextOrderNumber() As Integer
        Dim nextOrderNumber As Integer = 0
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT IFNULL(MAX(order_number), 0) + 1 FROM order_history WHERE user_id = @userID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", Me.UserID)
                    nextOrderNumber = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Error retrieving next order number: " & ex.Message)
            End Try
        End Using
        Return nextOrderNumber
    End Function

    Private Sub OnPaymentItemDeleted(sender As Object, e As EventArgs)
        Dim paymentItemControl As PaymentItemControl = CType(sender, PaymentItemControl)

        ' Remove the item from receiptmenu_panel
        For Each receiptItem As ReceiptItemControl In receiptmenu_panel.Controls.OfType(Of ReceiptItemControl)()
            If receiptItem.ItemName = paymentItemControl.ItemName Then
                receiptmenu_panel.Controls.Remove(receiptItem)
                Exit For
            End If
        Next

        ' Remove the item from payment panel
        paymentItem_panel.Controls.Remove(paymentItemControl)

        ' Update total
        UpdateTotalPrice()
    End Sub
    Private Function GetItemCategory(itemName As String) As String
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()
            Dim query = "SELECT category FROM menu_items WHERE name = @name"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", itemName)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return result.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return String.Empty
    End Function

    Private Function FormatPhoneNumber(phoneNumber As String) As String
        If phoneNumber.Length = 11 Then
            Return $"{phoneNumber.Substring(0, 4)} {phoneNumber.Substring(4, 3)} {phoneNumber.Substring(7, 4)}"
        End If
        Return phoneNumber
    End Function

    Private Function SaveOrderToDatabase() As Boolean
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()

            ' Get the next order number for the user
            Dim getOrderNumberQuery = "SELECT IFNULL(MAX(order_number), 0) + 1 FROM order_history WHERE user_id = @userID"
            Dim getOrderNumberCmd As New MySqlCommand(getOrderNumberQuery, conn)
            getOrderNumberCmd.Parameters.AddWithValue("@userID", Me.UserID)
            Dim nextOrderNumber As Integer = Convert.ToInt32(getOrderNumberCmd.ExecuteScalar())

            ' Insert the new order
            Dim query = "INSERT INTO order_history (user_id, order_date, items, total_amount, order_number) VALUES (@userID, @orderDate, @items, @totalAmount, @orderNumber)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Format items with quantity
            Dim items As String = String.Join(",", receiptmenu_panel.Controls.OfType(Of ReceiptItemControl)() _
            .Select(Function(c) $"{c.ItemName}:{c.Quantity}"))

            Dim orderDate As DateTime = DateTime.Now
            Dim totalAmount As Decimal = CalcuTotalPrice() + (CalcuTotalPrice() * 0.1) + Decimal.Parse(prTipsno_label.Text.Replace("Php ", ""), Globalization.NumberStyles.Currency)

            cmd.Parameters.AddWithValue("@userID", Me.UserID)
            cmd.Parameters.AddWithValue("@orderDate", orderDate)
            cmd.Parameters.AddWithValue("@items", items)
            cmd.Parameters.AddWithValue("@totalAmount", totalAmount)
            cmd.Parameters.AddWithValue("@orderNumber", nextOrderNumber)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
        Return False
    End Function

    Private Function SearchMenuItems(query As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(connectionString)
            ' Modify the search query to use LIKE with wildcards on both sides for name
            Dim searchQuery = "SELECT * FROM menu_items WHERE LOWER(name) LIKE @query"
            Using cmd As New MySqlCommand(searchQuery, conn)
                ' Add wildcards to ensure partial matching
                cmd.Parameters.AddWithValue("@query", "%" & query.ToLower() & "%")
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Function SearchOrderHistory(query As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(connectionString)
            Dim searchQuery = "SELECT * FROM order_history WHERE LOWER(items) LIKE @query"
            Using cmd As New MySqlCommand(searchQuery, conn)
                cmd.Parameters.AddWithValue("@query", "%" & query.ToLower() & "%")
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Function GetTargetPanel(category As String) As FlowLayoutPanel
        Select Case category.ToLower()
            Case "starter"
                Return startermenu_panel
            Case "main course"
                Return maincoursemenu_panel
            Case "drinks"
                Return drinksmenu_panel
            Case "desserts"
                Return dessertsmenu_panel
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function GetMenuButton(category As String) As Button
        Select Case category.ToLower()
            Case "starter"
                Return btn_starter
            Case "main course"
                Return btn_maincourse
            Case "drinks"
                Return btn_drinks
            Case "desserts"
                Return btn_desserts
            Case Else
                Return Nothing
        End Select
    End Function

    'Event Handlers
    Private Sub cashinput_text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cashinput_text.KeyPress
        ' Check if digit
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not digit or control key, cancel the key press event
            e.Handled = True
        ElseIf e.KeyChar = ChrW(Keys.Enter) Then
            ' If Enter key is pressed, trigger the payment process
            e.Handled = True
            btn_pay_Click(sender, e)
        End If
    End Sub

    Private Sub phone_text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phone_text.KeyPress
        ' Check if digit
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub phone_text_TextChanged(sender As Object, e As EventArgs) Handles phone_text.TextChanged
        Dim text As String = phone_text.Text.Replace(" ", "")
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

        phone_text.Text = formattedText
        phone_text.SelectionStart = phone_text.Text.Length
    End Sub

    Private Sub currentpass_text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles currentpass_text.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub newpass_text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles newpass_text.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub retype_text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles retype_text.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub search_text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search_text.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            PerformSearch()
        End If
    End Sub

End Class