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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Mainform_panel = New Panel()
        header_panel = New Panel()
        Panel1 = New Panel()
        date_icon = New PictureBox()
        current_datelabel = New Label()
        search_panel = New Panel()
        search_icon = New Button()
        search_text = New TextBox()
        nav_panel = New Panel()
        btn_logout = New CircularButton()
        btn_settings = New CircularButton()
        btn_orders = New CircularButton()
        btn_payment = New CircularButton()
        btn_menu = New CircularButton()
        btn_home = New CircularButton()
        receipt_panel = New Panel()
        Mainform_panel.SuspendLayout()
        header_panel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(date_icon, ComponentModel.ISupportInitialize).BeginInit()
        search_panel.SuspendLayout()
        nav_panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Mainform_panel
        ' 
        Mainform_panel.Controls.Add(header_panel)
        Mainform_panel.Controls.Add(nav_panel)
        Mainform_panel.Controls.Add(receipt_panel)
        Mainform_panel.Dock = DockStyle.Fill
        Mainform_panel.Location = New Point(0, 0)
        Mainform_panel.Name = "Mainform_panel"
        Mainform_panel.Size = New Size(1494, 935)
        Mainform_panel.TabIndex = 1
        ' 
        ' header_panel
        ' 
        header_panel.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        header_panel.Controls.Add(Panel1)
        header_panel.Controls.Add(search_panel)
        header_panel.Dock = DockStyle.Top
        header_panel.Location = New Point(0, 0)
        header_panel.Name = "header_panel"
        header_panel.Size = New Size(1494, 97)
        header_panel.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(date_icon)
        Panel1.Controls.Add(current_datelabel)
        Panel1.Location = New Point(1073, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(284, 40)
        Panel1.TabIndex = 1
        ' 
        ' date_icon
        ' 
        date_icon.BackgroundImage = CType(resources.GetObject("date_icon.BackgroundImage"), Image)
        date_icon.BackgroundImageLayout = ImageLayout.Center
        date_icon.Dock = DockStyle.Left
        date_icon.Location = New Point(0, 0)
        date_icon.Name = "date_icon"
        date_icon.Size = New Size(45, 40)
        date_icon.TabIndex = 1
        date_icon.TabStop = False
        ' 
        ' current_datelabel
        ' 
        current_datelabel.AutoSize = True
        current_datelabel.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        current_datelabel.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        current_datelabel.Location = New Point(51, 6)
        current_datelabel.Name = "current_datelabel"
        current_datelabel.Size = New Size(53, 28)
        current_datelabel.TabIndex = 0
        current_datelabel.Text = "Date"
        ' 
        ' search_panel
        ' 
        search_panel.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        search_panel.Controls.Add(search_icon)
        search_panel.Controls.Add(search_text)
        search_panel.Location = New Point(187, 23)
        search_panel.Name = "search_panel"
        search_panel.Size = New Size(357, 58)
        search_panel.TabIndex = 0
        ' 
        ' search_icon
        ' 
        search_icon.BackgroundImage = CType(resources.GetObject("search_icon.BackgroundImage"), Image)
        search_icon.BackgroundImageLayout = ImageLayout.Center
        search_icon.Cursor = Cursors.Hand
        search_icon.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(94), CByte(143), CByte(144))
        search_icon.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(163), CByte(195), CByte(197))
        search_icon.Location = New Point(276, 0)
        search_icon.Name = "search_icon"
        search_icon.Size = New Size(81, 58)
        search_icon.TabIndex = 0
        search_icon.UseVisualStyleBackColor = True
        ' 
        ' search_text
        ' 
        search_text.BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        search_text.BorderStyle = BorderStyle.None
        search_text.Font = New Font("Segoe UI", 12.0F)
        search_text.ForeColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        search_text.Location = New Point(8, 16)
        search_text.Name = "search_text"
        search_text.PlaceholderText = "Search any product..."
        search_text.Size = New Size(262, 27)
        search_text.TabIndex = 1
        ' 
        ' nav_panel
        ' 
        nav_panel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        nav_panel.BackColor = Color.FromArgb(CByte(34), CByte(40), CByte(49))
        nav_panel.Controls.Add(btn_logout)
        nav_panel.Controls.Add(btn_settings)
        nav_panel.Controls.Add(btn_orders)
        nav_panel.Controls.Add(btn_payment)
        nav_panel.Controls.Add(btn_menu)
        nav_panel.Controls.Add(btn_home)
        nav_panel.Location = New Point(0, 0)
        nav_panel.Name = "nav_panel"
        nav_panel.Size = New Size(115, 935)
        nav_panel.TabIndex = 1
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.Transparent
        btn_logout.BackgroundColor = Color.Transparent
        btn_logout.BackgroundImage = CType(resources.GetObject("btn_logout.BackgroundImage"), Image)
        btn_logout.BackgroundImageLayout = ImageLayout.Center
        btn_logout.BorderColor = Color.PaleVioletRed
        btn_logout.BorderRadius = 40
        btn_logout.BorderSize = 0
        btn_logout.Cursor = Cursors.Hand
        btn_logout.FlatAppearance.BorderSize = 0
        btn_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_logout.Location = New Point(6, 825)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(100, 100)
        btn_logout.TabIndex = 9
        btn_logout.Text = "Logout"
        btn_logout.TextAlign = ContentAlignment.BottomCenter
        btn_logout.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' btn_settings
        ' 
        btn_settings.BackColor = Color.Transparent
        btn_settings.BackgroundColor = Color.Transparent
        btn_settings.BackgroundImage = CType(resources.GetObject("btn_settings.BackgroundImage"), Image)
        btn_settings.BackgroundImageLayout = ImageLayout.Center
        btn_settings.BorderColor = Color.PaleVioletRed
        btn_settings.BorderRadius = 40
        btn_settings.BorderSize = 0
        btn_settings.Cursor = Cursors.Hand
        btn_settings.FlatAppearance.BorderSize = 0
        btn_settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_settings.FlatStyle = FlatStyle.Flat
        btn_settings.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_settings.Location = New Point(6, 611)
        btn_settings.Name = "btn_settings"
        btn_settings.Size = New Size(100, 100)
        btn_settings.TabIndex = 8
        btn_settings.Text = "Settings"
        btn_settings.TextAlign = ContentAlignment.BottomCenter
        btn_settings.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_settings.UseVisualStyleBackColor = False
        ' 
        ' btn_orders
        ' 
        btn_orders.BackColor = Color.Transparent
        btn_orders.BackgroundColor = Color.Transparent
        btn_orders.BackgroundImage = CType(resources.GetObject("btn_orders.BackgroundImage"), Image)
        btn_orders.BackgroundImageLayout = ImageLayout.Center
        btn_orders.BorderColor = Color.PaleVioletRed
        btn_orders.BorderRadius = 40
        btn_orders.BorderSize = 0
        btn_orders.Cursor = Cursors.Hand
        btn_orders.FlatAppearance.BorderSize = 0
        btn_orders.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_orders.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_orders.FlatStyle = FlatStyle.Flat
        btn_orders.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_orders.Location = New Point(6, 492)
        btn_orders.Name = "btn_orders"
        btn_orders.Size = New Size(100, 100)
        btn_orders.TabIndex = 7
        btn_orders.Text = "Orders"
        btn_orders.TextAlign = ContentAlignment.BottomCenter
        btn_orders.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_orders.UseVisualStyleBackColor = False
        ' 
        ' btn_payment
        ' 
        btn_payment.BackColor = Color.Transparent
        btn_payment.BackgroundColor = Color.Transparent
        btn_payment.BackgroundImage = CType(resources.GetObject("btn_payment.BackgroundImage"), Image)
        btn_payment.BackgroundImageLayout = ImageLayout.Center
        btn_payment.BorderColor = Color.PaleVioletRed
        btn_payment.BorderRadius = 40
        btn_payment.BorderSize = 0
        btn_payment.Cursor = Cursors.Hand
        btn_payment.FlatAppearance.BorderSize = 0
        btn_payment.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_payment.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_payment.FlatStyle = FlatStyle.Flat
        btn_payment.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_payment.Location = New Point(6, 373)
        btn_payment.Name = "btn_payment"
        btn_payment.Size = New Size(100, 100)
        btn_payment.TabIndex = 6
        btn_payment.Text = "Payment"
        btn_payment.TextAlign = ContentAlignment.BottomCenter
        btn_payment.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_payment.UseVisualStyleBackColor = False
        ' 
        ' btn_menu
        ' 
        btn_menu.BackColor = Color.Transparent
        btn_menu.BackgroundColor = Color.Transparent
        btn_menu.BackgroundImage = CType(resources.GetObject("btn_menu.BackgroundImage"), Image)
        btn_menu.BackgroundImageLayout = ImageLayout.Center
        btn_menu.BorderColor = Color.PaleVioletRed
        btn_menu.BorderRadius = 40
        btn_menu.BorderSize = 0
        btn_menu.Cursor = Cursors.Hand
        btn_menu.FlatAppearance.BorderSize = 0
        btn_menu.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_menu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_menu.FlatStyle = FlatStyle.Flat
        btn_menu.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_menu.Location = New Point(6, 254)
        btn_menu.Name = "btn_menu"
        btn_menu.Size = New Size(100, 100)
        btn_menu.TabIndex = 5
        btn_menu.Text = "Menu"
        btn_menu.TextAlign = ContentAlignment.BottomCenter
        btn_menu.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_menu.UseVisualStyleBackColor = False
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.Transparent
        btn_home.BackgroundColor = Color.Transparent
        btn_home.BackgroundImage = CType(resources.GetObject("btn_home.BackgroundImage"), Image)
        btn_home.BackgroundImageLayout = ImageLayout.Center
        btn_home.BorderColor = Color.PaleVioletRed
        btn_home.BorderRadius = 40
        btn_home.BorderSize = 0
        btn_home.Cursor = Cursors.Hand
        btn_home.FlatAppearance.BorderSize = 0
        btn_home.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(49), CByte(54), CByte(63))
        btn_home.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(118), CByte(171), CByte(174))
        btn_home.FlatStyle = FlatStyle.Flat
        btn_home.ForeColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_home.Location = New Point(6, 135)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(100, 100)
        btn_home.TabIndex = 4
        btn_home.Text = "Home"
        btn_home.TextAlign = ContentAlignment.BottomCenter
        btn_home.TextColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        btn_home.UseVisualStyleBackColor = False
        ' 
        ' receipt_panel
        ' 
        receipt_panel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        receipt_panel.Location = New Point(1046, 97)
        receipt_panel.Name = "receipt_panel"
        receipt_panel.Size = New Size(448, 838)
        receipt_panel.TabIndex = 3
        ' 
        ' Mainform
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        BackColor = Color.FromArgb(CByte(238), CByte(238), CByte(238))
        ClientSize = New Size(1494, 935)
        Controls.Add(Mainform_panel)
        Name = "Mainform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mainform"
        WindowState = FormWindowState.Maximized
        Mainform_panel.ResumeLayout(False)
        header_panel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(date_icon, ComponentModel.ISupportInitialize).EndInit()
        search_panel.ResumeLayout(False)
        search_panel.PerformLayout()
        nav_panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Mainform_panel As Panel
    Friend WithEvents header_panel As Panel
    Friend WithEvents nav_panel As Panel
    Friend WithEvents receipt_panel As Panel
    Friend WithEvents btn_home As CircularButton
    Friend WithEvents btn_logout As CircularButton
    Friend WithEvents btn_settings As CircularButton
    Friend WithEvents btn_orders As CircularButton
    Friend WithEvents btn_payment As CircularButton
    Friend WithEvents btn_menu As CircularButton
    Friend WithEvents search_panel As Panel
    Friend WithEvents search_icon As Button
    Friend WithEvents search_text As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents current_datelabel As Label
    Friend WithEvents date_icon As PictureBox
End Class
