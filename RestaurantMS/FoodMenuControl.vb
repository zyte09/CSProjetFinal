Public Class FoodItemControl
    Public Property FoodName As String
        Get
            Return lbl_FoodName.Text
        End Get
        Set(value As String)
            lbl_FoodName.Text = value
        End Set
    End Property

    Public Property FoodImage As Image
        Get
            Return food_image.Image
        End Get
        Set(value As Image)
            food_image.Image = value
        End Set
    End Property
End Class