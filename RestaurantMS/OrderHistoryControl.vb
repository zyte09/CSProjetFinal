Imports MySql.Data.MySqlClient

Public Class OrderHistoryControl
    Public Event OrderHistoryClicked(orderNumber As Integer)
    Private _orderNumber As Integer

    Public Sub New()
        InitializeComponent()
        AddHandler Me.Click, AddressOf OrderHistoryControl_Click
        Me.Cursor = Cursors.Hand
    End Sub

    Public Property OrderNumber As Integer
        Get
            Return _orderNumber
        End Get
        Set(value As Integer)
            _orderNumber = value
            orderNumber_label.Text = "Order #" & value.ToString()
        End Set
    End Property

    Private Sub OrderHistoryControl_Click(sender As Object, e As EventArgs)
        RaiseEvent OrderHistoryClicked(_orderNumber)
    End Sub

    Public Sub LoadOrderDetails(orderNumber As Integer)
        Me.OrderNumber = orderNumber
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT order_number, order_date, items, total_amount FROM order_history WHERE order_number = @orderNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@orderNumber", orderNumber)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            orderNumber_label.Text = "Order #" & reader("order_number").ToString()
                            time_label.Text = Convert.ToDateTime(reader("order_date")).ToString("MM/dd/yyyy hh:mm tt")
                            noItems_label.Text = "Number of items: " & reader("items").ToString().Split(","c).Length.ToString()
                            total_label.Text = "Php " & Convert.ToDecimal(reader("total_amount")).ToString("N2")
                            Debug.WriteLine($"Order details loaded: Order #{reader("order_number")}, Date: {reader("order_date")}, Items: {reader("items")}, Total: {reader("total_amount")}")
                        Else
                            Debug.WriteLine("No order details found for orderNumber: " & orderNumber)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Debug.WriteLine($"Error loading order details: {ex.Message}")
            End Try
        End Using
    End Sub
End Class