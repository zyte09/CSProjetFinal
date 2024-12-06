Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FoodItemControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoodItemControl))
        food_image = New PictureBox()
        lbl_FoodName = New Label()
        CType(food_image, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' food_image
        ' 
        food_image.BackColor = Color.Transparent
        food_image.BackgroundImageLayout = ImageLayout.None
        food_image.Dock = DockStyle.Top
        food_image.Image = CType(resources.GetObject("food_image.Image"), Image)
        food_image.Location = New Point(0, 0)
        food_image.Margin = New Padding(3, 2, 3, 2)
        food_image.Name = "food_image"
        food_image.Size = New Size(174, 107)
        food_image.SizeMode = PictureBoxSizeMode.Zoom
        food_image.TabIndex = 0
        food_image.TabStop = False
        ' 
        ' lbl_FoodName
        ' 
        lbl_FoodName.BackColor = Color.Transparent
        lbl_FoodName.Dock = DockStyle.Bottom
        lbl_FoodName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_FoodName.Location = New Point(0, 109)
        lbl_FoodName.Name = "lbl_FoodName"
        lbl_FoodName.Size = New Size(174, 49)
        lbl_FoodName.TabIndex = 1
        lbl_FoodName.Text = "Ice tea"
        lbl_FoodName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FoodItemControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        BorderStyle = BorderStyle.Fixed3D
        Controls.Add(lbl_FoodName)
        Controls.Add(food_image)
        Cursor = Cursors.Hand
        Margin = New Padding(3, 2, 3, 2)
        Name = "FoodItemControl"
        Size = New Size(174, 158)
        CType(food_image, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents food_image As PictureBox
    Friend WithEvents lbl_FoodName As Label

End Class