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
        paymentreceipt_panel = New Panel()
        textpayment_panel = New Panel()
        prSubtotal_label = New Label()
        prSubtotalno_label = New Label()
        prServiceno_label = New Label()
        prTotal_label = New Label()
        prService_label = New Label()
        prTotalno_label = New Label()
        prTips_label = New Label()
        prTipsno_label = New Label()
        btn_pay = New CircularButton()
        title_label = New Panel()
        pay_label = New Label()
        paytotal_label = New Label()
        pguest_icon = New PictureBox()
        pguest_label = New Label()
        pguestno_label = New Label()
        cash_panel = New Panel()
        sign_label = New Label()
        cashinput_text = New TextBox()
        cash_label = New Label()
        btnpayment_panel = New Panel()
        btn_gcash = New CircularButton()
        btn_cash = New CircularButton()
        btn_creditcard = New CircularButton()
        tip_panel = New Panel()
        tips_label = New Label()
        btn_tip0 = New CircularButton()
        btn_tip1 = New CircularButton()
        btn_tip2 = New CircularButton()
        btn_tip3 = New CircularButton()
        btn_tip4 = New CircularButton()
        receipt_panel = New Panel()
        receipttotal_panel = New Panel()
        subtotal_label = New Label()
        servicechargeno_label = New Label()
        servicecharge_label = New Label()
        totalno_label = New Label()
        total_label = New Label()
        btn_cancelorder = New CircularButton()
        btn_sendorder = New CircularButton()
        subtotalno_label = New Label()
        receiptmenu_panel = New FlowLayoutPanel()
        guesttable_panel = New Panel()
        tableno_label = New Label()
        table_label = New Label()
        table_icon = New PictureBox()
        guestno_label = New Label()
        guest_label = New Label()
        guest_icon = New PictureBox()
        orderno_panel = New Panel()
        order_label = New Label()
        orderno_label = New Label()
        nav_panel = New Panel()
        payment_panel = New Panel()
        psubtotal_label = New Label()
        quantity_label = New Label()
        price_label = New Label()
        paymentItem_panel = New FlowLayoutPanel()
        item_label = New Label()
        headerpayment_panel = New Panel()
        time_label = New Label()
        ptime_label = New Label()
        time_icon = New PictureBox()
        ptableno_label = New Label()
        ptable_label = New Label()
        table_photo = New PictureBox()
        pOrderno_label = New Label()
        foodmenu_panel = New Panel()
        btn_maincourse = New CircularButton()
        btn_starter = New CircularButton()
        btn_drinks = New CircularButton()
        btn_desserts = New CircularButton()
        startermenu_panel = New FlowLayoutPanel()
        Label7 = New Label()
        maincoursemenu_panel = New FlowLayoutPanel()
        Label6 = New Label()
        drinksmenu_panel = New FlowLayoutPanel()
        Label5 = New Label()
        dessertsmenu_panel = New FlowLayoutPanel()
        Label2 = New Label()
        home_panel = New Panel()
        Label1 = New Label()
        orders_panel = New Panel()
        settings_panel = New Panel()
        Label4 = New Label()
        header_panel = New Panel()
        date_panel = New Panel()
        date_icon = New PictureBox()
        current_datelabel = New Label()
        search_panel = New Panel()
        search_icon = New Button()
        search_text = New TextBox()
        navbtn_panel = New Panel()
        btn_logout = New CircularButton()
        btn_settings = New CircularButton()
        btn_orders = New CircularButton()
        btn_payment = New CircularButton()
        btn_menu = New CircularButton()
        btn_home = New CircularButton()
        Mainform_panel.SuspendLayout()
        paymentreceipt_panel.SuspendLayout()
        textpayment_panel.SuspendLayout()
        title_label.SuspendLayout()
        CType(pguest_icon, ComponentModel.ISupportInitialize).BeginInit()
        cash_panel.SuspendLayout()
        btnpayment_panel.SuspendLayout()
        tip_panel.SuspendLayout()
        receipt_panel.SuspendLayout()
        receipttotal_panel.SuspendLayout()
        guesttable_panel.SuspendLayout()
        CType(table_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(guest_icon, ComponentModel.ISupportInitialize).BeginInit()
        orderno_panel.SuspendLayout()
        nav_panel.SuspendLayout()
        payment_panel.SuspendLayout()
        headerpayment_panel.SuspendLayout()
        CType(time_icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(table_photo, ComponentModel.ISupportInitialize).BeginInit()
        foodmenu_panel.SuspendLayout()
        startermenu_panel.SuspendLayout()
        maincoursemenu_panel.SuspendLayout()
        drinksmenu_panel.SuspendLayout()
        dessertsmenu_panel.SuspendLayout()
        home_panel.SuspendLayout()
        settings_panel.SuspendLayout()
        header_panel.SuspendLayout()
        date_panel.SuspendLayout()
        CType(date_icon, ComponentModel.ISupportInitialize).BeginInit()
        search_panel.SuspendLayout()
        navbtn_panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Mainform_panel
        ' 
        Mainform_panel.Controls.Add(paymentreceipt_panel)
        Mainform_panel.Controls.Add(receipt_panel)
        Mainform_panel.Controls.Add(nav_panel)
        Mainform_panel.Controls.Add(header_panel)
        Mainform_panel.Controls.Add(navbtn_panel)
        Mainform_panel.Dock = DockStyle.Fill
        Mainform_panel.Location = New Point(0, 0)
        Mainform_panel.Name = "Mainform_panel"
        Mainform_panel.Size = New Size(1494, 935)
        Mainform_panel.TabIndex = 1
        ' 
        ' paymentreceipt_panel
        ' 
        paymentreceipt_panel.Controls.Add(textpayment_panel)
        paymentreceipt_panel.Controls.Add(btn_pay)
        paymentreceipt_panel.Controls.Add(title_label)
        paymentreceipt_panel.Controls.Add(cash_panel)
        paymentreceipt_panel.Controls.Add(btnpayment_panel)
        paymentreceipt_panel.Controls.Add(tip_panel)
        paymentreceipt_panel.Location = New Point(1046, 98)
        paymentreceipt_panel.Name = "paymentreceipt_panel"
        paymentreceipt_panel.Size = New Size(448, 837)
        paymentreceipt_panel.TabIndex = 17
        ' 
        ' textpayment_panel
        ' 
        textpayment_panel.Controls.Add(prSubtotal_label)
        textpayment_panel.Controls.Add(prSubtotalno_label)
        textpayment_panel.Controls.Add(prServiceno_label)
        textpayment_panel.Controls.Add(prTotal_label)
        textpayment_panel.Controls.Add(prService_label)
        textpayment_panel.Controls.Add(prTotalno_label)
        textpayment_panel.Controls.Add(prTips_label)
        textpayment_panel.Controls.Add(prTipsno_label)
        textpayment_panel.Location = New Point(14, 462)
        textpayment_panel.Name = "textpayment_panel"
        textpayment_panel.Size = New Size(431, 192)
        textpayment_panel.TabIndex = 37
        ' 
        ' prSubtotal_label
        ' 
        prSubtotal_label.Anchor = AnchorStyles.None
        prSubtotal_label.AutoSize = True
        prSubtotal_label.Font = New Font("Segoe UI", 10F)
        prSubtotal_label.ForeColor = Color.FromArgb(34, 40, 49)
        prSubtotal_label.Location = New Point(8, 13)
        prSubtotal_label.Name = "prSubtotal_label"
        prSubtotal_label.Size = New Size(87, 23)
        prSubtotal_label.TabIndex = 28
        prSubtotal_label.Text = "SUBTOTAL"
        ' 
        ' prSubtotalno_label
        ' 
        prSubtotalno_label.Anchor = AnchorStyles.None
        prSubtotalno_label.AutoSize = True
        prSubtotalno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        prSubtotalno_label.ForeColor = Color.FromArgb(34, 40, 49)
        prSubtotalno_label.Location = New Point(251, 13)
        prSubtotalno_label.Name = "prSubtotalno_label"
        prSubtotalno_label.Size = New Size(81, 23)
        prSubtotalno_label.TabIndex = 30
        prSubtotalno_label.Text = "Php 0.00"
        ' 
        ' prServiceno_label
        ' 
        prServiceno_label.Anchor = AnchorStyles.None
        prServiceno_label.AutoSize = True
        prServiceno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        prServiceno_label.ForeColor = Color.FromArgb(34, 40, 49)
        prServiceno_label.Location = New Point(252, 105)
        prServiceno_label.Name = "prServiceno_label"
        prServiceno_label.Size = New Size(81, 23)
        prServiceno_label.TabIndex = 35
        prServiceno_label.Text = "Php 0.00"
        ' 
        ' prTotal_label
        ' 
        prTotal_label.Anchor = AnchorStyles.None
        prTotal_label.AutoSize = True
        prTotal_label.Font = New Font("Segoe UI", 15F)
        prTotal_label.ForeColor = Color.FromArgb(34, 40, 49)
        prTotal_label.Location = New Point(13, 144)
        prTotal_label.Name = "prTotal_label"
        prTotal_label.Size = New Size(84, 35)
        prTotal_label.TabIndex = 32
        prTotal_label.Text = "TOTAL"
        ' 
        ' prService_label
        ' 
        prService_label.Anchor = AnchorStyles.None
        prService_label.AutoSize = True
        prService_label.Font = New Font("Segoe UI", 10F)
        prService_label.ForeColor = Color.FromArgb(34, 40, 49)
        prService_label.Location = New Point(9, 105)
        prService_label.Name = "prService_label"
        prService_label.Size = New Size(144, 23)
        prService_label.TabIndex = 34
        prService_label.Text = "SERVICE CHARGE"
        ' 
        ' prTotalno_label
        ' 
        prTotalno_label.Anchor = AnchorStyles.None
        prTotalno_label.AutoSize = True
        prTotalno_label.Font = New Font("Segoe UI", 15F)
        prTotalno_label.ForeColor = Color.FromArgb(34, 40, 49)
        prTotalno_label.Location = New Point(253, 144)
        prTotalno_label.Name = "prTotalno_label"
        prTotalno_label.Size = New Size(109, 35)
        prTotalno_label.TabIndex = 33
        prTotalno_label.Text = "Php 0.00"
        ' 
        ' prTips_label
        ' 
        prTips_label.Anchor = AnchorStyles.None
        prTips_label.AutoSize = True
        prTips_label.Font = New Font("Segoe UI", 10F)
        prTips_label.ForeColor = Color.FromArgb(34, 40, 49)
        prTips_label.Location = New Point(8, 56)
        prTips_label.Name = "prTips_label"
        prTips_label.Size = New Size(43, 23)
        prTips_label.TabIndex = 29
        prTips_label.Text = "TIPS"
        ' 
        ' prTipsno_label
        ' 
        prTipsno_label.Anchor = AnchorStyles.None
        prTipsno_label.AutoSize = True
        prTipsno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        prTipsno_label.ForeColor = Color.FromArgb(34, 40, 49)
        prTipsno_label.Location = New Point(251, 56)
        prTipsno_label.Name = "prTipsno_label"
        prTipsno_label.Size = New Size(81, 23)
        prTipsno_label.TabIndex = 31
        prTipsno_label.Text = "Php 0.00"
        ' 
        ' btn_pay
        ' 
        btn_pay.Anchor = AnchorStyles.None
        btn_pay.BackColor = Color.PaleTurquoise
        btn_pay.BackgroundColor = Color.PaleTurquoise
        btn_pay.BackgroundImageLayout = ImageLayout.Center
        btn_pay.BorderColor = Color.PaleVioletRed
        btn_pay.BorderRadius = 40
        btn_pay.BorderSize = 0
        btn_pay.Cursor = Cursors.Hand
        btn_pay.FlatAppearance.BorderSize = 0
        btn_pay.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 54, 63)
        btn_pay.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_pay.FlatStyle = FlatStyle.Flat
        btn_pay.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_pay.ForeColor = Color.FromArgb(34, 40, 49)
        btn_pay.Location = New Point(34, 664)
        btn_pay.Name = "btn_pay"
        btn_pay.Size = New Size(377, 69)
        btn_pay.TabIndex = 27
        btn_pay.Text = "PAY NOW"
        btn_pay.TextColor = Color.FromArgb(34, 40, 49)
        btn_pay.UseVisualStyleBackColor = False
        ' 
        ' title_label
        ' 
        title_label.Controls.Add(pay_label)
        title_label.Controls.Add(paytotal_label)
        title_label.Controls.Add(pguest_icon)
        title_label.Controls.Add(pguest_label)
        title_label.Controls.Add(pguestno_label)
        title_label.Location = New Point(14, 9)
        title_label.Name = "title_label"
        title_label.Size = New Size(422, 125)
        title_label.TabIndex = 36
        ' 
        ' pay_label
        ' 
        pay_label.AutoSize = True
        pay_label.Font = New Font("Segoe UI", 19F)
        pay_label.Location = New Point(4, 8)
        pay_label.Name = "pay_label"
        pay_label.Size = New Size(287, 45)
        pay_label.TabIndex = 0
        pay_label.Text = "PAYABLE AMOUNT"
        ' 
        ' paytotal_label
        ' 
        paytotal_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        paytotal_label.AutoSize = True
        paytotal_label.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0)
        paytotal_label.ForeColor = Color.FromArgb(118, 171, 174)
        paytotal_label.Location = New Point(3, 61)
        paytotal_label.Name = "paytotal_label"
        paytotal_label.Size = New Size(154, 46)
        paytotal_label.TabIndex = 11
        paytotal_label.Text = "Php 0.00"
        ' 
        ' pguest_icon
        ' 
        pguest_icon.BackgroundImage = CType(resources.GetObject("pguest_icon.BackgroundImage"), Image)
        pguest_icon.BackgroundImageLayout = ImageLayout.Zoom
        pguest_icon.Location = New Point(285, 70)
        pguest_icon.Name = "pguest_icon"
        pguest_icon.Size = New Size(45, 37)
        pguest_icon.TabIndex = 12
        pguest_icon.TabStop = False
        ' 
        ' pguest_label
        ' 
        pguest_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pguest_label.AutoSize = True
        pguest_label.Font = New Font("Segoe UI", 10F)
        pguest_label.ForeColor = Color.FromArgb(34, 40, 49)
        pguest_label.Location = New Point(332, 76)
        pguest_label.Name = "pguest_label"
        pguest_label.Size = New Size(70, 23)
        pguest_label.TabIndex = 13
        pguest_label.Text = "GUEST: "
        ' 
        ' pguestno_label
        ' 
        pguestno_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pguestno_label.AutoSize = True
        pguestno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        pguestno_label.ForeColor = Color.FromArgb(118, 171, 174)
        pguestno_label.Location = New Point(396, 76)
        pguestno_label.Name = "pguestno_label"
        pguestno_label.Size = New Size(20, 23)
        pguestno_label.TabIndex = 14
        pguestno_label.Text = "5"
        ' 
        ' cash_panel
        ' 
        cash_panel.BorderStyle = BorderStyle.Fixed3D
        cash_panel.Controls.Add(sign_label)
        cash_panel.Controls.Add(cashinput_text)
        cash_panel.Controls.Add(cash_label)
        cash_panel.Location = New Point(16, 369)
        cash_panel.Name = "cash_panel"
        cash_panel.Size = New Size(420, 84)
        cash_panel.TabIndex = 26
        ' 
        ' sign_label
        ' 
        sign_label.AutoSize = True
        sign_label.Font = New Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0)
        sign_label.Location = New Point(206, 7)
        sign_label.Name = "sign_label"
        sign_label.Size = New Size(60, 67)
        sign_label.TabIndex = 25
        sign_label.Text = "₱"
        ' 
        ' cashinput_text
        ' 
        cashinput_text.BackColor = Color.FromArgb(238, 238, 238)
        cashinput_text.Font = New Font("Segoe UI", 30F)
        cashinput_text.Location = New Point(248, 3)
        cashinput_text.Name = "cashinput_text"
        cashinput_text.Size = New Size(163, 74)
        cashinput_text.TabIndex = 24
        ' 
        ' cash_label
        ' 
        cash_label.AutoSize = True
        cash_label.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        cash_label.Location = New Point(6, 37)
        cash_label.Name = "cash_label"
        cash_label.Size = New Size(203, 28)
        cash_label.TabIndex = 23
        cash_label.Text = "ADD CASH RECEIVED"
        ' 
        ' btnpayment_panel
        ' 
        btnpayment_panel.BorderStyle = BorderStyle.Fixed3D
        btnpayment_panel.Controls.Add(btn_gcash)
        btnpayment_panel.Controls.Add(btn_cash)
        btnpayment_panel.Controls.Add(btn_creditcard)
        btnpayment_panel.Location = New Point(14, 258)
        btnpayment_panel.Name = "btnpayment_panel"
        btnpayment_panel.Size = New Size(418, 100)
        btnpayment_panel.TabIndex = 25
        ' 
        ' btn_gcash
        ' 
        btn_gcash.BackColor = Color.FromArgb(34, 40, 49)
        btn_gcash.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_gcash.BorderColor = Color.PaleVioletRed
        btn_gcash.BorderRadius = 40
        btn_gcash.BorderSize = 0
        btn_gcash.FlatAppearance.BorderSize = 0
        btn_gcash.FlatStyle = FlatStyle.Flat
        btn_gcash.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_gcash.ForeColor = Color.White
        btn_gcash.Image = CType(resources.GetObject("btn_gcash.Image"), Image)
        btn_gcash.ImageAlign = ContentAlignment.TopCenter
        btn_gcash.Location = New Point(290, 3)
        btn_gcash.Name = "btn_gcash"
        btn_gcash.Size = New Size(122, 90)
        btn_gcash.TabIndex = 22
        btn_gcash.Text = "Gcash"
        btn_gcash.TextAlign = ContentAlignment.BottomCenter
        btn_gcash.TextColor = Color.White
        btn_gcash.UseVisualStyleBackColor = False
        ' 
        ' btn_cash
        ' 
        btn_cash.BackColor = Color.FromArgb(34, 40, 49)
        btn_cash.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_cash.BorderColor = Color.PaleVioletRed
        btn_cash.BorderRadius = 40
        btn_cash.BorderSize = 0
        btn_cash.FlatAppearance.BorderSize = 0
        btn_cash.FlatStyle = FlatStyle.Flat
        btn_cash.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_cash.ForeColor = Color.White
        btn_cash.Image = CType(resources.GetObject("btn_cash.Image"), Image)
        btn_cash.ImageAlign = ContentAlignment.TopCenter
        btn_cash.Location = New Point(2, 3)
        btn_cash.Name = "btn_cash"
        btn_cash.Size = New Size(122, 90)
        btn_cash.TabIndex = 20
        btn_cash.Text = "Cash"
        btn_cash.TextAlign = ContentAlignment.BottomCenter
        btn_cash.TextColor = Color.White
        btn_cash.UseVisualStyleBackColor = False
        ' 
        ' btn_creditcard
        ' 
        btn_creditcard.BackColor = Color.FromArgb(34, 40, 49)
        btn_creditcard.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_creditcard.BorderColor = Color.PaleVioletRed
        btn_creditcard.BorderRadius = 40
        btn_creditcard.BorderSize = 0
        btn_creditcard.FlatAppearance.BorderSize = 0
        btn_creditcard.FlatStyle = FlatStyle.Flat
        btn_creditcard.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_creditcard.ForeColor = Color.White
        btn_creditcard.Image = CType(resources.GetObject("btn_creditcard.Image"), Image)
        btn_creditcard.ImageAlign = ContentAlignment.TopCenter
        btn_creditcard.Location = New Point(146, 3)
        btn_creditcard.Name = "btn_creditcard"
        btn_creditcard.Size = New Size(122, 90)
        btn_creditcard.TabIndex = 21
        btn_creditcard.Text = "Card"
        btn_creditcard.TextAlign = ContentAlignment.BottomCenter
        btn_creditcard.TextColor = Color.White
        btn_creditcard.UseVisualStyleBackColor = False
        ' 
        ' tip_panel
        ' 
        tip_panel.BorderStyle = BorderStyle.Fixed3D
        tip_panel.Controls.Add(tips_label)
        tip_panel.Controls.Add(btn_tip0)
        tip_panel.Controls.Add(btn_tip1)
        tip_panel.Controls.Add(btn_tip2)
        tip_panel.Controls.Add(btn_tip3)
        tip_panel.Controls.Add(btn_tip4)
        tip_panel.Location = New Point(14, 140)
        tip_panel.Name = "tip_panel"
        tip_panel.Size = New Size(422, 104)
        tip_panel.TabIndex = 24
        ' 
        ' tips_label
        ' 
        tips_label.AutoSize = True
        tips_label.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0)
        tips_label.Location = New Point(9, 6)
        tips_label.Name = "tips_label"
        tips_label.Size = New Size(65, 35)
        tips_label.TabIndex = 24
        tips_label.Text = "TIPS"
        ' 
        ' btn_tip0
        ' 
        btn_tip0.BackColor = Color.FromArgb(34, 40, 49)
        btn_tip0.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_tip0.BorderColor = Color.PaleVioletRed
        btn_tip0.BorderRadius = 40
        btn_tip0.BorderSize = 0
        btn_tip0.FlatAppearance.BorderSize = 0
        btn_tip0.FlatStyle = FlatStyle.Flat
        btn_tip0.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_tip0.ForeColor = Color.White
        btn_tip0.Location = New Point(12, 45)
        btn_tip0.Name = "btn_tip0"
        btn_tip0.Size = New Size(75, 50)
        btn_tip0.TabIndex = 20
        btn_tip0.Text = "₱0"
        btn_tip0.TextColor = Color.White
        btn_tip0.UseVisualStyleBackColor = False
        ' 
        ' btn_tip1
        ' 
        btn_tip1.BackColor = Color.FromArgb(34, 40, 49)
        btn_tip1.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_tip1.BorderColor = Color.PaleVioletRed
        btn_tip1.BorderRadius = 40
        btn_tip1.BorderSize = 0
        btn_tip1.FlatAppearance.BorderSize = 0
        btn_tip1.FlatStyle = FlatStyle.Flat
        btn_tip1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_tip1.ForeColor = Color.White
        btn_tip1.Location = New Point(92, 45)
        btn_tip1.Name = "btn_tip1"
        btn_tip1.Size = New Size(75, 50)
        btn_tip1.TabIndex = 16
        btn_tip1.Text = "₱20"
        btn_tip1.TextColor = Color.White
        btn_tip1.UseVisualStyleBackColor = False
        ' 
        ' btn_tip2
        ' 
        btn_tip2.BackColor = Color.FromArgb(34, 40, 49)
        btn_tip2.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_tip2.BorderColor = Color.PaleVioletRed
        btn_tip2.BorderRadius = 40
        btn_tip2.BorderSize = 0
        btn_tip2.FlatAppearance.BorderSize = 0
        btn_tip2.FlatStyle = FlatStyle.Flat
        btn_tip2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_tip2.ForeColor = Color.White
        btn_tip2.Location = New Point(172, 45)
        btn_tip2.Name = "btn_tip2"
        btn_tip2.Size = New Size(75, 50)
        btn_tip2.TabIndex = 17
        btn_tip2.Text = "₱30"
        btn_tip2.TextColor = Color.White
        btn_tip2.UseVisualStyleBackColor = False
        ' 
        ' btn_tip3
        ' 
        btn_tip3.BackColor = Color.FromArgb(34, 40, 49)
        btn_tip3.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_tip3.BorderColor = Color.PaleVioletRed
        btn_tip3.BorderRadius = 40
        btn_tip3.BorderSize = 0
        btn_tip3.FlatAppearance.BorderSize = 0
        btn_tip3.FlatStyle = FlatStyle.Flat
        btn_tip3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_tip3.ForeColor = Color.White
        btn_tip3.Location = New Point(252, 45)
        btn_tip3.Name = "btn_tip3"
        btn_tip3.Size = New Size(75, 50)
        btn_tip3.TabIndex = 18
        btn_tip3.Text = "₱40"
        btn_tip3.TextColor = Color.White
        btn_tip3.UseVisualStyleBackColor = False
        ' 
        ' btn_tip4
        ' 
        btn_tip4.BackColor = Color.FromArgb(34, 40, 49)
        btn_tip4.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_tip4.BorderColor = Color.PaleVioletRed
        btn_tip4.BorderRadius = 40
        btn_tip4.BorderSize = 0
        btn_tip4.FlatAppearance.BorderSize = 0
        btn_tip4.FlatStyle = FlatStyle.Flat
        btn_tip4.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_tip4.ForeColor = Color.White
        btn_tip4.Location = New Point(332, 45)
        btn_tip4.Name = "btn_tip4"
        btn_tip4.Size = New Size(75, 50)
        btn_tip4.TabIndex = 19
        btn_tip4.Text = "₱50"
        btn_tip4.TextColor = Color.White
        btn_tip4.UseVisualStyleBackColor = False
        ' 
        ' receipt_panel
        ' 
        receipt_panel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        receipt_panel.Controls.Add(receipttotal_panel)
        receipt_panel.Controls.Add(receiptmenu_panel)
        receipt_panel.Controls.Add(guesttable_panel)
        receipt_panel.Controls.Add(orderno_panel)
        receipt_panel.Location = New Point(1046, 98)
        receipt_panel.Name = "receipt_panel"
        receipt_panel.Size = New Size(448, 837)
        receipt_panel.TabIndex = 3
        ' 
        ' receipttotal_panel
        ' 
        receipttotal_panel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        receipttotal_panel.Controls.Add(subtotal_label)
        receipttotal_panel.Controls.Add(servicechargeno_label)
        receipttotal_panel.Controls.Add(servicecharge_label)
        receipttotal_panel.Controls.Add(totalno_label)
        receipttotal_panel.Controls.Add(total_label)
        receipttotal_panel.Controls.Add(btn_cancelorder)
        receipttotal_panel.Controls.Add(btn_sendorder)
        receipttotal_panel.Controls.Add(subtotalno_label)
        receipttotal_panel.Location = New Point(27, 387)
        receipttotal_panel.Name = "receipttotal_panel"
        receipttotal_panel.Size = New Size(392, 271)
        receipttotal_panel.TabIndex = 16
        ' 
        ' subtotal_label
        ' 
        subtotal_label.Anchor = AnchorStyles.None
        subtotal_label.AutoSize = True
        subtotal_label.Font = New Font("Segoe UI", 10F)
        subtotal_label.ForeColor = Color.FromArgb(34, 40, 49)
        subtotal_label.Location = New Point(4, 29)
        subtotal_label.Name = "subtotal_label"
        subtotal_label.Size = New Size(87, 23)
        subtotal_label.TabIndex = 11
        subtotal_label.Text = "SUBTOTAL"
        ' 
        ' servicechargeno_label
        ' 
        servicechargeno_label.Anchor = AnchorStyles.None
        servicechargeno_label.AutoSize = True
        servicechargeno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        servicechargeno_label.ForeColor = Color.FromArgb(34, 40, 49)
        servicechargeno_label.Location = New Point(247, 72)
        servicechargeno_label.Name = "servicechargeno_label"
        servicechargeno_label.Size = New Size(81, 23)
        servicechargeno_label.TabIndex = 14
        servicechargeno_label.Text = "Php 0.00"
        ' 
        ' servicecharge_label
        ' 
        servicecharge_label.Anchor = AnchorStyles.None
        servicecharge_label.AutoSize = True
        servicecharge_label.Font = New Font("Segoe UI", 10F)
        servicecharge_label.ForeColor = Color.FromArgb(34, 40, 49)
        servicecharge_label.Location = New Point(4, 72)
        servicecharge_label.Name = "servicecharge_label"
        servicecharge_label.Size = New Size(181, 23)
        servicecharge_label.TabIndex = 12
        servicecharge_label.Text = "SERVICE CHARGE 10%"
        ' 
        ' totalno_label
        ' 
        totalno_label.Anchor = AnchorStyles.None
        totalno_label.AutoSize = True
        totalno_label.Font = New Font("Segoe UI", 15F)
        totalno_label.ForeColor = Color.FromArgb(34, 40, 49)
        totalno_label.Location = New Point(247, 121)
        totalno_label.Name = "totalno_label"
        totalno_label.Size = New Size(109, 35)
        totalno_label.TabIndex = 16
        totalno_label.Text = "Php 0.00"
        ' 
        ' total_label
        ' 
        total_label.Anchor = AnchorStyles.None
        total_label.AutoSize = True
        total_label.Font = New Font("Segoe UI", 15F)
        total_label.ForeColor = Color.FromArgb(34, 40, 49)
        total_label.Location = New Point(7, 121)
        total_label.Name = "total_label"
        total_label.Size = New Size(84, 35)
        total_label.TabIndex = 15
        total_label.Text = "TOTAL"
        ' 
        ' btn_cancelorder
        ' 
        btn_cancelorder.Anchor = AnchorStyles.None
        btn_cancelorder.BackColor = Color.IndianRed
        btn_cancelorder.BackgroundColor = Color.IndianRed
        btn_cancelorder.BackgroundImageLayout = ImageLayout.Center
        btn_cancelorder.BorderColor = Color.PaleVioletRed
        btn_cancelorder.BorderRadius = 40
        btn_cancelorder.BorderSize = 0
        btn_cancelorder.Cursor = Cursors.Hand
        btn_cancelorder.FlatAppearance.BorderSize = 0
        btn_cancelorder.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 54, 63)
        btn_cancelorder.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_cancelorder.FlatStyle = FlatStyle.Flat
        btn_cancelorder.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btn_cancelorder.ForeColor = Color.FromArgb(34, 40, 49)
        btn_cancelorder.Location = New Point(5, 170)
        btn_cancelorder.Name = "btn_cancelorder"
        btn_cancelorder.Size = New Size(185, 69)
        btn_cancelorder.TabIndex = 9
        btn_cancelorder.Text = "CANCEL ORDER"
        btn_cancelorder.TextColor = Color.FromArgb(34, 40, 49)
        btn_cancelorder.UseVisualStyleBackColor = False
        ' 
        ' btn_sendorder
        ' 
        btn_sendorder.Anchor = AnchorStyles.None
        btn_sendorder.BackColor = Color.PaleTurquoise
        btn_sendorder.BackgroundColor = Color.PaleTurquoise
        btn_sendorder.BackgroundImageLayout = ImageLayout.Center
        btn_sendorder.BorderColor = Color.PaleVioletRed
        btn_sendorder.BorderRadius = 40
        btn_sendorder.BorderSize = 0
        btn_sendorder.Cursor = Cursors.Hand
        btn_sendorder.FlatAppearance.BorderSize = 0
        btn_sendorder.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 54, 63)
        btn_sendorder.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_sendorder.FlatStyle = FlatStyle.Flat
        btn_sendorder.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btn_sendorder.ForeColor = Color.FromArgb(34, 40, 49)
        btn_sendorder.Location = New Point(207, 170)
        btn_sendorder.Name = "btn_sendorder"
        btn_sendorder.Size = New Size(185, 69)
        btn_sendorder.TabIndex = 10
        btn_sendorder.Text = "SEND ORDER"
        btn_sendorder.TextColor = Color.FromArgb(34, 40, 49)
        btn_sendorder.UseVisualStyleBackColor = False
        ' 
        ' subtotalno_label
        ' 
        subtotalno_label.Anchor = AnchorStyles.None
        subtotalno_label.AutoSize = True
        subtotalno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        subtotalno_label.ForeColor = Color.FromArgb(34, 40, 49)
        subtotalno_label.Location = New Point(247, 29)
        subtotalno_label.Name = "subtotalno_label"
        subtotalno_label.Size = New Size(81, 23)
        subtotalno_label.TabIndex = 13
        subtotalno_label.Text = "Php 0.00"
        ' 
        ' receiptmenu_panel
        ' 
        receiptmenu_panel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        receiptmenu_panel.AutoScroll = True
        receiptmenu_panel.ForeColor = Color.FromArgb(34, 40, 49)
        receiptmenu_panel.Location = New Point(27, 114)
        receiptmenu_panel.Name = "receiptmenu_panel"
        receiptmenu_panel.Size = New Size(392, 267)
        receiptmenu_panel.TabIndex = 4
        ' 
        ' guesttable_panel
        ' 
        guesttable_panel.Anchor = AnchorStyles.Right
        guesttable_panel.Controls.Add(tableno_label)
        guesttable_panel.Controls.Add(table_label)
        guesttable_panel.Controls.Add(table_icon)
        guesttable_panel.Controls.Add(guestno_label)
        guesttable_panel.Controls.Add(guest_label)
        guesttable_panel.Controls.Add(guest_icon)
        guesttable_panel.Location = New Point(27, 68)
        guesttable_panel.Name = "guesttable_panel"
        guesttable_panel.Size = New Size(392, 37)
        guesttable_panel.TabIndex = 2
        ' 
        ' tableno_label
        ' 
        tableno_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        tableno_label.AutoSize = True
        tableno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        tableno_label.ForeColor = Color.FromArgb(118, 171, 174)
        tableno_label.Location = New Point(331, 7)
        tableno_label.Name = "tableno_label"
        tableno_label.Size = New Size(20, 23)
        tableno_label.TabIndex = 5
        tableno_label.Text = "2"
        ' 
        ' table_label
        ' 
        table_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        table_label.AutoSize = True
        table_label.Font = New Font("Segoe UI", 10F)
        table_label.ForeColor = Color.FromArgb(34, 40, 49)
        table_label.Location = New Point(277, 7)
        table_label.Name = "table_label"
        table_label.Size = New Size(65, 23)
        table_label.TabIndex = 4
        table_label.Text = "TABLE: "
        ' 
        ' table_icon
        ' 
        table_icon.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        table_icon.BackgroundImage = CType(resources.GetObject("table_icon.BackgroundImage"), Image)
        table_icon.BackgroundImageLayout = ImageLayout.Zoom
        table_icon.Location = New Point(232, 0)
        table_icon.Name = "table_icon"
        table_icon.Size = New Size(45, 37)
        table_icon.TabIndex = 3
        table_icon.TabStop = False
        ' 
        ' guestno_label
        ' 
        guestno_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        guestno_label.AutoSize = True
        guestno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        guestno_label.ForeColor = Color.FromArgb(118, 171, 174)
        guestno_label.Location = New Point(113, 7)
        guestno_label.Name = "guestno_label"
        guestno_label.Size = New Size(20, 23)
        guestno_label.TabIndex = 2
        guestno_label.Text = "5"
        ' 
        ' guest_label
        ' 
        guest_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        guest_label.AutoSize = True
        guest_label.Font = New Font("Segoe UI", 10F)
        guest_label.ForeColor = Color.FromArgb(34, 40, 49)
        guest_label.Location = New Point(49, 7)
        guest_label.Name = "guest_label"
        guest_label.Size = New Size(70, 23)
        guest_label.TabIndex = 1
        guest_label.Text = "GUEST: "
        ' 
        ' guest_icon
        ' 
        guest_icon.BackgroundImage = CType(resources.GetObject("guest_icon.BackgroundImage"), Image)
        guest_icon.BackgroundImageLayout = ImageLayout.Zoom
        guest_icon.Dock = DockStyle.Left
        guest_icon.Location = New Point(0, 0)
        guest_icon.Name = "guest_icon"
        guest_icon.Size = New Size(45, 37)
        guest_icon.TabIndex = 0
        guest_icon.TabStop = False
        ' 
        ' orderno_panel
        ' 
        orderno_panel.Anchor = AnchorStyles.None
        orderno_panel.Controls.Add(order_label)
        orderno_panel.Controls.Add(orderno_label)
        orderno_panel.Location = New Point(27, 14)
        orderno_panel.Name = "orderno_panel"
        orderno_panel.Size = New Size(392, 47)
        orderno_panel.TabIndex = 1
        ' 
        ' order_label
        ' 
        order_label.AutoSize = True
        order_label.Dock = DockStyle.Left
        order_label.Font = New Font("Segoe UI", 20F)
        order_label.ForeColor = Color.FromArgb(34, 40, 49)
        order_label.Location = New Point(0, 0)
        order_label.Name = "order_label"
        order_label.Size = New Size(156, 46)
        order_label.TabIndex = 0
        order_label.Text = "ORDER #"
        ' 
        ' orderno_label
        ' 
        orderno_label.AutoSize = True
        orderno_label.Dock = DockStyle.Right
        orderno_label.Font = New Font("Segoe UI", 20F)
        orderno_label.ForeColor = Color.FromArgb(118, 171, 174)
        orderno_label.Location = New Point(392, 0)
        orderno_label.Name = "orderno_label"
        orderno_label.Size = New Size(0, 46)
        orderno_label.TabIndex = 0
        ' 
        ' nav_panel
        ' 
        nav_panel.Controls.Add(payment_panel)
        nav_panel.Controls.Add(foodmenu_panel)
        nav_panel.Controls.Add(home_panel)
        nav_panel.Controls.Add(orders_panel)
        nav_panel.Controls.Add(settings_panel)
        nav_panel.Location = New Point(111, 98)
        nav_panel.Name = "nav_panel"
        nav_panel.Size = New Size(929, 837)
        nav_panel.TabIndex = 4
        ' 
        ' payment_panel
        ' 
        payment_panel.BackColor = Color.FromArgb(238, 238, 238)
        payment_panel.Controls.Add(psubtotal_label)
        payment_panel.Controls.Add(quantity_label)
        payment_panel.Controls.Add(price_label)
        payment_panel.Controls.Add(paymentItem_panel)
        payment_panel.Controls.Add(item_label)
        payment_panel.Controls.Add(headerpayment_panel)
        payment_panel.Dock = DockStyle.Fill
        payment_panel.Location = New Point(0, 0)
        payment_panel.Name = "payment_panel"
        payment_panel.Size = New Size(929, 837)
        payment_panel.TabIndex = 1
        ' 
        ' psubtotal_label
        ' 
        psubtotal_label.AutoSize = True
        psubtotal_label.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        psubtotal_label.Location = New Point(670, 107)
        psubtotal_label.Name = "psubtotal_label"
        psubtotal_label.Size = New Size(133, 35)
        psubtotal_label.TabIndex = 5
        psubtotal_label.Text = "SUBTOTAL"
        ' 
        ' quantity_label
        ' 
        quantity_label.AutoSize = True
        quantity_label.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        quantity_label.Location = New Point(481, 107)
        quantity_label.Name = "quantity_label"
        quantity_label.Size = New Size(61, 35)
        quantity_label.TabIndex = 4
        quantity_label.Text = "QTY"
        ' 
        ' price_label
        ' 
        price_label.AutoSize = True
        price_label.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        price_label.Location = New Point(294, 107)
        price_label.Name = "price_label"
        price_label.Size = New Size(82, 35)
        price_label.TabIndex = 3
        price_label.Text = "PRICE"
        ' 
        ' paymentItem_panel
        ' 
        paymentItem_panel.Location = New Point(36, 145)
        paymentItem_panel.Name = "paymentItem_panel"
        paymentItem_panel.Size = New Size(875, 680)
        paymentItem_panel.TabIndex = 2
        ' 
        ' item_label
        ' 
        item_label.AutoSize = True
        item_label.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        item_label.Location = New Point(50, 107)
        item_label.Name = "item_label"
        item_label.Size = New Size(72, 35)
        item_label.TabIndex = 1
        item_label.Text = "ITEM"
        ' 
        ' headerpayment_panel
        ' 
        headerpayment_panel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        headerpayment_panel.Controls.Add(time_label)
        headerpayment_panel.Controls.Add(ptime_label)
        headerpayment_panel.Controls.Add(time_icon)
        headerpayment_panel.Controls.Add(ptableno_label)
        headerpayment_panel.Controls.Add(ptable_label)
        headerpayment_panel.Controls.Add(table_photo)
        headerpayment_panel.Controls.Add(pOrderno_label)
        headerpayment_panel.Location = New Point(10, 14)
        headerpayment_panel.Name = "headerpayment_panel"
        headerpayment_panel.Size = New Size(901, 53)
        headerpayment_panel.TabIndex = 0
        ' 
        ' time_label
        ' 
        time_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        time_label.AutoSize = True
        time_label.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        time_label.ForeColor = Color.FromArgb(118, 171, 174)
        time_label.Location = New Point(820, 19)
        time_label.Name = "time_label"
        time_label.Size = New Size(71, 23)
        time_label.TabIndex = 10
        time_label.Text = "2:00 pm"
        ' 
        ' ptime_label
        ' 
        ptime_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        ptime_label.AutoSize = True
        ptime_label.Font = New Font("Segoe UI", 10F)
        ptime_label.ForeColor = Color.FromArgb(34, 40, 49)
        ptime_label.Location = New Point(767, 18)
        ptime_label.Name = "ptime_label"
        ptime_label.Size = New Size(52, 23)
        ptime_label.TabIndex = 9
        ptime_label.Text = "TIME:"
        ' 
        ' time_icon
        ' 
        time_icon.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        time_icon.BackgroundImage = CType(resources.GetObject("time_icon.BackgroundImage"), Image)
        time_icon.BackgroundImageLayout = ImageLayout.Zoom
        time_icon.Location = New Point(722, 11)
        time_icon.Name = "time_icon"
        time_icon.Size = New Size(45, 37)
        time_icon.TabIndex = 8
        time_icon.TabStop = False
        ' 
        ' ptableno_label
        ' 
        ptableno_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        ptableno_label.AutoSize = True
        ptableno_label.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        ptableno_label.ForeColor = Color.FromArgb(118, 171, 174)
        ptableno_label.Location = New Point(697, 20)
        ptableno_label.Name = "ptableno_label"
        ptableno_label.Size = New Size(20, 23)
        ptableno_label.TabIndex = 7
        ptableno_label.Text = "2"
        ' 
        ' ptable_label
        ' 
        ptable_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        ptable_label.AutoSize = True
        ptable_label.Font = New Font("Segoe UI", 10F)
        ptable_label.ForeColor = Color.FromArgb(34, 40, 49)
        ptable_label.Location = New Point(640, 18)
        ptable_label.Name = "ptable_label"
        ptable_label.Size = New Size(65, 23)
        ptable_label.TabIndex = 6
        ptable_label.Text = "TABLE: "
        ' 
        ' table_photo
        ' 
        table_photo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        table_photo.BackgroundImage = CType(resources.GetObject("table_photo.BackgroundImage"), Image)
        table_photo.BackgroundImageLayout = ImageLayout.Zoom
        table_photo.Location = New Point(595, 11)
        table_photo.Name = "table_photo"
        table_photo.Size = New Size(45, 37)
        table_photo.TabIndex = 5
        table_photo.TabStop = False
        ' 
        ' pOrderno_label
        ' 
        pOrderno_label.AutoSize = True
        pOrderno_label.Dock = DockStyle.Left
        pOrderno_label.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0)
        pOrderno_label.Location = New Point(0, 0)
        pOrderno_label.Name = "pOrderno_label"
        pOrderno_label.Size = New Size(267, 46)
        pOrderno_label.TabIndex = 0
        pOrderno_label.Text = "ORDER #: 12345"
        ' 
        ' foodmenu_panel
        ' 
        foodmenu_panel.BackColor = Color.FromArgb(238, 238, 238)
        foodmenu_panel.Controls.Add(btn_maincourse)
        foodmenu_panel.Controls.Add(btn_starter)
        foodmenu_panel.Controls.Add(btn_drinks)
        foodmenu_panel.Controls.Add(btn_desserts)
        foodmenu_panel.Controls.Add(startermenu_panel)
        foodmenu_panel.Controls.Add(maincoursemenu_panel)
        foodmenu_panel.Controls.Add(drinksmenu_panel)
        foodmenu_panel.Controls.Add(dessertsmenu_panel)
        foodmenu_panel.Dock = DockStyle.Fill
        foodmenu_panel.Location = New Point(0, 0)
        foodmenu_panel.Name = "foodmenu_panel"
        foodmenu_panel.Size = New Size(929, 837)
        foodmenu_panel.TabIndex = 2
        ' 
        ' btn_maincourse
        ' 
        btn_maincourse.BackColor = Color.FromArgb(34, 40, 49)
        btn_maincourse.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_maincourse.BackgroundImageLayout = ImageLayout.Center
        btn_maincourse.BorderColor = Color.PaleVioletRed
        btn_maincourse.BorderRadius = 40
        btn_maincourse.BorderSize = 0
        btn_maincourse.Cursor = Cursors.Hand
        btn_maincourse.FlatAppearance.BorderSize = 0
        btn_maincourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 40, 49)
        btn_maincourse.FlatStyle = FlatStyle.Flat
        btn_maincourse.Font = New Font("Segoe UI", 15F)
        btn_maincourse.ForeColor = Color.FromArgb(238, 238, 238)
        btn_maincourse.Location = New Point(250, 626)
        btn_maincourse.Name = "btn_maincourse"
        btn_maincourse.Size = New Size(207, 80)
        btn_maincourse.TabIndex = 6
        btn_maincourse.Text = "Main Course"
        btn_maincourse.TextColor = Color.FromArgb(238, 238, 238)
        btn_maincourse.UseVisualStyleBackColor = False
        ' 
        ' btn_starter
        ' 
        btn_starter.BackColor = Color.FromArgb(34, 40, 49)
        btn_starter.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_starter.BackgroundImageLayout = ImageLayout.Center
        btn_starter.BorderColor = Color.PaleVioletRed
        btn_starter.BorderRadius = 40
        btn_starter.BorderSize = 0
        btn_starter.Cursor = Cursors.Hand
        btn_starter.FlatAppearance.BorderSize = 0
        btn_starter.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 40, 49)
        btn_starter.FlatStyle = FlatStyle.Flat
        btn_starter.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_starter.ForeColor = Color.FromArgb(238, 238, 238)
        btn_starter.Location = New Point(19, 626)
        btn_starter.Name = "btn_starter"
        btn_starter.Size = New Size(207, 80)
        btn_starter.TabIndex = 5
        btn_starter.Text = "Starter"
        btn_starter.TextColor = Color.FromArgb(238, 238, 238)
        btn_starter.UseVisualStyleBackColor = False
        ' 
        ' btn_drinks
        ' 
        btn_drinks.BackColor = Color.FromArgb(34, 40, 49)
        btn_drinks.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_drinks.BackgroundImageLayout = ImageLayout.Center
        btn_drinks.BorderColor = Color.PaleVioletRed
        btn_drinks.BorderRadius = 40
        btn_drinks.BorderSize = 0
        btn_drinks.Cursor = Cursors.Hand
        btn_drinks.FlatAppearance.BorderSize = 0
        btn_drinks.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 40, 49)
        btn_drinks.FlatStyle = FlatStyle.Flat
        btn_drinks.Font = New Font("Segoe UI", 15F)
        btn_drinks.ForeColor = Color.FromArgb(238, 238, 238)
        btn_drinks.Location = New Point(481, 626)
        btn_drinks.Name = "btn_drinks"
        btn_drinks.Size = New Size(207, 80)
        btn_drinks.TabIndex = 7
        btn_drinks.Text = "Drinks"
        btn_drinks.TextColor = Color.FromArgb(238, 238, 238)
        btn_drinks.UseVisualStyleBackColor = False
        ' 
        ' btn_desserts
        ' 
        btn_desserts.BackColor = Color.FromArgb(34, 40, 49)
        btn_desserts.BackgroundColor = Color.FromArgb(34, 40, 49)
        btn_desserts.BackgroundImageLayout = ImageLayout.Center
        btn_desserts.BorderColor = Color.PaleVioletRed
        btn_desserts.BorderRadius = 40
        btn_desserts.BorderSize = 0
        btn_desserts.Cursor = Cursors.Hand
        btn_desserts.FlatAppearance.BorderSize = 0
        btn_desserts.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 40, 49)
        btn_desserts.FlatStyle = FlatStyle.Flat
        btn_desserts.Font = New Font("Segoe UI", 15F)
        btn_desserts.ForeColor = Color.FromArgb(238, 238, 238)
        btn_desserts.Location = New Point(712, 626)
        btn_desserts.Name = "btn_desserts"
        btn_desserts.Size = New Size(207, 80)
        btn_desserts.TabIndex = 8
        btn_desserts.Text = "Desserts"
        btn_desserts.TextColor = Color.FromArgb(238, 238, 238)
        btn_desserts.UseVisualStyleBackColor = False
        ' 
        ' startermenu_panel
        ' 
        startermenu_panel.AutoScroll = True
        startermenu_panel.BackColor = Color.FromArgb(238, 238, 238)
        startermenu_panel.Controls.Add(Label7)
        startermenu_panel.Location = New Point(0, 0)
        startermenu_panel.Name = "startermenu_panel"
        startermenu_panel.Size = New Size(929, 606)
        startermenu_panel.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 30F)
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(377, 67)
        Label7.TabIndex = 0
        Label7.Text = "STARTER PANEL"
        ' 
        ' maincoursemenu_panel
        ' 
        maincoursemenu_panel.AutoScroll = True
        maincoursemenu_panel.BackColor = Color.FromArgb(238, 238, 238)
        maincoursemenu_panel.Controls.Add(Label6)
        maincoursemenu_panel.Location = New Point(0, 0)
        maincoursemenu_panel.Name = "maincoursemenu_panel"
        maincoursemenu_panel.Size = New Size(929, 606)
        maincoursemenu_panel.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 30F)
        Label6.Location = New Point(3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(511, 67)
        Label6.TabIndex = 0
        Label6.Text = "MAIN COURSE PANEL"
        ' 
        ' drinksmenu_panel
        ' 
        drinksmenu_panel.AutoScroll = True
        drinksmenu_panel.BackColor = Color.FromArgb(238, 238, 238)
        drinksmenu_panel.Controls.Add(Label5)
        drinksmenu_panel.Location = New Point(0, 0)
        drinksmenu_panel.Name = "drinksmenu_panel"
        drinksmenu_panel.Size = New Size(929, 606)
        drinksmenu_panel.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 30F)
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(357, 67)
        Label5.TabIndex = 0
        Label5.Text = "DRINKS PANEL"
        ' 
        ' dessertsmenu_panel
        ' 
        dessertsmenu_panel.AutoScroll = True
        dessertsmenu_panel.BackColor = Color.FromArgb(238, 238, 238)
        dessertsmenu_panel.Controls.Add(Label2)
        dessertsmenu_panel.Location = New Point(0, 0)
        dessertsmenu_panel.Name = "dessertsmenu_panel"
        dessertsmenu_panel.Size = New Size(929, 606)
        dessertsmenu_panel.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 30F)
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(405, 67)
        Label2.TabIndex = 0
        Label2.Text = "DESSERTS PANEL"
        ' 
        ' home_panel
        ' 
        home_panel.BackColor = Color.FromArgb(238, 238, 238)
        home_panel.Controls.Add(Label1)
        home_panel.Dock = DockStyle.Fill
        home_panel.Location = New Point(0, 0)
        home_panel.Name = "home_panel"
        home_panel.Size = New Size(929, 837)
        home_panel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 60F)
        Label1.Location = New Point(186, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(658, 133)
        Label1.TabIndex = 0
        Label1.Text = "HOME PANEL"
        ' 
        ' orders_panel
        ' 
        orders_panel.BackColor = Color.LightSteelBlue
        orders_panel.Dock = DockStyle.Fill
        orders_panel.Location = New Point(0, 0)
        orders_panel.Name = "orders_panel"
        orders_panel.Size = New Size(929, 837)
        orders_panel.TabIndex = 1
        ' 
        ' settings_panel
        ' 
        settings_panel.BackColor = Color.FromArgb(0, 64, 64)
        settings_panel.Controls.Add(Label4)
        settings_panel.Dock = DockStyle.Fill
        settings_panel.Location = New Point(0, 0)
        settings_panel.Name = "settings_panel"
        settings_panel.Size = New Size(929, 837)
        settings_panel.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 60F)
        Label4.Location = New Point(160, 273)
        Label4.Name = "Label4"
        Label4.Size = New Size(805, 133)
        Label4.TabIndex = 0
        Label4.Text = "SETTIGNS PANEL"
        ' 
        ' header_panel
        ' 
        header_panel.BackColor = Color.FromArgb(34, 40, 49)
        header_panel.Controls.Add(date_panel)
        header_panel.Controls.Add(search_panel)
        header_panel.Dock = DockStyle.Top
        header_panel.Location = New Point(0, 0)
        header_panel.Name = "header_panel"
        header_panel.Size = New Size(1494, 97)
        header_panel.TabIndex = 2
        ' 
        ' date_panel
        ' 
        date_panel.Controls.Add(date_icon)
        date_panel.Controls.Add(current_datelabel)
        date_panel.Location = New Point(1046, 26)
        date_panel.Name = "date_panel"
        date_panel.Size = New Size(419, 40)
        date_panel.TabIndex = 1
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
        current_datelabel.Font = New Font("Segoe UI", 14F)
        current_datelabel.ForeColor = Color.FromArgb(238, 238, 238)
        current_datelabel.Location = New Point(51, 6)
        current_datelabel.Name = "current_datelabel"
        current_datelabel.Size = New Size(64, 32)
        current_datelabel.TabIndex = 0
        current_datelabel.Text = "Date"
        ' 
        ' search_panel
        ' 
        search_panel.BackColor = Color.FromArgb(238, 238, 238)
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
        search_icon.FlatAppearance.MouseDownBackColor = Color.FromArgb(94, 143, 144)
        search_icon.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 195, 197)
        search_icon.Location = New Point(276, 0)
        search_icon.Name = "search_icon"
        search_icon.Size = New Size(81, 58)
        search_icon.TabIndex = 0
        search_icon.UseVisualStyleBackColor = True
        ' 
        ' search_text
        ' 
        search_text.BackColor = Color.FromArgb(238, 238, 238)
        search_text.BorderStyle = BorderStyle.None
        search_text.Font = New Font("Segoe UI", 12F)
        search_text.ForeColor = Color.FromArgb(49, 54, 63)
        search_text.Location = New Point(8, 16)
        search_text.Name = "search_text"
        search_text.PlaceholderText = "Search any product..."
        search_text.Size = New Size(262, 27)
        search_text.TabIndex = 1
        ' 
        ' navbtn_panel
        ' 
        navbtn_panel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        navbtn_panel.BackColor = Color.FromArgb(34, 40, 49)
        navbtn_panel.Controls.Add(btn_logout)
        navbtn_panel.Controls.Add(btn_settings)
        navbtn_panel.Controls.Add(btn_orders)
        navbtn_panel.Controls.Add(btn_payment)
        navbtn_panel.Controls.Add(btn_menu)
        navbtn_panel.Controls.Add(btn_home)
        navbtn_panel.Location = New Point(0, 0)
        navbtn_panel.Name = "navbtn_panel"
        navbtn_panel.Size = New Size(115, 935)
        navbtn_panel.TabIndex = 1
        ' 
        ' btn_logout
        ' 
        btn_logout.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btn_logout.BackColor = Color.Transparent
        btn_logout.BackgroundColor = Color.Transparent
        btn_logout.BackgroundImage = CType(resources.GetObject("btn_logout.BackgroundImage"), Image)
        btn_logout.BackgroundImageLayout = ImageLayout.Center
        btn_logout.BorderColor = Color.PaleVioletRed
        btn_logout.BorderRadius = 40
        btn_logout.BorderSize = 0
        btn_logout.Cursor = Cursors.Hand
        btn_logout.FlatAppearance.BorderSize = 0
        btn_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 54, 63)
        btn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.ForeColor = Color.FromArgb(238, 238, 238)
        btn_logout.Location = New Point(5, 684)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(100, 100)
        btn_logout.TabIndex = 9
        btn_logout.Text = "Logout"
        btn_logout.TextAlign = ContentAlignment.BottomCenter
        btn_logout.TextColor = Color.FromArgb(238, 238, 238)
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
        btn_settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 54, 63)
        btn_settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_settings.FlatStyle = FlatStyle.Flat
        btn_settings.ForeColor = Color.FromArgb(238, 238, 238)
        btn_settings.Location = New Point(5, 578)
        btn_settings.Name = "btn_settings"
        btn_settings.Size = New Size(100, 100)
        btn_settings.TabIndex = 8
        btn_settings.Text = "Settings"
        btn_settings.TextAlign = ContentAlignment.BottomCenter
        btn_settings.TextColor = Color.FromArgb(238, 238, 238)
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
        btn_orders.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 54, 63)
        btn_orders.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_orders.FlatStyle = FlatStyle.Flat
        btn_orders.ForeColor = Color.FromArgb(238, 238, 238)
        btn_orders.Location = New Point(5, 458)
        btn_orders.Name = "btn_orders"
        btn_orders.Size = New Size(100, 100)
        btn_orders.TabIndex = 7
        btn_orders.Text = "Orders"
        btn_orders.TextAlign = ContentAlignment.BottomCenter
        btn_orders.TextColor = Color.FromArgb(238, 238, 238)
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
        btn_payment.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 40, 49)
        btn_payment.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_payment.FlatStyle = FlatStyle.Flat
        btn_payment.ForeColor = Color.FromArgb(238, 238, 238)
        btn_payment.Location = New Point(5, 338)
        btn_payment.Name = "btn_payment"
        btn_payment.Size = New Size(100, 100)
        btn_payment.TabIndex = 6
        btn_payment.Text = "Payment"
        btn_payment.TextAlign = ContentAlignment.BottomCenter
        btn_payment.TextColor = Color.FromArgb(238, 238, 238)
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
        btn_menu.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 40, 49)
        btn_menu.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_menu.FlatStyle = FlatStyle.Flat
        btn_menu.ForeColor = Color.FromArgb(238, 238, 238)
        btn_menu.Location = New Point(5, 218)
        btn_menu.Name = "btn_menu"
        btn_menu.Size = New Size(100, 100)
        btn_menu.TabIndex = 5
        btn_menu.Text = "Menu"
        btn_menu.TextAlign = ContentAlignment.BottomCenter
        btn_menu.TextColor = Color.FromArgb(238, 238, 238)
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
        btn_home.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 40, 49)
        btn_home.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 171, 174)
        btn_home.FlatStyle = FlatStyle.Flat
        btn_home.ForeColor = Color.FromArgb(238, 238, 238)
        btn_home.Location = New Point(5, 98)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(100, 100)
        btn_home.TabIndex = 4
        btn_home.Text = "Home"
        btn_home.TextAlign = ContentAlignment.BottomCenter
        btn_home.TextColor = Color.FromArgb(238, 238, 238)
        btn_home.UseVisualStyleBackColor = False
        ' 
        ' Mainform
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        AutoScroll = True
        BackColor = Color.FromArgb(238, 238, 238)
        ClientSize = New Size(1494, 935)
        Controls.Add(Mainform_panel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Mainform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mainform"
        Mainform_panel.ResumeLayout(False)
        paymentreceipt_panel.ResumeLayout(False)
        textpayment_panel.ResumeLayout(False)
        textpayment_panel.PerformLayout()
        title_label.ResumeLayout(False)
        title_label.PerformLayout()
        CType(pguest_icon, ComponentModel.ISupportInitialize).EndInit()
        cash_panel.ResumeLayout(False)
        cash_panel.PerformLayout()
        btnpayment_panel.ResumeLayout(False)
        tip_panel.ResumeLayout(False)
        tip_panel.PerformLayout()
        receipt_panel.ResumeLayout(False)
        receipttotal_panel.ResumeLayout(False)
        receipttotal_panel.PerformLayout()
        guesttable_panel.ResumeLayout(False)
        guesttable_panel.PerformLayout()
        CType(table_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(guest_icon, ComponentModel.ISupportInitialize).EndInit()
        orderno_panel.ResumeLayout(False)
        orderno_panel.PerformLayout()
        nav_panel.ResumeLayout(False)
        payment_panel.ResumeLayout(False)
        payment_panel.PerformLayout()
        headerpayment_panel.ResumeLayout(False)
        headerpayment_panel.PerformLayout()
        CType(time_icon, ComponentModel.ISupportInitialize).EndInit()
        CType(table_photo, ComponentModel.ISupportInitialize).EndInit()
        foodmenu_panel.ResumeLayout(False)
        startermenu_panel.ResumeLayout(False)
        startermenu_panel.PerformLayout()
        maincoursemenu_panel.ResumeLayout(False)
        maincoursemenu_panel.PerformLayout()
        drinksmenu_panel.ResumeLayout(False)
        drinksmenu_panel.PerformLayout()
        dessertsmenu_panel.ResumeLayout(False)
        dessertsmenu_panel.PerformLayout()
        home_panel.ResumeLayout(False)
        home_panel.PerformLayout()
        settings_panel.ResumeLayout(False)
        settings_panel.PerformLayout()
        header_panel.ResumeLayout(False)
        date_panel.ResumeLayout(False)
        date_panel.PerformLayout()
        CType(date_icon, ComponentModel.ISupportInitialize).EndInit()
        search_panel.ResumeLayout(False)
        search_panel.PerformLayout()
        navbtn_panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Mainform_panel As Panel
    Friend WithEvents header_panel As Panel
    Friend WithEvents navbtn_panel As Panel
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
    Friend WithEvents date_panel As Panel
    Friend WithEvents current_datelabel As Label
    Friend WithEvents date_icon As PictureBox
    Friend WithEvents orderno_label As Label
    Friend WithEvents order_label As Label
    Friend WithEvents orderno_panel As Panel
    Friend WithEvents receiptmenu_panel As FlowLayoutPanel
    Friend WithEvents btn_cancelorder As CircularButton
    Friend WithEvents btn_sendorder As CircularButton
    Friend WithEvents servicecharge_label As Label
    Friend WithEvents subtotal_label As Label
    Friend WithEvents total_label As Label
    Friend WithEvents servicechargeno_label As Label
    Friend WithEvents subtotalno_label As Label
    Friend WithEvents totalno_label As Label
    Friend WithEvents guesttable_panel As Panel
    Friend WithEvents tableno_label As Label
    Friend WithEvents table_label As Label
    Friend WithEvents table_icon As PictureBox
    Friend WithEvents guestno_label As Label
    Friend WithEvents guest_label As Label
    Friend WithEvents guest_icon As PictureBox
    Friend WithEvents receipttotal_panel As Panel
    Friend WithEvents nav_panel As Panel
    Friend WithEvents home_panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents settings_panel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents payment_panel As Panel
    Friend WithEvents startermenu_panel As FlowLayoutPanel
    Friend WithEvents orders_panel As Panel
    Friend WithEvents foodmenu_panel As Panel
    Friend WithEvents btn_desserts As CircularButton
    Friend WithEvents btn_drinks As CircularButton
    Friend WithEvents btn_maincourse As CircularButton
    Friend WithEvents btn_starter As CircularButton
    Friend WithEvents Label7 As Label
    Friend WithEvents maincoursemenu_panel As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents drinksmenu_panel As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents dessertsmenu_panel As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents headerpayment_panel As Panel
    Friend WithEvents ptableno_label As Label
    Friend WithEvents ptable_label As Label
    Friend WithEvents table_photo As PictureBox
    Friend WithEvents pOrderno_label As Label
    Friend WithEvents time_label As Label
    Friend WithEvents ptime_label As Label
    Friend WithEvents time_icon As PictureBox
    Friend WithEvents item_label As Label
    Friend WithEvents paymentItem_panel As FlowLayoutPanel
    Friend WithEvents psubtotal_label As Label
    Friend WithEvents quantity_label As Label
    Friend WithEvents price_label As Label
    Friend WithEvents paymentreceipt_panel As Panel
    Friend WithEvents pay_label As Label
    Friend WithEvents pguestno_label As Label
    Friend WithEvents pguest_label As Label
    Friend WithEvents pguest_icon As PictureBox
    Friend WithEvents paytotal_label As Label
    Friend WithEvents btn_tip4 As CircularButton
    Friend WithEvents btn_tip3 As CircularButton
    Friend WithEvents btn_tip2 As CircularButton
    Friend WithEvents btn_tip1 As CircularButton
    Friend WithEvents btn_cash As CircularButton
    Friend WithEvents cash_label As Label
    Friend WithEvents btn_gcash As CircularButton
    Friend WithEvents btn_creditcard As CircularButton
    Friend WithEvents btnpayment_panel As Panel
    Friend WithEvents tip_panel As Panel
    Friend WithEvents cash_panel As Panel
    Friend WithEvents cashinput_text As TextBox
    Friend WithEvents prSubtotal_label As Label
    Friend WithEvents prTipsno_label As Label
    Friend WithEvents prTips_label As Label
    Friend WithEvents prTotalno_label As Label
    Friend WithEvents prTotal_label As Label
    Friend WithEvents btn_pay As CircularButton
    Friend WithEvents prSubtotalno_label As Label
    Friend WithEvents prServiceno_label As Label
    Friend WithEvents prService_label As Label
    Friend WithEvents textpayment_panel As Panel
    Friend WithEvents title_label As Panel
    Friend WithEvents sign_label As Label
    Friend WithEvents tips_label As Label
    Friend WithEvents btn_tip0 As CircularButton
End Class
