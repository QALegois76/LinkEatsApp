namespace LinkEatsApp
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rgrp = new AyoControlLibrary.ALERoundedGroupBox();
            this.clientItem1 = new LinkEatsApp.UC.ClientItem();
            this.aleScrollBar1 = new ALEControlLibrary.ALEScrollBar();
            this.aleRoundedButton1 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.aleRoundedButton2 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.aleRoundedButton3 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.tb_firstName_tile = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_lastName_title = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_lastName = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_firstName = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_pwd = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_login = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_pwd_title = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_login_title = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_mail = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.tb_mail_title = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.rgrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgrp
            // 
            this.rgrp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.rgrp.BorderSize = 2;
            this.rgrp.Controls.Add(this.clientItem1);
            this.rgrp.CornerRadius = 10;
            this.rgrp.Location = new System.Drawing.Point(3, 3);
            this.rgrp.Name = "rgrp";
            this.rgrp.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.rgrp.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.rgrp.Size = new System.Drawing.Size(411, 634);
            this.rgrp.TabIndex = 0;
            this.rgrp.TabStop = false;
            this.rgrp.Text = "Group 1";
            // 
            // clientItem1
            // 
            this.clientItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.clientItem1.FirstName = "aleRoundedGroupBox1";
            this.clientItem1.ID = "aleRoundedGroupBox1";
            this.clientItem1.LastName = "aleRoundedGroupBox1";
            this.clientItem1.Location = new System.Drawing.Point(6, 189);
            this.clientItem1.Name = "clientItem1";
            this.clientItem1.Size = new System.Drawing.Size(394, 66);
            this.clientItem1.TabIndex = 0;
            // 
            // aleScrollBar1
            // 
            this.aleScrollBar1.BorderSize = 1;
            this.aleScrollBar1.CornerRadius = 15;
            this.aleScrollBar1.GapBorderGrip = 2;
            this.aleScrollBar1.GripSize = 35;
            this.aleScrollBar1.IsAllowClickGoTo = false;
            this.aleScrollBar1.Location = new System.Drawing.Point(413, 11);
            this.aleScrollBar1.Maximum = 100;
            this.aleScrollBar1.Minimum = 0;
            this.aleScrollBar1.Mode = ALEControlLibrary.ALEScrollBar.EMode.Vertical;
            this.aleScrollBar1.Name = "aleScrollBar1";
            this.aleScrollBar1.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.aleScrollBar1.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.aleScrollBar1.Size = new System.Drawing.Size(23, 626);
            this.aleScrollBar1.TabIndex = 10;
            this.aleScrollBar1.Value = 0;
            this.aleScrollBar1.ValueChanged += new System.EventHandler(this.aleScrollBar1_ValueChanged);
            // 
            // aleRoundedButton1
            // 
            this.aleRoundedButton1.BorderSize = 2;
            this.aleRoundedButton1.BorderSizeActiv = 10;
            this.aleRoundedButton1.IsActivate = false;
            this.aleRoundedButton1.IsAutoActivable = false;
            this.aleRoundedButton1.IsClickable = true;
            this.aleRoundedButton1.IsDebug = false;
            this.aleRoundedButton1.Location = new System.Drawing.Point(695, 11);
            this.aleRoundedButton1.Name = "aleRoundedButton1";
            this.aleRoundedButton1.Radius = 15;
            this.aleRoundedButton1.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton1.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleRoundedButton1.Size = new System.Drawing.Size(165, 58);
            this.aleRoundedButton1.TabIndex = 11;
            this.aleRoundedButton1.Text = "Connect";
            this.aleRoundedButton1.UseVisualStyleBackColor = true;
            this.aleRoundedButton1.Click += new System.EventHandler(this.aleRoundedButton1_Click);
            // 
            // aleRoundedButton2
            // 
            this.aleRoundedButton2.BorderSize = 2;
            this.aleRoundedButton2.BorderSizeActiv = 10;
            this.aleRoundedButton2.IsActivate = false;
            this.aleRoundedButton2.IsAutoActivable = false;
            this.aleRoundedButton2.IsClickable = true;
            this.aleRoundedButton2.IsDebug = false;
            this.aleRoundedButton2.Location = new System.Drawing.Point(695, 433);
            this.aleRoundedButton2.Name = "aleRoundedButton2";
            this.aleRoundedButton2.Radius = 15;
            this.aleRoundedButton2.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton2.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleRoundedButton2.Size = new System.Drawing.Size(165, 58);
            this.aleRoundedButton2.TabIndex = 12;
            this.aleRoundedButton2.Text = "Add";
            this.aleRoundedButton2.UseVisualStyleBackColor = true;
            this.aleRoundedButton2.Click += new System.EventHandler(this.aleRoundedButton2_Click);
            // 
            // aleRoundedButton3
            // 
            this.aleRoundedButton3.BorderSize = 2;
            this.aleRoundedButton3.BorderSizeActiv = 10;
            this.aleRoundedButton3.IsActivate = false;
            this.aleRoundedButton3.IsAutoActivable = false;
            this.aleRoundedButton3.IsClickable = true;
            this.aleRoundedButton3.IsDebug = false;
            this.aleRoundedButton3.Location = new System.Drawing.Point(695, 564);
            this.aleRoundedButton3.Name = "aleRoundedButton3";
            this.aleRoundedButton3.Radius = 15;
            this.aleRoundedButton3.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton3.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleRoundedButton3.Size = new System.Drawing.Size(165, 58);
            this.aleRoundedButton3.TabIndex = 13;
            this.aleRoundedButton3.Text = "Save";
            this.aleRoundedButton3.UseVisualStyleBackColor = true;
            // 
            // tb_firstName_tile
            // 
            this.tb_firstName_tile.BorderSize = 2;
            this.tb_firstName_tile.CornerRadius = 15;
            this.tb_firstName_tile.Location = new System.Drawing.Point(546, 95);
            this.tb_firstName_tile.Name = "tb_firstName_tile";
            this.tb_firstName_tile.PasswordChar = '\0';
            this.tb_firstName_tile.ReadOnly = true;
            this.tb_firstName_tile.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_firstName_tile.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_firstName_tile.Size = new System.Drawing.Size(218, 46);
            this.tb_firstName_tile.TabIndex = 14;
            this.tb_firstName_tile.Text = "First Name";
            this.tb_firstName_tile.WordWrad = true;
            // 
            // tb_lastName_title
            // 
            this.tb_lastName_title.BorderSize = 2;
            this.tb_lastName_title.CornerRadius = 15;
            this.tb_lastName_title.Location = new System.Drawing.Point(546, 163);
            this.tb_lastName_title.Name = "tb_lastName_title";
            this.tb_lastName_title.PasswordChar = '\0';
            this.tb_lastName_title.ReadOnly = true;
            this.tb_lastName_title.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_lastName_title.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_lastName_title.Size = new System.Drawing.Size(218, 46);
            this.tb_lastName_title.TabIndex = 15;
            this.tb_lastName_title.Text = "Last Name";
            this.tb_lastName_title.WordWrad = true;
            // 
            // tb_lastName
            // 
            this.tb_lastName.BorderSize = 2;
            this.tb_lastName.CornerRadius = 15;
            this.tb_lastName.Location = new System.Drawing.Point(760, 163);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.PasswordChar = '\0';
            this.tb_lastName.ReadOnly = false;
            this.tb_lastName.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_lastName.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.tb_lastName.Size = new System.Drawing.Size(218, 46);
            this.tb_lastName.TabIndex = 17;
            this.tb_lastName.WordWrad = true;
            // 
            // tb_firstName
            // 
            this.tb_firstName.BorderSize = 2;
            this.tb_firstName.CornerRadius = 15;
            this.tb_firstName.Location = new System.Drawing.Point(760, 95);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.PasswordChar = '\0';
            this.tb_firstName.ReadOnly = false;
            this.tb_firstName.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_firstName.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.tb_firstName.Size = new System.Drawing.Size(218, 46);
            this.tb_firstName.TabIndex = 16;
            this.tb_firstName.WordWrad = true;
            // 
            // tb_pwd
            // 
            this.tb_pwd.BorderSize = 2;
            this.tb_pwd.CornerRadius = 15;
            this.tb_pwd.Location = new System.Drawing.Point(760, 294);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '\0';
            this.tb_pwd.ReadOnly = false;
            this.tb_pwd.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_pwd.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.tb_pwd.Size = new System.Drawing.Size(218, 46);
            this.tb_pwd.TabIndex = 21;
            this.tb_pwd.WordWrad = true;
            // 
            // tb_login
            // 
            this.tb_login.BorderSize = 2;
            this.tb_login.CornerRadius = 15;
            this.tb_login.Location = new System.Drawing.Point(760, 226);
            this.tb_login.Name = "tb_login";
            this.tb_login.PasswordChar = '\0';
            this.tb_login.ReadOnly = false;
            this.tb_login.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_login.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.tb_login.Size = new System.Drawing.Size(218, 46);
            this.tb_login.TabIndex = 20;
            this.tb_login.WordWrad = true;
            // 
            // tb_pwd_title
            // 
            this.tb_pwd_title.BorderSize = 2;
            this.tb_pwd_title.CornerRadius = 15;
            this.tb_pwd_title.Location = new System.Drawing.Point(546, 294);
            this.tb_pwd_title.Name = "tb_pwd_title";
            this.tb_pwd_title.PasswordChar = '\0';
            this.tb_pwd_title.ReadOnly = true;
            this.tb_pwd_title.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_pwd_title.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_pwd_title.Size = new System.Drawing.Size(218, 46);
            this.tb_pwd_title.TabIndex = 19;
            this.tb_pwd_title.Text = "Password";
            this.tb_pwd_title.WordWrad = true;
            // 
            // tb_login_title
            // 
            this.tb_login_title.BorderSize = 2;
            this.tb_login_title.CornerRadius = 15;
            this.tb_login_title.Location = new System.Drawing.Point(546, 226);
            this.tb_login_title.Name = "tb_login_title";
            this.tb_login_title.PasswordChar = '\0';
            this.tb_login_title.ReadOnly = true;
            this.tb_login_title.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_login_title.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_login_title.Size = new System.Drawing.Size(218, 46);
            this.tb_login_title.TabIndex = 18;
            this.tb_login_title.Text = "Login";
            this.tb_login_title.WordWrad = true;
            // 
            // tb_mail
            // 
            this.tb_mail.BorderSize = 2;
            this.tb_mail.CornerRadius = 15;
            this.tb_mail.Location = new System.Drawing.Point(760, 358);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.PasswordChar = '\0';
            this.tb_mail.ReadOnly = false;
            this.tb_mail.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_mail.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.tb_mail.Size = new System.Drawing.Size(218, 46);
            this.tb_mail.TabIndex = 24;
            this.tb_mail.WordWrad = true;
            // 
            // tb_mail_title
            // 
            this.tb_mail_title.BorderSize = 2;
            this.tb_mail_title.CornerRadius = 15;
            this.tb_mail_title.Location = new System.Drawing.Point(546, 358);
            this.tb_mail_title.Name = "tb_mail_title";
            this.tb_mail_title.PasswordChar = '\0';
            this.tb_mail_title.ReadOnly = true;
            this.tb_mail_title.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_mail_title.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_mail_title.Size = new System.Drawing.Size(218, 46);
            this.tb_mail_title.TabIndex = 22;
            this.tb_mail_title.Text = "E-Mail";
            this.tb_mail_title.WordWrad = true;
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_mail_title);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_pwd_title);
            this.Controls.Add(this.tb_login_title);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.tb_lastName_title);
            this.Controls.Add(this.tb_firstName_tile);
            this.Controls.Add(this.aleRoundedButton3);
            this.Controls.Add(this.aleRoundedButton2);
            this.Controls.Add(this.aleRoundedButton1);
            this.Controls.Add(this.aleScrollBar1);
            this.Controls.Add(this.rgrp);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1188, 640);
            this.rgrp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AyoControlLibrary.ALERoundedGroupBox rgrp;
        private ALEControlLibrary.ALEScrollBar aleScrollBar1;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton1;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton2;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton3;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_firstName_tile;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_lastName_title;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_lastName;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_firstName;
        private UC.ClientItem clientItem1;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_pwd;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_login;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_pwd_title;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_login_title;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_mail;
        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_mail_title;
    }
}
