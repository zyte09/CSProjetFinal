<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btn_connect = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtbox_username = New TextBox()
        txtbox_password = New TextBox()
        btn_login = New Button()
        SuspendLayout()
        ' 
        ' btn_connect
        ' 
        btn_connect.Cursor = Cursors.Hand
        btn_connect.FlatStyle = FlatStyle.Popup
        btn_connect.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_connect.Location = New Point(448, 311)
        btn_connect.Name = "btn_connect"
        btn_connect.Size = New Size(161, 46)
        btn_connect.TabIndex = 0
        btn_connect.Text = "Connection"
        btn_connect.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 46)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(42, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 46)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Location = New Point(241, 86)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.Size = New Size(186, 27)
        txtbox_username.TabIndex = 3
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Location = New Point(241, 147)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PasswordChar = "*"c
        txtbox_password.Size = New Size(186, 27)
        txtbox_password.TabIndex = 4
        ' 
        ' btn_login
        ' 
        btn_login.FlatStyle = FlatStyle.Popup
        btn_login.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.Location = New Point(274, 226)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(109, 44)
        btn_login.TabIndex = 5
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(648, 396)
        Controls.Add(btn_login)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_connect)
        Name = "LoginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_connect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents btn_login As Button

End Class
