<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim combobox_account_type As ComboBox
        Panel1 = New Panel()
        Label5 = New Label()
        txtbox_email = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        txtbox_phone_number = New TextBox()
        Label3 = New Label()
        txtbox_first_name = New TextBox()
        txtbox_last_name = New TextBox()
        Label2 = New Label()
        txtbox_password = New TextBox()
        lbl_username = New Label()
        lbl_password = New Label()
        txt_Welcome = New Label()
        txtbox_username = New TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        cbtn_submit = New CircularButton()
        combobox_account_type = New ComboBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(44, 41, 41)
        Panel1.Controls.Add(cbtn_submit)
        Panel1.Controls.Add(combobox_account_type)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtbox_email)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtbox_phone_number)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtbox_first_name)
        Panel1.Controls.Add(txtbox_last_name)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtbox_password)
        Panel1.Controls.Add(lbl_username)
        Panel1.Controls.Add(lbl_password)
        Panel1.Controls.Add(txt_Welcome)
        Panel1.Controls.Add(txtbox_username)
        Panel1.Location = New Point(199, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(860, 468)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(160, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 20)
        Label5.TabIndex = 20
        Label5.Text = "Account Type"
        ' 
        ' txtbox_email
        ' 
        txtbox_email.BackColor = Color.FromArgb(44, 41, 41)
        txtbox_email.BorderStyle = BorderStyle.FixedSingle
        txtbox_email.Font = New Font("Microsoft Sans Serif", 12F)
        txtbox_email.ForeColor = Color.White
        txtbox_email.Location = New Point(287, 311)
        txtbox_email.Name = "txtbox_email"
        txtbox_email.PasswordChar = "*"c
        txtbox_email.Size = New Size(365, 26)
        txtbox_email.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(160, 270)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 16
        Label1.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(160, 313)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 17
        Label4.Text = "Email"
        ' 
        ' txtbox_phone_number
        ' 
        txtbox_phone_number.BackColor = Color.FromArgb(44, 41, 41)
        txtbox_phone_number.BorderStyle = BorderStyle.FixedSingle
        txtbox_phone_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtbox_phone_number.ForeColor = Color.White
        txtbox_phone_number.Location = New Point(287, 268)
        txtbox_phone_number.Name = "txtbox_phone_number"
        txtbox_phone_number.Size = New Size(365, 26)
        txtbox_phone_number.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(160, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 14
        Label3.Text = "First Name"
        ' 
        ' txtbox_first_name
        ' 
        txtbox_first_name.BackColor = Color.FromArgb(44, 41, 41)
        txtbox_first_name.BorderStyle = BorderStyle.FixedSingle
        txtbox_first_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtbox_first_name.ForeColor = Color.White
        txtbox_first_name.Location = New Point(287, 88)
        txtbox_first_name.Name = "txtbox_first_name"
        txtbox_first_name.Size = New Size(365, 26)
        txtbox_first_name.TabIndex = 15
        ' 
        ' txtbox_last_name
        ' 
        txtbox_last_name.BackColor = Color.FromArgb(44, 41, 41)
        txtbox_last_name.BorderStyle = BorderStyle.FixedSingle
        txtbox_last_name.Font = New Font("Microsoft Sans Serif", 12F)
        txtbox_last_name.ForeColor = Color.White
        txtbox_last_name.Location = New Point(287, 132)
        txtbox_last_name.Name = "txtbox_last_name"
        txtbox_last_name.PasswordChar = "*"c
        txtbox_last_name.Size = New Size(365, 26)
        txtbox_last_name.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(160, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 11
        Label2.Text = "Last Name"
        ' 
        ' txtbox_password
        ' 
        txtbox_password.BackColor = Color.FromArgb(44, 41, 41)
        txtbox_password.BorderStyle = BorderStyle.FixedSingle
        txtbox_password.Font = New Font("Microsoft Sans Serif", 12F)
        txtbox_password.ForeColor = Color.White
        txtbox_password.Location = New Point(287, 223)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PasswordChar = "*"c
        txtbox_password.Size = New Size(365, 26)
        txtbox_password.TabIndex = 9
        ' 
        ' lbl_username
        ' 
        lbl_username.AutoSize = True
        lbl_username.BackColor = Color.Transparent
        lbl_username.Font = New Font("Microsoft Sans Serif", 12F)
        lbl_username.ForeColor = Color.White
        lbl_username.Location = New Point(160, 182)
        lbl_username.Name = "lbl_username"
        lbl_username.Size = New Size(83, 20)
        lbl_username.TabIndex = 4
        lbl_username.Text = "Username"
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.BackColor = Color.Transparent
        lbl_password.Font = New Font("Microsoft Sans Serif", 12F)
        lbl_password.ForeColor = Color.White
        lbl_password.Location = New Point(160, 225)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(78, 20)
        lbl_password.TabIndex = 5
        lbl_password.Text = "Password"
        ' 
        ' txt_Welcome
        ' 
        txt_Welcome.AutoSize = True
        txt_Welcome.BackColor = Color.Transparent
        txt_Welcome.Font = New Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
        txt_Welcome.ForeColor = Color.White
        txt_Welcome.Location = New Point(26, 29)
        txt_Welcome.Name = "txt_Welcome"
        txt_Welcome.Size = New Size(157, 44)
        txt_Welcome.TabIndex = 8
        txt_Welcome.Text = "Sign-up"
        ' 
        ' txtbox_username
        ' 
        txtbox_username.BackColor = Color.FromArgb(44, 41, 41)
        txtbox_username.BorderStyle = BorderStyle.FixedSingle
        txtbox_username.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtbox_username.ForeColor = Color.White
        txtbox_username.Location = New Point(287, 180)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.Size = New Size(365, 26)
        txtbox_username.TabIndex = 6
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(287, 88)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(8, 11)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' combobox_account_type
        ' 
        combobox_account_type.BackColor = Color.FromArgb(44, 41, 41)
        combobox_account_type.FlatStyle = FlatStyle.Flat
        combobox_account_type.ForeColor = Color.White
        combobox_account_type.FormattingEnabled = True
        combobox_account_type.Items.AddRange(New Object() {"admin", "customer"})
        combobox_account_type.Location = New Point(287, 350)
        combobox_account_type.Name = "combobox_account_type"
        combobox_account_type.Size = New Size(365, 23)
        combobox_account_type.TabIndex = 21
        ' 
        ' cbtn_submit
        ' 
        cbtn_submit.BackColor = Color.FromArgb(226, 226, 226)
        cbtn_submit.BackgroundColor = Color.FromArgb(226, 226, 226)
        cbtn_submit.BorderColor = Color.PaleVioletRed
        cbtn_submit.BorderRadius = 33
        cbtn_submit.BorderSize = 0
        cbtn_submit.FlatAppearance.BorderSize = 0
        cbtn_submit.FlatAppearance.MouseDownBackColor = Color.FromArgb(94, 90, 90)
        cbtn_submit.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 203, 203)
        cbtn_submit.FlatStyle = FlatStyle.Flat
        cbtn_submit.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        cbtn_submit.ForeColor = Color.FromArgb(25, 24, 24)
        cbtn_submit.Location = New Point(371, 401)
        cbtn_submit.Name = "cbtn_submit"
        cbtn_submit.Size = New Size(149, 43)
        cbtn_submit.TabIndex = 22
        cbtn_submit.Text = "Submit"
        cbtn_submit.TextColor = Color.FromArgb(25, 24, 24)
        cbtn_submit.UseVisualStyleBackColor = False
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.login_bg1
        ClientSize = New Size(1249, 641)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Name = "RegistrationForm"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents txt_Welcome As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbtn_connect As CircularButton
    Friend WithEvents cbtn_submit As CircularButton
    Friend WithEvents txtbox_email As TextBox
    Friend WithEvents txtbox_phone_number As TextBox
    Friend WithEvents txtbox_first_name As TextBox
    Friend WithEvents txtbox_last_name As TextBox
End Class
