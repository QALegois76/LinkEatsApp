namespace LinkEatsApp.UC
{
    partial class FormTest
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
            this.aleScrollBarV = new ALEControlLibrary.ALEScrollBar();
            this.aleScrollBarH = new ALEControlLibrary.ALEScrollBar();
            this.aleProgressH = new ALEControlLibrary.CTRL.ALEProgressBar();
            this.aleProgressV = new ALEControlLibrary.CTRL.ALEProgressBar();
            this.aleProgressH2 = new ALEControlLibrary.CTRL.ALEProgressBar();
            this.SuspendLayout();
            // 
            // aleScrollBarV
            // 
            this.aleScrollBarV.BorderSize = 2;
            this.aleScrollBarV.CornerRadius = 15;
            this.aleScrollBarV.Dock = System.Windows.Forms.DockStyle.Left;
            this.aleScrollBarV.GapBorderGrip = 2;
            this.aleScrollBarV.GripSize = 35;
            this.aleScrollBarV.IsAllowClickGoTo = false;
            this.aleScrollBarV.Location = new System.Drawing.Point(0, 0);
            this.aleScrollBarV.Maximum = 100;
            this.aleScrollBarV.Minimum = 0;
            this.aleScrollBarV.Mode = ALEControlLibrary.ALEScrollBar.EMode.Vertical;
            this.aleScrollBarV.Name = "aleScrollBarV";
            this.aleScrollBarV.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.aleScrollBarV.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleScrollBarV.Size = new System.Drawing.Size(40, 693);
            this.aleScrollBarV.TabIndex = 0;
            this.aleScrollBarV.Value = 0;
            this.aleScrollBarV.ValueChanged += new System.EventHandler(this.aleScrollBarV_Load);
            // 
            // aleScrollBarH
            // 
            this.aleScrollBarH.BorderSize = 2;
            this.aleScrollBarH.CornerRadius = 15;
            this.aleScrollBarH.Dock = System.Windows.Forms.DockStyle.Top;
            this.aleScrollBarH.GapBorderGrip = 2;
            this.aleScrollBarH.GripSize = 35;
            this.aleScrollBarH.IsAllowClickGoTo = false;
            this.aleScrollBarH.Location = new System.Drawing.Point(40, 0);
            this.aleScrollBarH.Maximum = 100;
            this.aleScrollBarH.Minimum = 0;
            this.aleScrollBarH.Mode = ALEControlLibrary.ALEScrollBar.EMode.Horizontal;
            this.aleScrollBarH.Name = "aleScrollBarH";
            this.aleScrollBarH.RoundedTag = ALEControlLibrary.ERoundedTag.None;
            this.aleScrollBarH.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleScrollBarH.Size = new System.Drawing.Size(1066, 40);
            this.aleScrollBarH.TabIndex = 1;
            this.aleScrollBarH.Value = 0;
            this.aleScrollBarH.ValueChanged += new System.EventHandler(this.aleScrollBarH_Load);
            // 
            // aleProgressH
            // 
            this.aleProgressH.BorderSize = 5;
            this.aleProgressH.Direction = ALEControlLibrary.CTRL.ALEProgressBar.EDirection.Horizontal;
            this.aleProgressH.ImgDecor = null;
            this.aleProgressH.ImgValue = null;
            this.aleProgressH.IsBorderVisible = true;
            this.aleProgressH.IsDebug = false;
            this.aleProgressH.IsImgValueIsOver = false;
            this.aleProgressH.IsTextVisisble = false;
            this.aleProgressH.Location = new System.Drawing.Point(105, 56);
            this.aleProgressH.Name = "aleProgressH";
            this.aleProgressH.PourcentBack = 1F;
            this.aleProgressH.PourcentFront = 1F;
            this.aleProgressH.PourcentValue = 0.25F;
            this.aleProgressH.Radius = 15;
            this.aleProgressH.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleProgressH.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleProgressH.Size = new System.Drawing.Size(976, 43);
            this.aleProgressH.TabIndex = 2;
            this.aleProgressH.Text = "aleProgressBar1";
            // 
            // aleProgressV
            // 
            this.aleProgressV.BorderSize = 5;
            this.aleProgressV.Direction = ALEControlLibrary.CTRL.ALEProgressBar.EDirection.Vertical;
            this.aleProgressV.ImgDecor = null;
            this.aleProgressV.ImgValue = null;
            this.aleProgressV.IsBorderVisible = true;
            this.aleProgressV.IsDebug = false;
            this.aleProgressV.IsImgValueIsOver = false;
            this.aleProgressV.IsTextVisisble = false;
            this.aleProgressV.Location = new System.Drawing.Point(46, 56);
            this.aleProgressV.Name = "aleProgressV";
            this.aleProgressV.PourcentBack = 1F;
            this.aleProgressV.PourcentFront = 1F;
            this.aleProgressV.PourcentValue = 0.25F;
            this.aleProgressV.Radius = 15;
            this.aleProgressV.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleProgressV.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleProgressV.Size = new System.Drawing.Size(42, 625);
            this.aleProgressV.TabIndex = 3;
            this.aleProgressV.Text = "aleProgressBar2";
            // 
            // aleProgressH2
            // 
            this.aleProgressH2.BorderSize = 5;
            this.aleProgressH2.Direction = ALEControlLibrary.CTRL.ALEProgressBar.EDirection.Horizontal;
            this.aleProgressH2.ImgDecor = global::LinkEatsApp.Properties.Resources.Etoiles_pleines;
            this.aleProgressH2.ImgValue = global::LinkEatsApp.Properties.Resources.Etoiles_pleines_Jaunes;
            this.aleProgressH2.IsBorderVisible = false;
            this.aleProgressH2.IsDebug = false;
            this.aleProgressH2.IsImgValueIsOver = true;
            this.aleProgressH2.IsTextVisisble = false;
            this.aleProgressH2.Location = new System.Drawing.Point(105, 155);
            this.aleProgressH2.Name = "aleProgressH2";
            this.aleProgressH2.PourcentBack = 1F;
            this.aleProgressH2.PourcentFront = 1F;
            this.aleProgressH2.PourcentValue = 0.25F;
            this.aleProgressH2.Radius = 15;
            this.aleProgressH2.RoundedTags = ALEControlLibrary.ERoundedTag.None;
            this.aleProgressH2.RoundedType = ALEControlLibrary.ERoundedType.All;
            this.aleProgressH2.Size = new System.Drawing.Size(976, 189);
            this.aleProgressH2.TabIndex = 4;
            this.aleProgressH2.Text = "aleProgressBar1";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1106, 693);
            this.Controls.Add(this.aleProgressH2);
            this.Controls.Add(this.aleProgressV);
            this.Controls.Add(this.aleProgressH);
            this.Controls.Add(this.aleScrollBarH);
            this.Controls.Add(this.aleScrollBarV);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private ALEControlLibrary.ALEScrollBar aleScrollBarV;
        private ALEControlLibrary.ALEScrollBar aleScrollBarH;
        private ALEControlLibrary.CTRL.ALEProgressBar aleProgressH;
        private ALEControlLibrary.CTRL.ALEProgressBar aleProgressV;
        private ALEControlLibrary.CTRL.ALEProgressBar aleProgressH2;
    }
}