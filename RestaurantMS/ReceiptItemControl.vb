Public Class ReceiptItemControl
    Public Event ItemIncremented As EventHandler
    Public Event ItemDecremented As EventHandler
    Public Event ItemCancelled As EventHandler

    Public Property ItemName As String
        Get
            Return lbl_fName.Text
        End Get
        Set(value As String)
            lbl_fName.Text = value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return Integer.Parse(lbl_quantity.Text)
        End Get
        Set(value As Integer)
            lbl_quantity.Text = value.ToString()
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return Decimal.Parse(lbl_price.Text, Globalization.NumberStyles.Currency)
        End Get
        Set(value As Decimal)
            lbl_price.Text = value.ToString("C2")
        End Set
    End Property

    Public Property FoodImage As Image
        Get
            Return lbl_photo.Image
        End Get
        Set(value As Image)
            lbl_photo.Image = value
        End Set
    End Property

    Private Sub btn_increment_Click(sender As Object, e As EventArgs) Handles btn_increment.Click
        Quantity += 1
        RaiseEvent ItemIncremented(Me, EventArgs.Empty)
    End Sub

    Private Sub btn_decrement_Click(sender As Object, e As EventArgs) Handles btn_decrement.Click
        If Quantity > 1 Then
            Quantity -= 1
            RaiseEvent ItemDecremented(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        RaiseEvent ItemCancelled(Me, EventArgs.Empty)
    End Sub
End Class