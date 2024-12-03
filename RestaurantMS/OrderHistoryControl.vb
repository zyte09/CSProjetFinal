Imports MySql.Data.MySqlClient

Public Class OrderHistoryControl
    Public Event OrderHistoryClicked(orderID As Integer)
    Private _orderID As Integer

    Public Sub New()
        InitializeComponent()
        AddHandler Me.Click, AddressOf OrderHistoryControl_Click
        Me.Cursor = Cursors.Hand
    End Sub

    Public Property OrderID As Integer
        Get
            Return _orderID
        End Get
        Set(value As Integer)
            _orderID = value
            orderID_label.Text = "Order #" & value.ToString()
        End Set
    End Property

    Private Sub OrderHistoryControl_Click(sender As Object, e As EventArgs)
        RaiseEvent OrderHistoryClicked(_orderID)
    End Sub

    Public Sub LoadOrderDetails(orderID As Integer)
        Me.OrderID = orderID
        Dim connectionString = "server=127.0.0.1;userid=root;password='';database=RestaurantMSDB"
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT order_id, order_date, items, total_amount FROM order_history WHERE order_id = @orderID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@orderID", orderID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            orderID_label.Text = "Order #" & reader("order_id").ToString()
                            time_label.Text = Convert.ToDateTime(reader("order_date")).ToString("MM/dd/yyyy hh:mm tt")
                            noItems_label.Text = "Number of items: " & reader("items").ToString().Split(","c).Length.ToString()
                            total_label.Text = "Php " & Convert.ToDecimal(reader("total_amount")).ToString("N2")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Debug.WriteLine($"Error loading order details: {ex.Message}")
            End Try
        End Using
    End Sub
End Class