<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderHistoryControl
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        orderID_label = New Label()
        noItems_label = New Label()
        time_label = New Label()
        btn_paymentstatus = New CircularButton()
        total_label = New Label()
        SuspendLayout()
        ' 
        ' orderID_label
        ' 
        orderID_label.AutoSize = True
        orderID_label.BackColor = SystemColors.ControlLightLight
        orderID_label.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        orderID_label.Location = New Point(12, 14)
        orderID_label.Name = "orderID_label"
        orderID_label.Size = New Size(93, 28)
        orderID_label.TabIndex = 0
        orderID_label.Text = "Order #0"
        ' 
        ' noItems_label
        ' 
        noItems_label.AutoSize = True
        noItems_label.BackColor = SystemColors.ControlLightLight
        noItems_label.Font = New Font("Segoe UI", 10.0F)
        noItems_label.Location = New Point(12, 70)
        noItems_label.Name = "noItems_label"
        noItems_label.Size = New Size(157, 23)
        noItems_label.TabIndex = 0
        noItems_label.Text = "Number of items: 0"
        ' 
        ' time_label
        ' 
        time_label.AutoSize = True
        time_label.BackColor = SystemColors.ControlLightLight
        time_label.Font = New Font("Segoe UI", 10.0F)
        time_label.Location = New Point(301, 14)
        time_label.Name = "time_label"
        time_label.Size = New Size(47, 23)
        time_label.TabIndex = 0
        time_label.Text = "Time"
        ' 
        ' btn_paymentstatus
        ' 
        btn_paymentstatus.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btn_paymentstatus.BackgroundColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btn_paymentstatus.BorderColor = Color.PaleVioletRed
        btn_paymentstatus.BorderRadius = 28
        btn_paymentstatus.BorderSize = 0
        btn_paymentstatus.Enabled = False
        btn_paymentstatus.FlatAppearance.BorderSize = 0
        btn_paymentstatus.FlatStyle = FlatStyle.Flat
        btn_paymentstatus.ForeColor = Color.White
        btn_paymentstatus.Location = New Point(366, 59)
        btn_paymentstatus.Name = "btn_paymentstatus"
        btn_paymentstatus.Size = New Size(85, 34)
        btn_paymentstatus.TabIndex = 1
        btn_paymentstatus.Text = "Paid"
        btn_paymentstatus.TextColor = Color.White
        btn_paymentstatus.UseVisualStyleBackColor = False
        ' 
        ' total_label
        ' 
        total_label.AutoSize = True
        total_label.BackColor = SystemColors.ControlLightLight
        total_label.Font = New Font("Segoe UI", 10.0F)
        total_label.Location = New Point(272, 70)
        total_label.Name = "total_label"
        total_label.Size = New Size(76, 23)
        total_label.TabIndex = 0
        total_label.Text = "Php 0.00"
        ' 
        ' OrderHistoryControl
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.ControlLightLight
        Controls.Add(btn_paymentstatus)
        Controls.Add(total_label)
        Controls.Add(noItems_label)
        Controls.Add(time_label)
        Controls.Add(orderID_label)
        Name = "OrderHistoryControl"
        Size = New Size(471, 116)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents orderID_label As Label
    Friend WithEvents noItems_label As Label
    Friend WithEvents time_label As Label
    Friend WithEvents btn_paymentstatus As CircularButton
    Friend WithEvents total_label As Label

End Class
