namespace LinkEatsApp.UC
{
    partial class DefaultListControl
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
            this.tb_search = new ALEControlLibrary.CTRL.ALERoundedTextbox();
            this.rbtn_search = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.grp_filter = new AyoControlLibrary.ALERoundedGroupBox();
            this.btn_filter_title = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_delete = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.rbtn_add = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.btn_filter_state = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.scrlBV = new ALEControlLibrary.ALEScrollBar();
            this.cmb_search = new ALEControlLibrary.ALEComboBox();
            this.pnl_gridView = new ALEControlLibrary.ALERoundedPanel();
            this.gridView = new ALEControlLibrary.CTRL.ALEGridView();
            this.rbtn_refresh = new ALEControlLibrary.CTRL.ALERoundedButton();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.BorderSize = 2;
            this.tb_search.CornerRadius = 15;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_search.Location = new System.Drawing.Point(255, 13);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.ReadOnly = false;
            this.tb_search.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.tb_search.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.tb_search.Size = new System.Drawing.Size(588, 46);
            this.tb_search.TabIndex = 0;
            this.tb_search.WordWrad = true;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // rbtn_search
            // 
            this.rbtn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_search.BackgroundImage = global::LinkEatsApp.Properties.Resources.Loupe_tresclair;
            this.rbtn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_search.BorderSize = 2;
            this.rbtn_search.BorderSizeActiv = 10;
            this.rbtn_search.IsActivate = false;
            this.rbtn_search.IsAutoActivable = false;
            this.rbtn_search.IsBorderVisible = true;
            this.rbtn_search.IsClickable = true;
            this.rbtn_search.IsDebug = false;
            this.rbtn_search.Location = new System.Drawing.Point(840, 14);
            this.rbtn_search.Name = "rbtn_search";
            this.rbtn_search.PourcentBack = 0.7F;
            this.rbtn_search.Radius = 15;
            this.rbtn_search.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_search.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_search.Size = new System.Drawing.Size(59, 44);
            this.rbtn_search.TabIndex = 1;
            this.rbtn_search.UseVisualStyleBackColor = true;
            // 
            // grp_filter
            // 
            this.grp_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grp_filter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.grp_filter.BorderSize = 2;
            this.grp_filter.CornerRadius = 15;
            this.grp_filter.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_filter.Location = new System.Drawing.Point(12, 118);
            this.grp_filter.Name = "grp_filter";
            this.grp_filter.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.grp_filter.RoundedType = ALEControlLibrary.ERoundedType.Bottom;
            this.grp_filter.Size = new System.Drawing.Size(237, 740);
            this.grp_filter.TabIndex = 2;
            this.grp_filter.TabStop = false;
            // 
            // btn_filter_title
            // 
            this.btn_filter_title.BorderSize = 2;
            this.btn_filter_title.BorderSizeActiv = 10;
            this.btn_filter_title.Enabled = false;
            this.btn_filter_title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_filter_title.IsActivate = false;
            this.btn_filter_title.IsAutoActivable = false;
            this.btn_filter_title.IsBorderVisible = true;
            this.btn_filter_title.IsClickable = false;
            this.btn_filter_title.IsDebug = false;
            this.btn_filter_title.Location = new System.Drawing.Point(11, 75);
            this.btn_filter_title.Name = "btn_filter_title";
            this.btn_filter_title.PourcentBack = 1F;
            this.btn_filter_title.Radius = 15;
            this.btn_filter_title.RoundedTags = ALEControlLibrary.ERoundedTag.TopLeft;
            this.btn_filter_title.RoundedType = ALEControlLibrary.ERoundedType.Custom;
            this.btn_filter_title.Size = new System.Drawing.Size(186, 46);
            this.btn_filter_title.TabIndex = 3;
            this.btn_filter_title.Text = "Filtres";
            this.btn_filter_title.UseVisualStyleBackColor = true;
            // 
            // rbtn_delete
            // 
            this.rbtn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_delete.BackgroundImage = global::LinkEatsApp.Properties.Resources.Delete;
            this.rbtn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_delete.BorderSize = 2;
            this.rbtn_delete.BorderSizeActiv = 10;
            this.rbtn_delete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rbtn_delete.IsActivate = false;
            this.rbtn_delete.IsAutoActivable = false;
            this.rbtn_delete.IsBorderVisible = true;
            this.rbtn_delete.IsClickable = true;
            this.rbtn_delete.IsDebug = false;
            this.rbtn_delete.Location = new System.Drawing.Point(971, 13);
            this.rbtn_delete.Name = "rbtn_delete";
            this.rbtn_delete.PourcentBack = 0.7F;
            this.rbtn_delete.Radius = 15;
            this.rbtn_delete.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_delete.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.rbtn_delete.Size = new System.Drawing.Size(75, 46);
            this.rbtn_delete.TabIndex = 4;
            this.rbtn_delete.UseVisualStyleBackColor = true;
            this.rbtn_delete.Click += new System.EventHandler(this.rbtn_delete_Click_1);
            // 
            // rbtn_add
            // 
            this.rbtn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_add.BackgroundImage = global::LinkEatsApp.Properties.Resources.ADD;
            this.rbtn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_add.BorderSize = 2;
            this.rbtn_add.BorderSizeActiv = 10;
            this.rbtn_add.IsActivate = false;
            this.rbtn_add.IsAutoActivable = false;
            this.rbtn_add.IsBorderVisible = true;
            this.rbtn_add.IsClickable = true;
            this.rbtn_add.IsDebug = false;
            this.rbtn_add.Location = new System.Drawing.Point(1044, 13);
            this.rbtn_add.Name = "rbtn_add";
            this.rbtn_add.PourcentBack = 0.7F;
            this.rbtn_add.Radius = 15;
            this.rbtn_add.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_add.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.rbtn_add.Size = new System.Drawing.Size(75, 46);
            this.rbtn_add.TabIndex = 5;
            this.rbtn_add.UseVisualStyleBackColor = true;
            this.rbtn_add.Click += new System.EventHandler(this.rbtn_add_Click);
            // 
            // btn_filter_state
            // 
            this.btn_filter_state.BackgroundImage = global::LinkEatsApp.Properties.Resources.Filtre_tresclair;
            this.btn_filter_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_filter_state.BorderSize = 2;
            this.btn_filter_state.BorderSizeActiv = 10;
            this.btn_filter_state.IsActivate = false;
            this.btn_filter_state.IsAutoActivable = false;
            this.btn_filter_state.IsBorderVisible = true;
            this.btn_filter_state.IsClickable = true;
            this.btn_filter_state.IsDebug = false;
            this.btn_filter_state.Location = new System.Drawing.Point(194, 75);
            this.btn_filter_state.Name = "btn_filter_state";
            this.btn_filter_state.PourcentBack = 0.7F;
            this.btn_filter_state.Radius = 15;
            this.btn_filter_state.RoundedTags = ALEControlLibrary.ERoundedTag.TopRight;
            this.btn_filter_state.RoundedType = ALEControlLibrary.ERoundedType.Custom;
            this.btn_filter_state.Size = new System.Drawing.Size(55, 46);
            this.btn_filter_state.TabIndex = 6;
            this.btn_filter_state.UseVisualStyleBackColor = true;
            this.btn_filter_state.Click += new System.EventHandler(this.btn_filter_state_Click);
            // 
            // scrlBV
            // 
            this.scrlBV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrlBV.BorderSize = 1;
            this.scrlBV.CornerRadius = 15;
            this.scrlBV.GapBorderGrip = 2;
            this.scrlBV.GripSize = 35;
            this.scrlBV.IsAllowClickGoTo = false;
            this.scrlBV.Location = new System.Drawing.Point(1093, 75);
            this.scrlBV.Maximum = 100;
            this.scrlBV.Minimum = 0;
            this.scrlBV.Mode = ALEControlLibrary.ALEScrollBar.EMode.Vertical;
            this.scrlBV.Name = "scrlBV";
            this.scrlBV.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.scrlBV.RoundedType = ALEControlLibrary.ERoundedType.Right;
            this.scrlBV.Size = new System.Drawing.Size(26, 782);
            this.scrlBV.TabIndex = 8;
            this.scrlBV.Value = 0;
            this.scrlBV.ValueChanged += new System.EventHandler(this.scrlBV_ValueChanged);
            // 
            // cmb_search
            // 
            this.cmb_search.BorderSize = 2;
            this.cmb_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_search.IsBorderVisible = true;
            this.cmb_search.IsDebug = false;
            this.cmb_search.Location = new System.Drawing.Point(11, 14);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Radius = 15;
            this.cmb_search.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.cmb_search.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.cmb_search.SelectedIndex = -1;
            this.cmb_search.Size = new System.Drawing.Size(237, 44);
            this.cmb_search.TabIndex = 9;
            this.cmb_search.AutoSizeChanged += new System.EventHandler(this.cmb_search_SelctedIndexChanged);
            // 
            // pnl_gridView
            // 
            this.pnl_gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_gridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.pnl_gridView.BorderWidth = 2;
            this.pnl_gridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(148)))));
            this.pnl_gridView.IsActivate = false;
            this.pnl_gridView.IsAutoActivable = false;
            this.pnl_gridView.IsClickable = true;
            this.pnl_gridView.IsColorizeOverPicture = false;
            this.pnl_gridView.IsContainer = true;
            this.pnl_gridView.Location = new System.Drawing.Point(256, 74);
            this.pnl_gridView.MultiplierAccentuationBorder = 1F;
            this.pnl_gridView.Name = "pnl_gridView";
            this.pnl_gridView.PourcentAlphaDisable = 0.25F;
            this.pnl_gridView.PourcentZoomBack = 1F;
            this.pnl_gridView.Radius = 15;
            this.pnl_gridView.RoundedTag = null;
            this.pnl_gridView.RoundedType = ALEControlLibrary.ERoundedType.Left;
            this.pnl_gridView.Size = new System.Drawing.Size(840, 784);
            this.pnl_gridView.TabIndex = 10;
            // 
            // gridView
            // 
            this.gridView.CornerRadius = 15;
            this.gridView.GapXRow = 10;
            this.gridView.GapYRow = 5;
            this.gridView.GridLineSize = 1;
            this.gridView.IsDebug = false;
            this.gridView.Location = new System.Drawing.Point(337, 127);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(733, 567);
            this.gridView.TabIndex = 11;
            // 
            // rbtn_refresh
            // 
            this.rbtn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_refresh.BackgroundImage = global::LinkEatsApp.Properties.Resources.reset;
            this.rbtn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtn_refresh.BorderSize = 2;
            this.rbtn_refresh.BorderSizeActiv = 10;
            this.rbtn_refresh.IsActivate = false;
            this.rbtn_refresh.IsAutoActivable = false;
            this.rbtn_refresh.IsBorderVisible = true;
            this.rbtn_refresh.IsClickable = true;
            this.rbtn_refresh.IsDebug = false;
            this.rbtn_refresh.Location = new System.Drawing.Point(906, 15);
            this.rbtn_refresh.Name = "rbtn_refresh";
            this.rbtn_refresh.PourcentBack = 0.7F;
            this.rbtn_refresh.Radius = 15;
            this.rbtn_refresh.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.rbtn_refresh.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.rbtn_refresh.Size = new System.Drawing.Size(59, 44);
            this.rbtn_refresh.TabIndex = 12;
            this.rbtn_refresh.UseVisualStyleBackColor = true;
            this.rbtn_refresh.Click += new System.EventHandler(this.rbtn_refresh_Click);
            // 
            // DefaultListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.rbtn_refresh);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.pnl_gridView);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.scrlBV);
            this.Controls.Add(this.btn_filter_state);
            this.Controls.Add(this.rbtn_add);
            this.Controls.Add(this.rbtn_delete);
            this.Controls.Add(this.btn_filter_title);
            this.Controls.Add(this.grp_filter);
            this.Controls.Add(this.rbtn_search);
            this.Controls.Add(this.tb_search);
            this.Name = "DefaultListControl";
            this.Size = new System.Drawing.Size(1142, 875);
            this.ResumeLayout(false);

        }

        #endregion

        private ALEControlLibrary.CTRL.ALERoundedTextbox tb_search;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_search;
        private AyoControlLibrary.ALERoundedGroupBox grp_filter;
        private ALEControlLibrary.CTRL.ALERoundedButton btn_filter_title;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_delete;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_add;
        private ALEControlLibrary.CTRL.ALERoundedButton btn_filter_state;
        private ALEControlLibrary.ALEScrollBar scrlBV;
        private ALEControlLibrary.ALEComboBox cmb_search;
        private ALEControlLibrary.ALERoundedPanel pnl_gridView;
        private ALEControlLibrary.CTRL.ALEGridView gridView;
        private ALEControlLibrary.CTRL.ALERoundedButton rbtn_refresh;
    }
}
