namespace LinkEatsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.rbtn_settings = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_logs = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_dishes = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_orders = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_restaurnats = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_deliverymen = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_clients = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_mainMenu = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.pnl_view = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.rbtn_settings);
            this.pnl_menu.Controls.Add(this.rbtn_logs);
            this.pnl_menu.Controls.Add(this.rbtn_dishes);
            this.pnl_menu.Controls.Add(this.rbtn_orders);
            this.pnl_menu.Controls.Add(this.rbtn_restaurnats);
            this.pnl_menu.Controls.Add(this.rbtn_deliverymen);
            this.pnl_menu.Controls.Add(this.rbtn_clients);
            this.pnl_menu.Controls.Add(this.rbtn_mainMenu);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 66);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(100, 687);
            this.pnl_menu.TabIndex = 2;
            // 
            // rbtn_settings
            // 
            this.rbtn_settings.BorderSize = 1;
            this.rbtn_settings.BorderSizeActiv = 10;
            this.rbtn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtn_settings.IsActivate = false;
            this.rbtn_settings.IsAutoActivable = false;
            this.rbtn_settings.IsBorderVisible = true;
            this.rbtn_settings.IsClickable = true;
            this.rbtn_settings.IsDebug = false;
            this.rbtn_settings.Location = new System.Drawing.Point(0, 371);
            this.rbtn_settings.Name = "rbtn_settings";
            this.rbtn_settings.PourcentBack = 1F;
            this.rbtn_settings.Radius = 15;
            this.rbtn_settings.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_settings.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_settings.Size = new System.Drawing.Size(100, 53);
            this.rbtn_settings.TabIndex = 7;
            this.rbtn_settings.Text = "Paramètres";
            this.rbtn_settings.UseVisualStyleBackColor = true;
            this.rbtn_settings.Click += new System.EventHandler(this.Menu_Click);
            // 
            // rbtn_logs
            // 
            this.rbtn_logs.BorderSize = 1;
            this.rbtn_logs.BorderSizeActiv = 10;
            this.rbtn_logs.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtn_logs.IsActivate = false;
            this.rbtn_logs.IsAutoActivable = false;
            this.rbtn_logs.IsBorderVisible = true;
            this.rbtn_logs.IsClickable = true;
            this.rbtn_logs.IsDebug = false;
            this.rbtn_logs.Location = new System.Drawing.Point(0, 318);
            this.rbtn_logs.Name = "rbtn_logs";
            this.rbtn_logs.PourcentBack = 1F;
            this.rbtn_logs.Radius = 15;
            this.rbtn_logs.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_logs.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_logs.Size = new System.Drawing.Size(100, 53);
            this.rbtn_logs.TabIndex = 6;
            this.rbtn_logs.Text = "Logs";
            this.rbtn_logs.UseVisualStyleBackColor = true;
            this.rbtn_logs.Click += new System.EventHandler(this.Menu_Click);
            // 
            // rbtn_dishes
            // 
            this.rbtn_dishes.BorderSize = 1;
            this.rbtn_dishes.BorderSizeActiv = 10;
            this.rbtn_dishes.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtn_dishes.IsActivate = false;
            this.rbtn_dishes.IsAutoActivable = false;
            this.rbtn_dishes.IsBorderVisible = true;
            this.rbtn_dishes.IsClickable = true;
            this.rbtn_dishes.IsDebug = false;
            this.rbtn_dishes.Location = new System.Drawing.Point(0, 265);
            this.rbtn_dishes.Name = "rbtn_dishes";
            this.rbtn_dishes.PourcentBack = 1F;
            this.rbtn_dishes.Radius = 15;
            this.rbtn_dishes.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_dishes.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_dishes.Size = new System.Drawing.Size(100, 53);
            this.rbtn_dishes.TabIndex = 5;
            this.rbtn_dishes.Text = "Plats";
            this.rbtn_dishes.UseVisualStyleBackColor = true;
            this.rbtn_dishes.Click += new System.EventHandler(this.Menu_Click);
            // 
            // rbtn_orders
            // 
            this.rbtn_orders.BorderSize = 1;
            this.rbtn_orders.BorderSizeActiv = 10;
            this.rbtn_orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtn_orders.IsActivate = false;
            this.rbtn_orders.IsAutoActivable = false;
            this.rbtn_orders.IsBorderVisible = true;
            this.rbtn_orders.IsClickable = true;
            this.rbtn_orders.IsDebug = false;
            this.rbtn_orders.Location = new System.Drawing.Point(0, 212);
            this.rbtn_orders.Name = "rbtn_orders";
            this.rbtn_orders.PourcentBack = 1F;
            this.rbtn_orders.Radius = 15;
            this.rbtn_orders.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_orders.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_orders.Size = new System.Drawing.Size(100, 53);
            this.rbtn_orders.TabIndex = 4;
            this.rbtn_orders.Text = "Commandes";
            this.rbtn_orders.UseVisualStyleBackColor = true;
            this.rbtn_orders.Click += new System.EventHandler(this.Menu_Click);
            // 
            // rbtn_restaurnats
            // 
            this.rbtn_restaurnats.BorderSize = 1;
            this.rbtn_restaurnats.BorderSizeActiv = 10;
            this.rbtn_restaurnats.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtn_restaurnats.IsActivate = false;
            this.rbtn_restaurnats.IsAutoActivable = false;
            this.rbtn_restaurnats.IsBorderVisible = true;
            this.rbtn_restaurnats.IsClickable = true;
            this.rbtn_restaurnats.IsDebug = false;
            this.rbtn_restaurnats.Location = new System.Drawing.Point(0, 159);
            this.rbtn_restaurnats.Name = "rbtn_restaurnats";
            this.rbtn_restaurnats.PourcentBack = 1F;
            this.rbtn_restaurnats.Radius = 15;
            this.rbtn_restaurnats.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_restaurnats.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_restaurnats.Size = new System.Drawing.Size(100, 53);
            this.rbtn_restaurnats.TabIndex = 3;
            this.rbtn_restaurnats.Text = "Restaurants";
            this.rbtn_restaurnats.UseVisualStyleBackColor = true;
            this.rbtn_restaurnats.Click += new System.EventHandler(this.Menu_Click);
            // 
            // rbtn_deliverymen
            // 
            this.rbtn_deliverymen.BorderSize = 1;
            this.rbtn_deliverymen.BorderSizeActiv = 10;
            this.rbtn_deliverymen.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtn_deliverymen.IsActivate = false;
            this.rbtn_deliverymen.IsAutoActivable = false;
            this.rbtn_deliverymen.IsBorderVisible = true;
            this.rbtn_deliverymen.IsClickable = true;
            this.rbtn_deliverymen.IsDebug = false;
            this.rbtn_deliverymen.Location = new System.Drawing.Point(0, 106);
            this.rbtn_deliverymen.Name = "rbtn_deliverymen";
            this.rbtn_deliverymen.PourcentBack = 1F;
            this.rbtn_deliverymen.Radius = 15;
            this.rbtn_deliverymen.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_deliverymen.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_deliverymen.Size = new System.Drawing.Size(100, 53);
            this.rbtn_deliverymen.TabIndex = 2;
            this.rbtn_deliverymen.Text = "Livreurs";
            this.rbtn_deliverymen.UseVisualStyleBackColor = true;
            this.rbtn_deliverymen.Click += new System.EventHandler(this.Menu_Click);
            // 
            // rbtn_clients
            // 
            this.rbtn_clients.BorderSize = 1;
            this.rbtn_clients.BorderSizeActiv = 10;
            this.rbtn_clients.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtn_clients.IsActivate = false;
            this.rbtn_clients.IsAutoActivable = false;
            this.rbtn_clients.IsBorderVisible = true;
            this.rbtn_clients.IsClickable = true;
            this.rbtn_clients.IsDebug = false;
            this.rbtn_clients.Location = new System.Drawing.Point(0, 53);
            this.rbtn_clients.Name = "rbtn_clients";
            this.rbtn_clients.PourcentBack = 1F;
            this.rbtn_clients.Radius = 15;
            this.rbtn_clients.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_clients.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_clients.Size = new System.Drawing.Size(100, 53);
            this.rbtn_clients.TabIndex = 1;
            this.rbtn_clients.Text = "Clients";
            this.rbtn_clients.UseVisualStyleBackColor = true;
            this.rbtn_clients.Click += new System.EventHandler(this.Menu_Click);
            // 
            // rbtn_mainMenu
            // 
            this.rbtn_mainMenu.BorderSize = 1;
            this.rbtn_mainMenu.BorderSizeActiv = 10;
            this.rbtn_mainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtn_mainMenu.IsActivate = false;
            this.rbtn_mainMenu.IsAutoActivable = false;
            this.rbtn_mainMenu.IsBorderVisible = true;
            this.rbtn_mainMenu.IsClickable = true;
            this.rbtn_mainMenu.IsDebug = false;
            this.rbtn_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.rbtn_mainMenu.Name = "rbtn_mainMenu";
            this.rbtn_mainMenu.PourcentBack = 1F;
            this.rbtn_mainMenu.Radius = 15;
            this.rbtn_mainMenu.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_mainMenu.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_mainMenu.Size = new System.Drawing.Size(100, 53);
            this.rbtn_mainMenu.TabIndex = 0;
            this.rbtn_mainMenu.Text = "Menu Principal";
            this.rbtn_mainMenu.UseVisualStyleBackColor = true;
            this.rbtn_mainMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // pnl_view
            // 
            this.pnl_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_view.Location = new System.Drawing.Point(100, 66);
            this.pnl_view.Name = "pnl_view";
            this.pnl_view.Size = new System.Drawing.Size(1360, 687);
            this.pnl_view.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1460, 753);
            this.Controls.Add(this.pnl_view);
            this.Controls.Add(this.pnl_menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsWindowStateFixed = false;
            this.Name = "MainForm";
            this.Text = "LinkEats";
            this.Controls.SetChildIndex(this.pnl_menu, 0);
            this.Controls.SetChildIndex(this.pnl_view, 0);
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_menu;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_settings;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_logs;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_dishes;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_orders;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_restaurnats;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_deliverymen;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_clients;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_mainMenu;
        private Panel pnl_view;
    }
}