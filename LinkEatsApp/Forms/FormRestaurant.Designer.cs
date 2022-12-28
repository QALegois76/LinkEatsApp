namespace LinkEatsApp.Forms
{
    partial class FormRestaurant
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
            this.pict_banner = new System.Windows.Forms.PictureBox();
            this.tb_actionRange = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_actionRange = new System.Windows.Forms.Label();
            this.tb_IBAN = new ALEControlLibrary.CTRL.ALERoundedTextbox();
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
            this.pgrss_rate = new ALEControlLibrary.CTRL.ALEProgressBar();
            this.lb_actifAccount = new System.Windows.Forms.Label();
            this.chk_actifAccount = new ALEControlLibrary.ALERoundedCheckbox();
            this.lb_IBAN = new System.Windows.Forms.Label();
            this.lb_rate = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_eMail = new System.Windows.Forms.Label();
            this.tb_phone = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_mail = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.rbtn_icon = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.lb_restoName = new System.Windows.Forms.Label();
            this.tb_restoName = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_siren = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_siren = new System.Windows.Forms.Label();
            this.tb_siret = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.lb_siret = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pict_banner)).BeginInit();
            this.SuspendLayout();
            // 
            // pict_banner
            // 
            this.pict_banner.BackgroundImage = global::LinkEatsApp.Properties.Resources.default_banner;
            this.pict_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pict_banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pict_banner.Location = new System.Drawing.Point(0, 66);
            this.pict_banner.Name = "pict_banner";
            this.pict_banner.Size = new System.Drawing.Size(918, 208);
            this.pict_banner.TabIndex = 2;
            this.pict_banner.TabStop = false;
            // 
            // tb_actionRange
            // 
            this.tb_actionRange.BorderSize = 2;
            this.tb_actionRange.CornerRadius = 15;
            this.tb_actionRange.Location = new System.Drawing.Point(17, 624);
            this.tb_actionRange.Name = "tb_actionRange";
            this.tb_actionRange.PasswordChar = '\0';
            this.tb_actionRange.ReadOnly = false;
            this.tb_actionRange.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_actionRange.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_actionRange.Size = new System.Drawing.Size(351, 46);
            this.tb_actionRange.TabIndex = 101;
            this.tb_actionRange.WordWrad = true;
            this.tb_actionRange.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_actionRange
            // 
            this.lb_actionRange.AutoSize = true;
            this.lb_actionRange.Location = new System.Drawing.Point(17, 606);
            this.lb_actionRange.Name = "lb_actionRange";
            this.lb_actionRange.Size = new System.Drawing.Size(92, 15);
            this.lb_actionRange.TabIndex = 100;
            this.lb_actionRange.Text = "Rayon d\'action :";
            // 
            // tb_IBAN
            // 
            this.tb_IBAN.BorderSize = 2;
            this.tb_IBAN.CornerRadius = 15;
            this.tb_IBAN.Location = new System.Drawing.Point(17, 703);
            this.tb_IBAN.Name = "tb_IBAN";
            this.tb_IBAN.PasswordChar = '\0';
            this.tb_IBAN.ReadOnly = false;
            this.tb_IBAN.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_IBAN.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_IBAN.Size = new System.Drawing.Size(878, 46);
            this.tb_IBAN.TabIndex = 95;
            this.tb_IBAN.WordWrad = true;
            this.tb_IBAN.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_resetPwd
            // 
            this.lb_resetPwd.AutoSize = true;
            this.lb_resetPwd.Location = new System.Drawing.Point(705, 549);
            this.lb_resetPwd.Name = "lb_resetPwd";
            this.lb_resetPwd.Size = new System.Drawing.Size(94, 15);
            this.lb_resetPwd.TabIndex = 94;
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
            this.rbtn_pwd.Location = new System.Drawing.Point(813, 533);
            this.rbtn_pwd.Name = "rbtn_pwd";
            this.rbtn_pwd.PourcentBack = 0.8F;
            this.rbtn_pwd.Radius = 15;
            this.rbtn_pwd.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_pwd.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_pwd.Size = new System.Drawing.Size(75, 46);
            this.rbtn_pwd.TabIndex = 93;
            this.rbtn_pwd.UseVisualStyleBackColor = true;
            this.rbtn_pwd.Click += new System.EventHandler(this.rbtn_pwd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "Login :";
            // 
            // tb_login
            // 
            this.tb_login.BorderSize = 2;
            this.tb_login.CornerRadius = 15;
            this.tb_login.Location = new System.Drawing.Point(12, 533);
            this.tb_login.Name = "tb_login";
            this.tb_login.PasswordChar = '\0';
            this.tb_login.ReadOnly = false;
            this.tb_login.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_login.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_login.Size = new System.Drawing.Size(356, 46);
            this.tb_login.TabIndex = 91;
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
            this.rbtn_save.Location = new System.Drawing.Point(377, 938);
            this.rbtn_save.Name = "rbtn_save";
            this.rbtn_save.PourcentBack = 0.8F;
            this.rbtn_save.Radius = 15;
            this.rbtn_save.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_save.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_save.Size = new System.Drawing.Size(134, 75);
            this.rbtn_save.TabIndex = 90;
            this.rbtn_save.UseVisualStyleBackColor = true;
            this.rbtn_save.Click += new System.EventHandler(this.rbtn_save_Click);
            // 
            // lb_lastModif_value
            // 
            this.lb_lastModif_value.AutoSize = true;
            this.lb_lastModif_value.Location = new System.Drawing.Point(827, 998);
            this.lb_lastModif_value.Name = "lb_lastModif_value";
            this.lb_lastModif_value.Size = new System.Drawing.Size(65, 15);
            this.lb_lastModif_value.TabIndex = 89;
            this.lb_lastModif_value.Text = "01/01/1972";
            // 
            // lb_lastModif_title
            // 
            this.lb_lastModif_title.AutoSize = true;
            this.lb_lastModif_title.Location = new System.Drawing.Point(693, 998);
            this.lb_lastModif_title.Name = "lb_lastModif_title";
            this.lb_lastModif_title.Size = new System.Drawing.Size(128, 15);
            this.lb_lastModif_title.TabIndex = 88;
            this.lb_lastModif_title.Text = "Dernière modification :";
            // 
            // lb_createdAt_value
            // 
            this.lb_createdAt_value.AutoSize = true;
            this.lb_createdAt_value.Location = new System.Drawing.Point(827, 964);
            this.lb_createdAt_value.Name = "lb_createdAt_value";
            this.lb_createdAt_value.Size = new System.Drawing.Size(65, 15);
            this.lb_createdAt_value.TabIndex = 87;
            this.lb_createdAt_value.Text = "01/01/1972";
            // 
            // lb_createdAt_title
            // 
            this.lb_createdAt_title.AutoSize = true;
            this.lb_createdAt_title.Location = new System.Drawing.Point(715, 964);
            this.lb_createdAt_title.Name = "lb_createdAt_title";
            this.lb_createdAt_title.Size = new System.Drawing.Size(99, 15);
            this.lb_createdAt_title.TabIndex = 86;
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
            this.chk_emailCheck.Location = new System.Drawing.Point(324, 456);
            this.chk_emailCheck.Name = "chk_emailCheck";
            this.chk_emailCheck.PourcentBorder = 0.05F;
            this.chk_emailCheck.PourcentIcon = 0.125F;
            this.chk_emailCheck.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.chk_emailCheck.Size = new System.Drawing.Size(44, 44);
            this.chk_emailCheck.State = ALEControlLibrary.ALERoundedCheckbox.EState.Checked;
            this.chk_emailCheck.TabIndex = 85;
            this.chk_emailCheck.Text = "aleRoundedCheckbox1";
            this.chk_emailCheck.UseVisualStyleBackColor = true;
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
            this.pgrss_rate.Location = new System.Drawing.Point(543, 335);
            this.pgrss_rate.Name = "pgrss_rate";
            this.pgrss_rate.PourcentBack = 1F;
            this.pgrss_rate.PourcentFront = 1F;
            this.pgrss_rate.PourcentValue = 0.25F;
            this.pgrss_rate.Radius = 15;
            this.pgrss_rate.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.pgrss_rate.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.pgrss_rate.Size = new System.Drawing.Size(257, 62);
            this.pgrss_rate.TabIndex = 84;
            this.pgrss_rate.Text = "25%";
            // 
            // lb_actifAccount
            // 
            this.lb_actifAccount.AutoSize = true;
            this.lb_actifAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.lb_actifAccount.Location = new System.Drawing.Point(838, 84);
            this.lb_actifAccount.Name = "lb_actifAccount";
            this.lb_actifAccount.Size = new System.Drawing.Size(71, 15);
            this.lb_actifAccount.TabIndex = 83;
            this.lb_actifAccount.Text = "Comte Actif";
            // 
            // chk_actifAccount
            // 
            this.chk_actifAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.chk_actifAccount.Checked = true;
            this.chk_actifAccount.CornerRadius = 15;
            this.chk_actifAccount.Enabled = false;
            this.chk_actifAccount.IconChecked = ALEControlLibrary.ALERoundedCheckbox.EIcon.Validate;
            this.chk_actifAccount.IconUndefined = ALEControlLibrary.ALERoundedCheckbox.EIcon.Line;
            this.chk_actifAccount.IsAnimationEnable = false;
            this.chk_actifAccount.IsAutoCheck = true;
            this.chk_actifAccount.IsCheckedFiller = true;
            this.chk_actifAccount.Location = new System.Drawing.Point(792, 72);
            this.chk_actifAccount.Name = "chk_actifAccount";
            this.chk_actifAccount.PourcentBorder = 0.01F;
            this.chk_actifAccount.PourcentIcon = 0.15F;
            this.chk_actifAccount.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.chk_actifAccount.Size = new System.Drawing.Size(40, 40);
            this.chk_actifAccount.State = ALEControlLibrary.ALERoundedCheckbox.EState.Checked;
            this.chk_actifAccount.TabIndex = 82;
            this.chk_actifAccount.Text = "aleRoundedCheckbox1";
            this.chk_actifAccount.UseVisualStyleBackColor = false;
            // 
            // lb_IBAN
            // 
            this.lb_IBAN.AutoSize = true;
            this.lb_IBAN.Location = new System.Drawing.Point(19, 685);
            this.lb_IBAN.Name = "lb_IBAN";
            this.lb_IBAN.Size = new System.Drawing.Size(34, 15);
            this.lb_IBAN.TabIndex = 81;
            this.lb_IBAN.Text = "IBAN";
            // 
            // lb_rate
            // 
            this.lb_rate.AutoSize = true;
            this.lb_rate.Location = new System.Drawing.Point(543, 321);
            this.lb_rate.Name = "lb_rate";
            this.lb_rate.Size = new System.Drawing.Size(39, 15);
            this.lb_rate.TabIndex = 80;
            this.lb_rate.Text = "Note :";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(542, 437);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(67, 15);
            this.lb_phone.TabIndex = 79;
            this.lb_phone.Text = "Téléphone :";
            // 
            // lb_eMail
            // 
            this.lb_eMail.AutoSize = true;
            this.lb_eMail.Location = new System.Drawing.Point(12, 437);
            this.lb_eMail.Name = "lb_eMail";
            this.lb_eMail.Size = new System.Drawing.Size(47, 15);
            this.lb_eMail.TabIndex = 78;
            this.lb_eMail.Text = "E-Mail :";
            // 
            // tb_phone
            // 
            this.tb_phone.BorderSize = 2;
            this.tb_phone.CornerRadius = 15;
            this.tb_phone.Location = new System.Drawing.Point(542, 456);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.PasswordChar = '\0';
            this.tb_phone.ReadOnly = false;
            this.tb_phone.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_phone.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_phone.Size = new System.Drawing.Size(350, 46);
            this.tb_phone.TabIndex = 77;
            this.tb_phone.WordWrad = true;
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // tb_mail
            // 
            this.tb_mail.BorderSize = 2;
            this.tb_mail.CornerRadius = 15;
            this.tb_mail.Location = new System.Drawing.Point(12, 455);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.PasswordChar = '\0';
            this.tb_mail.ReadOnly = false;
            this.tb_mail.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_mail.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_mail.Size = new System.Drawing.Size(315, 46);
            this.tb_mail.TabIndex = 76;
            this.tb_mail.WordWrad = true;
            this.tb_mail.TextChanged += new System.EventHandler(this.tb_mail_TextChanged);
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.tb_id.Location = new System.Drawing.Point(41, 71);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(231, 16);
            this.tb_id.TabIndex = 74;
            this.tb_id.Text = "aaaa-aaaa-aaaa-aaaa";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.lb_id.Location = new System.Drawing.Point(12, 72);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(23, 15);
            this.lb_id.TabIndex = 73;
            this.lb_id.Text = "Id :";
            // 
            // rbtn_icon
            // 
            this.rbtn_icon.BackgroundImage = global::LinkEatsApp.Properties.Resources.restoIcon;
            this.rbtn_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_icon.BorderSize = 3;
            this.rbtn_icon.BorderSizeActiv = 10;
            this.rbtn_icon.Enabled = false;
            this.rbtn_icon.IsActivate = false;
            this.rbtn_icon.IsAutoActivable = false;
            this.rbtn_icon.IsBorderVisible = true;
            this.rbtn_icon.IsClickable = true;
            this.rbtn_icon.IsDebug = false;
            this.rbtn_icon.Location = new System.Drawing.Point(12, 214);
            this.rbtn_icon.Name = "rbtn_icon";
            this.rbtn_icon.PourcentBack = 0.85F;
            this.rbtn_icon.Radius = 110;
            this.rbtn_icon.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_icon.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_icon.Size = new System.Drawing.Size(120, 120);
            this.rbtn_icon.TabIndex = 102;
            this.rbtn_icon.UseVisualStyleBackColor = true;
            // 
            // lb_restoName
            // 
            this.lb_restoName.AutoSize = true;
            this.lb_restoName.Location = new System.Drawing.Point(18, 344);
            this.lb_restoName.Name = "lb_restoName";
            this.lb_restoName.Size = new System.Drawing.Size(138, 15);
            this.lb_restoName.TabIndex = 104;
            this.lb_restoName.Text = "Nom de l\'établissement :";
            // 
            // tb_restoName
            // 
            this.tb_restoName.BorderSize = 2;
            this.tb_restoName.CornerRadius = 15;
            this.tb_restoName.Location = new System.Drawing.Point(18, 362);
            this.tb_restoName.Name = "tb_restoName";
            this.tb_restoName.PasswordChar = '\0';
            this.tb_restoName.ReadOnly = false;
            this.tb_restoName.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_restoName.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_restoName.Size = new System.Drawing.Size(350, 46);
            this.tb_restoName.TabIndex = 103;
            this.tb_restoName.WordWrad = true;
            this.tb_restoName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_siren
            // 
            this.tb_siren.BorderSize = 2;
            this.tb_siren.CornerRadius = 15;
            this.tb_siren.Location = new System.Drawing.Point(17, 786);
            this.tb_siren.Name = "tb_siren";
            this.tb_siren.PasswordChar = '\0';
            this.tb_siren.ReadOnly = false;
            this.tb_siren.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_siren.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_siren.Size = new System.Drawing.Size(878, 46);
            this.tb_siren.TabIndex = 106;
            this.tb_siren.WordWrad = true;
            this.tb_siren.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_siren
            // 
            this.lb_siren.AutoSize = true;
            this.lb_siren.Location = new System.Drawing.Point(19, 768);
            this.lb_siren.Name = "lb_siren";
            this.lb_siren.Size = new System.Drawing.Size(44, 15);
            this.lb_siren.TabIndex = 105;
            this.lb_siren.Text = "SIREN :";
            // 
            // tb_siret
            // 
            this.tb_siret.BorderSize = 2;
            this.tb_siret.CornerRadius = 15;
            this.tb_siret.Location = new System.Drawing.Point(19, 870);
            this.tb_siret.Name = "tb_siret";
            this.tb_siret.PasswordChar = '\0';
            this.tb_siret.ReadOnly = false;
            this.tb_siret.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_siret.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.tb_siret.Size = new System.Drawing.Size(878, 46);
            this.tb_siret.TabIndex = 108;
            this.tb_siret.WordWrad = true;
            this.tb_siret.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lb_siret
            // 
            this.lb_siret.AutoSize = true;
            this.lb_siret.Location = new System.Drawing.Point(21, 852);
            this.lb_siret.Name = "lb_siret";
            this.lb_siret.Size = new System.Drawing.Size(41, 15);
            this.lb_siret.TabIndex = 107;
            this.lb_siret.Text = "SIRET :";
            // 
            // FormRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 1033);
            this.Controls.Add(this.tb_siret);
            this.Controls.Add(this.lb_siret);
            this.Controls.Add(this.tb_siren);
            this.Controls.Add(this.lb_siren);
            this.Controls.Add(this.lb_restoName);
            this.Controls.Add(this.tb_restoName);
            this.Controls.Add(this.rbtn_icon);
            this.Controls.Add(this.tb_actionRange);
            this.Controls.Add(this.lb_actionRange);
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
            this.Controls.Add(this.lb_rate);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_eMail);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.pict_banner);
            this.Name = "FormRestaurant";
            this.Text = "FormRestaurant";
            this.Controls.SetChildIndex(this.pict_banner, 0);
            this.Controls.SetChildIndex(this.lb_id, 0);
            this.Controls.SetChildIndex(this.tb_id, 0);
            this.Controls.SetChildIndex(this.tb_mail, 0);
            this.Controls.SetChildIndex(this.tb_phone, 0);
            this.Controls.SetChildIndex(this.lb_eMail, 0);
            this.Controls.SetChildIndex(this.lb_phone, 0);
            this.Controls.SetChildIndex(this.lb_rate, 0);
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
            this.Controls.SetChildIndex(this.lb_actionRange, 0);
            this.Controls.SetChildIndex(this.tb_actionRange, 0);
            this.Controls.SetChildIndex(this.rbtn_icon, 0);
            this.Controls.SetChildIndex(this.tb_restoName, 0);
            this.Controls.SetChildIndex(this.lb_restoName, 0);
            this.Controls.SetChildIndex(this.lb_siren, 0);
            this.Controls.SetChildIndex(this.tb_siren, 0);
            this.Controls.SetChildIndex(this.lb_siret, 0);
            this.Controls.SetChildIndex(this.tb_siret, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pict_banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private PictureBox pict_banner;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_actionRange;
        private Label lb_actionRange;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_IBAN;
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
        private ALEControlLibrary.CTRL.ALEProgressBar pgrss_rate;
        private Label lb_actifAccount;
        private ALEControlLibrary.ALERoundedCheckbox chk_actifAccount;
        private Label lb_IBAN;
        private Label lb_rate;
        private Label lb_phone;
        private Label lb_eMail;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_phone;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_mail;
        private TextBox tb_id;
        private Label lb_id;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_icon;
        private Label lb_restoName;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_restoName;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_siren;
        private Label lb_siren;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_siret;
        private Label lb_siret;
    }
}