
Partial Friend Class frm_Post_Payment
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.Btn_Payment_Post = New DevExpress.XtraEditors.DropDownButton()

        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Number = New DevExpress.XtraEditors.ButtonEdit()
        Me.Account_Ledger = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Name = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Address = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Model = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Brand = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Color = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Outstanding_Interest = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Outstanding_Principal = New DevExpress.XtraEditors.LabelControl()
        Me.Account_Outstanding = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.labelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.payment_Date_Posting = New DevExpress.XtraEditors.DateEdit()
        Me.labelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.calcEdit1 = New DevExpress.XtraEditors.CalcEdit()
        Me.labelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.calcEdit2 = New DevExpress.XtraEditors.CalcEdit()
        Me.calcEdit3 = New DevExpress.XtraEditors.CalcEdit()
        Me.calcEdit4 = New DevExpress.XtraEditors.CalcEdit()
        Me.calcEdit5 = New DevExpress.XtraEditors.CalcEdit()
        Me.calcEdit6 = New DevExpress.XtraEditors.CalcEdit()
        Me.labelControl27 = New DevExpress.XtraEditors.LabelControl()
        CType((Me.Account_Number.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.Account_Ledger.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        CType((Me.groupControl3), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl3.SuspendLayout()
        CType((Me.payment_Date_Posting.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.payment_Date_Posting.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.calcEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.calcEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.calcEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.calcEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.calcEdit5.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.calcEdit6.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.Btn_Payment_Post.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.Btn_Payment_Post.Location = New System.Drawing.Point(272, 389)
        Me.Btn_Payment_Post.Name = "Btn_Payment_Post"
        Me.Btn_Payment_Post.Size = New System.Drawing.Size(135, 23)
        Me.Btn_Payment_Post.TabIndex = 15
        Me.Btn_Payment_Post.Text = "Post Payment"

        Me.labelControl1.Location = New System.Drawing.Point(14, 15)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(42, 13)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "Account"
        Me.labelControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.labelControl7.Location = New System.Drawing.Point(395, 15)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(35, 13)
        Me.labelControl7.TabIndex = 2
        Me.labelControl7.Text = "Ledger"
        Me.Account_Number.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.Account_Number.Location = New System.Drawing.Point(78, 12)
        Me.Account_Number.Name = "Account_Number"
        Me.Account_Number.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
        Me.Account_Number.Properties.Appearance.Options.UseFont = True
        Me.Account_Number.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.Account_Number.Size = New System.Drawing.Size(300, 20)
        Me.Account_Number.TabIndex = 1
        Me.Account_Ledger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.Account_Ledger.Location = New System.Drawing.Point(434, 12)
        Me.Account_Ledger.Name = "Account_Ledger"
        Me.Account_Ledger.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
        Me.Account_Ledger.Properties.Appearance.Options.UseFont = True
        Me.Account_Ledger.Size = New System.Drawing.Size(54, 20)
        Me.Account_Ledger.TabIndex = 3
        Me.labelControl2.Location = New System.Drawing.Point(14, 41)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(29, 13)
        Me.labelControl2.TabIndex = 4
        Me.labelControl2.Text = "Name"
        Me.labelControl3.Location = New System.Drawing.Point(14, 60)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(41, 13)
        Me.labelControl3.TabIndex = 6
        Me.labelControl3.Text = "Address"
        Me.Account_Name.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Account_Name.Appearance.Options.UseFont = True
        Me.Account_Name.Location = New System.Drawing.Point(78, 41)
        Me.Account_Name.Name = "Account_Name"
        Me.Account_Name.Size = New System.Drawing.Size(77, 13)
        Me.Account_Name.TabIndex = 5
        Me.Account_Name.Text = "Account_Name"
        Me.Account_Address.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Account_Address.Appearance.Options.UseFont = True
        Me.Account_Address.Location = New System.Drawing.Point(78, 60)
        Me.Account_Address.Name = "Account_Address"
        Me.Account_Address.Size = New System.Drawing.Size(88, 13)
        Me.Account_Address.TabIndex = 7
        Me.Account_Address.Text = "Account_Address"
        Me.labelControl10.Location = New System.Drawing.Point(12, 68)
        Me.labelControl10.Name = "labelControl10"
        Me.labelControl10.Size = New System.Drawing.Size(66, 13)
        Me.labelControl10.TabIndex = 4
        Me.labelControl10.Text = "Outstanding"
        Me.labelControl8.Location = New System.Drawing.Point(12, 30)
        Me.labelControl8.Name = "labelControl8"
        Me.labelControl8.Size = New System.Drawing.Size(44, 13)
        Me.labelControl8.TabIndex = 0
        Me.labelControl8.Text = "Principal"
        Me.labelControl9.Location = New System.Drawing.Point(12, 49)
        Me.labelControl9.Name = "labelControl9"
        Me.labelControl9.Size = New System.Drawing.Size(39, 13)
        Me.labelControl9.TabIndex = 2
        Me.labelControl9.Text = "Interest"
        Me.labelControl4.Location = New System.Drawing.Point(12, 30)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(31, 13)
        Me.labelControl4.TabIndex = 0
        Me.labelControl4.Text = "Brand"
        Me.labelControl5.Location = New System.Drawing.Point(12, 49)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(33, 13)
        Me.labelControl5.TabIndex = 2
        Me.labelControl5.Text = "Model"
        Me.labelControl6.Location = New System.Drawing.Point(12, 68)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(28, 13)
        Me.labelControl6.TabIndex = 4
        Me.labelControl6.Text = "Color"
        Me.Account_Model.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Account_Model.Appearance.Options.UseFont = True
        Me.Account_Model.Location = New System.Drawing.Point(66, 49)
        Me.Account_Model.Name = "Account_Model"
        Me.Account_Model.Size = New System.Drawing.Size(80, 13)
        Me.Account_Model.TabIndex = 3
        Me.Account_Model.Text = "Account_Model"
        Me.Account_Brand.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Account_Brand.Appearance.Options.UseFont = True
        Me.Account_Brand.Location = New System.Drawing.Point(66, 30)
        Me.Account_Brand.Name = "Account_Brand"
        Me.Account_Brand.Size = New System.Drawing.Size(77, 13)
        Me.Account_Brand.TabIndex = 1
        Me.Account_Brand.Text = "Account_Brand"
        Me.Account_Color.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Account_Color.Appearance.Options.UseFont = True
        Me.Account_Color.Location = New System.Drawing.Point(66, 68)
        Me.Account_Color.Name = "Account_Color"
        Me.Account_Color.Size = New System.Drawing.Size(74, 13)
        Me.Account_Color.TabIndex = 5
        Me.Account_Color.Text = "Account_Color"
        Me.Account_Outstanding_Interest.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Account_Outstanding_Interest.Appearance.Options.UseFont = True
        Me.Account_Outstanding_Interest.Appearance.Options.UseTextOptions = True
        Me.Account_Outstanding_Interest.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Account_Outstanding_Interest.Location = New System.Drawing.Point(133, 49)
        Me.Account_Outstanding_Interest.Name = "Account_Outstanding_Interest"
        Me.Account_Outstanding_Interest.Size = New System.Drawing.Size(21, 13)
        Me.Account_Outstanding_Interest.TabIndex = 3
        Me.Account_Outstanding_Interest.Text = "0.00"
        Me.Account_Outstanding_Principal.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Account_Outstanding_Principal.Appearance.Options.UseFont = True
        Me.Account_Outstanding_Principal.Appearance.Options.UseTextOptions = True
        Me.Account_Outstanding_Principal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Account_Outstanding_Principal.Location = New System.Drawing.Point(133, 30)
        Me.Account_Outstanding_Principal.Name = "Account_Outstanding_Principal"
        Me.Account_Outstanding_Principal.Size = New System.Drawing.Size(21, 13)
        Me.Account_Outstanding_Principal.TabIndex = 1
        Me.Account_Outstanding_Principal.Text = "0.00"
        Me.Account_Outstanding.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Account_Outstanding.Appearance.Options.UseFont = True
        Me.Account_Outstanding.Appearance.Options.UseTextOptions = True
        Me.Account_Outstanding.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Account_Outstanding.Location = New System.Drawing.Point(133, 68)
        Me.Account_Outstanding.Name = "Account_Outstanding"
        Me.Account_Outstanding.Size = New System.Drawing.Size(21, 13)
        Me.Account_Outstanding.TabIndex = 5
        Me.Account_Outstanding.Text = "0.00"
        Me.groupControl1.Controls.Add(Me.labelControl4)
        Me.groupControl1.Controls.Add(Me.labelControl6)
        Me.groupControl1.Controls.Add(Me.labelControl5)
        Me.groupControl1.Controls.Add(Me.Account_Brand)
        Me.groupControl1.Controls.Add(Me.Account_Color)
        Me.groupControl1.Controls.Add(Me.Account_Model)
        Me.groupControl1.Location = New System.Drawing.Point(12, 88)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.Size = New System.Drawing.Size(172, 89)
        Me.groupControl1.TabIndex = 8
        Me.groupControl1.Text = "Unit"
        Me.groupControl2.Controls.Add(Me.labelControl8)
        Me.groupControl2.Controls.Add(Me.labelControl9)
        Me.groupControl2.Controls.Add(Me.Account_Outstanding)
        Me.groupControl2.Controls.Add(Me.labelControl10)
        Me.groupControl2.Controls.Add(Me.Account_Outstanding_Interest)
        Me.groupControl2.Controls.Add(Me.Account_Outstanding_Principal)
        Me.groupControl2.Location = New System.Drawing.Point(12, 183)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.Size = New System.Drawing.Size(172, 89)
        Me.groupControl2.TabIndex = 9
        Me.groupControl2.Text = "Oustanding Balance"
        Me.groupControl3.Controls.Add(Me.labelControl19)
        Me.groupControl3.Controls.Add(Me.labelControl20)
        Me.groupControl3.Controls.Add(Me.labelControl15)
        Me.groupControl3.Controls.Add(Me.labelControl16)
        Me.groupControl3.Controls.Add(Me.labelControl17)
        Me.groupControl3.Controls.Add(Me.labelControl18)
        Me.groupControl3.Controls.Add(Me.labelControl11)
        Me.groupControl3.Controls.Add(Me.labelControl12)
        Me.groupControl3.Controls.Add(Me.labelControl13)
        Me.groupControl3.Controls.Add(Me.labelControl14)
        Me.groupControl3.Location = New System.Drawing.Point(12, 278)
        Me.groupControl3.Name = "groupControl3"
        Me.groupControl3.Size = New System.Drawing.Size(172, 132)
        Me.groupControl3.TabIndex = 10
        Me.groupControl3.Text = "Current Due"
        Me.labelControl19.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.labelControl19.Appearance.Options.UseFont = True
        Me.labelControl19.Location = New System.Drawing.Point(12, 106)
        Me.labelControl19.Name = "labelControl19"
        Me.labelControl19.Size = New System.Drawing.Size(39, 21)
        Me.labelControl19.TabIndex = 8
        Me.labelControl19.Text = "Total"
        Me.labelControl20.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.labelControl20.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.labelControl20.Appearance.Options.UseFont = True
        Me.labelControl20.Appearance.Options.UseTextOptions = True
        Me.labelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.labelControl20.Location = New System.Drawing.Point(123, 106)
        Me.labelControl20.Name = "labelControl20"
        Me.labelControl20.Size = New System.Drawing.Size(31, 21)
        Me.labelControl20.TabIndex = 9
        Me.labelControl20.Text = "0.00"
        Me.labelControl15.Location = New System.Drawing.Point(12, 68)
        Me.labelControl15.Name = "labelControl15"
        Me.labelControl15.Size = New System.Drawing.Size(36, 13)
        Me.labelControl15.TabIndex = 4
        Me.labelControl15.Text = "Rebate"
        Me.labelControl16.Location = New System.Drawing.Point(12, 87)
        Me.labelControl16.Name = "labelControl16"
        Me.labelControl16.Size = New System.Drawing.Size(37, 13)
        Me.labelControl16.TabIndex = 6
        Me.labelControl16.Text = "Penalty"
        Me.labelControl17.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.labelControl17.Appearance.Options.UseFont = True
        Me.labelControl17.Appearance.Options.UseTextOptions = True
        Me.labelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.labelControl17.Location = New System.Drawing.Point(133, 87)
        Me.labelControl17.Name = "labelControl17"
        Me.labelControl17.Size = New System.Drawing.Size(21, 13)
        Me.labelControl17.TabIndex = 7
        Me.labelControl17.Text = "0.00"
        Me.labelControl18.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.labelControl18.Appearance.Options.UseFont = True
        Me.labelControl18.Appearance.Options.UseTextOptions = True
        Me.labelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.labelControl18.Location = New System.Drawing.Point(133, 68)
        Me.labelControl18.Name = "labelControl18"
        Me.labelControl18.Size = New System.Drawing.Size(21, 13)
        Me.labelControl18.TabIndex = 5
        Me.labelControl18.Text = "0.00"
        Me.labelControl11.Location = New System.Drawing.Point(12, 30)
        Me.labelControl11.Name = "labelControl11"
        Me.labelControl11.Size = New System.Drawing.Size(44, 13)
        Me.labelControl11.TabIndex = 0
        Me.labelControl11.Text = "Principal"
        Me.labelControl12.Location = New System.Drawing.Point(12, 49)
        Me.labelControl12.Name = "labelControl12"
        Me.labelControl12.Size = New System.Drawing.Size(39, 13)
        Me.labelControl12.TabIndex = 2
        Me.labelControl12.Text = "Interest"
        Me.labelControl13.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.labelControl13.Appearance.Options.UseFont = True
        Me.labelControl13.Appearance.Options.UseTextOptions = True
        Me.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.labelControl13.Location = New System.Drawing.Point(133, 49)
        Me.labelControl13.Name = "labelControl13"
        Me.labelControl13.Size = New System.Drawing.Size(21, 13)
        Me.labelControl13.TabIndex = 3
        Me.labelControl13.Text = "0.00"
        Me.labelControl14.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.labelControl14.Appearance.Options.UseFont = True
        Me.labelControl14.Appearance.Options.UseTextOptions = True
        Me.labelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.labelControl14.Location = New System.Drawing.Point(133, 30)
        Me.labelControl14.Name = "labelControl14"
        Me.labelControl14.Size = New System.Drawing.Size(21, 13)
        Me.labelControl14.TabIndex = 1
        Me.labelControl14.Text = "0.00"
        Me.payment_Date_Posting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.payment_Date_Posting.Location = New System.Drawing.Point(206, 85)
        Me.payment_Date_Posting.Name = "payment_Date_Posting"
        Me.payment_Date_Posting.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.payment_Date_Posting.Properties.Appearance.Options.UseFont = True
        Me.payment_Date_Posting.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.payment_Date_Posting.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.payment_Date_Posting.Size = New System.Drawing.Size(282, 28)
        Me.payment_Date_Posting.TabIndex = 12
        Me.labelControl22.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F)
        Me.labelControl22.Appearance.Options.UseFont = True
        Me.labelControl22.Location = New System.Drawing.Point(206, 131)
        Me.labelControl22.Name = "labelControl22"
        Me.labelControl22.Size = New System.Drawing.Size(56, 21)
        Me.labelControl22.TabIndex = 13
        Me.labelControl22.Text = "Amount"
        Me.calcEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.calcEdit1.Location = New System.Drawing.Point(304, 128)
        Me.calcEdit1.Name = "calcEdit1"
        Me.calcEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.calcEdit1.Properties.Appearance.Options.UseFont = True
        Me.calcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcEdit1.Size = New System.Drawing.Size(184, 28)
        Me.calcEdit1.TabIndex = 14
        Me.labelControl23.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F)
        Me.labelControl23.Appearance.Options.UseFont = True
        Me.labelControl23.Location = New System.Drawing.Point(206, 233)
        Me.labelControl23.Name = "labelControl23"
        Me.labelControl23.Size = New System.Drawing.Size(48, 21)
        Me.labelControl23.TabIndex = 19
        Me.labelControl23.Text = "Rebate"
        Me.labelControl24.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F)
        Me.labelControl24.Appearance.Options.UseFont = True
        Me.labelControl24.Location = New System.Drawing.Point(206, 267)
        Me.labelControl24.Name = "labelControl24"
        Me.labelControl24.Size = New System.Drawing.Size(51, 21)
        Me.labelControl24.TabIndex = 21
        Me.labelControl24.Text = "Penalty"
        Me.labelControl25.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F)
        Me.labelControl25.Appearance.Options.UseFont = True
        Me.labelControl25.Location = New System.Drawing.Point(206, 165)
        Me.labelControl25.Name = "labelControl25"
        Me.labelControl25.Size = New System.Drawing.Size(60, 21)
        Me.labelControl25.TabIndex = 15
        Me.labelControl25.Text = "Principal"
        Me.labelControl26.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F)
        Me.labelControl26.Appearance.Options.UseFont = True
        Me.labelControl26.Location = New System.Drawing.Point(206, 199)
        Me.labelControl26.Name = "labelControl26"
        Me.labelControl26.Size = New System.Drawing.Size(52, 21)
        Me.labelControl26.TabIndex = 17
        Me.labelControl26.Text = "Interest"
        Me.calcEdit2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.calcEdit2.Location = New System.Drawing.Point(304, 162)
        Me.calcEdit2.Name = "calcEdit2"
        Me.calcEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.calcEdit2.Properties.Appearance.Options.UseFont = True
        Me.calcEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcEdit2.Size = New System.Drawing.Size(184, 28)
        Me.calcEdit2.TabIndex = 16
        Me.calcEdit3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.calcEdit3.Location = New System.Drawing.Point(304, 196)
        Me.calcEdit3.Name = "calcEdit3"
        Me.calcEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.calcEdit3.Properties.Appearance.Options.UseFont = True
        Me.calcEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcEdit3.Size = New System.Drawing.Size(184, 28)
        Me.calcEdit3.TabIndex = 18
        Me.calcEdit4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.calcEdit4.Location = New System.Drawing.Point(304, 230)
        Me.calcEdit4.Name = "calcEdit4"
        Me.calcEdit4.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.calcEdit4.Properties.Appearance.Options.UseFont = True
        Me.calcEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcEdit4.Size = New System.Drawing.Size(184, 28)
        Me.calcEdit4.TabIndex = 20
        Me.calcEdit5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.calcEdit5.Location = New System.Drawing.Point(304, 264)
        Me.calcEdit5.Name = "calcEdit5"
        Me.calcEdit5.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.calcEdit5.Properties.Appearance.Options.UseFont = True
        Me.calcEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcEdit5.Size = New System.Drawing.Size(184, 28)
        Me.calcEdit5.TabIndex = 22
        Me.calcEdit6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.calcEdit6.Location = New System.Drawing.Point(304, 298)
        Me.calcEdit6.Name = "calcEdit6"
        Me.calcEdit6.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.calcEdit6.Properties.Appearance.Options.UseFont = True
        Me.calcEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcEdit6.Size = New System.Drawing.Size(184, 28)
        Me.calcEdit6.TabIndex = 24
        Me.labelControl27.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
        Me.labelControl27.Appearance.Options.UseFont = True
        Me.labelControl27.Location = New System.Drawing.Point(206, 301)
        Me.labelControl27.Name = "labelControl27"
        Me.labelControl27.Size = New System.Drawing.Size(39, 21)
        Me.labelControl27.TabIndex = 23
        Me.labelControl27.Text = "Total"
        Me.AcceptButton = Me.Btn_Payment_Post
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(500, 424)
        Me.Controls.Add(Me.calcEdit6)
        Me.Controls.Add(Me.labelControl27)
        Me.Controls.Add(Me.calcEdit5)
        Me.Controls.Add(Me.calcEdit4)
        Me.Controls.Add(Me.calcEdit3)
        Me.Controls.Add(Me.calcEdit2)
        Me.Controls.Add(Me.labelControl23)
        Me.Controls.Add(Me.labelControl24)
        Me.Controls.Add(Me.labelControl25)
        Me.Controls.Add(Me.labelControl26)
        Me.Controls.Add(Me.calcEdit1)
        Me.Controls.Add(Me.labelControl22)
        Me.Controls.Add(Me.payment_Date_Posting)
        Me.Controls.Add(Me.groupControl3)
        Me.Controls.Add(Me.groupControl2)
        Me.Controls.Add(Me.groupControl1)
        Me.Controls.Add(Me.Account_Address)
        Me.Controls.Add(Me.Account_Name)
        Me.Controls.Add(Me.labelControl2)
        Me.Controls.Add(Me.labelControl3)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.labelControl7)
        Me.Controls.Add(Me.Account_Number)
        Me.Controls.Add(Me.Btn_Payment_Post)
        Me.Controls.Add(Me.Account_Ledger)
        Me.MaximizeBox = False
        Me.Name = "frm_Post_Payment"
        Me.Text = "Post Payment"
        CType((Me.Account_Number.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.Account_Ledger.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        Me.groupControl1.PerformLayout()
        CType((Me.groupControl2), System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        Me.groupControl2.PerformLayout()
        CType((Me.groupControl3), System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl3.ResumeLayout(False)
        Me.groupControl3.PerformLayout()
        CType((Me.payment_Date_Posting.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.payment_Date_Posting.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.calcEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.calcEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.calcEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.calcEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.calcEdit5.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.calcEdit6.Properties), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Btn_Payment_Post As DevExpress.XtraEditors.DropDownButton
    Private labelControl1 As DevExpress.XtraEditors.LabelControl
    Private labelControl7 As DevExpress.XtraEditors.LabelControl
    Friend Account_Number As DevExpress.XtraEditors.ButtonEdit
    Private labelControl2 As DevExpress.XtraEditors.LabelControl
    Private labelControl3 As DevExpress.XtraEditors.LabelControl
    Private Account_Name As DevExpress.XtraEditors.LabelControl
    Private Account_Address As DevExpress.XtraEditors.LabelControl
    Private labelControl10 As DevExpress.XtraEditors.LabelControl
    Private labelControl8 As DevExpress.XtraEditors.LabelControl
    Private labelControl9 As DevExpress.XtraEditors.LabelControl
    Private labelControl4 As DevExpress.XtraEditors.LabelControl
    Private labelControl5 As DevExpress.XtraEditors.LabelControl
    Private labelControl6 As DevExpress.XtraEditors.LabelControl
    Private Account_Model As DevExpress.XtraEditors.LabelControl
    Private Account_Brand As DevExpress.XtraEditors.LabelControl
    Private Account_Color As DevExpress.XtraEditors.LabelControl
    Private Account_Outstanding_Interest As DevExpress.XtraEditors.LabelControl
    Private Account_Outstanding_Principal As DevExpress.XtraEditors.LabelControl
    Private Account_Outstanding As DevExpress.XtraEditors.LabelControl
    Private groupControl1 As DevExpress.XtraEditors.GroupControl
    Private groupControl2 As DevExpress.XtraEditors.GroupControl
    Private groupControl3 As DevExpress.XtraEditors.GroupControl
    Private labelControl19 As DevExpress.XtraEditors.LabelControl
    Private labelControl20 As DevExpress.XtraEditors.LabelControl
    Private labelControl15 As DevExpress.XtraEditors.LabelControl
    Private labelControl16 As DevExpress.XtraEditors.LabelControl
    Private labelControl17 As DevExpress.XtraEditors.LabelControl
    Private labelControl18 As DevExpress.XtraEditors.LabelControl
    Private labelControl11 As DevExpress.XtraEditors.LabelControl
    Private labelControl12 As DevExpress.XtraEditors.LabelControl
    Private labelControl13 As DevExpress.XtraEditors.LabelControl
    Private labelControl14 As DevExpress.XtraEditors.LabelControl
    Private payment_Date_Posting As DevExpress.XtraEditors.DateEdit
    Private labelControl22 As DevExpress.XtraEditors.LabelControl
    Private calcEdit1 As DevExpress.XtraEditors.CalcEdit
    Private labelControl23 As DevExpress.XtraEditors.LabelControl
    Private labelControl24 As DevExpress.XtraEditors.LabelControl
    Private labelControl25 As DevExpress.XtraEditors.LabelControl
    Private labelControl26 As DevExpress.XtraEditors.LabelControl
    Private calcEdit2 As DevExpress.XtraEditors.CalcEdit
    Private calcEdit3 As DevExpress.XtraEditors.CalcEdit
    Private calcEdit4 As DevExpress.XtraEditors.CalcEdit
    Private calcEdit5 As DevExpress.XtraEditors.CalcEdit
    Private calcEdit6 As DevExpress.XtraEditors.CalcEdit
    Private labelControl27 As DevExpress.XtraEditors.LabelControl
    Friend Account_Ledger As DevExpress.XtraEditors.TextEdit
End Class

