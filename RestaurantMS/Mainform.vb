Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Mainform
    Private SelectedButton As Button = Nothing
    Private isExiting As Boolean = False
    Private connectionString As String = "Server=127.0.0.1;userid=root;password='';Database=RestaurantMSDB"
    Private Const ServiceCharge As Decimal = CDec(50)

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCurrentDate()
        HighlightButton(btn_home)
        ShowPanel(home_panel)

        orderno_panel.Visible = True
        guesttable_panel.Visible = True
        receiptmenu_panel.Visible = True
        receipt_panel.Visible = True
        receipt_panel.Location = New Point(1046, 97)
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
                HighlightButton(btn_payment)

            Case "orders_panel"
                orders_panel.Visible = True
                HighlightButton(btn_orders)

            Case "settings_panel"
                settings_panel.Visible = True
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

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        HighlightButton(btn_orders)
        ShowPanel(orders_panel)
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
                Dim query As String = "SELECT price FROM menu_items WHERE name = @name"
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
            Dim price As Decimal = receiptItem.Price
            Dim quantity As Integer = receiptItem.Quantity
            total += price * quantity
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

        ' Update the service charge label
        servicechargeno_label.Text = "Php " & ServiceCharge.ToString("N2")

        ' Calculate and update the total label
        Dim total As Decimal = totalPrice + ServiceCharge
        totalno_label.Text = "Php " & total.ToString("N2")
    End Sub

    Private Sub btn_cancelorder_Click(sender As Object, e As EventArgs) Handles btn_cancelorder.Click
        'Clear items in receiptmenu_panel
        receiptmenu_panel.Controls.Clear()

        'Update total
        UpdateTotalPrice()
    End Sub
End Class