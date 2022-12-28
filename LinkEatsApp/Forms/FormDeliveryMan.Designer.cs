namespace LinkEatsApp
{
    partial class FormDeliveryMan
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
            this.lb_resetPwd = new System.Windows.Forms.Label();
            this.rbtn_pwd = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_login = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.rbtn_save = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.lb_lastModif_value = new System.Windows.Forms.Label();
            this.lb_lastModif_title = new System.Windows.Forms.Label();
            this.lb_createdAt_value = new System.Windows.Forms.Label();
            this.lb_createdAt_title = new System.Windows.Forms.Label();
            this.chk_emailCheck = new ALEControlLibrary.ALERoundedCheckbox();
            this.lb_actifAccount = new System.Windows.Forms.Label();
            this.chk_actifAccount = new ALEControlLibrary.ALERoundedCheckbox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_eMail = new System.Windows.Forms.Label();
            this.tb_phone = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_mail = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_firstName = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_lastName = new System.Windows.Forms.Label();
            this.tb_firstName = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_lastName = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_IBAN = new System.Windows.Forms.Label();
            this.pgrss_rate = new ALEControlLibrary.CTRL.ALEProgressBar();
            this.lb_lvl_title = new System.Windows.Forms.Label();
            this.tb_IBAN = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_latitude = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_latitude = new System.Windows.Forms.Label();
            this.tb_longitude = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_longitude = new System.Windows.Forms.Label();
            this.tb_actionRange = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_actionRange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_resetPwd
            // 
            this.lb_resetPwd.AutoSize = true;
            this.lb_resetPwd.Location = new System.Drawing.Point(709, 381);
            this.lb_resetPwd.Name = "lb_resetPwd";
            this.lb_resetPwd.Size = new System.Drawing.Size(94, 15);
            this.lb_resetPwd.TabIndex = 62;
            this.lb_resetPwd.Text = "Reset Password :";
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
            this.rbtn_pwd.Location = new System.Drawing.Point(817, 365);
            this.rbtn_pwd.Name = "rbtn_pwd";
            this.rbtn_pwd.PourcentBack = 0.8F;
            this.rbtn_pwd.Radius = 15;
            this.rbtn_pwd.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_pwd.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_pwd.Size = new System.Drawing.Size(75, 46);
            this.rbtn_pwd.TabIndex = 61;
            this.rbtn_pwd.UseVisualStyleBackColor = true;
            this.rbtn_pwd.Click += new System.EventHandler(this.rbtn_pwd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Login :";
            // 
            // tb_login
            // 
            this.tb_login.BorderSize = 2;
            this.tb_login.CornerRadius = 15;
            this.tb_login.Location = new System.Drawing.Point(12, 365);
            this.tb_login.Name = "tb_login";
            this.tb_login.PasswordChar = '\0';
            this.tb_login.ReadOnly = false;
            this.tb_login.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_login.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_login.Size = new System.Drawing.Size(350, 46);
            this.tb_login.TabIndex = 59;
            this.tb_login.WordWrad = true;
            this.tb_login.TextChanged += new System.EventHandler(this.tb_TextChanged);
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
            this.rbtn_save.Location = new System.Drawing.Point(376, 742);
            this.rbtn_save.Name = "rbtn_save";
            this.rbtn_save.PourcentBack = 0.8F;
            this.rbtn_save.Radius = 15;
            this.rbtn_save.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_save.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_save.Size = new System.Drawing.Size(134, 75);
            this.rbtn_save.TabIndex = 57;
            this.rbtn_save.UseVisualStyleBackColor = true;
            // 
            // lb_lastModif_value
            // 
            this.lb_lastModif_value.AutoSize = true;
            this.lb_lastModif_value.Location = new System.Drawing.Point(163, 705);
            this.lb_lastModif_value.Name = "lb_lastModif_value";
            this.lb_lastModif_value.Size = new System.Drawing.Size(65, 15);
            this.lb_lastModif_value.TabIndex = 56;
            this.lb_lastModif_value.Text = "01/01/1972";
            // 
            // lb_lastModif_title
            // 
            this.lb_lastModif_title.AutoSize = true;
            this.lb_lastModif_title.Location = new System.Drawing.Point(29, 705);
            this.lb_lastModif_title.Name = "lb_lastModif_title";
            this.lb_lastModif_title.Size = new System.Drawing.Size(128, 15);
            this.lb_lastModif_title.TabIndex = 55;
            this.lb_lastModif_title.Text = "Dernière modification :";
            // 
            // lb_createdAt_value
            // 
            this.lb_createdAt_value.AutoSize = true;
            this.lb_createdAt_value.Location = new System.Drawing.Point(163, 671);
            this.lb_createdAt_value.Name = "lb_createdAt_value";
            this.lb_createdAt_value.Size = new System.Drawing.Size(65, 15);
            this.lb_createdAt_value.TabIndex = 54;
            this.lb_createdAt_value.Text = "01/01/1972";
            // 
            // lb_createdAt_title
            // 
            this.lb_createdAt_title.AutoSize = true;
            this.lb_createdAt_title.Location = new System.Drawing.Point(51, 671);
            this.lb_createdAt_title.Name = "lb_createdAt_title";
            this.lb_createdAt_title.Size = new System.Drawing.Size(99, 15);
            this.lb_createdAt_title.TabIndex = 53;
            this.lb_createdAt_title.Text = "Compte créee le :";
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
            this.chk_emailCheck.Location = new System.Drawing.Point(316, 288);
            this.chk_emailCheck.Name = "chk_emailCheck";
            this.chk_emailCheck.PourcentBorder = 0.05F;
            this.chk_emailCheck.PourcentIcon = 0.125F;
            this.chk_emailCheck.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.chk_emailCheck.Size = new System.Drawing.Size(44, 44);
            this.chk_emailCheck.State = ALEControlLibrary.ALERoundedCheckbox.EState.Checked;
            this.chk_emailCheck.TabIndex = 52;
            this.chk_emailCheck.Text = "aleRoundedCheckbox1";
            this.chk_emailCheck.UseVisualStyleBackColor = true;
            // 
            // lb_actifAccount
            // 
            this.lb_actifAccount.AutoSize = true;
            this.lb_actifAccount.Location = new System.Drawing.Point(737, 88);
            this.lb_actifAccount.Name = "lb_actifAccount";
            this.lb_actifAccount.Size = new System.Drawing.Size(71, 15);
            this.lb_actifAccount.TabIndex = 46;
            this.lb_actifAccount.Text = "Comte Actif";
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
            this.chk_actifAccount.Location = new System.Drawing.Point(691, 76);
            this.chk_actifAccount.Name = "chk_actifAccount";
            this.chk_actifAccount.PourcentBorder = 0.01F;
            this.chk_actifAccount.PourcentIcon = 0.15F;
            this.chk_actifAccount.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.chk_actifAccount.Size = new System.Drawing.Size(40, 40);
            this.chk_actifAccount.State = ALEControlLibrary.ALERoundedCheckbox.EState.Checked;
            this.chk_actifAccount.TabIndex = 45;
            this.chk_actifAccount.Text = "aleRoundedCheckbox1";
            this.chk_actifAccount.UseVisualStyleBackColor = true;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(542, 269);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(67, 15);
            this.lb_phone.TabIndex = 42;
            this.lb_phone.Text = "Téléphone :";
            // 
            // lb_eMail
            // 
            this.lb_eMail.AutoSize = true;
            this.lb_eMail.Location = new System.Drawing.Point(12, 269);
            this.lb_eMail.Name = "lb_eMail";
            this.lb_eMail.Size = new System.Drawing.Size(47, 15);
            this.lb_eMail.TabIndex = 41;
            this.lb_eMail.Text = "E-Mail :";
            // 
            // tb_phone
            // 
            this.tb_phone.BorderSize = 2;
            this.tb_phone.CornerRadius = 15;
            this.tb_phone.Location = new System.Drawing.Point(542, 287);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.PasswordChar = '\0';
            this.tb_phone.ReadOnly = false;
            this.tb_phone.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_phone.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_phone.Size = new System.Drawing.Size(350, 46);
            this.tb_phone.TabIndex = 40;
            this.tb_phone.WordWrad = true;
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // tb_mail
            // 
            this.tb_mail.BorderSize = 2;
            this.tb_mail.CornerRadius = 15;
            this.tb_mail.Location = new System.Drawing.Point(12, 287);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.PasswordChar = '\0';
            this.tb_mail.ReadOnly = false;
            this.tb_mail.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_mail.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_mail.Size = new System.Drawing.Size(307, 46);
            this.tb_mail.TabIndex = 39;
            this.tb_mail.WordWrad = true;
            this.tb_mail.TextChanged += new System.EventHandler(this.tb_mail_TextChanged);
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Location = new System.Drawing.Point(542, 118);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(55, 15);
            this.lb_firstName.TabIndex = 38;
            this.lb_firstName.Text = "Prénom :";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.tb_id.Location = new System.Drawing.Point(38, 87);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(231, 16);
            this.tb_id.TabIndex = 37;
            this.tb_id.Text = "aaaa-aaaa-aaaa-aaaa";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(9, 88);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(23, 15);
            this.lb_id.TabIndex = 36;
            this.lb_id.Text = "Id :";
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Location = new System.Drawing.Point(12, 118);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(40, 15);
            this.lb_lastName.TabIndex = 35;
            this.lb_lastName.Text = "Nom :";
            // 
            // tb_firstName
            // 
            this.tb_firstName.BorderSize = 2;
            this.tb_firstName.CornerRadius = 15;
            this.tb_firstName.Location = new System.Drawing.Point(542, 136);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.PasswordChar = '\0';
            this.tb_firstName.ReadOnly = false;
            this.tb_firstName.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_firstName.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_firstName.Size = new System.Drawing.Size(350, 46);
            this.tb_firstName.TabIndex = 34;
            this.tb_firstName.WordWrad = true;
            this.tb_firstName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_lastName
            // 
            this.tb_lastName.BorderSize = 2;
            this.tb_lastName.CornerRadius = 15;
            this.tb_lastName.Location = new System.Drawing.Point(12, 136);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.PasswordChar = '\0';
            this.tb_lastName.ReadOnly = false;
            this.tb_lastName.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_lastName.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_lastName.Size = new System.Drawing.Size(350, 46);
            this.tb_lastName.TabIndex = 33;
            this.tb_lastName.WordWrad = true;
            this.tb_lastName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_IBAN
            // 
            this.lb_IBAN.AutoSize = true;
            this.lb_IBAN.Location = new System.Drawing.Point(14, 424);
            this.lb_IBAN.Name = "lb_IBAN";
            this.lb_IBAN.Size = new System.Drawing.Size(34, 15);
            this.lb_IBAN.TabIndex = 44;
            this.lb_IBAN.Text = "IBAN";
            // 
            // pgrss_rate
            // 
            this.pgrss_rate.BorderSize = 3;
            this.pgrss_rate.Direction = ALEControlLibrary.CTRL.ALEProgressBar.EDirection.Horizontal;
            this.pgrss_rate.ImgDecor = global::LinkEatsApp.Properties.Resources.Etoiles_pleines;
            this.pgrss_rate.ImgValue = global::LinkEatsApp.Properties.Resources.Etoiles_pleines_Jaunes;
            this.pgrss_rate.IsBorderVisible = false;
            this.pgrss_rate.IsDebug = false;
            this.pgrss_rate.IsImgValueIsOver = true;
            this.pgrss_rate.IsTextVisisble = false;
            this.pgrss_rate.Location = new System.Drawing.Point(70, 194);
            this.pgrss_rate.Name = "pgrss_rate";
            this.pgrss_rate.PourcentBack = 1F;
            this.pgrss_rate.PourcentFront = 1F;
            this.pgrss_rate.PourcentValue = 0.25F;
            this.pgrss_rate.Radius = 15;
            this.pgrss_rate.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.pgrss_rate.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.pgrss_rate.Size = new System.Drawing.Size(257, 62);
            this.pgrss_rate.TabIndex = 48;
            this.pgrss_rate.Text = "25%";
            // 
            // lb_lvl_title
            // 
            this.lb_lvl_title.AutoSize = true;
            this.lb_lvl_title.Location = new System.Drawing.Point(14, 218);
            this.lb_lvl_title.Name = "lb_lvl_title";
            this.lb_lvl_title.Size = new System.Drawing.Size(50, 15);
            this.lb_lvl_title.TabIndex = 43;
            this.lb_lvl_title.Text = "Niveau :";
            // 
            // tb_IBAN
            // 
            this.tb_IBAN.BorderSize = 2;
            this.tb_IBAN.CornerRadius = 15;
            this.tb_IBAN.Location = new System.Drawing.Point(14, 442);
            this.tb_IBAN.Name = "tb_IBAN";
            this.tb_IBAN.PasswordChar = '\0';
            this.tb_IBAN.ReadOnly = false;
            this.tb_IBAN.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_IBAN.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_IBAN.Size = new System.Drawing.Size(878, 46);
            this.tb_IBAN.TabIndex = 63;
            this.tb_IBAN.WordWrad = true;
            this.tb_IBAN.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_latitude
            // 
            this.tb_latitude.BorderSize = 2;
            this.tb_latitude.CornerRadius = 15;
            this.tb_latitude.Location = new System.Drawing.Point(14, 610);
            this.tb_latitude.Name = "tb_latitude";
            this.tb_latitude.PasswordChar = '\0';
            this.tb_latitude.ReadOnly = true;
            this.tb_latitude.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_latitude.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_latitude.Size = new System.Drawing.Size(431, 46);
            this.tb_latitude.TabIndex = 65;
            this.tb_latitude.WordWrad = true;
            // 
            // lb_latitude
            // 
            this.lb_latitude.AutoSize = true;
            this.lb_latitude.Location = new System.Drawing.Point(14, 592);
            this.lb_latitude.Name = "lb_latitude";
            this.lb_latitude.Size = new System.Drawing.Size(50, 15);
            this.lb_latitude.TabIndex = 64;
            this.lb_latitude.Text = "Latitude";
            // 
            // tb_longitude
            // 
            this.tb_longitude.BorderSize = 2;
            this.tb_longitude.CornerRadius = 15;
            this.tb_longitude.Location = new System.Drawing.Point(461, 610);
            this.tb_longitude.Name = "tb_longitude";
            this.tb_longitude.PasswordChar = '\0';
            this.tb_longitude.ReadOnly = true;
            this.tb_longitude.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_longitude.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_longitude.Size = new System.Drawing.Size(431, 46);
            this.tb_longitude.TabIndex = 66;
            this.tb_longitude.WordWrad = true;
            // 
            // lb_longitude
            // 
            this.lb_longitude.AutoSize = true;
            this.lb_longitude.Location = new System.Drawing.Point(464, 592);
            this.lb_longitude.Name = "lb_longitude";
            this.lb_longitude.Size = new System.Drawing.Size(61, 15);
            this.lb_longitude.TabIndex = 67;
            this.lb_longitude.Text = "Longitude";
            // 
            // tb_actionRange
            // 
            this.tb_actionRange.BorderSize = 2;
            this.tb_actionRange.CornerRadius = 15;
            this.tb_actionRange.Location = new System.Drawing.Point(14, 525);
            this.tb_actionRange.Name = "tb_actionRange";
            this.tb_actionRange.PasswordChar = '\0';
            this.tb_actionRange.ReadOnly = false;
            this.tb_actionRange.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_actionRange.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_actionRange.Size = new System.Drawing.Size(431, 46);
            this.tb_actionRange.TabIndex = 69;
            this.tb_actionRange.WordWrad = true;
            this.tb_actionRange.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_actionRange
            // 
            this.lb_actionRange.AutoSize = true;
            this.lb_actionRange.Location = new System.Drawing.Point(14, 507);
            this.lb_actionRange.Name = "lb_actionRange";
            this.lb_actionRange.Size = new System.Drawing.Size(92, 15);
            this.lb_actionRange.TabIndex = 68;
            this.lb_actionRange.Text = "Rayon d\'action :";
            // 
            // FormDeliveryMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 829);
            this.Controls.Add(this.tb_actionRange);
            this.Controls.Add(this.lb_actionRange);
            this.Controls.Add(this.lb_longitude);
            this.Controls.Add(this.tb_longitude);
            this.Controls.Add(this.tb_latitude);
            this.Controls.Add(this.lb_latitude);
            this.Controls.Add(this.tb_IBAN);
            this.Controls.Add(this.lb_resetPwd);
            this.Controls.Add(this.rbtn_pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.rbtn_save);
            this.Controls.Add(this.lb_lastModif_value);
            this.Controls.Add(this.lb_lastModif_title);
            this.Controls.Add(this.lb_createdAt_value);
            this.Controls.Add(this.lb_createdAt_title);
            this.Controls.Add(this.chk_emailCheck);
            this.Controls.Add(this.pgrss_rate);
            this.Controls.Add(this.lb_actifAccount);
            this.Controls.Add(this.chk_actifAccount);
            this.Controls.Add(this.lb_IBAN);
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
            this.Name = "FormDeliveryMan";
            this.Text = "FormDeliveryMan";
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
            this.Controls.SetChildIndex(this.lb_IBAN, 0);
            this.Controls.SetChildIndex(this.chk_actifAccount, 0);
            this.Controls.SetChildIndex(this.lb_actifAccount, 0);
            this.Controls.SetChildIndex(this.pgrss_rate, 0);
            this.Controls.SetChildIndex(this.chk_emailCheck, 0);
            this.Controls.SetChildIndex(this.lb_createdAt_title, 0);
            this.Controls.SetChildIndex(this.lb_createdAt_value, 0);
            this.Controls.SetChildIndex(this.lb_lastModif_title, 0);
            this.Controls.SetChildIndex(this.lb_lastModif_value, 0);
            this.Controls.SetChildIndex(this.rbtn_save, 0);
            this.Controls.SetChildIndex(this.tb_login, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.rbtn_pwd, 0);
            this.Controls.SetChildIndex(this.lb_resetPwd, 0);
            this.Controls.SetChildIndex(this.tb_IBAN, 0);
            this.Controls.SetChildIndex(this.lb_latitude, 0);
            this.Controls.SetChildIndex(this.tb_latitude, 0);
            this.Controls.SetChildIndex(this.tb_longitude, 0);
            this.Controls.SetChildIndex(this.lb_longitude, 0);
            this.Controls.SetChildIndex(this.lb_actionRange, 0);
            this.Controls.SetChildIndex(this.tb_actionRange, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lb_resetPwd;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_pwd;
        private Label label1;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_login;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_save;
        private Label lb_lastModif_value;
        private Label lb_lastModif_title;
        private Label lb_createdAt_value;
        private Label lb_createdAt_title;
        private ALEControlLibrary.ALERoundedCheckbox chk_emailCheck;
        private Label lb_actifAccount;
        private ALEControlLibrary.ALERoundedCheckbox chk_actifAccount;
        private Label lb_phone;
        private Label lb_eMail;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_phone;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_mail;
        private Label lb_firstName;
        private TextBox tb_id;
        private Label lb_id;
        private Label lb_lastName;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_firstName;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_lastName;
        private Label lb_IBAN;
        private ALEControlLibrary.CTRL.ALEProgressBar pgrss_rate;
        private Label lb_lvl_title;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_IBAN;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_latitude;
        private Label lb_latitude;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_longitude;
        private Label lb_longitude;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_actionRange;
        private Label lb_actionRange;
    }
}