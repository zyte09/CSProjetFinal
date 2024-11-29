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
        Panel1 = New Panel()
        cbtn_submit = New CircularButton()
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
        btnCancel = New CircularButton()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(41), CByte(41))
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(cbtn_submit)
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
        ' cbtn_submit
        ' 
        cbtn_submit.BackColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        cbtn_submit.BackgroundColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        cbtn_submit.BorderColor = Color.PaleVioletRed
        cbtn_submit.BorderRadius = 33
        cbtn_submit.BorderSize = 0
        cbtn_submit.FlatAppearance.BorderSize = 0
        cbtn_submit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(94), CByte(90), CByte(90))
        cbtn_submit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(205), CByte(203), CByte(203))
        cbtn_submit.FlatStyle = FlatStyle.Flat
        cbtn_submit.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbtn_submit.ForeColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        cbtn_submit.Location = New Point(371, 401)
        cbtn_submit.Name = "cbtn_submit"
        cbtn_submit.Size = New Size(149, 43)
        cbtn_submit.TabIndex = 7
        cbtn_submit.Text = "Submit"
        cbtn_submit.TextColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        cbtn_submit.UseVisualStyleBackColor = False
        ' 
        ' txtbox_email
        ' 
        txtbox_email.BackColor = Color.FromArgb(CByte(44), CByte(41), CByte(41))
        txtbox_email.BorderStyle = BorderStyle.FixedSingle
        txtbox_email.Font = New Font("Microsoft Sans Serif", 12F)
        txtbox_email.ForeColor = Color.White
        txtbox_email.Location = New Point(288, 330)
        txtbox_email.Name = "txtbox_email"
        txtbox_email.Size = New Size(365, 26)
        txtbox_email.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(161, 289)
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
        Label4.Location = New Point(161, 332)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 17
        Label4.Text = "Email"
        ' 
        ' txtbox_phone_number
        ' 
        txtbox_phone_number.BackColor = Color.FromArgb(CByte(44), CByte(41), CByte(41))
        txtbox_phone_number.BorderStyle = BorderStyle.FixedSingle
        txtbox_phone_number.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbox_phone_number.ForeColor = Color.White
        txtbox_phone_number.Location = New Point(288, 287)
        txtbox_phone_number.Name = "txtbox_phone_number"
        txtbox_phone_number.Size = New Size(365, 26)
        txtbox_phone_number.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(161, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 14
        Label3.Text = "First Name"
        ' 
        ' txtbox_first_name
        ' 
        txtbox_first_name.BackColor = Color.FromArgb(CByte(44), CByte(41), CByte(41))
        txtbox_first_name.BorderStyle = BorderStyle.FixedSingle
        txtbox_first_name.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbox_first_name.ForeColor = Color.White
        txtbox_first_name.Location = New Point(288, 107)
        txtbox_first_name.Name = "txtbox_first_name"
        txtbox_first_name.Size = New Size(365, 26)
        txtbox_first_name.TabIndex = 0
        ' 
        ' txtbox_last_name
        ' 
        txtbox_last_name.BackColor = Color.FromArgb(CByte(44), CByte(41), CByte(41))
        txtbox_last_name.BorderStyle = BorderStyle.FixedSingle
        txtbox_last_name.Font = New Font("Microsoft Sans Serif", 12F)
        txtbox_last_name.ForeColor = Color.White
        txtbox_last_name.Location = New Point(288, 151)
        txtbox_last_name.Name = "txtbox_last_name"
        txtbox_last_name.Size = New Size(365, 26)
        txtbox_last_name.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(161, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 11
        Label2.Text = "Last Name"
        ' 
        ' txtbox_password
        ' 
        txtbox_password.BackColor = Color.FromArgb(CByte(44), CByte(41), CByte(41))
        txtbox_password.BorderStyle = BorderStyle.FixedSingle
        txtbox_password.Font = New Font("Microsoft Sans Serif", 12F)
        txtbox_password.ForeColor = Color.White
        txtbox_password.Location = New Point(288, 242)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PasswordChar = "*"c
        txtbox_password.Size = New Size(365, 26)
        txtbox_password.TabIndex = 3
        ' 
        ' lbl_username
        ' 
        lbl_username.AutoSize = True
        lbl_username.BackColor = Color.Transparent
        lbl_username.Font = New Font("Microsoft Sans Serif", 12F)
        lbl_username.ForeColor = Color.White
        lbl_username.Location = New Point(161, 201)
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
        lbl_password.Location = New Point(161, 244)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(78, 20)
        lbl_password.TabIndex = 5
        lbl_password.Text = "Password"
        ' 
        ' txt_Welcome
        ' 
        txt_Welcome.AutoSize = True
        txt_Welcome.BackColor = Color.Transparent
        txt_Welcome.Font = New Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txt_Welcome.ForeColor = Color.White
        txt_Welcome.Location = New Point(26, 29)
        txt_Welcome.Name = "txt_Welcome"
        txt_Welcome.Size = New Size(157, 44)
        txt_Welcome.TabIndex = 8
        txt_Welcome.Text = "Sign-up"
        ' 
        ' txtbox_username
        ' 
        txtbox_username.BackColor = Color.FromArgb(CByte(44), CByte(41), CByte(41))
        txtbox_username.BorderStyle = BorderStyle.FixedSingle
        txtbox_username.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbox_username.ForeColor = Color.White
        txtbox_username.Location = New Point(288, 199)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.Size = New Size(365, 26)
        txtbox_username.TabIndex = 2
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        btnCancel.BackgroundColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        btnCancel.BorderColor = Color.PaleVioletRed
        btnCancel.BorderRadius = 33
        btnCancel.BorderSize = 0
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(94), CByte(90), CByte(90))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(205), CByte(203), CByte(203))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        btnCancel.Location = New Point(710, 29)
        btnCancel.Name = "btnCancel"
        btnCancel.RightToLeft = RightToLeft.Yes
        btnCancel.Size = New Size(110, 43)
        btnCancel.TabIndex = 18
        btnCancel.Text = "Cancel"
        btnCancel.TextColor = Color.FromArgb(CByte(25), CByte(24), CByte(24))
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.login_bg
        ClientSize = New Size(1249, 641)
        Controls.Add(Panel1)
        Name = "RegistrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Registration"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents cbtn_connect As CircularButton
    Friend WithEvents cbtn_submit As CircularButton
    Friend WithEvents txtbox_email As TextBox
    Friend WithEvents txtbox_phone_number As TextBox
    Friend WithEvents txtbox_first_name As TextBox
    Friend WithEvents txtbox_last_name As TextBox
    Private WithEvents btnCancel As CircularButton
End Class
