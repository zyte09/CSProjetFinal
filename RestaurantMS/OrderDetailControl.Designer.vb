<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDetailControl
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
        foodName_label = New Label()
        quantity_label = New Label()
        category_label = New Label()
        SuspendLayout()
        ' 
        ' foodName_label
        ' 
        foodName_label.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        foodName_label.Location = New Point(18, 48)
        foodName_label.Name = "foodName_label"
        foodName_label.Size = New Size(257, 58)
        foodName_label.TabIndex = 0
        foodName_label.Text = "Ice Tea"
        ' 
        ' quantity_label
        ' 
        quantity_label.AutoSize = True
        quantity_label.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quantity_label.Location = New Point(342, 48)
        quantity_label.Name = "quantity_label"
        quantity_label.Size = New Size(26, 31)
        quantity_label.TabIndex = 1
        quantity_label.Text = "1"
        ' 
        ' category_label
        ' 
        category_label.AutoSize = True
        category_label.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        category_label.Location = New Point(18, 115)
        category_label.Name = "category_label"
        category_label.Size = New Size(79, 28)
        category_label.TabIndex = 2
        category_label.Text = "(Drinks)"
        ' 
        ' OrderDetailControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(category_label)
        Controls.Add(quantity_label)
        Controls.Add(foodName_label)
        Name = "OrderDetailControl"
        Size = New Size(392, 162)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents foodName_label As Label
    Friend WithEvents quantity_label As Label
    Friend WithEvents category_label As Label

End Class
