<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentItemControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentItemControl))
        lbl_itemName = New Label()
        lbl_Price = New Label()
        lbl_category = New Label()
        lbl_quantity = New Label()
        lbl_subtotal = New Label()
        btn_delete = New CircularButton()
        SuspendLayout()
        ' 
        ' lbl_itemName
        ' 
        lbl_itemName.AutoSize = True
        lbl_itemName.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_itemName.Location = New Point(14, 23)
        lbl_itemName.Name = "lbl_itemName"
        lbl_itemName.Size = New Size(66, 25)
        lbl_itemName.TabIndex = 0
        lbl_itemName.Text = "Ice tea"
        ' 
        ' lbl_Price
        ' 
        lbl_Price.AutoSize = True
        lbl_Price.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Price.Location = New Point(286, 32)
        lbl_Price.Name = "lbl_Price"
        lbl_Price.Size = New Size(83, 25)
        lbl_Price.TabIndex = 0
        lbl_Price.Text = "Php 0.00"
        ' 
        ' lbl_category
        ' 
        lbl_category.AutoSize = True
        lbl_category.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_category.Location = New Point(14, 53)
        lbl_category.Name = "lbl_category"
        lbl_category.Size = New Size(75, 25)
        lbl_category.TabIndex = 0
        lbl_category.Text = "(drinks)"
        ' 
        ' lbl_quantity
        ' 
        lbl_quantity.AutoSize = True
        lbl_quantity.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_quantity.Location = New Point(529, 32)
        lbl_quantity.Name = "lbl_quantity"
        lbl_quantity.Size = New Size(19, 25)
        lbl_quantity.TabIndex = 0
        lbl_quantity.Text = "1"
        ' 
        ' lbl_subtotal
        ' 
        lbl_subtotal.AutoSize = True
        lbl_subtotal.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_subtotal.Location = New Point(727, 32)
        lbl_subtotal.Name = "lbl_subtotal"
        lbl_subtotal.Size = New Size(83, 25)
        lbl_subtotal.TabIndex = 0
        lbl_subtotal.Text = "Php 0.00"
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.Transparent
        btn_delete.BackgroundColor = Color.Transparent
        btn_delete.BackgroundImageLayout = ImageLayout.Center
        btn_delete.BorderColor = Color.PaleVioletRed
        btn_delete.BorderRadius = 24
        btn_delete.BorderSize = 0
        btn_delete.Cursor = Cursors.Hand
        btn_delete.FlatAppearance.BorderSize = 0
        btn_delete.FlatStyle = FlatStyle.Flat
        btn_delete.ForeColor = Color.WhiteSmoke
        btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), Image)
        btn_delete.Location = New Point(856, 21)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(45, 50)
        btn_delete.TabIndex = 9
        btn_delete.TextColor = Color.WhiteSmoke
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' PaymentItemControl
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btn_delete)
        Controls.Add(lbl_quantity)
        Controls.Add(lbl_subtotal)
        Controls.Add(lbl_Price)
        Controls.Add(lbl_category)
        Controls.Add(lbl_itemName)
        Name = "PaymentItemControl"
        Size = New Size(904, 99)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_itemName As Label
    Friend WithEvents lbl_Price As Label
    Friend WithEvents lbl_category As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents btn_delete As CircularButton

End Class
