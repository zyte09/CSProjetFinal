Imports MySql.Data.MySqlClient
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
        receipt_panel.Visible = True
        receipt_panel.Location = New Point(1046, 97)

        'Disble button at start
        btn_cancelorder.Enabled = False
        btn_sendorder.Enabled = False

        ' Set default tip amount
        HighlightTipButton(btn_tip1, Tip1Amount)
        HighlightPaymentButton(btn_cash)
        LoadOrderHistory()
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

    Private Sub UpdateCurrentDate()
        current_datelabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy | h:mm tt")
        time_label.Text = DateTime.Now.ToString("h:mm tt")
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
        orders_panel.Visible = False
        settings_panel.Visible = False
        paymentreceipt_panel.Visible = False

        'Always show receipt panel in panel needed
        Select Case panel.Name
            Case "home_panel", "foodmenu_panel", "startermenu_panel", "maincoursemenu_panel", "drinksmenu_panel", "dessertsmenu_panel"
                receipt_panel.Visible = True
                receipt_panel.Location = New Point(1046, 97)
        End Select

        ' Show specific panel
        Select Case panel.Name
            Case "home_panel"
                home_panel.Visible = True
                HighlightButton(btn_home)

            Case "foodmenu_panel"
                foodmenu_panel.Visible = True
                HighlightButton(btn_menu)

            Case "startermenu_panel"
                foodmenu_panel.Visible = True
                startermenu_panel.Visible = True
                HighlightMenuButton(btn_starter)

            Case "maincoursemenu_panel"
                foodmenu_panel.Visible = True
                maincoursemenu_panel.Visible = True
                HighlightMenuButton(btn_maincourse)

            Case "drinksmenu_panel"
                foodmenu_panel.Visible = True
                drinksmenu_panel.Visible = True
                HighlightMenuButton(btn_drinks)

            Case "dessertsmenu_panel"
                foodmenu_panel.Visible = True
                dessertsmenu_panel.Visible = True
                HighlightMenuButton(btn_desserts)

            Case "payment_panel"
                payment_panel.Visible = True
                paymentreceipt_panel.Visible = True
                HighlightButton(btn_payment)
                receipt_panel.Visible = False

            Case "orders_panel"
                orders_panel.Visible = True
                receipt_panel.Visible = False
                HighlightButton(btn_history)

            Case "settings_panel"
                settings_panel.Visible = True
                receipt_panel.Visible = False
                HighlightButton(btn_settings)

            Case Else
                Debug.WriteLine($"Unexpected panel name: {panel.Name}")
        End Select

        Debug.WriteLine($"Showing panel: {panel.Name}")
        Debug.WriteLine($"{panel.Name} visibility: {panel.Visible}")
        Debug.WriteLine($"Panel passed: {panel.Name}")
        Debug.WriteLine($"nav_panel visible: {nav_panel.Visible}")
        Debug.WriteLine($"home_panel visible: {home_panel.Visible}")
        Debug.WriteLine($"foodmenu_panel visible: {foodmenu_panel.Visible}")
        Debug.WriteLine($"startermenu_panel visible: {startermenu_panel.Visible}")
        Debug.WriteLine($"maincoursemenu_panel visible: {maincoursemenu_panel.Visible}")
        Debug.WriteLine($"drinksmenu_panel visible: {drinksmenu_panel.Visible}")
        Debug.WriteLine($"dessertsmenu_panel visible: {dessertsmenu_panel.Visible}")
        Debug.WriteLine($"payment_panel visible: {payment_panel.Visible}")
        Debug.WriteLine($"orders_panel visible: {orders_panel.Visible}")
        Debug.WriteLine($"settings_panel visible: {settings_panel.Visible}")
        Debug.WriteLine($"Foodmenu Size: {foodmenu_panel.Size}")
        Debug.WriteLine($"Foodmenu Location: {foodmenu_panel.Location}")
        Debug.WriteLine($"Starter Size: {startermenu_panel.Size}")
        Debug.WriteLine($"Starter Location: {startermenu_panel.Location}")
        Debug.WriteLine($"Main Course Size: {maincoursemenu_panel.Size}")
        Debug.WriteLine($"Main Course Location: {maincoursemenu_panel.Location}")
        Debug.WriteLine($"Drinks Size: {drinksmenu_panel.Size}")
        Debug.WriteLine($"Drinks Location: {drinksmenu_panel.Location}")
        Debug.WriteLine($"Desserts Size: {dessertsmenu_panel.Size}")
        Debug.WriteLine($"Desserts Location: {dessertsmenu_panel.Location}")
        Debug.WriteLine($"Starter Button Location: {btn_starter.Location}")
        Debug.WriteLine($"Main Course Button Location: {btn_maincourse.Location}")
        Debug.WriteLine($"Drinks Button Location: {btn_drinks.Location}")
        Debug.WriteLine($"Desserts Button Location: {btn_desserts.Location}")
        Debug.WriteLine($"Starter Button Visible: {btn_starter.Visible}")
        Debug.WriteLine($"Main Course Button Visible: {btn_maincourse.Visible}")
        Debug.WriteLine($"Drinks Button Visible: {btn_drinks.Visible}")
        Debug.WriteLine($"Desserts Button Visible: {btn_desserts.Visible}")
        Debug.WriteLine($"OrderHistoryControl Size: {orderhistory_panel.Size}")
        Debug.WriteLine($"OrderHistoryControl Location: {orderhistory_panel.Location}")
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        HighlightButton(btn_home)
        ShowPanel(home_panel)
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        HighlightButton(btn_menu)
        ShowPanel(foodmenu_panel)
        HighlightMenuButton(btn_starter)
        ShowPanel(startermenu_panel)
    End Sub

    Private Sub btn_payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        HighlightButton(btn_payment)
        ShowPanel(payment_panel)
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        HighlightButton(btn_history)
        ShowPanel(orders_panel)
        LoadOrderHistory()
    End Sub

    Private Sub btn_settings_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        HighlightButton(btn_settings)
        ShowPanel(settings_panel)
    End Sub

    Private Sub HighlightMenuButton(button As Button)
        ' Reset all menu buttons
        Dim menuButtons() As Button = {btn_starter, btn_maincourse, btn_drinks, btn_desserts}
        For Each menuButton In menuButtons
            menuButton.BackColor = Color.DarkGray
            menuButton.ForeColor = Color.FromArgb(238, 238, 238)
        Next

        ' Highlight the selected button
        button.BackColor = Color.FromArgb(34, 40, 49)
        button.ForeColor = Color.FromArgb(238, 238, 238)
    End Sub

    Private Sub btn_starter_Click(sender As Object, e As EventArgs) Handles btn_starter.Click
        HighlightMenuButton(btn_starter)
        ShowPanel(startermenu_panel)
        LoadFoodItems("Starter", startermenu_panel)
    End Sub

    Private Sub btn_maincourse_Click(sender As Object, e As EventArgs) Handles btn_maincourse.Click
        HighlightMenuButton(btn_maincourse)
        ShowPanel(maincoursemenu_panel)
        LoadFoodItems("Main Course", maincoursemenu_panel)
    End Sub

    Private Sub btn_drinks_Click(sender As Object, e As EventArgs) Handles btn_drinks.Click
        HighlightMenuButton(btn_drinks)
        ShowPanel(drinksmenu_panel)
        LoadFoodItems("Drinks", drinksmenu_panel)
    End Sub

    Private Sub btn_desserts_Click(sender As Object, e As EventArgs) Handles btn_desserts.Click
        HighlightMenuButton(btn_desserts)
        ShowPanel(dessertsmenu_panel)
        LoadFoodItems("Desserts", dessertsmenu_panel)
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
        End If
    End Sub

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

    Private Sub cashinput_text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cashinput_text.KeyPress
        ' Check if digit
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not digit or control key, cancel the key press event
            e.Handled = True
        End If
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

    Private Sub btn_cash_Click(sender As Object, e As EventArgs) Handles btn_cash.Click
        HighlightPaymentButton(btn_cash)
    End Sub

    Private Sub btn_creditcard_Click(sender As Object, e As EventArgs) Handles btn_creditcard.Click
        HighlightPaymentButton(btn_creditcard)
    End Sub

    Private Sub btn_gcash_Click(sender As Object, e As EventArgs) Handles btn_gcash.Click
        HighlightPaymentButton(btn_gcash)
    End Sub

    Private Sub LoadOrderHistory()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT order_id FROM order_history ORDER BY order_date DESC"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        orderhistory_panel.Controls.Clear()
                        Dim yOffset As Integer = 10

                        While reader.Read()
                            Dim orderID As Integer = reader("order_id")
                            Dim orderHistoryControl As New OrderHistoryControl()

                            orderHistoryControl.Location = New Point(10, yOffset)
                            orderHistoryControl.Size = New Size(509, 116)
                            orderHistoryControl.LoadOrderDetails(orderID)

                            AddHandler orderHistoryControl.OrderHistoryClicked, Sub(id) LoadOrderDetails(id)
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
                    ShowPanel(orders_panel)
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

    Private Function SaveOrderToDatabase() As Boolean
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()
            Dim query = "INSERT INTO order_history (user_id, order_date, items, total_amount) VALUES (@userID, @orderDate, @items, @totalAmount)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Format items with quantity
            Dim items As String = String.Join(",", receiptmenu_panel.Controls.OfType(Of ReceiptItemControl)() _
            .Select(Function(c) $"{c.ItemName}:{c.Quantity}"))

            Dim userID As Integer = Me.UserID
            Dim orderDate As DateTime = DateTime.Now
            Dim totalAmount As Decimal = CalcuTotalPrice() + (CalcuTotalPrice() * 0.1) +
            Decimal.Parse(prTipsno_label.Text.Replace("Php ", ""), Globalization.NumberStyles.Currency)

            cmd.Parameters.AddWithValue("@userID", userID)
            cmd.Parameters.AddWithValue("@orderDate", orderDate)
            cmd.Parameters.AddWithValue("@items", items)
            cmd.Parameters.AddWithValue("@totalAmount", totalAmount)

            Dim result As Integer = cmd.ExecuteNonQuery()
            Return result > 0
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub LoadOrderDetails(orderID As Integer)
        orderID_label.Text = "Order #" & orderID.ToString()
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()
            Dim query = "SELECT items FROM order_history WHERE order_id = @orderID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@orderID", orderID)
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

    Private Sub OnOrderHistoryClicked(orderID As Integer)
        LoadOrderDetails(orderID)
    End Sub

End Class