Public Class OrderDetailControl
    Public Property FoodName As String
        Get
            Return foodName_label.Text
        End Get
        Set(value As String)
            foodName_label.Text = value
        End Set
    End Property

    Public Property Quantity As String
        Get
            Return quantity_label.Text
        End Get
        Set(value As String)
            quantity_label.Text = value
        End Set
    End Property

    Public Property Category As String
        Get
            Return category_label.Text
        End Get
        Set(value As String)
            category_label.Text = $"({value})"
        End Set
    End Property
End Class