<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        btn_logout = New CircularButton()
        SuspendLayout()
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.MediumSlateBlue
        btn_logout.BackgroundColor = Color.MediumSlateBlue
        btn_logout.BorderColor = Color.PaleVioletRed
        btn_logout.BorderRadius = 40
        btn_logout.BorderSize = 0
        btn_logout.FlatAppearance.BorderSize = 0
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.ForeColor = Color.White
        btn_logout.Location = New Point(505, 225)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(188, 50)
        btn_logout.TabIndex = 0
        btn_logout.Text = "Logout"
        btn_logout.TextColor = Color.White
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Mainform
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        ClientSize = New Size(1262, 673)
        Controls.Add(btn_logout)
        Name = "Mainform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mainform"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_logout As CircularButton
End Class
