Public Class FoodItemControl
    Public Event FoodItemClicked As EventHandler

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

    Public Sub New()
        InitializeComponent()
        AddHandler Me.Click, AddressOf OnFoodItemClicked
        AddHandler lbl_FoodName.Click, AddressOf OnFoodItemClicked
        AddHandler food_image.Click, AddressOf OnFoodItemClicked
    End Sub

    Private Sub OnFoodItemClicked(sender As Object, e As EventArgs)
        RaiseEvent FoodItemClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub food_image_Click(sender As Object, e As EventArgs) Handles food_image.Click
        OnFoodItemClicked(sender, e)
    End Sub

    Private Sub lbl_FoodName_Click(sender As Object, e As EventArgs) Handles lbl_FoodName.Click
        OnFoodItemClicked(sender, e)
    End Sub
End Class