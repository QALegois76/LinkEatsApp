namespace LinkEatsApp
{
    partial class DefaultForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtn_close = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.lb_title = new System.Windows.Forms.Label();
            this.rbtn_max = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_min = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rbtn_close);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Controls.Add(this.rbtn_max);
            this.panel1.Controls.Add(this.rbtn_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 66);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HeaderDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::LinkEatsApp.Properties.Resources.linkEats1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HeaderDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderUp);
            // 
            // rbtn_close
            // 
            this.rbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_close.BackgroundImage = global::LinkEatsApp.Properties.Resources.close;
            this.rbtn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_close.BorderSize = 2;
            this.rbtn_close.BorderSizeActiv = 10;
            this.rbtn_close.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_close.ForeColor = System.Drawing.Color.Coral;
            this.rbtn_close.IsActivate = false;
            this.rbtn_close.IsAutoActivable = false;
            this.rbtn_close.IsClickable = true;
            this.rbtn_close.IsDebug = false;
            this.rbtn_close.Location = new System.Drawing.Point(1338, 0);
            this.rbtn_close.Name = "rbtn_close";
            this.rbtn_close.PourcentBack = 0.5F;
            this.rbtn_close.Radius = 15;
            this.rbtn_close.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_close.RoundedType = ALEControlLibrary.ERoundedType.Bottom;
            this.rbtn_close.Size = new System.Drawing.Size(50, 50);
            this.rbtn_close.TabIndex = 0;
            this.rbtn_close.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtn_close.UseVisualStyleBackColor = true;
            this.rbtn_close.Click += new System.EventHandler(this.rbtn_close_Click);
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
            this.lb_title.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HeaderDoubleClick);
            this.lb_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderDown);
            this.lb_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderMove);
            this.lb_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderUp);
            // 
            // rbtn_max
            // 
            this.rbtn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_max.BackgroundImage = global::LinkEatsApp.Properties.Resources.max;
            this.rbtn_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_max.BorderSize = 2;
            this.rbtn_max.BorderSizeActiv = 10;
            this.rbtn_max.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_max.ForeColor = System.Drawing.Color.Coral;
            this.rbtn_max.IsActivate = false;
            this.rbtn_max.IsAutoActivable = false;
            this.rbtn_max.IsClickable = true;
            this.rbtn_max.IsDebug = false;
            this.rbtn_max.Location = new System.Drawing.Point(1287, 0);
            this.rbtn_max.Name = "rbtn_max";
            this.rbtn_max.PourcentBack = 0.5F;
            this.rbtn_max.Radius = 15;
            this.rbtn_max.RoundedTags = ALEControlLibrary.ERoundedTag.BottomRight;
            this.rbtn_max.RoundedType = ALEControlLibrary.ERoundedType.Custom;
            this.rbtn_max.Size = new System.Drawing.Size(50, 50);
            this.rbtn_max.TabIndex = 3;
            this.rbtn_max.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtn_max.UseVisualStyleBackColor = true;
            this.rbtn_max.Click += new System.EventHandler(this.rbtn_max_Click);
            // 
            // rbtn_min
            // 
            this.rbtn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_min.BackgroundImage = global::LinkEatsApp.Properties.Resources.Minimiser_fenetre_tresclair;
            this.rbtn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_min.BorderSize = 2;
            this.rbtn_min.BorderSizeActiv = 2;
            this.rbtn_min.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_min.ForeColor = System.Drawing.Color.Coral;
            this.rbtn_min.IsActivate = false;
            this.rbtn_min.IsAutoActivable = false;
            this.rbtn_min.IsClickable = true;
            this.rbtn_min.IsDebug = false;
            this.rbtn_min.Location = new System.Drawing.Point(1240, 0);
            this.rbtn_min.Name = "rbtn_min";
            this.rbtn_min.PourcentBack = 0.5F;
            this.rbtn_min.Radius = 15;
            this.rbtn_min.RoundedTags = ALEControlLibrary.ERoundedTag.BottomLeft;
            this.rbtn_min.RoundedType = ALEControlLibrary.ERoundedType.Custom;
            this.rbtn_min.Size = new System.Drawing.Size(50, 50);
            this.rbtn_min.TabIndex = 1;
            this.rbtn_min.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtn_min.UseVisualStyleBackColor = true;
            this.rbtn_min.Click += new System.EventHandler(this.rbtn_min_Click);
            // 
            // DefaultForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1391, 825);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DefaultForm";
            this.Text = "UserCreator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_max;
        private Label lb_title;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_min;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_close;
    }
}