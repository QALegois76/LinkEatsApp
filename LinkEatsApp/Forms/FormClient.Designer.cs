namespace LinkEatsApp
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_lastName = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_firstName = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_lastName = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_firstName = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_eMail = new System.Windows.Forms.Label();
            this.tb_phone = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_mail = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_lvl_title = new System.Windows.Forms.Label();
            this.lb_lvl_description = new System.Windows.Forms.Label();
            this.chk_actifAccount = new ALEControlLibrary.ALERoundedCheckbox();
            this.lb_actifAccount = new System.Windows.Forms.Label();
            this.lb_lvl = new System.Windows.Forms.Label();
            this.pgrss_lvl = new ALEControlLibrary.CTRL.ALEProgressBar();
            this.lb_wallet = new System.Windows.Forms.Label();
            this.tb_wallet = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.rbtn_AddWallet = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.chk_emailCheck = new ALEControlLibrary.ALERoundedCheckbox();
            this.lb_createdAt_title = new System.Windows.Forms.Label();
            this.lb_createdAt_value = new System.Windows.Forms.Label();
            this.lb_lastModif_value = new System.Windows.Forms.Label();
            this.lb_lastModif_title = new System.Windows.Forms.Label();
            this.rbtn_save = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_linkerState = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_login = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.rbtn_pwd = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.lb_resetPwd = new System.Windows.Forms.Label();
            this.lb_linkerState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_lastName
            // 
            this.tb_lastName.BorderSize = 2;
            this.tb_lastName.CornerRadius = 15;
            this.tb_lastName.Location = new System.Drawing.Point(28, 178);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.PasswordChar = '\0';
            this.tb_lastName.ReadOnly = false;
            this.tb_lastName.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_lastName.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_lastName.Size = new System.Drawing.Size(350, 46);
            this.tb_lastName.TabIndex = 2;
            this.tb_lastName.WordWrad = true;
            this.tb_lastName.TextChanged += new System.EventHandler(this.tb_lastName_TextChanged);
            // 
            // tb_firstName
            // 
            this.tb_firstName.BorderSize = 2;
            this.tb_firstName.CornerRadius = 15;
            this.tb_firstName.Location = new System.Drawing.Point(558, 178);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.PasswordChar = '\0';
            this.tb_firstName.ReadOnly = false;
            this.tb_firstName.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_firstName.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_firstName.Size = new System.Drawing.Size(350, 46);
            this.tb_firstName.TabIndex = 3;
            this.tb_firstName.WordWrad = true;
            this.tb_firstName.TextChanged += new System.EventHandler(this.tb_lastName_TextChanged);
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Location = new System.Drawing.Point(28, 160);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(40, 15);
            this.lb_lastName.TabIndex = 4;
            this.lb_lastName.Text = "Nom :";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(25, 95);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(23, 15);
            this.lb_id.TabIndex = 5;
            this.lb_id.Text = "Id :";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.tb_id.Location = new System.Drawing.Point(54, 94);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(231, 16);
            this.tb_id.TabIndex = 6;
            this.tb_id.Text = "aaaa-aaaa-aaaa-aaaa";
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Location = new System.Drawing.Point(558, 160);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(55, 15);
            this.lb_firstName.TabIndex = 7;
            this.lb_firstName.Text = "Prénom :";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(558, 245);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(67, 15);
            this.lb_phone.TabIndex = 11;
            this.lb_phone.Text = "Téléphone :";
            // 
            // lb_eMail
            // 
            this.lb_eMail.AutoSize = true;
            this.lb_eMail.Location = new System.Drawing.Point(28, 245);
            this.lb_eMail.Name = "lb_eMail";
            this.lb_eMail.Size = new System.Drawing.Size(47, 15);
            this.lb_eMail.TabIndex = 10;
            this.lb_eMail.Text = "E-Mail :";
            // 
            // tb_phone
            // 
            this.tb_phone.BorderSize = 2;
            this.tb_phone.CornerRadius = 15;
            this.tb_phone.Location = new System.Drawing.Point(558, 263);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.PasswordChar = '\0';
            this.tb_phone.ReadOnly = false;
            this.tb_phone.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_phone.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_phone.Size = new System.Drawing.Size(350, 46);
            this.tb_phone.TabIndex = 9;
            this.tb_phone.WordWrad = true;
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // tb_mail
            // 
            this.tb_mail.BorderSize = 2;
            this.tb_mail.CornerRadius = 15;
            this.tb_mail.Location = new System.Drawing.Point(28, 263);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.PasswordChar = '\0';
            this.tb_mail.ReadOnly = false;
            this.tb_mail.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_mail.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_mail.Size = new System.Drawing.Size(307, 46);
            this.tb_mail.TabIndex = 8;
            this.tb_mail.WordWrad = true;
            this.tb_mail.TextChanged += new System.EventHandler(this.tb_mail_TextChanged);
            // 
            // lb_lvl_title
            // 
            this.lb_lvl_title.AutoSize = true;
            this.lb_lvl_title.Location = new System.Drawing.Point(28, 418);
            this.lb_lvl_title.Name = "lb_lvl_title";
            this.lb_lvl_title.Size = new System.Drawing.Size(50, 15);
            this.lb_lvl_title.TabIndex = 12;
            this.lb_lvl_title.Text = "Niveau :";
            // 
            // lb_lvl_description
            // 
            this.lb_lvl_description.AutoSize = true;
            this.lb_lvl_description.Location = new System.Drawing.Point(28, 490);
            this.lb_lvl_description.Name = "lb_lvl_description";
            this.lb_lvl_description.Size = new System.Drawing.Size(66, 15);
            this.lb_lvl_description.TabIndex = 13;
            this.lb_lvl_description.Text = "description";
            // 
            // chk_actifAccount
            // 
            this.chk_actifAccount.Checked = true;
            this.chk_actifAccount.CornerRadius = 15;
            this.chk_actifAccount.Enabled = false;
            this.chk_actifAccount.IconChecked = ALEControlLibrary.ALERoundedCheckbox.EIcon.Validate;
            this.chk_actifAccount.IconUndefined = ALEControlLibrary.ALERoundedCheckbox.EIcon.Line;
            this.chk_actifAccount.IsAnimationEnable = false;
            this.chk_actifAccount.IsAutoCheck = true;
            this.chk_actifAccount.IsCheckedFiller = true;
            this.chk_actifAccount.Location = new System.Drawing.Point(707, 83);
            this.chk_actifAccount.Name = "chk_actifAccount";
            this.chk_actifAccount.PourcentBorder = 0.01F;
            this.chk_actifAccount.PourcentIcon = 0.15F;
            this.chk_actifAccount.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.chk_actifAccount.Size = new System.Drawing.Size(40, 40);
            this.chk_actifAccount.State = ALEControlLibrary.ALERoundedCheckbox.EState.Checked;
            this.chk_actifAccount.TabIndex = 14;
            this.chk_actifAccount.Text = "aleRoundedCheckbox1";
            this.chk_actifAccount.UseVisualStyleBackColor = true;
            // 
            // lb_actifAccount
            // 
            this.lb_actifAccount.AutoSize = true;
            this.lb_actifAccount.Location = new System.Drawing.Point(753, 95);
            this.lb_actifAccount.Name = "lb_actifAccount";
            this.lb_actifAccount.Size = new System.Drawing.Size(71, 15);
            this.lb_actifAccount.TabIndex = 15;
            this.lb_actifAccount.Text = "Comte Actif";
            // 
            // lb_lvl
            // 
            this.lb_lvl.AutoSize = true;
            this.lb_lvl.Location = new System.Drawing.Point(85, 418);
            this.lb_lvl.Name = "lb_lvl";
            this.lb_lvl.Size = new System.Drawing.Size(13, 15);
            this.lb_lvl.TabIndex = 16;
            this.lb_lvl.Text = "0";
            // 
            // pgrss_lvl
            // 
            this.pgrss_lvl.BorderSize = 3;
            this.pgrss_lvl.Direction = ALEControlLibrary.CTRL.ALEProgressBar.EDirection.Horizontal;
            this.pgrss_lvl.ImgDecor = null;
            this.pgrss_lvl.ImgValue = null;
            this.pgrss_lvl.IsBorderVisible = true;
            this.pgrss_lvl.IsDebug = false;
            this.pgrss_lvl.IsImgValueIsOver = true;
            this.pgrss_lvl.IsTextVisisble = true;
            this.pgrss_lvl.Location = new System.Drawing.Point(28, 436);
            this.pgrss_lvl.Name = "pgrss_lvl";
            this.pgrss_lvl.PourcentBack = 1F;
            this.pgrss_lvl.PourcentFront = 1F;
            this.pgrss_lvl.PourcentValue = 0.25F;
            this.pgrss_lvl.Radius = 15;
            this.pgrss_lvl.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.pgrss_lvl.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.pgrss_lvl.Size = new System.Drawing.Size(880, 44);
            this.pgrss_lvl.TabIndex = 17;
            this.pgrss_lvl.Text = "25%";
            // 
            // lb_wallet
            // 
            this.lb_wallet.AutoSize = true;
            this.lb_wallet.Location = new System.Drawing.Point(28, 552);
            this.lb_wallet.Name = "lb_wallet";
            this.lb_wallet.Size = new System.Drawing.Size(91, 15);
            this.lb_wallet.TabIndex = 18;
            this.lb_wallet.Text = "Porte monnaie :";
            // 
            // tb_wallet
            // 
            this.tb_wallet.BorderSize = 2;
            this.tb_wallet.CornerRadius = 15;
            this.tb_wallet.Location = new System.Drawing.Point(28, 570);
            this.tb_wallet.Name = "tb_wallet";
            this.tb_wallet.PasswordChar = '\0';
            this.tb_wallet.ReadOnly = true;
            this.tb_wallet.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_wallet.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_wallet.Size = new System.Drawing.Size(304, 46);
            this.tb_wallet.TabIndex = 19;
            this.tb_wallet.Text = "0.00";
            this.tb_wallet.WordWrad = true;
            // 
            // rbtn_AddWallet
            // 
            this.rbtn_AddWallet.BackgroundImage = global::LinkEatsApp.Properties.Resources.ADD;
            this.rbtn_AddWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_AddWallet.BorderSize = 2;
            this.rbtn_AddWallet.BorderSizeActiv = 10;
            this.rbtn_AddWallet.IsActivate = false;
            this.rbtn_AddWallet.IsAutoActivable = false;
            this.rbtn_AddWallet.IsBorderVisible = true;
            this.rbtn_AddWallet.IsClickable = true;
            this.rbtn_AddWallet.IsDebug = false;
            this.rbtn_AddWallet.Location = new System.Drawing.Point(329, 571);
            this.rbtn_AddWallet.Name = "rbtn_AddWallet";
            this.rbtn_AddWallet.PourcentBack = 0.75F;
            this.rbtn_AddWallet.Radius = 15;
            this.rbtn_AddWallet.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_AddWallet.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_AddWallet.Size = new System.Drawing.Size(46, 44);
            this.rbtn_AddWallet.TabIndex = 20;
            this.rbtn_AddWallet.UseVisualStyleBackColor = true;
            this.rbtn_AddWallet.Click += new System.EventHandler(this.rbtn_AddWallet_Click);
            // 
            // chk_emailCheck
            // 
            this.chk_emailCheck.Checked = true;
            this.chk_emailCheck.CornerRadius = 15;
            this.chk_emailCheck.Enabled = false;
            this.chk_emailCheck.IconChecked = ALEControlLibrary.ALERoundedCheckbox.EIcon.Validate;
            this.chk_emailCheck.IconUndefined = ALEControlLibrary.ALERoundedCheckbox.EIcon.Line;
            this.chk_emailCheck.IsAnimationEnable = false;
            this.chk_emailCheck.IsAutoCheck = true;
            this.chk_emailCheck.IsCheckedFiller = false;
            this.chk_emailCheck.Location = new System.Drawing.Point(332, 264);
            this.chk_emailCheck.Name = "chk_emailCheck";
            this.chk_emailCheck.PourcentBorder = 0.05F;
            this.chk_emailCheck.PourcentIcon = 0.125F;
            this.chk_emailCheck.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.chk_emailCheck.Size = new System.Drawing.Size(44, 44);
            this.chk_emailCheck.State = ALEControlLibrary.ALERoundedCheckbox.EState.Checked;
            this.chk_emailCheck.TabIndex = 21;
            this.chk_emailCheck.Text = "aleRoundedCheckbox1";
            this.chk_emailCheck.UseVisualStyleBackColor = true;
            // 
            // lb_createdAt_title
            // 
            this.lb_createdAt_title.AutoSize = true;
            this.lb_createdAt_title.Location = new System.Drawing.Point(731, 743);
            this.lb_createdAt_title.Name = "lb_createdAt_title";
            this.lb_createdAt_title.Size = new System.Drawing.Size(99, 15);
            this.lb_createdAt_title.TabIndex = 22;
            this.lb_createdAt_title.Text = "Compte créee le :";
            // 
            // lb_createdAt_value
            // 
            this.lb_createdAt_value.AutoSize = true;
            this.lb_createdAt_value.Location = new System.Drawing.Point(843, 743);
            this.lb_createdAt_value.Name = "lb_createdAt_value";
            this.lb_createdAt_value.Size = new System.Drawing.Size(65, 15);
            this.lb_createdAt_value.TabIndex = 23;
            this.lb_createdAt_value.Text = "01/01/1972";
            // 
            // lb_lastModif_value
            // 
            this.lb_lastModif_value.AutoSize = true;
            this.lb_lastModif_value.Location = new System.Drawing.Point(843, 777);
            this.lb_lastModif_value.Name = "lb_lastModif_value";
            this.lb_lastModif_value.Size = new System.Drawing.Size(65, 15);
            this.lb_lastModif_value.TabIndex = 25;
            this.lb_lastModif_value.Text = "01/01/1972";
            // 
            // lb_lastModif_title
            // 
            this.lb_lastModif_title.AutoSize = true;
            this.lb_lastModif_title.Location = new System.Drawing.Point(709, 777);
            this.lb_lastModif_title.Name = "lb_lastModif_title";
            this.lb_lastModif_title.Size = new System.Drawing.Size(128, 15);
            this.lb_lastModif_title.TabIndex = 24;
            this.lb_lastModif_title.Text = "Dernière modification :";
            // 
            // rbtn_save
            // 
            this.rbtn_save.BackgroundImage = global::LinkEatsApp.Properties.Resources.Save;
            this.rbtn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_save.BorderSize = 1;
            this.rbtn_save.BorderSizeActiv = 10;
            this.rbtn_save.IsActivate = false;
            this.rbtn_save.IsAutoActivable = false;
            this.rbtn_save.IsBorderVisible = true;
            this.rbtn_save.IsClickable = true;
            this.rbtn_save.IsDebug = false;
            this.rbtn_save.Location = new System.Drawing.Point(394, 717);
            this.rbtn_save.Name = "rbtn_save";
            this.rbtn_save.PourcentBack = 0.8F;
            this.rbtn_save.Radius = 15;
            this.rbtn_save.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_save.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_save.Size = new System.Drawing.Size(134, 75);
            this.rbtn_save.TabIndex = 26;
            this.rbtn_save.UseVisualStyleBackColor = true;
            this.rbtn_save.Click += new System.EventHandler(this.rbtn_save_Click);
            // 
            // rbtn_linkerState
            // 
            this.rbtn_linkerState.BackgroundImage = global::LinkEatsApp.Properties.Resources.LinkerVide;
            this.rbtn_linkerState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_linkerState.BorderSize = 1;
            this.rbtn_linkerState.BorderSizeActiv = 10;
            this.rbtn_linkerState.IsActivate = false;
            this.rbtn_linkerState.IsAutoActivable = true;
            this.rbtn_linkerState.IsBorderVisible = false;
            this.rbtn_linkerState.IsClickable = true;
            this.rbtn_linkerState.IsDebug = false;
            this.rbtn_linkerState.Location = new System.Drawing.Point(707, 556);
            this.rbtn_linkerState.Name = "rbtn_linkerState";
            this.rbtn_linkerState.PourcentBack = 0.8F;
            this.rbtn_linkerState.Radius = 15;
            this.rbtn_linkerState.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_linkerState.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_linkerState.Size = new System.Drawing.Size(134, 75);
            this.rbtn_linkerState.TabIndex = 27;
            this.rbtn_linkerState.UseVisualStyleBackColor = true;
            this.rbtn_linkerState.Click += new System.EventHandler(this.rbtn_linkerState_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Login :";
            // 
            // tb_login
            // 
            this.tb_login.BorderSize = 2;
            this.tb_login.CornerRadius = 15;
            this.tb_login.Location = new System.Drawing.Point(28, 345);
            this.tb_login.Name = "tb_login";
            this.tb_login.PasswordChar = '\0';
            this.tb_login.ReadOnly = false;
            this.tb_login.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_login.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_login.Size = new System.Drawing.Size(350, 46);
            this.tb_login.TabIndex = 28;
            this.tb_login.WordWrad = true;
            // 
            // rbtn_pwd
            // 
            this.rbtn_pwd.BackgroundImage = global::LinkEatsApp.Properties.Resources.reset;
            this.rbtn_pwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_pwd.BorderSize = 1;
            this.rbtn_pwd.BorderSizeActiv = 10;
            this.rbtn_pwd.IsActivate = false;
            this.rbtn_pwd.IsAutoActivable = false;
            this.rbtn_pwd.IsBorderVisible = true;
            this.rbtn_pwd.IsClickable = true;
            this.rbtn_pwd.IsDebug = false;
            this.rbtn_pwd.Location = new System.Drawing.Point(833, 345);
            this.rbtn_pwd.Name = "rbtn_pwd";
            this.rbtn_pwd.PourcentBack = 0.8F;
            this.rbtn_pwd.Radius = 15;
            this.rbtn_pwd.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_pwd.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_pwd.Size = new System.Drawing.Size(75, 46);
            this.rbtn_pwd.TabIndex = 30;
            this.rbtn_pwd.UseVisualStyleBackColor = true;
            this.rbtn_pwd.Click += new System.EventHandler(this.rbtn_pwd_Click);
            // 
            // lb_resetPwd
            // 
            this.lb_resetPwd.AutoSize = true;
            this.lb_resetPwd.Location = new System.Drawing.Point(725, 361);
            this.lb_resetPwd.Name = "lb_resetPwd";
            this.lb_resetPwd.Size = new System.Drawing.Size(94, 15);
            this.lb_resetPwd.TabIndex = 31;
            this.lb_resetPwd.Text = "Reset Password :";
            // 
            // lb_linkerState
            // 
            this.lb_linkerState.AutoSize = true;
            this.lb_linkerState.Location = new System.Drawing.Point(610, 586);
            this.lb_linkerState.Name = "lb_linkerState";
            this.lb_linkerState.Size = new System.Drawing.Size(85, 15);
            this.lb_linkerState.TabIndex = 32;
            this.lb_linkerState.Text = "Linker Option :";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 804);
            this.Controls.Add(this.lb_linkerState);
            this.Controls.Add(this.lb_resetPwd);
            this.Controls.Add(this.rbtn_pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.rbtn_linkerState);
            this.Controls.Add(this.rbtn_save);
            this.Controls.Add(this.lb_lastModif_value);
            this.Controls.Add(this.lb_lastModif_title);
            this.Controls.Add(this.lb_createdAt_value);
            this.Controls.Add(this.lb_createdAt_title);
            this.Controls.Add(this.chk_emailCheck);
            this.Controls.Add(this.rbtn_AddWallet);
            this.Controls.Add(this.tb_wallet);
            this.Controls.Add(this.lb_wallet);
            this.Controls.Add(this.pgrss_lvl);
            this.Controls.Add(this.lb_lvl);
            this.Controls.Add(this.lb_actifAccount);
            this.Controls.Add(this.chk_actifAccount);
            this.Controls.Add(this.lb_lvl_description);
            this.Controls.Add(this.lb_lvl_title);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_eMail);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.lb_firstName);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_lastName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.tb_lastName);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Controls.SetChildIndex(this.tb_lastName, 0);
            this.Controls.SetChildIndex(this.tb_firstName, 0);
            this.Controls.SetChildIndex(this.lb_lastName, 0);
            this.Controls.SetChildIndex(this.lb_id, 0);
            this.Controls.SetChildIndex(this.tb_id, 0);
            this.Controls.SetChildIndex(this.lb_firstName, 0);
            this.Controls.SetChildIndex(this.tb_mail, 0);
            this.Controls.SetChildIndex(this.tb_phone, 0);
            this.Controls.SetChildIndex(this.lb_eMail, 0);
            this.Controls.SetChildIndex(this.lb_phone, 0);
            this.Controls.SetChildIndex(this.lb_lvl_title, 0);
            this.Controls.SetChildIndex(this.lb_lvl_description, 0);
            this.Controls.SetChildIndex(this.chk_actifAccount, 0);
            this.Controls.SetChildIndex(this.lb_actifAccount, 0);
            this.Controls.SetChildIndex(this.lb_lvl, 0);
            this.Controls.SetChildIndex(this.pgrss_lvl, 0);
            this.Controls.SetChildIndex(this.lb_wallet, 0);
            this.Controls.SetChildIndex(this.tb_wallet, 0);
            this.Controls.SetChildIndex(this.rbtn_AddWallet, 0);
            this.Controls.SetChildIndex(this.chk_emailCheck, 0);
            this.Controls.SetChildIndex(this.lb_createdAt_title, 0);
            this.Controls.SetChildIndex(this.lb_createdAt_value, 0);
            this.Controls.SetChildIndex(this.lb_lastModif_title, 0);
            this.Controls.SetChildIndex(this.lb_lastModif_value, 0);
            this.Controls.SetChildIndex(this.rbtn_save, 0);
            this.Controls.SetChildIndex(this.rbtn_linkerState, 0);
            this.Controls.SetChildIndex(this.tb_login, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.rbtn_pwd, 0);
            this.Controls.SetChildIndex(this.lb_resetPwd, 0);
            this.Controls.SetChildIndex(this.lb_linkerState, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_lastName;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_firstName;
        private Label lb_lastName;
        private Label lb_id;
        private TextBox tb_id;
        private Label lb_firstName;
        private Label lb_phone;
        private Label lb_eMail;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_phone;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_mail;
        private Label lb_lvl_title;
        private Label lb_lvl_description;
        private ALEControlLibrary.ALERoundedCheckbox chk_actifAccount;
        private Label lb_actifAccount;
        private Label lb_lvl;
        private ALEControlLibrary.CTRL.ALEProgressBar pgrss_lvl;
        private Label lb_wallet;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_wallet;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_AddWallet;
        private ALEControlLibrary.ALERoundedCheckbox chk_emailCheck;
        private Label lb_createdAt_title;
        private Label lb_createdAt_value;
        private Label lb_lastModif_value;
        private Label lb_lastModif_title;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_save;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_linkerState;
        private Label label1;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_login;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_pwd;
        private Label lb_resetPwd;
        private Label lb_linkerState;
    }
}