Public Class PaymentItemControl
    Public Property ItemName As String
        Get
            Return lbl_itemName.Text
        End Get
        Set(value As String)
            lbl_itemName.Text = value
        End Set
    End Property

    Public Property Category As String
        Get
            Return lbl_category.Text
        End Get
        Set(value As String)
            lbl_category.Text = $"({value})"
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return Decimal.Parse(lbl_Price.Text.Replace("Php ", ""), Globalization.NumberStyles.Currency)
        End Get
        Set(value As Decimal)
            lbl_Price.Text = "Php " & value.ToString("N2")
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

    Public Property Subtotal As Decimal
        Get
            Return Decimal.Parse(lbl_subtotal.Text.Replace("Php ", ""), Globalization.NumberStyles.Currency)
        End Get
        Set(value As Decimal)
            lbl_subtotal.Text = "Php " & value.ToString("N2")
        End Set
    End Property

    Public Event ItemDeleted As EventHandler

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        RaiseEvent ItemDeleted(Me, EventArgs.Empty)
    End Sub
End Class