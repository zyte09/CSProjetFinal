<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReceiptItemControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceiptItemControl))
        lbl_photo = New PictureBox()
        lbl_fName = New Label()
        lbl_price = New Label()
        lbl_quantity = New Label()
        btn_increment = New CircularButton()
        btn_decrement = New CircularButton()
        btn_cancel = New CircularButton()
        CType(lbl_photo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_photo
        ' 
        lbl_photo.Location = New Point(0, 0)
        lbl_photo.Name = "lbl_photo"
        lbl_photo.Size = New Size(148, 157)
        lbl_photo.SizeMode = PictureBoxSizeMode.Zoom
        lbl_photo.TabIndex = 0
        lbl_photo.TabStop = False
        ' 
        ' lbl_fName
        ' 
        lbl_fName.BackColor = Color.Transparent
        lbl_fName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_fName.Location = New Point(154, 18)
        lbl_fName.Name = "lbl_fName"
        lbl_fName.Size = New Size(144, 81)
        lbl_fName.TabIndex = 2
        lbl_fName.Text = "Ice tea"
        lbl_fName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lbl_price
        ' 
        lbl_price.AutoSize = True
        lbl_price.BackColor = Color.Transparent
        lbl_price.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_price.Location = New Point(319, 18)
        lbl_price.Name = "lbl_price"
        lbl_price.Size = New Size(88, 28)
        lbl_price.TabIndex = 3
        lbl_price.Text = "Php 0.00"
        ' 
        ' lbl_quantity
        ' 
        lbl_quantity.AutoSize = True
        lbl_quantity.BackColor = Color.Transparent
        lbl_quantity.Font = New Font("Segoe UI", 20F)
        lbl_quantity.Location = New Point(240, 92)
        lbl_quantity.Name = "lbl_quantity"
        lbl_quantity.Size = New Size(38, 46)
        lbl_quantity.TabIndex = 5
        lbl_quantity.Text = "1"
        ' 
        ' btn_increment
        ' 
        btn_increment.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_increment.BackgroundColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_increment.BackgroundImageLayout = ImageLayout.Center
        btn_increment.BorderColor = Color.PaleVioletRed
        btn_increment.BorderRadius = 40
        btn_increment.BorderSize = 0
        btn_increment.Cursor = Cursors.Hand
        btn_increment.FlatAppearance.BorderSize = 0
        btn_increment.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(13), CByte(20))
        btn_increment.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_increment.FlatStyle = FlatStyle.Flat
        btn_increment.ForeColor = Color.WhiteSmoke
        btn_increment.Image = CType(resources.GetObject("btn_increment.Image"), Image)
        btn_increment.Location = New Point(319, 98)
        btn_increment.Name = "btn_increment"
        btn_increment.Size = New Size(40, 41)
        btn_increment.TabIndex = 6
        btn_increment.TextColor = Color.WhiteSmoke
        btn_increment.UseVisualStyleBackColor = False
        ' 
        ' btn_decrement
        ' 
        btn_decrement.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_decrement.BackgroundColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        btn_decrement.BackgroundImageLayout = ImageLayout.Center
        btn_decrement.BorderColor = Color.PaleVioletRed
        btn_decrement.BorderRadius = 40
        btn_decrement.BorderSize = 0
        btn_decrement.Cursor = Cursors.Hand
        btn_decrement.FlatAppearance.BorderSize = 0
        btn_decrement.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(13), CByte(20))
        btn_decrement.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(0), CByte(48), CByte(73))
        btn_decrement.FlatStyle = FlatStyle.Flat
        btn_decrement.ForeColor = Color.WhiteSmoke
        btn_decrement.Image = CType(resources.GetObject("btn_decrement.Image"), Image)
        btn_decrement.Location = New Point(169, 98)
        btn_decrement.Name = "btn_decrement"
        btn_decrement.Size = New Size(40, 41)
        btn_decrement.TabIndex = 7
        btn_decrement.TextColor = Color.WhiteSmoke
        btn_decrement.UseVisualStyleBackColor = False
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = Color.Transparent
        btn_cancel.BackgroundColor = Color.Transparent
        btn_cancel.BackgroundImageLayout = ImageLayout.Center
        btn_cancel.BorderColor = Color.PaleVioletRed
        btn_cancel.BorderRadius = 24
        btn_cancel.BorderSize = 0
        btn_cancel.Cursor = Cursors.Hand
        btn_cancel.FlatAppearance.BorderSize = 0
        btn_cancel.FlatStyle = FlatStyle.Flat
        btn_cancel.ForeColor = Color.WhiteSmoke
        btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), Image)
        btn_cancel.Location = New Point(378, 103)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(30, 30)
        btn_cancel.TabIndex = 8
        btn_cancel.TextColor = Color.WhiteSmoke
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' ReceiptItemControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        Controls.Add(btn_cancel)
        Controls.Add(btn_decrement)
        Controls.Add(btn_increment)
        Controls.Add(lbl_quantity)
        Controls.Add(lbl_price)
        Controls.Add(lbl_fName)
        Controls.Add(lbl_photo)
        Name = "ReceiptItemControl"
        Size = New Size(424, 160)
        CType(lbl_photo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_photo As PictureBox
    Friend WithEvents lbl_fName As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents btn_increment As CircularButton
    Friend WithEvents btn_decrement As CircularButton
    Friend WithEvents btn_cancel As CircularButton

End Class
