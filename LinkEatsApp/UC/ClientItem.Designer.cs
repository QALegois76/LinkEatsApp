namespace LinkEatsApp.UC
{
    partial class ClientItem
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
            this.rgrp_client = new AyoControlLibrary.ALERoundedGroupBox();
            this.lb_firstName = new System.Windows.Forms.Label();
            this.lb_lastName = new System.Windows.Forms.Label();
            this.aleRoundedButton1 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rgrp_client.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgrp_client
            // 
            this.rgrp_client.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.rgrp_client.BorderSize = 2;
            this.rgrp_client.CausesValidation = false;
            this.rgrp_client.Controls.Add(this.aleRoundedButton1);
            this.rgrp_client.Controls.Add(this.lb_firstName);
            this.rgrp_client.Controls.Add(this.lb_lastName);
            this.rgrp_client.CornerRadius = 10;
            this.rgrp_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgrp_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.rgrp_client.Location = new System.Drawing.Point(0, 0);
            this.rgrp_client.Name = "rgrp_client";
            this.rgrp_client.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.rgrp_client.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rgrp_client.Size = new System.Drawing.Size(394, 66);
            this.rgrp_client.TabIndex = 0;
            this.rgrp_client.TabStop = false;
            this.rgrp_client.Text = "aleRoundedGroupBox1";
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Location = new System.Drawing.Point(17, 32);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(38, 15);
            this.lb_firstName.TabIndex = 1;
            this.lb_firstName.Text = "label2";
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Location = new System.Drawing.Point(182, 32);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(38, 15);
            this.lb_lastName.TabIndex = 0;
            this.lb_lastName.Text = "label1";
            // 
            // aleRoundedButton1
            // 
            this.aleRoundedButton1.BorderSize = 2;
            this.aleRoundedButton1.BorderSizeActiv = 10;
            this.aleRoundedButton1.IsActivate = false;
            this.aleRoundedButton1.IsAutoActivable = false;
            this.aleRoundedButton1.IsClickable = true;
            this.aleRoundedButton1.IsDebug = false;
            this.aleRoundedButton1.Location = new System.Drawing.Point(333, 8);
            this.aleRoundedButton1.Name = "aleRoundedButton1";
            this.aleRoundedButton1.Radius = 15;
            this.aleRoundedButton1.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton1.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleRoundedButton1.Size = new System.Drawing.Size(62, 59);
            this.aleRoundedButton1.TabIndex = 2;
            this.aleRoundedButton1.Text = "DEL";
            this.aleRoundedButton1.UseVisualStyleBackColor = true;
            this.aleRoundedButton1.Click += new System.EventHandler(this.aleRoundedButton1_Click);
            // 
            // ClientItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.rgrp_client);
            this.Name = "ClientItem";
            this.Size = new System.Drawing.Size(394, 66);
            this.rgrp_client.ResumeLayout(false);
            this.rgrp_client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AyoControlLibrary.ALERoundedGroupBox rgrp_client;
        private Label lb_lastName;
        private Label lb_firstName;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton1;
    }
}
