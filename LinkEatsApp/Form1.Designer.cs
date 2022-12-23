namespace LinkEatsApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtn_max = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.lb_title = new System.Windows.Forms.Label();
            this.rbtn_min = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_close = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aleRoundedButton7 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.aleRoundedButton6 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.aleRoundedButton5 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.aleRoundedButton4 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.aleRoundedButton3 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.aleRoundedButton2 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.aleRoundedButton1 = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.btn = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl11 = new LinkEatsApp.UserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rbtn_max);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Controls.Add(this.rbtn_min);
            this.panel1.Controls.Add(this.rbtn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1460, 66);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::LinkEatsApp.Properties.Resources.linkEats;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // rbtn_max
            // 
            this.rbtn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_max.BorderSize = 2;
            this.rbtn_max.BorderSizeActiv = 10;
            this.rbtn_max.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_max.ForeColor = System.Drawing.Color.Coral;
            this.rbtn_max.IsActivate = false;
            this.rbtn_max.IsAutoActivable = false;
            this.rbtn_max.IsClickable = true;
            this.rbtn_max.IsDebug = false;
            this.rbtn_max.Location = new System.Drawing.Point(1359, -2);
            this.rbtn_max.Name = "rbtn_max";
            this.rbtn_max.Radius = 15;
            this.rbtn_max.RoundedTags = ALEControlLibrary.ERoundedTag.BottomRight;
            this.rbtn_max.RoundedType = ALEControlLibrary.ERoundedType.Custom;
            this.rbtn_max.Size = new System.Drawing.Size(50, 50);
            this.rbtn_max.TabIndex = 3;
            this.rbtn_max.Text = "[ ]";
            this.rbtn_max.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtn_max.UseVisualStyleBackColor = true;
            this.rbtn_max.Click += new System.EventHandler(this.rbtn_max_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_title.Location = new System.Drawing.Point(103, 6);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(177, 54);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "LinkEats";
            this.lb_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderDown);
            this.lb_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderMove);
            this.lb_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderUp);
            // 
            // rbtn_min
            // 
            this.rbtn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_min.BorderSize = 2;
            this.rbtn_min.BorderSizeActiv = 10;
            this.rbtn_min.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_min.ForeColor = System.Drawing.Color.Coral;
            this.rbtn_min.IsActivate = false;
            this.rbtn_min.IsAutoActivable = false;
            this.rbtn_min.IsClickable = true;
            this.rbtn_min.IsDebug = false;
            this.rbtn_min.Location = new System.Drawing.Point(1311, -2);
            this.rbtn_min.Name = "rbtn_min";
            this.rbtn_min.Radius = 15;
            this.rbtn_min.RoundedTags = ALEControlLibrary.ERoundedTag.BottomLeft;
            this.rbtn_min.RoundedType = ALEControlLibrary.ERoundedType.Custom;
            this.rbtn_min.Size = new System.Drawing.Size(50, 50);
            this.rbtn_min.TabIndex = 1;
            this.rbtn_min.Text = ".";
            this.rbtn_min.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtn_min.UseVisualStyleBackColor = true;
            this.rbtn_min.Click += new System.EventHandler(this.rbtn_min_Click);
            // 
            // rbtn_close
            // 
            this.rbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_close.BorderSize = 2;
            this.rbtn_close.BorderSizeActiv = 10;
            this.rbtn_close.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_close.ForeColor = System.Drawing.Color.Coral;
            this.rbtn_close.IsActivate = false;
            this.rbtn_close.IsAutoActivable = false;
            this.rbtn_close.IsClickable = true;
            this.rbtn_close.IsDebug = false;
            this.rbtn_close.Location = new System.Drawing.Point(1407, -2);
            this.rbtn_close.Name = "rbtn_close";
            this.rbtn_close.Radius = 15;
            this.rbtn_close.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_close.RoundedType = ALEControlLibrary.ERoundedType.Bottom;
            this.rbtn_close.Size = new System.Drawing.Size(50, 50);
            this.rbtn_close.TabIndex = 0;
            this.rbtn_close.Text = "X";
            this.rbtn_close.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtn_close.UseVisualStyleBackColor = true;
            this.rbtn_close.Click += new System.EventHandler(this.rbtn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.aleRoundedButton7);
            this.panel2.Controls.Add(this.aleRoundedButton6);
            this.panel2.Controls.Add(this.aleRoundedButton5);
            this.panel2.Controls.Add(this.aleRoundedButton4);
            this.panel2.Controls.Add(this.aleRoundedButton3);
            this.panel2.Controls.Add(this.aleRoundedButton2);
            this.panel2.Controls.Add(this.aleRoundedButton1);
            this.panel2.Controls.Add(this.btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 687);
            this.panel2.TabIndex = 1;
            // 
            // aleRoundedButton7
            // 
            this.aleRoundedButton7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aleRoundedButton7.BorderSize = 0;
            this.aleRoundedButton7.BorderSizeActiv = 10;
            this.aleRoundedButton7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aleRoundedButton7.ForeColor = System.Drawing.Color.Coral;
            this.aleRoundedButton7.IsActivate = false;
            this.aleRoundedButton7.IsAutoActivable = false;
            this.aleRoundedButton7.IsClickable = true;
            this.aleRoundedButton7.IsDebug = false;
            this.aleRoundedButton7.Location = new System.Drawing.Point(0, 336);
            this.aleRoundedButton7.Name = "aleRoundedButton7";
            this.aleRoundedButton7.Radius = 15;
            this.aleRoundedButton7.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton7.RoundedType = ALEControlLibrary.ERoundedType.None;
            this.aleRoundedButton7.Size = new System.Drawing.Size(185, 48);
            this.aleRoundedButton7.TabIndex = 12;
            this.aleRoundedButton7.Text = "Setting";
            this.aleRoundedButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aleRoundedButton7.UseVisualStyleBackColor = true;
            // 
            // aleRoundedButton6
            // 
            this.aleRoundedButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aleRoundedButton6.BorderSize = 0;
            this.aleRoundedButton6.BorderSizeActiv = 10;
            this.aleRoundedButton6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aleRoundedButton6.ForeColor = System.Drawing.Color.Coral;
            this.aleRoundedButton6.IsActivate = false;
            this.aleRoundedButton6.IsAutoActivable = false;
            this.aleRoundedButton6.IsClickable = true;
            this.aleRoundedButton6.IsDebug = false;
            this.aleRoundedButton6.Location = new System.Drawing.Point(0, 288);
            this.aleRoundedButton6.Name = "aleRoundedButton6";
            this.aleRoundedButton6.Radius = 15;
            this.aleRoundedButton6.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton6.RoundedType = ALEControlLibrary.ERoundedType.None;
            this.aleRoundedButton6.Size = new System.Drawing.Size(185, 48);
            this.aleRoundedButton6.TabIndex = 11;
            this.aleRoundedButton6.Text = "Logs";
            this.aleRoundedButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aleRoundedButton6.UseVisualStyleBackColor = true;
            // 
            // aleRoundedButton5
            // 
            this.aleRoundedButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aleRoundedButton5.BorderSize = 0;
            this.aleRoundedButton5.BorderSizeActiv = 10;
            this.aleRoundedButton5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aleRoundedButton5.ForeColor = System.Drawing.Color.Coral;
            this.aleRoundedButton5.IsActivate = false;
            this.aleRoundedButton5.IsAutoActivable = false;
            this.aleRoundedButton5.IsClickable = true;
            this.aleRoundedButton5.IsDebug = false;
            this.aleRoundedButton5.Location = new System.Drawing.Point(0, 240);
            this.aleRoundedButton5.Name = "aleRoundedButton5";
            this.aleRoundedButton5.Radius = 15;
            this.aleRoundedButton5.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton5.RoundedType = ALEControlLibrary.ERoundedType.None;
            this.aleRoundedButton5.Size = new System.Drawing.Size(185, 48);
            this.aleRoundedButton5.TabIndex = 10;
            this.aleRoundedButton5.Text = "Dishs / Menus";
            this.aleRoundedButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aleRoundedButton5.UseVisualStyleBackColor = true;
            // 
            // aleRoundedButton4
            // 
            this.aleRoundedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aleRoundedButton4.BorderSize = 0;
            this.aleRoundedButton4.BorderSizeActiv = 10;
            this.aleRoundedButton4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aleRoundedButton4.ForeColor = System.Drawing.Color.Coral;
            this.aleRoundedButton4.IsActivate = false;
            this.aleRoundedButton4.IsAutoActivable = false;
            this.aleRoundedButton4.IsClickable = true;
            this.aleRoundedButton4.IsDebug = false;
            this.aleRoundedButton4.Location = new System.Drawing.Point(0, 192);
            this.aleRoundedButton4.Name = "aleRoundedButton4";
            this.aleRoundedButton4.Radius = 15;
            this.aleRoundedButton4.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton4.RoundedType = ALEControlLibrary.ERoundedType.None;
            this.aleRoundedButton4.Size = new System.Drawing.Size(185, 48);
            this.aleRoundedButton4.TabIndex = 9;
            this.aleRoundedButton4.Text = "Orders";
            this.aleRoundedButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aleRoundedButton4.UseVisualStyleBackColor = true;
            // 
            // aleRoundedButton3
            // 
            this.aleRoundedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aleRoundedButton3.BorderSize = 0;
            this.aleRoundedButton3.BorderSizeActiv = 10;
            this.aleRoundedButton3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aleRoundedButton3.ForeColor = System.Drawing.Color.Coral;
            this.aleRoundedButton3.IsActivate = false;
            this.aleRoundedButton3.IsAutoActivable = false;
            this.aleRoundedButton3.IsClickable = true;
            this.aleRoundedButton3.IsDebug = false;
            this.aleRoundedButton3.Location = new System.Drawing.Point(0, 144);
            this.aleRoundedButton3.Name = "aleRoundedButton3";
            this.aleRoundedButton3.Radius = 15;
            this.aleRoundedButton3.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton3.RoundedType = ALEControlLibrary.ERoundedType.None;
            this.aleRoundedButton3.Size = new System.Drawing.Size(185, 48);
            this.aleRoundedButton3.TabIndex = 8;
            this.aleRoundedButton3.Text = "Restaurants";
            this.aleRoundedButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aleRoundedButton3.UseVisualStyleBackColor = true;
            // 
            // aleRoundedButton2
            // 
            this.aleRoundedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aleRoundedButton2.BorderSize = 0;
            this.aleRoundedButton2.BorderSizeActiv = 10;
            this.aleRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aleRoundedButton2.ForeColor = System.Drawing.Color.Coral;
            this.aleRoundedButton2.IsActivate = false;
            this.aleRoundedButton2.IsAutoActivable = false;
            this.aleRoundedButton2.IsClickable = true;
            this.aleRoundedButton2.IsDebug = false;
            this.aleRoundedButton2.Location = new System.Drawing.Point(0, 96);
            this.aleRoundedButton2.Name = "aleRoundedButton2";
            this.aleRoundedButton2.Radius = 15;
            this.aleRoundedButton2.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton2.RoundedType = ALEControlLibrary.ERoundedType.None;
            this.aleRoundedButton2.Size = new System.Drawing.Size(185, 48);
            this.aleRoundedButton2.TabIndex = 7;
            this.aleRoundedButton2.Text = "Deliverymen";
            this.aleRoundedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aleRoundedButton2.UseVisualStyleBackColor = true;
            // 
            // aleRoundedButton1
            // 
            this.aleRoundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aleRoundedButton1.BorderSize = 0;
            this.aleRoundedButton1.BorderSizeActiv = 10;
            this.aleRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aleRoundedButton1.ForeColor = System.Drawing.Color.Coral;
            this.aleRoundedButton1.IsActivate = false;
            this.aleRoundedButton1.IsAutoActivable = false;
            this.aleRoundedButton1.IsClickable = true;
            this.aleRoundedButton1.IsDebug = false;
            this.aleRoundedButton1.Location = new System.Drawing.Point(0, 48);
            this.aleRoundedButton1.Name = "aleRoundedButton1";
            this.aleRoundedButton1.Radius = 15;
            this.aleRoundedButton1.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleRoundedButton1.RoundedType = ALEControlLibrary.ERoundedType.None;
            this.aleRoundedButton1.Size = new System.Drawing.Size(185, 48);
            this.aleRoundedButton1.TabIndex = 6;
            this.aleRoundedButton1.Text = "Clients";
            this.aleRoundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aleRoundedButton1.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.BorderSize = 0;
            this.btn.BorderSizeActiv = 10;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn.ForeColor = System.Drawing.Color.Coral;
            this.btn.IsActivate = false;
            this.btn.IsAutoActivable = false;
            this.btn.IsClickable = true;
            this.btn.IsDebug = false;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Radius = 15;
            this.btn.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.btn.RoundedType = ALEControlLibrary.ERoundedType.None;
            this.btn.Size = new System.Drawing.Size(185, 48);
            this.btn.TabIndex = 5;
            this.btn.Text = "Main Menu";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.userControl11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(185, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1275, 687);
            this.panel3.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.userControl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.userControl11.Location = new System.Drawing.Point(26, 17);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1188, 640);
            this.userControl11.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(71)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1460, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "LinkEats";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_close;
        private Label lb_title;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_min;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_max;
        private PictureBox pictureBox1;
        private ALEControlLibrary.CTRL.ALERoundedButton btn;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton7;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton6;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton5;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton4;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton3;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton2;
        private ALEControlLibrary.CTRL.ALERoundedButton aleRoundedButton1;
        private UserControl1 userControl11;
    }
}